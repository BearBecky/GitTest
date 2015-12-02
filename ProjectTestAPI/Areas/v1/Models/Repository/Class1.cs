using Newtonsoft.Json;
using ProjectTestAPI.Areas.V1.Models.DataModel;
using ProjectTestAPI.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;


namespace ProjectTestAPI.Areas.V1.Controllers
{
    public class Class1
    {
        public ResponseBase<Data> aa(string UserId, string EncodePassword, string Search, string StartRow, string EndRow)
        {
            ResponseBase<Data> ReturnResult = new ResponseBase<Data>();
            string SUrl = string.Empty;
            string content = string.Empty;
            SUrl = "https://uemployee.api.liontravel.com/api/V1/EmployeeContent?UserId=" + UserId + "&EncodePassword=" + EncodePassword + "&Search=" + Search + "&StartRow=" + StartRow + "&EndRow=" + EndRow;
            var request = HttpWebRequest.Create(SUrl);
            request.ContentType = "application/json";
            request.Method = "GET";
            request.Headers.Add("Authorization", "basic MjA2OTQ2MzE5NjkzMjU0OTYzMjAxNS81LzI4IKRXpMggMTE6NTE6NTI");
            using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
            {
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    Console.Out.WriteLine("Error fetching data. Server returned status code: {0}", response.StatusCode);

                    return ReturnResult;
                }

                using (StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8))
                {
                    content = reader.ReadToEnd();


                    ReturnResult = JsonConvert.DeserializeObject<ResponseBase<Data>>(content);
                }

            }

          
            return ReturnResult;
        }
    }
}