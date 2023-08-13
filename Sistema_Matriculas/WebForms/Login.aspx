<%@ Page Title="Login" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Login.aspx.vb" Inherits="FrontEnd.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

       <!---Se realiza toda la parte visual y se recolecta los datos que se necesitan ---->
     <div class="SistemaMatriculas">
        <h1>Login</h1>
        
  <div class="form-group">
    <label for="exampleInputEmail1">Usuario</label><br />
      <asp:TextBox ID="txtusuario" runat="server" Width="1195px"></asp:TextBox>
     <small id="usu" class="form-text text-muted">
      <br />
      Ingrese su nombre de usuario.</small>
  </div>
  <div class="form-group">
    <label for="exampleInputPassword1">Contrasena</label>
      <br />
      <asp:TextBox ID="txtcontrasena" runat="server" Width="1194px"></asp:TextBox>
    <small id="contra" class="form-text text-muted">
      <br />
      Ingrese su contrasena.</small>
  </div>
          <div class="form-group">
            <label for="ddlEstado">Tipo de Usuario</label>
            <asp:DropDownList ID="ddlUsuario" runat="server" class="form-control" required="required" placeholder="">
                <asp:ListItem>Estudiante</asp:ListItem>
                <asp:ListItem>Funcionario</asp:ListItem>
            </asp:DropDownList>
        </div>
         <asp:Button ID="btnIniciarL" runat="server" Text="Iniciar" class="btn btn-primary" OnClick ="btnIniciarL_Click" />

  </div>
</asp:Content>
