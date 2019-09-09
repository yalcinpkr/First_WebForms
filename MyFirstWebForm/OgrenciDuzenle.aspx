<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OgrenciDuzenle.aspx.cs" Inherits="MyFirstWebForm.OgrenciDuzenle" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
     <form id="form1" runat="server">
        <div class="auto-style1">
            <table style="width:500px">
             <tr>
             <td>
            <asp:Label ID="Label1" runat="server" Text="Ad : "></asp:Label>
            </td>
                 <td>
            <asp:TextBox ID="txtFirstName" runat="server"  Width="268px"></asp:TextBox>
        </td>
                 </tr>
                <tr>
                    <td>
            <asp:Label ID="Label2" runat="server" Text="Soyad : "></asp:Label>
</td>
                    <td>
            <asp:TextBox ID="txtLastName" runat="server" Width="268px"></asp:TextBox>
         </td>
                    </tr>
                <tr>
                    <td>
            <asp:Label ID="Label3" runat="server" Text="Telefon : "></asp:Label> 
            </td>
            <td>
            <asp:TextBox ID="txtPhone" runat="server" Width="268px"></asp:TextBox>
         </td>
                    </tr>
                <tr>
                    <td>
            <asp:Label ID="Label4" runat="server" Text="Email : "></asp:Label>
                        </td>
<td>
            <asp:TextBox ID="txtEmail" runat="server" Width="268px"></asp:TextBox>
    </td>
                    </tr>
                <tr>
                    <td>
            <asp:Label ID="Label5" runat="server" Text="Doğum Tarihi : "></asp:Label>
            </td>
                    <td>
                        <asp:Calendar ID="cldBirthDate" runat="server"></asp:Calendar>
         </td>
                    </tr>
                <tr>
                    <td>
             <asp:Label ID="Label6" runat="server" Text="Yaş : "></asp:Label>
                        </td>
                    <td>
            <asp:TextBox ID="txtAge" runat="server"  Width="268px"></asp:TextBox>
                        </td>
                    </tr>
                <tr>
                    <td colspan="2" style="text-align:center;">
          
            <asp:Button ID="btnDuzenle" runat="server" OnClick="btnDuzenle_Click" Text="Düzenle"/>
                        </td></tr>
            </table>
        </div>
    </form>
</body>
</html>
