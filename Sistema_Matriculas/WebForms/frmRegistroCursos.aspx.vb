Public Class frmRegistroCursos
    Inherits System.Web.UI.Page

    'Boton de registrar cuando se le da click ingresa todos los datos y los asigna
    Protected Sub btnRegistar_Click(sender As Object, e As EventArgs)

        Try
            Dim eCurso As New Entidades.Cursos
            eCurso.ID_CURSO = txtIDCurso.Text
            eCurso.DES_NOMBRE = txtNombre.Text
            eCurso.NUM_CREDITOS = txtCreditos.Text
            eCurso.NUM_NOTA_MINIMA = txtNotaMin.Text
            eCurso.NUM_CUPO_MINIMO = txtCupoMin.Text
            eCurso.NUM_CUPO_MAXIMO = txtCupoMin.Text
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
End Class