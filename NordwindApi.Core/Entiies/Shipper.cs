using NordwindApi.Core.Infrastructure.EntityAbstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace NordwindApi.Core.Entiies
{
    public class Shipper: EntityBaseWithId
    {
        public string Companyname { get; set; }
        public string Phone { get; set; }

        public ICollection<Order> Orders { set; get; }
    }
}
