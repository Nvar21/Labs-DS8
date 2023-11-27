Public Class FrmCrearCuentas
    Dim clienteSeleccionado As Cliente
    Dim p_id_cliente As Integer = 1

    'al cargarse el form, obtiene los datos de los clientes para poblar el combobox cmbCliente
    Private Sub FrmCrearCuentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label5.Left = Me.Width / 2 - (Label5.Width / 2)
        GroupBox1.Left = Me.Width / 2 - (GroupBox1.Width / 2)

        Dim listaClientes As List(Of Cliente) = obtener_clientes()

        ' poblar cmbCliente con los datos obtenidos del modulo
        cmbCliente.DataSource = listaClientes
        cmbCliente.DisplayMember = "IdNombreApellido"
        cmbCliente.ValueMember = "id_cliente"
    End Sub

    'se ejecuta cuando el usuario seleccione otro indice del cmbCliente
    Private Sub cmbCliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCliente.SelectedIndexChanged
        If cmbCliente.SelectedValue IsNot Nothing Then
            ' se valida primero si no está vacío el cmbCliente
            ' de no estar vacío, se habilita el txtSaldo para definir un saldo inicial
            txtSaldo.Enabled = True
        Else
            ' si está vacío el combobox, no se puede ingresar un saldo inicial para la nueva cuenta
            txtSaldo.Enabled = False
        End If
    End Sub

        ' tambien se ejecuta cuando el usuario seleccione otro indice del cmbCliente, en este, 
        ' se asigna a la instancia de la clase Cliente, clienteSeleccionado, el cliente que se encuentre seleccionado
    Private Sub cmbCliente_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cmbCliente.SelectedIndexChanged
        ' Verificar si se ha seleccionado un cliente en el ComboBox
        If cmbCliente.SelectedItem IsNot Nothing AndAlso TypeOf cmbCliente.SelectedItem Is Cliente Then
            clienteSeleccionado = DirectCast(cmbCliente.SelectedItem, Cliente)
        End If
    End Sub

    ' se ejecuta cuando el texboxt del saldo inicial cambia
    Private Sub txtSaldo_TextChanged(sender As Object, e As EventArgs) Handles txtSaldo.TextChanged
        If IsNumeric(txtSaldo.Text) Then 'se verifica si lo que hay en el txtSaldo es un numero
            ' se declara la variable saldo obteniendo lo que haya en el txtSaldo
            Dim saldo As Double = txtSaldo.Text
            
            If saldo > 0 Then ' se valida que el saldo sea positivo
                If rdbCuentAhorro.Checked Or rdbCuentCorriente.Checked Then
                    ' si está seleccionado uno de los dos radiobutton, se habilita el boton de crear 
                    btnCrear.Enabled = True
                Else ' si no esta seleccionado un radiobuton, se inhabilita el boton y no se puede crear una cuenta 
                    btnCrear.Enabled = False
                End If
            End If
        End If
    End Sub

    ' cuando el usuario presiona el boton para crear la cuenta
    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        'Se declaran variables p_... que se refieren a los parametros enviados al procedimiento almacenado
        Dim p_id_cliente As Integer = clienteSeleccionado.id_cliente
        Dim p_saldo As Double = txtSaldo.Text
        Dim p_tipo_cuenta As String
        ' se obtiene el tipo de cuenta dependiendo del radiobutton seleccionado
        If rdbCuentAhorro.Checked Then
            p_tipo_cuenta = rdbCuentAhorro.Text
        Else
            p_tipo_cuenta = rdbCuentCorriente.Text
        End If
        ' se hace llamado a la función del módulo crear_cuenta() enviando los datos necesarios
        crear_cuenta(p_id_cliente, p_tipo_cuenta, p_saldo)
    End Sub

End Class
