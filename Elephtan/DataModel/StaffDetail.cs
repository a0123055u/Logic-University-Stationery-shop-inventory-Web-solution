using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Elephtan.DataModel
{
    public class StaffDetail
    {
        public string StaffId { get; set; }
        public string StaffName { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string CollectionPoint { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string AuthorizationId { get; set; }
    }
}