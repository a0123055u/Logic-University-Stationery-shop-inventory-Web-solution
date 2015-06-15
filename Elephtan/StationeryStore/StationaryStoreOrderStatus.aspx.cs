using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Elephtan.DataModel;
using Elephtan.OrderService;
using store.sg.edu.nus.utility;

namespace Elephtan.StationeryStore
{
    public partial class StationaryStoreOrderStatus : System.Web.UI.Page
    {
        private ArrayList orderList = new ArrayList();
        OrderServiceSoapClient orderService
            = new OrderServiceSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {


            OrderFindListRequest orderRequest
                = new OrderFindListRequest();
            OrderFindListResponse orderResponse = 
               orderService.FindSupplierDeliveryList(orderRequest);
            if (null != orderRequest && "1".Equals(orderResponse.ServiceResponseCode)) {
                OrderFindResponse[] orders = 
                    orderResponse.OrderFindResponseList;
                if (null != orders)
                {
                    foreach (OrderFindResponse order in orders) {
                        //
                        Order o = new Order();
                        o.OrderReference = order.OrderId;
                        o.RequestId = order.OrderNo;
                        o.RequestDate = order.CreateTime;
                        o.Supplier = order.SupplierName;
                        o.Description = "...";
                        o.deliveryId = order.DeliveryId;
                        o.status = SystemUtility.GetDictString("DeliveryStatusCd" ,order.OrderStatus);
                        
                        //
                        if (null != order.OrderDetailList)
                        {
                            OrderDetail[] details = order.OrderDetailList;
                            if (null != details) {
                                foreach (OrderDetail detail in details) { 
                                    //
                                    o.Description += detail.ItemName + ", ";
                                    //
                                }
                                if (o.Description.Length > 25)
                                    o.Description.Substring(0, 25);
                            }
                        }
                        this.orderList.Add(o);
                        Session["orderList"] = this.orderList;
                    }
                }
            
            }

            this.ordersTable.DataSource = orderList;
            this.ordersTable.DataBind();
        }

        protected void detailBtn_Click(object sender, GridViewCommandEventArgs e)
        {
            Int32 index = Convert.ToInt32(e.CommandArgument);

            ArrayList list = (ArrayList)(Session["orderList"]);

            Order order = (Order)list[index];

            Response.Redirect("~/StationeryStore/StationaryStoreOrderDetail.aspx?DeliveryId="+order.deliveryId + "&state=" + order.status);

        }
    }
}