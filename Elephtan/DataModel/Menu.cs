using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Elephtan.DataModel
{
    public class Menu
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string url;

        public string Url
        {
            get { return url; }
            set { url = value; }
        }

    }
}