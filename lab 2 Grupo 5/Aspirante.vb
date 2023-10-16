Imports System.IO
Public Class Aspirante

    Dim nombreCand As String
    Private cantidadVotos As New List(Of Integer)

    Public Sub AsignarNombre(nombre As String)
        nombreCand = nombre
    End Sub

    Public Sub AnadirVoto(votos As Integer)
        cantidadVotos.Add(votos)
    End Sub

    Public Function ObtenerTotalVotos() As Integer
        Return cantidadVotos.Sum()
    End Function

    Public Function ObtenerNombre() As String
        Return nombreCand
    End Function

End Class