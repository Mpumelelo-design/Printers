<%@ Page Title="LogIn" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="CompanyPrinters.Contact" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
  
    <div>
        <table height="center" width="600px" border="0">
    <header> Welcome Admin </header>
            <tr>
                <td>
    <asp:Label  ID="LEmail" runat="server" Text="Email : "> </asp:Label>
            </td>

                <td>
    <asp:TextBox ID="Email" runat="server"/>
    </td>
    <td>
    <asp:Label ID="LPassword" runat="server" Text="Password : "></asp:Label>
        </td>
                <td>
    <asp:TextBox ID="Password" runat="server" />
                    </td>
                <td>
    <asp:Button ID="btnSubmit" runat="server" Text="Log In" OnClick="btnSubmit_Click" />
                    </td>
    </tr>
            </table>

            </div>
</asp:Content>
