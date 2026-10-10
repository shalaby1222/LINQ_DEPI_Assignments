using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore_System.Models
{
    public class Book
    {
        /*
         Q1 =>  EF Core recognizes properties named Id or BookId
         as the primary key by convention.

         Q2 =>  Country is a nullable reference type, while Price
         is a non-nullable value type (decimal).
        */
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public DateTime? PublishedDate { get; set; }
    }
}
