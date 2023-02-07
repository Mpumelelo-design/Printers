<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminPage.aspx.cs" Inherits="CompanyPrinters.AdminPage" %>

<!DOCTYPE html>

                   
             
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Admin</title>
    <style>

        .ParentMenu, .ParentMenu:hover {  
            width: 100px;  
            background-color: #fff;  
            color: #333;  
            text-align: center;  
            height: 30px;  
            line-height: 30px;  
            margin-right: 5px;  
        }  
  
            .ParentMenu:hover {  
                background-color: #ccc;  
            }  
  
        .ChildMenu, .ChildMenu:hover {  
            width: 110px;  
            background-color: #fff;  
            color: #333;  
            text-align: center;  
            height: 30px;  
            line-height: 30px;  
            margin-top: 5px;  
        }  
  
            .ChildMenu:hover {  
                background-color: #ccc;  
            }  
  
        .selected, .selected:hover {  
            background-color: #A6A6A6 !important;  
            color: #fff;  
        }  
  
        .level2 {  
            background-color: #fff;  
        }  

        img {
            position:absolute;
            z-index:-1; 
            width:1596px;
            height:1345px;
        }

        h1 {
            align-content:center;
        }

        div {
            display:flex;
            justify-content:center;
            align-items:center;
        }

    </style>
</head>

<body>
    <header>Welcome Admin</header>
    
   <div >
       <img src="Admin_bg.jpg" alt="relative" />
    <form id="form1" runat="server">
        <asp:Menu ID="Menu1" runat="server" Orientation="Horizontal">  
                <LevelMenuItemStyles>  
                    <asp:MenuItemStyle CssClass="ParentMenu" />  
                    <asp:MenuItemStyle CssClass="ChildMenu" />  
                    <asp:MenuItemStyle CssClass="ChildMenu" />  
                </LevelMenuItemStyles>  
                <StaticSelectedStyle CssClass="selected" />  
            </asp:Menu>  
      
        <table width="900px" border="0">
            <tr>
                <td>
        <asp:Label ID="FName" runat="server" Text="First Name :" ></asp:Label>
                
    <asp:TextBox ID="FirstName" runat="server"/>
                </td>
                </tr>
         </table>
               <table width="900px" border="0">
            <tr>
                <td>
    <asp:Label  ID="Emails" runat="server" Text="Emails :"></asp:Label>
                
    <asp:TextBox ID="Email" runat="server"/>
                    </td>
                </tr>
               </table>
          
                    <table width="900px" border="0">
            <tr>
                <td>
    <asp:Label ID="LName" runat="server" Text="Last Name:"></asp:Label>
    <asp:TextBox ID="LastName" runat="server" />
                    </td>
                </tr>
            </table>
        <table width="900px" border="0">
            <tr>
                <td>
                
    <asp:Label ID="LAddress" runat="server" Text="Address :"></asp:Label>
    <asp:TextBox ID="txtAddress" runat="server" />
                    </td>
                </tr>
                </table>
            
                <table width="900px" border="0">
            <tr>
                <td>
    <asp:Label  ID="LDesignation" runat="server" Text="Designation :"> </asp:Label>
    <asp:TextBox ID="txtDesignation" runat="server"/>
                    </td>
                </tr>
                    </table>
                <table width="900px" border="0">
            <tr>
                <td>
    <asp:Label ID="LPassword" runat="server" Text="Password :"></asp:Label>
    <asp:TextBox ID="Password" runat="server" />
                    </td>
                </tr>
                    </table>

         <table width="900px" border="0">
            <tr>
                <td>
    <asp:Label ID="DateOfBirth" runat="server" Text="DOB :"></asp:Label>
    <asp:TextBox ID="DOB" runat="server" />
                    </td>
                </tr>
                    </table>
        <table width="900px" border="0">
            <tr>
                <td>
        <asp:Button ID="btnCreate" runat="server" Text="Create"  OnClick="btnCreate_Click"/>

<asp:Button ID="btnDelete" runat="server" Text="Delete" OnClientClick="return ConfirmDelete();"  
            OnClick="btnDelete_Click" />

                </td>
                </tr>
            </table>
            
                
<%--                <asp:GridView ID="Grid_Users" runat="server"></asp:GridView>--%>

        <asp:GridView ID="Grid_Users" runat="server" AutoGenerateColumns="True" Font-Names="Arial"  
            Font-Size="11pt" AlternatingRowStyle-BackColor="#C2D69B" HeaderStyle-BackColor="green"  
            AllowPaging="True" OnPageIndexChanging="OnPaging" DataKeyNames="Email" CellPadding="4"  
            ForeColor="#333333" GridLines="None">  
            <Columns>  
                <asp:TemplateField>  
                    <HeaderTemplate>  
                        <asp:Label runat="server" Text="Delete All "></asp:Label>  
                        <asp:CheckBox ID="chkAll" runat="server" onclick="checkAll(this);" />  
                    </HeaderTemplate>  
                    <ItemTemplate>  
                        <asp:CheckBox ID="chk" runat="server" onclick="Check_Click(this)" />  
                    </ItemTemplate>  
                </asp:TemplateField>  
            </Columns>  
            <AlternatingRowStyle BackColor="White" />  
            <EditRowStyle BackColor="#7C6F57" />  
            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />  
            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White"></HeaderStyle>  
            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />  
            <RowStyle BackColor="#E3EAEB" />  
            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />  
            <SortedAscendingCellStyle BackColor="#F8FAFA" />  
            <SortedAscendingHeaderStyle BackColor="#246B61" />  
            <SortedDescendingCellStyle BackColor="#D4DFE1" />  
            <SortedDescendingHeaderStyle BackColor="#15524A" />  
        </asp:GridView>  
        <asp:HiddenField ID="hdncnt" runat="server" Value="0" />  

        
        
       </form>
     </div>
</body>
</html>
