using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Store_1.Application.Interfaces.FacadPatterns;
using Store_1.Application.Services.Products.Queries.GetProductForSite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndPont.Site.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductFacad _productFacad;
        public ProductsController(IProductFacad productFacad)
        {
            _productFacad = productFacad;
        }
        // GET: ProductsController
        public ActionResult Index( Ordering ordering,string Searchkey,int page=1,long? CatId=null,int pageSize=20)
        {
            return View(_productFacad.GetProductForSiteService.Execute(ordering,Searchkey,page,CatId,pageSize).Data);
        }
        public IActionResult Detail(long Id)
        {
            return View(_productFacad.getProductDetailForSiteService.Execute(Id).Data);
        }
    }
}
