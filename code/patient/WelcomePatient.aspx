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
                        <asp:Button ID="Button3" runat="server" Text="Home" OnClick="Button3_Click" />
                        </td>
                     <td>
                        <asp:Button ID="Button4" runat="server" Text="Logout" OnClick="Button4_Click" />
                        </td>
                        <td>
                        <asp:Button ID="Button5" runat="server" Text="Change Password" OnClick="Button5_Click" />
                        </td>
                    <td>
                        <asp:Button ID="Button2" runat="server" Text="See Prescriptions" OnClick="Button2_Click" />
                    </td>
                     <td>
                        <asp:Button ID="Button6" runat="server" Text="See Reciepts" OnClick="Button6_Click" />
                    </td>

                    <td>Hello
                        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                    </td>
                     <td>
                         <asp:Image ID="Image1" runat="server" Height="100px" Width="100px"/>
                    </td>
                </tr>
              
            </table>
            <table>
<tr>
    <td>
        <asp:Label ID="Label2" runat="server" Text="My Approved Appointments"></asp:Label>
            <br />
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="ID" pagesize="3">
                <columns>
                <asp:BoundField DataField="ID" HeaderText="ID"/>
                    <asp:BoundField DataField="DocID" HeaderText="Doctor"/>
                    <asp:BoundField DataField="PID" HeaderText="PatientID"/>
                    <asp:BoundField DataField="starttime" HeaderText="time"/>
                    </columns>
            </asp:GridView>
    </td>
    <td>
        </td>
    <td>
        <asp:GridView ID="GridView3" runat="server" Visible="False" AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="Id" pagesize="1">
            <columns>
                <asp:BoundField DataField="Id" HeaderText="ID"/>
                    <asp:BoundField DataField="DocId" HeaderText="Doctor"/>
                    <asp:BoundField DataField="Ptid" HeaderText="PatientID"/>
                    <asp:BoundField DataField="Day" HeaderText="Time"/>
                    <asp:ImageField DataImageUrlField="Image" HeaderText="Prescription">
                        <ItemStyle HorizontalAlign="Center" />
                </asp:ImageField>
                    </columns>
        </asp:GridView>
    </td>
    <td>
        <asp:GridView ID="GridView4" runat="server" Visible="False" AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="Id" pagesize="1">
            <columns>
                <asp:BoundField DataField="Id" HeaderText="ID"/>
                    <asp:BoundField DataField="EmployeeId" HeaderText="Employee"/>
                    <asp:BoundField DataField="PatientId" HeaderText="PatientID"/>
                    <asp:BoundField DataField="Day" HeaderText="Time"/>
                    <asp:ImageField DataImageUrlField="Image" HeaderText="Receipt">
                        <ItemStyle HorizontalAlign="Center" />
                </asp:ImageField>
                    </columns>
        </asp:GridView>
    </td>
    
</tr>
            </table>
            
            <asp:Label ID="Label3" runat="server" Text="My Pending Appointments"></asp:Label>
            <asp:GridView ID="GridView2" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="ID" pagesize="3">
                <columns>
                <asp:BoundField DataField="ID" HeaderText="ID"/>
                    <asp:BoundField DataField="DocID" HeaderText="Doctor"/>
                    <asp:BoundField DataField="PID" HeaderText="PatientID"/>
                    <asp:BoundField DataField="starttime" HeaderText="time"/>
                    </columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
