<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WelcomeAdmin.aspx.cs" Inherits="HospitalSystem.WelcomeAdmin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
                     <table align="centre" runat="server">
                <tr>
     <td>
         <asp:Button ID="Button1" runat="server" Text="Add doctor" OnClick="Button1_Click" /></td>
                        <td>
         <asp:Button ID="Button2" runat="server" Text="Add Employee" OnClick="Button2_Click" /></td>
                    <td>
                        
                    </td>
                    <td>
                        <asp:Button ID="Button3" runat="server" Text="Home" OnClick="Button3_Click" />
                        </td>
                     <td>
                        <asp:Button ID="Button4" runat="server" Text="Logout" OnClick="Button4_Click" />
                        </td>
                    <td>Hello
                        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
              
                <asp:GridView ID="GridView1" runat="server" Visible="false"></asp:GridView>
            </table>
        </div>
    </form>
</body>
</html>
