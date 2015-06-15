using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Elephtan.DataModel
{
    public class SessionObjectList
    {
        // For storing dummy test user Object
        // Initialisa at every page
        public static string dummyUser = "dummyUser";
        
        // For storing current user Object
        public static string currentUser = "currentUser";

        // For storing current selected request detail
        public static string selectedRequest = "selectedRequest";

        // Request Detail for Stationary Request Confirmation
        public static string requestDetail = "requestDetail";

    }
}