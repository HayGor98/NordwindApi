using NordwindApi.Core.Infrastructure.EntityAbstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace NordwindApi.Core.Entiies
{
    public class Territory: EntityBaseWithId
    {
        public string TeritryDescription { get; set; }
        public int RegionID { get; set; }

       public ICollection<EmployeeTerritory> EmployeeTerritories { get; set; }
        public Region Region{ get; set; }
    }
}
