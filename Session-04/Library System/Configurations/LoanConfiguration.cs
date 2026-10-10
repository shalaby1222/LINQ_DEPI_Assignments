using System;
using System.Collections.Generic;
using System.Text;
using Library_System_DEPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library_System_DEPI.Configurations
{
    public class LoanConfiguration : IEntityTypeConfiguration<Loan>
    {
        public void Configure(EntityTypeBuilder<Loan> builder)
        {
            builder.HasKey(l => new { l.BookId, l.BorrowerId });

            builder.HasOne(l => l.Book)
                .WithMany(b => b.Loans)
                .HasForeignKey(l => l.BookId);

            builder.HasOne(l => l.Borrower)
                .WithMany(bo => bo.Loans)
                .HasForeignKey(l => l.BorrowerId);
        }
    }
}
