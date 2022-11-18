using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ITI.E_Commerce.Models
{
    public class MyContext : IdentityDbContext<Customer>
    {
        public MyContext(DbContextOptions options) : base(options) {}



        public DbSet<Category> Categories { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<ProductImages> ProductImages { get; set; }

        public DbSet<ProductInStock> ProductInStocks { get; set; }

        public DbSet<Shipper> Shippers { get; set; } 
        
        public DbSet<Stores> Stores { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new CategoryConfiguration().Configure(modelBuilder.Entity<Category>());
            new OrderConfiguration().Configure(modelBuilder.Entity<Order>());
            new OrderDetailsConfiguration().Configure(modelBuilder.Entity<OrderDetails>());
            new ProductConfiguration().Configure(modelBuilder.Entity<Product>());
            new ProductInStockConfiguration().Configure(modelBuilder.Entity<ProductInStock>());
            new ProductImagesConfiguration().Configure(modelBuilder.Entity<ProductImages>());
            new ShipperConfiguration().Configure(modelBuilder.Entity<Shipper>());
            new StoresConfiguration().Configure(modelBuilder.Entity<Stores>());


            modelBuilder.MappRelationships();
            base.OnModelCreating(modelBuilder);
        }


        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseLazyLoadingProxies()
        //        .UseSqlServer("Data Source=.; Initial Catalog= E-Commerce; Integrated Security=True;");
        //}


    }
}
