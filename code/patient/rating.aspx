<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="rating.aspx.cs" Inherits="HospitalSystem.rating" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajaxToolkit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 120px;
        }

       .starempty
        {
            background-image:url(images/starem.png);
               width: 32px;
               height: 32px;
        }
       .starfilled
        {
            background-image: url(images/starf.png);
            width: 32px;
            height: 32px;
        }
        .starwaiting {
            background-image: url(images/starwt.png);
              width: 32px;
            height: 32px;
        }

        .auto-style3 {
            width: 120px;
            height: 187px;
        }
        .auto-style4 {
            height: 187px;
        }
        .auto-style5 {
            width: 432px;
        }
        .auto-style6 {
            height: 187px;
            width: 432px;
        }

    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>

       

            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
            <br />
            <br />
            
       

            <table class="auto-style1">
                <tr>
                    <td>
                        <asp:Button ID="Button2" runat="server" Text="MyPortal" OnClick="Button2_Click" /></td>
                    <td>
                        <asp:Button ID="Button3" runat="server" Text="Home" OnClick="Button3_Click" /></td>
                </tr>
                <tr>
                    <td class="auto-style2">select doctor id</td>
                    <td class="auto-style5">
                        <asp:DropDownList ID="DropDownList1" runat="server">
                            <asp:ListItem>
                                -select-
                            </asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">your rating</td>
                    <td class="auto-style6">
                        
   <ajaxToolkit:Rating ID="Rating1" runat="server" CurrentRating="1" MaxRating="5" AutoPostBack="true" StarCssClass="starempty" FilledStarCssClass="starfilled" EmptyStarCssClass="starempty" WaitingStarCssClass="starwaiting" OnChanged="Rating1_Changed">
                        </ajaxToolkit:Rating>
                        
                    </td>
                    <td class="auto-style4">
                        <asp:Label ID="lbl_rating" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Give feedback</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="TextBox1" runat="server" TextMode="MultiLine"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style5">
                        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
                    </td>
                    <td>
                        <asp:Label ID="lbl_msg" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
            </table>
            
       

        </div>
    </form>
</body>
</html>
