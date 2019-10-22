<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="HospitalSystem.Register" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Register Page</title>
    
    <link href="StyleSheet5.css" rel="Stylesheet" type="text/css" />
    
    <style type="text/css">
        .style1
        {
            background-repeat: no-repeat;
            background-position: center;
            height: 683px;
        }
        .auto-style1 {
            width: 505px;
        }
        .auto-style2 {
            height: 78px;
        }
        .auto-style3 {
            width: 505px;
            height: 78px;
        }
    </style>
    
</head>
<body style="background-image:url(Images/background_image.jpg)">
    <form id="form2" runat="server">
    <div>
    <table width="100%">
        <tr>
            <td align="center">
            <asp:Button ID="Button1" runat="server" Text="Home" OnClick="Button1_Click" />
                </td>
            </tr>
    <tr><td align="center">
    
   <table width="75%" style=" top:50px">
   <tr>
   <td style="background-color:#f2f2f2" align="center" colspan="2">
    
    <table style="background-color: #f2f2f2; width: 900px">
                        
                    <tr>
                     <td align="center" class="style1" style="background-image: url('images/Light-Blue-HD-Backgrounds-Free-Download.jpg'); ">
                     
                     <table style="width: 380px" cellspacing="5" cellpadding="7"  >
                      
                      <tr>
                      <td  colspan="2" align="center" style=" color:#7D0541; font-weight:bold; font-style:italic; font-size:larger;">Register Your self........ </td>
                      </tr>

                      <tr style="background-color:#CEE3F6">
                      <td align="right">First Name</td>
                      <td class="auto-style1"><asp:TextBox ID="nameTxt" runat="server"></asp:TextBox></td>
                          <td>
                              <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="First Name Empty" ControlToValidate="nameTxt"></asp:RequiredFieldValidator>
                          </td>
                    </tr>
                      
                      <tr>
                      <td align="right">Last name</td>
                      <td class="auto-style1"><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
                          <td>
                              <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="RequiredField" ControlToValidate="TextBox2"></asp:RequiredFieldValidator>
                          </td>
                      </tr>
                      
                      <tr>
                      <td align="right">Age</td>
                      <td class="auto-style1"><asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td>
                          <td>
                              <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="RequiredField" ControlToValidate="TextBox3"></asp:RequiredFieldValidator>
                          </td>
                      </tr>
                    <tr>
                   <td align="right" class="auto-style2">Date_of_Birth</td>
                   <td class="auto-style3">
                       <asp:TextBox ID="TextBox4" runat="server" ReadOnly="False"></asp:TextBox><br />
                   </td>
                        <td class="auto-style2">
                        <br />
                            
                        </td>
                   </tr>
                       <tr>
                         <td align="right">E-mail</td>
                        <td class="auto-style1"><asp:TextBox ID="emailTxt" runat="server"></asp:TextBox></td>
                           <td>
                               <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="invalid email address" ControlToValidate="emailTxt" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                               <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="RequiredField" ControlToValidate="emailTxt"></asp:RequiredFieldValidator>
                           </td>
                         </tr>
            
                         
                          <tr style="background-color:#CEE3F6">
                        <td align="right">Gender</td>
                         <td class="auto-style1">
                             <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                                 <asp:ListItem>male</asp:ListItem>
                                 <asp:ListItem>Female</asp:ListItem>
                             </asp:RadioButtonList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                             </td>
                              <td>
                                  <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="RequiredField" ControlToValidate="RadioButtonList1"></asp:RequiredFieldValidator>
                              </td>
                        </tr>

                      <tr>
    <td align="right">Address</td>
    <td class="auto-style1"><asp:TextBox ID="addressTxt" runat="server"></asp:TextBox></td>
                          <td>
                              <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="RequiredField" ControlToValidate="addressTxt"></asp:RequiredFieldValidator>
                          </td>
    </tr>

                    
    <tr style="background-color:#CEE3F6">
    <td align="right">Mobile_no.</td>
    <td class="auto-style1"><asp:TextBox ID="mobileTxt" runat="server"></asp:TextBox></td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="mobileTxt" ErrorMessage="RequiredField"></asp:RequiredFieldValidator>
        </td>
    </tr>
                         <tr>
                     <td align="right">PatientID</td>
                                <td class="auto-style1"><asp:Label ID="Label3" runat="server"></asp:Label></td>
                             
                     
                    </tr>
                         <tr>
                     <td align="right">Your Password</td>
                                <td class="auto-style1"><asp:Label ID="Label4" runat="server"></asp:Label></td>
                             
                     
                    </tr>
                                               
    


   

    <tr>
    <td colspan="2" align="center">
        <br />
        <asp:CheckBox ID="CheckBox1" runat="server" Text="I accept terms and conditions" />
&nbsp;
        <br />
        <asp:Button ID="submitBtn" runat="server" Text="Submit" OnClick="submitBtn_Click" />
        <br />
        <asp:Label ID="Label2" runat="server"></asp:Label><br>
        <asp:Label ID="Label1" runat="server"></asp:Label></br>
        </td>
    </tr>

    </table>
    </td>
    </tr>

   </table>
    
    </td>
    </tr>
    
    <tr>
    <td style="background-image:url(images/075.jpg); color:#FFF8C6; font-weight:bold" align="center" colspan="2">

        &nbsp;</td>
    </tr>
    
    </table>

</td></tr>
    </table>
    </div>
    </form>
</body>
</html>



