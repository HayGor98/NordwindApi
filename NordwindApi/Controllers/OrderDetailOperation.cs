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
    public class OrderDetailController : ControllerBase
    {
        private readonly IOrderDetailOperation _orderDetailOperation;
        public OrderDetailController(IOrderDetailOperation orderDetailOperation)
        {
            _orderDetailOperation = orderDetailOperation;
        }

        // GET api/<controller>/5/Product/4
        [HttpGet("{orderId}/Product/{productId}")]
        public Task<OrderDetailModel> GetOrderDetail([FromRoute]int productId, [FromRoute]int orderId)
        {
            var result = _orderDetailOperation.GetOrderDetail(orderId, productId);
            return result;

        }

        // POST api/<controller>
        [HttpPost]
        public async Task AddOrderDetail([FromBody]OrderDetailModel orderDetail)
        {
            await _orderDetailOperation.AddOrderDetail(orderDetail);
        }

        // PUT api/<controller>/5
        [HttpPut]
        public async Task UpdateOrderDetail([FromBody]OrderDetailModel orderDetail)
        {
            await _orderDetailOperation.UpdateOrderDetail(orderDetail);
        }

        // DELETE api/<controller>/5/Product/4
        [HttpDelete("{orderId}/Product/{productId}")]
        public async Task DeletOrderDetail([FromRoute]int productId, [FromRoute] int orderId)
        {
            await _orderDetailOperation.DeleteOrderDetail(orderId, productId);
        }
    }
}
