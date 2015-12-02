using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectTestAPI.Areas.v1.Models.DataModel
{
    public class GetTemplate
    {
        /// <summary>
        /// api Key
        /// </summary>
        public string apikey { get; set; }
        /// <summary>
        /// 接收的手机号
        /// </summary>
        public string mobile { get; set; }
        /// <summary>
        /// 短信内容
        /// </summary>
        public string text { get; set; }
    }
}