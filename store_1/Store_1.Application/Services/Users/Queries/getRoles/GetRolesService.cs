using Store_1.Application.Interfaces.Context;
using System.Collections.Generic;
using System.Linq;
using Store_1.Common.Dto;

namespace Store_1.Application.Services.Users.Queries.getRoles
{
    public partial class GetRolesService: IGetRolesService
    {
        private readonly IDataBaseContext _context;
        public GetRolesService(IDataBaseContext context)
        {
            _context = context;
        }
        
        public ResultDto<List<RolesDto>> Execute()
        {
            var roles = _context.roles.ToList().Select(p => new RolesDto
            {
                Id = p.Id,
                Name = p.Name,

            }).ToList();
            return new ResultDto<List<RolesDto>>()
            {
                Data = roles,
                IsSuccess = true,
                Message = "",
            };
        }

    }
}
