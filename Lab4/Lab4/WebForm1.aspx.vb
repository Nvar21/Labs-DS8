Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim costoInicial, gananciaVend, impuesto, costoFinal As Double
        costoInicial = Val(txtCosto.Text)
        gananciaVend = 0.12
        impuesto = 0.06
        costoFinal = costoInicial + (costoInicial * gananciaVend)
        txtResult.Text = "El costo final del automóvil es: " + costoFinal.ToString()
    End Sub

End Class