using Elephtan.DataModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Elephtan.WaitingItemService;
namespace Elephtan.StationeryStore
{
    public partial class StationaryStoreDepartmentWaiting : System.Web.UI.Page
    {
        private ArrayList outstandingList = new ArrayList();

        WaitingItemServiceSoapClient waitingItemService
            = new WaitingItemServiceSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            // WebService Here
            WaitingItemFindListRequest request
                = new WaitingItemFindListRequest();

            WaitingItemFindListResponse response
                = 
            waitingItemService.QueryWaitingItems(request);
            if (null != response && "1".Equals(response.ServiceResponseCode)) {

                WaitingItemFindResponse[] waitings = response.WaitingItemFindResponseList;
                if (null != waitings) { 
                    foreach(WaitingItemFindResponse entry in waitings){
                        //
                        //
                        OutstandingEntry en = new OutstandingEntry();
                        en.Department = entry.DepartmentName;
                        en.Reference = entry.DepartmentId;
                        en.RequestDescription = "";
                        
                        WaitingItem[] items = entry.WaitingItemList;
                        foreach (WaitingItem item in items) { 
                            //
                            //
                            en.RequestDescription += item.ItemName + ", ";
                        
                        }
                        this.outstandingList.Add(en);
                    }
                }

            }


            
            
            this.requestsTable.DataSource = outstandingList;
            this.requestsTable.DataBind();
        }

        protected void requestDetailBtn_Click(object sender, GridViewCommandEventArgs e)
        {
            Int32 index = Convert.ToInt32(e.CommandArgument);

            OutstandingEntry en = (OutstandingEntry)outstandingList[index];

            Response.Redirect("~/StationeryStore/StationaryStoreDepartmentWaitingDetail.aspx?entryId=" + en.Reference);
        }
    }
}