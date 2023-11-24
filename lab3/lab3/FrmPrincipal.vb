Public Class FrmPrincipal
    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim altoTotal As Integer = ToolStrip1.Height - ToolStrip1.Padding.Top - ToolStrip1.Padding.Bottom
        Dim altoItems As Integer = altoTotal / ToolStrip1.Items.Count

        For Each item As ToolStripItem In ToolStrip1.Items
            item.Height = altoItems
        Next

        'muestra por default el frmInicio
        FrmInicio.MdiParent = Me
        FrmInicio.WindowState = FormWindowState.Maximized
        FrmInicio.Show()
    End Sub

    Private Sub tslRegistrarCliente_Click(sender As Object, e As EventArgs) Handles tslRegistrarCliente.Click
        FrmRegistrarClientes.MdiParent = Me
        FrmRegistrarClientes.WindowState = FormWindowState.Maximized
        FrmRegistrarClientes.Show()

        'cerrar otros forms
        FrmCrearCuentas.Close()
        FrmTransacciones.Close()
        FrmVerMovimientos.Close()
        FrmInicio.Close()
    End Sub

    Private Sub tslCrearCuenta_Click(sender As Object, e As EventArgs) Handles tslCrearCuenta.Click
        FrmCrearCuentas.MdiParent = Me
        FrmCrearCuentas.WindowState = FormWindowState.Maximized
        FrmCrearCuentas.Show()

        'cerrar otros forms
        FrmRegistrarClientes.Close()
        FrmTransacciones.Close()
        FrmVerMovimientos.Close()
        FrmInicio.Close()
    End Sub

    Private Sub tslTransacciones_Click(sender As Object, e As EventArgs) Handles tslTransacciones.Click
        FrmTransacciones.MdiParent = Me
        FrmTransacciones.WindowState = FormWindowState.Maximized
        FrmTransacciones.Show()

        'cerrar otros forms
        FrmRegistrarClientes.Close()
        FrmCrearCuentas.Close()
        FrmVerMovimientos.Close()
        FrmInicio.Close()
    End Sub

    Private Sub tslVerMovimientos_Click(sender As Object, e As EventArgs) Handles tslVerMovimientos.Click
        FrmVerMovimientos.MdiParent = Me
        FrmVerMovimientos.WindowState = FormWindowState.Maximized
        FrmVerMovimientos.Show()

        'cerrar otros forms
        FrmRegistrarClientes.Close()
        FrmTransacciones.Close()
        FrmCrearCuentas.Close()
        FrmInicio.Close()
    End Sub

    Private Sub tlsInicio_Click(sender As Object, e As EventArgs) Handles tlsInicio.Click
        FrmInicio.MdiParent = Me
        FrmInicio.WindowState = FormWindowState.Maximized
        FrmInicio.Show()

        'cerrar otros forms
        FrmRegistrarClientes.Close()
        FrmTransacciones.Close()
        FrmVerMovimientos.Close()
        FrmCrearCuentas.Close()
    End Sub

End Class
