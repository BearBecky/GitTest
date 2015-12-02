using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectTestAPI.Areas.V1.Models.DataModel
{
    public class test
    {
        public string EmpNo { get; set; }
        public string Cname { get; set; }
        public string Ename { get; set; }
        public string Prof { get; set; }
        public string ProfID { get; set; }
        public string HeadImage { get; set; }
        public string Job { get; set; }
        public string Team { get; set; }
        public bool IsWork { get; set; }
    }

    public class Data
    {
        public int Total { get; set; }
        public List<test> ListEmp { get; set; }
    }

}