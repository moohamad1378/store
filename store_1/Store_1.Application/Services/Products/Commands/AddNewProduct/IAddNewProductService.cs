using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Store_1.Application.Interfaces.Context;
using Store_1.Common.Dto;
using Store_1.Domain.Entities.Products;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_1.Application.Services.Products.Commands.AddNewProduct
{
    public interface IAddNewProductService
    {
        ResultDto Execute(RequestAddNewProductDto request);
    }

    public class AddNewProductService : IAddNewProductService
    {
        private readonly IDataBaseContext _context;
        private readonly IHostingEnvironment _environment;

        public AddNewProductService(IDataBaseContext context,IHostingEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }

        public ResultDto Execute (RequestAddNewProductDto request)
        {
            try
            {
                var category = _context.Categories.Find(request.CategoryId);
                Product product = new Product()
                {
                    Brand = request.Brand,
                    Description = request.Description,
                    Name = request.Name,
                    Price = request.Price,
                    Inventory = request.Inventory,
                    Category = category,
                    Displayed = request.Displayed,
                };
                _context.products.Add(product);
                List<ProductImages> productImages = new List<ProductImages>();
                foreach (var item in request.Images)
                {
                    var UploadResult = UploadFile(item);
                    productImages.Add(new ProductImages
                    {
                        Product=product,
                        Src=UploadResult.FileNameAddress
                    });
                }
                _context.ProductImages.AddRange(productImages);
                List<ProductFeatures> productFeatures = new List<ProductFeatures>();
                foreach (var item in request.Features)
                {
                    productFeatures.Add(new ProductFeatures
                    {
                        DisplayName=item.DisplayedName,
                        value=item.value,
                        Product=product,
                    });
                }
                _context.ProductFeatures.AddRange(productFeatures);
                _context.SaveChanges();
                return new ResultDto
                {
                    IsSuccess = true,
                    Message = "Product successfully added to store products"
                };
            }
            catch (Exception Ex)
            {

                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "An error occurred",
                };
            }


        }

        private UploadDto UploadFile(IFormFile file)
        {
            if (file != null)
            {
                
                string folder = $@"images\ProductImages\";
              
                var uploadsRootFolder = Path.Combine(_environment.WebRootPath ,folder);
                
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
                using(var fileStream=new FileStream(filePath, FileMode.Create))
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
    public class RequestAddNewProductDto
    {
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int Inventory { get; set; }
        public long CategoryId { get; set; }
        public bool Displayed { get; set; }
        //فیلد نمایش محصول در سایت یا نه


        public List<IFormFile> Images { get; set; }
        public List<AddNewProduct_features> Features { get; set; }
    }
    public class AddNewProduct_features
    {
        public string DisplayedName { get; set; }
        public string value { get; set; }
    }
    public class UploadDto
    {
        public long Id { get; set; }
        public bool Status { get; set; }
        public string FileNameAddress { get; set; }
    }
}
