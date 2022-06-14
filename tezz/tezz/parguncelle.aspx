<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="parguncelle.aspx.cs" Inherits="tezz.parguncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <div class="form-group">
           <label for="kuladi">Kullanıcı Adı</label>
           <asp:TextBox ID="txtkul2" runat="server" class="form-control" ></asp:TextBox>

       <div class="form-group">
           <label for="kulpar">Mevcut Parola</label>
           <br />
           <asp:TextBox ID="txtpar3" runat="server" class="form-control" TextMode="Password"></asp:TextBox>
       </div>
      
       </div>
       <div class="form-group">
           <label for="kulpar">Yeni Parola</label>
           <br />
           <asp:TextBox ID="txtpar2" runat="server" class="form-control" TextMode="Password"></asp:TextBox>
       </div>
      
       <asp:Button ID="btnguncelle" runat="server" class="btn btn-primary" Text="Parola Değiştir" OnClick="btnguncelle_Click"  />
&nbsp;&nbsp;&nbsp;
     <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Medium" ForeColor="#FF3300"></asp:Label>
</asp:Content>
