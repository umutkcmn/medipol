<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="tezz.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %></h2>
    <h3>Öğretmen ile öğrencinin buluşma alanı...</h3>
    <p>Öğrenciler için kendilerini geliştirebilecekleri öğretmenlerine veya diğer öğretmenlere soru sorabilecekleri bir
        web sitesi.
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Giriş Sayfasına Dönmek İçin Tıklayın" />
    </p>
</asp:Content>
