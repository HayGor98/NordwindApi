using NordwindApi.Core.Infrastructure.RepositoryAbstraction;
using NordwindApi.Core.Infrastructure.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;


namespace NordwindApi.DAL
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly NordwindContext _context;

        public RepositoryManager(IServiceProvider serviceProvider, NordwindContext context)
        {
            _serviceProvider = serviceProvider;
            _context = context;
        }

        private ICategoryRepository _categories;
        public ICategoryRepository Categories =>
            _categories ?? (_categories = _serviceProvider.GetService<ICategoryRepository>());

        private ICustomerRepository _customerRepository;
        public ICustomerRepository Customers =>
            _customerRepository ?? (_customerRepository = _serviceProvider.GetService<ICustomerRepository>());

        private ICustomerCustomerDemoRepository _customerCustomerDemos;
        public ICustomerCustomerDemoRepository CustomerCustomerDemos =>
            _customerCustomerDemos ?? (_customerCustomerDemos = _serviceProvider.GetService<ICustomerCustomerDemoRepository>());

        private ICustomerDemographicRepository _customerDempgraphic;
        public ICustomerDemographicRepository CustomerDemographics =>
            _customerDempgraphic ?? (_customerDempgraphic = _serviceProvider.GetService<ICustomerDemographicRepository>());

        private IEmployerRepository _employer;
        public IEmployerRepository Employee =>
            _employer ?? (_employer = _serviceProvider.GetService<IEmployerRepository>());

        private IEmployeTeretoryRepository _employeTerritory;
        public IEmployeTeretoryRepository EmployeTeretories =>
            _employeTerritory ?? (_employeTerritory = _serviceProvider.GetService<IEmployeTeretoryRepository>());

        private IOrderRepository _order;
        public IOrderRepository Orders =>
            _order ?? (_order = _serviceProvider.GetService<IOrderRepository>());

        private IOrderDetailRepository _orderDetails;
        public IOrderDetailRepository OrderDetails =>
            _orderDetails ?? (_orderDetails = _serviceProvider.GetService<IOrderDetailRepository>());

        private IProductRepository _product;
        public IProductRepository Products =>
            _product ?? (_product = _serviceProvider.GetService<IProductRepository>());

        private IRegionRepository _region;
        public IRegionRepository Regions =>
            _region ?? (_region = _serviceProvider.GetService<IRegionRepository>());

        private ISupplierRepository _supplier;
        public ISupplierRepository suppliers =>
            _supplier ?? (_supplier = _serviceProvider.GetService<ISupplierRepository>());

        private IShipperRepository _shipper;
        public IShipperRepository shippers =>
            _shipper ?? (_shipper = _serviceProvider.GetService<IShipperRepository>());

        private ITerritoryRepository _territory;
        public ITerritoryRepository Territories =>
            _territory ?? (_territory = _serviceProvider.GetService<ITerritoryRepository>());


        public int Complete()
        {
            return _context.SaveChanges();
        }

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
