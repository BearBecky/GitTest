using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProjectTestAPI.Areas.v1.Controllers
{
    public class TestSpliteLengthController : ApiController
    {
       

        // GET: api/TestSpliteLength/5
        public string Get()
        {
            int Page = 0;
            int GroupPage = 0;
            

            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            //Page = arr.Count() / 3;
            //if (arr.Count() % 3 > 0)
            //{
            //    Page = Page + 1;
            //}

            List<int> SpliteList = new List<int>();
            foreach (var item in arr) 
            {
                SpliteList.Add(item);
                if (SpliteList.Count == 3) 
                {
                    GroupPage++;

                    //做存檔的事
                    SpliteList = new List<int>();
                }
            }





            return "value";
        }

        
    }
}
