using System;
using System.Collections.Generic;
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

        public IEnumerable<Country> GetCountriesSorted(string SortByColumn, bool LowestFirst)
        {
            IEnumerable<Country> countries;
            using (IDataContext ctx = DataContext.Instance())
            {

                var rep = ctx.GetRepository<Country>();

                //Creates an object which is conditionally set by the string that is passed... It is later used to sort in a "OrderBy" LINQ Query
                Func<Country, Object> orderByFunc = null;


                //Define the columns that can be selected for sorting
                if (SortByColumn == "Name")
                {
                    orderByFunc = t => t.Name;
                }
                else if (SortByColumn == "Population")
                {
                    orderByFunc = t => t.Population;
                }

                //Define the direcion the columns will be sorted

                if (LowestFirst == true)
                {
                    countries = rep.Get().OrderBy(orderByFunc);
                }
                else //High To Low
                {
                    countries = rep.Get().OrderByDescending(orderByFunc);
                }
                



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