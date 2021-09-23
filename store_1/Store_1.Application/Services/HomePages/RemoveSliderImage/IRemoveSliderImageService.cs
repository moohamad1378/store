using Store_1.Application.Interfaces.Context;
using Store_1.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_1.Application.Services.HomePages.RemoveSliderImage
{
    public interface IRemoveSliderImageService
    {
        ResultDto Execute(long SliderId);
    }
    public class RemoveSliderImageService: IRemoveSliderImageService
    {
        private readonly IDataBaseContext _context;
        public RemoveSliderImageService (IDataBaseContext context)
        {
            _context = context;
        }

        public ResultDto Execute(long SliderId)
        {
            var sliderremove = _context.Sliders.Find(SliderId);
            sliderremove.RemoveTime = DateTime.Now;
            sliderremove.IsRemoved = true;
            _context.SaveChanges();
            return new ResultDto()
            {
                IsSuccess = true,
                Message="okay",

            };

        }
    }

}
