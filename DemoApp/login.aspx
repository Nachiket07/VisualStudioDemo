<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="DemoApp.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td><asp:Label ID="IdL" runat="server" Text="ID"></asp:Label></td>
                    <td><asp:TextBox ID="Id" runat="server"></asp:TextBox></td>
                </tr><tr>
                    <td><asp:Label ID="PassL" runat="server" Text="Password"></asp:Label></td>
                    <td><asp:TextBox ID="Pass" runat="server"></asp:TextBox></td>
                </tr><tr>
                    <td><asp:Button ID="Login" runat="server" Text="Login"></asp:Button></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
