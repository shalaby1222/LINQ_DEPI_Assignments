using System;
using System.Collections.Generic;
using System.Text;

namespace Library_System_DEPI.Models
{
    public class Loan
    {
        public int BookId { get; set; }
        public Book Book { get; set; }

        public int BorrowerId { get; set; }
        public Borrower Borrower { get; set; }

        public DateTime LoanDate { get; set; }
        public DateTime ReturnDate { get; set; }

    }
}
