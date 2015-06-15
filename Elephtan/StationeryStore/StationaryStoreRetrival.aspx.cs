using Elephtan.DataModel;
using Elephtan.RetrievingService;
using store.sg.edu.nus.utility;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Elephtan.StationeryStore
{
    public partial class StationaryStoreRetrival : System.Web.UI.Page
    {
        private ArrayList historyRetrivalList = new ArrayList();

        RetrievingServiceSoapClient retrievingService =
            new RetrievingServiceSoapClient();

        protected void Page_Load(object sender, EventArgs e)
        {

            // Add all previous disbursement info
            // ArrayList retriverHistoryList

            // Web Service
            RetrievingFindListRequest retrievingListRequest
                = new RetrievingFindListRequest();

            RetrievingFindListResponse retrievingListResponse =
                retrievingService.FindRetrievingList(retrievingListRequest);

            if (null != retrievingListResponse
                && "1".Equals(retrievingListResponse.ServiceResponseCode))
            {

                RetrievingFindResponse[] retrievings = retrievingListResponse.RetrievingFindResponseList;
                if (null != retrievings)
                {
                    foreach (RetrievingFindResponse retrieving in retrievings)
                    {
                        //
                        //
                        RetriverRecord record = new RetriverRecord();
                        record.RetriverNum = retrieving.RetrievingNum;
                        record.RetriverReference = retrieving.RetrievingId;
                        record.RetriverDate = retrieving.CreateTime;
                        record.RetriverReference = retrieving.RetrievingId;

                        string statusStr = SystemUtility.GetDictString("RetrievingFormStatusCd", retrieving.RetrievingStatus);
                       
                        record.Description = "";
                        if (retrieving.RetrievingDetailList != null)
                        {
                            foreach (RetrievingDetail obj in retrieving.RetrievingDetailList)
                            {
                                record.Description += obj.ItemName + ", ";
                            }
                            if (record.Description.Length > 1)
                                record.Description = record.Description.Remove(record.Description.Length - 1);

                            if (record.Description.Length > 25)
                                record.Description = record.Description.Substring(0, 25);

                        }

                        record.Status = statusStr;

                        this.historyRetrivalList.Add(record);
                    }
                }

            }


            Session["historyRetrivalList"] = historyRetrivalList;
            this.retriverTable.DataSource = historyRetrivalList;
            this.retriverTable.DataBind();

        }

        protected void retriverTable_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            Int32 index = Convert.ToInt32(e.CommandArgument);

            ArrayList list = (ArrayList)Session["historyRetrivalList"];
            RetriverRecord record = (RetriverRecord)list[index];

            Response.Redirect("~/StationeryStore/StationaryStoreRetrivalDetail.aspx?retirvingId=" + record.RetriverReference+"&state="+record.Status);
        }
    }
}