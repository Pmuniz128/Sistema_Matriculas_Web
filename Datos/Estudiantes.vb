Imports Entidades
Imports System.Data.SqlClient

Public Class Estudiantes
    Public Sub Grabar(ByVal accion As Integer, estudiate As EstudianteEnt)
        Dim strNombreSP As String = "GrabarEstudiante"

        Dim lstParametros As New List(Of SqlParameter)

        With lstParametros
            .Add(New SqlParameter("@Accion", accion))
            .Add(New SqlParameter("@CodigoCarnet", estudiate.CodigoCarnet))
            .Add(New SqlParameter("@Nombre", estudiate.Nombre))
            .Add(New SqlParameter("@PrimerApellido", estudiate.PrimerApellido))
            .Add(New SqlParameter("@SegundoApellido", estudiate.SegundoApellido))
            .Add(New SqlParameter("@FechaNacimiento", estudiate.FechaNacimiento))
            .Add(New SqlParameter("@CodigoProvicia", estudiate.CodigoProvincia))
            .Add(New SqlParameter("@DireccionExacta", estudiate.DireccionExacta))
            .Add(New SqlParameter("@Telefono", estudiate.Telefono))
            .Add(New SqlParameter("@Email", estudiate.Email))

        End With

        Dim iConexion As New DatosSQL.ConexionSQL
        iConexion.EjecutarSP(strNombreSP, lstParametros)

    End Sub

    Public Function Leer(ByVal Optional Carnet As String = "") As DataTable
        Dim strNombreSP As String = "LeerEstudiante"

        Dim lstParametros As New List(Of SqlParameter)

        With lstParametros
            .Add(New SqlParameter("@GetAll", If(String.IsNullOrEmpty(Carnet), 0, 1)))
            .Add(New SqlParameter("@CodigoCarnet", Carnet))


        End With

        Dim iConexion As New DatosSQL.ConexionSQL
        Return iConexion.EjecutarSPWithData(strNombreSP, lstParametros)

    End Function
End Class
