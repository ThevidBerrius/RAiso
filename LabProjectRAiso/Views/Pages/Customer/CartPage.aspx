<%@ Page Title="" Language="C#" MasterPageFile="~/Views/MasterPage/Navbar.Master" AutoEventWireup="true" CodeBehind="CartPage.aspx.cs" Inherits="LabProjectRAiso.Views.Pages.Customer.CartPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h1>Cart</h1>
        <div>
            <asp:GridView ID="GV_Cart" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="StationeryName" HeaderText="Name" SortExpression="StationeryName" />
                    <asp:BoundField DataField="StationeryPrice" HeaderText="Price" SortExpression="StationeryPrice" />
                    <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity" />
                    <asp:TemplateField HeaderText="Actions">
                        <ItemTemplate>
                            <asp:Button ID="Btn_Update" runat="server" Text="Update" OnClick="Btn_Update_Click" />
                            <asp:Button ID="Btn_Delete" runat="server" Text="Delete" OnClick="Btn_Delete_Click" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
        <asp:Button ID="Btn_Checkout" runat="server" Text="Checkout" OnClick="Btn_Checkout_Click" />
    </div>
</asp:Content>
