using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Store_1.Application.Services.Users.Queries.GetUsers
{
    public interface IGetUserService
    {
        ReslutGetUserDto Execute(RequestGetUserDto Request);
    }
}
