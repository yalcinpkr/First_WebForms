<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ogrenciler.aspx.cs" Inherits="MyFirstWebForm.Ogrenciler" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/OgrenciEkle.aspx">Yeni Öğrenci</asp:HyperLink>
        </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowDeleting="GridView1_RowDeleting">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Id" />
                <asp:BoundField DataField="FirstName" HeaderText="Ad" />
                <asp:BoundField DataField="LastName" HeaderText="Soyad" />
                <asp:BoundField DataField="Phone" HeaderText="Telefon" />
                <asp:BoundField DataField="Email" HeaderText="Email" />
                <asp:BoundField DataField="BirthDate" HeaderText="Doğum Tarihi" />
                <asp:BoundField DataField="Age" HeaderText="Yaş" />
                <asp:HyperLinkField DataNavigateUrlFields="Id" DataNavigateUrlFormatString="OgrenciDuzenle?Id={0}" HeaderText="Eylemler" Text="Düzenle" />
                <asp:CommandField ShowDeleteButton="True" />
            </Columns>
            <EditRowStyle BackColor="#7C6F57" />
            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#E3EAEB" />
            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F8FAFA" />
            <SortedAscendingHeaderStyle BackColor="#246B61" />
            <SortedDescendingCellStyle BackColor="#D4DFE1" />
            <SortedDescendingHeaderStyle BackColor="#15524A" />
        </asp:GridView>
    </form>
</body>
</html>
