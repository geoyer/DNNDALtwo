
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Christoc.Modules.DNNDAL2.Components;
namespace Christoc.Modules.DNNDAL2
{
    public partial class SearchResults : DNNDAL2ModuleBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var countryCont = new CountryController();
            string searchQuery = Request.QueryString["Query"];

           

            rptResults.DataSource = countryCont.SearchForCountries(searchQuery);
            rptResults.DataBind();
        }
    }
}