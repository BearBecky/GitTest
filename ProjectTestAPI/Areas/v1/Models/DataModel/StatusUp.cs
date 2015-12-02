using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sms.CN.ExAPI.Areas.V1.Models.DataModel
{
    public class StatusUp
    {
        /// <summary>
        /// 接收状态报告验证的用户名
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 接收状态报告验证的密码
        /// </summary>
        public string pwd { get; set; }
        /// <summary>
        /// 提交短信时平台返回的sendid
        /// </summary>
        public string sendid { get; set; }
        /// <summary>
        /// 报告时间（多个号码时，是第一个号码的时间）
        /// </summary>
        public DateTime? time { get; set; }
        /// <summary>
        /// 当多个号码状态相同时 手机号以英文逗号隔开；不同时 为单个手机号码
        /// </summary>
        public string mobile { get; set; }
        /// <summary>
        /// 状态报告数值
        /// </summary>
        public string state { get; set; }

    }
}