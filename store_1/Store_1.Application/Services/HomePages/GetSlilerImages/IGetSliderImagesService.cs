using Store_1.Application.Interfaces.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_1.Application.Services.HomePages.GetSlilerImages
{
    public interface IGetSliderImagesService
    {
        ResultGetSliderImagesDto Execute();
    }
    public class GetSliderImagesService : IGetSliderImagesService
    {
        private readonly IDataBaseContext _context;
        public GetSliderImagesService(IDataBaseContext context)
        {
            _context = context;
        }

        public ResultGetSliderImagesDto Execute()
        {
            var imageforSliders = _context.Sliders.AsQueryable();
            var sliderLIstimage= imageforSliders.Select(p => new GetSliderImagesDto
            {
                Id = p.Id,
                Src = p.Src,
                link = p.link,
            }).ToList();
            return new ResultGetSliderImagesDto
            {
                SliderImage= sliderLIstimage,
            };
        }
    }
    public class ResultGetSliderImagesDto
    {
        public List<GetSliderImagesDto> SliderImage { get; set; }
    }
    public class GetSliderImagesDto
    {
        public long Id { get; set; }
        public string Src { get; set; }
        public string link { get; set; }
    }
}
