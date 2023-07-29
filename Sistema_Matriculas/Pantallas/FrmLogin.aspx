<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="FrmLogin.aspx.vb" Inherits="Sistema_Matriculas.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="Login" runat="server">
        <div style="height: 552px">
           
            <asp:Label ID="lbl_Login" runat="server" Text="Login"></asp:Label>
            <br />
            <asp:Label ID="lbl_Tipo_Credencial" runat="server" Text="Seleccione sus Credenciales:"></asp:Label>
            <br />
            <asp:Button ID="btn_Registrarse" runat="server" Text="¿Registrarse?" />
            <br />
            <br />
            <asp:DropDownList ID="DropDownList1" runat="server" Height="22px" Width="160px">
                <asp:ListItem>Funcionario</asp:ListItem>
                <asp:ListItem>Estudiante</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Label ID="lbl_Email" runat="server" Text="Email:"></asp:Label>
            <br />
            <asp:TextBox ID="TextBox1" runat="server" Width="160px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lbl_contraseña" runat="server" Text="Contraseña:"></asp:Label>
            <br />
            <asp:TextBox ID="TextBox3" runat="server" Width="160px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btn_Ingresar" runat="server" Text="Ingresar" Width="168px" />
            <br />
            <br />
            <asp:Button ID="btn_RecoveryPass" runat="server" Height="26px" Text="¿Olvido su contraseña?" Width="168px" />
            <br />
            <br />
            <br />
           
        </div>
    </form>
</body>
</html>
