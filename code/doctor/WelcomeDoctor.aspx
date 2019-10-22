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
  font-size: 16px;
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
  font-size: 17px;
}
.topnav td:hover {
  background-color: #ddd;
  color: black;
}

.topnav td.active {
  background-color: #4CAF50;
  color: black;
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
         <asp:Button ID="Button1" class="mybtn" runat="server" Text="View appointments" OnClick="Button1_Click1" style="height: 26px" /></td>
                    <td >
                        <asp:Button class="mybtn" ID="Button2" runat="server" Text="Apply For leave" OnClick="Button2_Click" Height="54px" Width="155px" />
                    </td>
                    <td >                                                             </td>
                    <td>
                        <asp:Button  class="mybtn" ID="Button3" runat="server" Text="Home" OnClick="Button3_Click" />
                        </td>
                     <td>
                        <asp:Button class="mybtn" ID="Button4" runat="server" Text="Logout" OnClick="Button4_Click" />
                        </td>
                        <td>
                        <asp:Button class="mybtn" ID="Button5" runat="server" Text="Change Password" OnClick="Button5_Click" />
                        </td>
                    <td>Hello
                        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                
              
            </table>
&nbsp;</div>
    </form>
</body>
</html>
