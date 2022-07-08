using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SecureWebApp.Models
{
    public class Order
    {
        public int ProductID { get; set; }
        public string Product { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public DateTime OrderDate { get; set; }
        public string Status { get; set; }
    }
}