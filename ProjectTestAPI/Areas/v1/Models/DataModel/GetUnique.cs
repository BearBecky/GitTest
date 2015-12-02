using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectTestAPI.Areas.v1.Models.DataModel
{
    public class GetUnique
    {
        /// <summary>
        /// 账号
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 接口密码
        /// </summary>
        public string pwd { get; set; }
        /// <summary>
        /// 发送内容
        /// </summary>
        public string content { get; set; }
        /// <summary>
        /// 手机号码
        /// </summary>
        public string mobile { get; set; }
        /// <summary>
        /// 发送时间
        /// </summary>
        public string stime { get; set; }
        /// <summary>
        /// 用户签名
        /// </summary>
        public string sign { get; set; }
        /// <summary>
        /// 固定值 pt
        /// </summary>
        public string type { get; set; }
        /// <summary>
        /// 扩展码
        /// </summary>
        public string extno { get; set; }

    }
}