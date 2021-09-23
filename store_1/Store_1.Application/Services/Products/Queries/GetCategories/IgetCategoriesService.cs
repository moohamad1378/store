﻿using Microsoft.EntityFrameworkCore;
using Store_1.Application.Interfaces.Context;
using Store_1.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_1.Application.Services.Products.Queries.GetCategories
{
    public interface IgetCategoriesService
    {
        ResultDto<List<CategoriesDto>> Execute(long? ParentId);
    }

    public class GetCategoriesService : IgetCategoriesService
    {
        private readonly IDataBaseContext _context;

        public GetCategoriesService(IDataBaseContext context)
        {
            _context = context;
        }

        public ResultDto<List<CategoriesDto>> Execute(long? ParentId)
        {
            var categories = _context.Categories
               .Include(p => p.ParentCategory)
               .Include(p => p.SubCategories)
               .Where(p => p.ParentCategoryId == ParentId)
               .ToList()
               .Select(p => new CategoriesDto
               {
                   Id = p.Id,
                   Name = p.Name,
                   Parent = p.ParentCategory != null ? new
                   ParentCategoryDto
                   {
                       Id = p.ParentCategory.Id,
                       name = p.ParentCategory.Name,
                   }
                   : null,
                   HasChild = p.SubCategories.Count() > 0 ? true : false,
               }).ToList();


            return new ResultDto<List<CategoriesDto>>()
            {
                Data = categories,
                IsSuccess = true,
                Message = "لیست باموقیت برگشت داده شد"
            };

        }
    }
    public class CategoriesDto
    {
        public long? ParentCategoryId { get; set; }
        public bool IsRemoved { get; set; }
        public long Id { get; set; }
        public string Name { get; set; }
        public bool HasChild { get; set; }
        public ParentCategoryDto Parent { get; set; }

    }
    public class ParentCategoryDto
    {
       
        public long Id { get; set; }
        public string name { get; set; }
    }
}
