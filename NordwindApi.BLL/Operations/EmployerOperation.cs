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
    public class EmployerOperation : IEmployerOperation
    {
        private readonly IRepositoryManager _manager;
        private readonly IMapper _mapper;
        public EmployerOperation(IRepositoryManager manager, IMapper mapper)
        {
            this._manager = manager;
            this._mapper = mapper;
        }
        public async  Task AddEmployer(EmployerModel model)
        {
            var result = _mapper.Map<Employer>(model);
            _manager.Employee.Add(result);
            await _manager.CompleteAsync();
        }

        public async  Task DeleteEmployer(long id)
        {
            _manager.Employee.DeleteWhere(x => x.Id == id);
            await _manager.CompleteAsync();
        }

        public async Task<EmployerModel> GetEmployer(long id)
        {
            var category = await _manager.Employee.GetSingleAsync(x => x.Id == id);
            var result = _mapper.Map<EmployerModel>(category);
            return result;
        }

        public async  Task UpdateEmployer(EmployerModel model)
        {
            var result = _mapper.Map<Employer>(model);
            _manager.Employee.Update(result);
            await _manager.CompleteAsync();
        }
    }
}
