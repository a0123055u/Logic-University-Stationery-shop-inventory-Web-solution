using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Elephtan.DepartmentService;
using Elephtan.RequisitionService;
using Elephtan.DataModel;
using store.sg.edu.nus.utility;

namespace Elephtan.StationeryStore
{
    public partial class StationaryStoreRequestDetail : System.Web.UI.Page
    {

        private ArrayList requestItemsList = new ArrayList();
        DepartmentServiceSoapClient departmentService =
             new DepartmentServiceSoapClient();

        RequisitionServiceSoapClient requisitionService
            = new RequisitionServiceSoapClient();

 
        protected void Page_Load(object sender, EventArgs e)
        {

            string departmentId = Request.QueryString["DepartmentId"];

            // Web Service
            DepartmentFindRequest departmentRequest =
                new DepartmentFindRequest();
            departmentRequest.DepartmentId = departmentId;
            DepartmentFindResponse departmentResponse
                =  departmentService.QueryDepartment(departmentRequest);
            if(null != departmentResponse && "1".Equals(departmentResponse.ServiceResponseCode)){
                 //show department info from departmentResponse
                this.departmentName.Text = departmentResponse.DepartmentName;
                this.representitiveName.Text = departmentResponse.RepresentativeName;
                this.representitveEmail.Text = departmentResponse.CollectionAddress;
            }


            // Connect to webservice here
            RequisitionFindListRequest request = new RequisitionFindListRequest();
            request.RequisitionDetailStatus = "1";
            request.RequisitionStatus = "2";
            request.DepartmentId = departmentId;
            RequisitionFindListResponse response = 
            requisitionService.FindRequisitionGroupByDepartment(request);
            if (null != response && "1".Equals(response.ServiceResponseCode))
            {

                RequisitionFindResponse[] requisitions =
                response.Requisitions;
                foreach (RequisitionFindResponse entry in requisitions)
                {
                    string departmentName = entry.DepartmentName;
                    
                    //req.RequisitionId = entry.RequisitionId;

                    RequisitionItem[] items = entry.ItemList;
                    foreach (RequisitionItem item in items) {

                        Item i = new Item();
                        i.Catagory = item.ItemNum;
                        i.Description = item.ItemName;
                        i.UnitOfMeasure = SystemUtility.GetDictString("UnitCd", item.Unit);
                        i.Quantity = item.ApplyAmount;
                        i.ItemReference = item.ItemId;

                        requestItemsList.Add(i);
                    }
                   
                }
            }


            this.requestDetailTable.DataSource = requestItemsList;
            this.requestDetailTable.DataBind();
        }

        protected void backBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/StationeryStore/StationaryStoreRequest.aspx");
        }
    }
}