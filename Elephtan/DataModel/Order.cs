using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Elephtan.DataModel
{
    public class Order
    {
        public string RequestId { get; set; }
        public string RequestDate { get; set; }
        public string Supplier { get; set; }
        public string Description { get; set; }
        public string OrderReference { get; set; }
        public string status { get; set; }
        public string deliveryId { get; set; }
    }
}