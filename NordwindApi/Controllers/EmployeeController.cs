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
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployerOperation _operation;
        public EmployeeController(IEmployerOperation operation)
        {
            this._operation = operation;
        }

        [HttpGet("{id}")]
        public Task<EmployerModel> GetEmployee([FromRoute]int id)
        {
            var result = _operation.GetEmployer(id);
            return result;
        }
        [HttpPost]
        public async Task AddEmployee([FromBody] EmployerModel model)
        {
            await _operation.AddEmployer(model);
        }
        [HttpPut]
        public async Task UpdateEmployee([FromBody]EmployerModel model)
        {
            await _operation.UpdateEmployer(model);
        }

        [HttpDelete("{id}")]
        public async Task DeleteEmployee([FromRoute] int id)
        {
            await _operation.DeleteEmployer(id);
        }



    }
}
