using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectTestAPI.Areas.v1.Models.DataModel
{
    public class TemplateApprove
    {
        /// <summary>
        /// 接收信息验证的用户名（不是账户名），是按照用户要求配置的名称，可以为空
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 接收信息服务需验证的密码，可以为空
        /// </summary>
        public string pwd { get; set; }
        /// <summary>
        /// 模板编号
        /// </summary>
        public string tid { get; set; }
        /// <summary>
        /// 只有1和2 两种情况
        ///1审核通过
        ///2驳回
        /// </summary>
        public string state { get; set; }
        /// <summary>
        /// 消息：驳回的原因；有可能为空
        /// </summary>
        public string msg { get; set; }
    }
}