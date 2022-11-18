using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.E_Commerce.Models
{
    internal class ProductInStockConfiguration : IEntityTypeConfiguration<ProductInStock>
    {
        public void Configure(EntityTypeBuilder<ProductInStock> builder)
        {
            builder.ToTable("ProductInStock");
            builder.HasKey(x => new { x.ProductID, x.StoreID });
            builder.Property(x => x.Quantity ).IsRequired();
            
        }
    }
}
