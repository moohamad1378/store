using Microsoft.EntityFrameworkCore;
using Store_1.Application.Interfaces.Context;
using Store_1.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_1.Application.Services.Products.Queries.GetProductDetailForSite
{
    public interface IGetProductDetailForSiteService
    {
        ResultDto<ProductDetailForSiteDto> Execute(long Id);
    }
    public class GetProductDetailForSiteService : IGetProductDetailForSiteService
    {
        private readonly IDataBaseContext _context;
        public GetProductDetailForSiteService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultDto<ProductDetailForSiteDto> Execute(long Id)
        {
            //زمانی که از اینکلود و زن انیکلود استفاده میکنیم دیگر نمیتوانیم از فایند استفاده کنیم 
            var Product = _context.products
                .Include(p => p.Category)
                .ThenInclude(p => p.ParentCategory)
                .Include(p=>p.ProductImages)
                .Include(p=>p.ProductFeatures)
                //.Find(Id);
                .Where(p => p.Id == Id).FirstOrDefault();
            if (Product == null)
            {
                throw new Exception("Product Not Found.... ");
            }
            Product.ViewCount++;
            _context.SaveChanges();
            //با کد بالا هر وقت که یک نفر روی دیتایلز کلیک کرد یک دونه عدد به ویو کانت اضافه میشه برای پر بازدید ها اینکارو میکنیم
            return new ResultDto<ProductDetailForSiteDto>()
            {
                Data = new ProductDetailForSiteDto
                {
                    Brand = Product.Brand,
                    Category = $"{ Product.Category.ParentCategory.Name } - {Product.Category.Name}",
                    Description = Product.Description,
                    Id = Product.Id,
                    Price = Product.Price,
                    Title = Product.Name,
                    Images = Product.ProductImages.Select(p => p.Src).ToList(),
                    //فیچر چون از لیست هستش نیو میکنیم
                    Features = Product.ProductFeatures.Select(p => new ProductDetailForSite_FeaturesDto
                    {
                        DisplayName = p.DisplayName,
                        Value = p.value,
                    }).ToList(),

                },
                IsSuccess = true,

            };
        }
    }
    public class ProductDetailForSiteDto
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Brand { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
      public List<string> Images { get; set; }
        public List<ProductDetailForSite_FeaturesDto> Features { get; set; }
    }
    public class ProductDetailForSite_FeaturesDto
    {
        public string DisplayName { get; set; }

        public string Value { get; set; }
    }
}
