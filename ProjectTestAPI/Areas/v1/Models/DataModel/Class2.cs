using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectTestAPI.Areas.v1.Models.DataModel
{
    public class Tourelements
    {
        /// <summary>
        /// 團號
        /// </summary>
        public string group_sn { get; set; }
        /// <summary>
        /// 產品出發日期
        /// </summary>
        public string godate { get; set; }
        /// <summary>
        /// 大人人數
        /// </summary>
        public int adultcount { get; set; }
        /// <summary>
        /// 小孩佔床人數
        /// </summary>
        public int childcount { get; set; }
        /// <summary>
        /// 小孩不佔床人數
        /// </summary>
        public int childnocount { get; set; }
        /// <summary>
        /// 小孩加床人數
        /// </summary>
        public int addcount { get; set; }
        /// <summary>
        /// 嬰兒人數
        /// </summary>
        public int babycount { get; set; }
        /// <summary>
        /// 總報名人數
        /// </summary>
        public int allcount { get; set; }
    }
}