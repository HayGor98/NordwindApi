using NordwindApi.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NordwindApi.Core.Infrastructure.BllInterfaces
{
    public interface IShipperOperation
    {
        Task<ShipperModel> GetShipper(long id);
        Task AddShipper(ShipperModel model);
        Task UpdateShipper(ShipperModel model);
        Task DeleteShipper(long id );
    }
}
