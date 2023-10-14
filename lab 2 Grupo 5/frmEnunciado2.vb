Imports System.Runtime.CompilerServices

Public Class frmEnunciado2
    Dim objTemperaturas As New Temperaturas

    'para centrarar unos labels
    Private Sub frmEnunciado2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTitulo.Location = New Point((pnlTitulo.Width - lblTitulo.Width) \ 2, (pnlTitulo.Height - lblTitulo.Height) \ 2)
        lblLista.Location = New Point((pnlRegistros.Width - lblLista.Width) \ 2)
        lblLista.Location = New Point((pnlResultados.Width - lblLista.Width) \ 2, 6)
    End Sub

    'Para validar si el valor de temperatura es numérico
    Private Sub txtGenero_TextChanged(sender As Object, e As EventArgs) Handles txtTemp.TextChanged
        If String.IsNullOrEmpty(txtTemp.Text) Then 'Si el txt está vacío
            lblIndicador.Show()
            lblIndicador.Text = "No puede dejar vacío el campo de temperatura"
            lblIndicador.Location = New Point((pnlRegistros.Width - lblIndicador.Width) \ 2, 75)
            lblIndicador.ForeColor = Color.FromArgb(233, 213, 2) 'Amarillo de Alerta
            btnRegister.Enabled = False
        Else  ' El txt no está vacío
            If IsNumeric(txtTemp.Text) Then 'Si el valor del txt es una temperatura válida (int o double)
                Dim temperatura As Double = txtTemp.Text
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
            If txtTemp.Text = "0" And objTemperaturas.ObtenerTotal > 0 Then 'el txt no está vacío y tiene dentro un "0" (quiere parar de ingresar)
                btnVerResult.Enabled = True
            Else
                btnVerResult.Enabled = False
            End If

        End If

    End Sub

    'para cuando se PUEDA ingresar una temperatura
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim temp As Double = txtTemp.Text
        objTemperaturas.añadirTemp(temp)
        txtContador.Text = objTemperaturas.ObtenerTotal()
        dgvResultados.Rows.Add(objTemperaturas.ObtenerTotal, objTemperaturas.ObtenerTemperatura(objTemperaturas.ObtenerTotal))
    End Sub

    Private Sub btnVerResult_Click(sender As Object, e As EventArgs) Handles btnVerResult.Click
        txtMay37.Text = objTemperaturas.ObtenerMay37
        txtmen33.Text = objTemperaturas.ObtenerMen33
    End Sub
End Class