Imports Entidades
Imports System.Data.SqlClient

Public Class Estudiantes
    'Se hace una funcion que guarde empleados por medio de la BD
    Public Sub agregarEstudiante(ByVal Estudiante As Entidades.EstudianteEnt)


        Try
            Dim consultaSQL As String
            consultaSQL = $"insert into Estudiante values ('{Estudiante.CodigoCarnet}','{Estudiante.Identificacion}','{ Estudiante.Nombre}','{Estudiante.PrimerApellido}',
'{Estudiante.SegundoApellido}','{ Estudiante.CarrerasMatriculadas}','{Estudiante.NumeroTelefono}','{Estudiante.Email}','{Estudiante.FechaNacimiento}', '{ Estudiante.DireccionExacta}','{ Estudiante.Beca}' )"

            Dim iDatosSQL As New DatosSQL.ConexionSQL
            iDatosSQL.EjecutarSQL(consultaSQL.ToString)

        Catch ex As Exception
            Throw ex

        End Try


    End Sub
    'Se hace un metodo que guarde toda la informacion que se necesita de la pagina para guardarla en
    'un SP proceso almacenado
    Public Sub mantenimientoEstudianteDatos(ByVal opcion As Short, ByVal estudiante As Entidades.EstudianteEnt)

        Dim strNombreSP As String = "SP_RegistroEstudiantes"
        Try
            Dim listaParametros As New List(Of SqlParameter) From {
                New SqlParameter("@Accion", opcion),
                New SqlParameter("@CodigoCarnet", estudiante.CodigoCarnet),
                New SqlParameter("@Identificacion", estudiante.Identificacion),
                New SqlParameter("@Nombre", estudiante.Nombre),
                New SqlParameter("@CarrerasMatriculadas", estudiante.CarrerasMatriculadas),
                New SqlParameter("@NumTelefono", estudiante.NumeroTelefono),
                New SqlParameter("@Email", estudiante.Email),
                New SqlParameter("@FechaNacimiento", estudiante.FechaNacimiento),
                New SqlParameter("@DireccionExacta", estudiante.DireccionExacta),
                New SqlParameter("@Beca", estudiante.Beca)
            }
            Dim idatosSql As New DatosSQL.ConexionSQL
            idatosSql.EjecutarSP(strNombreSP, listaParametros)


        Catch ex As Exception
            Throw ex

        End Try


    End Sub
    'Metodo para realizar consultas generales de la pagina y pueda ser visualizado en un datatable
    Public Function consultaGeneralEstudianteDatos() As DataTable

        Try
            Dim consulta As String
            consulta = "select * from Estudiante"
            Dim iDatosSQL As New DatosSQL.ConexionSQL
            Dim dt As DataTable = iDatosSQL.EjecutarSQLWithData(consulta)
            Return dt

        Catch ex As Exception
            Throw ex

        End Try

    End Function
End Class
