Imports Entidades
Imports System.Data.SqlClient

Public Class Estudiantes
    Public Sub Grabar(ByVal accion As Integer, estudiante As EstudianteEnt)
        Dim strNombreSP As String = "GrabarEstudiante"

        Dim lstParametros As New List(Of SqlParameter)

        With lstParametros
            .Add(New SqlParameter("@Accion", accion))
            .Add(New SqlParameter("@CodigoCarnet", estudiante.CodigoCarnet))
            .Add(New SqlParameter("@Identificacion", estudiante.Identificacion))
            .Add(New SqlParameter("@NombreCompleto", estudiante.NombreCompleto))
            .Add(New SqlParameter("@CarrerasMatriculadas", estudiante.CarrerasMatriculadas))
            .Add(New SqlParameter("@NumTelefono", estudiante.NumeroTelefono))
            .Add(New SqlParameter("@Email", estudiante.Email))
            .Add(New SqlParameter("@FechaNacimiento", estudiante.FechaNacimiento))
            .Add(New SqlParameter("@DireccionExacta", estudiante.DireccionExacta))
            .Add(New SqlParameter("@Beca", estudiante.Beca))

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
