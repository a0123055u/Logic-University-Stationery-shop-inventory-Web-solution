using Elephtan.DataModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Elephtan.ItemService;
using store.sg.edu.nus.utility;

namespace Elephtan.StationeryStore
{
    public partial class StationaryStoreStockDetails : System.Web.UI.Page
    {

        private ArrayList stockDetailList = new ArrayList();
        ItemServiceSoapClient itemService =
            new ItemServiceSoapClient();

        protected void Page_Load(object sender, EventArgs e)
        {

            // WebService here!!!
            
            ItemFindListRequest itemRequest = new ItemFindListRequest();

                ItemFindListResponse itemReponse = itemService.QueryItemList(itemRequest);

                if(null != itemReponse && !"".Equals(itemReponse.ServiceResponseCode)){
                  ItemFindResponse[] items = itemReponse.ItemFindListResponseList ;

                    if(null != items){
                        foreach(ItemFindResponse entry in items){
                        
                            Item i = new Item();
                            i.ItemId = entry.ItemNumber;
                            i.Catagory = entry.CategoryName;
                            i.Description = entry.Description;
                            i.UnitOfMeasure = SystemUtility.GetDictString("UnitCd", entry.Unit);
                            i.CurrentStock = entry.CurrentQuantity.ToString();
                            i.ItemReference = entry.ItemId;
                            this.stockDetailList.Add(i);
                        
                        }
                        Session["stockDetailList"] = this.stockDetailList;
                    }
                }
            
            
            this.stockDetailTable.DataSource = stockDetailList;
            this.stockDetailTable.DataBind();
        }

        protected void searchBtn_Click(object sender, EventArgs e)
        {
            string searchStr = this.itemSearchBox.Text;
            this.stockDetailList = new ArrayList();

            ItemFindListRequest itemRequest = new ItemFindListRequest();
            itemRequest.QueryString = searchStr;
                ItemFindListResponse itemReponse = itemService.QueryItemList(itemRequest);

                if(null != itemReponse && !"".Equals(itemReponse.ServiceResponseCode)){
                  ItemFindResponse[] items = itemReponse.ItemFindListResponseList ;

                    if(null != items){
                        foreach(ItemFindResponse entry in items){
                            Item i = new Item();
                            i.ItemId = entry.ItemNumber;
                            i.Catagory = entry.CategoryName;
                            i.Description = entry.Description;
                            i.UnitOfMeasure = entry.Unit;
                            i.CurrentStock = entry.CurrentQuantity.ToString();
                            i.ItemReference = entry.ItemId;
                            this.stockDetailList.Add(i);
                        }
                    }
                    Session["stockDetailList"] = this.stockDetailList;
                }
            
            
            this.stockDetailTable.DataSource = this.stockDetailList;
            this.stockDetailTable.DataBind();
        }

        protected void stockItemDetail_Click(object sender, GridViewCommandEventArgs e)
        {
            Int32 index = Convert.ToInt32(e.CommandArgument);

            ArrayList list = (ArrayList)(Session["stockDetailList"]);

            Item item = (Item)(list[index]);

            string itemId = item.ItemReference;

            Response.Redirect("~/StationeryStore/StationaryStoreStockDetailsUpdate.aspx?itemId=" + itemId);
        }
    }
}