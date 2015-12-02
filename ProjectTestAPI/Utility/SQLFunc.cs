using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ProjectTestAPI.Utility
{
    public class SQLFunc
    {
        /// <summary>指定包含連接字串的字串時，初始化 System.Data.SqlClient.SqlConnection 類別的新執行個體，並開啟資料庫連接。</summary>
        /// <param name="connectionString">用來開啟 SQL Server 資料庫的連接。</param>
        /// <returns></returns>
        public static SqlConnection OpenConnection(string connectionString)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            return connection;
        }

        #region 開始交易 StartTransaction

        /// <summary>開始交易</summary>
        /// <param name="connStr"></param>
        /// <param name="tran"></param>
        /// <returns></returns>
        public static int StartTransaction(string connStr, Func<SqlTransaction, int> tran)
        {
            int result = 0;
            using (SqlConnection conn = OpenConnection(connStr))
            using (SqlTransaction transaction = conn.BeginTransaction())
            {
                try
                {
                    result = tran.Invoke(transaction);
                }
                catch
                {
                    result = -1;
                }
                if (result > 0)
                {
                    transaction.Commit();
                }
                else
                {
                    transaction.Rollback();
                }
            }
            return result;
        }

        #endregion

    }
}