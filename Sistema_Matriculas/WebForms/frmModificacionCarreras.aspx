<%@ Page Title="Modificacion de Carreras" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="frmModificacionCarreras.aspx.vb" Inherits="FrontEnd.frmModificacionCarreras" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    
       <!---Se realiza toda la parte visualy se recolecta los datos que se necesitan ---->
    <h1>Mantenimiento de Carreras</h1>
    <!-- Fila Uno -->
    <div class="row">
        <div class="col-3">
            <div class="form-group">
                <label for="IDCarrera">Código de Carrera</label>
                <asp:TextBox ID="txtIdentif" runat="server" placeholder="Identificacion" class="form-control" required=" required"></asp:TextBox>
                <small id="emailHelp" class="form-text text-muted">Ingrese su numero de Identificacion.</small>
            </div>
        </div>
        <div class="col-3">
            <div class="form-group">
                <label for="Nombre">Nombre</label>
                <asp:TextBox ID="txtNombre" runat="server" placeholder="Nombre" class="form-control" required="required"></asp:TextBox>
            </div>
        </div>
         <!-- Columna  -->
        <div class="col-3">
            <label for="ddlEstado">Estado</label>
            <asp:DropDownList ID="ddlGrado" runat="server" class="form-control" required="required" placeholder="Seleccione">
                <asp:ListItem>Bachillerato</asp:ListItem>
                <asp:ListItem>Licenciatura</asp:ListItem>
            </asp:DropDownList>
        </div>
    </div>
        <!-- Columna  -->
        <div class="col-3">
            <label for="ddlEstado">Estado</label>
            <asp:DropDownList ID="ddlEstado" runat="server" class="form-control" required="required" placeholder="Seleccione">
                <asp:ListItem>Activo</asp:ListItem>
                <asp:ListItem>Inactivo</asp:ListItem>
            </asp:DropDownList>
        </div>
    <div class="row mt-4 mb-4">
        <!-- Columna  -->
        <div class="col-4">
            <asp:Button ID="btnAgregar" runat="server" Text="Registrar" class="btn btn-success" OnClick="btnAgregar_Click" />
        </div>
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
             <h2>Consulta de Carreras</h2>
        </div>
    </div>
     <div class="row">
        <div class="col-12">
            <asp:GridView ID="gvCarrera" runat="server" class="p-3 mb-2 bg-light text-dark" OnSelectedIndexChanged="gvCarrera_SelectedIndexChanged">
                <Columns>
                    <asp:CommandField SelectText="Seleccionar" ShowSelectButton="True"></asp:CommandField>
                </Columns>
            </asp:GridView> 
        </div>
    </div>
</asp:Content>
