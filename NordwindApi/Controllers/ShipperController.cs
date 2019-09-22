﻿using Microsoft.AspNetCore.Mvc;
using NordwindApi.Core.Infrastructure.BllInterfaces;
using NordwindApi.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NordwindApi.Controllers
{
    [Route("api/[controller]")]
    public class ShipperController : ControllerBase
    {
        private readonly IShipperOperation _shipperOperation;
        public ShipperController(IShipperOperation shipperOperation)
        {
            _shipperOperation = shipperOperation;
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public Task<ShipperModel> GetShipper([FromRoute]int id)
        {
            var result = _shipperOperation.GetShipper(id);
            return result;

        }

        // POST api/<controller>
        [HttpPost]
        public async Task AddShipper([FromBody]ShipperModel shipper)
        {
            await _shipperOperation.AddShipper(shipper);
        }

        // PUT api/<controller>/5
        [HttpPut]
        public async Task UpdateShipper([FromBody]ShipperModel shipper)
        {
            await _shipperOperation.UpdateShipper(shipper);
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public async Task DeleteShipper([FromRoute]int id)
        {
            await _shipperOperation.DeleteShipper(id);
        }
    }
}