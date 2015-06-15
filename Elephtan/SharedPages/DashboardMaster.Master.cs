using Elephtan.DataModel;
using Elephtan.UserService;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Elephtan.SharedPages
{
    public partial class DashboardMaster : System.Web.UI.MasterPage
    {
        private const string DEPARTMENT_STAFF_OVERVIEW = "~/StationeryDepartment/DeartmentStaffOverview.aspx";
        private const string DEPARTMENT_HEAD_OVERVIEW = "~/StationeryDepartment/DepartmentHeadOverview.aspx";
        private const string STATIONARY_STORE_OVERVIEW = "~/StationeryStore/StationaryStoreOverview.aspx";
        
        // Department Menu Item Constant String
        
        private const string menuItemDepartmentStaffOverview = "<span class=\"glyphicon glyphicon-blackboard\"></span>&nbsp;Overview";
        private const string menuItemDepartmentRequestStationary = "<span class=\"glyphicon glyphicon-file\"></span>&nbsp;Request Stationary";
        private const string menuItemDepartmentHeadPendingRequest = "<span class=\"glyphicon glyphicon-list-alt\"></span>&nbsp;Pending Request";
        private const string menuItemDepartmentHeadSetting = "<span class=\"glyphicon glyphicon-cog\"></span>&nbsp;Settings";

        // Stationary Menu Item Constant String
        private const string menuItemStoreOverview = "";
        private const string menuItemStore = "";

        
        protected void Page_Load(object sender, EventArgs e)
        {
            UserInfo currrentUser = (UserInfo)Session["currentUser"];
            ArrayList menuList = new ArrayList();

            HttpCookie cookie1 = Request.Cookies.Get("LogicalUserName");
            HttpCookie cookie2 = Request.Cookies.Get("LogicalUserPass");
            if (null != cookie1 && cookie2 != null)
            {
                string userName = cookie1.Value;
                string passWord = cookie2.Value;
                if (Login(userName, passWord))
                    Forward();
                else
                    Response.Redirect("~/SharedPages/signin.aspx");
            }
            
            if (!IsPostBack)
            {
                this.labelUserId.Text = currrentUser.UserName + " (" + currrentUser.DepartmentName+")";
                foreach (var item in currrentUser.Menus)
                {
                    menuList.Add(item.Name);
                    
                }
                this.listViewMenuItem.DataSource = menuList;
                this.listViewMenuItem.DataBind();
            }            
        }

        /// <summary>
        /// varify user and password combination
        /// Get WebService instance
        /// </summary>
        /// <param name="userNo"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        private bool Login(string userNo, string password)
        {

            UserService.UserServiceSoapClient userServiceSoapClient
                = new UserService.UserServiceSoapClient();

            UserService.UserFindRequest userFindRequest =
                new UserService.UserFindRequest();

            userFindRequest.UserNo = userNo;

            UserService.UserFindResponse userFindResponse =
            userServiceSoapClient.QueryUserByNum(userFindRequest);
            bool result = false;
            if (password.Equals(userFindResponse.Password))
            {
                UserInfo userInfo = new UserInfo();
                userInfo.UserId = userFindResponse.UserId;
                userInfo.UserName = userFindResponse.UserName;
                userInfo.UserNo = userFindResponse.UserNo;
                userInfo.Password = userFindResponse.Password;
                userInfo.UserId = userFindResponse.UserStatus;
                RoleEntry[] roles = userFindResponse.Roles;
                List<Elephtan.DataModel.Menu> menuList = new List<Elephtan.DataModel.Menu>();
                Dictionary<string, string> menuDict = new Dictionary<string, string>();
                userInfo.Roles = new List<string>();
                foreach (RoleEntry roleEntry in roles)
                {
                    userInfo.Roles.Add(roleEntry.RoleName);
                    MenuEntry[] menus = roleEntry.Menus;
                    foreach (MenuEntry menuEntry in menus)
                    {
                        Elephtan.DataModel.Menu menu = new Elephtan.DataModel.Menu();
                        menu.Name = menuEntry.MenuName;
                        menu.Url = menuEntry.Url;
                        menuDict.Add(menu.Name, menu.Url);
                        menuList.Add(menu);
                    }
                }

                userInfo.Menus = menuList;
                userInfo.MenuDict = menuDict;
                Session["currentUser"] = userInfo;
                result = true;
            }
            return result;
        }

        private void Forward()
        {
            UserInfo userInfo = (UserInfo)Session["currentUser"];
            foreach (string entry in userInfo.Roles)
            {
                string roleName = entry;
                if (roleName.Equals("Head"))
                {
                    Response.Redirect(DEPARTMENT_HEAD_OVERVIEW);
                }

                if (roleName.Equals("Staff") || roleName.Equals("Representative"))
                {
                    Response.Redirect(DEPARTMENT_STAFF_OVERVIEW);
                    break;
                }

                if (roleName.Equals("Clerk") || roleName.Equals("Supervisor") || roleName.Equals("Manager"))
                {
                    Response.Redirect(STATIONARY_STORE_OVERVIEW);
                }
            }
        }

        protected void linkButtonLogout_Click(object sender, EventArgs e)
        {
            Session.Abandon();

            // Clear Cookies
            HttpCookie cookie01 = new HttpCookie("LogicalUserName");
            HttpCookie cookie02 = new HttpCookie("LogicalUserPass");

            cookie01.Expires = DateTime.Now.AddDays(-1d);
            cookie02.Expires = DateTime.Now.AddDays(-1d);

            Response.Cookies.Add(cookie01);
            Response.Cookies.Add(cookie02);
            
            Response.Redirect("~/SharedPages/signin.aspx");
        }

        protected void menuItem_Click(object sender, EventArgs e)
        {
            
            LinkButton clickedMenuItem = (LinkButton)sender;
            string menuItemStr = clickedMenuItem.Text;
            Debug.WriteLine(">>> menuItem_Click item: " + clickedMenuItem.Text);

            UserInfo currrentUser = (UserInfo)Session["currentUser"];

            Response.Redirect(currrentUser.MenuDict[menuItemStr]);
        }
    }
}