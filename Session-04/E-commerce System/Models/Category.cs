using System;
using System.Collections.Generic;
using System.Text;

namespace E_commerce_System_DEPI.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();
    }
}
