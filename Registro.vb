Imports clases
Public Class Registro
    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click

        Dim empleado1 As empleado = New empleado()

        empleado1.Apellidos = txtApellidos.Text
        empleado1.Nombres = txtNombres.Text
        empleado1.Documentos = txtDocumentos.Text
        empleado1.Tipo = cboxTipo.Text
        empleado1.TipoContrato = cboxContrato.Text

        empleado1.calcularsueldo(750)

        dgvRegistrar.Rows.Insert(0, empleado1.Tipo, empleado1.Apellidos, empleado1.Nombres, empleado1.Documentos, empleado1.Sueldo)



    End Sub
End Class