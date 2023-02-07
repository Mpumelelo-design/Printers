<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="CompanyPrinters.Registation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Register</title>
    <style>
         img {
            position:absolute;
            z-index:-1; 
            width:1596px;
            height:1345px;
        }

        body{
            display:flex;
            justify-content:center;
            align-items:center;
        }

    </style>

</head>
<body>
        <img src="Register.jpg" alt="" />

        <form id="form1" runat="server">

            <header>    Welcome New User</header>

             <table class="auto-style1">  
                <tr>  
                    <td>First Name :</td>  
                    <td>  
    <asp:TextBox ID="U_fname" runat="server"></asp:TextBox>

                         </td>  
  
               </tr>  
                <tr>  
                    <td>Last Name :</td>  
                    <td>
    <asp:TextBox ID="U_lname" runat="server"></asp:TextBox>

                     </td>  
  
               </tr>  
                <tr>  
                    <td>Email :</td>  
                    <td>
    <asp:TextBox ID="U_EMAIL" runat="server"></asp:TextBox>

                     </td>  
  
               </tr>  
                <tr>  
                    <td>Address :</td>  
                    <td>
    <asp:TextBox ID="U_address" runat="server"></asp:TextBox>

                     </td>  
  
               </tr>  
                <tr>  
                    <td>Date Of Birth :</td>  
                    <td>
    <asp:TextBox ID="U_birthday" runat="server"></asp:TextBox>


                     </td>  
  
               </tr>  
                <tr>  
                    <td>Password :</td>  
                    <td>
    <asp:TextBox ID="U_password" runat="server"></asp:TextBox>


                     </td>  
  
               </tr>  
                <tr>  
                    <td>Designation</td>  
                    <td>
    <asp:TextBox ID="U_designstion" runat="server"></asp:TextBox>

                     </td>  
                </tr>  
                <tr>  
                    <td>  
                        <asp:Button ID="btnRegister" runat="server"  Text="Register" OnClick="Register_Click"/>
                    </td>  
                </tr>  
            </table> 

        <div>
        </div>
    </form>
</body>
</html>
