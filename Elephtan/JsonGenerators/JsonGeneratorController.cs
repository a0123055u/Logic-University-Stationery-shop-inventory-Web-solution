using Elephtan.DataModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Elephtan.ReportService;
using System.Diagnostics;
namespace Elephtan.JsonGenerators
{
    public class JsonGeneratorController : ApiController
    {
        ReportServiceSoapClient reportService =
            new ReportServiceSoapClient();

        [AcceptVerbs("GET")]
        public string DepartmentStaffOverview() {
            string json = "[{\"id\":1,\"name\":\"Test1\"},{\"id\":2,\"name\":\"Test2\"}]";

            // Web Service Here

            ArrayList previousMonthRequests = new ArrayList();


            return json;
        }

        [AcceptVerbs("GET")]
        public string DepartmentHeadOverview()
        {
            string json = "[{\"firstName\":\"John\",\"lastName\":\"Doe\"},{\"firstName\":\"Anna\",\"lastName\":\"Smith\"}]";

            return json;
        }
        
        [AcceptVerbs("GET")]
        public string StationaryStoreOverviewPart01()
        {
            
            ArrayList stationaryStoreOverviewList = getStationaryStoreOverviewDataObject(1);

            return convertArrayIntoString(stationaryStoreOverviewList);
            
        }
        [AcceptVerbs("GET")]
        public string StationaryStoreOverviewPart02()
        {

            ArrayList stationaryStoreOverviewList = getStationaryStoreOverviewDataObject(2);

            return convertArrayIntoString(stationaryStoreOverviewList);

        }
        [AcceptVerbs("GET")]
        public string StationaryStoreOverviewPart03()
        {

            ArrayList stationaryStoreOverviewList = getStationaryStoreOverviewDataObject(3);

            return convertArrayIntoString(stationaryStoreOverviewList);

        }

        protected string convertArrayIntoString(ArrayList arrayList)
        {
            string[] colorCode = new string[3] { "#F7464A", "#46BFBD", "#FDB45C" };
            string[] hightlightCode = new string[3] { "#FF5A5E", "#5AD3D1", "#FFC870" };

            string jsonStr = "[";
            int objectCounter = 0;
            foreach (OverviewDisplayObject obj in arrayList)
            {
                jsonStr += "{";

                jsonStr += "\"value\":";
                jsonStr += obj.value + ",";
                jsonStr += "\"color\":\"" + colorCode[objectCounter] + "\",";
                jsonStr += "\"hightlight\":\"" + hightlightCode[objectCounter] + "\",";
                jsonStr += "\"label\":\"" + obj.label + "\"";

                jsonStr += "},";
                objectCounter++;
                if (objectCounter == 3)
                    break;

            }
            jsonStr = jsonStr.Remove(jsonStr.Length - 1);
            jsonStr += "]";

            return jsonStr;
        }

        protected ArrayList getStationaryStoreOverviewDataObject(int partNum) {

            ArrayList list = new ArrayList();

            string[] monthName = new string[12] {"Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"};

            int monthNum = 0;

            if (partNum == 1) {
                monthNum = DateTime.Now.Month;
            }
            else if (partNum == 2)
            {
                monthNum = DateTime.Now.AddMonths(-1).Month;
            }
            else if (partNum == 3)
            {
                monthNum = DateTime.Now.AddMonths(-2).Month;
            }

            string yearStr = Convert.ToString(DateTime.Now.Year);
            
            ReportFindRequest request = new ReportFindRequest();
            request.ReportType = "1";
            request.TopItemRange = "3";
            request.StartDate = "01/"+monthName[monthNum - 1]+"/"+yearStr; // 09/Jan/2013 23:22:22
            request.EndDate = "01/"+monthName[monthNum]+"/"+yearStr;

            ReportFindResponse response = reportService.QueryReport(request);
            if (null != response && "1".Equals(response.ServiceResponseCode)) {
                ReportDepartmentItemInfo[] reports = response.ReportDepartmentItemInfoList;
                if (null != reports) {

                    foreach (ReportDepartmentItemInfo depReport in reports) {

                        String departmentName = depReport.DepartmentName;
                        //
                        //

                        ReportItemInfo[] reportItems = depReport.ReportItemInfoList;
                        foreach (ReportItemInfo item in reportItems) { 
                            //
                            //
                            OverviewDisplayObject obj = new OverviewDisplayObject();
                            obj.value = item.AppliedQuantity;
                            obj.label = item.ItemName;

                            list.Add(obj);
                        }

                    }
                }
            }

            return list;
        }

    }
}