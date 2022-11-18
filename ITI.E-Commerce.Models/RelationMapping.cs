using ITI.E_Commerce.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ITI.E_Commerce
{
    public static class RelationMapping 
    {
        public static void MappRelationships(this ModelBuilder builder)
        {
            builder.Entity<Product>().
                    HasOne(i => i.Category)
                    .WithMany(i => i.Products).HasForeignKey(i => i.CategoryID)
                    .IsRequired().OnDelete(DeleteBehavior.Cascade);

            builder.Entity<ProductInStock>().
                HasOne(i => i.Products)
                .WithMany(i => i.ProductInStocks).HasForeignKey(i => i.ProductID)
                .IsRequired().OnDelete(DeleteBehavior.Cascade);

            builder.Entity<ProductInStock>().
               HasOne(i => i.Stores)
               .WithMany(i => i.ProductInStocks).HasForeignKey(i => i.StoreID)
               .IsRequired().OnDelete(DeleteBehavior.Cascade);

            builder.Entity<ProductImages>().
             HasOne(i => i.Products)
             .WithMany(i => i.ProductImages).HasForeignKey(i => i.ProductID)
             .IsRequired().OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Order>().HasOne(i => i.Shippers).WithMany(i => i.Orders)
                .HasForeignKey(i => i.ShipperID)
                .IsRequired().OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Order>().HasOne(i => i.Customers).WithMany(i => i.Orders)
               .HasForeignKey(i => i.CustomerID)
               .IsRequired().OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Order>().HasOne(i => i.Stores).WithMany(i => i.Orders)
               .HasForeignKey(i => i.StoreID)
               .IsRequired().OnDelete(DeleteBehavior.Cascade);

            builder.Entity<OrderDetails>().HasOne(i => i.Products).WithMany(i => i.OrderDetails)
            .HasForeignKey(i => i.ProductID)
            .IsRequired().OnDelete(DeleteBehavior.Cascade);

            builder.Entity<OrderDetails>().HasOne(i => i.Orders).WithMany(i => i.OrderDetails)
            .HasForeignKey(i => i.OrderID)
            .IsRequired().OnDelete(DeleteBehavior.Cascade);






        }
    }
}
