<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ogrsor.aspx.cs" Inherits="tezz.ogrsor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <table style="width: 93%; height: 383px;">
            <tr>
                <td style="height: 55px; width: 523px">
                    <asp:TextBox ID="TextBox1" runat="server" Height="316px" Width="434px"></asp:TextBox>
                </td>
                <td style="height: 55px">
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="height: 26px; width: 523px">
                    &nbsp;</td>
                <td style="height: 26px">
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Soru Sor" />
                &nbsp;
                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click1" Text="Anasayfaya Dön" />
                </td>
            </tr>
        </table>
        <br />
        &nbsp; </p>
    <p>
        <asp:Label ID="Label1" runat="server"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
    <p>
    </p>
    <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </p>
    <p>
    </p>
</asp:Content>
