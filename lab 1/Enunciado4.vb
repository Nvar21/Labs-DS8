Public Class Enunciado4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim number As Integer
        number = Val(txtNum.Text)
        Dim seque As String
        seque = number.ToString()

        If number > 0 Then
            txtResult.Clear()

            While number <> 1
                If number Mod 2 = 0 Then
                    number /= 2
                Else
                    number = (number * 3) + 1
                End If

                seque &= ", " & number.ToString()
            End While
            txtResult.Text = seque

        Else
            MessageBox.Show("Ingrese un número entero positivo que sea mayor a 0", "ERROR")
        End If
    End Sub
End Class






