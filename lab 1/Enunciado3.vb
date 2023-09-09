Public Class Enunciado3
    Private Sub btnEjecutar_Click(sender As Object, e As EventArgs) Handles btnEjecutar.Click
        Dim num As Integer
        If Integer.TryParse(txtNumLim.Text, num) Then
            If num > 0 Then
                MostrarNumPerfectos(num)
            Else
                MsgBox("El número debe ser mayor que 0.")
            End If
        Else
            MsgBox("Debe ingresar un valor númerico.")
        End If

    End Sub

    Private Sub MostrarNumPerfectos(ByVal limite As Integer)
        txtResultado.Clear()
        For i As Integer = 1 To limite
            If NumPerfecto(i) Then
                txtResultado.AppendText(" > " & i & " es un número perfecto")
                MostrarDivisores(i)
            End If
        Next
    End Sub

    Public Function NumPerfecto(ByVal num As Integer) As Boolean
        Dim sumaDivisores As Integer = 0
        For i As Integer = 1 To num - 1
            If num Mod i = 0 Then
                sumaDivisores += i
            End If
        Next

        Return sumaDivisores = num
    End Function

    Private Sub MostrarDivisores(ByVal num As Integer)
        Dim divisores As String = "     Sus divisores son: "

        For i As Integer = 1 To num - 1
            If num Mod i = 0 Then
                divisores &= i & ", "
            End If
        Next

        txtResultado.AppendText(Environment.NewLine & divisores & Environment.NewLine)
    End Sub
End Class