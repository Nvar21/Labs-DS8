Public Class FrmCrearCuentas
    Dim clienteSeleccionado As Cliente
    Dim p_id_cliente As Integer = 1
    Private Sub FrmCrearCuentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label5.Left = Me.Width / 2 - (Label5.Width / 2)
        GroupBox1.Left = Me.Width / 2 - (GroupBox1.Width / 2)

        Dim listaClientes As List(Of Cliente) = obtener_clientes()

        ' poblar cmbCliente con los datos obtenidos del modulo
        cmbCliente.DataSource = listaClientes
        cmbCliente.DisplayMember = "IdNombreApellido"
        cmbCliente.ValueMember = "id_cliente"
    End Sub

    Private Sub cmbCliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCliente.SelectedIndexChanged
        If cmbCliente.SelectedValue IsNot Nothing Then
            txtSaldo.Enabled = True
        Else
            txtSaldo.Enabled = False
        End If
    End Sub

    Private Sub txtSaldo_TextChanged(sender As Object, e As EventArgs) Handles txtSaldo.TextChanged
        If IsNumeric(txtSaldo.Text) Then
            Dim saldo As Double = txtSaldo.Text
            If saldo > 0 Then
                If rdbCuentAhorro.Checked Or rdbCuentCorriente.Checked Then
                    btnCrear.Enabled = True
                Else
                    btnCrear.Enabled = False
                End If
            End If
        End If
    End Sub

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        Dim p_id_cliente As Integer = clienteSeleccionado.id_cliente
        Dim p_saldo As Double = txtSaldo.Text
        Dim p_tipo_cuenta As String
        If rdbCuentAhorro.Checked Then
            p_tipo_cuenta = rdbCuentAhorro.Text
        Else
            p_tipo_cuenta = rdbCuentCorriente.Text
        End If
        crear_cuenta(p_id_cliente, p_tipo_cuenta, p_saldo)

    End Sub

    Private Sub cmbCliente_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cmbCliente.SelectedIndexChanged
        ' Verificar si se ha seleccionado un cliente en el ComboBox
        If cmbCliente.SelectedItem IsNot Nothing AndAlso TypeOf cmbCliente.SelectedItem Is Cliente Then
            clienteSeleccionado = DirectCast(cmbCliente.SelectedItem, Cliente)
        End If

    End Sub
End Class