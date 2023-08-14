Public Class frmRegistroCarreras
    Inherits System.Web.UI.Page

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

End Class