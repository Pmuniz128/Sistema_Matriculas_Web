Imports System.IO
Imports System.Xml

Public Class Funcionario
    Inherits Persona

    Private strEmail As String
    Public Property email() As String
        Get
            Return strEmail
        End Get
        Set(ByVal value As String)
            strEmail = value
        End Set
    End Property

    Private strContraseña As String
    Public Property contraseña() As String
        Get
            Return strContraseña
        End Get
        Set(ByVal value As String)
            strContraseña = value
        End Set
    End Property

    Private blnEstado As String
    Public Property estado() As String
        Get
            Return blnEstado
        End Get
        Set(ByVal value As String)
            blnEstado = value
        End Set
    End Property


End Class
