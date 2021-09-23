using Store_1.Application.Interfaces.Context;
using Store_1.Common.Dto;
using System;

namespace Store_1.Application.Services.Users.Commands.RemoveUser
{
    public class RemoveUserService : IRemoveUserService
    {
        private readonly IDataBaseContext _context;
        public RemoveUserService(IDataBaseContext context)
        {
            _context = context;
        }

        public ResultDto Execute(long UserId)
        {
            var User = _context.users.Find(UserId);
            if (User == null)
            {
                return new ResultDto
                {
                    IsSuccess=false,
                    Message="کاربر یافت نشد"
                };
            }
            User.RemoveTime = DateTime.Now;
            User.IsRemoved = true;
            _context.SaveChanges();
            return new ResultDto()
            {
                IsSuccess = true,
                Message = "کاربر با موفقیت حذف شد"
            };
        }
    }
}
