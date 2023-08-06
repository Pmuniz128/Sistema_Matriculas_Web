
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

    Public Sub Grabar(ByVal accion As Integer, estudiate As Es)
        Dim strNombreSP As String = ""

        Dim sqlParametros As New List(Of SqlParameter)

        With sqlParametros
            .Add(New SqlParameter("@Accion", accion))
            .Add(New SqlParameter("@CodigoCarnet", estudiate.CodigoCarnet))
            .Add(New SqlParameter("@Nombre", estudiate))
            .Add(New SqlParameter("@PrimerApellido", estudiate))
            .Add(New SqlParameter("@SegundoApellido", estudiate))
            .Add(New SqlParameter("@FechaNacimiento", estudiate))
            .Add(New SqlParameter("@CodigoProvicia", estudiate))
            .Add(New SqlParameter("@DireccionExacta", estudiate))
            .Add(New SqlParameter("@Telefono", estudiate))
            .Add(New SqlParameter("@Email", estudiate))

        End With

        Dim iConexion As New DatosSQL.ConexionSQL
        iConexion.EjecutarSP(strNombreSP, listaParametro)

    End Sub


End Class
