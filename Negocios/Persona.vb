Public Class Persona



    Private intIndetificacion As Integer
    Public Property Identificacion() As Integer
        Get
            Return intIndetificacion
        End Get
        Set(ByVal value As Integer)
            intIndetificacion = value
        End Set
    End Property


    Private strNombre As String
    Public Property Nombre() As String
        Get
            Return strNombre
        End Get
        Set(ByVal value As String)
            strNombre = value
        End Set
    End Property

    Private strPrimerApellido As String
    Public Property primerApellido() As String
        Get
            Return strPrimerApellido
        End Get
        Set(ByVal value As String)
            strPrimerApellido = value
        End Set
    End Property

    Private strSegundoApellido As String
    Public Property segundoApellido() As String
        Get
            Return strSegundoApellido
        End Get
        Set(ByVal value As String)
            strSegundoApellido = value
        End Set
    End Property

    Private dptFechaNacimiento As DateTime
    Public Property FechaNacimiento() As DateTime

        Get
            Return dptFechaNacimiento
        End Get
        Set(ByVal value As DateTime)
            dptFechaNacimiento = value
        End Set
    End Property

    Private strDireccion As String
    Public Property direccionExacta() As String
        Get
            Return strDireccion
        End Get
        Set(ByVal value As String)
            strDireccion = value
        End Set
    End Property
End Class
