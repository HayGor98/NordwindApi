using NordwindApi.Core.Entities;
using NordwindApi.Core.Infrastructure.EntityAbstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace NordwindApi.Core.Entiies
{
    public  class Product: EntityBaseWithId
    {
        public string ProductName { get; set; }
        public int? SupplierID { get; set; }
        public int? CategoryID { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal? UnitPrice { get; set; }
        public int? UnitslnStock { get; set; }
        public int? UnitONOrder { get; set; }
        public int? ReorderLevel { get; set; }
        public bool Discounted { get; set; }


      public  ICollection<OrderDetail> OrderDetails { get; set; }
        public Supplier Supplier { get; set; }
        public Category Categorie { get; set; }
    }
}
