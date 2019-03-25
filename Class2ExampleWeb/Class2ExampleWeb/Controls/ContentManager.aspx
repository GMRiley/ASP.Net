<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ContentManager.aspx.cs" Inherits="Class2ExampleWeb.Controls.ContentManager" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Body" runat="server">
    <div style="width:80%; margin-top: 2%; margin-left:10%; text-align:center;">
        <h1>Manage Users</h1>
        <asp:Button ID="btnLogout" runat="server" Text="Log Out" CssClass="btn btn-danger float-right" OnClick="BtnLogout_Click"/>
    </div>
    <div style="width:80%; margin-top: 2%; margin-left:10%; text-align:center;">
        <asp:Table ID="Table1" CssClass="table table-dark table-hover" runat="server">
            <asp:TableHeaderRow CssClass="thead-dark">
                <asp:TableCell>First Name</asp:TableCell>
                <asp:TableCell>Last Name</asp:TableCell>
                <asp:TableCell>Street One</asp:TableCell>
                <asp:TableCell>Street Two</asp:TableCell>
                <asp:TableCell>City</asp:TableCell>
                <asp:TableCell>State</asp:TableCell>
                <asp:TableCell>Zip Code</asp:TableCell>
                <asp:TableCell>Email</asp:TableCell>
                <asp:TableCell>Phone</asp:TableCell>
                <asp:TableCell>Edit</asp:TableCell>
                <asp:TableCell>Delete</asp:TableCell>
            </asp:TableHeaderRow>
        </asp:Table>
    </div>
</asp:Content>
