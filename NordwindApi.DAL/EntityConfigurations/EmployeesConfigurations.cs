using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NordwindApi.Core.Entiies;
using System;
using System.Collections.Generic;
using System.Text;

namespace NordwindApi.DAL.EntitiesConfig
{
    class EmployeesConfigurations : IEntityTypeConfiguration<Employer>
    {
        public void Configure(EntityTypeBuilder<Employer> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Photo).HasColumnType("image");
            builder.Property(x => x.LastName).HasColumnType("nvarchar(20)").IsRequired();
            builder.Property(x => x.FirstName).HasColumnType("nvarchar(20)").IsRequired();
            builder.Property(x => x.Title).HasColumnType("nvarchar(20)");
            builder.Property(x => x.TitleOfCourtesy).HasColumnType("nvarchar(20)");
            builder.Property(x => x.Address).HasColumnType("nvarchar(20)");
            builder.Property(x => x.City).HasColumnType("nvarchar(20)");
            builder.Property(x => x.Region).HasColumnType("nvarchar(15)");
            builder.Property(x => x.PostalCode).HasColumnType("nvarchar(10)");
            builder.Property(x => x.Country).HasColumnType("nvarchar(15)");
            builder.Property(x => x.HomePhone).HasColumnType("nvarchar(24)");
            builder.Property(x => x.Extensions).HasColumnType("nvarchar(24)");
            builder.Property(x => x.Notes).HasColumnType("nvarchar(4)");
            builder.Property(x => x.PhotoPath).HasColumnType("nvarchar(255)");
            builder.HasIndex(x => new { x.PostalCode, x.LastName });


            builder.HasMany(x => x.Employe).WithOne(x => x.ReportToEmployee).HasForeignKey(x => x.Id).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
