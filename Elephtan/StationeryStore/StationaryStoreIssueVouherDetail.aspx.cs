using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Elephtan.AdjustmentService;
using Elephtan.DataModel;

namespace Elephtan.StationeryStore
{
    public partial class StationaryStoreIssueVouherDetail : System.Web.UI.Page
    {
        private ArrayList voucherItemList = new ArrayList();

        AdjustmentServiceSoapClient adjustmentService =
            new AdjustmentServiceSoapClient();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            // Web Service Here

            this.issueDetailDate.Text = DateTime.Now.ToString();


            voucherItemList = (ArrayList)(Session["itemAddedResult"]);

            this.voucherDetailTable.DataSource = voucherItemList;
            this.voucherDetailTable.DataBind();

        }

        protected void backBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/StationeryStore/StationaryStoreIssueVoucher.aspx");
        }

        protected void issueBtn_Click(object sender, EventArgs e)
        {
            // Web Service Here Issue Voucher


            ArrayList itemList = (ArrayList)Session["itemAddedResult"];
            UserInfo userInfo = (UserInfo)Session["currentUser"];
            if(null != itemList){
                foreach(Item item in itemList){
                     AdjustmentFindRequest request = new AdjustmentFindRequest();
                     request.ItemId = item.ItemId;
                     request.QuantityAdjusted = item.Quantity;
                     request.CreateUserId = userInfo.UserId;
                     adjustmentService.createAdjustment(request);
                }
            }

            //double amount = Convert.ToDouble(this.totalAmount.Text);

            Response.Redirect("~/StationeryStore/StationaryStoreOverview.aspx");
        }

    }
}