using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectTestAPI.Models.DataModel
{
    public class TestXML
    {
        /// <summary>
        /// PK
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 建立日期
        /// </summary>
        public DateTime CreateDate { get; set; }
        /// <summary>
        /// 更新日期
        /// </summary>
        public DateTime UpdateDate { get; set; }
        /// <summary>
        /// 建立人員id
        /// </summary>
        public string CreateID { get; set; }
        /// <summary>
        /// 更新人員id
        /// </summary>
        public string UpdateID { get; set; }
        /// <summary>
        /// 建立人員姓名
        /// </summary>
        public string CreateName { get; set; }
        /// <summary>
        /// 更新人員姓名
        /// </summary>
        public string UpdateName { get; set; }
        /// <summary>
        /// 類別 1：iOS、2：Android、3：web
        /// </summary>
        public int? ParentId { get; set; }
        /// <summary>
        /// 使用系統名稱
        /// </summary>
        public string ApplicationName { get; set; }
        /// <summary>
        /// ApiKey值
        /// </summary>
        public string ApiKey { get; set; }
        /// <summary>
        /// ApiSecret值
        /// </summary>
        public string ApiSecret { get; set; }
        /// <summary>
        /// 使用ip位置
        /// </summary>
        public string AllowIPs { get; set; }
        //20150601 新增 專案Icon by 宛蒨
        /// <summary>
        /// 專案Icon
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string ApplicationIconUrl { get; set; }
        //20150601 傳入參數欄位 by 宛蒨
        /// <summary>
        /// Code
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Code { get; set; }
        //20150605 傳入參數欄位 by 宛蒨
        /// <summary>
        /// IP資料
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Ip { get; set; }
        //20150605 傳入參數欄位 by 宛蒨
        /// <summary>
        /// 是否覆蓋IP
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsAdd { get; set; }
    }
}