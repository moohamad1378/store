using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Store_1.Application.Services.Users.commands.RegisterUser;
using Store_1.Application.Services.Users.Commands.EditUser;
using Store_1.Application.Services.Users.Commands.RemoveUser;
using Store_1.Application.Services.Users.Commands.UserStatuseChange;
using Store_1.Application.Services.Users.Queries.getRoles;
using Store_1.Application.Services.Users.Queries.GetUsers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace EndPont.Site.Areas.Primery_Admin.Controllers
{
     
    [Area("Primery_Admin")]
    public class UsersController : Controller
    {
        private readonly IGetUserService _getUserService;
        private readonly IGetRolesService _getRolesService;
        private readonly IRegisterUserService _registerUserService;
        private readonly IRemoveUserService _removeUserService;
        private readonly IUserStatuseChangeService _userStatuseChangeService;
        private readonly IEditUserService _editUserService;
        public UsersController(IGetUserService getUserService, IGetRolesService getRolesService, IRegisterUserService registerUserService,IRemoveUserService removeUserService, IUserStatuseChangeService userStatuseChangeService
            , IEditUserService editUserService)
        {
            _getUserService = getUserService;
            _getRolesService = getRolesService;
            _registerUserService = registerUserService;
            _removeUserService = removeUserService;
            _userStatuseChangeService = userStatuseChangeService;
            _editUserService = editUserService;
        }
        public IActionResult Index(string serchkey, int page = 1)
        {
        return View(_getUserService.Execute(new RequestGetUserDto
        { 
            Page=page,
            SearchKey=serchkey,
         }));
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Roles = new SelectList(_getRolesService.Execute().Data, "Id", "Name");
            return View();
        }
        [HttpPost]
        public IActionResult Create(string Email, string FullName, long RoleId, string Password, string RePassword)
        {//کلاینت این متود رو صدا میزنه و این متود رجیستر یوزر رو صدا میزنه
            var result = _registerUserService.Execute(new RequestRegisterUserDto
            {
                Email = Email,
                FullName = FullName,
                roles = new List<RolesInRegisterUserDto>()
                {
                    new RolesInRegisterUserDto
                    {
                        Id=RoleId
                    }
                },
                Password = Password,
                RePassword = RePassword

            });
            return Json(result);
        }


        [HttpPost]
        public IActionResult Delete(long UserId)
        {
            return Json(_removeUserService.Execute(UserId));
        }
        [HttpPost]
        public IActionResult UserStatuseChange(long UserId)
        {
            return Json(_userStatuseChangeService.Execute(UserId));
        }
        [HttpPost]
        public IActionResult EditUser(long UserId, string fullname)
        {
            return Json(_editUserService.Execute(new RequestEdituserDto 
            { 
            
            fullname=fullname,
            UserId=UserId,
            
            }));
        }
    }
}
