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

                //Load Model in to "Universal Variable"
                var country = countryCont.GetCountry(CountryIdQS);


                //Layout the Data
                MainTitle.InnerText = country.Name;
                //Load the Map (Had to use Literal as editing Iframe src caused errors due to Framework version???
                CountryMap.Text = @"<iframe id='CountryMap' runat='server' width='100%' height='450'
                            src='https://www.google.com/maps/embed/v1/place?q=" + country.Name + "&key=AIzaSyDHPO6bNG225SK_Jnohf4xQtC-1Ew4V-Ec'></iframe>";
                
                //Load the Popular Cities into the Repeater
                var citiesCont = new CityController();

                var CountryCities = citiesCont.GetCountryCities(country.Code);

                rptCities.DataSource = CountryCities;
                rptCities.DataBind();

    

            }
            catch (Exception exc) //Module failed to load
            {
                Exceptions.ProcessModuleLoadException(this, exc);
            }
        }
    }
}