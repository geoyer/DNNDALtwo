<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Details.ascx.cs" Inherits="Christoc.Modules.DNNDAL2.Details" %>


<div class="row">

    <div class="col-md-6">
        <h1 id="MainTitle" runat="server">Country Name</h1>

        <asp:Repeater ID="rptCities" runat="server">
            <ItemTemplate>
                <h3>
                    <%#DataBinder.Eval(Container.DataItem,"Name").ToString() %>
                </h3>
            </ItemTemplate>
        </asp:Repeater>

    </div>

    <div class="col-md-6">
        <asp:Literal ID="CountryMap" runat="server"></asp:Literal>
    </div>


</div>





