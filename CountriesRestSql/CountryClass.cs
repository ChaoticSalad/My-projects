using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountriesRestSql
{
    /// <summary>
    /// Class to make object out of user's search
    /// </summary>
    class CountryClass
    {
        string name;
        int callingCodes;
        string capital;
        double area;
        int population;
        string region;

        public CountryClass(string name, int callingCodes, string capital, double area, int population, string region)
        {
            this.name = name;
            this.callingCodes = callingCodes;
            this.capital = capital;
            this.area = area;
            this.population = population;
            this.region = region;
        }
        public string Name { get { return name; } }
        public int CallingCodes { get { return callingCodes; } }
        public string Capital { get { return capital; } }
        public double Area { get { return area; } }
        public int Population { get { return population; } }
        public string Region { get { return region; } }
    }
}
