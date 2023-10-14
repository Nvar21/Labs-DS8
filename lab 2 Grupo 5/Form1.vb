Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = 1080
        Me.Height = 750
        Me.StartPosition = FormStartPosition.Manual
        Me.Location = New Point(200, 150) ' Cambia las coordenadas X e Y según tus necesidades.
        IsMdiContainer = True

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Close()
    End Sub
    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked
        Dim formulario As Form = Nothing

        Select Case e.ClickedItem.Name
            Case "smiEnun1"
                formulario = New frmEnunciado1()
            Case "smiEnun2"
                formulario = New frmEnunciado2()
                'Case "smiEnun3"
                '    formulario = New frmEnunciado3()
                'Case "smiEnun4"
                '    formulario = New frmEnunciado4()
                'Case "smiEnun5"
                '    formulario = New frmEnunciado5()
                'Case "smiEnun6"
                '    formulario = New frmEnunciado6()
        End Select

        If formulario IsNot Nothing Then
            formulario.MdiParent = Me
            formulario.WindowState = FormWindowState.Maximized
            formulario.Show()
        End If
    End Sub

End Class
