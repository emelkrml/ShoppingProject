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
        public ShoppingContext(DbContextOptions<ShoppingContext> options) : base(options)
        { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
