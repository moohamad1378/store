using Microsoft.EntityFrameworkCore;
using Store_1.Application.Interfaces.Context;
using Store_1.Common;
using Store_1.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_1.Application.Services.Users.Commands.UserLogin
{
    public interface IUserLoginService
    {
        ResultDto<ResultUserLoginDtio> Execute(string UserName, string Password);
    }
    public class UserLoginService : IUserLoginService
    {
        private readonly IDataBaseContext _Context;
        public UserLoginService(IDataBaseContext Context)
        {
            _Context = Context;
        }
        public ResultDto<ResultUserLoginDtio> Execute(string UserName, string Password)
        {
            if (string.IsNullOrWhiteSpace(UserName) || string.IsNullOrWhiteSpace(Password))
            {
                return new ResultDto<ResultUserLoginDtio>()
                {
                    Data = new ResultUserLoginDtio()
                    {

                    },
                    IsSuccess = false,
                    Message = "نام کاربری و رمز عبور را وارد نمایید",
                };
            }
            var user = _Context.users
                 .Include(p => p.UserInroles)
                 .ThenInclude(p => p.Role)
                 .Where(p => p.Email.Equals(UserName) && p.IsActive == true).FirstOrDefault();
            if (user == null)
            {
                return new ResultDto<ResultUserLoginDtio>()
                {
                    Data = new ResultUserLoginDtio
                    {

                    },
                    IsSuccess = false,
                    Message = "کاربری با این ایمیل در سایت فروشگاه  ثبت نام نکرده است",
                };
            }
            var passwordhasher = new PasswordHasher();
            bool resultVerfryPassword = passwordhasher.VerifyPassword(user.Password, Password);
            if (resultVerfryPassword == false)
            {
                return new ResultDto<ResultUserLoginDtio>()
                {
                    Data = new ResultUserLoginDtio
                    {

                    },
                    IsSuccess = false,
                    Message = "رمز وارد شده اشتباه است",
                };
            }
            List<string> roles = new List<string>();
            foreach (var item in user.UserInroles)
            {
                roles.Add(item.Role.Name);
            }
            return new ResultDto<ResultUserLoginDtio>()
            {
                Data = new ResultUserLoginDtio()
                {
                    Roles = roles,
                    UserId = user.Id,
                    Name = user.FullName
                },
                IsSuccess=true,
                Message="ورود به سایت با موفقیت انجام شد"
            };
        }
    }
    public class ResultUserLoginDtio
    {
        public long UserId { get; set; }
        public List<string> Roles { get; set; }
        public string  Name { get; set; }
    }
}
