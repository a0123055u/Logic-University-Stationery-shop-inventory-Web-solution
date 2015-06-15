using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Elephtan.AdjustmentService;
namespace Elephtan.StationeryStore
{
    public partial class StationaryStorePendingVoucherDetail : System.Web.UI.Page
    {
        AdjustmentServiceSoapClient adjustmentService
            = new AdjustmentServiceSoapClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            string voucherId = Request.QueryString["voucherId"];

            // Web Service Here
            AdjustmentFindRequest request =
                new AdjustmentFindRequest();
            request.AdjustmentId = voucherId;
            if (Session["AdjustmentId"] == null)
                Session["AdjustmentId"] = voucherId;

            AdjustmentFindResponse adjustmentResponse = 
                adjustmentService.QueryAdjustById(request);
            if (null != adjustmentResponse && "1".Equals(adjustmentResponse.ServiceResponseCode))
            {
                
                AdjustmentDetail[] details = adjustmentResponse.AdjustmentDetailList;

                this.voucherDetailDate.Text = adjustmentResponse.CreateTime;
                this.voucherId.Text = adjustmentResponse.AdjustementNo;
                this.issueAmount.Text = adjustmentResponse.Totalamount1;

                if (null != details)
                {
                    foreach (AdjustmentDetail detail in details) {
                        //
                        //detail.ItemPrice;
                        this.issueItem.Text = detail.ItemName;
                    }
                }
            }

        }

        protected void backBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/StationeryStore/StationaryStorePendingVoucher.aspx");
        }

        protected void rejectBtn_Click(object sender, EventArgs e)
        {
            // WebService Reject
            string voucherId = (string)Session["AdjustmentId"];
            string adjustmentId = voucherId;
            bool result = UpdateStatus(adjustmentId,"0");
            if (result)
            {
                Session["AdjustmentId"] = null;
            }
            
            
            Response.Redirect("~/StationeryStore/StationaryStorePendingVoucher.aspx");
        }

        protected void approveBtn_Click(object sender, EventArgs e)
        {
            // WebService Approve
            string voucherId = (string)Session["AdjustmentId"];
            string adjustmentId = voucherId;
            bool result = UpdateStatus(adjustmentId, "2");
            if (result)
            {
                Session["AdjustmentId"] = null;
            }
            Response.Redirect("~/StationeryStore/StationaryStorePendingVoucher.aspx");
        }


        private bool UpdateStatus(string adjustmentId, string adjustStatus) { 

            AdjustmentFindRequest request =
                new AdjustmentFindRequest();
            request.AdjustmentId = adjustmentId;
            request.AdjustmentStatus = adjustStatus;
            AdjustmentFindResponse adjustmentResponse =
                adjustmentService.updateadjustment(request);
            return adjustmentResponse != null && "1".Equals(adjustmentResponse.ServiceResponseCode);
        
        }
    }
}