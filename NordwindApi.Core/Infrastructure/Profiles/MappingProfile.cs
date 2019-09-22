using AutoMapper;
using NordwindApi.Core.Entiies;
using NordwindApi.Core.Entities;
using NordwindApi.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NordwindApi.Core.Infrastructure.Profiles
{
    public class  MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Category, CategoryModel>();
            CreateMap<CategoryModel, Category>()
                .ForMember(s => s.Products, x => x.Ignore());

            CreateMap<Customer, CustomerModel>();
            CreateMap<CustomerModel, Customer>()
                .ForMember(x => x.CustomerCustomerDemos, x => x.Ignore())
                .ForMember(x => x.Orders, x => x.Ignore());

            CreateMap<CustomerCustomerDemo, CustomerCustomerDemoModel>();
            CreateMap<CustomerCustomerDemoModel, CustomerCustomerDemo>()
                .ForMember(x => x.Customer, x => x.Ignore())
                .ForMember(x => x.CustomerDemographic, X => X.Ignore());

            CreateMap<CustomerDemographic, CustomerDemographicModel>();
            CreateMap<CustomerDemographicModel, CustomerDemographic>()
                .ForMember(x => x.CustomerCustomerDemos, x => x.Ignore());

            CreateMap<EmployeeTerritory, EmployeeTerritoryModel>();
            CreateMap<EmployeeTerritoryModel, EmployeeTerritory>()
                .ForMember(x => x.Employe, X => X.Ignore())
                .ForMember(x => x.Territory, x => x.Ignore());

            CreateMap<Employer, EmployerModel>();
            CreateMap<EmployerModel, Employer>()
                .ForMember(x => x.ReportToEmployee, x => x.Ignore())
                .ForMember(x => x.Employe, x => x.Ignore())
                .ForMember(x => x.EmployeeTerritories, x => x.Ignore())
                .ForMember(x => x.Orders, x => x.Ignore());

            CreateMap<Order, OrderModel>();
            CreateMap<OrderModel, Order>()
                .ForMember(x => x.OrderDetails, x => x.Ignore())
                .ForMember(x => x.Customers, x => x.Ignore())
                .ForMember(x => x.Employees, x => x.Ignore())
                .ForMember(x => x.Shippers, x => x.Ignore());

            CreateMap<OrderDetail, OrderDetailModel>();
            CreateMap<OrderDetailModel, OrderDetail>()
                .ForMember(x => x.Order, x => x.Ignore())
                .ForMember(x => x.Products, X => X.Ignore());

            CreateMap<Product, ProductModel>();
            CreateMap<ProductModel, Product>()
                .ForMember(x => x.OrderDetails, x => x.Ignore())
                .ForMember(x => x.Supplier, x => x.Ignore())
                .ForMember(x => x.Categorie, x => x.Ignore());

            CreateMap<Region, RegionModel>();
            CreateMap<RegionModel, Region>()
                .ForMember(x => x.Territorie, x => x.Ignore());

            CreateMap<Shipper, ShipperModel>();
            CreateMap<ShipperModel, Shipper>()
                .ForMember(x => x.Orders, x => x.Ignore());

            CreateMap<Supplier, SupplierModel>();
            CreateMap<SupplierModel, Supplier>()
                .ForMember(x => x.Products, x => x.Ignore());

            CreateMap<Territory, TerritoryModel>();
            CreateMap<TerritoryModel, Territory>()
                .ForMember(x => x.EmployeeTerritories, x => x.Ignore())
                .ForMember(x => x.Region, x => x.Ignore());





        }
    }
}
