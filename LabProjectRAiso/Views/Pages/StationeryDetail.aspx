<%@ Page Title="" Language="C#" MasterPageFile="~/Views/MasterPage/Navbar.Master" AutoEventWireup="true" CodeBehind="StationeryDetail.aspx.cs" Inherits="LabProjectRAiso.Views.Pages.StationeryDetail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h1>Stationery Detail</h1>
        <div>
            <asp:Label ID="Lbl_Name" runat="server" Text="Stationery Name: "></asp:Label>
            <asp:TextBox ID="TBox_Name" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Lbl_Price" runat="server" Text="Stationery Price: "></asp:Label>
            <asp:TextBox ID="TBox_Price" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:TextBox ID="TBox_Quantity" TextMode="Number" runat="server"></asp:TextBox>
        </div>
        <asp:Label ID="Lbl_Error" runat="server" Text=""></asp:Label>
        <asp:Button ID="Btn_Add" runat="server" Text="Add to Cart" OnClick="Btn_Add_Click" />
    </div>
</asp:Content>
