using Store_1.Domain.Commons;
using Store_1.Domain.Entities.Orders;
using Store_1.Domain.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_1.Domain.Entities.Finances
{
    public class RequestPay:BaseEntity
    {
        //از جی یو آیدی استفاده میکنیم که قابل حدث زدن نباشه

        public Guid Guid { get; set; }
        public virtual User User { get; set; }
        public long UserId { get; set; }

        public int Amount { get; set; }
        public bool IsPay { get; set; }
        public DateTime? PayDate { get; set; }
        //دو تا پراپرتی زیر را زرین پال به ما برگشت میده
        public string Authurity { get; set; }
        public long RefId { get; set; } = 0;

        public virtual ICollection<Order> Orders { get; set; }
    }
}
