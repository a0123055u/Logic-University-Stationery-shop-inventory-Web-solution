using Elephtan.DataModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Elephtan.OrderService;
using System.Diagnostics;

namespace Elephtan.StationeryStore
{
    public partial class StationaryStoreOrderConfirmation : System.Web.UI.Page
    {
        OrderServiceSoapClient orderService
            = new OrderServiceSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            UserInfo currentUser = (UserInfo)Session["currentUser"];

            this.requestDetailDate.Text = DateTime.Now.ToString();
            this.staffName.Text = currentUser.UserName;

            ArrayList itemAdded = (ArrayList)(Session["itemAddedResult"]);
            this.requestDetailTable.DataSource = itemAdded;
            this.requestDetailTable.DataBind();

            if (null != this.requestDetailTable.DataSource)
            {
                for (int i = 0; i < this.requestDetailTable.Rows.Count; i++)
                {
                    DropDownList dropdownList = (DropDownList)this.requestDetailTable.Rows[i].Cells[4].FindControl("supplierList");

                    if (null != dropdownList)
                    {

                        dropdownList.DataValueField = "SupplierId";
                        dropdownList.DataTextField = "SupplierName";

                        dropdownList.DataSource = ((Item)(itemAdded[i])).suppliserList;
                        dropdownList.DataBind();
                    }
                }
            }

        }

        protected void backButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/SharedPages/RequestStationary.aspx");
        }

        protected void confirmButton_Click(object sender, EventArgs e)
        {
            // WebService Make Order
            OrderManageRequest orderRequest
                = new OrderManageRequest();
            UserInfo userInfo = (UserInfo)Session["currentUser"];
            orderRequest.RequestUserId = userInfo.UserId;
            //create order base info
            //1-normal 2-confirmed
            OrderManageResponse orderResponse = orderService.CreateOrder(orderRequest);
            if (null != orderResponse && "1".Equals(orderResponse.ServiceResponseCode))
            {
                ArrayList list = (ArrayList)this.requestDetailTable.DataSource;

                //create order detail
                for (int i = 0; i < this.requestDetailTable.Rows.Count; i++)
                {
                    Item item = (Item)list[i];
                    DropDownList dropdownList = (DropDownList)this.requestDetailTable.Rows[i].Cells[4].FindControl("supplierList");
                    item.selectedSupplier = dropdownList.SelectedValue;
                    //Debug.WriteLine(">>> " + item.selectedSupplier);
                    OrderDetailManageRequest detailManageRequest = new OrderDetailManageRequest();
                    detailManageRequest.OrderedQuantity = item.Quantity;
                    detailManageRequest.ItemId = item.ItemReference;
                    detailManageRequest.SupplierId = item.selectedSupplier;
                    detailManageRequest.OrderId = orderResponse.OrderId;
                    orderService.CreateOrderDetail(detailManageRequest);
                }

                orderRequest.OrderId = orderResponse.OrderId;
                //update the status to confirmed
                orderService.ConfirmOrder(orderRequest);

            }

            Response.Redirect("~/StationeryStore/StationaryStoreOverview.aspx");

        }

        protected void requestDetail_OnRowDataBound(object sender, GridViewRowEventArgs e)
        {
            ArrayList list = (ArrayList)(Session["itemAddedResult"]);
            this.requestDetailTable.DataSource = list;
        }
    }
}