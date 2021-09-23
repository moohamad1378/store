using Store_1.Domain.Commons;

namespace Store_1.Domain.Entities.Products
{
    public class ProductFeatures:BaseEntity
    {
        public virtual Product Product { get; set; }
        public long productId { get; set; }
        public string DisplayName { get; set; }
        //برای مشخصات محصولات هستش  
        public string value { get; set; }
    }
}
