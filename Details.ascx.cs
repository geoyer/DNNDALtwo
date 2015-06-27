using Christoc.Modules.DNNDAL2.Components;
using DotNetNuke.Services.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Christoc.Modules.DNNDAL2
{
    public partial class Details : DNNDAL2ModuleBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                var countryCont = new CountryController();

                string CountryIdQS = Request.QueryString["CountryID"];

                Label1.Text = countryCont.GetCountry(CountryIdQS).Name;
            }
            catch (Exception exc) //Module failed to load
            {
                Exceptions.ProcessModuleLoadException(this, exc);
            }
        }
    }
}