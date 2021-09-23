using Store_1.Common.Dto;
using System.Collections.Generic;
using static Store_1.Application.Services.Users.Queries.getRoles.GetRolesService;

namespace Store_1.Application.Services.Users.Queries.getRoles
{
    public interface IGetRolesService
    {
        ResultDto<List<RolesDto>> Execute();
    }
}
