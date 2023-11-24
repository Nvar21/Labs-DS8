Public Class FrmVerMovimientos
    Dim clienteSeleccionado As Cliente
    Private Sub FrmVerMovimientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTitulo.Left = Me.Width / 2 - (lblTitulo.Width / 2)
        GroupBox1.Left = Me.Width / 2 - (GroupBox1.Width / 2)
        dgvMovimientos.Left = Me.Width / 2 - (dgvMovimientos.Width / 2)

        'margin entre controles
        lblTitulo.Margin = New Padding(20, 0, 0, 0)
        GroupBox1.Margin = New Padding(10, 0, 0, 0)
        dgvMovimientos.Margin = New Padding(10, 0, 0, 0)


        'para poblar el cmbCliente
        Dim listaClientes As List(Of Cliente) = obtener_clientes()
        ' poblar cmbCliente con los datos obtenidos del modulo
        cmbCliente.DataSource = listaClientes
        cmbCliente.DisplayMember = "IdNombreApellido"
        cmbCliente.ValueMember = "id_cliente"
    End Sub

    Private Sub cmbCliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCliente.SelectedIndexChanged
        Dim p_id_cliente As Integer = 1
        ' Verificar si se ha seleccionado un cliente en el ComboBox
        If cmbCliente.SelectedItem IsNot Nothing AndAlso TypeOf cmbCliente.SelectedItem Is Cliente Then
            clienteSeleccionado = DirectCast(cmbCliente.SelectedItem, Cliente)
        End If
        p_id_cliente = clienteSeleccionado.id_cliente
        Dim ListaMovimiento As List(Of Movimiento) = obtener_movimientos_cliente(p_id_cliente)
        dgvMovimientos.DataSource = ListaMovimiento
    End Sub

    Private Sub pbEditar_Click(sender As Object, e As EventArgs) Handles pbEditar.Click
        FrmEditarCliente.Show()
    End Sub
End Class