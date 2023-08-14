Imports System.Data.SqlClient

'Se realiza una clase para que guarde en la BD
Public Class DatosCarreras
    'Se hace una funcion que guarde carreras por medio de la BD
    Public Sub agregarCarrera(ByVal Carrera As Entidades.Carrera)

        Try
            Dim consultaSQL As String
            consultaSQL = $"insert into Carrera values ('{Carrera.ID_CARRERA}','{Carrera.DES_NOMBRE}','{ Carrera.DES_GRADO}','{Carrera.DES_ESTADO}')"

            Dim iDatosSQL As New DatosSQL.ConexionSQL
            iDatosSQL.EjecutarSQL(consultaSQL.ToString)
        Catch ex As Exception
            Throw ex

        End Try
    End Sub

    'Se hace un metodo que guarde toda la informacion que se necesita de la pagina para guardarla en
    'un SP proceso almacenado
    Public Sub mantenimientoCarrerasDatos(ByVal opcion As Short, ByVal carrera As Entidades.Carrera)

        Dim strNombreSP As String = "GrabarCarrera"
        Try
            Dim listaParametros As New List(Of SqlParameter) From {
                New SqlParameter("@Accion", opcion),
                New SqlParameter("@CodigoCurso", carrera.ID_CARRERA),
                New SqlParameter("@Nombre", carrera.DES_NOMBRE),
                New SqlParameter("@Grado", carrera.DES_GRADO),
                New SqlParameter("@Estado", carrera.DES_ESTADO),
            }

            Dim idatosSql As New DatosSQL.ConexionSQL
            idatosSql.EjecutarSP(strNombreSP, listaParametros)

        Catch ex As Exception
            Throw ex

        End Try
    End Sub

    'Metodo para realizar consultas generales de la pagina y pueda ser visualizado en un datatable
    Public Function consultaGeneralCarrerasDatos() As DataTable

        Try
            Dim consulta As String
            consulta = "select * from Carrera"
            Dim iDatosSQL As New DatosSQL.ConexionSQL
            Dim dt As DataTable = iDatosSQL.EjecutarSQLWithData(consulta)
            Return dt

        Catch ex As Exception
            Throw ex

        End Try
    End Function
End Class
