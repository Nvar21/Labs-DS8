Public Class Ventas
    Private CantVentas1 As Integer 'cantidad de ventas mayores a $1000
    Private CantVentas2 As Integer 'cantidad de ventas mayores a $500 pero menores o iguales a $1000
    Private CantVentas3 As Integer 'cantidad de ventas menores o iguales a $500
    Private MontoVentas1 As Double 'monto de ventas mayores a $1000
    Private MontoVentas2 As Double 'monto de ventas mayores a $500 pero menores o iguales a $1000
    Private MontoVentas3 As Double 'monto de ventas menores o iguales a $500


    'metodo para registrar las ventas y categorizarlas
    Public Sub RegistrarVenta(ByVal monto As Double)
        If monto > 1000 Then
            CantVentas1 += 1
            MontoVentas1 += monto
        ElseIf monto <= 500 Then
            CantVentas3 += 1
            MontoVentas3 += monto
        Else
            CantVentas2 += 1
            MontoVentas2 += monto
        End If
    End Sub

    'metodos para devolver los resultados
    Public Function ObtenerCantVentas1() As Integer
        Return CantVentas1
    End Function
    Public Function ObtenerCantVentas2() As Integer
        Return CantVentas2
    End Function
    Public Function ObtenerCantVentas3() As Integer
        Return CantVentas3
    End Function
    Public Function ObtenerMontoVentas1() As Double
        Return MontoVentas1
    End Function
    Public Function ObtenerMontoVentas2() As Double
        Return MontoVentas2
    End Function
    Public Function ObtenerMontoVentas3() As Double
        Return MontoVentas3
    End Function

    Public Function ObtenerCantVentasTotal() As Integer
        Return CantVentas1 + CantVentas2 + CantVentas3
    End Function

    Public Function ObtenerMontoVentasTotal() As Double
        Return MontoVentas1 + MontoVentas2 + MontoVentas3
    End Function
End Class
