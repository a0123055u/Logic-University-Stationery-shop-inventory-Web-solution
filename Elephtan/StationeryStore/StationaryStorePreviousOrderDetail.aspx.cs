using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Elephtan.OrderService;
using Elephtan.DataModel;
using store.sg.edu.nus.utility;
namespace Elephtan.StationeryStore
{
    public partial class StationaryStorePreviousOrderDetail : System.Web.UI.Page
    {
        private ArrayList orderItemList = new ArrayList();

        OrderServiceSoapClient orderService =
            new OrderServiceSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            string orderId = Request.QueryString["orderId"];

            // Web Service Here
            OrderFindRequest orderRequest =
                new OrderFindRequest();
            orderRequest.OrderId = orderId;
            OrderFindResponse orderResponse = 
            orderService.FindOrderDetailListByOrderId(orderRequest);

            if (null != orderResponse
                && "1".Equals(orderResponse.ServiceResponseCode)) {

                    this.orderDetailDate.Text = orderResponse.CreateTime;
                    this.orderID.Text = orderResponse.OrderNo;

                OrderDetail[] orderDetails = 
                    orderResponse.OrderDetailList;
                if (null != orderDetails) {

                    foreach (OrderDetail detail in orderDetails) {

                        Item item = new Item();
                        item.ItemNumber = detail.ItemNum;
                        item.Description = detail.ItemName;
                        item.UnitOfMeasure = SystemUtility.GetDictString("UnitCd" ,detail.Unit);
                        item.Quantity = detail.OrderedQuantity;
                        item.selectedSupplier = detail.SupplierName;
                        //
                        //
                        this.orderItemList.Add(item);
                    }
                }
            }



            this.orderDetailDate.Text = "";
            this.orderID.Text = "";

            this.orderDetailTable.DataSource = orderItemList;
            this.orderDetailTable.DataBind();
        }

        protected void backBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/StationeryStore/StationaryStoreOverview.aspx");
        }
    }
}