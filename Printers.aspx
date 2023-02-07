<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Printers.aspx.cs" Inherits="CompanyPrinters.Printers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> Printers</title>

    <style>

        div {
            display: flex;
            justify-content: center;
            align-items: center;
        }
       
        div1 {
            display: flex;
            justify-content: center;
            align-items: center;
        }

    </style>

</head>


<body>

        <h1>Printers</h1>

    <form id="form1" runat="server">

    <div>
        <table width="900px" border="0">
            <tr>
                <td>
        <asp:Label ID="PM" runat="server" Text="Printer Maker :" ></asp:Label>
        
    <asp:TextBox ID="PrinterMaker" runat="server"/>
                </td>
                </tr>
         </table>
         <table width="900px" border="0">
            <tr>
                <td>
    <asp:Label  ID="TimeStampFrom" runat="server" Text="Create TimeStamp From :"></asp:Label>
                
    <asp:TextBox ID="TSF" runat="server"/>
                    </td>
                </tr>
               </table>
        </div>
        <div>
               <table width="900px" border="0">
            <tr>
                <td>
    <asp:Label  ID="Printer" runat="server" Text="Printer Name :"></asp:Label>
                
    <asp:TextBox ID="P_Name" runat="server"/>
                    </td>
                </tr>
               </table>
            <table width="900px" border="0">
            <tr>
                <td>
    <asp:Label  ID="TimeStampTo" runat="server" Text="Create TimeStamp To :"></asp:Label>
                
    <asp:TextBox ID="TextBox1" runat="server"/>
                    </td>
                </tr>
               </table>
            </div>
        <div>

        <table width="900px" border="0">
            <tr>
                <td>
    <asp:Label  ID="Folder" runat="server" Text="Folder To Monitor :"></asp:Label>
                
    <asp:TextBox ID="FTM" runat="server"/>
                    </td>
                </tr>
               </table >
             <table width="900px" border="0">
            <tr>
                <td>
    <asp:Label  ID="Out" runat="server" Text="Output Type :"></asp:Label>
                
    <asp:TextBox ID="OT" runat="server"/>
                    </td>
                </tr>
               </table>
            </div>
        <div>
        <table width="900px" border="0">
            <tr>
                <td>
        <asp:RadioButton ID="Active_btn" runat="server" Text="Active" />
        <asp:RadioButton ID="Inactive_btn" runat="server" Text="Inactive" />
                    </td>
                </tr>
            </table>

         <table width="900px" border="0">
            <tr>
                <td>
    <asp:Label ID="File" runat="server" Text="File Output Type :"></asp:Label>
    <asp:TextBox ID="FOT" runat="server" />
                    </td>
                </tr>
            </table>
        </div>
        
            <div1>
        <asp:GridView ID="Grid_Printers" runat="server"></asp:GridView>
            </div1>
        
           <asp:Button ID="btnCreate" runat="server"  Text="Add Printer" OnClick="Create_Click"/>

        
    </form>
</body>
</html>
