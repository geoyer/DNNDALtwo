using DotNetNuke.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Christoc.Modules.DNNDAL2.Components
{
    public class CityController
    {

        public IEnumerable<City> GetAllCities()
        {
            IEnumerable<City> cities;
            using (IDataContext ctx = DataContext.Instance())
            {
                var rep = ctx.GetRepository<City>();
                cities = rep.Get();
            }
            return cities;
        }

        public IEnumerable<City> GetCountryCities(string CountryCode)
        {
            IEnumerable<City> cities;
            using (IDataContext ctx = DataContext.Instance())
            {
                var rep = ctx.GetRepository<City>();
                cities = rep.Get()
                        .Where(x => x.CountryCode == CountryCode);
            }
            return cities;
        }

        public City GetCity(string cityID)
        {
            City city;

            using (IDataContext ctx = DataContext.Instance())
            {
                var rep = ctx.GetRepository<City>();
                city = rep.GetById(cityID);
            }

            return city;

        }
    }
}