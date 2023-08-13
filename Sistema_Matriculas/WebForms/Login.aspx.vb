Imports Entidades

Public Class Login
    Inherits System.Web.UI.Page
    'Metodo de pagina de carga se encarga de validar si el usuario es existente y redirecciona a la pagina pricipal
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim eUsuario As Entidades.Usuarios = CType(Session("Usuario"), Entidades.Usuarios)

        If eUsuario IsNot Nothing Then

            FormsAuthentication.RedirectFromLoginPage("", False)

        End If
    End Sub
    'Boton que realiza la validacion de iniciar para comparas usuarios y contrasenas
    Protected Sub btnIniciar_Click(sender As Object, e As EventArgs)
        Dim strUsuario As String = txtusuario.Text
        Dim strContrasena As String = txtcontrasena.Text

        Dim eUsuario As New Entidades.Usuarios
        Dim iSeguridad As New Negocios.Seguridad

        eUsuario = iSeguridad.validarLogin(strUsuario, strContrasena)

        If eUsuario.validarCredencial Then
            Session("Usuario") = eUsuario
            FormsAuthentication.RedirectFromLoginPage(strUsuario, False)


        Else
            ScriptManager.RegisterStartupScript(Me, GetType(Page), "Alerta", "javascript:alert('Hubo un fallo al Iniciar Sesion');", True)

        End If

    End Sub
End Class