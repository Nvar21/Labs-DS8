Module ModuleEnun3
    Function Inversion(numeroComoCadena As String) As String
        ' Caso base: si la cadena está vacía o tiene una sola cifra, regresamos la cadena tal como está
        If String.IsNullOrEmpty(numeroComoCadena) OrElse numeroComoCadena.Length = 1 Then
            Return numeroComoCadena
        End If

        ' Obtenemos el último carácter de la cadena
        Dim ultimoCaracter As Char = numeroComoCadena(numeroComoCadena.Length - 1)

        ' Llamada recursiva con la cadena sin el último carácter
        Dim cadenaRestante As String = numeroComoCadena.Substring(0, numeroComoCadena.Length - 1)
        Dim cadenaInvertidaRestante As String = Inversion(cadenaRestante)

        ' Concatenamos el último carácter al resultado invertido
        Return ultimoCaracter & cadenaInvertidaRestante
    End Function
End Module
