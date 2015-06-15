using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Elephtan.DisbursementService;
using Elephtan.DataModel;
using store.sg.edu.nus.utility;

namespace Elephtan.StationeryStore
{
    public partial class StationaryStoreDisbursmentDetail : System.Web.UI.Page
    {

        private ArrayList disbursementItemList = null;
        DisbursementServiceSoapClient disbursementService
            = new DisbursementServiceSoapClient();
      

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Connect Webservice here.
                Session["disbursementDetailsId"] = Request.QueryString["disbursementId"];
                ArrayList list = new ArrayList();
                this.LoadDisbursementDetails(list);
                Session["disbursementItemList"] = list;
                this.disburseDetailTable.DataSource = list;
                this.disburseDetailTable.DataBind();
                SetGridViewTextBox(list);

                string stateStr = Request.QueryString["state"];

                Session["DisbursementStatus"] = stateStr;
                if (stateStr == "2" || stateStr == "3")
                {
                    this.confirmButton.Visible = false;
                }



            }
        }

        protected void backBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/StationeryStore/StationaryStoreDisbursement.aspx");
        }

        protected void confirmButton_Click(object sender, EventArgs e)
        {
            // WebService
            DisbursementManageRequest request =
                new DisbursementManageRequest();

          
            UserInfo userInfo = (UserInfo) Session["currentUser"];

            request.RequestUserId = userInfo.UserId;
            request.DisbursementId = (string)Session["disbursementDetailsId"];
            DisbursementManageResponse response = 
                disbursementService.ConfirmStoreDisbursement(request);
            if (null != response && "1".Equals(response.ServiceResponseCode)) {

                Session["disbursementDetailsId"] = null;
                Session["disbursementItemList"] = null;
            }
            Response.Redirect("~/StationeryStore/StationaryStoreDisbursement.aspx");
        }

        protected void updateBtn_Click(object sender, GridViewCommandEventArgs e)
        {
            Int32 index = Convert.ToInt32(e.CommandArgument);

            TextBox quantityTextBox = (TextBox)this.disburseDetailTable.Rows[index].Cells[4].FindControl("quantityBox");
            ArrayList list = (ArrayList)(Session["disbursementItemList"]);
            Item item = (Item)list[index];
            
            DisbursementDetailManageRequest request
                = new DisbursementDetailManageRequest();

            request.AssignedQuanntity = quantityTextBox.Text;
            request.DisbursementDetailId = item.ItemReference;

            DisbursementDetailManageResponse response = 
                disbursementService.UpdateDisbursementDetail(request);
           
            if (response != null && "1".Equals(response.ServiceResponseCode))
            {
                //reload the data list
                ArrayList disbursementList = new ArrayList();
                this.LoadDisbursementDetails(disbursementList);
                Session["disbursementItemList"] = disbursementList;
                this.disburseDetailTable.DataSource = disbursementList;
                this.disburseDetailTable.DataBind();
                SetGridViewTextBox(disbursementList);
            }
        }

        private void SetGridViewTextBox(ArrayList list) {

            string disbursementStatus =
                 (string)Session["DisbursementStatus"];
            if (null != this.disburseDetailTable.DataSource)
            {
                for (int i = 0; i < this.disburseDetailTable.Rows.Count; i++)
                {
                    TextBox quantityBox = (TextBox)this.disburseDetailTable.Rows[i].Cells[4].FindControl("quantityBox");

                    if (null != quantityBox)
                    {

                        quantityBox.Text = ((Item)(list[i])).actualQuantity;
                        if (disbursementStatus == "2"
                            || disbursementStatus=="3")
                        {
                            quantityBox.Enabled = false;  
                        }
                    }
                }
            }
        }

        private void LoadDisbursementDetails(ArrayList disbursementItemList)
        {
            if(disbursementItemList == null)
                 disbursementItemList = new ArrayList();

            string disbursementId = (string)Session["disbursementDetailsId"];
            DisbursementFindRequest request =
                   new DisbursementFindRequest();
            request.DisbursementId = disbursementId;

            DisbursementFindResponse response =
               disbursementService.QueryDisbursementById(request);

            if (null != response && "1".Equals(response.ServiceResponseCode))
            {
                DisbursementDetail[] details =
                response.DisbursementDetailList;


                this.departmentName.Text = response.DepartmentName;
                this.representitiveName.Text = response.RepresentativeName;
                this.representitiveName.Text = response.CollectionPointAddress;


                if (null != details)
                {
                    foreach (DisbursementDetail entry in details)
                    {
                        ////
                        Item item = new Item();
                        item.Catagory = entry.ItemNum;
                        item.ItemReference = entry.DisbursementDetailId;
                        item.Description = entry.ItemName;
                        item.UnitOfMeasure = SystemUtility.GetDictString("UnitCd", entry.Unit);
                        item.Quantity = entry.AppliedQuantity;
                        item.actualQuantity = entry.AssignedQuantity;

                        disbursementItemList.Add(item);

                    }
                }
            }


        }

    }
}