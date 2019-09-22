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
    public class RegionOperation : IRegionOperation
    {
        private readonly IRepositoryManager _manager;
        private readonly IMapper _mapper;
        public RegionOperation(IRepositoryManager manager, IMapper mapper)
        {
            this._manager = manager;
            this._mapper = mapper;
        }
        public async Task AddRegion(RegionModel model)
        {
            var result = _mapper.Map<Region>(model);
            _manager.Regions.Add(result);
            await _manager.CompleteAsync();
        }

        public async Task DeleteRegion(long id)
        {
            _manager.Regions.DeleteWhere(x => x.Id == id);
            await _manager.CompleteAsync();
        }

        public async  Task<RegionModel> GetRegion(long id)
        {
            var category = await _manager.Regions.GetSingleAsync(x => x.Id == id);
            var result = _mapper.Map<RegionModel>(category);
            return result;
        }

        public async Task UpdateRegion(RegionModel model)
        {
            var result = _mapper.Map<Region>(model);
            _manager.Regions.Update(result);

            await _manager.CompleteAsync();
        }
    }
}
