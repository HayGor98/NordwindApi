using NordwindApi.Core.Infrastructure.EntityAbstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace NordwindApi.Core.Entiies
{
    public class EmployeeTerritory: EntityBase
    {
        public int EmployeeID { get; set; }
        public int TeritoryID { get; set; }

        public Employer Employe { get; set; }
        public Territory Territory { get; set; }
    }
}
