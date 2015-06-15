using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Elephtan.DepartmentService;
using Elephtan.DelegationService;
using Elephtan.DataModel;
using Elephtan.UserService;

namespace Elephtan.StationeryDepartment
{
    public partial class DepartmentStaffDetail : System.Web.UI.Page
    {

        DepartmentServiceSoapClient departmentService =
             new DepartmentServiceSoapClient();

        DelegationServiceSoapClient delegationService =
            new DelegationServiceSoapClient();


        protected void Page_Load(object sender, EventArgs e)
        {
            // Get Staff Id fron Query String
            string staffId = Request.QueryString["staffId"];
            
            // Connect Web Service Here
            UserServiceSoapClient userService =
                new UserServiceSoapClient();
            UserFindRequest userRequest = new UserFindRequest();
            userRequest.UserId = staffId;

            UserFindResponse response = 
                userService.QueryUserById(userRequest);
            if (null != response && "1".Equals(response.ServiceResponseCode)) { 
                //
                this.departmentName.Text = response.DepartmentName;
                this.staffName.Text = response.UserName;
                this.staffEmail.Text = response.Email;

            }

            // Get Staff Info

            this.StartDate.Enabled = false;
            this.EndDate.Enabled = false;

            string assignmentStr = this.assignmentDropDownList.Text;

            if (assignmentStr.Equals("Delegation"))
            {
                this.StartDate.Enabled = true;
                this.EndDate.Enabled = true;
            }

            string startDateStr = this.StartDate.Text;
            string endDateStr = this.EndDate.Text;


        }

        protected void backButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/StationeryDepartment/DepartmentHeadSettings.aspx");
        }

        protected void assignmentDropDownList_Changed(object sender, EventArgs e)
        {
            string selectedItem = this.assignmentDropDownList.SelectedValue;

            if (selectedItem == "Delegation")
            {
                this.StartDate.Enabled = true;
                this.EndDate.Enabled = true;
            }
            else
            {
                this.StartDate.Enabled = false;
                this.EndDate.Enabled = false;
            }
        }

        protected void assignButton_Click(object sender, EventArgs e)
        {

            UserInfo userInfo = (UserInfo)Session["currentUser"];
            string userId = Request.QueryString["staffId"];
            // Web Service here Complete Assignment

            string assignmentType = this.assignmentDropDownList.SelectedValue;

            if (assignmentType == "Delegation")
            {
                DelegationFindRequest delegationRequest =
                new DelegationFindRequest();
                delegationRequest.FromUserId1 = userInfo.UserId;

                delegationRequest.ToUserId1 = userId;

                string startTime = this.StartDate.Text;

                string endTime = this.EndDate.Text;

                delegationRequest.StartTime1 = startTime;
                delegationRequest.EndTime1 = endTime;

                DelegationFindResponse delegationResponse =
                    delegationService.addDelegation(delegationRequest);
                //success
                if (null != delegationResponse && "1".Equals(delegationResponse.ServiceResponseCode))
                {
                    Response.Redirect("~/StationeryDepartment/DepartmentHeadSettings.aspx");
                }

            }
            else
            {
                //if update representative
                DepartmentManageRequest departmentRequest =
                    new DepartmentManageRequest();

                departmentRequest.DepartmentId = userInfo.DepartmentId;
                departmentRequest.RepresentativeId = userId;
                DepartmentManageResponse departmentResonse =
                    departmentService.UpdateDepartmentCollectionInfo(departmentRequest);

                //success
                if (departmentResonse != null && "1".Equals(departmentResonse.ServiceResponseCode))
                {
                    Response.Redirect("~/StationeryDepartment/DepartmentHeadSettings.aspx");
                }
            
            }

         


            



            // Redirect to setting page after assignment
            Response.Redirect("~/StationeryDepartment/DepartmentHeadSettings.aspx");
        }
    }
}