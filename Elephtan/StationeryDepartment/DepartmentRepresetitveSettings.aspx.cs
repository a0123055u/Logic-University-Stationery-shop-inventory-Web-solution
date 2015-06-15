using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Elephtan.DepartmentService;
using Elephtan.DataModel;
using Elephtan.CollectionPointService;
using System.Diagnostics;

namespace Elephtan.StationeryDepartment
{
    public partial class DepartmentRepresetitveSettings : System.Web.UI.Page
    {

        private ArrayList collectionLocations = new ArrayList();
        private CollectionPoint selectedCollectionPoint;
        private DepartmentServiceSoapClient departmentService
            = new DepartmentServiceSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                /// Web service show current CollectionPoint
                /// 
                DepartmentFindRequest request =
                    new DepartmentFindRequest();

                UserInfo userInfo = (UserInfo)Session["currentUser"];

                request.DepartmentId = userInfo.DepartmentId;
                DepartmentFindResponse response =
                    departmentService.QueryDepartment(request);
                if (null != response && response.ServiceResponseCode.Equals("1"))
                {
                    //show current collection point

                    string departmentName = response.DepartmentName;
                    //

                    //
                    selectedCollectionPoint = new CollectionPoint();
                    selectedCollectionPoint.description += response.CollectionAddress + " ";
                    selectedCollectionPoint.description += response.CollectionTime + " ";
                    selectedCollectionPoint.description += response.StoreClertName;

                    Session["selectedCollectionPoint"] = selectedCollectionPoint;

                }



                // add alll collection points
                //show collection Points
                CollectionPointServiceSoapClient collectionService
                    = new CollectionPointServiceSoapClient();

                CollectionPointFindRequest collectionRequest =

                   new CollectionPointFindRequest();
                CollectionPointFindListResponse collectionResponse =
                collectionService.QueryCollectionList(collectionRequest);

                if (null != collectionResponse && collectionResponse.ServiceResponseCode.Equals("1"))
                {

                    CollectionPointFindResponse[]
                        list = collectionResponse.ListResponse;

                    //Handle the CollectionPoint List
                    if (null != list)
                    {
                        foreach (CollectionPointFindResponse entry in list)
                        {

                            string clerkName = entry.ClertName;

                            CollectionPoint point = new CollectionPoint();
                            point.description += " " + entry.Address + " ";
                            point.description += entry.CollectionTime + " ";
                            point.description += entry.ClertName;

                            point.collectionPointId = entry.CollectionPointId;


                            collectionLocations.Add(point);
                        }
                        Session["collectionLocations"] = collectionLocations;
                    }

                }

                // show the current coolection point
                this.currentCollectionPoint.Text = selectedCollectionPoint.description;

               ArrayList collectionLocationsStr = new ArrayList();
                foreach (CollectionPoint collectionObj in collectionLocations)
                {
                    collectionLocationsStr.Add(collectionObj.description);
                }

                this.radioButtonList.DataSource = collectionLocationsStr;
                this.radioButtonList.DataBind();
            }

            CollectionPoint ccp = (CollectionPoint)Session["selectedCollectionPoint"];
        }

        protected void radioButtonList_Changed(object sender, EventArgs e)
        {
            int index = this.radioButtonList.SelectedIndex;
            Session["radioButtonList_index"] = index;
        }

        protected void UpdateCollectionBtn_Click(object sender, EventArgs e)
        {
            /// Update the collection Point using seclected radio button
            /// 
            UserInfo userInfo = (UserInfo)Session["currentUser"];

            int index = (int)(Session["radioButtonList_index"]);
            Debug.WriteLine(">>> " + index);
            ArrayList colLocations = (ArrayList)Session["collectionLocations"];

            CollectionPoint p = (CollectionPoint)colLocations[index];

            Debug.WriteLine(">>> " + p.description);

            this.currentCollectionPoint.Text = p.description;

            String collectionPointId = p.collectionPointId;
            DepartmentManageRequest
                departmentRequest = new DepartmentManageRequest();
            departmentRequest.DepartmentId = userInfo.DepartmentId;

            departmentRequest.CollectionPointId = collectionPointId;
            DepartmentManageResponse
                departmentManageResponse = 
            departmentService.UpdateDepartmentCollectionInfo(departmentRequest);
            if (null != departmentManageResponse && "1".Equals(departmentManageResponse.ServiceResponseCode)) {

                this.Page_Load(sender, e);
                
            }


        }
    }
}