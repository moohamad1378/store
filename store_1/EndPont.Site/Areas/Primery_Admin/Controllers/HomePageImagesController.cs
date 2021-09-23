using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Store_1.Application.Interfaces.Context;
using Store_1.Application.Services.HomePages.AddHomePageImages;
using Store_1.Domain.Entities.HomePage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndPont.Site.Areas.Primery_Admin.Controllers
{
    [Area("Primery_admin")]
    public class HomePageImagesController : Controller
    {
        private readonly IDataBaseContext _context;
        private readonly IAddHomePageImagesService _addHomePageImagesService;
        public HomePageImagesController(IDataBaseContext context,IAddHomePageImagesService addHomePageImagesService)
        {
            _addHomePageImagesService = addHomePageImagesService;
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]

        public IActionResult Add(IFormFile file,string link,ImageLocation imageLocation )
        {
            _addHomePageImagesService.Execute(new requestAddHomePageImagesDto
            {

                file = file,
                ImageLocation = imageLocation,
                Link = link,
            });

            return View();
        }
    
    
    
    
    
    }   
  
}
