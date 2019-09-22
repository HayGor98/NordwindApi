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
    public class EmployeeTerritoryOperation : IEmployeeTerritoryOperation
    {
        private readonly IRepositoryManager _manager;
        private readonly IMapper _mapper;
        public EmployeeTerritoryOperation(IRepositoryManager manager, IMapper mapper)
        {
            this._manager = manager;
            this._mapper = mapper;
        }
        public async Task AddEmployeeTerritory(EmployeeTerritoryModel model)
        {
            var result = _mapper.Map<EmployeeTerritory>(model);
            _manager.EmployeTeretories.Add(result);
            await _manager.CompleteAsync();

        }

        public async Task DeleteEmployeeTerritory(long EmployeeID, long TeritoryID)
        {
            _manager.EmployeTeretories.DeleteWhere(x => x.EmployeeID == EmployeeID && x.TeritoryID == TeritoryID);
            await _manager.CompleteAsync();
        }

        public async Task<EmployeeTerritoryModel> GetEmployeeTerritory(long EmployeeID, long TeritoryID)
        {
            var result = await _manager.EmployeTeretories.GetSingleAsync(x => x.EmployeeID == EmployeeID && x.TeritoryID == TeritoryID);
            var r = _mapper.Map<EmployeeTerritoryModel>(result);
            return r;
        }

        public async Task UpdateEmployeeTerritory(EmployeeTerritoryModel model)
        {
            var result = _mapper.Map<EmployeeTerritory>(model);
            _manager.EmployeTeretories.Update(result);
            await _manager.CompleteAsync();
        }
    }
}
