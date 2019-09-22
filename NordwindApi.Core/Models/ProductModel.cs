using System;
using System.Collections.Generic;
using System.Text;

namespace NordwindApi.Core.Models
{
    public class ProductModel
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
    }
}
