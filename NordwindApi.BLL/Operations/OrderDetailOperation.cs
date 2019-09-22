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
    public class OrderDetailOperation : IOrderDetailOperation
    {
        private readonly IRepositoryManager _manager;
        private readonly IMapper _mapper;
        public OrderDetailOperation(IRepositoryManager manager, IMapper mapper)
        {
            this._manager = manager;
            this._mapper = mapper;
        }
        public async Task AddOrderDetail(OrderDetailModel model)
        {
            var result = _mapper.Map<OrderDetail>(model);
            _manager.OrderDetails.Add(result);
            await _manager.CompleteAsync();
        }

        public async Task DeleteOrderDetail(long OrderID,long ProductID)
        {
            _manager.OrderDetails.DeleteWhere(x => x.OrderID == OrderID && x.ProductID == ProductID);
            await _manager.CompleteAsync(); 
        }

        public async Task<OrderDetailModel> GetOrderDetail(long OrderID, long ProductID)
        {
            var category = await _manager.OrderDetails.GetSingleAsync(x => x.OrderID==OrderID && x.ProductID == ProductID);
            var result = _mapper.Map<OrderDetailModel>(category);
            return result;
        }

        public async  Task UpdateOrderDetail(OrderDetailModel model)
        {
            var result = _mapper.Map<OrderDetail>(model);
            _manager.OrderDetails.Update(result);

            await _manager.CompleteAsync();
        }
    }
}
