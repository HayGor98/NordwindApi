using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NordwindApi.Core.Infrastructure.BllInterfaces;
using NordwindApi.Core.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NordwindApi.Controllers
{
    public class EmployeTerritoryController : ControllerBase
    {
        private readonly IEmployeeTerritoryOperation _employeeTerritoryOperation;
        public EmployeTerritoryController(IEmployeeTerritoryOperation employeeTerritoryOperation)
        {
            _employeeTerritoryOperation = employeeTerritoryOperation;
        }

        // GET api/<controller>/5
        // GET api/<controller>/5/Product/4
        [HttpGet("{employeId}/{territoryId}")]
        public Task<EmployeeTerritoryModel> GetEmployeTerritory([FromRoute]int employeId, [FromRoute]int territoryId)
        {
            var result = _employeeTerritoryOperation.GetEmployeeTerritory(employeId, territoryId);
            return result;

        }

        // POST api/<controller>
        [HttpPost]
        public async Task AddEmployeTerritory([FromBody]EmployeeTerritoryModel employeeTerritoryModel)
        {
            await _employeeTerritoryOperation.AddEmployeeTerritory(employeeTerritoryModel);
        }

        // PUT api/<controller>/5
        [HttpPut]
        public async Task UpdateEmployeTerritory([FromBody]EmployeeTerritoryModel employeeTerritory)
        {
            await _employeeTerritoryOperation.UpdateEmployeeTerritory(employeeTerritory);
        }

        // DELETE api/<controller>/5/Product/4
        [HttpDelete("{employeId}/{territoryId}")]
        public async Task DeletOrderDetail([FromRoute]int employeId, [FromRoute] int territoryId)
        {
            await _employeeTerritoryOperation.DeleteEmployeeTerritory(employeId, territoryId);
        }

    }
}
