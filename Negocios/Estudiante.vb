
Imports System.IO
Imports System.Xml
Imports System.Data
Imports System.Data.SqlClient
Imports Entidades

Public Class Estudiante


#Region "Propiedades"
    Private strCarnet As String
    Public Property Carnet() As String
        Get
            Return strCarnet
        End Get
        Set(ByVal value As String)
            strCarnet = value
        End Set
    End Property

    Private strtidEstudiante As String
    Public Property IDEstudiante() As String
        Get
            Return strtidEstudiante
        End Get
        Set(ByVal value As String)
            strtidEstudiante = value
        End Set
    End Property

    Private strnombreCompletoEstudnt As String
    Public Property NombreEstudiante() As String
        Get
            Return strnombreCompletoEstudnt
        End Get
        Set(ByVal value As String)
            strnombreCompletoEstudnt = value
        End Set
    End Property

    Private strcarrerasMatriculadas As String
    Public Property CarrerasMatriculadas() As String
        Get
            Return strcarrerasMatriculadas
        End Get
        Set(ByVal value As String)
            strcarrerasMatriculadas = value
        End Set
    End Property

    Private strnumeroTelefono As String
    Public Property NumeroTelefonico() As String
        Get
            Return strnumeroTelefono
        End Get
        Set(ByVal value As String)
            strnumeroTelefono = value
        End Set
    End Property

    Private strcorreroElectronico As String
    Public Property CorreoElectronico() As String
        Get
            Return strcorreroElectronico
        End Get
        Set(ByVal value As String)
            strcorreroElectronico = value
        End Set
    End Property

    Private datefechaNacimiento As Date
    Public Property FechaNacimiento() As Date
        Get
            Return datefechaNacimiento
        End Get
        Set(ByVal value As Date)
            datefechaNacimiento = value
        End Set
    End Property

    Private strdireccionExacta As String
    Public Property DireccionExacta() As String
        Get
            Return strdireccionExacta
        End Get
        Set(ByVal value As String)
            strdireccionExacta = value
        End Set
    End Property

    Private strbecaInfo As String
    Public Property Beca() As String
        Get
            Return strbecaInfo
        End Get
        Set(ByVal value As String)
            strbecaInfo = value
        End Set
    End Property
#End Region

#Region "Métodos"

#End Region

    Public Function Leer(rutaArchivo As String) As DataTable
        Dim iEstudiantes As New Datos.Estudiantes
        Return iEstudiantes.Leer()
    End Function

End Class
