using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Health_Care_System_DEPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Health_Care_System_DEPI.AppDbContext
{
    public class HealthCareDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=HealthCareDB;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Appointment> Appointments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }

}
