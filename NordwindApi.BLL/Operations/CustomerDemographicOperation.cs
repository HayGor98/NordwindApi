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
    public class CustomerDemographicOperation : ICustomerDemographicOperation
    {

        private readonly IRepositoryManager _manager;
        private readonly IMapper _mapper;
        public CustomerDemographicOperation(IRepositoryManager manager, IMapper mapper)
        {
            this._manager = manager;
            this._mapper = mapper;
        }
        public async Task AddCustomerDemographic(CustomerDemographicModel model)
        {
            var result = _mapper.Map<CustomerDemographic>(model);
            _manager.CustomerDemographics.Add(result);
            await _manager.CompleteAsync();
        }

        public async Task DeleteCustomerDemographic(long id)
        {
            _manager.CustomerDemographics.DeleteWhere(x => x.Id == id);
            await _manager.CompleteAsync();
        }

        public async  Task<CustomerDemographicModel> GetCustomerDemographic(long id)
        {
            var r = await _manager.CustomerDemographics.GetSingleAsync(x => x.Id == id);
            var result = _mapper.Map<CustomerDemographicModel>(r);
            return result;
        }

        public async Task UpdateCustomerDemographic(CustomerDemographicModel model)
        {
            var result = _mapper.Map<CustomerDemographic>(model);
            _manager.CustomerDemographics.Update(result);

            await _manager.CompleteAsync();
        }
    }
}
