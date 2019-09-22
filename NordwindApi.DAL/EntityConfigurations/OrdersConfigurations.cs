using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NordwindApi.Core.Entiies;
using System;
using System.Collections.Generic;
using System.Text;
namespace NordwindApi.DAL.EntitiesConfig
{
    class OrdersConfigurations : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(x=> x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.ShipName).HasColumnType("nvarchar(15)");
            builder.Property(x => x.ShipAddress).HasColumnType("nvarchar(15)");
            builder.Property(x => x.ShipCity).HasColumnType("nvarchar(15)");
            builder.Property(x => x.ShipRegion).HasColumnType("nvarchar(15)");
            builder.Property(x => x.ShipPostalCode).HasColumnType("nvarchar(15)");
            builder.Property(x => x.ShipCountry).HasColumnType("nvarchar(15)");
            builder.Property(x => x.Freight).HasDefaultValue(0M);
            builder.Property(x => x.ShipperID).HasColumnName("ShipVia");
            builder.HasIndex(x => new {  x.ShippedDate, x.OrderDate,  x.ShipPostalCode });


            builder.HasOne(a => a.Customers).WithMany(b => b.Orders).HasForeignKey(c => c.CustomerID).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(e => e.Employees).WithMany(f=> f.Orders).HasForeignKey(x => x.EmployeeID).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x => x.Shippers).WithMany(x => x.Orders).HasForeignKey(x => x.ShipperID).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
