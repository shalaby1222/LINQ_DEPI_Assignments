using System;
using System.Collections.Generic;
using System.Text;

namespace Library_System_DEPI.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }

        public int AuthorId { get; set; }
        public Author Author { get; set; }

        public List<Loan> Loans { get; set; } = new List<Loan>();
    }
}
