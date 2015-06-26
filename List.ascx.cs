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
                var tc = new ItemController();
                rptItemList.DataSource = tc.GetCountries();
                rptItemList.DataBind();
            }
            catch (Exception exc) //Module failed to load
            {
                Exceptions.ProcessModuleLoadException(this, exc);
            }
        }


        protected void rptItemListOnItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            //if (e.Item.ItemType == ListItemType.AlternatingItem || e.Item.ItemType == ListItemType.Item)
            //{
            //    var lnkEdit = e.Item.FindControl("lnkEdit") as HyperLink;
            //    var lnkDelete = e.Item.FindControl("lnkDelete") as LinkButton;

            //    var pnlAdminControls = e.Item.FindControl("pnlAdmin") as Panel;

            //    var t = (Item)e.Item.DataItem;

            //    if (IsEditable && lnkDelete != null && lnkEdit != null && pnlAdminControls != null)
            //    {
            //        pnlAdminControls.Visible = true;
            //        lnkDelete.CommandArgument = t.ItemId.ToString();
            //        lnkDelete.Enabled = lnkDelete.Visible = lnkEdit.Enabled = lnkEdit.Visible = true;

            //        lnkEdit.NavigateUrl = EditUrl(string.Empty, string.Empty, "Edit", "tid=" + t.ItemId);

            //        ClientAPI.AddButtonConfirm(lnkDelete, Localization.GetString("ConfirmDelete", LocalResourceFile));
            //    }
            //    else
            //    {
            //        pnlAdminControls.Visible = false;
            //    }
            //}
        }


        public void rptItemListOnItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "Edit")
            {
                Response.Redirect(EditUrl(string.Empty, string.Empty, "Edit", "tid=" + e.CommandArgument));
            }

            if (e.CommandName == "Delete")
            {
                var tc = new ItemController();
                tc.DeleteItem(Convert.ToInt32(e.CommandArgument), ModuleId);
            }
            Response.Redirect(DotNetNuke.Common.Globals.NavigateURL());
        }

        public ModuleActionCollection ModuleActions
        {
            get
            {
                var actions = new ModuleActionCollection
                    {
                        {
                            GetNextActionID(), Localization.GetString("EditModule", LocalResourceFile), "", "", "",
                            EditUrl(), false, SecurityAccessLevel.Edit, true, false
                        }
                    };
                return actions;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect(DotNetNuke.Common.Globals.NavigateURL("", String.Format("cid={0}&tid={1}", "Details", this.TabId)));
        }
    }
}