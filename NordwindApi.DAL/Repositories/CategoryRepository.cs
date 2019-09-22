using NordwindApi.Core.Entities;
using NordwindApi.Core.Infrastructure.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace NordwindApi.DAL.Repositories
{
    public class CategoryRepository: RepositoryBase<Category>,ICategoryRepository
    {
        public CategoryRepository(NordwindContext _context):base(_context)
        {
        }
    }
}
