using NordwindApi.Core.Infrastructure.EntityAbstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace NordwindApi.Core.Entiies
{
    public class CustomerDemographic:EntityBaseWithId
    {
        public string  Description { get; set; }
        public ICollection<CustomerCustomerDemo> CustomerCustomerDemos { get; set; }
    }
}
