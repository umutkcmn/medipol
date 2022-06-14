<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="kuleklesil.aspx.cs" Inherits="tezz.kuleklesil" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

     <div class="form-group">
           <label for="kuladi">Kullanıcı Adı</label>
           <asp:TextBox ID="txtkul1" runat="server" class="form-control" ></asp:TextBox>

       </div>
       <div class="form-group">
           <label for="kulpar">Parola</label>
           <asp:TextBox ID="txtpar1" runat="server" class="form-control" TextMode="Password"></asp:TextBox>
       </div>
      
       <asp:DropDownList ID="DropDownList1" runat="server" Height="47px" Width="143px">
           <asp:ListItem Value="ogrtmn">Öğretmen</asp:ListItem>
           <asp:ListItem Value="ogrnci">Öğrenci</asp:ListItem>
     </asp:DropDownList>
     <br />
     <br />
      
       <asp:Button ID="btnekle" runat="server" class="btn btn-primary" Text="Kullanıcı Ekle" OnClick="btnekle_Click"  />
        &nbsp &nbsp
        <asp:Button ID="btnsil" runat="server" class="btn btn-primary" Text="Kullanıcı Sil" OnClick="btnsil_Click"  />
&nbsp;&nbsp;&nbsp;
     <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Medium" ForeColor="Red"></asp:Label>
</asp:Content>
