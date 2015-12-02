using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sms.CN.ExAPI.Areas.V1.Models.DataModel
{
    public class TplStatus
    {
        /// <summary>
        /// 短信id
        /// </summary>
        public long sid { get; set; }
        /// <summary>
        /// 用户自定义id
        /// </summary>
        public string uid { get; set; }
        /// <summary>
        /// 用户接受时间
        /// </summary>
        public DateTime ? user_receive_time { get; set; }
        /// <summary>
        /// 运营商返回的代码
        /// </summary>
        public string error_msg { get; set; }
        /// <summary>
        /// 接受手机号
        /// </summary>
        public string mobile { get; set; }
        /// <summary>
        /// 接收状态有:SUCCESS/FAIL
        /// </summary>
        public string report_status { get; set; }
    }
}