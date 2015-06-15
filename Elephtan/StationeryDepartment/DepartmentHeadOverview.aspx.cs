using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Elephtan.RequisitionService;
using Elephtan.DataModel;

namespace Elephtan.StationeryDepartment
{
    public partial class DepartmentHeadOverview : System.Web.UI.Page
    {
        RequisitionServiceSoapClient requisitionService
            = new RequisitionServiceSoapClient();

        private ArrayList previousRequests = new ArrayList();
        private const string previousRequestDetail = "~/StationeryDepartment/DepartmentRequestDetail.aspx?from=previousRequestTable";    
        protected void Page_Load(object sender, EventArgs e)
        {
            UserInfo userInfo = (UserInfo)Session["currentUser"];
            // connect to webservice here
            RequisitionFindListRequest findRequest =
                new RequisitionFindListRequest();
            findRequest.DepartmentId = userInfo.DepartmentId;
            findRequest.ApproveUserId = userInfo.UserId;
             RequisitionFindListResponse findResponse = 
            requisitionService.FindRequisitionListByDepartmentId(findRequest);
             if (null != findResponse && "1".Equals(findResponse.ServiceResponseCode)) {
                RequisitionFindResponse[] requisitions =  findResponse.Requisitions;
                foreach (RequisitionFindResponse entry in requisitions) {
                    Request request = new Request();
                    request.RequestDate = entry.CreateTime;
                    request.RequestId = entry.RequisitionId;

                    string descStr = "";

                    foreach (RequisitionItem i in entry.ItemList) 
                    {
                        descStr += i.ItemName + " ";
                    }
                    if (descStr == null)
                        descStr = "No Item";
                    if (descStr.Length > 50)
                        descStr = descStr.Substring(0, 50);
                    request.RequestDescription = descStr;
                    previousRequests.Add(request);
                }
             }

            this.pastApprovedTable.DataSource = previousRequests;
            this.pastApprovedTable.DataBind();
  
        }

        protected void pastApprovedTable_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            Int32 index = Convert.ToInt32(e.CommandArgument);
            Debug.WriteLine(index);

            Request req = (Request)(previousRequests[index]);

            Response.Redirect(previousRequestDetail + "&RequisitionId=" + req.RequestId);
        }

    }
}