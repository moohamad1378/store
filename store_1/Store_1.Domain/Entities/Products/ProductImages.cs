using Store_1.Domain.Commons;

namespace Store_1.Domain.Entities.Products
{
    public class ProductImages: BaseEntity
    {//برای ذخیره آدرس تصویر
        public virtual Product Product { get; set; }
        public long productId { get; set; }
        public string Src { get; set; }
    }
}
