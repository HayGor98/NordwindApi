using NordwindApi.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NordwindApi.Core.Infrastructure.BllInterfaces
{
    public interface ISupplierOperation
    {
        Task<SupplierModel> GetSupplier(long id);
        Task AddSupplier(SupplierModel model);
        Task UpdateSupplier(SupplierModel model);
        Task DeleteSupplier(long id);
    }
}
