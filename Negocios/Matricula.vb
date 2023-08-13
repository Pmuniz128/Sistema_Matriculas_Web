Public Class Matricula

#Region "Propiedades"
    Private stridentificacionEstudte As String
    Public Property IdentificacionEstudiante() As String
        Get
            Return stridentificacionEstudte
        End Get
        Set(ByVal value As String)
            stridentificacionEstudte = value
        End Set
    End Property

    Private datefechaMatricula As Date
    Public Property FechaMatricula() As Date
        Get
            Return datefechaMatricula
        End Get
        Set(ByVal value As Date)
            datefechaMatricula = value
        End Set
    End Property

    Private strcarreraMatricular As String
    Public Property CarreraMatricular() As String
        Get
            Return strcarreraMatricular
        End Get
        Set(ByVal value As String)
            strcarreraMatricular = value
        End Set
    End Property

    Private strcursoMatricular As String
    Public Property CursoMatricular() As String
        Get
            Return strcursoMatricular
        End Get
        Set(ByVal value As String)
            strcursoMatricular = value
        End Set
    End Property

    Private strCuatrimestre As String
    Public Property Cuatrimestre() As String
        Get
            Return strCuatrimestre
        End Get
        Set(ByVal value As String)
            strCuatrimestre = value
        End Set
    End Property

    Private intcostoTotal As Integer
    Public Property CostoTotal() As Integer
        Get
            Return intcostoTotal
        End Get
        Set(ByVal value As Integer)
            intcostoTotal = value
        End Set
    End Property
#End Region
End Class
