using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectTestAPI.Areas.v1.Models.DataModel
{
    public class Tpl
    {
        public int code { get; set; }
        public string msg { get; set; }
        public template template { get; set; }
        public Tpl() 
        {
            template = new template();
        }
    }
    public class template
    {
        /// <summary>
        /// 模板id
        /// </summary>
        public long tpl_id { get; set; }
        /// <summary>
        /// 模板內容
        /// </summary>
        public string tpl_content { get; set; }
        /// <summary>
        /// 審核狀態
        /// </summary>
        public string check_status { get; set; }
        /// <summary>
        /// 模板失敗原因
        /// </summary>
        public string reason { get; set; }
    }
}