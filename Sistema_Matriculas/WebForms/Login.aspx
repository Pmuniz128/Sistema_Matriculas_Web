<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Login.aspx.vb" Inherits="FrondEnd.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

       <!---Se realiza toda la parte visualy se recolecta los datos que se necesitan ---->
     <div class="SistemaMatriculas">
        <h1>Login</h1>
        
  <div class="form-group">
    <label for="exampleInputEmail1">Usuario</label>
     <asp:TextBox ID="txtusuario" runat="server" placeholder="Usuario" class="form-control" required="required" ></asp:TextBox>
     <small id="usu" class="form-text text-muted">Ingrese su nombre de usuario.</small>
  </div>
  <div class="form-group">
    <label for="exampleInputPassword1">Contrasena</label>
      <asp:TextBox ID="txtcontrasena" placeholder="Contrasena" class="form-control" runat="server" required="required" TextMode="Password"></asp:TextBox>
    <small id="contra" class="form-text text-muted">Ingrese su contrasena.</small>
  </div>
          <div class="form-group">
            <label for="ddlEstado">Tipo de Usuario</label>
            <asp:DropDownList ID="ddlUsuario" runat="server" class="form-control" required="required" placeholder="">
                <asp:ListItem>Estudiante</asp:ListItem>
                <asp:ListItem>Funcionario</asp:ListItem>
            </asp:DropDownList>
        </div>
         <asp:Button ID="btnIniciar" runat="server" Text="Iniciar" class="btn btn-primary" OnClick="btnIniciar_Click" />

  </div>
</asp:Content>
