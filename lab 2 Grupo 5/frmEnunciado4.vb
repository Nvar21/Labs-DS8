Public Class frmEnunciado4
    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        'Variable para almacenar el año ingresado.
        Dim year As Integer = Integer.Parse(txtYear.Text)

        ' Validar si el año ingresado es un número válido
        ' (Esta fórmula y sus coeficientes 24 y 5 son válidos desde el año 1900 hasta el 2100.)
        If Integer.TryParse(txtYear.Text, year) AndAlso year >= 1900 And year <= 2100 Then
            ' El resultado se almacena en "fechaPascua"
            Dim fechaPascua As DateTime = CalcularDomingo(year)
            MsgBox("El domingo de Pascua en el año " & year & " es el " & fechaPascua.ToString("d 'de' MMMM", New System.Globalization.CultureInfo("es-ES")), MsgBoxStyle.Information, "MENSAJE")
        Else
            MsgBox("Por favor, ingrese un año válido.", MsgBoxStyle.Information, "ERROR")
        End If
    End Sub
End Class

