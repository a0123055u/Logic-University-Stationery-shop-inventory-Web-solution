using Elephtan.ItemService;
using Elephtan.ReportService;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Elephtan.StationeryStore
{
    public partial class StationaryStoreReport : System.Web.UI.Page
    {
        ReportFindRequest request = new ReportFindRequest();
        CrystalReport1 rpt1;
        ReportService.ReportServiceSoapClient report = new ReportServiceSoapClient();
        ItemService.ItemServiceSoapClient itemlist = new ItemServiceSoapClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox1.Visible = false;
            TextBox2.Visible = false;
            Calendar1.VisibleDate = DateTime.Now;
            Calendar2.VisibleDate = DateTime.Now;

            // hide calendar
            //this.Calendar1.Visible = false;
            //this.Calendar2.Visible = false;


            rpt1 = (CrystalReport1)Session["reportstore"];
            if (rpt1 != null)
                CrystalReportViewer1.ReportSource = rpt1;

            if (!IsPostBack)
            {
                ItemFindListRequest requestitem = new ItemFindListRequest();
                ItemFindListResponse responseListItem = itemlist.QueryItemList(requestitem);
                if (responseListItem != null)
                {
                    ItemFindResponse[] temp = responseListItem.ItemFindListResponseList;
                    if (null != temp)
                    {

                        DropDownList5.DataTextField = "Description";
                        DropDownList5.DataValueField = "ItemId";
                        DropDownList5.DataSource = temp;
                        DropDownList5.DataBind();

                    }


                }
            }

            Session["ItemId"] = DropDownList5.SelectedItem.Value;
            if (RadioButton1.Checked)
            {
                DropDownList5.Visible = false;
                request.TopItemRange = DropDownList2.Text;
                RadioButton2.Visible = false;
            }
            if (RadioButton2.Checked)
            {
                DropDownList2.Visible = false;
                request.ItemId = (String)Session["ItemId"];
                RadioButton1.Visible = false;
            }
            if (RadioButton3.Checked)
            {

            }
            else
            {
                request.DepartmentId = DropDownList3.SelectedValue;
            }

        }

        protected void departmentChanged(object sender, EventArgs e)
        {
            this.DropDownList3.Visible = false;
        }
        protected void Button1_Click(object sender, EventArgs e)
        {


            String qty = "";
            String Itemname = "";
            String date = "";
            String deptname = "";
            TextBox1.Text = Convert.ToString(Calendar2.SelectedDate);
            TextBox2.Text = Convert.ToString(Calendar1.SelectedDate);

            if (ListBox1.SelectedIndex == 1)
            {
                request.StartDate = TextBox1.Text;
                request.EndDate = TextBox2.Text;
            }

            request.ReportType = ListBox1.SelectedValue;








            ReportFindResponse response = report.QueryReport(request);
            if (response != null)
            {
                int i = 0;
                if (response.ServiceResponseCode == "1")
                {
                    DataSet ds = new DataSet();

                    DataTable tt = new DataSet1.DataTable2DataTable();


                    foreach (var details in response.ReportDepartmentItemInfoList)
                    {
                        deptname = details.DepartmentName;


                        foreach (ReportItemInfo itemdetails in details.ReportItemInfoList)
                        {

                            DataRow drow = tt.NewRow();
                            drow["Departmentname"] = details.DepartmentName;
                            drow["itemname"] = itemdetails.ItemName;
                            drow["quantity"] = Convert.ToInt16(itemdetails.AppliedQuantity);
                            drow["date"] = itemdetails.YearMonthString;
                            qty = itemdetails.AppliedQuantity;
                            Itemname = itemdetails.ItemName;
                            date = itemdetails.YearMonthString;
                            tt.Rows.Add(drow);

                        }
                        rpt1 = new CrystalReport1();

                        if (i == 0)
                            ds.Tables.Add(tt);
                        rpt1.SetDataSource(ds);
                        HttpContext.Current.Session["reportstore"] = rpt1;


                        rpt1 = (CrystalReport1)Session["reportstore"];

                        CrystalReportViewer1.ReportSource = rpt1;
                        i++;





                    }



                }
            }






        }

        protected void DropDownList5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           // Debug.WriteLine(">>>" + this.ListBox1.SelectedIndex);
            Int32 index = this.ListBox1.SelectedIndex;
            if (index == 0)
            {
                // hide calendar
                this.Calendar1.Visible = false;
                this.Calendar2.Visible = false;
                TextBox1.Visible = false;
                TextBox2.Visible = false;
                Label2.Visible = false;
                Label3.Visible = false;
            }
            else
            {
                // show calendar
                this.Calendar1.Visible = true;
                this.Calendar2.Visible = true;
            }

        }

        protected void Calendar2_SelectionChanged(object sender, EventArgs e)
        {

        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {

        }

        protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
        {

        }

        protected void Calendar2_DayRender(object sender, DayRenderEventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/StationeryStore/StationaryStoreReport.aspx");
        }

    }
}




