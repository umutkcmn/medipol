<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="cvpver.aspx.cs" Inherits="tezz.cvpver" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width: 97%; height: 497px;">
        <tr>
            <td class="modal-lg" style="width: 986px">&nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Anasayfaya Dön" />
                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Çıkış Yap" />
            </td>
        </tr>
        <tr>
            <td style="width: 986px; height: 342px">
                <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical" Height="283px" Width="583px">
                    <AlternatingRowStyle BackColor="White" />
                    <FooterStyle BackColor="#CCCC99" />
                    <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                    <RowStyle BackColor="#F7F7DE" />
                    <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#FBFBF2" />
                    <SortedAscendingHeaderStyle BackColor="#848384" />
                    <SortedDescendingCellStyle BackColor="#EAEAD3" />
                    <SortedDescendingHeaderStyle BackColor="#575357" />
                </asp:GridView>
            </td>
            <td style="height: 342px">
                <asp:TextBox ID="TextBox1" runat="server" Height="143px" Width="286px"></asp:TextBox>
                <br />
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Cevap Ver" />
            </td>
        </tr>
        <tr>
            <td class="modal-lg" style="width: 986px">Cevap vermek istediğiniz sorunun ID&#39;sini giriniz. <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                <br />
                <br />
                Silmek istediğiniz sorunun ID&#39;sini giriniz.<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Silmek İçin Tıklayın" />
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
