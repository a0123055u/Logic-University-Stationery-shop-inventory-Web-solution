using Elephtan.DataModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Elephtan.AdjustmentService;

namespace Elephtan.StationeryStore
{
    public partial class StationaryStorePendingVoucher : System.Web.UI.Page
    {
        private ArrayList pendingVoucherList = new ArrayList();

        AdjustmentServiceSoapClient adjustmentService
            = new AdjustmentServiceSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {

            // Web Service Here
            AdjustmentFindRequest request =
                new AdjustmentFindRequest();

            AdjustmentFindListResponse adjustmentResponse = 
                adjustmentService.QueryAdjustList(request);
            if (null != adjustmentResponse && "1".Equals(adjustmentResponse.ServiceResponseCode))
            {
                AdjustmentFindResponse[] adjustments = adjustmentResponse.ListResponser;
                if (null != adjustments) { 
                //
                    //
                    //
                    foreach (AdjustmentFindResponse item in adjustments) {
                    Voucher voucher = new Voucher();
                    voucher.VoucherID = item.AdjustementNo;
                    voucher.VoucherReference = item.AdjustmentId;
                    voucher.VoucherDate = item.CreateTime;

                    voucher.IssueItems = "";

                    foreach (AdjustmentDetail i in item.AdjustmentDetailList)
                    {
                        voucher.IssueItems += i.ItemName + ", ";
                    }

                    if (voucher.IssueItems.Length > 25)
                        voucher.IssueItems.Substring(0, 25);

                    voucher.IssueAmount = item.QuantityAdjusted;
                    pendingVoucherList.Add(voucher);
                    }
                }
            }

            Session["pendingVoucherList"] = pendingVoucherList;
            
            this.vouchersTable.DataSource = pendingVoucherList;
            this.vouchersTable.DataBind();

        }

        protected void detailBtn_Click(object sender, GridViewCommandEventArgs e)
        {
            Int32 index = Convert.ToInt32(e.CommandArgument);
            
            
            ArrayList pendingVoucherList = (ArrayList)(Session["pendingVoucherList"]);

            Voucher voucher = (Voucher)pendingVoucherList[index];

            Response.Redirect("~/StationeryStore/StationaryStorePendingVoucherDetail.aspx?voucherId=" + voucher.VoucherReference);

        }
    }
}