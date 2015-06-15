using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
using System.Web.Script.Services;

namespace Elephtan.JsonGenerators
{
    public partial class JsonDepartmentOverview : System.Web.UI.Page
    {
        [WebMethod]
        [ScriptMethod(UseHttpGet=true, ResponseFormat=ResponseFormat.Json)]
        protected void Page_Load(object sender, EventArgs e)
        {
            string json = "[{value:300,color:'#F7464A',highlight:'#FF5A5E',label:'Red'},{value:50,color:'#46BFBD',highlight:'#5AD3D1',label:'Green'},{value:100,color:'#FDB45C',highlight:'#FFC870',label:'Yellow'}]";
            
            Response.Clear();
            Response.AppendHeader("Access-Control-Allow-Origin", "*");
            Response.ContentType = "application/json; charset=utf-8";
            Response.Write(json);
            Response.End();
        }
    }
}