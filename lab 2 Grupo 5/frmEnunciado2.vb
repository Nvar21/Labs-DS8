Imports System.Runtime.CompilerServices

Public Class frmEnunciado2
    Private Sub frmEnunciado2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim x As Integer = (pnlTitulo.Width - lblTitulo.Width) \ 2
        Dim y As Integer = (pnlTitulo.Height - lblTitulo.Height) \ 2
        lblTitulo.Location = New Point(x, y)
        lblLista.Location = New Point((pnlRegistros.Width - lblLista.Width) \ 2)
        lblLista.Location = New Point((pnlResultados.Width - lblLista.Width) \ 2, 6)
    End Sub

    'Para validar si el valor de temperatura es numérico
    Private Sub txtGenero_TextChanged(sender As Object, e As EventArgs) Handles txtTemp.TextChanged
        If String.IsNullOrEmpty(txtTemp.Text) Then 'Si el txt está vacío
            lblIndicador.Show()
            lblIndicador.Text = "No puede dejar Vacío el campo de temperatura"
            lblIndicador.Location = New Point((pnlRegistros.Width - lblIndicador.Width) \ 2, 75)
            lblIndicador.ForeColor = Color.FromArgb(233, 213, 2) 'Amarillo de Alerta
            btnRegister.Enabled = False
        Else
            If IsNumeric(txtTemp.Text) Then 'Si el valor del txt es una temperatura válida
                Dim temperatura As Integer = txtTemp.Text
                lblIndicador.Show()
                lblIndicador.Text = "Valor CORRECTO para temperatura"
                lblIndicador.Location = New Point((pnlRegistros.Width - lblIndicador.Width) \ 2, 75)
                lblIndicador.ForeColor = Color.FromArgb(153, 204, 51) 'Verde de Correcto
                btnRegister.Enabled = True
            Else ' Si es un valor alfabetico o caracter (aB"*$...)
                lblIndicador.Show()
                lblIndicador.Text = "Valor INCORRECTO para temperatura, no ingrese letras o caracteres"
                lblIndicador.Location = New Point((pnlRegistros.Width - lblIndicador.Width) \ 2, 75)
                lblIndicador.ForeColor = Color.FromArgb(255, 153, 102) 'Rojo de Incorrecto
                btnRegister.Enabled = False
            End If
        End If
    End Sub


End Class