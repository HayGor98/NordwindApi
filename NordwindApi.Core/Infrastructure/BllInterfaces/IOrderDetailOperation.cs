using NordwindApi.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NordwindApi.Core.Infrastructure.BllInterfaces
{
    public interface IOrderDetailOperation
    {
        Task<OrderDetailModel> GetOrderDetail(long id);
        Task AddOrderDetail(OrderDetailModel model);
        Task UpdateOrderDetail(OrderDetailModel model);
        Task DeleteOrderDetail(long id);
    }
}
