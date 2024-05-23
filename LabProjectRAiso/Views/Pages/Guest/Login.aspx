<%@ Page Title="" Language="C#" MasterPageFile="~/Views/MasterPage/Navbar.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="LabProjectRAiso.Views.Pages.Guest.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h1>Login</h1>
        <div>
            <asp:Label ID="Lbl_Username" runat="server" Text="Username"></asp:Label>
            <asp:TextBox ID="TBox_Username" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Lbl_Password" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="TBox_Password" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Lbl_Status" runat="server" Text=""></asp:Label>
        </div>
        <asp:Button ID="Btn_Login" runat="server" Text="Login" />
    </div>
</asp:Content>
