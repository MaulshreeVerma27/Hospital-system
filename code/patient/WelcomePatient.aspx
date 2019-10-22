<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WelcomePatient.aspx.cs" Inherits="HospitalSystem.WelcomePatient" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table  runat="server">
                <tr>
     <td>
         <asp:Button ID="Button1" runat="server" Text="Request For appointments" OnClick="Button1_Click" /></td>
                    <td>
                        
                    </td>
                    <td>
                        <asp:Button ID="Button3" runat="server" Text="Home" />
                        </td>
                     <td>
                        <asp:Button ID="Button4" runat="server" Text="Logout" OnClick="Button4_Click" />
                        </td>
                        <td>
                        <asp:Button ID="Button5" runat="server" Text="Change Password" />
                        </td>
                    <td>
                        <asp:Button ID="Button2" runat="server" Text="See Prescriptions" />
                    </td>
                     <td>
                        <asp:Button ID="Button6" runat="server" Text="See Reciepts" />
                    </td>

                    <td>Hello
                        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
              
            </table>
            <asp:Label ID="Label2" runat="server" Text="My Approved Appointments"></asp:Label>
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
            <asp:Label ID="Label3" runat="server" Text="My Pending Appointments"></asp:Label>
            <asp:GridView ID="GridView2" runat="server"></asp:GridView>
        </div>
    </form>
</body>
</html>
