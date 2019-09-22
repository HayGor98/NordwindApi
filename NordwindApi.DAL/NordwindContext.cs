using Microsoft.EntityFrameworkCore;
using NordwindApi.Core.Entiies;
using NordwindApi.Core.Entities;
using NordwindApi.DAL.EntitiesConfig;
using System;
using System.Collections.Generic;
using System.Text;

namespace NordwindApi.DAL
{
    public class NordwindContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<CustomerCustomerDemo> CustomerCustomerDemo { get; set; }
        public DbSet<CustomerDemographic> CustomerDemographics { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employer> Employees { get; set; }
        public DbSet<EmployeeTerritory> EmployeeTerritories { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Region> Region { get; set; }
        public DbSet<Shipper> Shippers { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Territory> Territories { get; set; }




        public NordwindContext (DbContextOptions options) : base(options)
            {
            }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new CategoriesConfiguration());
            modelBuilder.ApplyConfiguration(new CustomerDemographicsConfig());
            modelBuilder.ApplyConfiguration(new CustomersConfiguration());
            modelBuilder.ApplyConfiguration(new CustomerCustomerDemoConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeesConfigurations());
            modelBuilder.ApplyConfiguration(new TerritoriesConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeTeritoriesConfiguration());
            modelBuilder.ApplyConfiguration(new OrdersConfigurations());
            modelBuilder.ApplyConfiguration(new ProductsConfigurations());
            modelBuilder.ApplyConfiguration(new OrderDetailsConfiguration());
            
            modelBuilder.ApplyConfiguration(new RegionConfigurations());
            modelBuilder.ApplyConfiguration(new ShippersConfiguration());
            modelBuilder.ApplyConfiguration(new SuppliersConfigurations());
        }



    }
}
