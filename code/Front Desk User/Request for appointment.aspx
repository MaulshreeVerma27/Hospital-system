<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Request for appointment.aspx.cs" Inherits="Hospitalsystem.Request_for_appointment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <table align="center" width="100%">
        <tr>
            <td align="center">
            <asp:Button ID="Button1" runat="server" Text="Home" OnClick="Button1_Click" />
                </td>
            <td>
                <asp:Button ID="Button3" runat="server" Text="My Portal" OnClick="Button3_Click" /></td>
            </tr>
   </table>
   
                       
          
                     
                     <table style="width: 380px"  >
                      
                      <tr>
                      <td  colspan="2" style=" color:#7D0541; font-weight:bold; font-style:italic; font-size:larger;">Request For Appointment</td>
                      </tr>

                         <tr><td>&nbsp;</td>
                      </tr>

                      <tr style="background-color:#CEE3F6">
                      <td >Speciality</td>
                      <td>
                          <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="True">
                        <asp:ListItem>--Select--</asp:ListItem>
                        <asp:ListItem>Cancer</asp:ListItem>
                        <asp:ListItem>Pediatrician</asp:ListItem>
                        <asp:ListItem>Neuro</asp:ListItem>
                        <asp:ListItem>ENT</asp:ListItem>
                    </asp:DropDownList></td>

                          
                          

                      </tr>

                      <tr style="background-color:#CEE3F6">
                      <td >Doctor</td>
                      <td>
                          <asp:DropDownList ID="DropDownList2" runat="server">
                          </asp:DropDownList>
                          </td>
                      </tr>

                       <tr style="background-color:#CEE3F6"><td>
                           Date</td>
                      <td>
                          <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                           </td>
                      </tr>

                       <tr style="background-color:#CEE3F6"><td>
                           Time</td>
                      <td>
                          <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                           </td>
                      </tr>
              
                        
                      <tr>
    <td >Reason</td>
    <td><asp:TextBox ID="RsnTxt" runat="server" TextMode="MultiLine" ></asp:TextBox></td>
    </tr>

                    
                         <tr>
                     <td class="auto-style1" ></td>
                                <td class="auto-style1">
                                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Submit" />
                             </td>
                     
                    </tr>
                         <tr>
                     <td >&nbsp;</td>
                                <td><asp:Label ID="Label3" runat="server"></asp:Label></td>
                     
                    </tr>

    <tr>
    <td colspan="2 >
        <br />
        
&nbsp;
        <br />
  
        <br />
        <asp:Label ID="Label1" runat="server"></asp:Label>
        </td>
    </tr>

    </table>
    

   </table>
    

        </div>
    </form>
</body>
</html>
