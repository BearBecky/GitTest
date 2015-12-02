using ProjectTestAPI.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Dapper;
using ProjectTestAPI.Areas.v1.Models.DataModel;

namespace ProjectTestAPI.Areas.v1.Controllers
{
    public class TestTourController : ApiController
    {

        // GET: api/TestTour/5
        public Tour Get(string ToursType, string Country = "TW", int? LineLevel = 0, string BuType = "T", int ShowType = 1, string LineID = "", string TravelID = "", string WebAreaID = "", int PageStart = 0, int PageCount = 0)
        {
            string strLine = string.Empty;
            string strwhere = string.Empty;
            if (ToursType==TT.NEW.ToString())
            {
                strwhere = "and hspd10_line <> 9";
            }
            if (ToursType == TT.NEWDOM.ToString())
            {
                strwhere = "and hspd10_line=9";
            }


            DynamicParameters sqlParm = new DynamicParameters();
            sqlParm.Add("@Country", Country);
            sqlParm.Add("@BuType", BuType);
            string sqlQuery = @"select hspd10_line AS LineID,hspd10_line_nm AS LineName,hspd10_travel AS TravelID,hspd10_travel_nm AS TravelName,hspd10_webarea AS WebAreaID, hspd10_warea_nm AS WebAreaName  from [dbo].[hspdm10] where hspd10_bu=@BuType and hspd10_country=@Country {0} ";
            using (var conn = SQLFunc.OpenConnection(DBList.LionAction))
            {
                sqlQuery = string.Format(sqlQuery, strwhere);
                return conn.Query<Tour>(sqlQuery, sqlParm).FirstOrDefault();
            }



        }


    }
}
