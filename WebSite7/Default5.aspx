<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default5.aspx.vb" Inherits="Default5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table border ="1">
        <tr>
            <td>
                student id
            </td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                student name
            </td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                gender
            </td>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server">
                    <asp:ListItem>MALE</asp:ListItem>
                    <asp:ListItem>FEMALE</asp:ListItem>

                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td >
                address
            </td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server" TextMode="MultiLine" Height="100" Width="200"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                pincode
            </td>
            <td>
                <asp:TextBox ID="TextBox4" runat="server" MaxLength="6"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan ="2">
                <asp:Button ID="Button1" runat="server" Text="submit" />
                <asp:Button ID="Button3" runat="server" Text="update" />
                <asp:Button ID="Button4" runat="server" Text="delete" />
                <asp:Button ID="Button2" runat="server" Text="clear" />
            </td>
        </tr>
        <tr>
            <td colspan ="2">
                <asp:GridView ID="GridView1" runat="server"></asp:GridView>
            </td>
        </tr>
    </table>
    </div>
    </form>
</body>
</html>
