using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Elephtan.DataModel;
using Elephtan.DisbursementService;
using store.sg.edu.nus.utility;

namespace Elephtan.StationeryStore
{
    public partial class StationaryStoreDisbursement : System.Web.UI.Page
    {
        private ArrayList disbursementList = new ArrayList();

        DisbursementServiceSoapClient disbursementService
            = new DisbursementServiceSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            // Web Service Here

            DisbursementFindListRequest disbursementRequest
                = new DisbursementFindListRequest();

            DisbursementFindListResponse dibursementResponse = 
            disbursementService.QueryDisbursementList(disbursementRequest);
            if (null != dibursementResponse && "1".Equals(dibursementResponse.ServiceResponseCode)) {

                DisbursementFindResponse[] disbursements = 
                    dibursementResponse.DisbursementFindResponseList;
                if (disbursements != null) {

                    foreach (DisbursementFindResponse disbursement in disbursements) {

                        string departmentName = disbursement.DepartmentName;
                        //
                        //
                        //
                        Disbursement dis = new Disbursement();

                        dis.DisbursementId = disbursement.DisbursementNo;
                        dis.RequestDate = disbursement.CreateTime;
                        dis.Department = disbursement.DepartmentName;
                        dis.DisbursementReference = disbursement.DisbursementId;
                        dis.RequestItems = "";
                        dis.State = SystemUtility.GetDictString("DisbursementStatusCd", disbursement.DisbursementStatus);
                        dis.StateCode = disbursement.DisbursementStatus;


                        DisbursementDetail[] details = 
                            disbursement.DisbursementDetailList;
                        if(null != details)
                            foreach (DisbursementDetail detail in details) {
                                string itemName = detail.ItemName;
                                //
                                //
                                //
                                dis.RequestItems += detail.ItemName + ", ";
                        
                            }

                        if (dis.RequestItems.Length > 50)
                            dis.RequestItems = dis.RequestItems.Substring(0, 50);

                        this.disbursementList.Add(dis);
                        Session["disbursementList"] = disbursementList;
                    }
                }
            }

            this.disbursementTable.DataSource = disbursementList;
            this.disbursementTable.DataBind();
        }

        protected void detailBtn_Click(object sender, GridViewCommandEventArgs e)
        {
            Int32 index = Convert.ToInt32(e.CommandArgument);

            ArrayList list = (ArrayList)(Session["disbursementList"]);

            Disbursement dis = (Disbursement)list[index];

            string disbursementReference = dis.DisbursementReference;

          

            Response.Redirect("~/StationeryStore/StationaryStoreDisbursmentDetail.aspx?disbursementId=" + disbursementReference + "&state=" + dis.StateCode);

        }
    }
}