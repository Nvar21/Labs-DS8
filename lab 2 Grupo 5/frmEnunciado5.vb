Imports System.Threading

Public Class frmEnunciado5
    Private Sub btnRotar_Click(sender As Object, e As EventArgs) Handles btnRotar.Click
        Dim textoInicial As String = txtCadena.Text 'obtiene el texto ingresado

        lstResultado.Items.Clear()

        Do
            textoInicial = RotarTexto(textoInicial) 'llama a la funcion para ir rotando el texto
            lstResultado.Items.Add(textoInicial) 'va agregando los resultados al listbox
            Me.Refresh()
            Thread.Sleep(1000) 'un tiempo de espera entre cada rotacion
        Loop While txtCadena.Text <> textoInicial

        lstResultado.Items.Add("> La cadena ha vuelto a su origen")
    End Sub

    Private Function RotarTexto(texto As String) As String
        'obtiene el ultimo caracter de la cadena
        Dim ultimoCaracter As Char = texto(texto.Length - 1)

        'crea la nueva cadena
        Dim textoRotado As String = ultimoCaracter & texto.Substring(0, texto.Length - 1)

        Return textoRotado
    End Function

End Class
