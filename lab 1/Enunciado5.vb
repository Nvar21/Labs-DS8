Public Class Enunciado5
    Dim desEfectivo As Double = 12.4
    Dim desCheque As Double = 8.6
    Dim desTarjeta As Double = 4.5
    Dim desClave As Double = 2.5

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click


        If String.IsNullOrEmpty(txtPrecio.Text) Or String.IsNullOrEmpty(txtUnidades.Text) Then
            MsgBox("Debe rellenar ambos campos de Precio Individual y Total a vender para continuar")
        Else
            Dim precioInd As Double = txtPrecio.Text
            Dim totalVent As Double = txtUnidades.Text
            Dim precioFinal = precioInd * totalVent
            If rdbEfectivo.Checked Then
                txtPrecioOG.Text = precioFinal & "$"
                txtDescuento.Text = desEfectivo & "$"
                txtTotalPagar.Text = (precioFinal) - ((desEfectivo / 100) * precioFinal) & "$"
            ElseIf rdbCheque.Checked Then
                txtPrecioOG.Text = precioFinal & "$"
                txtDescuento.Text = desCheque & "$"
                txtTotalPagar.Text = (precioFinal) - ((desCheque / 100) * precioFinal) & "$"
            ElseIf rdbTarjeta.Checked Then
                txtPrecioOG.Text = precioFinal & "$"
                txtDescuento.Text = desTarjeta & "$"
                txtTotalPagar.Text = (precioFinal) - ((desTarjeta / 100) * precioFinal) & "$"
            ElseIf rdbClave.Checked Then
                txtPrecioOG.Text = precioFinal & "$"
                txtDescuento.Text = desClave & "$"
                txtTotalPagar.Text = (precioFinal) - ((desClave / 100) * precioFinal) & "$"
            End If
        End If
    End Sub
End Class