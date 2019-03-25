<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="apply.aspx.cs" Inherits="Lab_2.apply" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Body" runat="server">
    <div style="width:60%; margin-left:20%; margin-top:2%;">
        <h1>Apply Now</h1>
        <div class="form-row" style="margin-top:2%">
            <div class ="col">
                <asp:TextBox ID="Firstname" CssClass ="form-control" placeholder ="First Name" runat="server"></asp:TextBox>
            </div>
           
            
            
            <div class ="col">
                <asp:TextBox ID="LastName" CssClass="form-control" placeholder ="Last Name" runat="server"></asp:TextBox>
            </div>
           
            
        </div>
        <div class ="form-row" style="margin-top:2%">
             <div class ="col">
                <asp:TextBox ID="AddressOne" CssClass ="form-control" placeholder ="Address One" runat="server"></asp:TextBox>
            </div>
             <div class="col">
                <asp:TextBox ID="AddressTwo" CssClass="form-control" placeholder ="Address Two (Optional)" runat="server"></asp:TextBox>
            </div>
           
        </div>
        <div class ="form-row" style="margin-top:2%">
             <div class ="col">
                <asp:TextBox ID="City" CssClass ="form-control" placeholder ="City" runat="server"></asp:TextBox>
            </div>
            <div class ="col">
                <asp:DropDownList ID="DropDownList1" runat="server" CssClass ="form-control">		    <asp:ListItem>AL</asp:ListItem>
                    <asp:ListItem>AK</asp:ListItem>
                    <asp:ListItem>AZ</asp:ListItem>
                    <asp:ListItem>AR</asp:ListItem>
                    <asp:ListItem>CA</asp:ListItem>
                    <asp:ListItem>CO</asp:ListItem>
                    <asp:ListItem>CT</asp:ListItem>
                    <asp:ListItem>DE</asp:ListItem>
                    <asp:ListItem>FL</asp:ListItem>
                    <asp:ListItem>GA</asp:ListItem>
                    <asp:ListItem>HI</asp:ListItem>
                    <asp:ListItem>ID</asp:ListItem>
                    <asp:ListItem>IL</asp:ListItem>
                    <asp:ListItem>IN</asp:ListItem>
                    <asp:ListItem>IA</asp:ListItem>
                    <asp:ListItem>KS</asp:ListItem>
                    <asp:ListItem>KY</asp:ListItem>
                    <asp:ListItem>LA</asp:ListItem>
                    <asp:ListItem>ME</asp:ListItem>
                    <asp:ListItem>MD</asp:ListItem>
                    <asp:ListItem>MA</asp:ListItem>
                    <asp:ListItem>MI</asp:ListItem>
                    <asp:ListItem>MN</asp:ListItem>
                    <asp:ListItem>MS</asp:ListItem>
                    <asp:ListItem>MO</asp:ListItem>
                    <asp:ListItem>MT</asp:ListItem>
                    <asp:ListItem>NE</asp:ListItem>
                    <asp:ListItem>NV</asp:ListItem>
                    <asp:ListItem>NH</asp:ListItem>
                    <asp:ListItem>NJ</asp:ListItem>
                    <asp:ListItem>NM</asp:ListItem>
                    <asp:ListItem>NY</asp:ListItem>
                    <asp:ListItem>NC</asp:ListItem>
                    <asp:ListItem>ND</asp:ListItem>
                    <asp:ListItem>OH</asp:ListItem>
                    <asp:ListItem>OK</asp:ListItem>
                    <asp:ListItem>OR</asp:ListItem>
                    <asp:ListItem>PA</asp:ListItem>
                    <asp:ListItem>RI</asp:ListItem>
                    <asp:ListItem>SC</asp:ListItem>
                    <asp:ListItem>SD</asp:ListItem>
                    <asp:ListItem>TN</asp:ListItem>
                    <asp:ListItem>TX</asp:ListItem>
                    <asp:ListItem>UT</asp:ListItem>
                    <asp:ListItem>VT</asp:ListItem>
                    <asp:ListItem>VA</asp:ListItem>
                    <asp:ListItem>WA</asp:ListItem>
                    <asp:ListItem>WV</asp:ListItem>
                    <asp:ListItem>WI</asp:ListItem>
                    <asp:ListItem>WY</asp:ListItem></asp:DropDownList>
            </div>
            <div class="col">
                <asp:TextBox ID="Zip" CssClass ="form-control" placeholder ="Zip Code" runat="server"></asp:TextBox>
            </div>
        </div>
        <div class="form-row" style="margin-top:2%;">
            <div class ="col">
                <asp:TextBox ID="Email" CssClass ="form-control" placeholder ="Email Address" runat="server"></asp:TextBox>
                

            </div>
            <div class="col">
                <asp:TextBox ID="PhoneNumber" CssClass ="form-control" placeholder ="Phone Number" runat="server"></asp:TextBox>
            </div>
        </div>
        <div class="form-row" style="margin-top:2%;">
            <asp:TextBox ID="Comments" CssClass ="form-control" placeholder ="Additional Comments (Optional)" runat="server" Height="100px"></asp:TextBox>
        </div>
        <div class="form-row" style="margin-top:2%">
            <asp:Button ID="Submit" runat="server" Text="Submit" CssClass="btn btn-success" OnClick="Submit_Click"/>
            <asp:Button ID="Clear" runat="server" Text="Clear" CssClass="btn btn-danger" OnClick="Clear_Click"/>
        </div>
    </div>
</asp:Content>
