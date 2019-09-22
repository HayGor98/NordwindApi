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
    public class TerritoryOperation : ITerritoryOperation
    {
        private readonly IRepositoryManager _manager;
        private readonly IMapper _mapper;
        public TerritoryOperation(IRepositoryManager manager, IMapper mapper)
        {
            this._manager = manager;
            this._mapper = mapper;
        }
        public  async Task AddTerritory(TerritoryModel model)
        {
            var result = _mapper.Map<Territory>(model);
            _manager.Territories.Add(result);
            await _manager.CompleteAsync();
        }

        public async  Task DeleteTerritory(long id)
        {
            _manager.Territories.DeleteWhere(x => x.Id == id);
            await _manager.CompleteAsync();
        }

        public async Task<TerritoryModel> GetTerritory(long id)
        {
            var category = await _manager.Territories.GetSingleAsync(x => x.Id == id);
            var result = _mapper.Map<TerritoryModel>(category);
            return result;
        }

        public async Task UpdateTerritory(TerritoryModel model)
        {
            var result = _mapper.Map<Territory>(model);
            _manager.Territories.Update(result);

            await _manager.CompleteAsync();
        }
    }
}
