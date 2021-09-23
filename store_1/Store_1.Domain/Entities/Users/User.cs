using Store_1.Domain.Commons;
using Store_1.Domain.Entities.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_1.Domain.Entities.Users
{
    public class User : BaseEntity
    {
        //public long Id { get; set; }
        //ما اینجا آیدی رو پلک میکنیم چون تو کلاس ابیترکت آیدی داره
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public ICollection<UserInRole> UserInroles { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
