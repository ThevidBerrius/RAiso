<%@ Page Title="" Language="C#" MasterPageFile="~/Views/MasterPage/Navbar.Master" AutoEventWireup="true" CodeBehind="CartPage.aspx.cs" Inherits="LabProjectRAiso.Views.Pages.Customer.CartPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <div>
            <asp:GridView ID="GV_Cart" runat="server">
                <Columns>
                    <asp:BoundField DataField="StationeryName" HeaderText="Name" SortExpression="StationeryName" />
                    <asp:BoundField DataField="StationeryPrice" HeaderText="Price" SortExpression="StationeryPrice" />
                    <asp:ButtonField ButtonType="Button" CommandName="Update" HeaderText="Update" ShowHeader="True" Text="Update" />
                    <asp:ButtonField ButtonType="Button" CommandName="Delete" HeaderText="Remove" ShowHeader="True" Text="Remove" />
                </Columns>
            </asp:GridView>
        </div>
        <asp:Button ID="Btn_Checkout" runat="server" Text="Checkout" />
    </div>
</asp:Content>
