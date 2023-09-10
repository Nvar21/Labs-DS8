Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Enunciado2

    'Validar que se ingresen solo numeros del 0 al 2 en el textbox de el genero del accidentado
    Private Sub txtGenero_TextChanged(sender As Object, e As EventArgs) Handles txtGenero.TextChanged
        Dim genero As String = txtGenero.Text

        If String.IsNullOrEmpty(genero) Then
            Return
        End If

        If Not (genero = "0" Or genero = "1" Or genero = "2") Then
            MsgBox("Ingresar un valor válido para el género (0 a 2)")
            txtGenero.Clear()
        End If

        If genero = "0" Then
            btnCalcular.Enabled = True
        End If
        If String.IsNullOrEmpty(txtGenero.Text) Then
            btnCalcular.Enabled = False
        End If
    End Sub


    Private Sub txtEdad_TextChanged(sender As Object, e As EventArgs) Handles txtEdad.TextChanged

        If String.IsNullOrEmpty(txtEdad.Text) Then
            Return
        Else
            If IsNumeric(txtEdad.Text) Then
                Dim edad As Integer = txtEdad.Text
                If edad < 0 Then
                    MsgBox("Ingresar una edad válida")
                    txtEdad.Clear()
                    Return
                End If
            Else
                MsgBox("No se admiten para la edad," & vbCrLf & "valores que no sean números: " & txtEdad.Text)
                txtEdad.Clear()
            End If
        End If

    End Sub
End Class