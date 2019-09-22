using NordwindApi.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NordwindApi.Core.Infrastructure.BllInterfaces
{
    public interface IProductOperation
    {
        Task<ProductModel> GetProduct(long id);
        Task AddProduct(ProductModel model);
        Task UpdateProduct(ProductModel model);
        Task DeleteProduct(long id);

    }
}
