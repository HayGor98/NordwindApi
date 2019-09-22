using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NordwindApi.Core.Entiies;
using System;
using System.Collections.Generic;
using System.Text;
namespace NordwindApi.DAL.EntitiesConfig
{
    class OrderDetailsConfiguration : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.HasKey(x => new { x.OrderID, x.ProductID });
            builder.Property(a => a.Quantity).HasDefaultValue("1");
            builder.Property(a => a.UnitPrice).HasDefaultValue("0");
            builder.Property(a => a.Discount).HasDefaultValue("0");
            

            builder.HasOne(b => b.Products).WithMany(x => x.OrderDetails).HasForeignKey(t => t.ProductID).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(b => b.Order).WithMany(a => a.OrderDetails).HasForeignKey(t => t.OrderID).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
