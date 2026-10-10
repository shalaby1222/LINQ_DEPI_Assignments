using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bookstore_System.Models;
using Microsoft.EntityFrameworkCore;

namespace Bookstore_System.AppDbContext
{
    public class BookstoreDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=BookstoreDB;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Book>((book) =>
            {
                book.Property(b => b.Title)
                .IsRequired()
                .HasMaxLength(150);

                book.Property(b => b.Price)
                .HasColumnType("decimal(8,2)");

                book.Property(p => p.PublishedDate)
                .IsRequired(false);
            });
        }
    }

}
