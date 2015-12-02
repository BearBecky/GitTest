using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProjectTestAPI.Areas.v1.Controllers
{
    public class TeststearmController : ApiController
    {
        // GET: api/Teststearm
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Teststearm/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Teststearm
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Teststearm/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Teststearm/5
        public void Delete(int id)
        {
        }
    }
}
