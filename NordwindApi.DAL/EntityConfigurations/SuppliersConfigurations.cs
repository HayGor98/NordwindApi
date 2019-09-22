using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NordwindApi.Core.Entiies;
using System;
using System.Collections.Generic;
using System.Text;

namespace NordwindApi.DAL.EntitiesConfig
{
    class SuppliersConfigurations : IEntityTypeConfiguration<Supplier>
    {
        public void Configure(EntityTypeBuilder<Supplier> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.CompanyName).HasColumnType("nvarchar(25)").IsRequired();
            builder.Property(x => x.ContactName).HasColumnType("nvarchar(30)");
            builder.Property(x => x.ContactTitle).HasColumnType("nvarchar(30)");
            builder.Property(x => x.Address).HasColumnType("nvarchar(60)");
            builder.Property(x => x.City).HasColumnType("nvarchar(150)");
            builder.Property(x => x.Region).HasColumnType("nvarchar(10)");
            builder.Property(x => x.PostalCode).HasColumnType("nvarchar(10)");
            builder.Property(x => x.Country).HasColumnType("nvarchar(10)");
            builder.Property(x => x.Phone).HasColumnType("nvarchar(24)");
            builder.Property(x => x.Fax).HasColumnType("nvarchar(24)");
            builder.Property(x => x.HomePage).HasColumnType("nvarchar(15)");
            builder.HasIndex(x => new { x.CompanyName, x.PostalCode });

        }
    }
}
