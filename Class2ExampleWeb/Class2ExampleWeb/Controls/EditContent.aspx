<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="EditContent.aspx.cs" Inherits="Class2ExampleWeb.Controls.EditContent" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Body" runat="server">
        <div style="width: 80%; margin-left: 10%; margin-top: 2%;">
        <div class="form-row" style="margin-top: 2%;">
            <div class="col">
                <asp:TextBox ID="FirstName" placeholder="First Name" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="col">
                <asp:TextBox ID="LastName" placeholder="Last Name" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
        </div>
        <div class="form-row" style="margin-top: 2%;">
            <div class="col">
                <asp:TextBox ID="Street1" placeholder="Street 1" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="col">
                <asp:TextBox ID="Street2" placeholder="Street 2 (Optional)" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
        </div>
        <div class="form-row" style="margin-top: 2%;">
            <div class="col">
                <asp:TextBox ID="City" placeholder="City" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="col">
                <asp:DropDownList ID="State" CssClass="form-control" runat="server">
                    <asp:ListItem>AL</asp:ListItem>
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
                    <asp:ListItem>WY</asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="col">
                <asp:TextBox ID="Zip" placeholder="Zipcode" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
        </div>
        <div class="form-row" style="margin-top: 2%;">
            <div class="col">
                <asp:TextBox ID="Email" placeholder="Email Address" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="col">
                <asp:TextBox ID="PhoneNumber" placeholder="Phone Number" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
        </div>
        <div class="form-row" style="margin-top: 2%;">
            <div class="col">
                <asp:TextBox ID="Notes" TextMode="MultiLine" placeholder="Additional Comments (Optional)" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
        </div>
        <div class="form-row" style="margin-top: 2%;">
            <div class="col">
                <asp:Button ID="fill" CssClass="btn btn-primary" runat="server" Text="Fill Form" OnClick="Fill_Click"/>      
                <asp:Button ID="submit" CssClass="btn btn-success" runat="server" Text="Submit" OnClick="Submit_Click" />                
                <asp:Button ID="Clear" CssClass="btn btn-danger" runat="server" Text="Clear" OnClick="Clear_Click" />
            </div>
        </div>
    </div>
</asp:Content>
