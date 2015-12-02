using System.Web.Configuration;

namespace ProjectTestAPI.Utility
{
    /// <summary>資料庫連線</summary>
    /// <remarks>
    /// DBList 連線請務必與 __connectionStrings.config 對應。
    /// </remarks>
    public class DBList
    {
        #region Property

        public static readonly string LionExAPIDB = WebConfigurationManager.ConnectionStrings["LionExAPIDB"].ConnectionString;

        public static readonly string Test = WebConfigurationManager.ConnectionStrings["Test"].ConnectionString;
        //LionTravel
        public static readonly string LionAction = WebConfigurationManager.ConnectionStrings["LionAction"].ConnectionString;
        

        #endregion Property
    }
}