<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WelcomeDoctor.aspx.cs" Inherits="HospitalSystem.WelcomeDoctor" %>
<link href="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css">
<script src="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js"></script>
<script src="//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <head>
<meta name="viewport" content="width=device-width, initial-scale=1">
<style>

    .mybtn
{  background-color: lightblue;
  border: none;
  color: white;
  padding: 15px 32px;
  text-align: center;
  text-decoration: none;
  display: inline-block;
  font-size: 10px;
  margin: 4px 2px;
  cursor: pointer;


   //some more styles
}
body {
  margin: 0;
  font-family: Arial, Helvetica,sans-serif;
}
.topnav {
  overflow: hidden;
  background-color: lightblue;
}
.topnav tr {
  float: left;
  color: black;
  text-align: center;
  padding: 14px 16px;
  text-decoration: none;
  font-size: 10px;
}
.topnav td:hover {
  background-color: #ddd;
  color: black;
}

.topnav td.active {
  background-color: #4CAF50;
  color: black;
}
    .auto-style1 {
        width: 125px;
    }
</style>
</head>
</head>
<body background="bg6.jpg">
    <form id="form1" runat="server">
        <div>
            <table class="topnav" align="centre" runat="server">
                
                <tr>
     <td>
         <asp:Button ID="Button1" class="mybtn" runat="server" Text="View appointments" OnClick="Button1_Click1" Width="199px" /></td>
                    <td >  <asp:Button class="mybtn" ID="Button6" runat="server" Text="Add Prescription" Height="54px" Width="184px" OnClick="Button6_Click" /></td>
                    <td >
                        <asp:Button class="mybtn" ID="Button2" runat="server" Text="Apply For leave" OnClick="Button2_Click" Height="54px" Width="173px" />
                    </td>
                    
                    <td>
                        <asp:Button  class="mybtn" ID="Button3" runat="server" Text="Home" OnClick="Button3_Click" Width="111px" />
                        </td>
                     <td class="auto-style1">
                        <asp:Button class="mybtn" ID="Button4" runat="server" Text="Logout" OnClick="Button4_Click" />
                        </td>
                        <td>
                        <asp:Button class="mybtn" ID="Button5" runat="server" Text="Change Password" OnClick="Button5_Click" Width="223px" />
                        </td>
                    <td>Hello
                        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                
              
            </table>
&nbsp;</div>

        <div>
           <table id="table2" >
               <tr>
                   <td>
                       <asp:Label ID="Label4" runat="server" Text="Select the patient Id" Visible="False"></asp:Label>
                       <br />
                       <asp:DropDownList ID="DropDownList1" runat="server" Visible="False" ></asp:DropDownList>
                       <br />
                       <asp:FileUpload ID="FileUpload1" runat="server" Visible="False" />
                       <br />
                       <asp:Button ID="Button7" runat="server" Text="Submit" OnClick="Button7_Click" Visible="False" />
                       <br />
                       <asp:Label ID="Label5" runat="server" Text=""></asp:Label>
                   </td>
                   <td>
                       <asp:Label ID="Label2" runat="server" Text="Select the number of days" Visible="False"></asp:Label>
                       <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged" Visible="False">
                            <asp:ListItem>Half Day</asp:ListItem>
                            <asp:ListItem>1 Day</asp:ListItem>
                            <asp:ListItem>Greater than 1</asp:ListItem>
                       </asp:RadioButtonList>
                   </td>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
                        <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged" Visible="False"></asp:Calendar>
                   </td>
                   <td>
                        <asp:Label ID="Label6" runat="server" Text=""></asp:Label>
                        <asp:Calendar ID="Calendar2" runat="server" OnSelectionChanged="Calendar2_SelectionChanged" Visible="False">
                        
                        </asp:Calendar>
                   </td>
                   </tr>
               <tr>
                   <td>

                   </td>
                    <td>

                   </td>
                    <td>
                        <asp:Label ID="Label7" runat="server" Text="Select the half of the day" Visible="False"></asp:Label>
                        <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="true" Visible="False">
                            <asp:ListItem Selected="True">---Select----</asp:ListItem>
                        <asp:ListItem>1pm-5pm</asp:ListItem>
                            <asp:ListItem>8am-12pm</asp:ListItem>
                        </asp:DropDownList>
                   </td>
               </tr>
               <tr>
                   <td>

                   </td>
                   <td>

                   </td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" Visible="False" ReadOnly="True"></asp:TextBox>
                   </td>
                    <td>
                    <asp:TextBox ID="TextBox2" runat="server" ReadOnly="True" Visible="False"></asp:TextBox>
                   </td>
               </tr>
               <tr>
                   <td></td>
                   <td></td>
                   <td>
                       <asp:Button ID="Button8" runat="server" Text="Submit Leaves" Visible="False" OnClick="Button8_Click" /></td>
               </tr>

           </table>
            </div>
    </form>
</body>
</html>
