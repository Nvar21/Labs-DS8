Public Class Enunciado1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim costoInicial, gananciaVend, impuesto, costoFinal As Double
        costoInicial = Val(txtCosto.Text)
        gananciaVend = 0.12
        impuesto = 0.06
        costoFinal = costoInicial + (costoInicial * gananciaVend) + (costoInicial * impuesto)
        txtResult.Text = costoFinal
    End Sub

End Class