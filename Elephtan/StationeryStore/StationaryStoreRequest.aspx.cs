using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Elephtan.RequisitionService;
using Elephtan.DataModel;
using Elephtan.RetrievingService;
using Elephtan.OrderService;

namespace Elephtan.StationeryStore
{
    public partial class StationaryStoreRequest : System.Web.UI.Page
    {
        private ArrayList requestList = new ArrayList();
        private ArrayList retriverHistoryList = new ArrayList();
        
        RequisitionServiceSoapClient requisitionService
            = new RequisitionServiceSoapClient();

        RetrievingServiceSoapClient retrievingService =
            new RetrievingServiceSoapClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            // Connect to webservice here
            RequisitionFindListRequest request = new RequisitionFindListRequest();
            request.RequisitionDetailStatus = "1";
            request.RequisitionStatus = "2";
            RequisitionFindListResponse response = 
            requisitionService.FindRequisitionGroupByDepartment(request);
            if (null != response && "1".Equals(response.ServiceResponseCode)) {
                
                RequisitionFindResponse[] requisitions = 
                response.Requisitions;
                foreach(RequisitionFindResponse entry in requisitions){
                    string departmentName = entry.DepartmentName;
                    string departmentId = entry.DepartmentId;
                    Request req = new Request();
                    req.RequestId = entry.RequisitionNo;
                    req.RequestDate = entry.CreateTime;
                    req.Department = entry.DepartmentName;
                    req.RequestDescription = "";
                    req.DepartmentId = departmentId;
                    //req.RequisitionId = entry.RequisitionId;


                    RequisitionItem[] items = entry.ItemList;

                    if (null != items) {
                        foreach (RequisitionItem item in items) {
                            req.RequestDescription += item.ItemName + ", ";
                        
                        }
                        if (req.RequestDescription.Length > 25)
                            req.RequestDescription.Substring(0, 25);
                    }
                    

                    this.requestList.Add(req);
                    Session["requestList"] = requestList;
                }
            }
            this.requestsTable.DataSource = requestList;
            this.requestsTable.DataBind();


            

            
        }

        protected void requestDetailBtn_Click(object sender, GridViewCommandEventArgs e)
        {
            Int32 index = Convert.ToInt32(e.CommandArgument);


            ArrayList list = (ArrayList)(Session["requestList"]);
            Request req = (Request)(list[index]);


            Response.Redirect("~/StationeryStore/StationaryStoreRequestDetail.aspx?DepartmentId=" + req.DepartmentId);
        }

        protected void generateRetrivalListBtn_Click(object sender, EventArgs e)
        {
            // Web service Generate Retrival List!!!!
            RetrievingManageRequest retrievingRequest =
                new RetrievingManageRequest();
            UserInfo userInfo = (UserInfo)Session["currentUser"];
            retrievingRequest.RequestUserId = userInfo.UserId;

            RetrievingManageResponse retrievingResponse = 
                retrievingService.GenereateRetrievingForm(retrievingRequest);
            string retrievingId = null;
            if (null != retrievingResponse && "1".Equals(retrievingResponse.ServiceResponseCode)) {

                retrievingId = retrievingResponse.RetrievingId;
                /////
                Session["requestList"] = null;
                this.Page_Load(sender, e);
            }

            Response.Redirect("~/StationeryStore/StationaryStoreRetrival.aspx");

        }

    }
}