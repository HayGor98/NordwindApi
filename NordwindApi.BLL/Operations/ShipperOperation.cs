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
    public class ShipperOperation : IShipperOperation
    {

        private readonly IRepositoryManager _manager;
        private readonly IMapper _mapper;
        public ShipperOperation(IRepositoryManager manager, IMapper mapper)
        {
            this._manager = manager;
            this._mapper = mapper;
        }
        public async Task AddShipper(ShipperModel model)
        {
            var result = _mapper.Map<Shipper>(model);
            _manager.shippers.Add(result);
            await _manager.CompleteAsync();
        }

        public async Task DeleteShipper(long id)
        {
            _manager.shippers.DeleteWhere(x => x.Id == id);
            await _manager.CompleteAsync();
        }

        public async Task<ShipperModel> GetShipper(long id)
        {
            var category = await _manager.shippers.GetSingleAsync(x => x.Id == id);
            var result = _mapper.Map<ShipperModel>(category);
            return result;
        }

        public async Task UpdateShipper(ShipperModel model)
        {
            var result = _mapper.Map<Shipper>(model);
            _manager.shippers.Update(result);

            await _manager.CompleteAsync();
        }
    }
}
