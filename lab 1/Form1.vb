Public Class Form1

    Private Sub btnEnun1_Click(sender As Object, e As EventArgs) Handles btnEnun1.Click
        Enunciado1.Show()
        Enunciado2.Close()
        Enunciado3.Close()
        Enunciado4.Close()
        Enunciado5.Close()
        Enunciado6.Close()
    End Sub

    Private Sub btnEnun2_Click(sender As Object, e As EventArgs) Handles btnEnun2.Click
        Enunciado2.Show()
        Enunciado1.Close()
        Enunciado3.Close()
        Enunciado4.Close()
        Enunciado5.Close()
        Enunciado6.Close()
    End Sub

    Private Sub btnEnun3_Click(sender As Object, e As EventArgs) Handles btnEnun3.Click
        Enunciado3.Show()
        Enunciado2.Close()
        Enunciado1.Close()
        Enunciado4.Close()
        Enunciado5.Close()
        Enunciado6.Close()

    End Sub

    Private Sub btnEnun4_Click(sender As Object, e As EventArgs) Handles btnEnun4.Click
        Enunciado4.Show()
        Enunciado2.Close()
        Enunciado3.Close()
        Enunciado1.Close()
        Enunciado5.Close()
        Enunciado6.Close()
    End Sub

    Private Sub btnEnun5_Click(sender As Object, e As EventArgs) Handles btnEnun5.Click
        Enunciado5.Show()
        Enunciado2.Close()
        Enunciado3.Close()
        Enunciado4.Close()
        Enunciado1.Close()
        Enunciado6.Close()
    End Sub

    Private Sub btnEnun6_Click(sender As Object, e As EventArgs) Handles btnEnun6.Click
        Enunciado6.Show()
        Enunciado2.Close()
        Enunciado3.Close()
        Enunciado4.Close()
        Enunciado5.Close()
        Enunciado1.Close()
    End Sub
End Class
