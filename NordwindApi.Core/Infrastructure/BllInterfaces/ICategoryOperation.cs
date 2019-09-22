using NordwindApi.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NordwindApi.Core.Infrastructure.BllInterfaces
{
    public interface ICategoryOperation
    {
        Task<CategoryModel> GetCategory(long id);
        Task AddCategory(CategoryModel model);
        Task UpdateCategory(CategoryModel model);
        Task DeleteCategory(long id);
    }
}
