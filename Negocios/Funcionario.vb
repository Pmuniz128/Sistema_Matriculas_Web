Imports System.IO
Imports System.Xml

Public Class Funcionario

#Region "Propiedades"

    Private strEmail As String
    Public Property email() As String
        Get
            Return strEmail
        End Get
        Set(ByVal value As String)
            strEmail = value
        End Set
    End Property

    Private strIdentificacion As String
    Public Property Identificacion As String
        Get
            Return strIdentificacion
        End Get
        Set(value As String)
            strIdentificacion = value
        End Set
    End Property

    Private strnombreCompleto As String
    Public Property NombreCompleto As String
        Get
            Return strnombreCompleto
        End Get
        Set(value As String)
            strnombreCompleto = value
        End Set
    End Property

    Private strUsuario As String
    Public Property Usuario As String
        Get
            Return strUsuario
        End Get
        Set(ByVal value As String)
            strUsuario = value
        End Set
    End Property

    Private strClave As String
    Public Property Clave As String
        Get
            Return strClave
        End Get
        Set(ByVal value As String)
            strClave = value
        End Set
    End Property

    Private strEstado As String
    Public Property Estado As String
        Get
            Return strEstado
        End Get
        Set(ByVal value As String)
            strEstado = value
        End Set
    End Property

#End Region
End Class
