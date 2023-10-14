Imports System.Diagnostics.CodeAnalysis

Public Class Temperaturas
    Private lstTemperaturas As New List(Of Double)
    Dim tempMay37 As Integer
    Dim tempMen33 As Integer
    Dim temperatura As Double

    Public Sub Asignartemp(temperatura As Double)
        Me.temperatura = temperatura
    End Sub

    Public Function AñadirTemp(temperatura As Double)
        lstTemperaturas.Add(temperatura)
        Return 0
    End Function

    Public Function ObtenerMay37() As Integer
        Dim tempMay37 As Integer
        For Each tempe As Double In lstTemperaturas
            If tempe > 37 Then
                tempMay37 += 1
            End If
        Next
        ObtenerMay37 = tempMay37
    End Function

    Public Function ObtenerMen33() As Integer
        Dim tempMen33 As Integer
        For Each tempe As Double In lstTemperaturas
            If tempe < 33 Then
                tempMen33 += 1
            End If
        Next
        ObtenerMen33 = tempMen33
    End Function

    Public Function ObtenerTotal()
        Return lstTemperaturas.Count
    End Function

    Public Function ObtenerTemperatura(posicion As Integer)
        Return lstTemperaturas(posicion - 1)
    End Function

End Class
