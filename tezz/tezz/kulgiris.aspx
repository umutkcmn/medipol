<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="kulgiris.aspx.cs" Inherits="tezz.kulgiris" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
       <div class="form-group">
           <label for="kuladi">Kullanıcı Adı</label>
           <asp:TextBox ID="txtkul" runat="server" class="form-control"></asp:TextBox>

       </div>
       <div class="form-group">
           <label for="kulpar">Parola</label>
           <asp:TextBox ID="txtpar" runat="server" class="form-control" TextMode="Password"></asp:TextBox>
       </div>
      
       <asp:Button ID="btngiris" runat="server" class="btn btn-primary" Text="Giriş Yap" OnClick="btngiris_Click" />
        &nbsp &nbsp
        <asp:Button ID="btneklesil" runat="server" class="btn btn-primary" Text="Kullanıcı Ekle/Sil" OnClick="btneklesil_Click" />
   
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
       <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Parolamı Değiştir</asp:LinkButton>
&nbsp;&nbsp;&nbsp;
       <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Medium" Font-Underline="True" ForeColor="Red"></asp:Label>
   
       </asp:Content>
