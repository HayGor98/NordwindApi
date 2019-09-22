using AutoMapper;
using NordwindApi.Core.Entiies;
using NordwindApi.Core.Infrastructure.BllInterfaces;
using NordwindApi.Core.Infrastructure.RepositoryAbstraction;
using NordwindApi.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NordwindApi.BLL.Operations
{
    public class CustomerCustomerDemoOperation : ICustomerCustomerDemoOperation
    {
        private readonly IRepositoryManager _manager;
        private readonly IMapper _mapper;
        public CustomerCustomerDemoOperation( IRepositoryManager manager,IMapper mapper )
        {
            this._manager = manager;
            this._mapper = mapper;
        }
        public async Task AddCustomerCustomerDemo(CustomerCustomerDemoModel model)
        {
            var result = _mapper.Map<CustomerCustomerDemo>(model);
            _manager.CustomerCustomerDemos.Add(result);
            await _manager.CompleteAsync();
        }

        public async Task DeleteCustomerCustomerDemo(long CustomerID, long CustomerTypeID)
        {
            _manager.CustomerCustomerDemos.DeleteWhere(x => x.CustomerID == CustomerID && x.CustomerTypeID == CustomerTypeID);
            await _manager.CompleteAsync();
        }

        public async Task<CustomerCustomerDemoModel> GetCustomerCustomerDemo(long CustomerID, long CustomerTypeID)
        {
            var result = await _manager.CustomerCustomerDemos.GetSingleAsync(x => x.CustomerID == CustomerID && x.CustomerTypeID == CustomerTypeID);
            var r = _mapper.Map<CustomerCustomerDemoModel>(result);
            return r;
        }

        public async Task UpdateCustomerCustomerDemo(CustomerCustomerDemoModel model)
        {
            var r = _mapper.Map<CustomerCustomerDemo>(model);
            _manager.CustomerCustomerDemos.Update(r);
            await _manager.CompleteAsync();


        }
    }
}
