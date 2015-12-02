using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Xml;

namespace ProjectTestAPI.Areas.v1.Controllers
{
    public class TestReadFileController : ApiController
    {
        

        // GET: api/TestReadFile/5
        public string GET()
        {
            string strUrl = @"E:\Data\Desktop\TktList\TktList\TktList.xml";
            XmlDocument xml = new XmlDocument();
            try
            {
                xml.Load(strUrl);
                //int Total = xml.SelectSingleNode("//TKTS").ChildNodes.Count;
                
                //XmlNodeList tweets = xml.GetElementsByTagName("DEPCITY");
                //XmlNodeList tweets1 = xml.GetElementsByTagName("ARRCITY");
                //for (int i = 0; i < tweets.Count; i++)
                //{
                    
                //       string strDepCity = tweets[i].InnerText;

                //}
                //for (int i = 0; i < tweets1.Count; i++)
                //{
                //      string strArrCity = tweets[i].InnerText;
                //}
                //for (int i = 0; i < Total; i++) 
                //{
                //    var aa = xml.SelectSingleNode("//TKTS/TKT/ARRCITY");

                //}
                //<DEPCITY> ARRCITY
            }
            catch (Exception ex) 
            {
                
            }
            return "value";
        }

       
    }
}
