using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProjectTestAPI.Areas.v1.Controllers
{
    public class TTTTTTController : ApiController
    {
        // GET: api/TTTTTT
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/TTTTTT/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/TTTTTT
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/TTTTTT/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/TTTTTT/5
        public void Delete(int id)
        {
        }
    }
}
