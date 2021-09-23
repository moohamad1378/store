using Store_1.Domain.Commons;
using Store_1.Domain.Entities.Finances;
using Store_1.Domain.Entities.Products;
using Store_1.Domain.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_1.Domain.Entities.Orders
{
    public class Order:BaseEntity
    {
        public virtual User User { get; set; }
        public long UserId { get; set; }

        public virtual RequestPay RequestPay { get; set; }
        public long RequestPayId { get; set; }

        public orderState orderState { get; set; }

        public string Address { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }

    public class OrderDetail : BaseEntity
    {
        public virtual Order Order { get; set; }
        public long OrderId { get; set; }


        public virtual Product Product { get; set; }
        public long ProductId { get; set; }

        public int Price { get; set; }

        public int Count { get; set; }
    }

    public enum orderState
    {
        Processing=0,
        Canceled=1,
        Delivered=2,
    }
}
