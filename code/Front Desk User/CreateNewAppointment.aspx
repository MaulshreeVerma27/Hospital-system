<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateNewAppointment.aspx.cs" Inherits="HospitalSystem.CreateNewAppointment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 182px;
        }
        .auto-style2 {
            width: 191px;
        }
        .auto-style3 {
            width: 194px;
        }
        .auto-style4 {
            width: 195px;
        }
        .auto-style5 {
            width: 197px;
        }
        .auto-style6 {
            width: 202px;
        }
        .auto-style7 {
            width: 494px;
        }
        .auto-style8 {
            width: 380px;
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
                     <table class="auto-style8"  >
                      
                      <tr>
                      <td  colspan="2" style=" color:#7D0541; font-weight:bold; font-style:italic; font-size:larger;">Create New Appointment</td>
                      </tr>

                         <tr><td>&nbsp;</td>
                      </tr>

                      <tr style="background-color:#CEE3F6">
                      <td >Speciality</td>
                      <td class="auto-style7">
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
                      <td class="auto-style7">
                          <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
                          </asp:DropDownList>
                          </td>
                          <td>
                              <asp:GridView align="right" ID="GridView2" CssClass="Grid" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="ID" >
    <Columns>
        <asp:BoundField  DataField="ID" HeaderText="ID"/>
                    <asp:BoundField DataField="DocID" HeaderText="Doctor"/>
                    <asp:BoundField DataField="PID" HeaderText="PatientID"/>
                    <asp:BoundField DataField="starttime" HeaderText="time"/>
    </Columns>
                        </asp:GridView>
                          </td>
                          <td></td>
                          <td>
      <asp:GridView align="right" CssClass="Grid" ID="GridView3" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="ID" 
              >
                             <Columns>
        <asp:BoundField DataField="Id" HeaderText="Id"/>
                    <asp:BoundField DataField="DocId" HeaderText="Doctor"/>
                    <asp:BoundField DataField="start date" HeaderText="start date"/>
                    <asp:BoundField DataField="end date" HeaderText="end date"/>
                    <asp:BoundField DataField="starttime" HeaderText="start time"/>
                    <asp:BoundField DataField="endtime" HeaderText="end time"/>

    </Columns>
                        </asp:GridView>
                          </td>
                          
                      </tr>
                         <tr style="background-color:#CEE3F6">
                          <td>PatientId</td>
                         <td class="auto-style7">
                             <asp:DropDownList ID="DropDownList3" runat="server">
                          </asp:DropDownList>
                             </td>
                         </tr>
                         

                       <tr style="background-color:#CEE3F6"><td>
                           Date</td>
                      <td class="auto-style7">
                          <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                           </td>
                      </tr>

                       <tr style="background-color:#CEE3F6"><td>
                           Time</td>
                      <td class="auto-style7">
                          <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                           </td>
                      </tr>
              
                        
                      <tr style="background-color:#CEE3F6">
    <td >Reason</td>
    <td class="auto-style7"><asp:TextBox ID="RsnTxt" runat="server" TextMode="MultiLine" ></asp:TextBox>&nbsp;</td>
    </tr>

                    
                         <tr>
                     <td class="auto-style1" ></td>
                                <td class="auto-style7">
                                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Submit" />
                             </td>
                     
                    </tr>
                         <tr>
                     <td >&nbsp;</td>
                                <td class="auto-style7"><asp:Label ID="Label3" runat="server"></asp:Label></td>
                     
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
            <table id="customers" align="centre">
                <tr>
                <td class="auto-style2">
                </td>
                 
                     <td class="auto-style1">
                </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                         &nbsp;</td>
                    <td class="auto-style3">
                         &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">
                    </td>
                    <td class="auto-style5">
                         &nbsp;</td>
                    <td class="auto-style6">
                        
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">

                    </td>
                    <td class="auto-style3">

                    </td><td class="auto-style1">

                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        
                    </td>
                    <td class="auto-style3">

                    </td>
                    <td class="auto-style1">

                    </td>
                </tr>
                <tr>
                    <td class="auto-style2"></td>
                    <td class="auto-style3"></td>
                    <td class="auto-style1"></td>
                </tr>
                 <tr>
                    <td class="auto-style2">
                        
                    </td>
                    <td class="auto-style3">
                  
                    </td>
                    <td class="auto-style1">

                    </td>
                </tr>
                
                
            </table>
    
        </div>
    </form>
</body>
</html>
