using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectTestAPI.Areas.v1.Models.DataModel
{
    public class Tour
    {
        public string LineID { get; set; }
        public string LineName { get; set; }
        public string TravelID { get; set; }
        public string TravelName { get; set; }
        public string WebAreaID { get; set; }
        public string WebAreaName { get; set; }
        public TraveItem TravelList { get; set; }
        public Tour() 
        {
            TravelList = new TraveItem();
        }
    }
    public class TraveItem 
    {
        public string TravelID { get; set; }
        public string TravelName { get; set; }
        public WebAreaItem WebAreaList { get; set; }
        public TraveItem() 
        {
            WebAreaList = new WebAreaItem();
        }
    }
    public class WebAreaItem 
    {
        public string WebAreaID { get; set; }
        public string WebAreaName { get; set; }
    }
}