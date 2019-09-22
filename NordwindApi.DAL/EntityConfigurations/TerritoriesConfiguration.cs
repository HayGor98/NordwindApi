using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NordwindApi.Core.Entiies;
using System;
using System.Collections.Generic;
using System.Text;

namespace NordwindApi.DAL.EntitiesConfig
{
    class TerritoriesConfiguration : IEntityTypeConfiguration<Territory>
    {
        public void Configure(EntityTypeBuilder<Territory> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.TeritryDescription).HasColumnType("nchar(50)").IsRequired();


            builder.HasOne(x => x.Region).WithMany(x => x.Territorie).HasForeignKey(x => x.RegionID).OnDelete(DeleteBehavior.Restrict);
        }

    }
}
