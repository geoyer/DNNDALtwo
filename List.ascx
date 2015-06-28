<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="List.ascx.cs" Inherits="Christoc.Modules.DNNDAL2.List" %>

<%--Added To Allow Stylesheet of Flags to be added--%>
<%@ Register TagPrefix="dnn" Namespace="DotNetNuke.Web.Client.ClientResourceManagement" Assembly="DotNetNuke.Web.Client" %>
<dnn:DnnCssInclude runat="server" FilePath="~/DesktopModules/DNNDAL2/Resources/Flags/css/flag-icon.min.css" />



<h1>Listing Page</h1>


<asp:DropDownList ID="ddlCountrySort" runat="server" OnSelectedIndexChanged="ddlCountrySort_SelectedIndexChanged">
    <asp:ListItem>Name</asp:ListItem>
    <asp:ListItem>Population</asp:ListItem>
</asp:DropDownList>

<asp:DropDownList ID="ddlCountrySortDirection" runat="server">
    <asp:ListItem Value="True">Ascending</asp:ListItem>
    <asp:ListItem Value="False">Descending</asp:ListItem>
</asp:DropDownList>

<asp:Button ID="btnSort" runat="server" Text="Sort" OnClick="btnSort_Click" />

<hr />
<asp:Repeater ID="rptItemList" runat="server">
    <HeaderTemplate>
        <div class="row">
    </HeaderTemplate>

    <ItemTemplate>
        <div class="col-md-3">

            <div class="thumbnail">

                <div style="width: 100%; height: 200px;" class="img-responsive center-block flag flag-icon-background flag-icon-<%#DataBinder.Eval(Container.DataItem,"Code2").ToString().ToLower()%>">
                </div>

                <a href="/Modules/cid/Details/CountryID/<%#DataBinder.Eval(Container.DataItem,"Code").ToString() %>">
                    <h3><asp:Label ID="lblitemName" runat="server" Text='<%#DataBinder.Eval(Container.DataItem,"Name").ToString() %>' /></h3>
                </a>

                <p>Population: <%# String.Format("{0:N0}", DataBinder.Eval(Container.DataItem,"Population"))%></p>


                <a href="/Modules/cid/Details/CountryID/<%#DataBinder.Eval(Container.DataItem,"Code").ToString() %>" class="btn btn-primary" role="button">Read More...</a>


            </div>

            </div>
    </ItemTemplate>
    <FooterTemplate>
        </div>
    </FooterTemplate>
</asp:Repeater>
