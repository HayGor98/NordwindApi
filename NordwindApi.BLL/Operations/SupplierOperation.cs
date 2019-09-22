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
    public class SupplierOperation : ISupplierOperation
    {
        private readonly IRepositoryManager _manager;
        private readonly IMapper _mapper;
        public SupplierOperation(IRepositoryManager manager, IMapper mapper)
        {
            this._manager = manager;
            this._mapper = mapper;
        }
        public async Task AddSupplier(SupplierModel model)
        {
            var result = _mapper.Map<Supplier>(model);
            _manager.suppliers.Add(result);
            await _manager.CompleteAsync();
        }

        public async Task DeleteSupplier(long id)
        {
            _manager.suppliers.DeleteWhere(x => x.Id == id);
            await _manager.CompleteAsync();
        }

        public async Task<SupplierModel> GetSupplier(long id)
        {
            var category = await _manager.suppliers.GetSingleAsync(x => x.Id == id);
            var result = _mapper.Map<SupplierModel>(category);
            return result;
        }

        public async Task UpdateSupplier(SupplierModel model)
        {
            var result = _mapper.Map<Supplier>(model);
            _manager.suppliers.Update(result);

            await _manager.CompleteAsync();
        }
    }
}
