using NordwindApi.Core.Entiies;
using NordwindApi.Core.Infrastructure.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace NordwindApi.DAL.Repositories
{
    public class ShipperRepository:RepositoryBase<Shipper>,IShipperRepository
    {
        public ShipperRepository (NordwindContext _context) : base(_context)
        {

        }
    }
}
