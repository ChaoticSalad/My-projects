using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Currency
{
    [Serializable, XmlRoot("ValCurs")]
    public class ValCurs
    {
        [XmlAttribute]
        public string Date { get; set; }
        [XmlAttribute]
        public string name;
        [XmlElement("Valute")]
        public List<Valute> Valute { get; set; }
    }
}
