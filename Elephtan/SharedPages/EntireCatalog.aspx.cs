using Elephtan.DataModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Elephtan.ItemService;
using System.Diagnostics;
using store.sg.edu.nus.utility;

namespace Elephtan.SharedPages
{
    public partial class EntireCatalog : System.Web.UI.Page
    {
        ItemServiceSoapClient itemService =
            new ItemServiceSoapClient();
        ArrayList entireCatalog;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                entireCatalog = new ArrayList();

                // Web Service Get entire catalog\
                ItemFindListRequest itemRequest = new ItemFindListRequest();

                ItemFindListResponse itemReponse = itemService.QueryItemList(itemRequest);

                if(null != itemReponse && !"".Equals(itemReponse.ServiceResponseCode)){
                  ItemFindResponse[] items = itemReponse.ItemFindListResponseList ;

                    if(null != items){
                        foreach(ItemFindResponse entry in items){
                        
                            Item item = new Item();
                            item.ItemNumber = entry.ItemNumber;
                            item.Catagory = entry.CategoryName;
                            item.Description = entry.Description;
                            item.UnitOfMeasure = SystemUtility.GetDictString("UnitCd", entry.Unit);
                            item.ItemId = entry.ItemId;
                            entireCatalog.Add(item);
                        }
                    }
                }

                Session["entireCatalogSession"] = entireCatalog;

                this.entireCatalogTable.DataSource = entireCatalog;
                this.entireCatalogTable.DataBind();
            }
        }

        protected void entireCatalogAddBtn_Click(object sender, GridViewCommandEventArgs e)
        {
            Int32 index = Convert.ToInt32(e.CommandArgument);


            TextBox quantityTextBox = (TextBox)this.entireCatalogTable.Rows[index].Cells[4].FindControl("quantityTextBox");

            Debug.WriteLine(">>> " + quantityTextBox.Text);

            Item item = new Item();
            item.Quantity = quantityTextBox.Text;
            Int32 n;
            if (!int.TryParse(quantityTextBox.Text, out n)) {
                this.Page_Load(sender, e);
            }

            ArrayList entireCatalogSession = (ArrayList)Session["entireCatalogSession"];

            Item selectedItem = (Item)entireCatalogSession[index];
            item.ItemNumber = selectedItem.ItemNumber;
            item.Catagory = selectedItem.Catagory;
            item.Description = selectedItem.Description;
            item.UnitOfMeasure = selectedItem.UnitOfMeasure;
            item.ItemReference = selectedItem.ItemId;

            ArrayList itemAdded = (ArrayList)Session["itemAddedResult"];

            if (itemAdded == null)
                itemAdded = new ArrayList();

            itemAdded.Add(item);

            Session["itemAddedResult"] = itemAdded;

            Response.Redirect("~/SharedPages/RequestStationary.aspx");

        }

        protected void backBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/SharedPages/RequestStationary.aspx");
        }
    }
}