using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProjectTestAPI.Areas.v1.Controllers
{
    public class ErrorPageController : ApiController
    {
    
        // GET: api/ErrorPage/5
        public string Get(int statusCode, Exception exception)
        {
            var aa = statusCode;

            return aa.ToString();
        }
    }
}
