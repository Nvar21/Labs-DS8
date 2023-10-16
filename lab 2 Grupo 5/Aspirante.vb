Imports System.IO

'Public Class Aspirante
'    Public Property Nombre As String
'    Public Property CantidadVotos As Integer

'    Public Sub New(Nombre As String, CantidadVotos As Integer)
'        Me.Nombre = Nombre
'        Me.CantidadVotos = 0

'    End Sub


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

    Public Function obtenerLista() As String
        Return cantidadVotos.ToString
    End Function

End Class