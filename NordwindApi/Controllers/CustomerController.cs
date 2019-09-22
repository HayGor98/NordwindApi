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
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerOperation _operation;
        public CustomerController(ICustomerOperation operation)
        {
            this._operation = operation;
        }

        [HttpGet("{id}")]
        public Task<CustomerModel> GetCustomer([FromRoute]int id)
        {
            var result = _operation.GetCustomer(id);
            return result;
        }
        [HttpPost]
        public async Task AddCustomer([FromBody] CustomerModel model)
        {
            await _operation.AddCustomer(model);
        }
        [HttpPut]
        public async Task UpdateCustomer([FromBody]CustomerModel model)
        {
            await _operation.UpdateCustomer(model);
        }

        [HttpDelete("{id}")]
        public async Task DeleteCustomer ([FromRoute] int id)
        {
            await _operation.DeleteCustomer(id);
        }

    }
}
