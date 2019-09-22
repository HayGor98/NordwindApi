using AutoMapper;
using NordwindApi.Core.Entiies;
using NordwindApi.Core.Infrastructure.BllInterfaces;
using NordwindApi.Core.Infrastructure.RepositoryAbstraction;
using NordwindApi.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NordwindApi.BLL.Operations
{
    public class ProductOperation : IProductOperation
    {
        private readonly IRepositoryManager _manager;
        private readonly IMapper _mapper;
        public ProductOperation(IRepositoryManager manager, IMapper mapper)
        {
            this._manager = manager;
            this._mapper = mapper;
        }
        public async  Task AddProduct(ProductModel model)
        {
            var result = _mapper.Map<Product>(model);
            _manager.Products.Add(result);
            await _manager.CompleteAsync();
        }

        public async Task DeleteProduct(long id)
        {

            _manager.Products.DeleteWhere(x => x.Id == id);
            await _manager.CompleteAsync();
        }

        public async Task<ProductModel> GetProduct(long id)
        {
            var category = await _manager.Products.GetSingleAsync(x => x.Id == id);
            var result = _mapper.Map<ProductModel>(category);
            return result;
        }

        public async  Task UpdateProduct(ProductModel model)
        {
            var result = _mapper.Map<Product>(model);
            _manager.Products.Update(result);

            await _manager.CompleteAsync();
        }
    }
}
