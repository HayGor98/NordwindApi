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
    public class CustomerOperation : ICustomerOperation
    {
        private readonly IRepositoryManager _manager;
        private readonly IMapper _mapper;
        public CustomerOperation(IRepositoryManager manager, IMapper mapper)
        {
            this._manager = manager;
            this._mapper = mapper;
        }
        public async Task AddCustomer(CustomerModel model)
        {
            var result = _mapper.Map<Customer>(model);
            _manager.Customers.Add(result);
            await _manager.CompleteAsync();
        }

        public async Task DeleteCustomer(long id)
        {
            _manager.Customers.DeleteWhere(x => x.Id == id);
            await _manager.CompleteAsync();
        }

        public async  Task<CustomerModel> GetCustomer(long id)
        {
            var result = await  _manager.Customers.GetSingleAsync(x => x.Id == id);
            var r = _mapper.Map<CustomerModel>(result);
            return r;
        }

        public async Task UpdateCustomer(CustomerModel model)
        {
            var result = _mapper.Map<Customer>(model);
            _manager.Customers.Update(result);
            await _manager.CompleteAsync();

        }
    }
}
