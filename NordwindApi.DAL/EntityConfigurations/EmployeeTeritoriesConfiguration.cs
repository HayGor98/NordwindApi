using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NordwindApi.Core.Entiies;
using System;
using System.Collections.Generic;
using System.Text;
namespace NordwindApi.DAL.EntitiesConfig
{
    class EmployeeTeritoriesConfiguration : IEntityTypeConfiguration<EmployeeTerritory>
    {
        public void Configure(EntityTypeBuilder<EmployeeTerritory> builder)
        {
            builder.HasKey(x => new { x.EmployeeID, x.TeritoryID });
            

            builder.HasOne(x=>x.Employe).WithMany(x => x.EmployeeTerritories).HasForeignKey(x => x.EmployeeID).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x => x.Territory).WithMany(x => x.EmployeeTerritories).HasForeignKey(x => x.TeritoryID).OnDelete(DeleteBehavior.Restrict);

        }
    }
}
