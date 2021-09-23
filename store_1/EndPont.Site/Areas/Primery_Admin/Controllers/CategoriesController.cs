using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Store_1.Application.Interfaces.FacadPatterns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndPont.Site.Areas.Primery_Admin.Controllers
{
    [Area("Primery_Admin")]
    public class CategoriesController : Controller
    {
        private readonly IProductFacad _productFacad;

        public CategoriesController(IProductFacad productFacad)
        {
            _productFacad = productFacad;
        }
        // GET: CategoriesController
        public ActionResult Index(long? parentId)
        {
            return View(_productFacad.GetCategoriesService.Execute(parentId).Data);
        }

      
       [HttpGet]
       public IActionResult AddNewCategory(long? parentId)
       {
            ViewBag.parentId = parentId;
            return View();
       }
       [HttpPost]
       public IActionResult AddNewCategory(long? parentId, string Name)
        {
            var result = _productFacad.addNewCategoryService.Execute(parentId, Name);
            return Json(result);
        }
        [HttpPost]
        public IActionResult Changethestatus(long CategoryId)
        {
            return Json(_productFacad.ChangethestatusofthecategoryService.Execute(CategoryId).Data);
        }
    }
}
