using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Elephtan.DataModel
{
    public class Voucher
    {

        public string VoucherID { get; set; }
        public string VoucherDate { get; set; }
        public string IssueItems { get; set; }
        public string IssueAmount { get; set; }
        public string VoucherReference { get; set; }
    }
}