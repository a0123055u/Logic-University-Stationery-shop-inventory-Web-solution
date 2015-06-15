using Elephtan.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using  Elephtan.RequisitionService;
using store.sg.edu.nus.utility;

namespace Elephtan.StationeryDepartment
{
    public partial class DepartmentRequestDetail : System.Web.UI.Page
    {
        private const string DEPARTMENT_OVERVIEW_PAGE = "~/StationeryDepartment/DeartmentStaffOverview.aspx";
        RequisitionServiceSoapClient requisitionService = new RequisitionServiceSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            // Get selected request obj
            Request request = new Request();
            
            // Connect Web Service Here
            //
            
            RequisitionFindRequest findRequest = new RequisitionFindRequest();
            findRequest.RequisitionId = Request.QueryString["RequisitionId"];
                                                     
            RequisitionFindResponse response = 
                requisitionService.FindRequisitionDetailById(findRequest);
         
            if (null != response && "1".Equals(response.ServiceResponseCode))
            {
                RequisitionItem[] items = response.ItemList;
                
                this.requestDetailDate.Text = response.CreateTime;
                this.departmentName.Text = response.DepartmentName;
                this.staffName.Text = response.CreateUserName;

                List<Request> requestList = new List<Request>();
                // requestList.Add(request);

                foreach (var item in items)
                {
                    Request req = new Request();
                    req.Category = item.Category;
                    req.RequestDescription = item.ItemName;
                    req.MeasureUnit = SystemUtility.GetDictString("UnitCd", item.Unit);
                    req.Quantity = item.ApplyAmount;
                    requestList.Add(req);
                }

                this.requestDetailTable.DataSource = requestList;
                this.requestDetailTable.DataBind();

                var origin = Request.QueryString["from"];


                if (origin != null)
                {
                    origin = origin.ToLower();
                    if (origin.Equals("currentrequesttable"))
                    {
                        this.deleteButton.Visible = true;

                    }
                    else if (origin.Equals("previousrequesttable"))
                    {
                        this.deleteButton.Visible = false;
                    }
                }
            }
        }

        protected void backButton_Click(object sender, EventArgs e)
        {

            UserInfo currentUser = (UserInfo)Session["currentUser"];

            if (currentUser.Roles[0] == "Head")
            {
                Response.Redirect("~/StationeryDepartment/DepartmentHeadOverview.aspx");
            }
            else
            {
                Response.Redirect(DEPARTMENT_OVERVIEW_PAGE);
            }

            
            
            

        }

        protected void deleteButton_Click(object sender, EventArgs e) 
        {
            // Connect to WebService Here
            RequisitionManageRequest requsitionRequest = new RequisitionManageRequest();
            requsitionRequest.RequisitionId = Request.QueryString["RequisitionId"];
            requsitionRequest.RequisitionStatus = "5";
            RequisitionManageResponse response = requisitionService.UpdateRequisition(requsitionRequest);
            if (null != response && "1".Equals(response.ServiceResponseCode)) {
                Response.Redirect(DEPARTMENT_OVERVIEW_PAGE);
            }
           
        }

    }
}