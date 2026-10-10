using System;
using System.Collections.Generic;
using System.Text;

namespace E_commerce_System_DEPI.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public List<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

    }
}
