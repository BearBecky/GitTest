using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectTestAPI.Models
{
    public class ResponseBase<T>
    {
        public bool IsSuccess { get; set; }
        public String Msg { get; set; }
        /// <summary>
        /// 計算總筆數
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }
        public T Data { get; set; }
    }
}