using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Elephtan.DataModel;
using Elephtan.DepartmentService;
using Elephtan.UserService;
using Elephtan.DelegationService;

namespace Elephtan.StationeryDepartment
{
    public partial class DepartmentHeadSettings : System.Web.UI.Page
    {
        private ArrayList staffList = new ArrayList();

        private ArrayList delegationList = new ArrayList();
        private ArrayList representitiveList = new ArrayList();

        UserServiceSoapClient userService =
            new UserServiceSoapClient();
        DepartmentServiceSoapClient departmentService =
            new DepartmentServiceSoapClient();

        DelegationServiceSoapClient delegationService =
            new DelegationServiceSoapClient();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            // Add Web Service Here 
            UserInfo userInfo = (UserInfo)Session["currentUser"];
            userInfo.DepartmentId = userInfo.DepartmentId;
             
            UserFindListRequest findListRequest
                = new UserFindListRequest();
            findListRequest.DepartmentId = userInfo.DepartmentId;

            UserFindListResponse findListResponse =
                userService.QueryUsersByDepartmentId(findListRequest);
            if (null != findListResponse && "1".Equals(findListResponse.ServiceResponseCode)) {

                UserFindResponse[] users = findListResponse.UserFindResponseList;
                if (null != users) {

                    //loop users
                    foreach (UserFindResponse entry in users) {

                        StaffDetail staff = new StaffDetail();
                        staff.StaffName = entry.UserName;
                        staff.EmailAddress = entry.Email;
                        staff.PhoneNumber = entry.TelephoneNo;
                        staff.StaffId = entry.UserId;
                       
                        staffList.Add(staff);
                    }
                    Session["departmentStaffList"] = staffList;
                }
            
            }

            // WebService get the current delegation
            
            //if update delegation
            DelegationFindRequest delegationRequest =
                 new DelegationFindRequest();
            delegationRequest.FromUserId1 = userInfo.UserId;

            DelegationFindResponse delegationResponse =
                delegationService.findDelegation(delegationRequest);
            //success
            if (null != delegationResponse && "1".Equals(delegationResponse.ServiceResponseCode))
            {
                StaffDetail staff = new StaffDetail();
                staff.StartDate = delegationResponse.StartTime1;
                staff.EndDate = delegationResponse.EndTime1;
                staff.StaffName = delegationResponse.ToUserName;
                staff.AuthorizationId = delegationResponse.AuthorizationId;
                delegationList.Add(staff);
            }

            //
            DepartmentFindRequest departmentRequest = new DepartmentFindRequest();
            departmentRequest.DepartmentId = userInfo.DepartmentId;
            DepartmentFindResponse departmentResonse =
                departmentService.QueryDepartment(departmentRequest);
            //success
            if (departmentResonse != null && "1".Equals(departmentResonse.ServiceResponseCode))
            {
                StaffDetail staff = new StaffDetail();
                staff.StaffName = departmentResonse.RepresentativeName;
                staff.CollectionPoint = departmentResonse.CollectionAddress;

                this.representitiveList.Add(staff);

            }
            


            // WebService get the current department representitive
            
            
            this.StaffListTable.DataSource = staffList;
            this.StaffListTable.DataBind();

            this.CurrentDelegationTable.DataSource = delegationList;
            this.CurrentDelegationTable.DataBind();

            this.CurrentRepresentitveTable.DataSource = representitiveList;
            this.CurrentRepresentitveTable.DataBind();
        }

        protected void StaffListTable_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            Int32 index = Convert.ToInt32(e.CommandArgument);

            Debug.WriteLine("Index: " + index);

            ArrayList staffList = (ArrayList)(Session["departmentStaffList"]);

            string staffId = ((StaffDetail)this.staffList[index]).StaffId;

            Response.Redirect("~/StationeryDepartment/DepartmentStaffDetail.aspx?staffId="+staffId);
        }

        protected void cancelDelegation_Click(object sender, GridViewCommandEventArgs e)
        {
            Int32 index = Convert.ToInt32(e.CommandArgument);

            ArrayList list = delegationList;
            StaffDetail staff = (StaffDetail)delegationList[index];
            
            // Web Service
            DelegationFindRequest request = new DelegationFindRequest();
            request.AuthorizationId = staff.AuthorizationId;
            request.DelegationStatus1 = "0";
            DelegationFindResponse response = 
               delegationService.updateDelegation(request);
            if (null != response && "1".Equals(response.ServiceResponseCode)) {
                delegationList.RemoveAt(index);
                this.CurrentDelegationTable.DataSource = delegationList;
                this.CurrentDelegationTable.DataBind();
            }

           

        }
    }
}