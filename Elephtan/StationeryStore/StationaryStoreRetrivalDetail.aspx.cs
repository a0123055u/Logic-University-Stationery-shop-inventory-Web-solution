using Elephtan.DataModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Elephtan.RetrievingService;
using Elephtan.DisbursementService;
using store.sg.edu.nus.utility;

namespace Elephtan.StationeryStore
{
    public partial class StationaryStoreRetrivalDetail : System.Web.UI.Page
    {
        private ArrayList retirvingList = new ArrayList();

        RetrievingServiceSoapClient retrievingService
            = new RetrievingServiceSoapClient();

        DisbursementServiceSoapClient disbursementService
            = new DisbursementServiceSoapClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            string retrievingId = Request.QueryString["retirvingId"];
            string stateId = Request.QueryString["state"];

            if (stateId == "Confirmed")
            {
                this.confirmButton.Visible = false;
            }
            // Web Service Here

            RetrievingFindRequest request = new RetrievingFindRequest();
            request.RetrievingId = retrievingId;

            RetrievingFindResponse response = 
                retrievingService.FindRetrievingById(request);
            if (null != response && "1".Equals(response.ServiceResponseCode)) {

                RetrievingDetail[] details = response.RetrievingDetailList;
                if (null != details) {
                    foreach (RetrievingDetail detail in details) { 
                        //
                        //
                        Item i = new Item();
                        i.Catagory = detail.ItemNum;
                        i.Description = detail.ItemName;
                        i.UnitOfMeasure = SystemUtility.GetDictString("UnitCd", detail.Unit);
                        i.Quantity = detail.AppliedQuantity;
                        retirvingList.Add(i);
                    }
                }
            }

            this.requestDetailTable.DataSource = retirvingList;
            this.requestDetailTable.DataBind();
        }

        protected void backBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/StationeryStore/StationaryStoreRetrival.aspx");
        }

        protected void confirmBtn_Click(object sender, EventArgs e)
        {
            // Web Service confirm
            DisbursementManageRequest request
                = new DisbursementManageRequest();

            UserInfo userInfo = (UserInfo)Session["currentUser"];

            request.RequestUserId = userInfo.UserId;
            DisbursementManageResponse response = 
                disbursementService.GenerateDisbursementForm(request);

            if (null != response && "1".Equals(response.ServiceResponseCode)) { 
            

            }

            Response.Redirect("~/StationeryStore/StationaryStoreRetrival.aspx");
        }
    }
}