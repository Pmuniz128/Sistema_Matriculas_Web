Imports System.Data.SqlClient
Imports System.Configuration

Public Class ConexionSQL
    Dim sqlConn As SqlConnection

    ''' <summary>
    ''' Constructor de la clase Conexión
    ''' </summary>
    Public Sub New()
        Dim strConnString As New System.Text.StringBuilder

        With strConnString
            .Append("Data Source=")
            .Append(ConfigurationManager.AppSettings("ServerName"))
            .Append(";Initial Catalog=")
            .Append(ConfigurationManager.AppSettings("DBName"))
            .Append(";User=")
            .Append(ConfigurationManager.AppSettings("UserDB"))
            .Append(";Password=")
            .Append(ConfigurationManager.AppSettings("PassDB"))
        End With

        Me.sqlConn = New SqlConnection(strConnString.ToString)

        'Me.sqlCon = New SqlConnection(ConfigurationManager.ConnectionStrings("sqlConnString").ConnectionString)
    End Sub

    Public Sub EjecutarSQL(ByVal ConsultaEjecutar As String)
        Try
            'objeto que ejecutará la consulta en la base de datos
            Dim cmd As New SqlCommand(ConsultaEjecutar, Me.sqlConn)

            'abrir la conexión a la base de datos
            Me.sqlConn.Open()

            'ejecuta la consulta en la base de datos
            cmd.ExecuteNonQuery()

            'cierra la conexión con la base de datos
            Me.sqlConn.Close()

        Catch ex As Exception
            'valida que la conexión esté abierta para cerrarla
            If Me.sqlConn.State = ConnectionState.Open Then Me.sqlConn.Close()

            'retorna el error
            Throw New Exception("Se ha producido un error al realizar el registro de la información en la base de datos", ex)
        End Try
    End Sub

    Public Sub EjecutarSP(ByVal NombreSP As String, ByVal listaParametro As List(Of SqlParameter))
        Try
            'objeto que ejecutará la consulta en la base de datos
            Dim cmd As New SqlCommand With {
                .CommandType = CommandType.StoredProcedure,
                .CommandText = NombreSP,
                .Connection = Me.sqlConn
                }

            For Each sqlParam As SqlParameter In listaParametro
                cmd.Parameters.Add(sqlParam)
            Next

            'abrir la conexión a la base de datos
            Me.sqlConn.Open()

            'ejecuta la consulta en la base de datos
            cmd.ExecuteNonQuery()

            'cierra la conexión con la base de datos
            Me.sqlConn.Close()

        Catch ex As Exception
            'valida que la conexión esté abierta para cerrarla
            If Me.sqlConn.State = ConnectionState.Open Then Me.sqlConn.Close()

            'retorna el error
            Throw New Exception("Se ha producido un error al realizar el registro de la información en la base de datos", ex)
        End Try
    End Sub

    Public Function EjecutarSQLWithData(ByVal ConsultaEjecutar As String) As DataTable
        Try
            'objeto que ejecutará la consulta en la base de datos
            Dim cmd As New SqlCommand(ConsultaEjecutar, Me.sqlConn)

            Dim adap As New SqlDataAdapter With {
                .SelectCommand = cmd
            }

            Dim dtDatos As New DataTable

            adap.Fill(dtDatos)

            Return dtDatos

        Catch ex As Exception
            'valida que la conexión esté abierta para cerrarla
            If Me.sqlConn.State = ConnectionState.Open Then Me.sqlConn.Close()

            'retorna el error
            Throw New Exception("Se ha producido un error al realizar el registro de la información en la base de datos", ex)
        End Try
    End Function

    Public Function EjecutarSPWithData(ByVal NombreSP As String, ByVal listaParametro As List(Of SqlParameter)) As DataTable
        Try
            'objeto que ejecutará la consulta en la base de datos
            Dim cmd As New SqlCommand With {
                .CommandType = CommandType.StoredProcedure,
                .CommandText = NombreSP,
                .Connection = Me.sqlConn
                }

            For Each sqlParam As SqlParameter In listaParametro
                cmd.Parameters.Add(sqlParam)
            Next

            Dim adap As New SqlDataAdapter With {
                .SelectCommand = cmd
            }

            Dim dtDatos As New DataTable

            adap.Fill(dtDatos)

            Return dtDatos

        Catch ex As Exception
            'valida que la conexión esté abierta para cerrarla
            If Me.sqlConn.State = ConnectionState.Open Then Me.sqlConn.Close()

            'retorna el error
            Throw New Exception("Se ha producido un error al realizar el registro de la información en la base de datos", ex)
        End Try
    End Function
End Class