using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountriesRestSql
{
    /// <summary>
    /// Class to work with API
    /// </summary>
    class RestClient
    {
        string find;
        public RestClient(string find)
        {
            this.find = find;
        }
        /// <summary>
        /// Search for a json list of a country, take first result and deserialize into CountryClass's object
        /// </summary>
        /// <param name="country">Object to deserialize into</param>
        /// <returns>Exception or nothing</returns>
        public string JsonCountry(ref CountryClass country)
        {
            string sReadData = String.Empty;
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://restcountries.eu/rest/v2/name/" + find);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream stream = response.GetResponseStream();
                StreamReader sr = new StreamReader(stream);
                sReadData = sr.ReadToEnd();
                response.Close();
                stream.Close();
                sr.Close();
            }
            catch(Exception ex)
            {
                return ex.ToString();
            }

            List<dynamic> countries = JsonConvert.DeserializeObject<List<dynamic>>(sReadData);

            country = new CountryClass(
                Convert.ToString(countries[0].name),
                Convert.ToInt32(countries[0].callingCodes[0]),
                Convert.ToString(countries[0].capital),
                Convert.ToDouble(countries[0].area),
                Convert.ToInt32(countries[0].population),
                Convert.ToString(countries[0].region)
                );

            return String.Empty;
        }
    }
}
