Public Class Seguridad
    'Se realiza una clase para conectar la base de datos con la capa negocios y asi se pueda mostrar las informaciones
    Public Function validarLogin(ByVal Usuario As String, ByVal Contrasena As String)
        Dim eUsuario As New Entidades.Usuarios
        Dim iLogin As New Datos.DatosLogin
        eUsuario.validarCredencial = False

        Dim dt As DataTable = iLogin.consultaLogin(Usuario, Contrasena)

        If dt.Rows.Count <> 0 Then
            eUsuario.usuario = Usuario
            eUsuario.contrasena = Contrasena
            eUsuario.validarCredencial = True
            eUsuario.rol = dt(0).Item(3)
        End If

        Return eUsuario

    End Function
End Class
