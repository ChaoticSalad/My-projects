using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Currency
{
    class XmlCurrency
    {
        /// <summary>
        /// Making request and getting response from the site
        /// </summary>
        /// <returns>Http response</returns>
        public static HttpWebResponse DowloadCurrencyXML()
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(@"http://www.cbr.ru/scripts/XML_daily.asp");
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                return response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Getting xml string from HttpResponse and deserializing it in the list of objects
        /// </summary>
        /// <returns>Valutes' list</returns>
        public static ValCurs DeserializeList()
        {
            ValCurs result;
            string sReadData = String.Empty;

            //Getting response from url
            using (HttpWebResponse response = DowloadCurrencyXML())
            {
                using (Stream stream = response.GetResponseStream())
                {
                    using (StreamReader sr = new StreamReader(stream))
                    {
                        sReadData = sr.ReadToEnd();

                        XmlSerializer serializer = new XmlSerializer(typeof(ValCurs));

                        using (TextReader reader = new StringReader(sReadData))
                        {
                            result = (ValCurs)serializer.Deserialize(reader);
                        }
                    }
                }
            }
            return result;
        }
    }
}
