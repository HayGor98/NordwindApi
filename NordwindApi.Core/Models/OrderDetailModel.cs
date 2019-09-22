using System;
using System.Collections.Generic;
using System.Text;

namespace NordwindApi.Core.Models
{
    public class OrderDetailModel
    {
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }
        public float Discount { get; set; }
    }
}
