Public Class frmEnunciado3
    Private Sub btnConvertir_Click(sender As Object, e As EventArgs) Handles txtNumero.TextChanged
        ' Obtén el número entero del cuadro de texto (suponiendo que se ingrese un número válido)
        Dim numeroOriginal As Integer
        If String.IsNullOrEmpty(txtNumero.Text) Then
            lblPrueba.Show()
            lblPrueba.Text = "No puede dejar vacío campo de número"
            lblPrueba.ForeColor = Color.FromArgb(233, 213, 2) 'Amarillo de Alerta
            txtResultado.Text = ""
        Else
            If Integer.TryParse(txtNumero.Text, numeroOriginal) Then
                lblPrueba.Show()
                lblPrueba.Text = "Valor Válido"
                lblPrueba.ForeColor = Color.FromArgb(153, 204, 51) 'Verde de Correcto
                ' Llama a la función del modulo para invertir el número
                Dim numeroInvertido As Integer = Integer.Parse(Inversion(numeroOriginal.ToString()))
                ' Muestra el número invertido en un cuadro de texto
                txtResultado.Text = numeroInvertido.ToString()
            Else ' Manejo de errores si la entrada no es un número válido
                lblPrueba.Show()
                lblPrueba.Text = "Tipo de dato Incorrecto, no ingrese letras o caracteres"
                txtResultado.Text = ""
                lblPrueba.ForeColor = Color.FromArgb(255, 153, 102) 'Rojo de Incorrecto
            End If
        End If

    End Sub
End Class