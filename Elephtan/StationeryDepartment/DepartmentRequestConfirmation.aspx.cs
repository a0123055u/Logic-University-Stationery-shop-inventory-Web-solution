using Elephtan.DataModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Elephtan.RequisitionService;

namespace Elephtan.StationeryDepartment
{

  
    public partial class DepartmentRequestConfirmation : System.Web.UI.Page
    {
        RequisitionServiceSoapClient requisitionService
            = new RequisitionServiceSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            UserInfo currentUser = (UserInfo)Session["currentUser"];
            
            
            this.requestDetailDate.Text = DateTime.Now.ToString("dd/MMM/yyyy hh:mm:ss");
            this.departmentName.Text = currentUser.DepartmentName;
            this.staffName.Text = currentUser.UserName;

            ArrayList itemList = (ArrayList)Session["itemAddedResult"];

            this.requestDetailTable.DataSource = itemList;
            this.requestDetailTable.DataBind();

        }

        protected void backButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/SharedPages/RequestStationary.aspx");
        }
        
        protected void confirmButton_Click(object sender, EventArgs e)
        {
            // Connect to WebServer make requistion
            //
            //1.Create requisition
            RequisitionManageRequest request = new
                RequisitionManageRequest();
            UserInfo userInfo = (UserInfo)Session["currentUser"];
            request.RequestUserId = userInfo.UserId;
            RequisitionManageResponse response = 
                requisitionService.AddRequisition(request);
            
                if(null != response && "1".Equals(response.ServiceResponseCode))
                { 
                    string requisitionId = response.RequisitionId;

                    ArrayList itemList = (ArrayList)Session["itemAddedResult"];
                    RequisitionItemManageRequest itemRequest = null;
                    foreach(Item item in itemList){
                         //2.create requisition detail
                     itemRequest
                    = new RequisitionItemManageRequest();
                    itemRequest.ItemId = item.ItemReference;
                    itemRequest.RequisitionId = requisitionId;
                    itemRequest.ApplyAmount = item.Quantity;

                    RequisitionItemManageResponse itemReponse = 
                    requisitionService.AddRequisitionItem(itemRequest);
                }

                    Session["itemAddedResult"] = null;
                    Session["searchItemStr"] = null;

          

                Server.Transfer("~/SharedPages/RequestStationary.aspx");
                
            }


        }
    }
}