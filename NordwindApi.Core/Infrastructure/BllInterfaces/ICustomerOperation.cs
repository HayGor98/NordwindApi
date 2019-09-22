using NordwindApi.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NordwindApi.Core.Infrastructure.BllInterfaces
{
    public interface ICustomerOperation
    {
        Task<CustomerModel> GetCustomer(long id);
        Task AddCustomer(CustomerModel model);
        Task UpdateCustomer(CustomerModel model);
        Task DeleteCustomer(long id);
    }
}
