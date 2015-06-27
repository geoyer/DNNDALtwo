<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Details.ascx.cs" Inherits="Christoc.Modules.DNNDAL2.Details" %>


<div class="row">

    <div class="col-md-6">
        <h1 id="MainTitle" runat="server">Country Name</h1>

        <asp:Repeater ID="rptCities" runat="server">

            <HeaderTemplate>
                <h2>Most Populated City/Cities</h2>

            </HeaderTemplate>
            <ItemTemplate>
                
                <div class="row">

                    <div class="col-md-6">
                          <h3>
                    <%#DataBinder.Eval(Container.DataItem,"Name").ToString() %>
                </h3>
                    </div>


                    <div class="col-md-6">
                          <h3>
                    <%# string.Format("{0:N0}", DataBinder.Eval(Container.DataItem, "Population")) %>
                </h3>
                    </div>

                </div>
              
            </ItemTemplate>
        </asp:Repeater>

    </div>

    <div class="col-md-6">
        <asp:Literal ID="CountryMap" runat="server"></asp:Literal>
    </div>


</div>





