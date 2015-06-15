using Elephtan.DataModel;
using Elephtan.UserService;
using store.sg.edu.nus.utility;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Elephtan.DictService;

namespace Elephtan.SharedPages
{
    public partial class signin : System.Web.UI.Page
    {

        private const string DEPARTMENT_STAFF_OVERVIEW = "~/StationeryDepartment/DeartmentStaffOverview.aspx";
        private const string DEPARTMENT_HEAD_OVERVIEW = "~/StationeryDepartment/DepartmentHeadOverview.aspx";
        private const string STATIONARY_STORE_OVERVIEW = "~/StationeryStore/StationaryStoreOverview.aspx";

        protected void Page_Load(object sender, EventArgs e)
        {
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

        }

        protected void buttonLogin_Clicked(object sender, EventArgs e)
        {

            string userNo = this.inputEmail.Text;
            string userPassword = this.inputPassword.Text;
            string MD5Password = SystemUtility.Encrypt(userPassword);
            if (Login(userNo, MD5Password))
            {

                UserInfo userInfo = (UserInfo)Session["currentUser"];
                // Check the signed in checkbox
                bool checkboxRememberMeState = this.checkboxRememberMe.Checked;
                if (checkboxRememberMeState)
                {
                    var cookie1 = new HttpCookie("LogicalUserName", userInfo.UserNo);
                    cookie1.Expires = DateTime.Now.AddDays(7);
                    var cookie2 = new HttpCookie("LogicalUserPass", userInfo.Password);
                    cookie2.Expires = DateTime.Now.AddDays(7);
                    Response.Cookies.Add(cookie2);
                    Response.Cookies.Add(cookie1);
                }
                Forward();
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
            if (Application["Dict"] == null) {
                lock (this)
                {
                    if(Application["Dict"] == null)
                    { 

                        //load all the dict
                        DictFindRequest dictRequest = new DictFindRequest();
                        DictServiceSoapClient dictService
                            = new DictServiceSoapClient();
                        DictFindListResponse response
                            = dictService.QueryDictList(dictRequest);
                        if (null != response && "1".Equals(response.ServiceResponseCode))
                        {
                            Dictionary<string, Dictionary<string, string>> dicts = new Dictionary<string, Dictionary<string, string>>();
                            DictFindResponse[] dictResponseList = response.ListResponse;
                            Dictionary<string, string> dict = null;
                            if (null != dicts)
                            {
                                foreach (DictFindResponse entry in dictResponseList)
                                {
                                    dict = null;
                                    dicts.TryGetValue(entry.DictTypeCode, out dict);
                                    if (null == dict)
                                    {
                                        dict = new Dictionary<string, string>();
                                        dicts.Add(entry.DictTypeCode, dict);
                                    }
                                    dict.Add(entry.DictValue, entry.DictName);
                                }

                                Application["Dict"] = dicts;
                                SystemUtility.application = Application;
                            }
                        }

                    }
                }
               
            }

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
                userInfo.DepartmentId = userFindResponse.DepartmentId;
                userInfo.DepartmentName = userFindResponse.DepartmentName;

                RoleEntry[] roles = userFindResponse.Roles;
                List<Elephtan.DataModel.Menu> menuList = new List<Elephtan.DataModel.Menu>();
                Dictionary<string, string> menuDict = new Dictionary<string, string>();
                userInfo.Roles = new List<string>();
                foreach (RoleEntry roleEntry in roles)
                {
                    userInfo.Roles.Add(roleEntry.RoleName);
                    MenuEntry[] menus = roleEntry.Menus;
                    if (null != menus) {
                        foreach (MenuEntry menuEntry in menus)
                        {
                            Elephtan.DataModel.Menu menu = new Elephtan.DataModel.Menu();
                            menu.Name = menuEntry.MenuName;
                            menu.Url = menuEntry.Url;
                            menuDict.Add(menu.Name, menu.Url);
                            menuList.Add(menu);
                        }
                    }
                    
                }

                userInfo.Menus = menuList;
                userInfo.MenuDict = menuDict;
                Session["currentUser"] = userInfo;
                result = true;
            }
            return result;
        }

        private void Forward() {
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

                if (roleName.Equals("Store Clerk") || roleName.Equals("Supervisor") || roleName.Equals("Manager"))
                {
                    Response.Redirect(STATIONARY_STORE_OVERVIEW);
                }
            }
        }
    }

}