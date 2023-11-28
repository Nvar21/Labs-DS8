Imports System
Public Class WebForm2
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim year As Integer
        If Integer.TryParse(txtYear.Text, year) AndAlso year >= 1900 And year <= 2100 Then
            Dim fechaPascua As String = CalcularDomingo(year)
            lblResultado.Text = $"El domingo de Pascua en el año {year} es el {fechaPascua}"
        Else
            lblResultado.Text = "Por favor, ingrese un año válido."
        End If
    End Sub

    ' Función para enunciado 2
    Function CalcularDomingo(ByVal year As Integer) As String
        Dim A As Integer = year Mod 19
        Dim B As Integer = year Mod 4
        Dim C As Integer = year Mod 7
        Dim D As Integer = (19 * A + 24) Mod 30
        Dim E As Integer = (2 * B + 4 * C + 6 * D + 5) Mod 7
        Dim N As Integer = 22 + D + E
        Dim fechaPascua As String
        If N <= 31 Then
            ' Domingo de Pascua en marzo
            fechaPascua = $"{N} de marzo"
        Else
            N -= 31
            ' Domingo de Pascua en abril
            fechaPascua = $"{N} de abril"
        End If
        Return fechaPascua
    End Function
End Class