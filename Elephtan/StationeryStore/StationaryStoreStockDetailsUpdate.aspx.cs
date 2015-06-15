using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Elephtan.ItemService;
namespace Elephtan.StationeryStore
{
    public partial class StationaryStoreStockDetailsUpdate : System.Web.UI.Page
    {
        ItemServiceSoapClient itemService =
            new ItemServiceSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {

            string itemId = Request.QueryString["itemId"];

            if (!IsPostBack) {
                // WebService
                ItemFindRequest itemRequest = new ItemFindRequest();
                itemRequest.ItemId = itemId;
                ItemFindResponse itemResponse =
                    itemService.QueryItemById(itemRequest);
                if (null != itemResponse && "1".Equals(itemResponse.ServiceResponseCode))
                {
                    this.itemNumber.Text = itemResponse.ItemNumber;
                    this.category.Text = itemResponse.CategoryName;
                    this.description.Text = itemResponse.Description;
                    this.reorderLevel.Text = itemResponse.ReorderLevel.ToString();
                    this.reorderQuantity.Text = itemResponse.ReorderQuantity.ToString();
                    this.currentStockLevel.Text = itemResponse.CurrentQuantity.ToString();
                    Session["itemPrice"] = itemResponse.Price;
                }

                this.feedbackTextBox.Visible = false;
                this.actualStockLevel.Visible = false;
                this.value.Visible = false;
                this.difference.Visible = false;
            }
            

        }

        protected void backBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/StationeryStore/StationaryStoreStockDetails.aspx");
        }

        protected void updateBtn_Click(object sender, EventArgs e)
        {
            // Web Service Up date stock
            // WebService
            ItemManageRequest itemRequest = new ItemManageRequest();
            itemRequest.ItemId = Request.QueryString["itemId"];

            int reorderlvl = Convert.ToInt32(this.reorderLevel.Text);
            int reorderQuan = Convert.ToInt32(this.reorderQuantity.Text);

            itemRequest.ReorderLevel = reorderlvl;
            itemRequest.ReorderQuantity = reorderQuan;
           
            ItemManageResponse itemResponse =
                itemService.UpdateItem(itemRequest);

            if (null != itemResponse && "1".Equals(itemResponse.ServiceResponseCode))
            {
                //
                //
            }

            Response.Redirect("~/StationeryStore/StationaryStoreStockDetails.aspx");

        }

        protected void actualStockLevel_Changed(object sender, EventArgs e)
        {
            Int32 currentLevel = Convert.ToInt32(this.currentStockLevel.Text);
            Int32 actualLevel = Convert.ToInt32(this.actualStockLevel.Text);

            double itemPrice = (double)Session["itemPrice"];

            Int32 diff = currentLevel - actualLevel;

            this.difference.Text = diff.ToString();
            this.value.Text = (diff * itemPrice).ToString();
        }
    }
}