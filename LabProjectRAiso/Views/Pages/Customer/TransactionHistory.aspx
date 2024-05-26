<%@ Page Title="" Language="C#" MasterPageFile="~/Views/MasterPage/Navbar.Master" AutoEventWireup="true" CodeBehind="TransactionHistory.aspx.cs" Inherits="LabProjectRAiso.Views.Pages.Customer.TransactionHistory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GV_History" runat="server">
        <Columns>
            <asp:BoundField DataField="TransactionID" HeaderText="Transaction ID" SortExpression="TransactionID" />
            <asp:BoundField DataField="TransactionDate" HeaderText="Transaction Date" SortExpression="TransactionDate" />
            <asp:BoundField DataField="UserName" HeaderText="Name" SortExpression="UserName" />
            <asp:ButtonField ButtonType="Button" CommandName="Select" HeaderText="Detail" ShowHeader="True" Text="Detail" />
        </Columns>
    </asp:GridView>
</asp:Content>
