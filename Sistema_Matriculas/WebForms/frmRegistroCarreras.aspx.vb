Imports Negocios

Public Class frmRegistroCarreras
    Inherits System.Web.UI.Page

    'Metodo de pagina de carga se encarga de validar si el usuario es existente y redirecciona a la pagina pricipal
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim eCursos As Entidades.Carrera = CType(Session("Carreras"), Entidades.Carrera)

        If eCursos Is Nothing Then
            FormsAuthentication.RedirectFromLoginPage("", False)

        End If
        consultaGeneral()
    End Sub

    'Boton de registrar cuando se le da click ingresa todos los datos y los asigna
    Protected Sub btnRegistar_Click(sender As Object, e As EventArgs)

        Try
            Dim eCarrera As New Entidades.Carrera
            eCarrera.ID_CARRERA = txtIDCarrera.Text
            eCarrera.DES_NOMBRE = txtNombre.Text
            eCarrera.DES_GRADO = ddlGrado.Text
            eCarrera.DES_ESTADO = ddlEstado.Text

            Dim iCarrera As New Negocios.Carreras
            iCarrera.mantenimiento(1, eCarrera)
            ScriptManager.RegisterStartupScript(Me, GetType(Page), "Alerta", "javascript:alert('Se agrego la carrera Exitosamente');", True)
            consultaGeneral()
            limpiar()

        Catch ex As Exception

        End Try

    End Sub

    'Metodo que le asigna al greadview la informacion ingresada
    Public Sub consultaGeneral()
        Dim iCarreras As New Negocios.Carreras
        gvCarreras.DataSource = iCarreras.consultaGeneralNegocios
        gvCarreras.DataBind()

    End Sub
    'Asocia el grid a cada columna , fila la informacion para que se vea ordenada

    Protected Sub gvEmpleado_SelectedIndexChanged(sender As Object, e As EventArgs)

        txtIDCarrera.ReadOnly = True

        txtIDCarrera.Text = gvCarreras.Rows(gvCarreras.SelectedIndex).Cells(1).Text
        txtNombre.Text = gvCarreras.Rows(gvCarreras.SelectedIndex).Cells(2).Text
        ddlGrado.Text = gvCarreras.Rows(gvCarreras.SelectedIndex).Cells(3).Text
        ddlEstado.Text = gvCarreras.Rows(gvCarreras.SelectedIndex).Cells(4).Text

    End Sub
    'Metodo que logra que despues de registrar informacion , los campos queden libres y sin informacion de manera que la limpia
    Public Sub limpiar()


        txtIDCarrera.ReadOnly = False
        txtNombre.Text = ""
        ddlEstado.Text = ""
        ddlEstado.Text = ""

        btnRegistar.Visible = True

    End Sub
End Class