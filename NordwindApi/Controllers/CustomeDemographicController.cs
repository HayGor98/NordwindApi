using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NordwindApi.Core.Infrastructure.BllInterfaces;
using NordwindApi.Core.Models;


namespace NordwindApi.Controllers
{
    [Route("api/[controller]")]
    public class CustomeDemographicController : ControllerBase
    {
        private readonly ICustomerDemographicOperation _customerDemographicOperation;
        public CustomeDemographicController(ICustomerDemographicOperation customerDemographicOperation)
        {
            _customerDemographicOperation = customerDemographicOperation;
        }

        [HttpGet("{id}")]
        public Task<CustomerDemographicModel> GetCustomerDemographic([FromRoute]int id)
        {
            var result = _customerDemographicOperation.GetCustomerDemographic(id);
            return result;

        }

        // POST api/<controller>
        [HttpPost]
        public async Task AddCustomerDemographic([FromBody]CustomerDemographicModel customerDemographicModel)
        {
            await _customerDemographicOperation.AddCustomerDemographic(customerDemographicModel);
        }

        // PUT api/<controller>/5
        [HttpPut]
        public async Task UpdateCustomerDemographic([FromBody]CustomerDemographicModel customerDemographic)
        {
            await _customerDemographicOperation.UpdateCustomerDemographic(customerDemographic);
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public async Task DeleteCustomerDemographic([FromRoute]int id)
        {
            await _customerDemographicOperation.DeleteCustomerDemographic(id);
        }
    }
}
