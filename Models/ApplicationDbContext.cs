using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace web_app_1.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // base.OnConfiguring(optionsBuilder);

            //optionsBuilder.UseSqlServer("Server=localhost;Database=customerdb;Integrated Security=true;TrustServerCertificate=true");
            
            optionsBuilder.UseNpgsql("Host=localhost; Port=15432; Database=customer_db; Username=postgres; Password=password;");
        }
    }
}