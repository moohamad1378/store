﻿using Store_1.Application.Interfaces.Context;
using Store_1.Common.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_1.Application.Services.Common.Queries.GetSlider
{
    public interface IGetSliderService
    {
        ResultDto<List<SliderDto>> Execute();
    }
    public class GetSliderService : IGetSliderService
    {
        private readonly IDataBaseContext _context;
        public GetSliderService(IDataBaseContext context)
        {
            _context = context;
        }
        public ResultDto<List<SliderDto>> Execute()
        {//طبق کد زیر اسلایدر هارو به ترتیب آخرین میگیریم
            var sliders = _context.Sliders.OrderByDescending(p => p.Id).ToList()
                .Select(p => new SliderDto
                {
                    Link = p.link,
                    Src = p.Src
                }).ToList();
            return new ResultDto<List<SliderDto>>()
            {
                Data = sliders,
                IsSuccess = true,
            };
        }
    }
    public class SliderDto
    {
        public string Src { get; set; }
        public string Link { get; set; }
    }
}
