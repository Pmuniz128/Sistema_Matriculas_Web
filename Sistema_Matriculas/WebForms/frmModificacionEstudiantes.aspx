<%@ Page Title="ModificaCION DE Estudiantes" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="frmModificacionEstudiantes.aspx.vb" Inherits="FrondEnd.frmMantenimientoEmpleado" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
      <!---Se realiza toda la parte visualy se recolecta los datos que se necesitan ---->
    <h1>Modificacion de Estudiantes</h1>
    <!---Fila ---->
     <div class ="row">
        <!---Columna--->
        <div class="col-3">
           <label for="Carnet">Carnet</label>
           <asp:TextBox ID="txtCarnet" runat="server" placeholder="Carnet" class="form-control" required ="required"></asp:TextBox>
           <small id="carnet" class="form-text text-muted">Ingrese su numero de Carnet.</small>
       </div>
    <div class ="row">
        <!---Columna--->
        <div class="col-3">
           <label for="Identificacion">Identificacion</label>
           <asp:TextBox ID="txtIdentif" runat="server" placeholder="Identificacion" class="form-control" required ="required"></asp:TextBox>
           <small id="identificacion" class="form-text text-muted">Ingrese su numero de Identificacion.</small>
       </div>
         <!---Columna--->
        <div class="col-3">
           <label for="Nombre">Nombre</label>
           <asp:TextBox ID="txtNombre" runat="server" placeholder="Nombre" class="form-control" required="required"></asp:TextBox>
        </div>
         <!---Columna--->
        <div class="col-3">
           <label for="PrimerApellido">Primer Apellido</label>
           <asp:TextBox ID="txtPrimerApellido" runat="server" placeholder="Primer Apellido" class="form-control" required ="required"></asp:TextBox>
        </div>
         <!---Columna--->
        <div class="col-3">
           <label for="SegundoApellido">Segundo Apellido</label>
           <asp:TextBox ID="txtSegundoApellido" runat="server" placeholder="Segundo Apellido" class="form-control" required="required"></asp:TextBox>
        </div>
    </div>

    <!---Fila ---->
    <div class ="row">
        <!---Columna--->
        <div class="col-3">
           <label for="Carrera">Carrera</label>
           <asp:TextBox ID="txtCarrera" runat="server" placeholder="Carrera" class="form-control" required="required"></asp:TextBox>
        </div>
         <!---Columna--->
        <div class="col-3">
          <label for="Proyecto">Proyecto</label>
          <asp:TextBox ID="txtProyecto" runat="server" placeholder="Proyecto" class="form-control" required="required"></asp:TextBox>
        </div>
         <!---Columna--->
        <div class="col-3">
           <label for="Telefono">Telefono</label>
           <asp:TextBox ID="txtTelef" runat="server" placeholder="Telefono" class="form-control" required="required" ></asp:TextBox>
        </div>
         <!---Columna--->
        <div class="col-3">
           <label for="Correo">Correo</label>
           <asp:TextBox ID="txtCorreo" runat="server" placeholder="Correo Electronico" class="form-control" required ></asp:TextBox>
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
            <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" class="btn btn-danger" Visible="false" OnClick="btnEliminar_Click" />
        </div>
        <!-- Columna  -->
        <div class="col-4">
            <asp:Button ID="btnModificar" runat="server" Text="Modificar" class="btn btn-warning" Visible="false" OnClick="btnModificar_Click" />
        </div>
      </div>
        
    
    <div class="row">
        <div class="col-12">
             <h2>Consulta de Estudiante</h2>
        </div>

    </div>
     <div class="row">
        <div class="col-12">
            <asp:GridView ID="gvEstudiante" runat="server" OnSelectedIndexChanged="gvEstudiante_SelectedIndexChanged">
                <Columns>
                    <asp:CommandField SelectText="Seleccionar" ShowSelectButton="True"></asp:CommandField>
                </Columns>


            </asp:GridView>
        </div>

    </div>
    
</asp:Content>
