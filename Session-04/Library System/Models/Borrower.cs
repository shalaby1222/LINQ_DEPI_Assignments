using System;
using System.Collections.Generic;
using System.Text;

namespace Library_System_DEPI.Models
{
    public class Borrower
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime MembershipDate { get; set; }

        public List<Loan> Loans { get; set; } = new List<Loan>();


    }
}
