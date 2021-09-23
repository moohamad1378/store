﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Store_1.Application.Interfaces.Context;
using Store_1.Application.Services.Products.Commands.AddNewProduct;
using Store_1.Common.Dto;
using Store_1.Domain.Entities.HomePage;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_1.Application.Services.HomePages.AddNewSlider
{
    public interface IAddNewSliderService
    {
        ResultDto Execute(IFormFile file,string Link);
    }

    public class AddNewSliderService : IAddNewSliderService
    {
        private readonly IDataBaseContext _context;
        private readonly IHostingEnvironment _environment;
        public AddNewSliderService(IDataBaseContext context,IHostingEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }
        public ResultDto Execute(IFormFile file, string Link)
        {
            var resultUpload= UploadFile(file);

            Slider slider = new Slider()
            {
                link = Link,
                Src = resultUpload.FileNameAddress,
            };
            _context.Sliders.Add(slider);
            _context.SaveChanges();
            return new ResultDto()
            {
                IsSuccess = true,

            };
        }

        private UploadDto UploadFile(IFormFile file)
        {
            if (file != null)
            {

                string folder = $@"images\HomePages\Sliders\";

                var uploadsRootFolder = Path.Combine(_environment.WebRootPath, folder);

                if (!Directory.Exists(uploadsRootFolder))
                {
                    Directory.CreateDirectory(uploadsRootFolder);
                }
                if (file == null || file.Length == 0)
                {
                    return new UploadDto()
                    {
                        Status = false,
                        FileNameAddress = "",

                    };
                }
                string fileName = DateTime.Now.Ticks.ToString() + file.FileName;
                var filePath = Path.Combine(uploadsRootFolder, fileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                //با دستورات بالا یک عدد به ابتدای فایل اضافه میکند
                {
                    file.CopyTo(fileStream);
                }
                return new UploadDto()
                {
                    FileNameAddress = folder + fileName,
                    Status = true,
                };
            }
            return null;

        }
    }
    
}
