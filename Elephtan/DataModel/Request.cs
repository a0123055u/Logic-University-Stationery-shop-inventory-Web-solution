using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Elephtan.DataModel
{
    public class Request
    {
        public Request(string id, string date, string description)
        {
            this.RequestId = id;
            this.RequestDate = date;
            this.RequestDescription = description;
        }
        public Request()
        {

        }
        public string RequestId { get; set; }
        public string RequestDate { get; set; }
        public string RequestDescription { get; set; }
        public string Category { get; set; }
        public string MeasureUnit { get; set; }
        public string Quantity { get; set; }
        public string RequisitionId { get; set; }
        public string Applicant { get; set; }
        public string Department { get; set; }
        public string DepartmentId { get; set; }

    }
}