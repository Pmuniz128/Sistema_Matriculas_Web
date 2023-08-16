<%@ Page Title="Modificacion DE Estudiantes" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="frmRegistroEstudiantes.aspx.vb" Inherits="FrontEnd.frmRegistroEstudiantes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
      <!---Se realiza toda la parte visualy se recolecta los datos que se necesitan ---->
    <h1>Registro de Estudiantes</h1>
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
           <label for="Nombre">Nombre Completo</label>
           <asp:TextBox ID="txtNombre" runat="server" placeholder="Nombre Completo" class="form-control" required="required"></asp:TextBox>
        </div>

        <div class="form-outline datetimepicker">
             <label for="dtpFecha" class="form-label">Fecha de Nacimiento</label>
            <input type="text" class="form-control" value="22/12/2020" id="dtpFecha" />
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
           <label for="Direccion">Direccion exacta</label>
           <asp:TextBox ID="txtDirec" runat="server" placeholder="Direccion exacta" class="form-control" required="required" Width="294px"></asp:TextBox>
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
           <asp:TextBox ID="txtCorreo" runat="server" placeholder="Correo Electronico" class="form-control" required ="required" ></asp:TextBox>
        </div>
                 <!---Columna--->
        <div class="col-3">
           <label for="Beca">Beca</label>
           <asp:TextBox ID="txtBeca" runat="server" placeholder="Beca" class="form-control" required ="required" ></asp:TextBox>
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
    
      </div>
      </div>
      </div>
</asp:Content>



