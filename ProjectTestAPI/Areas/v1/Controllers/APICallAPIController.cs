using Newtonsoft.Json;
using ProjectTestAPI.Areas.v1.Models.DataModel;
using ProjectTestAPI.Models;
using Sms.CN.ExAPI.Areas.V1.Models.DataModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Configuration;
using System.Web.Http;

namespace ProjectTestAPI.Areas.v1.Controllers
{
    public class APICallAPIController : ApiController
    {
        public static readonly string Url = WebConfigurationManager.AppSettings["Url"];
        public static readonly string TplUrl = WebConfigurationManager.AppSettings["TplUrl"];

        /// <summary>
        /// Post呼叫SMS平台API
        /// </summary>
        /// <param name="strparameter"></param>
        /// <param name="PostUrl"></param>
        /// <returns></returns>
        public static string FunWebClientPost(string strparameter, string PostUrl)
        {
            string strResult = string.Empty;
            try
            {
                System.Net.WebRequest req = System.Net.WebRequest.Create(PostUrl);
                req.ContentType = "application/x-www-form-urlencoded";
                req.Method = "POST";
                byte[] bytes = System.Text.Encoding.UTF8.GetBytes(strparameter);//这里编码设置为utf8
                req.ContentLength = bytes.Length;
                System.IO.Stream os = req.GetRequestStream();
                os.Write(bytes, 0, bytes.Length);
                os.Close();
                System.Net.WebResponse resp = req.GetResponse();
                if (resp == null) return null;
                StreamReader sr = new StreamReader(resp.GetResponseStream());
                strResult = sr.ReadToEnd().Trim();
                return strResult;
            }
            catch (Exception ex)
            {
                return strResult;
            }
        }


        /// <summary>
        /// 創瑞
        /// </summary>
        /// <returns></returns>
        public ResponseBase<string> Post()
        {
            #region 宣告
            //參數宣告
            ResponseBase<string> RespBaseReturn = new ResponseBase<string>();
            //預設值
            RespBaseReturn.IsSuccess = true;
            RespBaseReturn.Msg = "";
            RespBaseReturn.Data = null;
            //DataModel
            StatusUp StatusUpClass = new StatusUp();
            //變數
            string strparameter = string.Empty;
            string client = string.Empty;
            string strUrltoJson = string.Empty;
            var httpRequest = System.Web.HttpContext.Current.Request;
            #endregion
            try
            {
                if (httpRequest.InputStream.CanRead)//將Url轉成Json格式
                {
                    var reader = new System.IO.StreamReader(httpRequest.InputStream);//用httpRequsest去讀取InputStream，InputStream的資料是從
                    strUrltoJson = reader.ReadToEnd();//停止讀取posman的json資料

                    StatusUpClass = JsonConvert.DeserializeObject<StatusUp>(strUrltoJson);
                }
                strparameter = "name=" + StatusUpClass.name + "&pwd=" + StatusUpClass.pwd + "&sendid=" + StatusUpClass.sendid + "&time=" + StatusUpClass.time + "&mobile=" + StatusUpClass.mobile + "&state=" + StatusUpClass.state;
                client = FunWebClientPost(strparameter, Url);
                if (string.IsNullOrWhiteSpace(client))
                {
                    RespBaseReturn.Msg = "修改資料失敗！";
                    return RespBaseReturn;
                }
                RespBaseReturn = JsonConvert.DeserializeObject<ResponseBase<string>>(client);
                return RespBaseReturn;
            }
            catch (Exception ex)
            {
                return RespBaseReturn;
            }
        }

        ///// <summary>
        ///// 雲片
        ///// </summary>
        ///// <returns></returns>
        //public ResponseBase<string> Post()
        //{
        //    #region 宣告
        //    //參數宣告
        //    ResponseBase<string> RespBaseReturn = new ResponseBase<string>();
        //    //預設值
        //    RespBaseReturn.IsSuccess = true;
        //    RespBaseReturn.Msg = "";
        //    RespBaseReturn.Data = null;
        //    //DataModel
        //    TplStatus TplStatusClass = new TplStatus();
        //    //變數
        //    string strparameter = string.Empty;
        //    string client = string.Empty;
        //    string strUrltoJson = string.Empty;
        //    var httpRequest = System.Web.HttpContext.Current.Request;
        //    #endregion
        //    try
        //    {
        //        if (httpRequest.InputStream.CanRead)//將Url轉成Json格式
        //        {
        //            var reader = new System.IO.StreamReader(httpRequest.InputStream);//用httpRequsest去讀取InputStream，InputStream的資料是從
        //            strUrltoJson = reader.ReadToEnd();//停止讀取posman的json資料
        //        }

        //        var httpWebRequest = (HttpWebRequest)WebRequest.Create(TplUrl);
        //        httpWebRequest.ContentType = "text/json";
        //        httpWebRequest.Method = "POST";

        //        using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
        //        {

        //            streamWriter.Write(strUrltoJson);
        //            streamWriter.Flush();
        //            streamWriter.Close();
        //        }

        //        var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
        //        using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
        //        {
        //            client = streamReader.ReadToEnd();
        //        }
        //        RespBaseReturn = JsonConvert.DeserializeObject<ResponseBase<string>>(client);

        //        return RespBaseReturn;
        //    }
        //    catch (Exception ex)
        //    {
        //        return RespBaseReturn;
        //    }

        //}

        ///// <summary>
        ///// 模板审核状态
        ///// </summary>
        ///// <returns></returns>
        //public ResponseBase<string> Post()
        //{
        //    #region 宣告
        //    //參數宣告
        //    ResponseBase<string> RespBaseReturn = new ResponseBase<string>();
        //    //預設值
        //    RespBaseReturn.IsSuccess = true;
        //    RespBaseReturn.Msg = "";
        //    RespBaseReturn.Data = null;
        //    //DataModel
        //    TemplateApprove TemplateApproveClass = new TemplateApprove();
        //    //變數
        //    string strparameter = string.Empty;
        //    string client = string.Empty;
        //    string strUrltoJson = string.Empty;
        //    var httpRequest = System.Web.HttpContext.Current.Request;
        //    #endregion
        //    try
        //    {
        //        if (httpRequest.InputStream.CanRead)//將Url轉成Json格式
        //        {
        //            var reader = new System.IO.StreamReader(httpRequest.InputStream);//用httpRequsest去讀取InputStream，InputStream的資料是從
        //            strUrltoJson = reader.ReadToEnd();//停止讀取posman的json資料

        //            TemplateApproveClass = JsonConvert.DeserializeObject<TemplateApprove>(strUrltoJson);
        //        }
        //        strparameter = "name="+TemplateApproveClass.name+"&pwd="+TemplateApproveClass.pwd+"&tid="+TemplateApproveClass.tid+"&state="+TemplateApproveClass.state+"&msg="+TemplateApproveClass.msg;
        //       // client = FunWebClientPost(strparameter, Url);
        //        if (string.IsNullOrWhiteSpace(client))
        //        {
        //            RespBaseReturn.Msg = "無查審核狀態資料！";
        //            return RespBaseReturn;
        //        }
        //        RespBaseReturn = JsonConvert.DeserializeObject<ResponseBase<string>>(client);
        //        return RespBaseReturn;
        //    }
        //    catch (Exception ex)
        //    {
        //        return RespBaseReturn;
        //    }

        //}


    }
}
