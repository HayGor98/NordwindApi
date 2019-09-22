using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using NordwindApi.Core.Entiies;

namespace NordwindApi.DAL.EntitiesConfig
{
    class CustomerCustomerDemoConfiguration : IEntityTypeConfiguration<CustomerCustomerDemo>
    {
        public void Configure(EntityTypeBuilder<CustomerCustomerDemo> builder)
        {
            builder.HasOne(x => x.Customer).WithMany(x => x.CustomerCustomerDemos).HasForeignKey(x => x.CustomerID).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x => x.CustomerDemographic).WithMany(x => x.CustomerCustomerDemos).HasForeignKey(x => x.CustomerTypeID).OnDelete(DeleteBehavior.Restrict);
            builder.HasKey(x => new { x.CustomerTypeID, x.CustomerID });



        }
    }
}
