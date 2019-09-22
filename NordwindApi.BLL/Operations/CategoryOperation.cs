using NordwindApi.Core.Infrastructure.BllInterfaces;
using NordwindApi.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NordwindApi.BLL.Operations
{
    public class CategoryOperation : ICategoryOperation
    {
        public Task AddCategory(CategoryModel model)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCategory(long id)
        {
            throw new NotImplementedException();
        }

        public Task<CategoryModel> GetCategory(long id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateCategory(CategoryModel model)
        {
            throw new NotImplementedException();
        }
    }
}
