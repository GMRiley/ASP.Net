<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ExampleOne.aspx.cs" Inherits="ClassOne.ExampleOne" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="LCD" runat="server" Width="168px"></asp:TextBox>
            <asp:Label ID="LCDmemory" runat="server" Text="Memory:"></asp:Label>
            <asp:Label ID="LCDmStore" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <asp:Button ID="BtnClear" runat="server" Text="C" style="width:40px" OnClick="BtnClear_Click"/>
            <asp:Button ID="BtnMR" runat="server" Text="MR" style="width:40px" OnClick="BtnMR_Click"/>
            <asp:Button ID="BtnMS" runat="server" Text="MS" style="width:40px" OnClick="BtnMS_Click"/>
            <asp:Button ID="BtnDiv" runat="server" Text="/" style="width:40px" OnClick="BtnDiv_Click"/>
            <asp:Label ID="LCDFunc" runat="server" Text="Function:"></asp:Label>
            <asp:Label ID="LCDfStore" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <asp:Button ID="Btn7" runat="server" Text="7" OnClick="Btn7_Click" style="width:40px" />
            <asp:Button ID="Btn8" runat="server" Text="8" OnClick="Btn8_Click" style="width:40px"/>
            <asp:Button ID="Btn9" runat="server" Text="9" OnClick="Btn9_Click"  style="width:40px"/>
            <asp:Button ID="BtnMult" runat="server" Text="X" OnClick="BtnMult_Click" style="width:40px"/>
        </div>
        <div>
            <asp:Button ID="Btn4" runat="server" Text="4" OnClick="Btn4_Click" style="width:40px" />
            <asp:Button ID="Btn5" runat="server" Text="5" OnClick="Btn5_Click" style="width:40px"/>
            <asp:Button ID="Btn6" runat="server" Text="6" OnClick="Btn6_Click"  style="width:40px"/>
            <asp:Button ID="BtnSub" runat="server" Text="-" OnClick="BtnSub_Click" style="width:40px"  />
        </div>
        <div>
            <asp:Button ID="Btn1" runat="server" Text="1"  style="width:40px" OnClick="Btn1_Click"/>
            <asp:Button ID="Btn2" runat="server" Text="2" style="width:40px" OnClick="Btn2_Click"/>
            <asp:Button ID="Btn3" runat="server" Text="3"  style="width:40px" OnClick="Btn3_Click"/>
            <asp:Button ID="BtnAdd" runat="server" Text="+" style="width:40px" OnClick="BtnAdd_Click"/>
        </div>
        <div>
            <asp:Button ID="Btn" runat="server" Text="+/-" style="width:40px" OnClick="Btn_Click"/>
            <asp:Button ID="Btn0" runat="server" Text="0" style="width:40px" OnClick="Btn0_Click"/>
            <asp:Button ID="BtnDec" runat="server" Text="." style="width:40px" OnClick="BtnDec_Click"/>
            <asp:Button ID="BtnEq" runat="server" Text="=" style="width:40px" OnClick="BtnEq_Click"/>
        </div>
    </form>
</body>
</html>
