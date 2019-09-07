<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Demo.aspx.cs" Inherits="DemoApp.Demo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 214px">
    <form id="form1" runat="server">
        <table>
        <tr>
        <td><asp:Label ID="Id" runat="server" Text="ID"></asp:Label></td>
        <td><asp:TextBox ID="Empid" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
        <td><asp:Label ID="lblName" runat="server" Text="Name"></asp:Label></td>
        <td><asp:TextBox ID="txtName" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
        <td><asp:Label ID="lbllistbox" runat="server" Text="City"></asp:Label></td>
        
        <td><asp:ListBox ID="lstLocation" runat="server">
            <asp:ListItem>Mumbai</asp:ListItem>
            <asp:ListItem>Pune</asp:ListItem>
            <asp:ListItem>Uran</asp:ListItem>
            <asp:ListItem>Dadar</asp:ListItem>
            <asp:ListItem>Nerul</asp:ListItem>
            <asp:ListItem>Thane</asp:ListItem>
        </asp:ListBox></td>
        </tr>
        <tr>
        <td><asp:Label ID="lblTech" runat="server" Text="Technology"></asp:Label></td>
        
        <td><asp:CheckBox ID="chkASP" runat="server" Text="ASP.NET" /></td>
        
        <td><asp:CheckBox ID="chkC" runat="server" Text="C#" /></td>
        </tr>
        <tr>
        <td><asp:Button ID="btnShow" runat="server" Text="Show" OnClick="Button1_Click" /></td>
        <td><asp:Button ID="btnIns" runat="server" Text="Insert" OnClick="Insert" /></td>
        <td><asp:Button ID="btnDel" runat="server" Text="Delete" OnClick="Delete" /></td>
        <td><asp:Button ID="btnUpd" runat="server" Text="Update" OnClick="Update" /></td>
        <td><asp:Button ID="SRecord" runat="server" Text="ViewRecord" OnClick="ShowRecord" /></td>
        </tr>
        </table>
    </form>
</body>
</html>
