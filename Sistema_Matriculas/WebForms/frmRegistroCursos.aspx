<%@ Page Title="Registro de Cursos" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="frmRegistroCursos.aspx.vb" Inherits="FrontEnd.frmRegistroCursos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
      <!---Se realiza toda la parte visualy se recolecta los datos que se necesitan ---->
    <h1>Registro de Cursos</h1>
    <!---Fila ---->
     <div class ="row">
        <!---Columna--->
        <div class="col-3">
           <label for="ID_Curso">ID Curso</label>
           <asp:TextBox ID="txtIDCurso" runat="server" placeholder="ID Curso" class="form-control" required ="required"></asp:TextBox>
           <small id="ID_Curso" class="form-text text-muted">Ingrese el ID del Curso.</small>
       </div>
         </div>
    <div class ="row">
        <!---Columna--->
        <div class="col-3">
           <label for="Desc_Nombre">Descripcion Nombre</label>
           <asp:TextBox ID="txtNombre" runat="server" placeholder="Descripcion Nombre" class="form-control" required ="required"></asp:TextBox>
           <small id="Desc_Nombre" class="form-text text-muted">Ingrese el nombre del curso.</small>
       </div>
      </div>
         <!---Columna--->
        <div class="col-3">
           <label for="Num_Creditos">Cantidad de Creditos</label>
           <asp:TextBox ID="txtCreditos" runat="server" placeholder="Cantidad de Creditos" class="form-control" required="required"></asp:TextBox>
           <small id="Num_Creditos" class="form-text text-muted">Ingrese el numero de creditos del curso.</small>
        </div>
         <!---Columna--->
        <div class="col-3">
           <label for="NUM_CUPO_MIN">Nota Minima</label>
           <asp:TextBox ID="txtCupoMin" runat="server" placeholder="Cupo Minima" class="form-control" required ="required"></asp:TextBox>
        </div>
             <!---Columna--->
        <div class="col-3">
           <label for="NUM_ CUPO_MAXIMO">Cupo Maximo</label>
           <asp:TextBox ID="txtCupoMax" runat="server" placeholder="Cupo Maximo" class="form-control" required ="required"></asp:TextBox>
        </div>
         <!---Columna--->
        <div class="col-3">
           <label for="NUM_NOTA_MAXIMO">Nota Maxima</label>
           <asp:TextBox ID="txtNotaMin" runat="server" placeholder="Nota Minima" class="form-control" required ="required"></asp:TextBox>
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
   <!---Columna--->
        <div class="col-3">
           <label for="NUM_COSTO">Costo del Curso</label>
           <asp:TextBox ID="txtCosto" runat="server" placeholder="Costo del Curso" class="form-control" required ="required"></asp:TextBox>
        </div>
   <!---Columna--->
        <div class="col-3">
           <label for="ID_CARRERA">ID Carrera</label>
           <asp:TextBox ID="txt_IDCarrera" runat="server" placeholder="ID Carrera" class="form-control" required ="required"></asp:TextBox>
        </div>

     <div class="row mt-4 mb-4">
        <!-- Columna  -->
        <div class="col-4">
             <asp:Button ID="btnRegistar" runat="server" Text="Registrar" class="btn btn-primary" OnClick="btnRegistar_Click" />
        </div>
     <div class="row">
        <div class="col-12">
            <asp:GridView ID="gvCursos" runat="server" OnSelectedIndexChanged="gvCursos_SelectedIndexChanged">
                <Columns>
                    <asp:CommandField SelectText="Seleccionar" ShowSelectButton="True"></asp:CommandField>
                </Columns>


            </asp:GridView>
        </div>

    </div>
    
</asp:Content>