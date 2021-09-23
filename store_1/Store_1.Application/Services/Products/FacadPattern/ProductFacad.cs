using Microsoft.AspNetCore.Hosting;
using Store_1.Application.Interfaces.Context;
using Store_1.Application.Interfaces.FacadPatterns;
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

namespace Store_1.Application.Services.Products.FacadPattern
{
    public class ProductFacad : IProductFacad
    {
        private readonly IDataBaseContext _context;
        private readonly IHostingEnvironment _environment;
        public ProductFacad(IDataBaseContext context, IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            _environment = hostingEnvironment;
        }
        private AddNewCategoryService _addNewCategory;
        public AddNewCategoryService addNewCategoryService
        {
            get
            {
                return _addNewCategory = _addNewCategory ?? new AddNewCategoryService(_context);
            }
        }
        private IgetCategoriesService _getCateGoriesService;
        
        public IgetCategoriesService GetCategoriesService
        {
            get
            {
                return _getCateGoriesService = _getCateGoriesService ?? new GetCategoriesService(_context);
            }
        }
        private AddNewProductService _addNewProductService;
        public AddNewProductService addNewProductService
        {
            get
            {
                return _addNewProductService = _addNewProductService ?? new AddNewProductService(_context, _environment);
            }
        }
        private IGetAllCategoriesService _getAllCategoriesService;
        public IGetAllCategoriesService GetAllCategoriesService
        {
            get
            {
                return _getAllCategoriesService = _getAllCategoriesService ?? new GetAllCategoriesService(_context);
            }
        }
        private IGetProductForAdminService _GetProductForAdminService;

        public IGetProductForAdminService GetProductForAdminService
        {
            get
            {
                return _GetProductForAdminService = _GetProductForAdminService ?? new GetProductForAdminService(_context);
            }
        }
        private IGetProductDetailForAdminService _getProductDetailForAdminService;
        public IGetProductDetailForAdminService GetProductDetailForAdminService
        {
            get
            {
                return _getProductDetailForAdminService = _getProductDetailForAdminService ?? new GetProductDetailForAdminService(_context);
            }
        }

        private IGetProductForSiteService _getProductForSiteService;
        public IGetProductForSiteService GetProductForSiteService
        {
            get
            {
                return _getProductForSiteService = _getProductForSiteService ?? new GetProductForSiteService(_context);
            }
        }
       
        private IGetProductDetailForSiteService _getProductDetailForSiteService;
        public IGetProductDetailForSiteService getProductDetailForSiteService
        {
            get
            {
                return _getProductDetailForSiteService = _getProductDetailForSiteService ?? new GetProductDetailForSiteService(_context);
            }
        }
       
        
        private IChangethestatusofthecategoryService _ChangethestatusofthecategoryService;
        public IChangethestatusofthecategoryService ChangethestatusofthecategoryService
        {
            get
            {
                return _ChangethestatusofthecategoryService = _ChangethestatusofthecategoryService ?? new ChangethestatusofthecategoryService(_context);
            }
        }
    }
}
