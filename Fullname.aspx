<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Fullname.aspx.cs" Inherits="Concatenation.Fullname" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Enter your First Name: <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br /><br />
            Enter your Last Name: <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br /><br />

            <asp:Button ID="B1" runat="server" Text="Display" OnClick="B1_Click" />
            <asp:Button ID="B2" runat="server" Text="Clear" OnClick="B2_Click" />

            <br /><br />
            <!-- Label to display full name -->
            <asp:Label ID="FullNameLabel" runat="server" Text="Full Name here:"></asp:Label>
        </div>
    </form>
</body>
</html>
