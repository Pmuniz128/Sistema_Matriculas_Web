Imports Negocios

Public Class frmRegistroEstudiantes
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim eEstudiantes As Entidades.EstudianteEnt = CType(Session("Estudiantes"), Entidades.EstudianteEnt)

        If eEstudiantes Is Nothing Then
            FormsAuthentication.RedirectFromLoginPage("", False)

        End If
        consultaGeneral()
    End Sub
    'Boton de registrar cuando se le da click ingresa todos los datos y los asigna
    Protected Sub btnRegistar_Click(sender As Object, e As EventArgs)

        Try
            Dim eEstudiantes As New Entidades.EstudianteEnt
            eEstudiantes.CodigoCarnet = txtCarnet.Text
            eEstudiantes.Identificacion = txtIdentif.Text
            eEstudiantes.Nombre = txtNombre.Text
            eEstudiantes.CarrerasMatriculadas = txtCarrera.Text
            eEstudiantes.NumeroTelefono = txtTelef.Text
            eEstudiantes.Email = txtCorreo.Text
            '' eEstudiantes.FechaNacimiento = dtpFecha.Text
            eEstudiantes.DireccionExacta = txtDirec.Text
            eEstudiantes.Beca = txtBeca.Text


            Dim iEstudiantes As New Negocios.Estudiante
            iEstudiantes.mantenimiento(1, eEstudiantes)
            ScriptManager.RegisterStartupScript(Me, GetType(Page), "Alerta", "javascript:alert('Se agrego el Estudiante Exitosamente');", True)
            consultaGeneral()
            limpiar()

        Catch ex As Exception

        End Try

    End Sub

    'Metodo que le asigna al greadview la informacion ingresada
    Public Sub consultaGeneral()
        Dim icursos As New Negocios.Cursos
        gvEstudiante.DataSource = icursos.consultaGeneralCursos
        gvEstudiante.DataBind()

    End Sub
    'Asocia el grid a cada columna , fila la informacion para que se vea ordenada

    Protected Sub gvEstudiante_SelectedIndexChanged(sender As Object, e As EventArgs)

        txtCarnet.ReadOnly = True

        txtIdentif.Text = gvEstudiante.Rows(gvEstudiante.SelectedIndex).Cells(1).Text
        txtNombre.Text = gvEstudiante.Rows(gvEstudiante.SelectedIndex).Cells(2).Text
        txtCarrera.Text = gvEstudiante.Rows(gvEstudiante.SelectedIndex).Cells(3).Text
        txtTelef.Text = gvEstudiante.Rows(gvEstudiante.SelectedIndex).Cells(4).Text
        txtCorreo.Text = gvEstudiante.Rows(gvEstudiante.SelectedIndex).Cells(5).Text
        txtDirec.Text = gvEstudiante.Rows(gvEstudiante.SelectedIndex).Cells(6).Text
        ''dtpFecha.Text = gvEstudiante.Rows(gvEstudiante.SelectedIndex).Cells(7).Text
        txtBeca.Text = gvEstudiante.Rows(gvEstudiante.SelectedIndex).Cells(8).Text

    End Sub
    'Metodo que logra que despues de registrar informacion , los campos queden libres y sin informacion de manera que la limpia
    Public Sub limpiar()


        txtCarnet.ReadOnly = False
        txtIdentif.Text = ""
        txtNombre.Text = ""
        txtCarrera.Text = ""
        txtTelef.Text = ""
        txtCorreo.Text = ""
        txtDirec.Text = ""
        ''dtpFecha.Text = ""
        txtBeca.Text = ""

        txtCarnet.ReadOnly = True

        btnRegistar.Visible = True

    End Sub

End Class