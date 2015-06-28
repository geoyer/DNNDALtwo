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
                LoadCountries("Name", true);
            }
            catch (Exception exc) //Module failed to load
            {
                Exceptions.ProcessModuleLoadException(this, exc);
            }
        }

        protected void ddlCountrySort_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void LoadCountries(string sortValue, bool LowestFirst)
        {
            //New "Countries" Code by AB
            var countryCont = new CountryController();
            rptItemList.DataSource = countryCont.GetCountriesSorted(sortValue, LowestFirst);
            rptItemList.DataBind();
        }

        protected void btnSort_Click(object sender, EventArgs e)
        {
            LoadCountries(ddlCountrySort.SelectedValue, Convert.ToBoolean(ddlCountrySortDirection.SelectedValue));
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            Response.Redirect(DotNetNuke.Entities.Tabs.TabController.CurrentPage.FullUrl + "/cid/Search/Query/" + txtSearch.Text);
        }


    }
}