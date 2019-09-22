using Microsoft.Extensions.DependencyInjection;
using NordwindApi.BLL.Operations;
using NordwindApi.Core.Infrastructure.BllInterfaces;
using NordwindApi.Core.Infrastructure.RepositoryAbstraction;
using NordwindApi.Core.Infrastructure.RepositoryInterfaces;
using NordwindApi.DAL;
using NordwindApi.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NordwindApi.Configuration
{
    public static class DependencyConfiguraton
    {
        public static void AddDALServices(this IServiceCollection services)
        {
            foreach (var entry in Repositories)
            {
                services.Add(new ServiceDescriptor(entry.Key, entry.Value, ServiceLifetime.Transient));
            }
        }

        public static void AddBLLServices(this IServiceCollection services)
        {
            foreach (var entry in Operations)
            {
                services.Add(new ServiceDescriptor(entry.Key, entry.Value, ServiceLifetime.Transient));
            }
        }
        private static readonly Dictionary<Type, Type> Operations = new Dictionary<Type, Type>
        {
            {typeof(ICategoryOperation),typeof(CategoryOperation) },
            {typeof(IShipperOperation),typeof(ShipperOperation) },
            {typeof(ISupplierOperation),typeof(SupplierOperation) },
            {typeof(IEmployerOperation),typeof(EmployerOperation) },
            {typeof(IEmployeeTerritoryOperation),typeof(EmployeeTerritoryOperation) },
            {typeof(IOrderDetailOperation),typeof(OrderDetailOperation) },
            {typeof(IOrderOperation),typeof(OrderOperation) },
            {typeof(IProductOperation),typeof(ProductOperation) },
            {typeof(IRegionOperation),typeof(RegionOperation) },
            {typeof(ITerritoryOperation),typeof(TerritoryOperation) },
            {typeof(ICustomerCustomerDemoOperation),typeof(CustomerCustomerDemoOperation) },
            {typeof(ICustomerDemographicOperation),typeof(CustomerDemographicOperation) },
            {typeof(ICustomerOperation),typeof(CustomerOperation) },
        };

        private static readonly Dictionary<Type, Type> Repositories = new Dictionary<Type, Type>
        {
            {typeof(IRepositoryManager),typeof(RepositoryManager) },
            {typeof(ICategoryRepository),typeof(CategoryRepository) },
            {typeof(IShipperRepository),typeof(ShipperRepository) },
            {typeof(ISupplierRepository),typeof(SupplierRepository) },
            {typeof(IRegionRepository),typeof(RegionRepository) },
            {typeof(IEmployeTeretoryRepository),typeof(EmployeTerritoryRepository) },
            {typeof(IOrderDetailRepository),typeof(OrderDetailRepository) },
            {typeof(IOrderRepository),typeof(OrderRepository) },
            {typeof(IProductRepository),typeof(ProductRepository) },
            {typeof(ICustomerCustomerDemoRepository),typeof(CustomerCustomerDemoRepository) },
            {typeof(ICustomerDemographicRepository),typeof(CustomerDemographicRepository) },
            {typeof(ICustomerRepository),typeof(CustomerRepository) },
            {typeof(ITerritoryRepository),typeof(TerritoryRepository) },
            {typeof(IEmployerRepository),typeof(EmployerRepository) },
        };
    }
}
