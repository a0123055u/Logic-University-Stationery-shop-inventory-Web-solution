using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using Elephtan.OrderService;
using Elephtan.DataModel;
using store.sg.edu.nus.utility;

namespace Elephtan.StationeryStore
{
    public partial class StationaryStoreOrderDetail : System.Web.UI.Page
    {
        private ArrayList orderItemList = new ArrayList();

        OrderServiceSoapClient orderService = new OrderServiceSoapClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            
            //
            string deliveryId = Request.QueryString["DeliveryId"];
            if (Session["DeliveryId"] == null)
                Session["DeliveryId"] = deliveryId;

            string deliverState = Request.QueryString["state"];

            if (deliverState == "Received")
                this.approveButton.Visible = false;

            OrderFindRequest request = new OrderFindRequest();
            request.DeliveryId = deliveryId;
            OrderFindResponse response =
            orderService.FindDeliveryDetailListByDelieveryId(request);
            if (null != response && "1".Equals(response.ServiceResponseCode)) {
                OrderDetail[] details = 
                response.OrderDetailList;

                this.orderDetailDate.Text = response.CreateTime;
                this.orderID.Text = response.OrderNo;
                this.supplierCode.Text = response.SupplierName;
                this.contactName.Text = response.Attn;
                this.phoneNumber.Text = response.DeliveryAddress;

                if (details != null) {
                    foreach (OrderDetail entry in details) { 
                        ////
                        Item item = new Item();
                        item.Catagory = entry.ItemNum;
                        item.Description = entry.ItemName;
                        item.UnitOfMeasure = SystemUtility.GetDictString("UnitCd", entry.Unit);
                        item.Quantity = entry.OrderedQuantity;
                        orderItemList.Add(item);
                    }
                }
            
            }
            
            this.orderDetailTable.DataSource = orderItemList;
            this.orderDetailTable.DataBind();

            if (Request.Url.AbsolutePath.Contains("StationaryStoreOverview"))
            {
                this.approveButton.Visible = false;
            }

        }

        protected void backBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/StationeryStore/StationaryStoreOrderStatus.aspx");
        }

        protected void receiveBtn_Click(object sender, EventArgs e)
        {

            OrderManageRequest request = new OrderManageRequest();
            request.DeliveryId = (string)Session["DeliveryId"];
            OrderManageResponse response = 
                orderService.ReceiveOrder(request);
            if (null != response && "1".Equals(response.ServiceResponseCode)) {
                Session["DeliveryId"] = null;
            }

            Response.Redirect("~/StationeryStore/StationaryStoreOrderStatus.aspx");
        }
    }
}