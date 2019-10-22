
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddDoc.aspx.cs" Inherits="Hospitalsystem.AddDoc" %>
<link href="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css">
<script src="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js"></script>
<script src="//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
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
            <table width="100%">
        <tr>
            <td align="center">
            <asp:Button ID="Button1" runat="server" Text="Home" OnClick="Button1_Click" />
                </td>
            </tr>
   </table>
   
    
    <table style=" width: 900px">
                        <tr>

                     <table align="center" style="width: 380px" cellspacing="5" cellpadding="7"  >
                     <tr>
                     <div class="row justify-content-center">
                    <div class="col-md-8">
                        <div class="card">
                            <div class="card-header">Add Doctor</div>
                    </tr>
          
                     
                     <table align="center" style="width: 380px" cellspacing="5" cellpadding="7"  >
                      
                      <tr>
                      <td  colspan="2" align="center" style=" font-weight:bold; font-style:italic; font-size:larger;">Add Doctor</td>
                      </tr>

                         <tr><td>&nbsp;</td>
                      </tr>

                      <tr>
                      <td align="right">First Name</td>
                      <td><asp:TextBox ID="nameTxt" runat="server" OnTextChanged="nameTxt_TextChanged"></asp:TextBox></td>
                      </tr>

                      <tr >
                      <td align="right">Last Name</td>
                      <td><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
                      </tr>

                       <tr ><td>
                           Age</td>
                      <td><asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td>
                      </tr>

                       <tr ><td>
                           Experience</td>
                      <td><asp:TextBox ID="TextBox4" runat="server"></asp:TextBox></td>
                      </tr>
              
                        
                          <tr>
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

                    
    <tr>
    <td align="right">Mobile_no.</td>
    <td><asp:TextBox ID="mobileTxt" runat="server"></asp:TextBox></td>
    </tr>
    
                   <tr>
                   <td align="right">Date_of_Birth</td>
                   <td>
                       <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </td>
    </tr>
    
                     <tr>
                     <td align="right">Speciality</td>
                     <td>&nbsp;<asp:DropDownList ID="spList" runat="server" Height="44px" Width="132px">
                        <asp:ListItem>--Select--</asp:ListItem>
                        <asp:ListItem>Cancer</asp:ListItem>
                        <asp:ListItem>Pediatrician</asp:ListItem>
                        <asp:ListItem>Neuro</asp:ListItem>
                        <asp:ListItem>ENT</asp:ListItem>
                    </asp:DropDownList></td>
                    </tr>
                         <tr>
                     <td align="right">EmpID</td>
                                <td><asp:Label ID="Label2" runat="server"></asp:Label></td>
                     
                    </tr>
                         <tr>
                     <td align="right">Your Password</td>
                                <td><asp:Label ID="Label3" runat="server"></asp:Label></td>
                     
                    </tr>

    <tr>
    <td colspan="2" align="center">
        <br />
        
&nbsp;
        <br />
        <asp:Button ID="submitBtn" runat="server" Text="Submit" OnClick="submitBtn_Click" />
        <br />
        <asp:Label ID="Label1" runat="server"></asp:Label>
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
