Public Class Carreras

#Region "Variables"
    Private idatos As New Datos.DatosCarreras
#End Region

#Region "Propiedades"
    Private strcodigoCarrera As String
    Public Property CodigoCarrera() As String
        Get
            Return strcodigoCarrera
        End Get
        Set(ByVal value As String)
            strcodigoCarrera = value
        End Set
    End Property

    Private strnombreCarrera As String
    Public Property nombreCarrera() As String
        Get
            Return strnombreCarrera
        End Get
        Set(ByVal value As String)
            strnombreCarrera = value
        End Set
    End Property

    Private strgradoCarrera As String
    Public Property GradoCarrera() As String
        Get
            Return strgradoCarrera
        End Get
        Set(ByVal value As String)
            strgradoCarrera = value
        End Set
    End Property

    Private strestadoCarrera As String
    Public Property EstadoCarrera() As String
        Get
            Return strestadoCarrera
        End Get
        Set(ByVal value As String)
            strestadoCarrera = value
        End Set
    End Property
#End Region

#Region "Métodos"
    Public Sub mantenimiento(ByVal opcion As Short, ByVal Carrera As Entidades.Carrera)
        idatos.mantenimientoCarrerasDatos(opcion, Carrera)

    End Sub

    Public Function consultaGeneralNegocios() As DataTable
        Dim dt As DataTable = idatos.consultaGeneralCarrerasDatos()
        Return dt

    End Function
#End Region
End Class
