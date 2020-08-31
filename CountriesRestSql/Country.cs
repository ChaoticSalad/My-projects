using System;
using System.Collections.Generic;

namespace CountriesRestSql
{
    
    public partial class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Code { get; set; }
        public int CityId { get; set; }
        public double Area { get; set; }
        public int Population { get; set; }
        public int RegionId { get; set; }
    }
}
