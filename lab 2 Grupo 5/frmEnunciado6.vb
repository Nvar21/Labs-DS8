Imports System.IO
Imports Microsoft.VisualBasic.FileIO

Public Class frmEnunciado6
    Dim aspirantes(3) As Aspirante ' Arreglo de Aspirante para almacenar los candidatos

    Private Sub btnObtener_Click(sender As Object, e As EventArgs) Handles btnObtener.Click
        Dim totalCandidatos As Integer = 4

        For instancia As Integer = 0 To totalCandidatos - 1
            aspirantes(instancia) = New Aspirante()
        Next

        aspirantes(0).AsignarNombre(txtCand0.Text)
        aspirantes(1).AsignarNombre(txtCand1.Text)
        aspirantes(2).AsignarNombre(txtCand2.Text)
        aspirantes(3).AsignarNombre(txtCand3.Text)



        ' Lista para almacenar las instancias de Aspirante
        Dim candidatos As New List(Of Aspirante)
        'Ejemplo de Microsoft https:  //learn.microsoft.com/es-es/dotnet/visual-basic/developing-apps/programming/drives-directories-files/how-to-read-from-comma-delimited-text-files
        Using MyReader As New Microsoft.VisualBasic.
            FileIO.TextFieldParser("Votos.csv")
            MyReader.TextFieldType = FileIO.FieldType.Delimited
            MyReader.SetDelimiters(";")
            While Not MyReader.EndOfData
                Try
                    Dim currentRow As String() = MyReader.ReadFields()
                    If currentRow.Length = 4 Then
                        aspirantes(0).AnadirVoto(currentRow(0))
                        aspirantes(1).AnadirVoto(currentRow(1))
                        aspirantes(2).AnadirVoto(currentRow(2))
                        aspirantes(3).AnadirVoto(currentRow(3))
                    End If
                Catch ex As Microsoft.VisualBasic.
                    FileIO.MalformedLineException
                    MsgBox("Error de Linea leida " & ex.Message)
                End Try
            End While
        End Using
        'Determinar el ganador  | el candidato con menos votos | los votos de cada aspirante
        'Mostrar nombres de Aspirantes
        Dim lstNombres As New List(Of String) From {aspirantes(0).ObtenerNombre, aspirantes(1).ObtenerNombre, aspirantes(2).ObtenerNombre, aspirantes(3).ObtenerNombre}
        lblNombreC1.Text = lstNombres(0)
        lblNombreC2.Text = lstNombres(1)
        lblNombreC3.Text = lstNombres(2)
        lblNombreC4.Text = lstNombres(3)
        'Votos de cada Aspirante
        Dim lstTotVotos As New List(Of Integer) From {aspirantes(0).ObtenerTotalVotos, aspirantes(1).ObtenerTotalVotos, aspirantes(2).ObtenerTotalVotos, aspirantes(3).ObtenerTotalVotos}
        txtVotosCand0.Text = lstTotVotos(0)
        txtVotosCand1.Text = lstTotVotos(1)
        txtVotosCand2.Text = lstTotVotos(2)
        txtVotosCand3.Text = lstTotVotos(3)

        'Obtener el que ganó la votación
        Dim Indexganador As Integer = lstTotVotos.IndexOf(lstTotVotos.Max())
        Dim Indexmenor As Integer = lstTotVotos.IndexOf(lstTotVotos.Min())
        txtGanador.Text = lstNombres(Indexganador) & " Con: " & aspirantes(Indexganador).ObtenerTotalVotos & "  Votos"
        txtMenor.Text = lstNombres(Indexmenor) & " Con: " & aspirantes(Indexmenor).ObtenerTotalVotos & "  Votos"
    End Sub


    Private Sub NombresDeCandidato_TextChanged(sender As Object, e As EventArgs) Handles txtCand0.TextChanged, txtCand1.TextChanged, txtCand2.TextChanged, txtCand3.TextChanged

        If String.IsNullOrEmpty(txtCand0.Text) Or String.IsNullOrEmpty(txtCand1.Text) Or String.IsNullOrEmpty(txtCand2.Text) Or String.IsNullOrEmpty(txtCand3.Text) Then
            lblAlerta.Show()
            lblAlerta.Text = "No deje vacío ninguno de los nombres de candidatos"
            lblAlerta.ForeColor = Color.FromArgb(233, 213, 2) ' Amarillo de Alerta
            btnObtener.Enabled = False
        Else
            lblAlerta.Show()
            lblAlerta.Text = "Puede Continuar"
            lblAlerta.ForeColor = Color.FromArgb(153, 204, 51) ' Verde de Correcto
            btnObtener.Enabled = True
        End If
    End Sub
End Class
