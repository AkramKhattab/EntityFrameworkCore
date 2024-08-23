using EntityFrameworkCore.Configurations;
using EntityFrameworkCore.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCore.Contexts
{
    internal class CompanyG03DBContext : DbContext
    {

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration<Employee>(new EmployeeConfigurations());

            base.OnModelCreating(modelBuilder);
        }


          

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=Akram;Database=CompanyG03DB;Trusted_Connection=True;TrustServerCertificate=True"); 
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

    }
}
