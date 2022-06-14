<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ogrtmnanasyf.aspx.cs" Inherits="tezz.ogrtmnanasyf" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width: 90%; height: 353px;">
        <tr>
            <td style="height: 92px; width: 482px"></td>
            <td style="height: 92px; width: 728px"></td>
            <td style="height: 92px; width: 401px">
                <asp:Label ID="Label1" runat="server" Font-Bold="True"></asp:Label>
&nbsp;&nbsp;
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="Çıkış Yap" />
            </td>
        </tr>
        <tr>
            <td style="height: 62px; width: 482px">
                <asp:Button ID="Button2" runat="server" Height="150px" Text="Soru Bankasını Görüntüle" Width="330px" OnClick="Button2_Click" />
            </td>
            <td style="height: 62px; width: 728px">
                <asp:Button ID="Button3" runat="server" Height="150px" OnClick="Button3_Click" Text="Öğrenciden Gelen Soruya Cevap Ver" Width="330px" />
            </td>
            <td style="height: 62px; width: 401px"></td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 482px">&nbsp;</td>
            <td style="width: 728px">&nbsp;</td>
            <td style="width: 401px">&nbsp;</td>
        </tr>
    </table>
</asp:Content>
