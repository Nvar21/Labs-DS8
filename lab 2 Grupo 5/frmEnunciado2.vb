Imports System.Diagnostics.Eventing.Reader
Imports System.Runtime.CompilerServices

Public Class frmEnunciado2
    Dim objTemperaturas As New Temperaturas

    'para centrarar unos labels
    Private Sub frmEnunciado2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTitulo.Location = New Point((pnlTitulo.Width - lblTitulo.Width) \ 2, (pnlTitulo.Height - lblTitulo.Height) \ 2)
        lblLista.Location = New Point((pnlRegistros.Width - lblLista.Width) \ 2)
        lblLista.Location = New Point((pnlResultados.Width - lblLista.Width) \ 2, 6)
        dgvResultados.Rows.Clear()
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
            If IsNumeric(txtTemp.Text) And txtTemp.Text >= 0 Then
                'Si el valor del txt es una temperatura válida (int o double) y mayor a 0 (si la persona entra caminando al lugar con menos de 0°C me daría miedo)

                If txtTemp.Text = "0" And objTemperaturas.ObtenerTotal > 0 Then 'Si ingresa 0 es que quiere dejar de registrar
                    lblIndicador.Show()
                    lblIndicador.Text = "Si terminó de registrar, puede presionar el botón 'Ver Resultados'"
                    lblIndicador.Location = New Point((pnlRegistros.Width - lblIndicador.Width) \ 2, 75)
                    lblIndicador.ForeColor = Color.FromArgb(233, 213, 2) 'Amarillo de Alerta
                    btnVerResult.Enabled = True
                    Return
                Else
                    btnVerResult.Enabled = False
                End If
                Dim temperatura As Double = txtTemp.Text
                lblIndicador.Show()
                lblIndicador.Text = "Valor VÁLIDO para registrar la temperatura"
                lblIndicador.Location = New Point((pnlRegistros.Width - lblIndicador.Width) \ 2, 75)
                lblIndicador.ForeColor = Color.FromArgb(153, 204, 51) 'Verde de Correcto
                btnRegister.Enabled = True
            Else ' Si es un valor alfabetico o caracter (aB"*$...)
                lblIndicador.Show()
                lblIndicador.Text = "Valor INVÁLIDO para para registrar la temperatura, no ingrese letras o caracteres"
                lblIndicador.Location = New Point((pnlRegistros.Width - lblIndicador.Width) \ 2, 75)
                lblIndicador.ForeColor = Color.FromArgb(255, 153, 102) 'Rojo de Incorrecto
                btnRegister.Enabled = False
            End If

        End If

    End Sub

    'para cuando se PUEDA ingresar una temperatura
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        If Not txtTemp.Text = "0" Then
            Dim temp As Double = CDbl(txtTemp.Text)
            objTemperaturas.AñadirTemp(temp)
            Dim registroNuevo As Double = objTemperaturas.ObtenerTemperatura(objTemperaturas.ObtenerTotal)
            txtContador.Text = objTemperaturas.ObtenerTotal()
            dgvResultados.Rows.Add(objTemperaturas.ObtenerTotal, registroNuevo)
        End If
    End Sub

    ' Para darle color a las celdas que indiquen si la temperatura es peligrosa o está bien
    Private Sub dgvResultados_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvResultados.CellFormatting
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = 0 Then ' Columna 1
            Dim valor As Double = CDbl(dgvResultados.Rows(e.RowIndex).Cells(1).Value)

            If valor <= 33 Or valor > 37 Then
                dgvResultados.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.FromArgb(255, 153, 102) 'Rojo de Alerta
            End If
            If valor >= 37 And valor <= 37.2 Then
                dgvResultados.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.FromArgb(153, 204, 51) 'Verde de Correcto
            End If
        End If
    End Sub


    ' ya para ver resultados finales
    Private Sub btnVerResult_Click(sender As Object, e As EventArgs) Handles btnVerResult.Click
        txtMay37.Text = objTemperaturas.ObtenerMay37
        txtmen33.Text = objTemperaturas.ObtenerMen33
    End Sub
End Class