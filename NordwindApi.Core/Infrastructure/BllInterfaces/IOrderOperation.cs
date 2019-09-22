using NordwindApi.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NordwindApi.Core.Infrastructure.BllInterfaces
{
   public interface IOrderOperation
    {
        Task<OrderModel> GetOrder(long id);
        Task AddOrder(OrderModel model);
        Task UpdateOrder(OrderModel model);
        Task DeleteOrder(long id);
    }
}
