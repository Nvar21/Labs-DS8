Imports System.IO
Imports Microsoft.VisualBasic.FileIO

Public Class frmEnunciado6
    Dim aspirantes(3) As Aspirante
    Dim contador As Integer = 0

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Dim votos As String() = File.ReadAllText("C:\Users\gutie\Downloads\Votos.csv").Split(";"c)

        ' Inicializar ganador y menosVotos con el primer candidato
        Dim ganador As Aspirante = New Aspirante("", 0)
        Dim menosVotos As Aspirante = New Aspirante("", Integer.MaxValue)

        Using parser As TextFieldParser = New TextFieldParser("C:\Users\gutie\Downloads\Votos.csv")
            parser.TextFieldType = FieldType.Delimited
            parser.SetDelimiters(";")

            While Not parser.EndOfData
                Dim row As String() = parser.ReadFields()

                If row.Length = 4 Then
                    Dim nombre As String = InputBox("Ingrese el nombre del candidato " & (contador + 1) & "; ")
                    Dim votosAspirante As Integer

                    If Integer.TryParse(row(contador), votosAspirante) Then
                        aspirantes(contador) = New Aspirante(nombre, votosAspirante)

                        ' Actualizar ganador y menosVotos dentro del bucle
                        If aspirantes(contador).CantidadVotos > ganador.CantidadVotos Then
                            ganador = aspirantes(contador)
                        End If

                        If aspirantes(contador).CantidadVotos < menosVotos.CantidadVotos Then
                            menosVotos = aspirantes(contador)
                        End If
                    Else
                        MessageBox.Show("Error en el formato de votos para el candidato " & (contador + 1))
                        ' Puedes manejar el error aquí o tomar otra acción apropiada.
                    End If

                    contador += 1
                Else
                    MessageBox.Show("Error en el formato de archivo CSV")
                    ' Puedes manejar el error aquí o tomar otra acción apropiada.
                End If
            End While
        End Using

        MessageBox.Show("El ganador es: " & ganador.Nombre & vbCrLf & "El que obtuvo menos cantidad de votos es: " & menosVotos.Nombre)
    End Sub
End Class
