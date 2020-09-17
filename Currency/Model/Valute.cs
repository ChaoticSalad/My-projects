using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Currency
{
    public class Valute
    {
        private double valueCur;
        [XmlAttribute]
        public string ID { get; set; }
        
        [XmlElement("NumCode")]
        public string NumCode { get; set; }
        
        [XmlElement("CharCode")]
        public string CharCode { get; set; }
        
        [XmlElement("Nominal")]
        public double Nominal { get; set; }
        
        [XmlElement("Name")]
        public string Name { get; set; }

        [XmlElement("Value")]
        public string ValueCur { 
            get { return Convert.ToString(valueCur); } 
            set { valueCur = Convert.ToDouble(value.Replace(',', '.')); } 
        }
    }
}
