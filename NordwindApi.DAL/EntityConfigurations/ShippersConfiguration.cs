using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using NordwindApi.Core.Entiies;

namespace NordwindApi.DAL.EntitiesConfig
{
    class ShippersConfiguration : IEntityTypeConfiguration<Shipper>
    {
        public void Configure(EntityTypeBuilder<Shipper> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Companyname).HasColumnType("nvarchar(40)").IsRequired();
            builder.Property(x => x.Phone).HasColumnType("nvarchar(24)");
        }
    }
}
