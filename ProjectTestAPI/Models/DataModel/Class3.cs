using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectTestAPI.Models.DataModel
{
    public class Class3
    {
        public string AA { get; set; }

        public string BB { get; set; }

        public List<Class2>  Class2 {get;set;}

    }

    public class Class2
    {

        public string DD { get; set; }

        public string EE { get; set; }
    }
}