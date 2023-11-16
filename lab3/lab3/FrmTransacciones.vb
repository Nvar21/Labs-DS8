Public Class FrmTransacciones
    Private Sub FrmTransacciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTitulo.Left = Me.Width / 2 - (lblTitulo.Width / 2)
        panelTransaccion.Left = Me.Width / 2 - (panelTransaccion.Width / 2)
        panelTransaccion.Top = Me.Height / 2 - (panelTransaccion.Height / 2)
    End Sub
End Class