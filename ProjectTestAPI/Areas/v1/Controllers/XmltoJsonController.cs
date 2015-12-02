using Newtonsoft.Json;
using ProjectTestAPI.Areas.v1.Models.DataModel;
using ProjectTestAPI.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using System.Xml;
using System.Xml.Serialization;

namespace ProjectTestAPI.Areas.v1.Controllers
{
    public class XmltoJsonController : ApiController
    {
      

        // POST: api/XmltoJson
        //public Tourelements Post()
        //{
        //    Tourelements TourElementsClass= new Tourelements();
        //    try
        //    {
        //        var httpRequest = System.Web.HttpContext.Current.Request;
        //        if (httpRequest.InputStream.CanRead)
        //        {
        //            var reader11 = new System.IO.StreamReader(httpRequest.InputStream);
        //            var _data = reader11.ReadToEnd();
        //            XmlDocument doc = new XmlDocument();
        //            doc.LoadXml(_data);
        //            //string first ="<?xml "+ doc.FirstChild.InnerText+"?>";
        //            doc.RemoveChild(doc.FirstChild);
        //            XmlNodeList root = doc.SelectSingleNode("//SendOrderMain").ChildNodes;
        //            foreach (XmlNode x in root)
        //            {
        //                string pp = Newtonsoft.Json.JsonConvert.SerializeXmlNode(doc.SelectSingleNode("//SendOrderMain/TourElements"));
        //                TourElementsClass = JsonConvert.DeserializeObject<Tourelements>(pp);
        //            }
        //            // strJson = Newtonsoft.Json.JsonConvert.SerializeXmlNode(doc);
        //            // OrderJsonClass = JsonConvert.DeserializeObject<OrderJson>(strJson);

        //        }
        //    }
        //    catch (Exception ex) 
        //    {
                
        //    }
           
          
        //    return TourElementsClass;
        //}


        public XmlDocument GET() 
        {
            #region 宣告 ／ 自行填入參數
            string BaseUrl = "http://124.9.7.197/servlet/b2b2c.servlet.SearchList";
            string Agent = "3430056";
            string ApiKey = "R7mwj2hmVn0JZQ5g9DH";
            string DepCity = "TPE";
            string ArrCity = "KIX";
            DateTime DepDate = Convert.ToDateTime("2015-11-02");
            DateTime RtnDate = Convert.ToDateTime("2015-11-08");
            byte Rooms = 1;
            byte Adult = 2;
            byte Child = 1;
            byte Age = 5;
            string HotelIDs = "463226";
            DateTime ChkInDate = Convert.ToDateTime("2015-11-02");
            DateTime ChkOutDate = Convert.ToDateTime("2015-11-07");
            string SearchID = "";

            string InResult = string.Empty;
            string OutResult = string.Empty;

            string text = string.Empty;
            string client = string.Empty;

            //輸入參數用的 XML
            XmlDocument ReaderDoc = new XmlDocument();
            //回傳結果用的 XML
            XmlDocument ResultDoc = new XmlDocument();
            SEARCHLIST SearchListData = new SEARCHLIST();
            #endregion
            try
            {

                #region 節點
                SearchListData.AGENT = Convert.ToUInt32(Agent);
                SearchListData.APIKEY = ApiKey;
                SearchListData.DEPCITY = DepCity;
                SearchListData.ARRCITY = ArrCity;
                SearchListData.DEPDATE = DepDate;
                SearchListData.RTNDATE = RtnDate;
                SearchListData.ROOMS = Rooms;
                SearchListData.ADULT = Adult;
                SearchListData.CHILDREN = new SEARCHLISTCHILDREN();
                SearchListData.CHILDREN.CHILD = Child;
                SearchListData.CHILDREN.AGES = new SEARCHLISTCHILDRENAGES();
                SearchListData.CHILDREN.AGES.AGE = Age;
                SearchListData.HOTELIDS = Convert.ToUInt32(HotelIDs);
                SearchListData.CHKINDATE = ChkInDate;
                SearchListData.CHKOUTDATE = ChkOutDate;
                SearchListData.SEARCHID = SearchID;
                #endregion

                #region 測試用的方法堆



                #endregion


                XmlSerializer ser = new XmlSerializer(SearchListData.GetType());
                StringBuilder sb = new StringBuilder();
                StringWriter writer = new StringWriter(sb);
                ser.Serialize(writer, SearchListData);
                text = sb.ToString();
                ReaderDoc.LoadXml(text);
                ReaderDoc.RemoveChild(ReaderDoc.FirstChild);
                InResult = ReaderDoc.InnerXml;

                WebClient webClient = new WebClient();
                webClient.Headers.Add(HttpRequestHeader.Accept, "text/xml");


                webClient.Encoding = Encoding.UTF8;
                //回傳結果的XML
                client = webClient.UploadString(BaseUrl, InResult);

                ResultDoc.LoadXml(client);
                return ResultDoc;
            }
            catch (Exception ex)
            {
                return ResultDoc;
            }
            
        }

        
    }
}
