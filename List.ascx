<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="List.ascx.cs" Inherits="Christoc.Modules.DNNDAL2.List" %>



<h1>Countries Of The World</h1>

<div class="row">

    <div class="col-md-6">

        <h4>Sort</h4>
        <asp:DropDownList ID="ddlCountrySort" runat="server" OnSelectedIndexChanged="ddlCountrySort_SelectedIndexChanged">
            <asp:ListItem>Name</asp:ListItem>
            <asp:ListItem>Population</asp:ListItem>
        </asp:DropDownList>

        <asp:DropDownList ID="ddlCountrySortDirection" runat="server">
            <asp:ListItem Value="True">Ascending</asp:ListItem>
            <asp:ListItem Value="False">Descending</asp:ListItem>
        </asp:DropDownList>

        <asp:Button ID="btnSort" runat="server" Text="Sort" OnClick="btnSort_Click" />
    </div>


    <div class="col-md-6">
        <h4>Search</h4>
        <asp:TextBox ID="txtSearch" runat="server"></asp:TextBox>
        <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />
    </div>

</div>


<hr />
<asp:Repeater ID="rptItemList" runat="server">
    <HeaderTemplate>
        <div class="row">
    </HeaderTemplate>

    <ItemTemplate>
        <div class="col-md-3">

            <div class="thumbnail">

                <a href="<%# DotNetNuke.Entities.Tabs.TabController.CurrentPage.FullUrl +"/cid/Details/CountryID/"+ DataBinder.Eval(Container.DataItem,"Code").ToString() %>">
                    <div style="width: 100%; height: 200px;" class="img-responsive center-block flag flag-icon-background flag-icon-<%#DataBinder.Eval(Container.DataItem,"Code2").ToString().ToLower()%>">
                    </div>
                </a>

                <a href="<%# DotNetNuke.Entities.Tabs.TabController.CurrentPage.FullUrl +"/cid/Details/CountryID/"+ DataBinder.Eval(Container.DataItem,"Code").ToString() %>">
                    <h3>
                        <asp:Label ID="lblitemName" runat="server" Text='<%#DataBinder.Eval(Container.DataItem,"Name").ToString() %>' />

                    </h3>
                </a>

                <p>Population: <%# String.Format("{0:N0}", DataBinder.Eval(Container.DataItem,"Population"))%></p>

                <a href="<%# DotNetNuke.Entities.Tabs.TabController.CurrentPage.FullUrl +"/cid/Details/CountryID/"+ DataBinder.Eval(Container.DataItem,"Code").ToString() %>" class="btn btn-primary" role="button">Read More...</a>


            </div>

        </div>
    </ItemTemplate>
    <FooterTemplate>
        </div>
    </FooterTemplate>
</asp:Repeater>
