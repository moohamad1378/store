using Microsoft.AspNetCore.Mvc;
using Store_1.Application.Services.Common.Queries.GetCategory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndPont.Site.ViewComponents
{
    public class Search:ViewComponent
    {
        private readonly IGetCategoryService _getCategoryService;
        public Search (IGetCategoryService getCategoryService)
        {
            _getCategoryService = getCategoryService;
        }
        public IViewComponentResult Invoke()
        {
            return View(viewName: "Search", _getCategoryService.ExeCute().Data);
        }
    }
    
}
