using Dapper;
using ProjectTestAPI.Models;
using Sms.CN.ExAPI.Areas.V1.Models.DataModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProjectTestAPI.Areas.v1.Controllers
{
    public class TestIISErrorController : ApiController
    {
      

        // GET: api/TestIISError/5
        public string Post(StatusUp StatusUpClass)
        {
            string aa = "";
            return "value";
        }
        public ResponseBase<string> SmsStatusUp(StatusUp StatusUpClass)
        {
            #region 宣告
            //參數宣告
            ResponseBase<string> RespBaseReturn = new ResponseBase<string>();
            //預設值
            RespBaseReturn.IsSuccess = true;
            RespBaseReturn.Data = null;
            RespBaseReturn.Msg = "";
            //變數
            string client = string.Empty;
            string strparameter = string.Empty;
            //查詢結果
            string strResult = string.Empty;
            string strQuery = string.Empty;
            //是否更新成功
            int intIsVaild = 0;
            //SQL 條件判斷
            string strWhere = string.Empty;
            //計算Mobile數量
            int intMobileCount = 0;
            string[] strarrMobile;
            #endregion

            try
            {

                #region SQL 參數
                DynamicParameters sqlParm = new DynamicParameters();
                sqlParm.Add("@Status", StatusUpClass.state);
                sqlParm.Add("@Sendid", StatusUpClass.sendid);
                sqlParm.Add("@Mobile", StatusUpClass.mobile);
                #endregion

                intMobileCount = StatusUpClass.mobile.Split(',').Count();
                if (intMobileCount > 1)
                {
                    int intN = 0;
                    string strIn = string.Empty;
                    foreach (string item in StatusUpClass.mobile.Split(','))
                    {
                        SqlParameter parameter = new SqlParameter("@dd" + intN, SqlDbType.NVarChar, 50, item);
                        parameter.IsNullable = true;
                        parameter.Direction = ParameterDirection.Output;

                        sqlParm.Add("@dd" + intN, item, System.Data.DbType.String);
                        strIn += "@dd" + intN + ",";

                        intN++;
                    }
                    strWhere = string.Format(" And Mobile in ({0} ) ", strIn.TrimEnd(','));

                }
                else
                {
                    strWhere = " And Mobile=@Mobile ";
                }


                #region SQL 語法
                strQuery = @"UPDATE SMSCNStatus
                             SET [Status] =@Status
                             WHERE Sendid=@Sendid  {0} ";
                strQuery = string.Format(strQuery, strWhere);
                #endregion
                #region SQL 執行
                //using (SqlConnection conn = new SqlConnection(DBList.LionExAPI))
                //{
                //    intIsVaild = conn.Execute(strQuery, sqlParm);

                //}
                //if (intIsVaild == 0)
                //{
                //    //Proj.send_ErrorEmail("更新失敗", string.Format("<h4>SQLUpdate：</h4><ul><li>{0};</li></ul><h4>StatusUpClass：</h4><ul><li>{1}</li></ul>", strQuery, JsonConvert.SerializeObject(StatusUpClass)));

                //}

                #endregion
                RespBaseReturn.Data = intIsVaild.ToString();
                return RespBaseReturn;
            }
            catch (Exception ex)
            {
                RespBaseReturn.IsSuccess = false;
                RespBaseReturn.Data = null;
                RespBaseReturn.Msg = "API System error";
                //new Log().ErrorLog(strThisPageName + "/SmsStatusUp", ex.Message);
                #region 記錄LOG
                //SmsCNLogs LogData = new SmsCNLogs();
                //LogData.ActionData = strThisPageName + "/SmsStatusUp";
                //LogData.SourceJsonString = JsonConvert.SerializeObject(StatusUpClass);
                //LogData.ReturnJsonString = string.Format("SQLUpdate={0};RespBaseReturn={1}", strQuery, RespBaseReturn);
                //LogData.CreateDateTime = DateTime.Now;
                //LogData.MagData = ex.Message;
                //LogData.Sort = "1";
                //ProjectFun.FunAddLogData(LogData);
                #endregion
                return RespBaseReturn;
            }
        }


        
    }
}
