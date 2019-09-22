using Microsoft.AspNetCore.Mvc;
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
    public class RegionController : ControllerBase
    {
        private readonly IRegionOperation _operation;
        public RegionController(IRegionOperation operation)
        {
            this._operation = operation;
        }
        [HttpGet("{id}")]
        public Task<RegionModel> GetRegion([FromRoute]int id)
        {
            var result = _operation.GetRegion(id);
            return result;
        }
        [HttpPost]
        public async Task AddRegion([FromBody] RegionModel model)
        {
            await _operation.AddRegion(model);
        }
        [HttpPut]
        public async Task UpdateRegion([FromBody]RegionModel model)
        {
            await _operation.UpdateRegion(model);
        }

        [HttpDelete("{id}")]
        public async Task DeleteRegion([FromRoute] int id)
        {
            await _operation.DeleteRegion(id);
        }
    }
}
