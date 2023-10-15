Public Class frmEnunciado4
    Private Sub BtnCalcular_Click(sender As Object, g As EventArgs) Handles btnCalcular.Click
        Dim year As Integer
        If Integer.TryParse(txtYear.Text, year) AndAlso year >= 1986 And year <= 2100 Then

            Dim A As Integer = year Mod 19
            Dim B As Integer = year Mod 4
            Dim C As Integer = year Mod 7
            Dim D As Integer = (19 * A + 24) Mod 30
            Dim E As Integer = (2 * B + 4 * C + 6 * D + 5) Mod 7
            Dim N As Integer = 22 + D + E

            If N <= 31 Then
                MsgBox("La fecha de Pascua en el año " & year & " es el Domingo " & N & " de marzo.", MsgBoxStyle.Information, "Mensaje")
            Else N -= 31
                MsgBox("La fecha de Pascua en el año " & year & " es el Domingo " & N & " de abril.", MsgBoxStyle.Information, "Mensaje")
            End If
        Else
            MsgBox("Por favor, ingrese un año válido.", MsgBoxStyle.Information, "ERROR")
        End If
    End Sub
End Class

