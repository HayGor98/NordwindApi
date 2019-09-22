using NordwindApi.Core.Entiies;
using NordwindApi.Core.Infrastructure.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace NordwindApi.DAL.Repositories
{
    public class CustomerRepository:RepositoryBase<Customer>,ICustomerRepository
    {
        public CustomerRepository(NordwindContext _context):base(_context)
        {

        }
    }
}
