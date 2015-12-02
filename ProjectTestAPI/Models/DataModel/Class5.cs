using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectTestAPI.Models.DataModel
{
    public class ssorm10
    {
        public decimal _OrerTotAmt = 0;

        /// <summary>
        /// 訂單年度
        /// </summary>
        public string OrerYear { get; set; }

        /// <summary>
        /// 訂單編號
        /// </summary>
        public int OrerOrdr { get; set; }

        /// <summary>
        /// 訂單明細序號
        /// </summary>
        public int OrerSeq { get; set; }

        /// <summary>
        /// 取消(預設0)
        /// </summary>
        public decimal OrerSts { get; set; }

        /// <summary>
        /// INB人數(預設1)
        /// </summary>
        public int OrerMax { get; set; }

        /// <summary>
        /// 不宜參團註記(空)
        /// </summary>
        public string OrerNmark { get; set; }

        /// <summary>
        /// 中文姓名
        /// </summary>
        public string OrerCname { get; set; }

        /// <summary>
        /// 性別
        /// </summary>
        public string OrerSex { get; set; }

        /// <summary>
        /// 身份證字號(空)
        /// </summary>
        public string OrerIdno { get; set; }

        /// <summary>
        /// 國籍別(空)
        /// </summary>
        public string OrerCountry { get; set; }

        /// <summary>
        /// 出生日期(空)
        /// </summary>
        public string OrerBdate { get; set; }

        /// <summary>
        /// 英文姓(空)
        /// </summary>
        public string OrerEnamel { get; set; }

        /// <summary>
        /// 英文名(空)
        /// </summary>
        public string OrerEname { get; set; }

        /// <summary>
        /// 稱謂
        /// </summary>
        public string OrerEtit { get; set; }

        /// <summary>
        /// 房型(空)
        /// </summary>
        public int OrerAct { get; set; }

        /// <summary>
        /// 佔床(空)
        /// </summary>
        public string OrerAmark { get; set; }

        /// <summary>
        /// 價格
        /// </summary>
        public string OrerPmark { get; set; }

        /// <summary>
        /// 加稅(空)
        /// </summary>
        public bool OerAddgst { get; set; }

        /// <summary>
        /// 總團費(含GST 不含退佣)
        /// </summary>
        public decimal OrerTotAmt { get { return _OrerTotAmt; } set { _OrerTotAmt = OrerAmt1 + OrerAmt2 + OrerAmt3 + OrerAmt4 + OrerAmt5 + OrerAmt6 + OrerAmt7 + OerGst - OrerKb1; } }

        /// <summary>
        /// 團費(空)
        /// </summary>
        public decimal OrerAmt1 { get; set; }

        /// <summary>
        /// 特別行程(空)
        /// </summary>
        public decimal OrerAmt2 { get; set; }

        /// <summary>
        /// 證照(空)
        /// </summary>
        public decimal OrerAmt3 { get; set; }

        /// <summary>
        /// 手續費機場稅(空)
        /// </summary>
        public decimal OrerAmt4 { get; set; }

        /// <summary>
        /// 產品部成本(空)
        /// </summary>
        public decimal OrerAmt5 { get; set; }

        /// <summary>
        /// Local團餐費(空)
        /// </summary>
        public decimal OrerAmt6 { get; set; }

        /// <summary>
        /// Local團自費活動節目費(空)
        /// </summary>
        public decimal OrerAmt7 { get; set; }

        /// <summary>
        /// GST稅額(空)
        /// </summary>
        public decimal OerGst { get; set; }

        /// <summary>
        /// 同業退佣金額
        /// </summary>
        public decimal OrerKb1 { get; set; }

        /// <summary>
        /// 團體分房(空)
        /// </summary>
        public int OrerRoom { get; set; }

        /// <summary>
        /// 房型(空)
        /// </summary>
        public string OrerRoomDesc { get; set; }

        /// <summary>
        /// 資料異動(最後)時間(空)
        /// </summary>
        public DateTime OrerChgnamedate { get; set; }

     

       
    }
}