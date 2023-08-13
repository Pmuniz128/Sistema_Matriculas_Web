Public Class Cursos

#Region "Propiedades"
    Private strcodigoCurso As String
    Public Property CodigoCurso As String
        Get
            Return strcodigoCurso
        End Get
        Set(ByVal value As String)
            strcodigoCurso = value
        End Set
    End Property

    Private strnombreCurso As String
    Public Property nombreCurso As String
        Get
            Return strnombreCurso
        End Get
        Set(ByVal value As String)
            strnombreCurso = value
        End Set
    End Property

    Private intcantCreditos As Integer
    Public Property CantidadCreditos As Integer
        Get
            Return intcantCreditos
        End Get
        Set(ByVal value As Integer)
            intcantCreditos = value
        End Set
    End Property

    Private intnotaMinima As Integer
    Public Property NotaMinima As Integer
        Get
            Return intnotaMinima
        End Get
        Set(ByVal value As Integer)
            intnotaMinima = value
        End Set
    End Property

    Private intcupoMinimo As Integer
    Public Property CupoMinimo() As Integer
        Get
            Return intcupoMinimo
        End Get
        Set(ByVal value As Integer)
            intcupoMinimo = value
        End Set
    End Property

    Private intcupoMaximo As Integer
    Public Property CupoMaximo As Integer
        Get
            Return intcupoMaximo
        End Get
        Set(ByVal value As Integer)
            intcupoMaximo = value
        End Set
    End Property

    Private strgradoCarrera As String
    Public Property GradoCarrera As String
        Get
            Return strgradoCarrera
        End Get
        Set(ByVal value As String)
            strgradoCarrera = value
        End Set
    End Property

    Private strestadoCurso As String
    Public Property EstadoCurso As String
        Get
            Return strestadoCurso
        End Get
        Set(ByVal value As String)
            strestadoCurso = value
        End Set
    End Property

    Private intcostoCurso As Integer
    Public Property CostoCurso As Integer
        Get
            Return intcostoCurso
        End Get
        Set(ByVal value As Integer)
            intcostoCurso = value
        End Set
    End Property

#End Region
End Class
