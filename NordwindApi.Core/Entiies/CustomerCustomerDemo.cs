using NordwindApi.Core.Infrastructure.EntityAbstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace NordwindApi.Core.Entiies
{
    public class CustomerCustomerDemo:EntityBase
    {
        public int CustomerID { get; set; }
        public int CustomerTypeID { get; set; }

        public Customer Customer { get; set; }
        public CustomerDemographic CustomerDemographic {get; set;}
    }
}
