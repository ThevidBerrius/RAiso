<%@ Page Title="" Language="C#" MasterPageFile="~/Views/MasterPage/Navbar.Master" AutoEventWireup="true" CodeBehind="TransactionDetails.aspx.cs" Inherits="LabProjectRAiso.Views.Pages.Customer.TransactionDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="homeSection">
        <h1>Transaction Detail</h1>
        <asp:GridView ID="GV_Detail" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="StationeryName" HeaderText="Stationery Name" SortExpression="StationeryName" />
                <asp:BoundField DataField="StationeryPrice" HeaderText="Stationery Price" SortExpression="StationeryPrice" />
                <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity" />
            </Columns>

        </asp:GridView>
    </div>
</asp:Content>
