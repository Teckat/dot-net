<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>MUTEBREAK</title>
    <script>

        function check() {
            a = document.getElementById("TextBox1");


            if (a.value == '') {
                alert("please enter the name  !");
                a.focus();
                return false;
            }
        }

    </script>


</head>
<body>
    <form id="form1" runat="server">
    <div>

<table border ="5" >


    <tr>
        <td>
            name
        </td>
        <td>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:Button ID="Button1" runat="server" Text="save" OnClientClick ="return check();" />
        </td>
    </tr>

    <tr>
        <td>
            gender
        </td>
        <td>
            <asp:DropDownList ID="DropDownList1" runat="server" Width="200">
            <asp:ListItem>-select-</asp:ListItem>
                <asp:ListItem>MALE</asp:ListItem>
                <asp:ListItem>FEMALE</asp:ListItem>
            </asp:DropDownList>
        </td>
    </tr>

    <tr>
        <td>
            age
        </td>
        <td>
            <asp:DropDownList ID="DropDownList2" runat="server">
                <asp:ListItem>15</asp:ListItem>
                  <asp:ListItem>16</asp:ListItem>
                  <asp:ListItem>17</asp:ListItem>
                  <asp:ListItem>18</asp:ListItem>
                  <asp:ListItem>19</asp:ListItem>
                  <asp:ListItem>20</asp:ListItem>
                  <asp:ListItem>21</asp:ListItem>
                  <asp:ListItem>22</asp:ListItem>
                  <asp:ListItem>23</asp:ListItem>
                  <asp:ListItem>24</asp:ListItem>
                  <asp:ListItem>25</asp:ListItem>
               
            </asp:DropDownList>
        </td>
    </tr>

    <tr> 
        <td colspan="3" align="center">
            <asp:Button ID="Button2" runat="server" Text="Next page" PostBackUrl="~/Default2.aspx" />
        </td>
    </tr>
    <tr>
        <td>
            <asp:Image ID="Image1" runat="server" ImageUrl="~/shriya2.jpg" Width="100" /> 
        </td>
    </tr>
</table>

        </div>
    </form>


</body>
</html>
