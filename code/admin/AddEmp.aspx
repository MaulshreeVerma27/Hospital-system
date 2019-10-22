<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddEmp.aspx.cs" Inherits="HospitalSystem.AddEmp" %>
<link href="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css">
<script src="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js"></script>
<script src="//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add Employee</title>
    <style>
        body {
            background: url(bg4.jpg);
            background-repeat: no-repeat;
            background-size: 100% 100%;
            object-fit: cover;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
        <tr>
            <td align="center">
                &nbsp;</td>
            </tr>
   </table>
   
    
    <table style="background-color: #f2f2f2; width: 900px">
                        
                    <tr>

                     <table align="center" style="width: 380px" cellspacing="5" cellpadding="7"  >
                     <tr>
                     <div class="row justify-content-center">
                    <div class="col-md-8">
                        <div class="card">
                            <div class="card-header">Add Employee</div>
                    </tr>
                                   <tr>
                     <td align="center" class="style1" style="background-image: url('BG'); ">
                         </tr>

                      <tr >
                    <div class="form-group">
                      <td for="name" class="cols-sm-2 control-label"  align="right">First Name</td>
                        <div class="input-group">
                             <span class="input-group-addon"><i class="fa fa-user fa" aria-hidden="true"></i></span>
                      <td><asp:TextBox ID="nameTxt" runat="server" OnTextChanged="nameTxt_TextChanged"></asp:TextBox></td>
                          </div>
                      </tr>

                       <tr >
                      <td align="right"> Last Name</td>
                      <td><asp:TextBox ID="TextBox2" runat="server" OnTextChanged="nameTxt_TextChanged"></asp:TextBox></td>
                      </tr>

                      <tr ><td>
                           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Age</td>
                      <td><asp:TextBox ID="TextBox3" runat="server" OnTextChanged="nameTxt_TextChanged"></asp:TextBox></td>
                      </tr>
                       <tr>
                         <td align="right">Phone Number</td>
                        <td><asp:TextBox ID="emailTxt" runat="server" OnTextChanged="emailTxt_TextChanged"></asp:TextBox></td>
                         </tr>
                         
                          <tr >
                        <td align="right">Gender</td>
                         <td>
                             <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                                 <asp:ListItem>male</asp:ListItem>
                                 <asp:ListItem>Female</asp:ListItem>
                             </asp:RadioButtonList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                             </td>
                        </tr>

                      <tr>
    <td align="right">Address</td>
    <td><asp:TextBox ID="addressTxt" runat="server"></asp:TextBox></td>
    </tr>

    
                   <tr><td>
        Date of Birth</td>
                   <td>
                       <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </td>
    </tr>
    
                     <tr>
                     <td align="right">Joining Date</td>
                     <td>
                         <asp:Label ID="Label4" runat="server" Text=""></asp:Label>
                         </td>
                    </tr>
                         <tr>
                     <td align="right">EmpID      <td align="right"></td>
                                <td><asp:Label ID="Label2" runat="server"></asp:Label></td>
                     
                    </tr>
                         <tr>
                     <td align="right">Your Password</td>
                              <td>  <asp:Label ID="Label3" runat="server"></asp:Label></td>
                     
                    </tr>

    <tr>
    <td colspan="2" align="center">
        <br />
        
&nbsp;
        <br />
        <asp:Button  class="btn btn-primary btn-lg btn-block login-button" ID="submitBtn" runat="server" Text="Submit" OnClick="submitBtn_Click" />
        <br />
        <asp:Label ID="Label1" runat="server"></asp:Label>
        </td>
    </tr>

    <tr>
    <td colspan="2" align="center">
     
        
&nbsp;
                   <asp:Button class="btn btn-primary btn-lg btn-block login-button" ID="Button1" runat="server" Text="Home" OnClick="Button1_Click" />

       
        <asp:Label ID="Label5" runat="server"></asp:Label>
        </td>
    </tr>



    </table>
    </td>
    </tr>

   </table>
    
   
       

        </div>
    </form>
</body>
</html>

