using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectTestAPI.Models.ViewModel
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(ElementName = "SEARCHLIST", Namespace = "SEARCHLIST", IsNullable = false)]
    public partial class SEARCHLIST
    {

        private uint aGENTField;

        private string aPIKEYField;

        private string dEPCITYField;

        private string aRRCITYField;

        private System.DateTime dEPDATEField;

        private System.DateTime rTNDATEField;

        private byte rOOMSField;

        private byte aDULTField;

        private SEARCHLISTCHILDREN cHILDRENField;

        private uint hOTELIDSField;

        private System.DateTime cHKINDATEField;

        private System.DateTime cHKOUTDATEField;

        private object sEARCHIDField;

        /// <remarks/>
        public uint AGENT
        {
            get
            {
                return this.aGENTField;
            }
            set
            {
                this.aGENTField = value;
            }
        }

        /// <remarks/>
        public string APIKEY
        {
            get
            {
                return this.aPIKEYField;
            }
            set
            {
                this.aPIKEYField = value;
            }
        }

        /// <remarks/>
        public string DEPCITY
        {
            get
            {
                return this.dEPCITYField;
            }
            set
            {
                this.dEPCITYField = value;
            }
        }

        /// <remarks/>
        public string ARRCITY
        {
            get
            {
                return this.aRRCITYField;
            }
            set
            {
                this.aRRCITYField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime DEPDATE
        {
            get
            {
                return this.dEPDATEField;
            }
            set
            {
                this.dEPDATEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime RTNDATE
        {
            get
            {
                return this.rTNDATEField;
            }
            set
            {
                this.rTNDATEField = value;
            }
        }

        /// <remarks/>
        public byte ROOMS
        {
            get
            {
                return this.rOOMSField;
            }
            set
            {
                this.rOOMSField = value;
            }
        }

        /// <remarks/>
        public byte ADULT
        {
            get
            {
                return this.aDULTField;
            }
            set
            {
                this.aDULTField = value;
            }
        }

        /// <remarks/>
        public SEARCHLISTCHILDREN CHILDREN
        {
            get
            {
                return this.cHILDRENField;
            }
            set
            {
                this.cHILDRENField = value;
            }
        }

        /// <remarks/>
        public uint HOTELIDS
        {
            get
            {
                return this.hOTELIDSField;
            }
            set
            {
                this.hOTELIDSField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime CHKINDATE
        {
            get
            {
                return this.cHKINDATEField;
            }
            set
            {
                this.cHKINDATEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime CHKOUTDATE
        {
            get
            {
                return this.cHKOUTDATEField;
            }
            set
            {
                this.cHKOUTDATEField = value;
            }
        }

        /// <remarks/>
        public object SEARCHID
        {
            get
            {
                return this.sEARCHIDField;
            }
            set
            {
                this.sEARCHIDField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class SEARCHLISTCHILDREN
    {

        private byte cHILDField;

        private SEARCHLISTCHILDRENAGES aGESField;

        /// <remarks/>
        public byte CHILD
        {
            get
            {
                return this.cHILDField;
            }
            set
            {
                this.cHILDField = value;
            }
        }

        /// <remarks/>
        public SEARCHLISTCHILDRENAGES AGES
        {
            get
            {
                return this.aGESField;
            }
            set
            {
                this.aGESField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class SEARCHLISTCHILDRENAGES
    {

        private byte aGEField;

        /// <remarks/>
        public byte AGE
        {
            get
            {
                return this.aGEField;
            }
            set
            {
                this.aGEField = value;
            }
        }
    }

}