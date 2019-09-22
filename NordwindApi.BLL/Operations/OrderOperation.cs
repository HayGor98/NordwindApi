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
    public class OrderOperation : IOrderOperation
    {
        private readonly IRepositoryManager _manager;
        private readonly IMapper _mapper;
        public OrderOperation(IRepositoryManager manager, IMapper mapper)
        {
            this._manager = manager;
            this._mapper = mapper;
        }
        public async  Task AddOrder(OrderModel model)
        {
            var result = _mapper.Map<Order>(model);
            _manager.Orders.Add(result);
            await _manager.CompleteAsync();
        }

        public  async Task DeleteOrder(long id)
        {
            _manager.Orders.DeleteWhere(x => x.Id == id);
            await _manager.CompleteAsync();
        }

        public async  Task<OrderModel> GetOrder(long id)
        {
            var category = await _manager.Orders.GetSingleAsync(x => x.Id == id);
            var result = _mapper.Map<OrderModel>(category);
            return result;
        }

        public async Task UpdateOrder(OrderModel model)
        {
            var result = _mapper.Map<Order>(model);
            _manager.Orders.Update(result);

            await _manager.CompleteAsync();
        }
    }
}
