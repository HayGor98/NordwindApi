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
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryOperation _categoryOperation;

        /// <summary>
        /// Category meens product type
        /// </summary>
        /// <param name="categoryOperation"></param>
        public CategoryController(ICategoryOperation categoryOperation)
        {
            _categoryOperation = categoryOperation;
        }

        // api/Categories/5
        // id = 5 tvyal depqum
        [HttpGet("{id}")]
        public Task<CategoryModel> GetCategory([FromRoute]int id)
        {
            var result = _categoryOperation.GetCategory(id);

            return result;
        }

        // api/Categories
        [HttpPost]
        public async Task AddCategory([FromBody]CategoryModel category)
        {
            await _categoryOperation.AddCategory(category);
        }

        // api/Categories
        [HttpPut]
        public async Task UpdateCategory([FromBody]CategoryModel category)
        {
            await _categoryOperation.UpdateCategory(category);
        }

        // api/Categories/5
        // id = 5 tvyal depqum
        [HttpDelete("{id}")]
        public async Task DeleteCategory([FromRoute]int id)
        {
            await _categoryOperation.DeleteCategory(id);
        }
    }
}