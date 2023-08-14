<%@ Page Title="Registro de Carreras" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="frmRegistroCarreras.aspx.vb" Inherits="FrontEnd.frmRegistroCarreras" %>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
   <!---Se realiza toda la parte visualy se recolecta los datos que se necesitan ---->
    <h1>Registro de Carreras</h1>
    <!---Fila ---->
     <div class ="row">
        <!---Columna--->
        <div class="col-3">
           <label for="ID_Carrera">ID Carrera</label>
           <asp:TextBox ID="txtIDCarrera" runat="server" placeholder="ID Carrera" class="form-control" required ="required"></asp:TextBox>
           <small id="ID_Carrera" class="form-text text-muted">Ingrese el ID de la carrera.</small>
       </div>
         </div>
    <div class ="row">
        <!---Columna--->
        <div class="col-3">
           <label for="DES_Nombre">Descripcion Nombre</label>
           <asp:TextBox ID="txtNombre" runat="server" placeholder="Descripcion Nombre" class="form-control" required ="required"></asp:TextBox>
           <small id="Desc_Nombre" class="form-text text-muted">Ingrese el nombre de la carrera.</small>
       </div>
      </div>
        <!---Fila--->
   <div class="row">
       <div class="col-3">
          <label for="ddlGrado">Grado</label>
          <asp:DropDownList ID="ddlGrado" runat="server" class ="form-control" required ="required" placeholder ="Seleccione">
          <asp:ListItem>Bachillerato</asp:ListItem>
          <asp:ListItem>Licenciatura</asp:ListItem>
          </asp:DropDownList>
       </div>
   </div>
   <div class="row">
       <div class="col-3">
          <label for="ddlEstado">Estado</label>
          <asp:DropDownList ID="ddlEstado" runat="server" class ="form-control" required ="required" placeholder ="Seleccione">
          <asp:ListItem>Activo</asp:ListItem>
          <asp:ListItem>Inactivo</asp:ListItem>
          </asp:DropDownList>
       </div>
   </div>
     <div class="row mt-4 mb-4">
        <!-- Columna  -->
        <div class="col-4">
             <asp:Button ID="btnRegistar" runat="server" Text="Registrar" class="btn btn-primary" OnClick="btnRegistar_Click" />
        </div>
     <div class="row">
        <div class="col-12">
            <asp:GridView ID="gvCarreras" runat="server" OnSelectedIndexChanged="gvCarreras_SelectedIndexChanged">
                <Columns>
                    <asp:CommandField SelectText="Seleccionar" ShowSelectButton="True"></asp:CommandField>
                </Columns>
            </asp:GridView>
        </div>
    </div>
           </div>
</asp:Content>
