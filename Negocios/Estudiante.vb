
Imports System.IO
Imports System.Xml
Imports System.Data
Imports System.Data.SqlClient
Imports Entidades

Public Class Estudiante
    Inherits Persona

    Private blnTieneBeca As String
    Public Property TieneBeca() As String
        Get
            Return blnTieneBeca
        End Get
        Set(ByVal value As String)
            blnTieneBeca = value
        End Set
    End Property

    Private strCarreraMatriculada As String
    Public Property CarreraMatriculada() As String
        Get
            Return strCarreraMatriculada
        End Get
        Set(ByVal value As String)
            strCarreraMatriculada = value
        End Set
    End Property

    Private strEmail As String
    Public Property email() As String
        Get
            Return strEmail
        End Get
        Set(ByVal value As String)
            strEmail = value
        End Set
    End Property
    Private int_Telefono As Integer
    Public Property telefono() As Integer
        Get
            Return int_Telefono
        End Get
        Set(ByVal value As Integer)
            int_Telefono = value
        End Set
    End Property

    Private dble_porcentaje_beca As Double
    Public Property porcentaje_Beca() As Double
        Get
            Return dble_porcentaje_beca
        End Get
        Set(ByVal value As Double)
            dble_porcentaje_beca = value
        End Set
    End Property

    Private strPeriodo As String
    Public Property Periodo() As String
        Get
            Return strPeriodo
        End Get
        Set(ByVal value As String)
            strPeriodo = value
        End Set
    End Property
    Private strCursoMatriculado As String
    Public Property Curso_Matriculado() As String
        Get
            Return strCursoMatriculado
        End Get
        Set(ByVal value As String)
            strCursoMatriculado = value
        End Set
    End Property

    Public Function Leer(rutaArchivo As String) As DataTable
        Dim iEstudiantes As New Datos.Estudiantes
        Return iEstudiantes.Leer()
    End Function

End Class
