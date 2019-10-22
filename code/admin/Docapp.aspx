<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Docapp.aspx.cs" Inherits="HospitalSystem.Docapp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button2" runat="server" Text="Home" OnClick="Button2_Click" /><asp:Button ID="Button3" runat="server" Text="MyPortal" OnClick="Button3_Click" />
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="ID" 
                OnPageIndexChanging="GridView1_PageIndexChanging" OnRowDeleting="GridView1_RowDeleting" OnRowCommand="GridView1_RowCommand" pagesize="3" Width="438px" >
                <columns>
                    <asp:BoundField DataField="ID" HeaderText="ID"/>
                    <asp:BoundField DataField="DocID" HeaderText="Doctor"/>
                    <asp:BoundField DataField="PID" HeaderText="PatientID"/>
                    <asp:BoundField DataField="starttime" HeaderText="time"/>
                    <asp:CommandField ShowDeleteButton="True" ButtonType="Button" />
                    
                    <asp:TemplateField HeaderText="ApppointmentCompleted">
                        <ItemTemplate>
                            <asp:CheckBox ID="CheckBox1" runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    
                    </columns>
            </asp:GridView>
            <asp:Button ID="Button1" runat="server" Text="Mark as Completed" OnClick="Button1_Click" />

            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
