using ProjectTestAPI.Areas.v1.Models.DataModel;
using Sms.CN.ExAPI.Areas.V1.Models.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProjectTestAPI.Areas.v1.Controllers
{
    public class TestPostWeClientController : ApiController
    {
        // <summary>
        // 發送模版簡訊SMSCN
        // </summary>
        // <param name="GetTemplateClass"></param>
        // <returns></returns>
        //public Template Post(GetTemplate GetTemplateClass)
        //{
        //    Template TemplateClass = new Template();
        //    try
        //    {
        //        #region 成功
        //        TemplateClass.code = 0;
        //        TemplateClass.msg = "OK";
        //        TemplateClass.result = new result();
        //        TemplateClass.result.count = 3;
        //        TemplateClass.result.fee = 3;
        //        TemplateClass.result.sid = 2500;
        //        #endregion

        //        #region 失敗
        //        //TemplateClass.code = 5;
        //        //TemplateClass.msg = "未找到对应id的模板";
        //        //TemplateClass.result = null;

        //        #endregion
        //        return TemplateClass;
        //    }
        //    catch (Exception ex)
        //    {
        //        return TemplateClass;
        //    }

        //}
        /// <summary>
        /// 發送自訂樣式簡訊SMSCN
        /// </summary>
        /// <param name="GetUniqueClass"></param>
        /// <returns></returns>
        public string Post(GetUnique GetUniqueClass)
        {
            string strResult = string.Empty;
            try
            {
                #region 成功
                strResult = "0,20130821110353234137876580,0,500,0,提交成功";
                #endregion

                #region 失敗
                // strResult = "1,失敗";
                #endregion

                return strResult;
            }
            catch (Exception ex)
            {
                return strResult;
            }

        }

        ///// <summary>
        ///// 取得模板SMSCN
        ///// </summary>
        ///// <param name="GetUniqueClass"></param>
        ///// <returns></returns>
        //public Tpl Post(GetTpl GetTplClass)
        //{
        //    Tpl TplClass = new Tpl();

        //    try
        //    {
        //        TplClass.code = 0;
        //        TplClass.msg = "OK";
               
        //        template templateClass = new template();
        //        templateClass.tpl_id = 1;
        //        templateClass.tpl_content = "【#company#】您的验证码是#code#";
        //        templateClass.check_status = "SUCCESS";
        //        templateClass.reason = null;
        //        TplClass.template = templateClass;


        //        return TplClass;
        //    }
        //    catch (Exception ex)
        //    {
        //        return TplClass;
        //    }

        //}

        ///// <summary>
        ///// 餘額查詢SMSCN
        ///// </summary>
        ///// <param name="GetUniqueClass"></param>
        ///// <returns></returns>
        //public string Post(GetUnique GetUniqueClass)
        //{
        //    string strResult = string.Empty;
        //    try
        //    {

        //        strResult = "0,123547788955956956";

        //        return strResult;
        //    }
        //    catch (Exception ex)
        //    {
        //        return strResult;
        //    }

        //}


        ///// <summary>
        ///// 餘額查詢SMSCN
        ///// </summary>
        ///// <param name="GetUniqueClass"></param>
        ///// <returns></returns>
        //public string Post(GetUnique GetUniqueClass)
        //{
        //    string strResult = string.Empty;
        //    try
        //    {

        //        strResult = "0,123547788955956956";

        //        return strResult;
        //    }
        //    catch (Exception ex)
        //    {
        //        return strResult;
        //    }

        //}

        ///// <summary>
        ///// 餘額查詢SMSCN
        ///// </summary>
        ///// <param name="GetUniqueClass"></param>
        ///// <returns></returns>
        //public string Post(StatusUp StatusUpClass)
        //{
        //    string strResult = string.Empty;
        //    try
        //    {

               

        //        return "1";
        //    }
        //    catch (Exception ex)
        //    {
        //        return "0";
        //    }

        //}



    }
}
