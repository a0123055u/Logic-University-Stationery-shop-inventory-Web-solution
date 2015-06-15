using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Elephtan.DataModel
{
    public class Disbursement
    {
        public string DisbursementId { get; set; }
        public string RequestDate { get; set; }
        public string Department { get; set; }
        public string RequestDescription { get; set; }
        public string DisbursementReference { get; set; }
        public string RequestItems { get; set; }

        public string State { get; set; }
        public string StateCode { get; set; }
    }
}