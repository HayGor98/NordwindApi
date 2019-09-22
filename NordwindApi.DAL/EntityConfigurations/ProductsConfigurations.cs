using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NordwindApi.Core.Entiies;
using System;
using System.Collections.Generic;
using System.Text;
namespace NordwindApi.DAL.EntitiesConfig
{
    class ProductsConfigurations : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.ProductName).HasColumnType("nvarchar(40)");
            builder.Property(x => x.QuantityPerUnit).HasColumnType("nvarchar(20)");
            builder.Property(x => x.Discounted).HasDefaultValue(false);
            builder.Property(x => x.ReorderLevel).HasDefaultValue(0);
            builder.Property(x => x.UnitPrice).HasDefaultValue(0M);
            builder.Property(x => x.UnitslnStock).HasDefaultValue(0);
            builder.Property(x => x.UnitONOrder).HasDefaultValue(0);
            builder.HasIndex(x => new { x.ProductName});


            builder.HasOne(x => x.Categorie).WithMany(x => x.Products).HasForeignKey(x => x.CategoryID).OnDelete(DeleteBehavior.Restrict);
            //esi chishta senc
            builder.HasOne(x => x.Supplier).WithMany(x => x.Products).HasForeignKey(x => x.SupplierID).OnDelete(DeleteBehavior.Restrict);

           

        }
    }
}
