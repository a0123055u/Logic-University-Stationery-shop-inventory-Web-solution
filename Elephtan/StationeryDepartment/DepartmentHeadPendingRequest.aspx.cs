using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Elephtan.DataModel;
using System.Diagnostics;
using Elephtan.RequisitionService;

namespace Elephtan.StationeryDepartment
{
    public partial class DepartmentHeadPendingRequest : System.Web.UI.Page
    {
        RequisitionServiceSoapClient requisitionService
            = new RequisitionServiceSoapClient();

        private ArrayList pendingRequestList = new ArrayList();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            // Get Web Service here

            UserInfo userInfo = (UserInfo)Session["currentUser"];
            // connect to webservice here
            RequisitionFindListRequest findRequest =
                new RequisitionFindListRequest();
            findRequest.DepartmentId = userInfo.DepartmentId;
            findRequest.RequisitionStatus = "1";
             RequisitionFindListResponse findResponse = 
            requisitionService.FindRequisitionListByDepartmentId(findRequest);
             if (null != findResponse && "1".Equals(findResponse.ServiceResponseCode))
             {
                 RequisitionFindResponse[] requisitions = findResponse.Requisitions;
                 foreach (RequisitionFindResponse entry in requisitions)
                 {
                     /////////////////
                     Request req = new Request();
                     req.RequestDate = entry.CreateTime;
                     req.Applicant = entry.CreateUserName;
                     req.RequestDescription = "";
                     req.RequestId = entry.RequisitionId;
                     foreach (RequisitionItem i in entry.ItemList)
                     {
                         req.RequestDescription += i.ItemName + " ";
                     }

                     if (req.RequestDescription.Length > 25)
                         req.RequestDescription.Substring(0, 25);

                     pendingRequestList.Add(req);
                 }
             }

            // Show Empty Table
            this.pendingRequestTable.DataSource = pendingRequestList;
            this.pendingRequestTable.DataBind();
        }

        protected void pendingRequestDetail_Click(object sender, GridViewCommandEventArgs e)
        {
            Int32 index = Convert.ToInt32(e.CommandArgument);

            Debug.WriteLine("index: " + index);

            Request selectedRequest = (Request)pendingRequestList[index];

            Response.Redirect("~/StationeryDepartment/DepartmentPendingRequestDetail.aspx?RequisitionId="+selectedRequest.RequestId);
        }
    }
}