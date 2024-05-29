<%@ Page Title="" Language="C#" MasterPageFile="~/Views/MasterPage/Navbar.Master" AutoEventWireup="true" CodeBehind="UpdateCart.aspx.cs" Inherits="LabProjectRAiso.Views.Pages.Customer.UpdateCart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Update Cart</h1>
    <div>
        <asp:Label ID="Lbl_Name" runat="server" Text="Name: "></asp:Label>
        <asp:TextBox ID="TBox_Name" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="Lbl_Price" runat="server" Text="Price: "></asp:Label>
        <asp:TextBox ID="TBox_Price" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="Lbl_Quantity" runat="server" Text="Quantity: "></asp:Label>
        <asp:TextBox ID="TBox_Quantity" runat="server" TextMode="Number"></asp:TextBox>
    </div>
    <asp:Label ID="Lbl_Error" runat="server" Text=""></asp:Label>
    <asp:Button ID="Btn_Update" runat="server" Text="Update" OnClick="Btn_Update_Click" />
</asp:Content>
