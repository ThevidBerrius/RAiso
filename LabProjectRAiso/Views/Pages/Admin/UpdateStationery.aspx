﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Views/MasterPage/Navbar.Master" AutoEventWireup="true" CodeBehind="UpdateStationery.aspx.cs" Inherits="LabProjectRAiso.Views.Pages.Admin.UpdateStationery" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Update Stationery</h1>
    <div>
        <asp:Label ID="Lbl_Name" runat="server" Text="Name: "></asp:Label>
        <asp:TextBox ID="TBox_Name" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="Lbl_Price" runat="server" Text="Price: "></asp:Label>
        <asp:TextBox ID="TBox_Price" TextMode="Number" runat="server"></asp:TextBox>
    </div>
    <asp:Label ID="Lbl_Error" runat="server" Text=""></asp:Label>
    <asp:Button ID="Btn_Insert" runat="server" Text="Insert" OnClick="Btn_Insert_Click"/>
</asp:Content>
