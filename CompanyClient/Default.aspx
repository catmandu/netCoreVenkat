<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <table style="border:1px solid black">
            <tr>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="Get Public Information" Width="300px" OnClick="Button1_Click"/>
                </td>
                <td>
                    <asp:Label ID="Label1" runat="server" Font-Bold="true"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Button2" runat="server" Text="Get Confidential Information" Width="300px" OnClick="Button2_Click"/>
                </td>
                <td>
                    <asp:Label ID="Label2" runat="server" Font-Bold="true"></asp:Label>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
