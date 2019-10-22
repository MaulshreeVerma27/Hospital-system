<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Loginpage2.aspx.cs" Inherits="HospitalSystem.Loginpage2" %>
<link href="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css">
<script src="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js"></script>
<script src="//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>

<!DOCTYPE html>
<head>
    <style>
        body {
  background: url(bg2.jpg);
  background-repeat: no-repeat;
    background-size: 100% 100%;
  object-fit:cover;
  
}
        

    </style>
</head>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head>
        <style>
            .button1 {width: 250px;}
        </style>
    </head>

<body >
     <tr>
                     
 

    <form id="form1" runat="server">
        <div>
            <style type="text/css">
        .auto-style1 {
            width: 194px;
        }
        .auto-style2 {
            width: 242px;
        }
    </style>
          <table align="center" style="width: 380px" cellspacing="5" cellpadding="7"  >
  
                     <tr>
                     <div class="row justify-content-center">
                    <div class="col-md-8">
                        <div class="card">
                            <div class="card-header" fon>Login</div>
                    </tr>
        <tr>
            <br><br><br><br><br><br>
               <td  >&nbsp;</td>
            <td> Login </td>
            <td>
                <asp:TextBox ID="loginTextBox" runat="server" OnTextChanged="loginTextBox_TextChanged"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style1">Password</td>
            <td>
                <asp:TextBox ID="passTextBox" runat="server" OnTextChanged="passTextBox_TextChanged"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style2">
                <asp:Button class="btn btn-primary btn-lg btn-block login-button" ID="Button1" runat="server" OnClick="Button1_Click" Text="Login" Width="150px" />
            </td>
            <td>
                <asp:Button class="btn btn-primary btn-lg btn-block login-button" ID="Button2" runat="server" OnClick="Button2_Click" Text="Change password" Width="180px" />
            </td>
            <td>
                <asp:Button class="btn btn-primary btn-lg btn-block login-button" ID="Button3" runat="server" Text="Home" OnClick="Button3_Click" Width="98px" />
            </td>

        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style2">
                <asp:Label ID="Label1" runat="server"></asp:Label>
                </td><td>
                <asp:Label ID="Label2" runat="server"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
        </div>
    </form>
</body>
</html>
