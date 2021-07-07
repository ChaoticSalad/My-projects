using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;

namespace CountriesRestSql
{
    /// <summary>
    /// Class for Entity methods
    /// </summary>
    class EntityThings
    {
        /// <summary>
        /// Add or edit country in a database method
        /// </summary>
        /// <param name="foundCountry">Object to add or edit DB with</param>
        /// <returns>String if country added or edited in DB</returns>
        public static string AddCountryToDB(CountryClass foundCountry)
        {
            bool edited = false;
            using (var context = new CountriesDbContext())
            {
                City city;
                if (context.Cities.Any(cityName => cityName.Name == foundCountry.Capital))
                {
                    city = context.Cities.FirstOrDefault(cityName => cityName.Name == foundCountry.Capital);
                }
                else
                {
                    city = new City()
                    {
                        Name = foundCountry.Capital
                    };
                    context.Cities.Add(city);
                    context.SaveChanges();
                }

                Region region;
                if (context.Regions.Any(regionName => regionName.Name == foundCountry.Region))
                {
                    region = context.Regions.FirstOrDefault(regionName => regionName.Name == foundCountry.Region);
                }
                else
                {
                    region = new Region()
                    {
                        Name = foundCountry.Region
                    };
                    context.Regions.Add(region);
                    context.SaveChanges();
                }

                Country country;
                if (context.Countries.Any(countryCode => countryCode.Code == foundCountry.CallingCodes))
                {
                    country = context.Countries.FirstOrDefault(countryCode => countryCode.Code == foundCountry.CallingCodes);
                    country.Name = foundCountry.Name;
                    country.CityId = city.Id;
                    country.Area = foundCountry.Area;
                    country.Population = foundCountry.Population;
                    country.RegionId = region.Id;
                    edited = true;
                }
                else
                {
                    country = new Country()
                    {
                        Name = foundCountry.Name,
                        Code = foundCountry.CallingCodes,
                        CityId = city.Id,
                        Area = foundCountry.Area,
                        Population = foundCountry.Population,
                        RegionId = region.Id
                    };
                    context.Countries.Add(country);
                }

                context.SaveChanges();
            }
            if (edited)
                return "Country was edited in the DB";
            else
                return "Country was added to the DB";        
        }

        /// <summary>
        /// Populates datagridview in the main form
        /// </summary>
        /// <returns>List of three joined tables</returns>
        public static object PopulateDataGridView()
        {
            using (CountriesDbContext context = new CountriesDbContext())
            {
                return (from country in context.Countries
                        join city in context.Cities on country.CityId equals city.Id
                        join region in context.Regions on country.RegionId equals region.Id
                        select new
                        {
                            Name = country.Name,
                            Code = country.Code,
                            Capital = city.Name,
                            Area = country.Area,
                            Population = country.Population,
                            Region = region.Name
                        }).ToList();
            }
        }
    }
}
