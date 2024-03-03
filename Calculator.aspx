<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculator.aspx.cs" Inherits="Concatenation.Calculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
         Enter First Number:   <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
          Enter Another Number:  <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />

            <asp:Button ID="Button1" runat="server" Text="+" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" Text="-" OnClick="Button2_Click" />
            <asp:Button ID="Button3" runat="server" Text="*" OnClick="Button3_Click" />
            <asp:Button ID="Button4" runat="server" Text="/" OnClick="Button4_Click" />
            <asp:Button ID="Button5" runat="server" Text="Clear" OnClick="Button5_Click" />

            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>

        </div>
    </form>
</body>
</html>
