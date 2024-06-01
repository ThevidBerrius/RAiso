<%@ Page Title="" Language="C#" MasterPageFile="~/Views/MasterPage/Navbar.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="LabProjectRAiso.Views.Pages.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="homeSection">
        <h1>Home</h1>
        <div class="homeContent">
            <asp:Button class="itemButton" ID="Btn_Insert" runat="server" Text="Insert Stationery" OnClick="Btn_Insert_Click" Visible="false" />
            <asp:GridView ID="GV_Stationery" runat="server" AutoGenerateColumns="False" CssClass="gridview-padding" OnRowDeleting="GV_Stationery_RowDeleting" OnRowEditing="GV_Stationery_RowEditing" OnSelectedIndexChanged="GV_Stationery_SelectedIndexChanged">
                <Columns>
                    <asp:BoundField DataField="StationeryName" HeaderText="Name" SortExpression="StationeryName" />
                    <asp:BoundField DataField="StationeryPrice" HeaderText="Price" SortExpression="StationeryPrice" />
                    <asp:CommandField ButtonType="Button" ShowSelectButton="True" HeaderText="Select" />
                    <asp:CommandField ButtonType="Button" HeaderText="Action" ShowCancelButton="False" ShowDeleteButton="True" ShowEditButton="True" ShowHeader="True" Visible="false" />
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>
