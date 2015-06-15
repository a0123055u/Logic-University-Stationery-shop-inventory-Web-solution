using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Elephtan.DataModel;
using Elephtan.RequisitionService;

namespace Elephtan.StationeryDepartment
{
    public partial class DepartmentPendingRequestDetail : System.Web.UI.Page
    {
        RequisitionServiceSoapClient requisitionService =
            new RequisitionServiceSoapClient();

        private ArrayList itemList = new ArrayList();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            // Connect WebService Here
            RequisitionFindRequest findRequest = new RequisitionFindRequest();
            findRequest.RequisitionId = Request.QueryString["RequisitionId"];
                                                     
            RequisitionFindResponse response = 
                requisitionService.FindRequisitionDetailById(findRequest);

            if (null != response && "1".Equals(response.ServiceResponseCode))
            {
                this.requestDetailDate.Text = response.CreateTime;
                this.departmentName.Text = response.DepartmentName;
                this.staffName.Text = response.CreateUserName;
                RequisitionItem[] items = response.ItemList;
                List<Request> requestList = new List<Request>();
                // requestList.Add(request);

                this.requestDetailDate.Text = response.CreateTime;
                this.departmentName.Text = response.DepartmentName;
                this.staffName.Text = response.CreateUserName;
                

                foreach (RequisitionItem item in items)
                {
                    Request req = new Request();
                    req.Category = item.Category;
                    req.RequestDescription = item.ItemName;
                    req.MeasureUnit = item.Unit;
                    req.Quantity = item.ApplyAmount;
                    itemList.Add(req);
                }
            }
            
            this.requestDetailTable.DataSource = itemList;
            this.requestDetailTable.DataBind();
        }

        protected void rejectBtn_Click(object sender, EventArgs e)
        {

            string requisitionId = Request.QueryString["RequisitionId"];
            UpdateRequisitionStatus(requisitionId, "6" , this.feedbackTextBox.Text);
            Response.Redirect("~/StationeryDepartment/DepartmentHeadPendingRequest.aspx");
        }

        protected void approveBtn_Click(object sender, EventArgs e)
        {
            string requisitionId = Request.QueryString["RequisitionId"];
            UpdateRequisitionStatus(requisitionId, "2", this.feedbackTextBox.Text);
            Response.Redirect("~/StationeryDepartment/DepartmentHeadPendingRequest.aspx");
        }


        private bool UpdateRequisitionStatus(string requisitionId, string status, string advice){
             RequisitionManageRequest request
                = new RequisitionManageRequest();
            request.RequisitionId = requisitionId;
            request.RequisitionStatus = status;
            request.Advice = advice;
            request.RequestUserId = ((UserInfo)Session["currentUser"]).UserId;
            RequisitionManageResponse response = 
                requisitionService.UpdateRequisition(request);
            if (null != response && "1".Equals(response.ServiceResponseCode))
            {
                return true;
            }
            else {
                return false;
            }
        }

        protected void backButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/StationeryDepartment/DepartmentHeadPendingRequest.aspx");
        }
    }
}