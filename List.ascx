<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="List.ascx.cs" Inherits="Christoc.Modules.DNNDAL2.List" %>

<%--Added To Allow Stylesheet of Flags to be added--%>
<%@ Register TagPrefix="dnn" Namespace="DotNetNuke.Web.Client.ClientResourceManagement" Assembly="DotNetNuke.Web.Client" %>
<dnn:DnnCssInclude runat="server" FilePath="~/DesktopModules/DNNDAL2/Resources/Flags/css/flag-icon.min.css" />



<h1>Listing Page</h1>

<link href="Resources/Flags/css/flag-icon.min.css" rel="stylesheet" />




<asp:Literal ID="Literal1" runat="server"></asp:Literal>


<hr />
<asp:Repeater ID="rptItemList" runat="server">
    <HeaderTemplate>
        <div class="row">
    </HeaderTemplate>

    <ItemTemplate>
        <div class="col-md-3">

            <a href="/Modules/cid/Details/CountryID/<%#DataBinder.Eval(Container.DataItem,"Code").ToString() %>">
            <div style="width:100%; height:200px;" class="img-thumbnail flag flag-icon-background flag-icon-<%#DataBinder.Eval(Container.DataItem,"Code2").ToString().ToLower()%>">

            </div>

            <h3>
                
                    <asp:Label ID="lblitemName" runat="server" Text='<%#DataBinder.Eval(Container.DataItem,"Name").ToString() %>' />
               
            </h3>
 </a>

        </div>
    </ItemTemplate>
    <FooterTemplate>
        </div>
    </FooterTemplate>
</asp:Repeater>
