using NordwindApi.Core.Entiies;
using NordwindApi.Core.Infrastructure.EntityAbstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace NordwindApi.Core.Entities
{

   public class Category:EntityBaseWithId
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int?  Picture { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
