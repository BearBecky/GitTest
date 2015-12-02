using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProjectTestAPI.Areas.v1.Controllers
{
    public class TestDateTimeController : ApiController
    {
        

        public string Get()
        {
            
            string strDateTime=string.Empty;
            DateTime? dt = string.IsNullOrWhiteSpace(strDateTime) ? (Nullable<DateTime>)null : Convert.ToDateTime("2015/11/11 09:46:00");
            return "";
        }
    }
}
