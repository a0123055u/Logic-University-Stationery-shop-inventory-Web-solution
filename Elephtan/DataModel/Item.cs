using Elephtan.ItemService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Elephtan.DataModel
{
    public class Item
    {
        public string ItemNumber { get; set; }
        public string Catagory { get; set; }
        public string CatagoryId { get; set; }
        public string Description { get; set; }
        public string UnitOfMeasure { get; set; }
        public string Quantity { get; set; }
        public string CurrentStock { get; set; }
        public string ItemId { get; set; }
        public string ItemReference { get; set; }
        public string price { get; set; }
        public string Supplier { get; set; }
        public string ItemState { get; set; }

        public SupplierEntry[] suppliserList { get; set; }

        public string selectedSupplier { get; set; }
        public string actualQuantity { get; set; }
    }
}