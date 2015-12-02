using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectTestAPI.Areas.v1.Models.DataModel
{

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "BUDGETHOLIDAY", IsNullable = false)]
    public partial class BUDGETHOLIDAY
    {

        private string dEPARTAIRPORTField;

        private string aRRIVEAIRPORTField;

        private BUDGETHOLIDAYCITY[] cITIESField;

        /// <remarks/>
        public string DEPARTAIRPORT
        {
            get
            {
                return this.dEPARTAIRPORTField;
            }
            set
            {
                this.dEPARTAIRPORTField = value;
            }
        }

        /// <remarks/>
        public string ARRIVEAIRPORT
        {
            get
            {
                return this.aRRIVEAIRPORTField;
            }
            set
            {
                this.aRRIVEAIRPORTField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("CITY", IsNullable = false)]
        public BUDGETHOLIDAYCITY[] CITIES
        {
            get
            {
                return this.cITIESField;
            }
            set
            {
                this.cITIESField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class BUDGETHOLIDAYCITY
    {

        private BUDGETHOLIDAYCITYAREA[] aREASField;

        private string nAMEField;

        private string tRANSLATEDField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("AREA", IsNullable = false)]
        public BUDGETHOLIDAYCITYAREA[] AREAS
        {
            get
            {
                return this.aREASField;
            }
            set
            {
                this.aREASField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NAME
        {
            get
            {
                return this.nAMEField;
            }
            set
            {
                this.nAMEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TRANSLATED
        {
            get
            {
                return this.tRANSLATEDField;
            }
            set
            {
                this.tRANSLATEDField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class BUDGETHOLIDAYCITYAREA
    {

        private BUDGETHOLIDAYCITYAREAHOTEL[] hOTELSField;

        private string nAMEField;

        private string tRANSLATEDField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("HOTEL", IsNullable = false)]
        public BUDGETHOLIDAYCITYAREAHOTEL[] HOTELS
        {
            get
            {
                return this.hOTELSField;
            }
            set
            {
                this.hOTELSField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NAME
        {
            get
            {
                return this.nAMEField;
            }
            set
            {
                this.nAMEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TRANSLATED
        {
            get
            {
                return this.tRANSLATEDField;
            }
            set
            {
                this.tRANSLATEDField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class BUDGETHOLIDAYCITYAREAHOTEL
    {

        private uint hOTELIDField;

        private ushort rATEField;

        private string hOTELNAMEField;

        private string tRANSLATEDNAMEField;

        private decimal sTARRATINGField;

        private decimal rATINGAVERAGEField;

        private string eNGLISHADDRESSField;

        private string lOCALADDRESSField;

        private string oVERVIEWField;

        private decimal lONGITUDEField;

        private decimal lATITUDEField;

        private string pICTUREField;

        /// <remarks/>
        public uint HOTELID
        {
            get
            {
                return this.hOTELIDField;
            }
            set
            {
                this.hOTELIDField = value;
            }
        }

        /// <remarks/>
        public ushort RATE
        {
            get
            {
                return this.rATEField;
            }
            set
            {
                this.rATEField = value;
            }
        }

        /// <remarks/>
        public string HOTELNAME
        {
            get
            {
                return this.hOTELNAMEField;
            }
            set
            {
                this.hOTELNAMEField = value;
            }
        }

        /// <remarks/>
        public string TRANSLATEDNAME
        {
            get
            {
                return this.tRANSLATEDNAMEField;
            }
            set
            {
                this.tRANSLATEDNAMEField = value;
            }
        }

        /// <remarks/>
        public decimal STARRATING
        {
            get
            {
                return this.sTARRATINGField;
            }
            set
            {
                this.sTARRATINGField = value;
            }
        }

        /// <remarks/>
        public decimal RATINGAVERAGE
        {
            get
            {
                return this.rATINGAVERAGEField;
            }
            set
            {
                this.rATINGAVERAGEField = value;
            }
        }

        /// <remarks/>
        public string ENGLISHADDRESS
        {
            get
            {
                return this.eNGLISHADDRESSField;
            }
            set
            {
                this.eNGLISHADDRESSField = value;
            }
        }

        /// <remarks/>
        public string LOCALADDRESS
        {
            get
            {
                return this.lOCALADDRESSField;
            }
            set
            {
                this.lOCALADDRESSField = value;
            }
        }

        /// <remarks/>
        public string OVERVIEW
        {
            get
            {
                return this.oVERVIEWField;
            }
            set
            {
                this.oVERVIEWField = value;
            }
        }

        /// <remarks/>
        public decimal LONGITUDE
        {
            get
            {
                return this.lONGITUDEField;
            }
            set
            {
                this.lONGITUDEField = value;
            }
        }

        /// <remarks/>
        public decimal LATITUDE
        {
            get
            {
                return this.lATITUDEField;
            }
            set
            {
                this.lATITUDEField = value;
            }
        }

        /// <remarks/>
        public string PICTURE
        {
            get
            {
                return this.pICTUREField;
            }
            set
            {
                this.pICTUREField = value;
            }
        }
    }


}