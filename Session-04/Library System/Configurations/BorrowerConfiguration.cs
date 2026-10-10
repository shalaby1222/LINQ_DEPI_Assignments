using System;
using System.Collections.Generic;
using System.Text;
using Library_System_DEPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library_System_DEPI.Configurations
{
    public class BorrowerConfiguration : IEntityTypeConfiguration<Borrower>
    {
        public void Configure(EntityTypeBuilder<Borrower> builder)
        {
            builder.HasKey(bo => bo.Id);

            builder.Property(bo => bo.Name)
                   .IsRequired()
                   .HasMaxLength(200);

            builder.Property(bo => bo.MembershipDate)
                   .IsRequired()
                   .HasMaxLength(50);

        }
    }
}
