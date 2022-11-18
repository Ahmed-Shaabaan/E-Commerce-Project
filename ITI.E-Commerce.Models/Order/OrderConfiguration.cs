using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.E_Commerce.Models
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(x=>x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.OrderDate).IsRequired();
            builder.Property(x => x.CustomerID).IsRequired();
            builder.Property(x => x.DeliveryCost).IsRequired();
            builder.Property(x => x.ShippedDate).IsRequired();
            builder.Property(x => x.ShippingAddress).IsRequired();
            builder.Property(x => x.StoreID).IsRequired();


        }
    }
}
