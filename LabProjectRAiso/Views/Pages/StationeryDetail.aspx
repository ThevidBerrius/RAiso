<%@ Page Title="" Language="C#" MasterPageFile="~/Views/MasterPage/Navbar.Master" AutoEventWireup="true" CodeBehind="StationeryDetail.aspx.cs" Inherits="LabProjectRAiso.Views.Pages.StationeryDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <div>
            <asp:Label ID="Lbl_Name" runat="server" Text="Stationery Name: "></asp:Label>
            <asp:Label ID="Lbl_NameText" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <asp:Label ID="Lbl_Price" runat="server" Text="Stationery Price: "></asp:Label>
            <asp:Label ID="Lbl_PriceText" runat="server" Text=""></asp:Label>
        </div>
        <asp:Label ID="Lbl_Error" runat="server" Text=""></asp:Label>
        <asp:TextBox ID="TBox_Quantity" runat="server"></asp:TextBox>
        <asp:Button ID="Btn_Add" runat="server" Text="Add to Cart" />
</asp:Content>
