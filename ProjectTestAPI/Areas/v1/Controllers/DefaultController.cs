using ProjectTestAPI.Areas.V1.Models.DataModel;
using ProjectTestAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Dapper;
using System.Data;
using System.Transactions;
using ProjectTestAPI.Utility;
using ProjectTestAPI.Models.DataModel;
using System.Xml;
using Newtonsoft.Json;
using System.IO;

namespace ProjectTestAPI.Areas.V1.Controllers
{
    public class DefaultController : ApiController
    {
        //呼叫外接API Get
        public ResponseBase<Data> Get(string UserId, string EncodePassword, string Search, string StartRow, string EndRow)
        {
            ResponseBase<Data> ReturnResult = new ResponseBase<Data>();
            ReturnResult = new Class1().aa(UserId, EncodePassword, Search, StartRow, EndRow);
            return ReturnResult;
        }

        //用int 參數 串入 where in(DynamicParameters 方式用)
        public string Get(int d)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DBList.LionExAPIDB))
                {
                    string strIn = string.Empty;
                    string dd = "1,2,3";

                    DynamicParameters sqlParam = new DynamicParameters();
                    int intN = 0;

                    foreach (string item in dd.Split(','))
                    {
                        SqlParameter parameter = new SqlParameter("@dd" + intN, SqlDbType.Int, 50, item);
                        parameter.IsNullable = true;
                        parameter.Direction = ParameterDirection.Output;

                        sqlParam.Add("@dd" + intN, item, System.Data.DbType.Int32);
                        strIn += "@dd" + intN + ",";

                        intN++;
                    }

                    string strQuery = string.Format("select createname from [dbo].[Application] where id in ({0});", strIn.TrimEnd(','));
                    string s = conn.Query<string>(strQuery, sqlParam).FirstOrDefault();
                    return "OK";
                }
            }
            catch (Exception e)
            { }
            return "error";
        }
        //用int 參數 串入 where in(SqlCommand 方式用)
        public string GetCommand(int d)
        {
            CommittableTransaction ct = new CommittableTransaction();
            string outString = string.Empty;
            try
            {
                SqlCommand cmd = new SqlCommand();
                //加入 System.Transactions.dll, v4.0.0.0 參考

                string strQuery = string.Empty;
                string strIn = string.Empty;




                #region SQL 執行
                using (var con = SQLFunc.OpenConnection(DBList.LionExAPIDB))
                {

                    string dd = "1,2,3";


                    con.EnlistTransaction(ct);
                    cmd.Connection = con;
                    List<string> list = new List<string>();
                    int intN = 0;

                    foreach (string item in dd.Split(','))
                    {
                        //SqlParameter parameter = new SqlParameter("@dd" + intN, SqlDbType.Int, 50, item);
                        //parameter.IsNullable = true;
                        //parameter.Direction = ParameterDirection.Output;



                        //cmd.Parameters.Add("@dd" + intN, System.Data.DbType.Int32).Value = item;

                        strIn += "@dd" + intN;
                        cmd.Parameters.Add(strIn, SqlDbType.Int).Value = item;
                        list.Add(item);

                        intN++;
                    }
                    strQuery = string.Format("select createname from [dbo].[Application] where id in ({0});", string.Join(",", list.ToArray()));
                    cmd.CommandText = strQuery;
                    var Data = cmd.ExecuteReader();

                    while ((Data.Read()))
                    {
                        //5.判斷資料列是否為空
                        if (!Data[0].Equals(DBNull.Value))
                        {
                            outString = Data[0].ToString();
                        }
                    }

                }
                #endregion



                ct.Commit();

            }
            catch (Exception e)
            { ct.Rollback(); }
            return outString;

        }

        public string GetList(string T)
        {
            string xml = @"<?xml version='1.0' standalone='no'?><root><person id='1'><name>Alan</name><url>http://www.google.com</url></person>" +
                          "<person id='2'><name>Louis</name><url>http://www.yahoo.com</url></person></root>";
            XmlDocument xDoc = new XmlDocument();
            xDoc.LoadXml(xml);
            string json = JsonConvert.SerializeXmlNode(xDoc);

            return json;
        }
        public string GetDetail() 
        {
            DBInserOrder DBInserOrder = new DBInserOrder();
           // DBInserOrder.ssorm10.Any()
            
         
            return "";
        }
    }
}
