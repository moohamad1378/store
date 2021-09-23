using System.Collections.Generic;

namespace Store_1.Application.Services.Users.Queries.GetUsers
{
    public class ReslutGetUserDto
    {
       public List<GetUsersDto> Users { get; set; }
       public int Rows { get; set; }
    }
}
