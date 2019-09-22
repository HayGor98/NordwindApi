using NordwindApi.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NordwindApi.Core.Infrastructure.BllInterfaces
{
    public interface IRegionOperation
    {
        Task<RegionModel> GetRegion(long id);
        Task AddRegion(RegionModel model);
        Task UpdateRegion(RegionModel model);
        Task DeleteRegion(long id);
    }
}
