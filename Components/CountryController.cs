using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//Required Additions to Base class;
using DotNetNuke.Data;

//Required for Complex LINQ commands on Model
using System.Linq;

namespace Christoc.Modules.DNNDAL2.Components
{
    public class CountryController
    {

        public IEnumerable<Country> GetCountries()
        {
            IEnumerable<Country> countries;
            using (IDataContext ctx = DataContext.Instance())
            {
                var rep = ctx.GetRepository<Country>();
                countries = rep.Get().OrderBy(t => t.Name);
            }
            return countries;
        }

        public Country GetCountry(string countryID)
        {
            Country country;

            using (IDataContext ctx = DataContext.Instance())
            {
                var rep = ctx.GetRepository<Country>();
                country = rep.GetById(countryID);
            }

            return country;

        }
    }
}