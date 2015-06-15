using Elephtan.DataModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Elephtan.WaitingItemService;
using store.sg.edu.nus.utility;

namespace Elephtan.StationeryStore
{
    public partial class StationaryStoreDepartmentWaitingDetail : System.Web.UI.Page
    {
        ArrayList detailItemList = new ArrayList();
        WaitingItemServiceSoapClient waitingItemService
            = new WaitingItemServiceSoapClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            string departmentId = Request.QueryString["entryId"];
            // Web Service
            WaitingItemFindListRequest request
               = new WaitingItemFindListRequest();
            request.DepartmentId = departmentId;
            WaitingItemFindListResponse response
                =
            waitingItemService.QueryWaitingItems(request);
            if (null != response && "1".Equals(response.ServiceResponseCode))
            {

                WaitingItemFindResponse[] waitings = response.WaitingItemFindResponseList;
                if (null != waitings)
                {
                    foreach (WaitingItemFindResponse entry in waitings)
                    {
                        //
                        //
                        OutstandingEntry en = new OutstandingEntry();
                        en.Department = entry.DepartmentName;
                        en.Reference = entry.DepartmentId;
                        en.RequestDescription = "";

                        WaitingItem[] items = entry.WaitingItemList;
                        foreach (WaitingItem entryItem in items)
                        {
                            //
                            //
                            Item i = new Item();
                            i.Catagory = entryItem.CategoryName;
                            i.Description = entryItem.ItemName;
                            i.UnitOfMeasure = SystemUtility.GetDictString("UnitCd", entryItem.Unit);
                            i.Quantity = entryItem.WaitingQuantity;
                            detailItemList.Add(i);
                        }
                        
                    }
                }

            }
        this.requestDetailTable.DataSource = detailItemList;
        this.requestDetailTable.DataBind();
        }

        protected void backBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/StationeryStore/StationaryStoreDepartmentWaiting.aspx");
        }
    }
}