<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Viewourdoctors.aspx.cs" Inherits="HospitalSystem.Viewourdoctors" %>

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
                    <td> </td>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="select speciality"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged1">
                            <asp:ListItem>--Select--</asp:ListItem>
                        <asp:ListItem>Cancer</asp:ListItem>
                        <asp:ListItem>Pediatrician</asp:ListItem>
                        <asp:ListItem>Neuro</asp:ListItem>
                        <asp:ListItem>ENT</asp:ListItem>
                        </asp:DropDownList>   
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Select Doctor" Visible="False"></asp:Label> </td>
                    <td>
                        <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged" Visible="False"></asp:DropDownList>
                    </td>
                    <td> 
                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Visible="False" CellPadding="4" ForeColor="#333333" GridLines="None" AllowPaging="True" DataKeyNames="ID" >
                            <AlternatingRowStyle BackColor="White" />
                            <Columns>
                    <asp:BoundField  DataField="Id" HeaderText="ID"/>
                    <asp:BoundField DataField="DocID" HeaderText="Doctor"/>
                    <asp:BoundField DataField="PtId" HeaderText="Patient"/>
                    <asp:BoundField DataField="Star" HeaderText="Rating"/>
                    <asp:BoundField DataField="Reviews" HeaderText="Reviews"/>
                    <asp:BoundField DataField="Timing" HeaderText="Date"/>


    </Columns>
                            <EditRowStyle BackColor="#7C6F57" />
                            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                            <RowStyle BackColor="#E3EAEB" />
                            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                            <SortedAscendingCellStyle BackColor="#F8FAFA" />
                            <SortedAscendingHeaderStyle BackColor="#246B61" />
                            <SortedDescendingCellStyle BackColor="#D4DFE1" />
                            <SortedDescendingHeaderStyle BackColor="#15524A" />
                        </asp:GridView>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
