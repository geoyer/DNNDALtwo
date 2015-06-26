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
                var tc = new ItemController();

                int cityIdQS = Convert.ToInt32(Request.QueryString["cityID"]);

                Label1.Text = tc.GetCity(cityIdQS).Name;

                Label2.Text = tc.GetCity(cityIdQS).Population.ToString();
                
                //rptItemList.DataSource = tc.GetCity(cityIdQS);
                //rptItemList.DataBind();
            }
            catch (Exception exc) //Module failed to load
            {
                Exceptions.ProcessModuleLoadException(this, exc);
            }
        }
    }
}