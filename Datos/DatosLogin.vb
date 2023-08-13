'Se realiza una clase login para poder hacer consultas de usuarios si ya estan ingresados

Public Class DatosLogin
    'Se realiza una funcion que hace consultas login a la BD
    Public Function consultaLogin(ByVal Usuario As String, ByVal Contrasena As String) As DataTable


        Try
            Dim consulta As String
            consulta = $"select * from Usuario where usuario ='{Usuario}' and clave='{Contrasena}'"
            Dim iDatosSQL As New DatosSQL.ConexionSQL
            Dim dt As DataTable = iDatosSQL.EjecutarSQLWithData(consulta)
            Return dt

        Catch ex As Exception
            Throw ex

        End Try

    End Function
End Class
