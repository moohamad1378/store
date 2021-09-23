using Store_1.Application.Services.Products.Commands.AddNewCategoryService;
using Store_1.Application.Services.Products.Commands.AddNewProduct;
using Store_1.Application.Services.Products.Commands.Changethestatusofthecategory;

using Store_1.Application.Services.Products.Queries.GetAllCategories;
using Store_1.Application.Services.Products.Queries.GetCategories;
using Store_1.Application.Services.Products.Queries.GetProductDetailForAdmin;
using Store_1.Application.Services.Products.Queries.GetProductDetailForSite;
using Store_1.Application.Services.Products.Queries.GetProductForAdmin;
using Store_1.Application.Services.Products.Queries.GetProductForSite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_1.Application.Interfaces.FacadPatterns
{
    public interface IProductFacad
    {
        AddNewCategoryService addNewCategoryService { get; }
        IgetCategoriesService GetCategoriesService { get; }
        AddNewProductService addNewProductService { get; }
       IGetAllCategoriesService GetAllCategoriesService { get; }
        /// <summary>
        /// گرفتن لیست محصولات برای ادمین
        /// </summary>
        IGetProductForAdminService GetProductForAdminService { get; }

        IGetProductDetailForAdminService GetProductDetailForAdminService { get; }
        IGetProductForSiteService GetProductForSiteService { get; }

        IGetProductDetailForSiteService getProductDetailForSiteService { get; }
        IChangethestatusofthecategoryService ChangethestatusofthecategoryService { get; }
    }
}
