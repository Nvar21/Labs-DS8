Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports MySql.Data.MySqlClient

Public Class FrmTransacciones
    Dim cuentaSeleccionada As Cuenta
    Private Sub FrmTransacciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTitulo.Left = Me.Width / 2 - (lblTitulo.Width / 2)
        panelTransaccion.Left = Me.Width / 2 - (panelTransaccion.Width / 2)

        Dim listaClientes As List(Of Cliente) = obtener_clientes()

        ' poblar cmbCliente con los datos obtenidos del modulo
        cmbCliente.DataSource = listaClientes
        cmbCliente.DisplayMember = "IdNombreApellido"
        cmbCliente.ValueMember = "id_cliente"
    End Sub
    Private Sub cmbTipoCuenta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCliente.SelectionChangeCommitted

        If cmbCliente.SelectedValue IsNot Nothing Then
            cmbTipoCuenta.Enabled = True
            Dim p_id_cliente As Integer = 1

            p_id_cliente = cmbCliente.SelectedValue
            Dim listaCuentas As List(Of Cuenta) = obtener_cuentas(p_id_cliente)
            cmbTipoCuenta.DataSource = listaCuentas
            cmbTipoCuenta.DisplayMember = "IdTipoSaldo"
            cmbTipoCuenta.ValueMember = "id_cuenta"

        Else ' si no hay cliente seleccionado no se habilita la seleccion de cuenta
            cmbTipoCuenta.Enabled = False
        End If
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        If cuentaSeleccionada IsNot Nothing Then
            Dim p_id_cuenta As Integer = cuentaSeleccionada.id_cuenta
            Dim p_saldo As Double = txtSaldo.Text
            If rdbDeposito.Checked Then
                realizar_deposito(p_id_cuenta, p_saldo)
            ElseIf rdbRetiro.Checked Then
                realizar_retiro(p_id_cuenta, p_saldo)
            End If
        End If
    End Sub

    Private Sub rdbRetiro_rdbDeposito_CheckedChanged(sender As Object, e As EventArgs) Handles txtSaldo.TextChanged, rdbRetiro.CheckedChanged, rdbDeposito.CheckedChanged
        If rdbDeposito.Checked Or rdbRetiro.Checked Then
            txtSaldo.Enabled = True
        Else
            txtSaldo.Enabled = False
        End If

        If cuentaSeleccionada IsNot Nothing Then
            If IsNumeric(txtSaldo.Text) Then
                Dim saldo As Double = txtSaldo.Text

                If saldo > 0 Then
                    If rdbDeposito.Checked Then
                        btnRegistrar.Enabled = True
                    End If
                    If saldo > cuentaSeleccionada.saldo And rdbRetiro.Checked Then
                        btnRegistrar.Enabled = False
                    Else
                        btnRegistrar.Enabled = True
                    End If
                Else
                    btnRegistrar.Enabled = False
                End If
            Else
                btnRegistrar.Enabled = False
            End If
        End If

    End Sub

    Private Sub cmbTipoCuenta_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cmbTipoCuenta.SelectedIndexChanged
        ' Verificar si se ha seleccionado un cliente en el ComboBox
        If cmbTipoCuenta.SelectedItem IsNot Nothing AndAlso TypeOf cmbTipoCuenta.SelectedItem Is Cuenta Then
            cuentaSeleccionada = DirectCast(cmbTipoCuenta.SelectedItem, Cuenta)
        End If
    End Sub
End Class
