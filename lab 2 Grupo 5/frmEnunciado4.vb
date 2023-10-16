Public Class frmEnunciado4
    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim year As Integer
        If Integer.TryParse(txtYear.Text, year) AndAlso year >= 1900 And year <= 2100 Then
            Dim fechaPascua As String = CalcularDomingo(year)
            MsgBox("El domingo de Pascua en el año " & year & " es el " & fechaPascua, MsgBoxStyle.Information, "MENSAJE")
        Else
            MsgBox("Por favor, ingrese un año válido.", MsgBoxStyle.Information, "ERROR")
        End If
    End Sub
End Class


