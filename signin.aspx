<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="signin.aspx.cs" Inherits="WebApplication1.signin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblUsername" runat="server" Text="User Name"></asp:Label>
        <p>
            <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
        <p>
            <asp:TextBox ID="txtPassword" TextMode="Password" runat="server"></asp:TextBox>
            
        </p>
        <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Log in!" />
        <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
