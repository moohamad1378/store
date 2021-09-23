﻿using Microsoft.EntityFrameworkCore;
using Store_1.Application.Interfaces.Context;
using Store_1.Common.Dto;
using Store_1.Domain.Entities.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_1.Application.Services.Products.Queries.GetProductDetailForAdmin
{
    public interface IGetProductDetailForAdminService
    {
        ResultDto<ProductDetailForAdmindto> Execute(long Id);
    }
    public class GetProductDetailForAdminService : IGetProductDetailForAdminService
    {
        private readonly IDataBaseContext _context;
        public GetProductDetailForAdminService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultDto<ProductDetailForAdmindto> Execute(long Id)
        {
            var product = _context.products.Include(p => p.Category)
                 .ThenInclude(p => p.ParentCategory)
                 .Include(p => p.ProductFeatures)
                 .Include(p => p.ProductImages)
                 .Where(p => p.Id == Id)
                 .FirstOrDefault();
            return new ResultDto<ProductDetailForAdmindto>()
            {
                Data = new ProductDetailForAdmindto()
                {
                    Brand = product.Brand,
                    Category = GetCategory(product.Category),
                    Description = product.Description,
                    Displayed = product.Displayed,
                    Id = product.Id,
                    Inventory = product.Inventory,
                    Name = product.Name,
                    Price = product.Price,
                    Features = product.ProductFeatures.ToList().Select(p => new ProductDetailFeatureDto
                    {
                        Id = p.Id,
                        DisplayName = p.DisplayName,
                        Value = p.value
                    }).ToList(),
                    Images = product.ProductImages.ToList().Select(p => new ProductDetailImagesDto
                    {
                        ID = p.Id,
                        Src = p.Src,
                    }).ToList(),
                },
                IsSuccess = true,
                Message = ""
            };
        }

        private string GetCategory(Category category)
        {
            string result = category.ParentCategory != null ? $"{category.ParentCategory.Name} - " : "";
            return result += category.Name;
        }
    }
    public class ProductDetailForAdmindto
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Brand { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int Inventory { get; set; }
        public bool Displayed { get; set; }
        public List<ProductDetailFeatureDto> Features { get; set; }
        public List<ProductDetailImagesDto> Images { get; set; }
    }
    public class ProductDetailImagesDto
    {
        public long ID { get; set; }
        public string Src { get; set; }
    }
    public class ProductDetailFeatureDto
    {
        public long Id { get; set; }
        public string DisplayName { get; set; }
        public string Value { get; set; }
    }
}
