using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirstDevelopment.Models.Address
{
    public class City
    {
        public int CityId { get; set; }
        public string CityName { get; set; }
        public int Population { get; set; }
        
        public string ProvinceCode { get; set; }
        public Province Province { get; set; }
    }
}