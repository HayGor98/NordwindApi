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
    public class OrderController : ControllerBase
    {
        private readonly IOrderOperation _orderOperation;
        public OrderController(IOrderOperation orderOperation)
        {
            _orderOperation = orderOperation;
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public Task<OrderModel> GetOrder([FromRoute]int id)
        {
            var result = _orderOperation.GetOrder(id);
            return result;

        }

        // POST api/<controller>
        [HttpPost]
        public async Task AddOrder([FromBody]OrderModel order)
        {
            await _orderOperation.AddOrder(order);
        }

        // PUT api/<controller>/5
        [HttpPut]
        public async Task UpdateOrder([FromBody]OrderModel order)
        {
            await _orderOperation.UpdateOrder(order);
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public async Task DeleteOrder([FromRoute]int id)
        {
            await _orderOperation.DeleteOrder(id);
        }
    }
}
