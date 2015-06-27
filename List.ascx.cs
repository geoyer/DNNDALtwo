using System;
using System.Web.UI.WebControls;
using Christoc.Modules.DNNDAL2.Components;
using DotNetNuke.Security;
using DotNetNuke.Services.Exceptions;
using DotNetNuke.Entities.Modules;
using DotNetNuke.Entities.Modules.Actions;
using DotNetNuke.Services.Localization;
using DotNetNuke.UI.Utilities;

namespace Christoc.Modules.DNNDAL2
{
    public partial class List : DNNDAL2ModuleBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                //New "Countries" Code by AB
                var countryCont = new CountryController();
                rptItemList.DataSource = countryCont.GetCountries();
                rptItemList.DataBind();

                //string CountryID = "AFG";
                Literal1.Text = countryCont.GetCountry("AFG").Name;

            }
            catch (Exception exc) //Module failed to load
            {
                Exceptions.ProcessModuleLoadException(this, exc);
            }
        }


       


        

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect(DotNetNuke.Common.Globals.NavigateURL("", String.Format("cid={0}&tid={1}", "Details", this.TabId)));
        }
    }
}