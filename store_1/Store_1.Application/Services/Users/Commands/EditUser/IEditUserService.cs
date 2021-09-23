using Store_1.Application.Interfaces.Context;
using Store_1.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_1.Application.Services.Users.Commands.EditUser
{
    public interface IEditUserService
    {
        ResultDto Execute(RequestEdituserDto request);
    }
    public class EditUserService: IEditUserService
    {
        private readonly IDataBaseContext _context;
        public EditUserService(IDataBaseContext dataBaseContex)
        {
            _context = dataBaseContex;
        }

        public ResultDto Execute(RequestEdituserDto request)
        {
            var User = _context.users.Find(request.UserId);
                if (User == null)
                {
                return new ResultDto
                   {
                    IsSuccess = false,
                    Message = "User not Found"
                   };
                }
            User.FullName = request.fullname;
            _context.SaveChanges();
            return new ResultDto()
            {
                IsSuccess = true,
                Message = "User Edited"
            };
        }
    }
    public class RequestEdituserDto
    {
        public long UserId { get; set; }
        public string fullname { get; set; }
    }
}
