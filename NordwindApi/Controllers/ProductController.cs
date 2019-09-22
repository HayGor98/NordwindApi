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
    [ApiController]
    public class ProductController : ControllerBase
    {


        private readonly IProductOperation _productOperation;
        public ProductController(IProductOperation productOperation)
        {
            _productOperation = productOperation;
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public Task<ProductModel> GetProduct([FromRoute]int id)
        {
            var result = _productOperation.GetProduct(id);
            return result;

        }

        // POST api/<controller>
        [HttpPost]
        public async Task AddProduct([FromBody]ProductModel product)
        {
            await _productOperation.AddProduct(product);
        }

        // PUT api/<controller>/5
        [HttpPut]
        public async Task UpdateProduct([FromBody]ProductModel product)
        {
            await _productOperation.UpdateProduct(product);
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public async Task DeleteProduct([FromRoute]int id)
        {
            await _productOperation.DeleteProduct(id);
        }

    }
}