using NordwindApi.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NordwindApi.Core.Infrastructure.BllInterfaces
{
    public interface ITerritoryOperation
    {
        Task<TerritoryModel> GetTerritory(long id);
        Task AddTerritory(TerritoryModel model);
        Task UpdateTerritory(TerritoryModel model);
        Task DeleteTerritory(long id);
    }
}
