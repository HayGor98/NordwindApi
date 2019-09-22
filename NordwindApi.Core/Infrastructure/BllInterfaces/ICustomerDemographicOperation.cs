using NordwindApi.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NordwindApi.Core.Infrastructure.BllInterfaces
{
    public interface ICustomerDemographicOperation
    {
        Task<CustomerDemographicModel> GetCustomerDemographic(long id);
        Task AddCustomerDemographic(CustomerDemographicModel model);
        Task UpdateCustomerDemographic(CustomerDemographicModel model);
        Task DeleteCustomerDemographic(long id);
    }
}
