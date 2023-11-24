Public Class FrmEditarCliente
    Private Sub FrmEditarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'hay que precargar los datos

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        'logica pa guardar

        'cierra el form
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        'cierra el form
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

End Class