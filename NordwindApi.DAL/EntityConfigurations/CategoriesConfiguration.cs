using Microsoft.EntityFrameworkCore;
using NordwindApi.Core.Entiies;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using NordwindApi.Core.Entities;

namespace NordwindApi.DAL.EntitiesConfig
{
    class CategoriesConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Name).HasColumnType("nvarchar(15)").IsRequired();
            builder.Property(x => x.Description).HasColumnType("nvarchar(15)");
            builder.HasIndex(x => x.Name);
            builder.Property(x => x.Picture).HasColumnType("image");



        }
    }
}
