Public Class frmEnunciado1
    Dim ventas As New Ventas
    Private Sub btnIniciar_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click

        Dim numVentas As Integer = txtNumVentas.Text

        For i As Integer = 1 To numVentas
            Dim venta As Double
            Dim input As String

            input = InputBox("Ingrese el monto de la venta n° " & i, "Venta " & i)

            If Double.TryParse(input, venta) Then
                ventas.RegistrarVenta(venta)
            Else
                MessageBox.Show("Ingrese un valor válido.", "Error")
                Exit For
            End If
        Next

        txtCantidad1.Text = ventas.ObtenerCantVentas1().ToString()
        txtCantidad2.Text = ventas.ObtenerCantVentas2().ToString()
        txtCantidad3.Text = ventas.ObtenerCantVentas3().ToString()
        txtMonto1.Text = ventas.ObtenerMontoVentas1().ToString("C")
        txtMonto2.Text = ventas.ObtenerMontoVentas2().ToString("C")
        txtMonto3.Text = ventas.ObtenerMontoVentas3().ToString("C")

        txtCantidadTotal.Text = ventas.ObtenerCantVentasTotal().ToString()
        txtMontoTotal.Text = ventas.ObtenerMontoVentasTotal().ToString("C")
    End Sub
End Class