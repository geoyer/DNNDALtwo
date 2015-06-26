<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="List.ascx.cs" Inherits="Christoc.Modules.DNNDAL2.List" %>

<h1>Listing Page</h1>
<asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
<asp:Repeater ID="rptItemList" runat="server" OnItemDataBound="rptItemListOnItemDataBound" OnItemCommand="rptItemListOnItemCommand">
    <HeaderTemplate>
        <div class="row">
    </HeaderTemplate>

    <ItemTemplate>
        <div class="col-md-4">
            <h3>
                <a href="/Modules/cid/Details/cityId/<%#DataBinder.Eval(Container.DataItem,"ID").ToString() %>">

                    <asp:Label ID="lblitemName" runat="server" Text='<%#DataBinder.Eval(Container.DataItem,"Name").ToString() %>' />
                </a>



            </h3>
            <asp:Label ID="lblItemDescription" runat="server" Text='<%#DataBinder.Eval(Container.DataItem,"Population").ToString() %>' CssClass="tm_td" />

            <asp:Panel ID="pnlAdmin" runat="server" Visible="false">
                <asp:HyperLink ID="lnkEdit" runat="server" ResourceKey="EditItem.Text" Visible="false" Enabled="false" />
                <asp:LinkButton ID="lnkDelete" runat="server" ResourceKey="DeleteItem.Text" Visible="false" Enabled="false" CommandName="Delete" />
            </asp:Panel>
        </div>
    </ItemTemplate>
    <FooterTemplate>
        </div>
    </FooterTemplate>
</asp:Repeater>
