Public Class FrmPrincipal
    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim altoTotal As Integer = ToolStrip1.Height - ToolStrip1.Padding.Top - ToolStrip1.Padding.Bottom

        Dim altoItems As Integer = altoTotal / ToolStrip1.Items.Count

        For Each item As ToolStripItem In ToolStrip1.Items
            item.Height = altoItems
        Next
    End Sub

    Private Sub tslRegistrarCliente_Click(sender As Object, e As EventArgs) Handles tslRegistrarCliente.Click
        FrmRegistrarClientes.MdiParent = Me
        FrmRegistrarClientes.WindowState = FormWindowState.Maximized
        FrmRegistrarClientes.Show()
    End Sub

    Private Sub tslCrearCuenta_Click(sender As Object, e As EventArgs) Handles tslCrearCuenta.Click
        FrmCrearCuentas.MdiParent = Me
        FrmCrearCuentas.WindowState = FormWindowState.Maximized
        FrmCrearCuentas.Show()
    End Sub

    Private Sub tslTransacciones_Click(sender As Object, e As EventArgs) Handles tslTransacciones.Click
        FrmTransacciones.MdiParent = Me
        FrmTransacciones.WindowState = FormWindowState.Maximized
        FrmTransacciones.Show()
        FrmTransacciones.Panel1.Left = Me.Width / 2 - (FrmTransacciones.Panel1.Width / 2)
        FrmTransacciones.Panel1.Top = Me.Height / 2 - (FrmTransacciones.Panel1.Height / 2)
    End Sub

    Private Sub tslVerMovimientos_Click(sender As Object, e As EventArgs) Handles tslVerMovimientos.Click
        FrmVerMovimientos.MdiParent = Me
        FrmVerMovimientos.WindowState = FormWindowState.Maximized
        FrmVerMovimientos.Show()
    End Sub


End Class
