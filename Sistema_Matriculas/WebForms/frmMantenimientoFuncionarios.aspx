<%@ Page Title="Mantenimiento Funcionarios" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="frmMantenimientoFuncionarios.aspx.vb" Inherits="FrondEnd.frmMantenimientoFuncionario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

       <!---Se realiza toda la parte visualy se recolecta los datos que se necesitan ---->
    <h1>Mantenimiento de Funcionarios</h1>

    <!-- Fila Uno -->
    <div class="row">
        <div class="col-3">
            <div class="form-group">
                <label for="Identificacion">Identificacion</label>
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
        <div class="col-3">
            <div class="form-group">
                <label for="PrimerApellido">Primer Apellido</label>
                <asp:TextBox ID="txtPrimerApellido" runat="server" placeholder="Primer Apellido" class="form-control" required="required"></asp:TextBox>
            </div>
        </div>
        <div class="col-3">
            <div class="form-group">
                <label for="SegundoApellido">Segundo Apellido</label>
                <asp:TextBox ID="txtSegundoApellido" runat="server" placeholder="Segundo Apellido" class="form-control" required="required"></asp:TextBox>
            </div>
        </div>
    </div>

    <!-- Fila  -->
    <div class="row">

        <!-- Columna  -->
        <div class="col-3">
            <div class="form-group">
                <label for="Usuario">Usuario</label>
                <asp:TextBox ID="txtUsuario" runat="server" placeholder="Usuario" class="form-control"></asp:TextBox>
            </div>
        </div>

        <!-- Columna  -->
        <div class="col-3">
            <div class="form-group">
                <label for="Clave">Clave</label>
                <asp:TextBox ID="txtClave" runat="server" placeholder="Clave" class="form-control" required="required"></asp:TextBox>
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
             <h2>Consulta de Funcionarios</h2>
        </div>

    </div>

     <div class="row">
        <div class="col-12">
            <asp:GridView ID="gvFuncionario" runat="server" class="p-3 mb-2 bg-light text-dark" OnSelectedIndexChanged="gvFuncionario_SelectedIndexChanged">
                <Columns>
                    <asp:CommandField SelectText="Seleccionar" ShowSelectButton="True"></asp:CommandField>
                </Columns>
            </asp:GridView> 
        </div>        
             </div>
</asp:Content>
