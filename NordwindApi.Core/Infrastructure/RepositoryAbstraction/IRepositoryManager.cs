using NordwindApi.Core.Infrastructure.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NordwindApi.Core.Infrastructure.RepositoryAbstraction
{
    public interface IRepositoryManager
    {
        ICategoryRepository Categories { get; }
        ICustomerRepository Customers { get; }
        ICustomerCustomerDemoRepository CustomerCustomerDemos { get; }
        ICustomerDemographicRepository CustomerDemographics { get; }
        IEmployerRepository Employee { get; }
        IEmployeTeretoryRepository EmployeTeretories { get; }
        IOrderRepository Orders { get; }
        IOrderDetailRepository OrderDetails { get; }
        IProductRepository Products { get; }
        IRegionRepository Regions { get; }
        ISupplierRepository suppliers { get; }
        IShipperRepository shippers { get; }
        ITerritoryRepository Territories { get; }
        Task<int> CompleteAsync();
        int Complete();
    }
}
