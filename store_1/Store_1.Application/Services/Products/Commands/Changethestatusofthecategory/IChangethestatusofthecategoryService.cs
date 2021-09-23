using Microsoft.EntityFrameworkCore;
using Store_1.Application.Interfaces.Context;
using Store_1.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_1.Application.Services.Products.Commands.Changethestatusofthecategory
{
    
    public interface IChangethestatusofthecategoryService
    {
        ResultDto<CategoriesDto> Execute(long CategoryId);
    }
    public class ChangethestatusofthecategoryService : IChangethestatusofthecategoryService
    {
        private readonly IDataBaseContext _context;
        public ChangethestatusofthecategoryService(IDataBaseContext context)
        {
            _context = context;
        }

        public ResultDto<CategoriesDto> Execute(long CategoryId )
        {
            var category = _context.Categories.Find(CategoryId);
            
            




            if (category == null)
            {
                return new ResultDto<CategoriesDto>
                {
                    IsSuccess = false,
                    Message = "Categry Not Found"
                };
            }
            ChangecategoryparentId(CategoryId);
            category.RemoveTime = DateTime.Now;
            category.IsRemoved = !category.IsRemoved;
           
            _context.SaveChanges();
            return new ResultDto<CategoriesDto>
            {
                IsSuccess = true,
                Message = "Change status Success"
            };
        }
        private void ChangecategoryparentId(long CategoryId)
        {
            var ChangecategoryparentId = _context.Categories.Where(p => p.ParentCategoryId == CategoryId).ToList();
            foreach (var item in ChangecategoryparentId)
            {
                if (item.IsRemoved == false)
                {
                    item.IsRemoved = !item.IsRemoved;
                    item.RemoveTime = DateTime.Now;
                }

            }

        }
    }
    public class CategoriesDto
    {
        public long? ParentCategoryId { get; set; }
        public long CategoryId { get; set; }
    }
}
