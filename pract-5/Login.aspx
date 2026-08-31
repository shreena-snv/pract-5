<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="Login.aspx.cs"
    Inherits="pract_5.Login" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
</head>
<body>
    <form id="form1" runat="server">
        <table>
            <tr>
                <td colspan="2"><h2>Login</h2></td>
            </tr>

            <tr>
                <td><asp:Label ID="lblUser" runat="server" Text="User ID:" /></td>
                <td><asp:TextBox ID="txtUser" runat="server" /></td>
            </tr>

            <tr>
                <td><asp:Label ID="lblPwd" runat="server" Text="Password:" /></td>
                <td><asp:TextBox ID="txtPwd" runat="server" TextMode="Password" /></td>
            </tr>

            <tr>
                <td colspan="2">
                    <asp:CheckBox ID="chkRememberMe" runat="server" Text="Remember Me" />
                </td>
            </tr>

            <tr>
                <td colspan="2">
                    <asp:Button ID="btnLogin" runat="server"
                        Text="Login" OnClick="btnLogin_Click" />
                </td>
            </tr>

            <tr>
                <td colspan="2">
                    <asp:Label ID="lblMessage" runat="server" ForeColor="Red" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>