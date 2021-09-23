using Store_1.Application.Services.Common.Queries.GetHomePageImages;
using Store_1.Application.Services.Common.Queries.GetSlider;
using Store_1.Application.Services.Products.Queries.GetProductForSite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndPont.Site.Models.ViewModels.HomePages
{
    public class HomePagesViewModel
    {
        public List<SliderDto> Sliders { get; set; }
        public List<HomePageImagesDto> PageImages { get; set; }
        public List<ProductForSiteDto> Camera { get; set; }
    }
}
