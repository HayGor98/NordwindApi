using AutoMapper;
using NordwindApi.Core.Entities;
using NordwindApi.Core.Infrastructure.BllInterfaces;
using NordwindApi.Core.Infrastructure.RepositoryAbstraction;
using NordwindApi.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NordwindApi.BLL.Operations
{
    public class CategoryOperation : ICategoryOperation
    {
        private readonly IRepositoryManager _manager;
        private readonly IMapper _mapper;
        public CategoryOperation(IRepositoryManager manager, IMapper mapper)
        {
            this._manager = manager;
            this._mapper = mapper;
        }
        public async  Task AddCategory(CategoryModel model)
        {
            var result = _mapper.Map<Category>(model);
            _manager.Categories.Add(result);
            await _manager.CompleteAsync();
        }

        public async Task DeleteCategory(long id)
        {
            _manager.Categories.DeleteWhere(x => x.Id == id);
           await _manager.CompleteAsync();
        }

        public  async Task<CategoryModel> GetCategory(long id)
        {
            var category = await _manager.Categories.GetSingleAsync(x => x.Id == id);
            var result = _mapper.Map<CategoryModel>(category);
            return result;
        }

        public async Task UpdateCategory(CategoryModel model)
        {
            var result = _mapper.Map<Category>(model);
            _manager.Categories.Update(result);

            await _manager.CompleteAsync();
        }
    }
}
