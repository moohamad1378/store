using EndPont.Site.Models;
using EndPont.Site.Models.ViewModels.HomePages;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Store_1.Application.Interfaces.FacadPatterns;
using Store_1.Application.Services.Common.Queries.GetHomePageImages;
using Store_1.Application.Services.Common.Queries.GetSlider;
using Store_1.Application.Services.Products.Queries.GetProductForSite;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace EndPont.Site.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGetSliderService _getSliderService;
        private readonly ILogger<HomeController> _logger;
        private readonly IGetHomePageImagesService _homePageImagesService;
        private readonly IProductFacad _productFacad;

        public HomeController(ILogger<HomeController> logger, IGetSliderService getSliderService, IGetHomePageImagesService homePageImagesService
            ,IProductFacad productFacad)
        {
            _logger = logger;
            _getSliderService = getSliderService;
            _homePageImagesService = homePageImagesService;
            _productFacad = productFacad;

        }

        public IActionResult Index()
        {
            HomePagesViewModel homepage = new HomePagesViewModel()
            {
                Sliders = _getSliderService.Execute().Data,
                PageImages=_homePageImagesService.Execute().Data,
                Camera=_productFacad.GetProductForSiteService.Execute(Ordering.theNewest,null,1,6,25).Data.Products
                //عدد 25 بالا لیست محصولات هستش مثلا 25 کتگوری دوربین هستش که من ندارم هنوز
            };
            return View(homepage);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
