using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Elephtan.OrderService;
using Elephtan.DisbursementService;
using Elephtan.DataModel;
using Elephtan.RetrievingService;

namespace Elephtan.StationeryStore
{
    public partial class StationaryStoreOverview : System.Web.UI.Page
    {
        private ArrayList orderHistoryList = new ArrayList();
        private ArrayList disbursementHistoryList = new ArrayList();
        private ArrayList retriverHistoryList = new ArrayList();

        DisbursementServiceSoapClient disbursementService
            = new DisbursementServiceSoapClient();

        OrderServiceSoapClient orderService =
            new OrderServiceSoapClient();

        RetrievingServiceSoapClient retrievingService =
            new RetrievingServiceSoapClient();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            // Connect to web Service here

            // Add all Previous Disbursement into 
            // ArrayList disbursementHistoryList
            DisbursementFindListRequest disbursementRequest
                = new DisbursementFindListRequest();

            //disbursementRequest.DisbursementStatus = "3";
            DisbursementFindListResponse disbursementResponse = 
            disbursementService.QueryDisbursementList(disbursementRequest);
            if (null != disbursementResponse && "1".Equals(disbursementResponse.ServiceResponseCode)) {

                DisbursementFindResponse[] disbursements = disbursementResponse.DisbursementFindResponseList;

                if (null != disbursements) {
                    foreach (DisbursementFindResponse entry in disbursements) { 
                        //
                        Disbursement dis = new Disbursement();
                        dis.DisbursementId = entry.DisbursementNo;
                        dis.RequestDate = entry.CreateTime;
                        dis.Department = entry.DepartmentName;
                        dis.RequestDescription = "";

                        foreach (DisbursementDetail obj in entry.DisbursementDetailList)
                        {
                            dis.RequestDescription += obj.ItemName + ", ";
                        }
                        if (dis.RequestDescription.Length > 1)
                            dis.RequestDescription=dis.RequestDescription.Remove(dis.RequestDescription.Length - 1);

                        if (dis.RequestDescription.Length > 25)
                            dis.RequestDescription=dis.RequestDescription.Substring(0, 25);

                        dis.DisbursementReference = entry.DisbursementId;

                        disbursementHistoryList.Add(dis);
                    }
                    Session["disbursementHistoryList"] = disbursementHistoryList;
                }
            }

            // Add all previous disbursement info
            // ArrayList retriverHistoryList

            // Web Service
            RetrievingFindListRequest retrievingListRequest
                = new RetrievingFindListRequest();

            RetrievingFindListResponse retrievingListResponse =
                retrievingService.FindRetrievingList(retrievingListRequest);

            if (null != retrievingListResponse 
                && "1".Equals(retrievingListResponse.ServiceResponseCode)) {

                    RetrievingFindResponse[] retrievings = retrievingListResponse.RetrievingFindResponseList;
                    if (null != retrievings) {
                        foreach (RetrievingFindResponse retrieving in retrievings)
                        {
                          //
                          //
                        RetriverRecord record = new RetriverRecord();
                        record.RetriverNum = retrieving.RetrievingNum;
                        record.RetriverReference = retrieving.RetrievingId;
                        record.RetriverDate = retrieving.CreateTime;

                        string statusStr = "";
                        if (retrieving.RetrievingStatus == "1")
                        {
                            statusStr = "Normal";
                        }
                        else if (retrieving.RetrievingStatus == "2")
                        {
                            statusStr = "Stock Clerk Confirmed";
                        }
                        else
                        {
                            statusStr = "N/A";
                        }
                        record.Description = "";
                        if (retrieving.RetrievingDetailList != null)
                        {
                            foreach (RetrievingDetail obj in retrieving.RetrievingDetailList)
                            {
                                record.Description += obj.ItemName + ", ";
                            }
                            if(record.Description.Length > 1)
                                record.Description=record.Description.Remove(record.Description.Length - 1);

                            if (record.Description.Length > 25)
                                record.Description=record.Description.Substring(0, 25);

                        }

                        record.Status = statusStr;
                        
                        this.retriverHistoryList.Add(record); 
                        }
                    }

            }



           

            // Add all Previous Order into
            // ArrayList orderHistoryList
            OrderFindListRequest orderRequest = new OrderFindListRequest();
            
            OrderFindListResponse orderResponse 
                = orderService.FindOrderList (orderRequest);
            if (null != orderResponse && "1".Equals(orderResponse.ServiceResponseCode))
            {

                OrderFindResponse[] orders = orderResponse.OrderFindResponseList;

                if (null != orders)
                {
                    foreach (OrderFindResponse entry in orders)
                    {
                        Order order = new Order();

                        order.RequestId = entry.OrderNo;
                        order.RequestDate = entry.CreateTime;
                        order.Supplier = entry.SupplierName;
                        order.Description = "";
                        order.OrderReference = entry.OrderId;
                        if (null != entry.OrderDetailList)
                        {
                            foreach (OrderDetail item in entry.OrderDetailList)
                            {
                                order.Description += item.ItemName + ", ";
                            }
                            int orderDescriptionLength = order.Description.Length;

                            if (orderDescriptionLength > 1)
                                order.Description=order.Description.Remove(orderDescriptionLength - 1);

                            if (orderDescriptionLength > 25)
                                order.Description=order.Description.Substring(0, 25);
                        }
                        orderHistoryList.Add(order);
                    }
                    Session["orderHistoryList"] = orderHistoryList;
                }
            }

         

            this.orderHistoryTable.DataSource = orderHistoryList;
            this.orderHistoryTable.DataBind();
            
            this.disbursementHistoryTable.DataSource = disbursementHistoryList;
            this.disbursementHistoryTable.DataBind();

            this.retriverTable.DataSource = retriverHistoryList;
            this.retriverTable.DataBind();
        }

        protected void disbursementHistoryTable_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            Int32 index = Convert.ToInt32(e.CommandArgument);

            ArrayList list = (ArrayList)Session["disbursementHistoryList"];

            Disbursement dis = (Disbursement)(list[index]);

            // Redirect to disbursement history detail
            Response.Redirect("~/StationeryStore/StationaryStoreDisbursmentDetail.aspx?disbursementId=" + dis.DisbursementReference);
        }

        protected void retriverTable_RowCommand(object sender, GridViewCommandEventArgs e)
        {

        }

        protected void orderHistoryTable_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            Int32 index = Convert.ToInt32(e.CommandArgument);

            ArrayList list = (ArrayList)Session["orderHistoryList"];

            Order order = (Order)(list[index]);

            // Redirect to order history detail
            Response.Redirect("~/StationeryStore/StationaryStorePreviousOrderDetail.aspx?orderId=" + order.OrderReference);
        }
    }
}