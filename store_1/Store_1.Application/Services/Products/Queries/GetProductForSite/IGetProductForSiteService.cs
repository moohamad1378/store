using Microsoft.EntityFrameworkCore;
using Store_1.Application.Interfaces.Context;
using Store_1.Common;
using Store_1.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_1.Application.Services.Products.Queries.GetProductForSite
{
    public interface IGetProductForSiteService
    {

        //همیه اول میریم کلاس دی تی او رو میسازیم یعمی پروداکت فور سایت دی تی او
        // بعد ریزالت دی تی او
        ResultDto<ResultProductForSiteDto> Execute( Ordering ordering,string Searchkey, int Page,long? CatId,int pageSize);
    }
    public class GetProductForSiteService : IGetProductForSiteService
    {
        private readonly IDataBaseContext _context;
        public GetProductForSiteService(IDataBaseContext context)
        {
            _context = context;
        }

        public ResultDto<ResultProductForSiteDto> Execute(Ordering ordering, string Searchkey, int Page, long? CatId, int pageSize)
        {
            int totalRow = 0;
            var productQuery = _context.products
                .Include(p => p.ProductImages).AsQueryable();
            if (CatId != null)
            {
                productQuery = productQuery.Where(p => p.CategoryId == CatId||p.Category.ParentCategoryId==CatId).AsQueryable();
            }
            if (!string.IsNullOrWhiteSpace(Searchkey))
            {
                productQuery = productQuery.Where(p => p.Name.Contains(Searchkey) || p.Brand.Contains(Searchkey)).AsQueryable();
            }
            switch (ordering)
            {
                case Ordering.NotOrder:
                    productQuery = productQuery.OrderByDescending(p => p.Id).AsQueryable();
                    break;
                case Ordering.MostVisited:
                    productQuery = productQuery.OrderByDescending(p => p.ViewCount).AsQueryable();
                    break;
                case Ordering.Bestselling:
                    break;
                case Ordering.MostPopular:
                    break;
                case Ordering.theNewest:
                    productQuery = productQuery.OrderByDescending(p => p.Id).AsQueryable();
                    break;
                case Ordering.Cheapest:
                    productQuery = productQuery.OrderBy(p => p.Price).AsQueryable();
                    break;
                case Ordering.theMostExpensive:
                    productQuery = productQuery.OrderByDescending(p => p.Price).AsQueryable();
                    break;
                default:
                    break;
            }
            var Product=productQuery.ToPaged(Page, pageSize, out totalRow);
            Random rd = new Random();
            return new ResultDto<ResultProductForSiteDto>
            {
                Data = new ResultProductForSiteDto
                {
                    TotalRow = totalRow,
                    Products = Product.Select(p => new ProductForSiteDto
                    {
                        Id = p.Id,
                        Star = rd.Next(1, 5),
                        Title = p.Name,
                        ImageSrc = /*p.ProductImages.FirstOrDefault().Src,*/p.ProductImages.Select(pi => pi.Src).FirstOrDefault(),
                        //p.ProductImages.FirstOrDefault()?.Src//با این کد هم درست میشه
                        Price = p.Price,
                    }).ToList(),
                },
                IsSuccess = true,
            };
        }
    }
    public class ResultProductForSiteDto
    {
        public List<ProductForSiteDto> Products { get; set; }
        public int TotalRow { get; set; }
    }
    public class ProductForSiteDto
    {
        public long Id { get; set; }
        public string Title{ get; set; }
        public string ImageSrc { get; set; }
        public int Star { get; set; }
        public int Price { get; set; }
    }
    public enum Ordering
    {
        NotOrder = 0,
        /// <summary>
        /// پربازدیدترین
        /// </summary>
        MostVisited = 1,
        /// <summary>
        /// پرفروشترین
        /// </summary>
        Bestselling = 2,
        /// <summary>
        /// محبوبترین
        /// </summary>
        MostPopular = 3,
        /// <summary>
        /// جدیدترین
        /// </summary>
        theNewest = 4,
        /// <summary>
        /// ارزانترین
        /// </summary>
        Cheapest = 5,
        /// <summary>
        /// گرانترین
        /// </summary>
        theMostExpensive = 6
    }

}
