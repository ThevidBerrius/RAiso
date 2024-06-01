<%@ Page Title="" Language="C#" MasterPageFile="~/Views/MasterPage/Navbar.Master" AutoEventWireup="true" CodeBehind="TransactionDetail.aspx.cs" Inherits="LabProjectRAiso.Views.Pages.Customer.TransactionDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="homeSection">
        <h1>Transaction Detail</h1>
        <div class="transactionDetail">
            <div class="stationeryContent">
                <asp:Label ID="Lbl_Name" runat="server" Text="Stationery Name: "></asp:Label>
                <asp:TextBox CssClass="TextBox" ID="TBox_Name" runat="server"></asp:TextBox>
            </div>
            <div class="stationeryContent">
                <asp:Label ID="Lbl_Price" runat="server" Text="Stationery Price: "></asp:Label>
                <asp:TextBox CssClass="TextBox" ID="TBox_Price" runat="server"></asp:TextBox>
            </div>
            <div class="transactionQuantity">
                <asp:Label ID="Lbl_Quantity" runat="server" Text="Quantity: "></asp:Label>
                <asp:TextBox CssClass="TextBox" ID="TBox_Quantity" runat="server"></asp:TextBox>
            </div>
        </div>
    </div>
</asp:Content>
