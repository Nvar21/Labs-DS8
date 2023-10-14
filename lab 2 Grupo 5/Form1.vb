Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = 1080
        Me.Height = 750
        Me.StartPosition = FormStartPosition.Manual
        Me.Location = New Point(200, 150) ' Cambia las coordenadas X e Y según tus necesidades.
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Close()
    End Sub
End Class
