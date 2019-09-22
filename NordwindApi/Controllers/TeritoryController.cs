using Microsoft.AspNetCore.Mvc;
using NordwindApi.BLL.Operations;
using NordwindApi.Core.Infrastructure.BllInterfaces;
using NordwindApi.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NordwindApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeritoryController : ControllerBase
    {
        private readonly ITerritoryOperation _operation;
        public TeritoryController(ITerritoryOperation operation)
        {
            this._operation = operation;
        }

        [HttpGet("{id}")]
        public Task<TerritoryModel> GetTerritory([FromRoute]int id)
        {
            var result = _operation.GetTerritory(id);
            return result;
        }
        [HttpPost]
        public async Task AddTerritory([FromBody] TerritoryModel model)
        {
            await _operation.AddTerritory(model);
        }
        [HttpPut]
        public async Task UpdateTerritory([FromBody]TerritoryModel model)
        {
            await _operation.UpdateTerritory(model);
        }

        [HttpDelete("{id}")]
        public async Task DeleteTerritory([FromRoute] int id)
        {
            await _operation.DeleteTerritory(id);
        }

    }
}
