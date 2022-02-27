using Microsoft.EntityFrameworkCore;
using ShoppingProject.Entity.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingProject.Data.Context
{
    public class ShoppingContext : DbContext
    {
        //public ShoppingContext() { }
        //public ShoppingContext(DbContextOptions options) : base(options)
        //{ }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=(localdb)\\MSSQLLocalDB;Database=Shopping;Trusted_Connection=True;MultipleActiveResultSets=true"
                );
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
