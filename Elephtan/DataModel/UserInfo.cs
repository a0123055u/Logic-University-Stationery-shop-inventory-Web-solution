using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Elephtan.DataModel
{
    public class UserInfo
    {
        private string userId;

        public string UserId
        {
            get { return userId; }
            set { userId = value; }
        }
        private string userName;

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        private string userNo;

        public string UserNo
        {
            get { return userNo; }
            set { userNo = value; }
        }
        private string departmentCode;

        public string DepartmentCode
        {
            get { return departmentCode; }
            set { departmentCode = value; }
        }

        private string departmentId;

        public string DepartmentId
        {
            get { return departmentId; }
            set { departmentId = value; }
        }
        private string departmentName;

        public string DepartmentName
        {
            get { return departmentName; }
            set { departmentName = value; }
        }
        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        List<string> roles = new List<string>();

        public List<string> Roles
        {
            get { return roles; }
            set { roles = value; }
        }
        List<Menu> menus;

        public List<Menu> Menus
        {
            get { return menus; }
            set { menus = value; }
        }

        Dictionary<string, string> menuDict;

        public Dictionary<string, string> MenuDict
        {
            get { return menuDict; }
            set { menuDict = value; }
        }







    }

}