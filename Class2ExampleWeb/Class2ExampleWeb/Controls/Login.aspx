<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Class2ExampleWeb.Controls.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Body" runat="server">
    <div style="width:50%; margin-left:25%; margin-top:2%; text-align:center;">
        <h1>Please Log In!</h1>
        <div style="margin-top:2%" class="form-row">
            <asp:TextBox ID="UserName" CssClass ="form-control" style="text-align:center" runat="server" placeholder ="User Name"></asp:TextBox>
        </div>
        <div style="margin-top:2%" class="form-row">
            <asp:TextBox ID="Password" CssClass ="form-control" style="text-align:center" placeholder ="Passowrd" TextMode="Password" runat="server"></asp:TextBox>
        </div>
        <div style="margin-top:2%" class="form-row">
            <asp:Button ID="BtnLogin" runat="server" CssClass="btn btn-success" Text="Login" OnClick="Login_Click" />
            <asp:Button ID="Clear" runat="server" CssClass="btn btn-danger" Text="Clear" OnClick="Clear_Click" />
        </div>
    </div>
</asp:Content>
