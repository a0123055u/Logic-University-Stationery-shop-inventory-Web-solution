using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using Elephtan.DataModel;
using System.Diagnostics;
using Elephtan.RequisitionService;
using Elephtan.ItemService;
using store.sg.edu.nus.utility;

namespace Elephtan.SharedPages
{
    public partial class RequestStationary : System.Web.UI.Page
    {
        private ArrayList itemSearchResult;
        private ArrayList itemAddedResult;
        
        RequisitionServiceSoapClient requisitionService = new RequisitionServiceSoapClient();


        private const string orderStationaryConfirmationPage = "~/StationeryStore/StationaryStoreOrderConfirmation.aspx";
        private const string requestStationaryConfirmationPage = "~/StationeryDepartment/DepartmentRequestConfirmation.aspx";

        private string confirmationPageURL;

        protected void Page_Load(object sender, EventArgs e)
        {
            itemSearchResult = new ArrayList();
            itemAddedResult = new ArrayList();
            
            UserInfo current = (UserInfo)Session["currentUser"];
            string roleType = current.Roles[0];

            if (roleType == "Staff")
            {
                confirmationPageURL = requestStationaryConfirmationPage;
            }
            else if (roleType == "Representative")
            {
                confirmationPageURL = requestStationaryConfirmationPage;
            }
            else if (roleType == "Head")
            {
                confirmationPageURL = requestStationaryConfirmationPage;
            }
            else if (roleType == "Supervisor")
            {
                confirmationPageURL = orderStationaryConfirmationPage;
            }
            else if (roleType == "Manager")
            {
                confirmationPageURL = orderStationaryConfirmationPage;
            }
            else if (roleType == "Store Clerk")
            {
                confirmationPageURL = orderStationaryConfirmationPage;
            }

            if (!IsPostBack)
            {
                // Connect Web Service Here

                RequisitionFindListRequest request = new RequisitionFindListRequest();
                request.RequestUserId = ((UserInfo)Session["currentUser"]).UserId;
                request.UserId = request.RequestUserId;

                RequisitionFindListResponse response = requisitionService.FindRequisitionListByUserId(request);
                if ("1".Equals(response.ServiceResponseCode) && response.Requisitions != null)
                {
                    foreach (var entry in response.Requisitions)
                    {


                        foreach (var itemEntry in entry.ItemList)
                        {
                            StationaryItem item = new StationaryItem();
                            item.ItemNumber = itemEntry.ItemNum;
                            item.Catagory = itemEntry.ItemName;
                            item.Description = itemEntry.ItemName;
                            item.UnitOfMeasure = SystemUtility.GetDictString("UnitCd", itemEntry.Unit);
                            item.Quantity = itemEntry.ApplyAmount;
                            item.ItemReference = itemEntry.ItemId;
                            
                        }

                    }
                }

                // Binding empty search result
                this.searchResultTable.DataSource = itemSearchResult;
                this.searchResultTable.DataBind();

                

                string searchItemStr = (string)Session["searchItemStr"];
                if (null != searchItemStr)
                {
                    performSearchService(searchItemStr);
                }
            }

            ArrayList itemAdded = (ArrayList)Session["itemAddedResult"];

            // Binding empty stationary add result
            this.stationariesAddedTable.DataSource = itemAdded;
            this.stationariesAddedTable.DataBind();
        }

        protected void searchButton_Click(object sender, EventArgs e)
        {
            // Search string
            string searchItemStr = this.itemSearchBox.Text;
            Session["searchItemStr"] = searchItemStr;

            // clear itemSearchResult holder
            this.itemSearchResult = new ArrayList();

            // Connect Web Service
            this.performSearchService(searchItemStr);
        }

        private void performSearchService(string searchItemStr)
        {
            if (searchItemStr != "")
            {

                ItemFindListRequest itemRequest =
                   new ItemFindListRequest();
                itemRequest.QueryString = searchItemStr;
                ItemServiceSoapClient itemService =
                    new ItemServiceSoapClient();
                ItemFindListResponse response =
                    itemService.QueryItemList(itemRequest);
                if (response != null && response.ServiceResponseCode == "1")
                {
                    ItemFindResponse[] items = response.ItemFindListResponseList;
                    if (null != items)
                    {
                        foreach (ItemFindResponse item in items)
                        {

                            Item i = new Item();
                            i.ItemNumber = item.ItemNumber;
                            i.Catagory = item.CategoryName;
                            i.UnitOfMeasure = SystemUtility.GetDictString("UnitCd" ,item.Unit);
                            i.Description = item.Description;
                            i.ItemId = item.ItemId;
                            i.suppliserList = item.Suppliers;
                            i.ItemReference = item.ItemId;

                            itemSearchResult.Add(i);
                        }
                    }

                }

                this.searchResultTable.DataSource = itemSearchResult;
                this.searchResultTable.DataBind();
            }
        }

        protected void searchResultTable_RowCommand(object sender, GridViewCommandEventArgs e) 
        {
            Int32 index = Convert.ToInt32(e.CommandArgument);

            Debug.WriteLine(">>> searchResultTableIndexSelected: " + index);

            TextBox quantityTextBox = (TextBox)this.searchResultTable.Rows[index].Cells[4].FindControl("quantityTextBox");

            Debug.WriteLine(">>> " + quantityTextBox.Text);

            Item item = new Item();
            item.Quantity = quantityTextBox.Text;

            this.performSearchService((string)Session["searchItemStr"]);

            Item selectedItem = (Item)itemSearchResult[index];
            item.ItemNumber = selectedItem.ItemNumber;
            item.Catagory = selectedItem.Catagory;
            item.Description = selectedItem.Description;
            item.UnitOfMeasure = selectedItem.UnitOfMeasure;
            item.ItemId = selectedItem.ItemId;
            item.suppliserList = selectedItem.suppliserList;
            item.ItemReference = selectedItem.ItemReference;

            ArrayList itemAdded = (ArrayList)Session["itemAddedResult"];

            if (itemAdded == null)
                itemAdded = new ArrayList();

            itemAdded.Add(item);

            Session["itemAddedResult"] = itemAdded;
            this.stationariesAddedTable.DataSource = itemAdded;
            this.stationariesAddedTable.DataBind();
            
        }

        protected void stationariesAddedTable_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            Int32 index = Convert.ToInt32(e.CommandArgument);
            Debug.WriteLine(">>> stationariesAddedTableIndexSelected: " + index);

            ArrayList itemAdded = (ArrayList)this.stationariesAddedTable.DataSource;

            itemAdded.RemoveAt(index);

            Session["itemAddedResult"] = itemAdded;
            this.stationariesAddedTable.DataSource = itemAdded;
            this.stationariesAddedTable.DataBind();
        }

        protected void doneButton_Click(object sender, EventArgs e)
        {
            Response.Redirect(confirmationPageURL);
        }

        protected void showEntireCatalogBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/SharedPages/EntireCatalog.aspx");
        }
    }
}