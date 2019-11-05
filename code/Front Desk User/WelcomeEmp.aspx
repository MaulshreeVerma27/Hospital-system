<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WelcomeEmp.aspx.cs" Inherits="HospitalSystem.WelcomeEmp" %>
<link href="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css">
<script src="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js"></script>
<script src="//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>

    .mybtn
{  background-color: lightblue;
  border: none;
  color: white;
  padding: 15px 32px;
  text-align: center;
  text-decoration: none;
 display: inline-block;
  font-size: 12px;
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
  width:100%;
}
.topnav tr {
  float: left;
  color: black;
  text-align: center;
  padding: 14px 10px;
  text-decoration: none;
  font-size: 12px;
  width:100%
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
<body background="bg6.jpg">
    <form id="form1" runat="server">   
        <div>
            <table class="topnav"  align="centre" runat="server">
                <tr>
     <td>
         <asp:Button ID="Button1" class="mybtn" runat="server" Text="View appointments" OnClick="Button1_Click" /></td>
                    <td>
                        <asp:Button ID="Button2" class="mybtn" runat="server" Text="Upload Receipt" OnClick="Button2_Click" />    
                    </td>
                    <td>
                        <asp:Button class="mybtn" ID="Button3" runat="server" Text="Home" OnClick="Button3_Click" />
                        </td>
                     <td>
                        <asp:Button class="mybtn" ID="Button4" runat="server" Text="Logout" OnClick="Button4_Click" />
                        </td>
                        <td>
                        <asp:Button class="mybtn" ID="Button5" runat="server" Text="Change Password" />
                        </td>
                    <td>Hello
                        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
              
            </table>
            <table>
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
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
