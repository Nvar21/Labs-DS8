Module Modulo

    'funcion para enunciado3
    Function Inversion(numeroComoCadena As String) As String
        ' si la cadena está vacía o tiene una sola cifra, se regresa la cadena asi mismo
        If String.IsNullOrEmpty(numeroComoCadena) OrElse numeroComoCadena.Length = 1 Then
            Return numeroComoCadena
        End If
        Dim numeroInvertido As String = StrReverse(numeroComoCadena)
        Return numeroInvertido
    End Function


    'funcion para enunciado 4
    Function CalcularDomingo(ByVal year As Integer) As DateTime
        Dim A As Integer = year Mod 19
        Dim B As Integer = year Mod 4
        Dim C As Integer = year Mod 7
        Dim D As Integer = (19 * A + 24) Mod 30
        Dim E As Integer = (2 * B + 4 * C + 6 * D + 5) Mod 7
        Dim N As Integer = 22 + D + E

        Dim fechaPascua As DateTime

        If N <= 31 Then
            'Domingo de pascua Marzo
            fechaPascua = New DateTime(year, 3, N)
        Else N -= 31
            'Domingo de pascua Marzo
            fechaPascua = New DateTime(year, 4, N)
        End If
        Return fechaPascua
    End Function


    'funcion para enunciado 5
    Function RotarTexto(texto As String) As String
        'obtiene el ultimo caracter de la cadena
        Dim ultimoCaracter As Char = texto(texto.Length - 1)

        'crea la nueva cadena
        Dim textoRotado As String = ultimoCaracter & texto.Substring(0, texto.Length - 1)

        Return textoRotado
    End Function

End Module
