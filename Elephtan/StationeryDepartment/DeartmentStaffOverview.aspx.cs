using Elephtan.DataModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.DataVisualization.Charting;
using System.Web.UI.WebControls;
using Elephtan.RequisitionService;
using Elephtan.UserService;

namespace Elephtan.StationeryDepartment
{
    public partial class DeartmentStaffOverview : System.Web.UI.Page
    {
        private const string currentRequestDetail = "~/StationeryDepartment/DepartmentRequestDetail.aspx?from=currentRequestTable";
        private const string previousRequestDetail = "~/StationeryDepartment/DepartmentRequestDetail.aspx?from=previousRequestTable";
        
        private ArrayList previousRequests;
        private ArrayList applingRequests;
        
        void Page_Load(Object sender, EventArgs e)
        {
            if (true)
            {


                UserInfo currentUser = (UserInfo)Session["currentUser"];

                // Get Requests List for appling requests (List)


                // applingRequest List for GridView Display
                applingRequests = new ArrayList();

                // Setting up findRequest by UserId
                // Setting up findRequest by Request Status
                // 1-appling 2-approved 3-???

                this.findRequisitionList(applingRequests, "1", currentUser);

                // Bind CurrentRequestTable with applingRequest
                // display ArrayList
                this.CurrentRequestTable.DataSource = applingRequests;
                this.CurrentRequestTable.DataBind();

                // previousRequest List for GridView Display
                previousRequests = new ArrayList();

                // Get request for previous requests (List)

                this.findRequisitionList(previousRequests, "2", currentUser);

                //request.UserId = userInfo.UserId;
                //request.RequestUserId = userInfo.UserId;
                //requisitionService.FindRequisitionListByUserId(request);

                // this.fillRequestsList(previousRequests, previousRequestListResponse)

                // Bind PreviousRequestTable with previousRequest
                // display ArrayList
                this.PreviousRequestTable.DataSource = previousRequests;
                this.PreviousRequestTable.DataBind();
            }
        }

        private void findRequisitionList(ArrayList arrayList, string state, UserInfo currentUser) 
        {
            RequisitionServiceSoapClient requisitionService = new RequisitionServiceSoapClient();
            RequisitionFindListRequest request = new RequisitionFindListRequest();
            request.RequestUserId = currentUser.UserId;
            request.UserId = currentUser.UserId;
            request.RequisitionStatus = state;
            RequisitionFindListResponse response =
                requisitionService.FindRequisitionListByUserId(request);

            if (null != response && "1".Equals(response.ServiceResponseCode)) {
                RequisitionFindResponse[] findList=  response.Requisitions;
                if (findList != null) {

                    //iterete requisitions
                    foreach (RequisitionFindResponse entry in findList) {
                        string requisitionId = entry.RequisitionId;
                        string userName = entry.CreateUserName;

                        //ieterate requisiton items
                        RequisitionItem[] items = entry.ItemList;

                        Request req = new Request();
                        req.RequestDate = entry.CreateTime;
                        string descriptionStr = null;
                        foreach (var i in items) {
                            descriptionStr += i.ItemName + ", ";
                        }


                        if (descriptionStr == null)
                            descriptionStr = "No Items";

                        if (descriptionStr.Length > 50)
                        {
                            req.RequestDescription = descriptionStr.Substring(0, 50);
                        }
                        else
                        {
                            req.RequestDescription = descriptionStr;
                        }
                        req.RequisitionId = entry.RequisitionId;
                        req.RequestId = entry.RequisitionId;
                        arrayList.Add(req);
                    }
                }
            }
        }
     

        private void fillRequestsList(ArrayList requestList, RequisitionFindListResponse requisitionFindListResponse)
        {
            if (requisitionFindListResponse.Requisitions != null)
            {
                foreach (RequisitionFindResponse entry in requisitionFindListResponse.Requisitions)
                {
                    Request request = new Request();
                    request.RequestId = entry.RequisitionId;
                    request.RequestDate = entry.CreateTime;
                    string description = null;
                    if (entry.ItemList != null)
                    {
                        foreach (RequisitionItem item in entry.ItemList)
                        {
                            description = item.ItemName + " ,";
                        }
                    }
                    if (description == null)
                        description = "No Items";
                    if (description.Length > 50)
                    {
                        description = description.Substring(0, 50);
                        description += "...";
                    }
                    else
                    {
                        description = string.Empty;
                    }
                    request.RequestDescription = description;
                    requestList.Add(request);
                }
            }
        }

        protected void CurrentRequestTable_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            Int32 index = Convert.ToInt32(e.CommandArgument);
            string req = ((Request)applingRequests[index]).RequisitionId;
            Debug.WriteLine(">>> ApplingRequestIndexSelectd: " + index);

            //Session[SessionObjectList.selectedRequest] = applingRequests[index];

            Response.Redirect(currentRequestDetail+"&RequisitionId="+req);
        }

        protected void PreviousRequestTable_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            Int32 index = Convert.ToInt32(e.CommandArgument);

            string req = ((Request)previousRequests[index]).RequestId;

            Debug.WriteLine(">>> PreviousRequestIndexSelected:  " + index);

            //Session[SessionObjectList.selectedRequest] = previousRequests[index];

            Server.Transfer(previousRequestDetail+"&RequisitionId="+req);
        }
    }
}