//        ReportFindRequest request = new ReportFindRequest();
//        CrystalReport1 rpt1;
//        ReportService.ReportServiceSoapClient report = new ReportService.ReportServiceSoapClient();
//        ItemService.ItemServiceSoapClient itemlist = new ItemService.ItemServiceSoapClient();
//        protected void Page_Load(object sender, EventArgs e)
//        {

//            Calendar1.VisibleDate = DateTime.Now;
//            Calendar2.VisibleDate = DateTime.Now;
//            rpt1 = (CrystalReport1)Session["reportstore"];
//            if (rpt1 != null)
//                CrystalReportViewer1.ReportSource = rpt1;

//            if (!IsPostBack)
//            {
//                ItemFindListRequest requestitem = new ItemFindListRequest();
//                ItemFindListResponse responseListItem = itemlist.QueryItemList(requestitem);
//                if (responseListItem != null)
//                {
//                    ItemFindResponse[] temp = responseListItem.ItemFindListResponseList;
//                    if (null != temp)
//                    {

//                        DropDownList5.DataTextField = "Description";
//                        DropDownList5.DataValueField = "ItemId";
//                        DropDownList5.DataSource = temp;
//                        DropDownList5.DataBind();

//                    }


//                }
//            }

//            Session["ItemId"] = DropDownList5.SelectedItem.Value;
//            if (RadioButton1.Checked)
//            {
//                DropDownList5.Visible = false;
//                request.TopItemRange = DropDownList2.Text;
//                RadioButton2.Visible = false;
//            }
//            if (RadioButton2.Checked)
//            {
//                DropDownList2.Visible = false;
//                request.ItemId = (String)Session["ItemId"];
//                RadioButton1.Visible = false;
//            }
//            if (RadioButton3.Checked)
//            {

//            }
//            else
//            {
//                request.DepartmentId = DropDownList3.SelectedValue;
//            }

//        }
//        protected void Button1_Click(object sender, EventArgs e)
//        {


//            String qty = "";
//            String Itemname = "";
//            String date = "";
//            String deptname = "";
//            TextBox1.Text = Convert.ToString(Calendar2.SelectedDate);
//            TextBox2.Text = Convert.ToString(Calendar1.SelectedDate);


//            request.StartDate = TextBox1.Text;
//            request.EndDate = TextBox2.Text;
//            request.ReportType = ListBox1.SelectedValue;


//            ReportFindResponse response = report.QueryReport(request);
//            if (response != null)
//            {
//                int i = 0;
//                if (response.ServiceResponseCode == "1")
//                {
//                    DataSet ds = new DataSet();

//                    DataTable tt = new DataSet1.DataTable2DataTable();


//                    foreach (var details in response.ReportDepartmentItemInfoList)
//                    {
//                        deptname = details.DepartmentName;


//                        foreach (ReportItemInfo itemdetails in details.ReportItemInfoList)
//                        {

//                            DataRow drow = tt.NewRow();
//                            drow["Departmentname"] = details.DepartmentName;
//                            drow["itemname"] = itemdetails.ItemName;
//                            drow["quantity"] = Convert.ToInt16(itemdetails.AppliedQuantity);
//                            drow["date"] = itemdetails.YearMonthString;
//                            qty = itemdetails.AppliedQuantity;
//                            Itemname = itemdetails.ItemName;
//                            date = itemdetails.YearMonthString;
//                            tt.Rows.Add(drow);

//                        }
//                        rpt1 = new CrystalReport1();

//                        if (i == 0)
//                            ds.Tables.Add(tt);
//                        rpt1.SetDataSource(ds);
//                        HttpContext.Current.Session["reportstore"] = rpt1;


//                        rpt1 = (CrystalReport1)Session["reportstore"];

//                        CrystalReportViewer1.ReportSource = rpt1;
//                        i++;





//                    }



//                }
//            }






//        }

//        protected void DropDownList5_SelectedIndexChanged(object sender, EventArgs e)
//        {

//        }

//        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
//        {

//        }
//    }
//}
