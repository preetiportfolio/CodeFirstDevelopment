using CodeFirstDevelopment.Models;
using CodeFirstDevelopment.Models.Address;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirstDevelopment.Data
{
    public class DummyData
    {
        public static System.Collections.Generic.List<Province> getProvinces()
        {
            List<Province> provinces = new List<Province>()
            {
                new Province() {
                    ProvinceCode = "AB",
                    ProvinceName = "Alberta",
                    },
               new Province() {
                    ProvinceCode = "BC",
                    ProvinceName = "British Columbia",
                    },
                new Province() {
                    ProvinceCode = "ON",
                    ProvinceName = "Ontario",
                    },
                new Province() {
                    ProvinceCode = "MB",
                    ProvinceName = "Manitaba",
                    },
            };

            return provinces;
        }

        public static List<City> getCities(ApplicationDbContext context)
        {
            List<City> cities = new List<City>() {
                new City {
                    CityName = "Vancouver",
                    Population = 100000,
                    ProvinceCode = context.Provinces.Find("BC").ProvinceCode,
                    },
                new City {
                    CityName = "Toronto",
                    Population = 200000,
                    ProvinceCode = context.Provinces.Find("ON").ProvinceCode,
                    },
                new City {
                    CityName = "WinninPeg",
                    Population = 300000,
                    ProvinceCode = context.Provinces.Find("MB").ProvinceCode,
                    },
                new City {
                    CityName = "Victoria",
                    Population = 400000,
                    ProvinceCode = context.Provinces.Find("BC").ProvinceCode,
                    },
            };

            return cities;
        }
    }
}