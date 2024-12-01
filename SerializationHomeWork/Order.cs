using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationHomeWork
{
    internal class Order
    {
        public int OrderId { get; set; }
        public string CostomerName { get; set; }
        public double TotalAmount { get; set; }
        public Status Status { get; set; }
        public OrderItem orderItem { get; set; }

    }

    enum Status
    {
        Pending = 1,
        Processing,
        Shipped,
        Delivered,
        Cancelled,
        Returned,
        Failed


    }
}
