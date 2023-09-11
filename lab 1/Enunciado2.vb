Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports System.Xml.Schema

Public Class Enunciado2
    Dim edadesMujeres As New List(Of Integer)
    Dim edadesHombres As New List(Of Integer)



    Private Sub txtGenero_txtEdad_TextChanged(sender As Object, e As EventArgs) Handles txtGenero.TextChanged, txtEdad.TextChanged
        Dim genero As String = txtGenero.Text
        Dim edad As String = txtEdad.Text
        lblIndicador.Visible = False
        'si se quiere dejar de registrar se inhabilita el ingreso de edad
        If genero = "0" Then
            txtEdad.Enabled = False
        Else
            txtEdad.Enabled = True
        End If

        'si se quiere dejar de registrar se inhabilita el ingreso de edad
        If genero = "1" Then
            lblGenero.Text = "Mujer"
        ElseIf genero = "2" Then
            lblGenero.Text = "Hombre"
        ElseIf genero = "0" Then
            lblGenero.Text = ""
        End If

        'Si ninguno de los dos campos está vacío
        If Not (String.IsNullOrEmpty(genero) Or String.IsNullOrEmpty(edad)) Then
            'Si en el textbox de Genero no hay 0, 1 o 2 no se pueden presionar los botones
            If Not (genero = "0" Or genero = "1" Or genero = "2") Then 'Si añade un valor que no sea 0 1 2
                MsgBox("Ingresar un valor válido para el género (0 a 2)")
                txtGenero.Clear()
                btnRegistrar.Enabled = False
                btnCalcular.Enabled = False

                'Si se va a registrar un Hombre o mujer y el campo de edad no está vacío, activa el botón de registrar
            ElseIf genero = "1" Or genero = "2" And Not edad Is Nothing Then
                btnRegistrar.Enabled = True

                'Si se ingresa un 0 (por que se desea dejar de ingresar registros de accidentados), se permite presionar el botón de "Obtener Estadísticas"
                'Pero solo si alguno de los dos arreglos que contienen las edades de accidentados no está vacío
            ElseIf genero = "0" And Not (edadesHombres Is Nothing Or edadesMujeres Is Nothing) Then
                btnCalcular.Enabled = True
            Else
                btnCalcular.Enabled = False
            End If


            'Si se ingresa algun caracter que no sea un numero positivo al textbox de edad
            If IsNumeric(edad) Then
                If edad < 0 Then
                    MsgBox("Ingresar una edad válida")
                    txtEdad.Clear()
                    Return
                End If
            Else
                MsgBox("No se admiten para la edad," & vbCrLf & "valores que no sean números positivos: " & txtEdad.Text)
                txtEdad.Clear()
                btnRegistrar.Enabled = False
            End If

        Else 'Si uno de los campos está vacío
            btnRegistrar.Enabled = False
            btnCalcular.Enabled = False
            Return

        End If
    End Sub

    Private Sub bntRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Dim genero As String = txtGenero.Text
        Dim edad As Integer = txtEdad.Text

        ' si se registra una accidentada 
        If genero = "1" Then
            edadesMujeres.Add(edad)
            lblIndicador.Visible = True
        End If

        ' si se registra un accidentado
        If genero = "2" Then
            lblIndicador.Visible = True
            edadesHombres.Add(edad)
        End If
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        lblIndicador.Visible = False
        gpbTotales.Visible = True ' Para hacer el GroupBox visible
        gpbResultados.Visible = True ' Para hacer el GroupBox visible
        Dim hombres_mayores_40 As Integer = 0
        Dim mujeres_rango_18a25 As Integer = 0

        ' recorre la lista de edades de hombres y cuenta cuántos son mayores de 40
        For Each edad As Integer In edadesHombres
            If edad > 39 Then
                hombres_mayores_40 += 1
            End If
        Next

        For Each edad As Integer In edadesMujeres
            If edad > 17 And edad < 26 Then
                mujeres_rango_18a25 += 1
            End If
        Next

        'Muestra resultados en respectivos Labels


        If edadesHombres.Count > 0 Then
            Dim porcentajeHombres As Double
            porcentajeHombres = Math.Round((hombres_mayores_40 / edadesHombres.Count) * 100, 1)
            lblHombres.Text = porcentajeHombres
            lblTotHombres.Text = edadesHombres.Count
            txtListaHombres.Text = String.Join(", ", edadesHombres)
        Else
            txtListaHombres.Text = "No hubo Hombres accidentados"
            lblHombres.Text = "0"
        End If

        If edadesMujeres.Count > 0 Then
            Dim porcentajeMujeres As Double
            porcentajeMujeres = Math.Round((mujeres_rango_18a25 / edadesMujeres.Count) * 100, 1)
            lblTotMujeres.Text = edadesMujeres.Count
            lblMujeres.Text = porcentajeMujeres
            txtListaMujeres.Text = String.Join(", ", edadesMujeres)
        Else
            txtListaMujeres.Text = "No hubo Mujeres accidentadas"
            lblMujeres.Text = "0"
        End If


    End Sub

    Private Sub txtListaMujeres_TextChanged(sender As Object, e As EventArgs) Handles txtListaMujeres.TextChanged

    End Sub

    Private Sub txtListaHombres_TextChanged(sender As Object, e As EventArgs) Handles txtListaHombres.TextChanged
    End Sub
End Class