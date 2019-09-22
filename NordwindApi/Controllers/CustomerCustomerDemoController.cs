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
    public class CustomerCustomerDemoController : ControllerBase
    {
        // GET: /<controller>/
        private readonly ICustomerCustomerDemoOperation _customerCustomerDemoOperation;
        public CustomerCustomerDemoController(ICustomerCustomerDemoOperation customerCustomerDemoOperation)
        {
            _customerCustomerDemoOperation = customerCustomerDemoOperation;
        }

        // GET api/<controller>/5
        [HttpGet("{customerId}/{customerTypeId}")]
        public Task<CustomerCustomerDemoModel> GetOrderDetail([FromRoute]int customerId, [FromRoute]int customerTypeId)
        {
            var result = _customerCustomerDemoOperation.GetCustomerCustomerDemo(customerId, customerTypeId);
            return result;

        }

        // POST api/<controller>
        [HttpPost]
        public async Task AddCustomerCustomerDemo([FromBody]CustomerCustomerDemoModel customerDemo)
        {
            await _customerCustomerDemoOperation.AddCustomerCustomerDemo(customerDemo);
        }

        // PUT api/<controller>/5
        [HttpPut]
        public async Task UpdateCustomerCustomerDemo([FromBody]CustomerCustomerDemoModel customerDemo)
        {
            await _customerCustomerDemoOperation.UpdateCustomerCustomerDemo(customerDemo);
        }

        // DELETE api/<controller>/5
        [HttpDelete("{customerId}/{customerTypeId}")]
        public async Task DeleteCustomerCustomrDemo([FromRoute]int customerId,[FromRoute]int customerTypeId)
        {
            await _customerCustomerDemoOperation.DeleteCustomerCustomerDemo(customerId,customerTypeId);
        }
    }
}
