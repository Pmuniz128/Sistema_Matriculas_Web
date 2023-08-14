Public Class frmRegistroCursos
    Inherits System.Web.UI.Page
    'Metodo de pagina de carga se encarga de validar si el usuario es existente y redirecciona a la pagina pricipal
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim eCursos As Entidades.Cursos = CType(Session("Cursos"), Entidades.Cursos)

        If eCursos Is Nothing Then
            FormsAuthentication.RedirectFromLoginPage("", False)

        End If
        consultaGeneral()
    End Sub
    'Boton de registrar cuando se le da click ingresa todos los datos y los asigna
    Protected Sub btnRegistar_Click(sender As Object, e As EventArgs)

        Try
            Dim eCurso As New Entidades.Cursos
            eCurso.ID_CURSO = txtIDCurso.Text
            eCurso.DES_NOMBRE = txtNombre.Text
            eCurso.NUM_CREDITOS = txtCreditos.Text
            eCurso.NUM_NOTA_MINIMA = txtNotaMin.Text
            eCurso.NUM_CUPO_MINIMO = txtCupoMin.Text
            eCurso.NUM_CUPO_MAXIMO = txtCupoMax.Text
            eCurso.NUM_CUPO_GRADO = ddlGrado.Text
            eCurso.DES_ESTADO = ddlEstado.Text
            eCurso.NUM_COSTO = txtCosto.Text
            eCurso.ID_CARRERA = txt_IDCarrera.Text

            Dim iCurso As New Negocios.Cursos
            iCurso.mantenimiento(1, eCurso)
            ScriptManager.RegisterStartupScript(Me, GetType(Page), "Alerta", "javascript:alert('Se agrego el Curso Exitosamente');", True)
            consultaGeneral()
            limpiar()

        Catch ex As Exception

        End Try

    End Sub
    'Metodo que le asigna al greadview la informacion ingresada
    Public Sub consultaGeneral()
        Dim icursos As New Negocios.Cursos
        gvCursos.DataSource = icursos.consultaGeneralNegocios
        gvCursos.DataBind()

    End Sub
    'Asocia el grid a cada columna , fila la informacion para que se vea ordenada

    Protected Sub gvEmpleado_SelectedIndexChanged(sender As Object, e As EventArgs)

        txtIDCurso.ReadOnly = True

        txtIDCurso.Text = gvCursos.Rows(gvCursos.SelectedIndex).Cells(1).Text
        txtNombre.Text = gvCursos.Rows(gvCursos.SelectedIndex).Cells(2).Text
        txtCreditos.Text = gvCursos.Rows(gvCursos.SelectedIndex).Cells(3).Text
        txtNotaMin.Text = gvCursos.Rows(gvCursos.SelectedIndex).Cells(4).Text
        txtCupoMin.Text = gvCursos.Rows(gvCursos.SelectedIndex).Cells(5).Text
        txtCupoMax.Text = gvCursos.Rows(gvCursos.SelectedIndex).Cells(6).Text
        ddlGrado.Text = gvCursos.Rows(gvCursos.SelectedIndex).Cells(7).Text
        ddlEstado.Text = gvCursos.Rows(gvCursos.SelectedIndex).Cells(8).Text
        txtCosto.Text = gvCursos.Rows(gvCursos.SelectedIndex).Cells(9).Text
        txt_IDCarrera.Text = gvCursos.Rows(gvCursos.SelectedIndex).Cells(10).Text

    End Sub
    'Metodo que logra que despues de registrar informacion , los campos queden libres y sin informacion de manera que la limpia
    Public Sub limpiar()


        txtIDCurso.ReadOnly = False
        txtNombre.Text = ""
        txtCreditos.Text = ""
        txtNotaMin.Text = ""
        txtCupoMin.Text = ""
        txtCupoMax.Text = ""
        ddlGrado.Text = ""
        ddlEstado.Text = ""
        txtCosto.Text = ""
        txt_IDCarrera.Text = ""

        btnRegistar.Visible = True

    End Sub
End Class