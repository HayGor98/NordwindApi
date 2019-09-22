using NordwindApi.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NordwindApi.Core.Infrastructure.BllInterfaces
{
    public interface ICustomerCustomerDemoOperation
    {
        Task<CustomerCustomerDemoModel> GetCustomerCustomerDemo(long CustomerID, long CustomerTypeID);
        Task AddCustomerCustomerDemo(CustomerCustomerDemoModel model);
        Task UpdateCustomerCustomerDemo(CustomerCustomerDemoModel model);
        Task DeleteCustomerCustomerDemo(long CustomerID, long CustomerTypeID);
    }
}
