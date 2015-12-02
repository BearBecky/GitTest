using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectTestAPI.Areas.v1.Models.DataModel
{
    public class result
    {
        public int count { get; set; }
        public int fee { get; set; }
        public int sid { get; set; }
    }

    public class Template
    {
        public int code { get; set; }
        public string msg { get; set; }
        public result result { get; set; }
    }
}