using NordwindApi.Core.Infrastructure.EntityAbstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace NordwindApi.Core.Entiies
{
    public class Region: EntityBaseWithId
    {
        public string RegionDescription { get; set; }

       public ICollection<Territory> Territorie { set; get; }
    }
}
