Public Class Enunciado6
    Private Sub btnEjecutar_Click(sender As Object, e As EventArgs) Handles btnEjecutar.Click
        Dim vectorNombres(3) As String
        Dim vectorVotos(3) As Integer
        Dim ganador As String = ""
        Dim perdedor As String = ""
        Dim maxVotos As Integer = Integer.MinValue
        Dim minVotos As Integer = Integer.MaxValue

        For i As Integer = 0 To 3
            Dim nombre As String = InputBox("Ingrese el nombre del candidato " & (i + 1), "Registro de Votos")
            Dim votos As Integer = Val(InputBox("Ingrese la cantidad de votos para " & nombre, "Registro de Votos"))

            'Dim nombre As String = DirectCast(Me.Controls("txtCand" & (i + 1)), TextBox).Text
            'Dim votos As Integer = Val(DirectCast(Me.Controls("txtVotos" & (i + 1)), TextBox).Text)

            vectorNombres(i) = nombre
            vectorVotos(i) = votos

            If votos > maxVotos Then
                maxVotos = votos
                ganador = nombre
            End If

            If votos < minVotos Then
                minVotos = votos
                perdedor = nombre
            End If
        Next

        txtResultado.Text = "El ganador de la elección es: " & ganador & vbCrLf & "El candidato con menos votos fue: " & perdedor
    End Sub
End Class