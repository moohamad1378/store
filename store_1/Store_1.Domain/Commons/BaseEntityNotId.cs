using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_1.Domain.Commons
{
    public abstract class BaseEntityNotId
    {
        //زمانی از این کلاس استفاده میکنیم که کلاسی که میخواد از این ارث بری کنه آیدی نداشته باشه

        public DateTime InsertTime { get; set; } = DateTime.Now;
        public DateTime? UpdateTime { get; set; }
        public bool IsRemoved { get; set; } = false;
        public DateTime? RemoveTime { get; set; }
    }
}
