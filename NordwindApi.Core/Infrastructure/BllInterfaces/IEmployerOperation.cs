using NordwindApi.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NordwindApi.Core.Infrastructure.BllInterfaces
{
    public interface IEmployerOperation
    {
        Task<EmployerModel> GetEmployer(long id);
        Task AddEmployer(EmployerModel model);
        Task UpdateEmployer(EmployerModel model);
        Task DeleteEmployer(long id);
    }
}
