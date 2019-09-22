using NordwindApi.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NordwindApi.Core.Infrastructure.BllInterfaces
{
    public interface IEmployeeTerritoryOperation
    {
        Task<EmployeeTerritoryModel> GetEmployeeTerritory(long id);
        Task AddEmployeeTerritory(EmployeeTerritoryModel model);
        Task UpdateEmployeeTerritory(EmployeeTerritoryModel model);
        Task DeleteEmployeeTerritory(long id);
    }
}
