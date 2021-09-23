using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Store_1.Application.Services.HomePages.AddNewSlider;
using Store_1.Application.Services.HomePages.GetSlilerImages;
using Store_1.Application.Services.HomePages.RemoveSliderImage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndPont.Site.Areas.Primery_Admin.Controllers
{
    [Area("Primery_admin")]
    public class SliderController : Controller
    {
        private readonly IGetSliderImagesService _getSliderImagesService;
        private readonly IAddNewSliderService _addNewSliderService;
        private readonly IRemoveSliderImageService _removeSliderImageService;
        public SliderController(IAddNewSliderService addNewSliderService,IGetSliderImagesService getSliderImagesService,IRemoveSliderImageService removeSliderImageService)
        {
            _addNewSliderService = addNewSliderService;
            _getSliderImagesService = getSliderImagesService;
            _removeSliderImageService = removeSliderImageService;
        }

        public IActionResult Index()
        {//تمرین نمایش لیست اسلایدر ها
            return View(_getSliderImagesService.Execute());
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(IFormFile file,string link)
        {
            _addNewSliderService.Execute(file, link);
            return View();
        }

        [HttpPost]
        public IActionResult Remove(long SliderId)
        {
            return Json(_removeSliderImageService.Execute(SliderId));
        }
    }
}
