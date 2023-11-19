Public Class FrmRegistrarClientes
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) 

    End Sub

    Private Sub Validar_TextBoxs(sender As Object, e As EventArgs) Handles txtNombre.TextChanged, txtApellido.TextChanged, txtTelefono.TextChanged, txtDireccion.TextChanged
        'imprimir cual es el que ha cambiado
        If IsNumeric(sender.text) Then
            sender.BackColor = Color.FromArgb(233, 213, 2) 'Amarillo de Alerta
            btnRegistrar.Enabled = False
        Else
            sender.BackColor = Color.FromArgb(153, 204, 51) 'Verde de Correcto
            btnRegistrar.Enabled = True
        End If

        If sender Is txtTelefono Then
            If IsNumeric(txtTelefono.Text) Then
                sender.BackColor = Color.FromArgb(153, 204, 51) 'Verde de Correcto
                btnRegistrar.Enabled = True
            Else
                sender.BackColor = Color.FromArgb(233, 213, 2) 'Amarillo de Alerta
                btnRegistrar.Enabled = False
            End If
        End If
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        'llamado a la funcion para registrar el cliente nuevo
        Dim nombre As String = txtNombre.Text
        Dim apellido As String = txtApellido.Text
        Dim telefono As String = txtTelefono.Text
        Dim direccion As String = txtDireccion.Text

        crear_cliente(nombre, apellido, telefono, direccion)
    End Sub
End Class