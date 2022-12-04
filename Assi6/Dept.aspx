<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dept.aspx.cs" Inherits="Assi6.Dept" %>

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
                    <td>Department Name</td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>

                    </td>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="Add" OnClick="Button1_Click" style="height: 29px" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
