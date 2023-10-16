Imports System.IO

Public Class Aspirante
    Public Property Nombre As String
    Public Property CantidadVotos As Integer

    Public Sub New(Nombre As String, CantidadVotos As Integer)
        Me.Nombre = Nombre
        Me.CantidadVotos = 0
    End Sub

End Class