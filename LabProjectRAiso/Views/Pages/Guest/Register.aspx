<%@ Page Title="" Language="C#" MasterPageFile="~/Views/MasterPage/Navbar.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="LabProjectRAiso.Views.Pages.Guest.Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="homeSection">
        <h1>Register</h1>
        <div class="inputSection">
            <div class="registerProfileContent">
                <asp:Label ID="Lbl_Name" runat="server" Text="Name"></asp:Label>
                <asp:TextBox CssClass="TextBox" ID="TBox_Name" runat="server"></asp:TextBox>
            </div>
            <div class="registerProfileContent">
                <asp:Label ID="Lbl_DOB" runat="server" Text="Date of Birth"></asp:Label>
                <asp:TextBox CssClass="Tbox_DOB" ID="TBox_DOB" runat="server" TextMode="Date"></asp:TextBox>
            </div>
            <div class="registerProfileContent">
                <asp:Label ID="Lbl_Gender" runat="server" Text="Gender"></asp:Label>
                <div class="radioButton">
                    <asp:RadioButton ID="Radio_Male" runat="server" Text="Male" GroupName="Gender"/>
                    <asp:RadioButton ID="Radio_Female" runat="server" Text="Female" GroupName="Gender"/>
                </div>
            </div>
            <div class="registerProfileContent">
                <asp:Label ID="Lbl_Address" runat="server" Text="Address"></asp:Label>
                <asp:TextBox CssClass="TextBox" ID="TBox_Address" runat="server"></asp:TextBox>
            </div>
            <div class="registerProfileContent">
                <asp:Label ID="Lbl_Password" runat="server" Text="Password"></asp:Label>
                <asp:TextBox CssClass="TextBox" ID="TBox_Password" runat="server"></asp:TextBox>
            </div>
            <div class="registerProfileContent">
                <asp:Label ID="Lbl_Phone" runat="server" Text="Phone"></asp:Label>
                <asp:TextBox CssClass="TextBox" ID="TBox_Phone" runat="server"></asp:TextBox>
            </div>
            <asp:Button CssClass="updateButton" ID="Btn_Register" runat="server" Text="Register" OnClick="Btn_Register_Click"/>
        </div>
                    <asp:Label CssClass="errorLabel" ID="Lbl_Status" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>
