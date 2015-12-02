using ProjectTestAPI.Areas.v1.Models.DataModel;
using ProjectTestAPI.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.OData;
using Dapper;
using System.Web.Http.OData.Query;
using System.Web.Http.OData.Builder;

namespace ProjectTestAPI.Areas.v1.Controllers
{
    public class TestODataController : ApiController
    {
        [Queryable]
        public IEnumerable<Product> GetAllProducts()
        {
            string sqlExecute = string.Empty;
            List<Product> ProductList = new List<Product>();
            try
            {
                #region SQL 語法

                sqlExecute = @"select * from Product ";

                #endregion SQL 語法

                #region SQL 執行
                using (var conn = SQLFunc.OpenConnection(DBList.Test))
                {
                   ProductList= conn.Query<Product>(sqlExecute).ToList();
                }
                var builder = new ODataConventionModelBuilder() { Namespace = "Default" };
                builder.EntitySet<Product>("Products");
                var model = builder.GetEdmModel();
                return ProductList.AsQueryable();
               
                #endregion
            }
            catch (Exception ex)
            {
            
            }
            return ProductList.AsQueryable();
           
        }



    }
}
