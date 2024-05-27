<%@ Page Title="" Language="C#" MasterPageFile="~/Views/MasterPage/Navbar.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="LabProjectRAiso.Views.Pages.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h1>Home</h1>
        <div>
            <asp:Button ID="Btn_Insert" runat="server" Text="Insert Stationery" OnClick="Btn_Insert_Click" Visible="false" />
            <asp:GridView ID="GV_Stationery" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:CommandField ButtonType="Button" ShowSelectButton="True" HeaderText="Select" />
                    <asp:CommandField ButtonType="Button" HeaderText="Action" ShowCancelButton="False" ShowDeleteButton="True" ShowEditButton="True" ShowHeader="True" Visible="false" />
                    <asp:BoundField DataField="StationeryName" HeaderText="Name" SortExpression="StationeryName" />
                    <asp:BoundField DataField="StationeryPrice" HeaderText="Price" SortExpression="StationeryPrice" />
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>
