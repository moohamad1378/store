using Microsoft.EntityFrameworkCore;
using Store_1.Application.Interfaces.Context;
using Store_1.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_1.Application.Services.Products.Queries.GetAllCategories
{
    public interface IGetAllCategoriesService
    {
        ResultDto<List<AllCategoriesDto>> Execute();
    }

    public class GetAllCategoriesService : IGetAllCategoriesService
    {
        private readonly IDataBaseContext _contxt;
        public GetAllCategoriesService(IDataBaseContext context)
        {
            _contxt = context;
        }
        public ResultDto<List<AllCategoriesDto>> Execute()
        {
            var categories = _contxt.Categories.Include(p => p.ParentCategory).Where(p => p.ParentCategoryId != null).ToList()
                .Select(p => new AllCategoriesDto
                {
                    Id = p.Id,
                    Name = $"{p.ParentCategory.Name} - {p.Name}",
                }).ToList();
            return new ResultDto<List<AllCategoriesDto>>
            {
                Data = categories,
                IsSuccess = true,
                Message = "",
            };
        }
    }
    public class AllCategoriesDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
    }
}
