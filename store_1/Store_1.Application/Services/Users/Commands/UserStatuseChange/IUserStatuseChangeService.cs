using Store_1.Application.Interfaces.Context;
using Store_1.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_1.Application.Services.Users.Commands.UserStatuseChange
{
    public interface IUserStatuseChangeService
    {
        ResultDto Execute(long UserId);
    }
    public class UserStatuseChangeService : IUserStatuseChangeService
    {
        private readonly IDataBaseContext _context;
        public UserStatuseChangeService(IDataBaseContext context)
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
                    IsSuccess = false,
                    Message = "کاربر یافت نشد"
                };
            }
                User.IsActive = !User.IsActive;
                //این کد بالا وضعیت را تغیر میدهد به وضعیت مخالف
                _context.SaveChanges();
                string userstate = User.IsActive == true ? " فعال  " : " غیر فعال ";
                //این کد بالا هم در متغیر استرینگ فعال یا غیر فعال را میزارد و ما به پایین پاسش میدیم
                return new ResultDto()
                {
                    IsSuccess = true,
                    Message = $"کاربر با موفقیت {userstate} شد ",

                };
        }
    }
}
