using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Elephtan.DataModel
{
    public class StationaryItem
    {
        public StationaryItem() { }

        public string ItemNumber { get; set; }
        public string Catagory { get; set; }
        public string Description { get; set; }
        public string UnitOfMeasure { get; set; }
        public string Quantity { get; set; }
        public string ItemReference { get; set; }

    }
}