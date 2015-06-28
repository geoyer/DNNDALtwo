<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SearchResults.ascx.cs" Inherits="Christoc.Modules.DNNDAL2.SearchResults" %>


<h2>Search Results</h2>
<asp:Repeater ID="rptResults" runat="server">

    <ItemTemplate>
        <p>
            <%#DataBinder.Eval(Container.DataItem,"Name").ToString() %>
        </p>
    </ItemTemplate>
</asp:Repeater>
