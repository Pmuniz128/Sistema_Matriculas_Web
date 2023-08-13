Imports System.Data.SqlClient
Imports Entidades
'Se realiza una clase para que guarde en la BD
Public Class DatosCursos
    'Se hace una funcion que guarde empleados por medio de la BD
    Public Sub agregarCurso(ByVal Curso As Entidades.Cursos)


        Try
            Dim consultaSQL As String
            consultaSQL = $"insert into Curso values ('{Curso.ID_CURSO}','{Curso.DES_NOMBRE}','{ Curso.NUM_CREDITOS}','{Curso.NUM_NOTA_MINIMA}',
'{Curso.NUM_CUPO_MINIMO}','{ Curso.NUM_CUPO_MAXIMO}','{Curso.NUM_CUPO_GRADO}','{Curso.DES_ESTADO}','{Curso.NUM_COSTO}', '{ Curso.ID_CARRERA}')"

            Dim iDatosSQL As New DatosSQL.ConexionSQL
            iDatosSQL.EjecutarSQL(consultaSQL.ToString)

        Catch ex As Exception
            Throw ex

        End Try


    End Sub
    'Se hace un metodo que guarde toda la informacion que se necesita de la pagina para guardarla en
    'un SP proceso almacenado
    Public Sub mantenimientoCursosDatos(ByVal opcion As Short, ByVal curso As Entidades.Cursos)

        Dim strNombreSP As String = "SP_MantenimientoCursos"
        Try
            Dim listaParametros As New List(Of SqlParameter) From {
                New SqlParameter("@Accion", opcion),
                New SqlParameter("@CodigoCurso", curso.ID_CURSO),
                New SqlParameter("@Nombre", curso.DES_NOMBRE),
                New SqlParameter("@Creditos", curso.NUM_CREDITOS),
                New SqlParameter("@NotaMinima", curso.NUM_NOTA_MINIMA),
                New SqlParameter("@CupoMinimo", curso.NUM_CUPO_MINIMO),
                New SqlParameter("@CupoMaximo", curso.NUM_CUPO_MAXIMO),
                New SqlParameter("@Grado", curso.NUM_CUPO_GRADO),
                New SqlParameter("@Estado", curso.DES_ESTADO),
                New SqlParameter("@Costo", curso.NUM_COSTO),
                New SqlParameter("@CodigoCarrera", curso.ID_CARRERA)
            }
            Dim idatosSql As New DatosSQL.ConexionSQL
            idatosSql.EjecutarSP(strNombreSP, listaParametros)


        Catch ex As Exception
            Throw ex

        End Try


    End Sub
    'Metodo para realizar consultas generales de la pagina y pueda ser visualizado en un datatable
    Public Function consultaGeneralCursosDatos() As DataTable

        Try
            Dim consulta As String
            consulta = "select * from Curso"
            Dim iDatosSQL As New DatosSQL.ConexionSQL
            Dim dt As DataTable = iDatosSQL.EjecutarSQLWithData(consulta)
            Return dt

        Catch ex As Exception
            Throw ex

        End Try

    End Function
End Class
