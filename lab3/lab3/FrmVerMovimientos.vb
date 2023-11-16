Public Class FrmVerMovimientos
    Private Sub FrmVerMovimientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTitulo.Left = Me.Width / 2 - (lblTitulo.Width / 2)
        GroupBox1.Left = Me.Width / 2 - (GroupBox1.Width / 2)
        dgvMovimientos.Left = Me.Width / 2 - (dgvMovimientos.Width / 2)

        'margin entre controles
        lblTitulo.Margin = New Padding(20, 0, 0, 0)
        GroupBox1.Margin = New Padding(10, 0, 0, 0)
        dgvMovimientos.Margin = New Padding(10, 0, 0, 0)
    End Sub


End Class