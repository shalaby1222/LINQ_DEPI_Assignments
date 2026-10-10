using System;
using System.Collections.Generic;
using System.Text;

namespace E_commerce_System_DEPI.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<Order> Orders { get; set; } = new List<Order>();
    }
}
