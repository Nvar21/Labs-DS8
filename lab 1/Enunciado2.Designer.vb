
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Enunciado2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label6 = New Label()
        txtGenero = New TextBox()
        txtEdad = New TextBox()
        btnRegistrar = New Button()
        btnCalcular = New Button()
        Label2 = New Label()
        Label5 = New Label()
        Label7 = New Label()
        lblHombres = New Label()
        lblMujeres = New Label()
        gpbResultados = New GroupBox()
        lblTotMujeres = New Label()
        lblTotHombres = New Label()
        Label11 = New Label()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        lblIndicador = New Label()
        gpbTotales = New GroupBox()
        txtListaMujeres = New TextBox()
        txtListaHombres = New TextBox()
        Label12 = New Label()
        Label14 = New Label()
        Label16 = New Label()
        Label13 = New Label()
        lblGenero = New Label()
        gpbResultados.SuspendLayout()
        gpbTotales.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.FlatStyle = FlatStyle.System
        Label1.Font = New Font("Myanmar Text", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(596, 34)
        Label1.TabIndex = 0
        Label1.Text = "Enunciado 2 - Registro de accidentes automovilísticos por genero"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.FlatStyle = FlatStyle.System
        Label3.Font = New Font("Myanmar Text", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(22, 53)
        Label3.Name = "Label3"
        Label3.Size = New Size(257, 29)
        Label3.TabIndex = 3
        Label3.Text = "Ingrese género del accidentado:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.FlatStyle = FlatStyle.System
        Label4.Font = New Font("Myanmar Text", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(22, 79)
        Label4.Name = "Label4"
        Label4.Size = New Size(413, 29)
        Label4.TabIndex = 5
        Label4.Text = "(1 para Mujer / 2 para Hombre / 0 para finalizar registros)"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.FlatStyle = FlatStyle.System
        Label6.Font = New Font("Myanmar Text", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(22, 121)
        Label6.Name = "Label6"
        Label6.Size = New Size(259, 29)
        Label6.TabIndex = 6
        Label6.Text = "Ingrese la edad del accidentado:"
        ' 
        ' txtGenero
        ' 
        txtGenero.Location = New Point(285, 53)
        txtGenero.MaxLength = 1
        txtGenero.Name = "txtGenero"
        txtGenero.PlaceholderText = "0, 1 o 2"
        txtGenero.Size = New Size(100, 23)
        txtGenero.TabIndex = 2
        txtGenero.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtEdad
        ' 
        txtEdad.Location = New Point(285, 121)
        txtEdad.Name = "txtEdad"
        txtEdad.Size = New Size(100, 23)
        txtEdad.TabIndex = 9
        ' 
        ' btnRegistrar
        ' 
        btnRegistrar.Enabled = False
        btnRegistrar.Location = New Point(172, 189)
        btnRegistrar.Margin = New Padding(3, 2, 3, 2)
        btnRegistrar.Name = "btnRegistrar"
        btnRegistrar.Size = New Size(90, 23)
        btnRegistrar.TabIndex = 10
        btnRegistrar.Text = "Añadir Registro"
        btnRegistrar.UseVisualStyleBackColor = True
        ' 
        ' btnCalcular
        ' 
        btnCalcular.Enabled = False
        btnCalcular.Location = New Point(313, 189)
        btnCalcular.Name = "btnCalcular"
        btnCalcular.Size = New Size(122, 23)
        btnCalcular.TabIndex = 11
        btnCalcular.Text = "Obtener Estadísticas"
        btnCalcular.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Myanmar Text", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(39, 50)
        Label2.Name = "Label2"
        Label2.Size = New Size(206, 29)
        Label2.TabIndex = 12
        Label2.Text = "Porcentaje de Accidentados:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Myanmar Text", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(246, 43)
        Label5.Name = "Label5"
        Label5.Size = New Size(224, 29)
        Label5.TabIndex = 13
        Label5.Text = "Hombres mayores de 40 años:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Myanmar Text", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(246, 65)
        Label7.Name = "Label7"
        Label7.Size = New Size(226, 29)
        Label7.TabIndex = 14
        Label7.Text = "Mujeres de entre 18 y 25 años:"
        ' 
        ' lblHombres
        ' 
        lblHombres.AutoSize = True
        lblHombres.Font = New Font("Myanmar Text", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        lblHombres.Location = New Point(484, 43)
        lblHombres.Name = "lblHombres"
        lblHombres.Size = New Size(22, 29)
        lblHombres.TabIndex = 15
        lblHombres.Text = "0"
        ' 
        ' lblMujeres
        ' 
        lblMujeres.AutoSize = True
        lblMujeres.Font = New Font("Myanmar Text", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        lblMujeres.Location = New Point(484, 65)
        lblMujeres.Name = "lblMujeres"
        lblMujeres.Size = New Size(22, 29)
        lblMujeres.TabIndex = 16
        lblMujeres.Text = "0"
        ' 
        ' gpbResultados
        ' 
        gpbResultados.Controls.Add(lblTotMujeres)
        gpbResultados.Controls.Add(lblTotHombres)
        gpbResultados.Controls.Add(Label11)
        gpbResultados.Controls.Add(Label10)
        gpbResultados.Controls.Add(Label9)
        gpbResultados.Controls.Add(Label8)
        gpbResultados.Controls.Add(Label7)
        gpbResultados.Controls.Add(lblMujeres)
        gpbResultados.Controls.Add(Label2)
        gpbResultados.Controls.Add(lblHombres)
        gpbResultados.Controls.Add(Label5)
        gpbResultados.Location = New Point(24, 319)
        gpbResultados.Margin = New Padding(3, 2, 3, 2)
        gpbResultados.Name = "gpbResultados"
        gpbResultados.Padding = New Padding(3, 2, 3, 2)
        gpbResultados.Size = New Size(602, 107)
        gpbResultados.TabIndex = 17
        gpbResultados.TabStop = False
        gpbResultados.Text = "Resultados"
        gpbResultados.Visible = False
        ' 
        ' lblTotMujeres
        ' 
        lblTotMujeres.AutoSize = True
        lblTotMujeres.Font = New Font("Myanmar Text", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        lblTotMujeres.Location = New Point(416, 14)
        lblTotMujeres.Name = "lblTotMujeres"
        lblTotMujeres.Size = New Size(22, 29)
        lblTotMujeres.TabIndex = 22
        lblTotMujeres.Text = "0"
        ' 
        ' lblTotHombres
        ' 
        lblTotHombres.AutoSize = True
        lblTotHombres.Font = New Font("Myanmar Text", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        lblTotHombres.Location = New Point(218, 14)
        lblTotHombres.Name = "lblTotHombres"
        lblTotHombres.Size = New Size(22, 29)
        lblTotHombres.TabIndex = 21
        lblTotHombres.Text = "0"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Myanmar Text", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label11.Location = New Point(308, 14)
        Label11.Name = "Label11"
        Label11.Size = New Size(110, 29)
        Label11.TabIndex = 20
        Label11.Text = "Total Mujeres:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Myanmar Text", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.Location = New Point(109, 14)
        Label10.Name = "Label10"
        Label10.Size = New Size(118, 29)
        Label10.TabIndex = 19
        Label10.Text = "Total Hombres:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Myanmar Text", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.Location = New Point(530, 65)
        Label9.Name = "Label9"
        Label9.Size = New Size(26, 29)
        Label9.TabIndex = 18
        Label9.Text = "%"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Myanmar Text", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(530, 43)
        Label8.Name = "Label8"
        Label8.Size = New Size(26, 29)
        Label8.TabIndex = 17
        Label8.Text = "%"
        ' 
        ' lblIndicador
        ' 
        lblIndicador.AutoSize = True
        lblIndicador.BackColor = SystemColors.ControlDark
        lblIndicador.Font = New Font("Myanmar Text", 11.0F, FontStyle.Regular, GraphicsUnit.Point)
        lblIndicador.ForeColor = Color.LawnGreen
        lblIndicador.Location = New Point(186, 161)
        lblIndicador.Name = "lblIndicador"
        lblIndicador.Size = New Size(234, 27)
        lblIndicador.TabIndex = 18
        lblIndicador.Text = "Registro Exitoso, puede continuar"
        lblIndicador.Visible = False
        ' 
        ' gpbTotales
        ' 
        gpbTotales.Controls.Add(txtListaMujeres)
        gpbTotales.Controls.Add(txtListaHombres)
        gpbTotales.Controls.Add(Label12)
        gpbTotales.Controls.Add(Label14)
        gpbTotales.Controls.Add(Label16)
        gpbTotales.Location = New Point(24, 231)
        gpbTotales.Margin = New Padding(3, 2, 3, 2)
        gpbTotales.Name = "gpbTotales"
        gpbTotales.Padding = New Padding(3, 2, 3, 2)
        gpbTotales.Size = New Size(602, 75)
        gpbTotales.TabIndex = 19
        gpbTotales.TabStop = False
        gpbTotales.Text = "Total Accidentados"
        gpbTotales.Visible = False
        ' 
        ' txtListaMujeres
        ' 
        txtListaMujeres.Location = New Point(303, 44)
        txtListaMujeres.Margin = New Padding(3, 2, 3, 2)
        txtListaMujeres.Name = "txtListaMujeres"
        txtListaMujeres.ReadOnly = True
        txtListaMujeres.Size = New Size(293, 23)
        txtListaMujeres.TabIndex = 21
        ' 
        ' txtListaHombres
        ' 
        txtListaHombres.Location = New Point(302, 20)
        txtListaHombres.Margin = New Padding(3, 2, 3, 2)
        txtListaHombres.Name = "txtListaHombres"
        txtListaHombres.ReadOnly = True
        txtListaHombres.Size = New Size(294, 23)
        txtListaHombres.TabIndex = 20
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Myanmar Text", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label12.Location = New Point(226, 42)
        Label12.Name = "Label12"
        Label12.Size = New Size(69, 29)
        Label12.TabIndex = 14
        Label12.Text = "Mujeres"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Myanmar Text", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label14.Location = New Point(27, 34)
        Label14.Name = "Label14"
        Label14.Size = New Size(162, 29)
        Label14.TabIndex = 12
        Label14.Text = "Lista de Accidentados"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Myanmar Text", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label16.Location = New Point(218, 20)
        Label16.Name = "Label16"
        Label16.Size = New Size(77, 29)
        Label16.TabIndex = 13
        Label16.Text = "Hombres"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.FlatStyle = FlatStyle.System
        Label13.Font = New Font("Myanmar Text", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label13.Location = New Point(391, 50)
        Label13.Name = "Label13"
        Label13.Size = New Size(76, 29)
        Label13.TabIndex = 20
        Label13.Text = "Género: "
        ' 
        ' lblGenero
        ' 
        lblGenero.AutoSize = True
        lblGenero.FlatStyle = FlatStyle.System
        lblGenero.Font = New Font("Myanmar Text", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblGenero.Location = New Point(402, 40)
        lblGenero.Name = "lblGenero"
        lblGenero.Size = New Size(0, 29)
        lblGenero.TabIndex = 21
        ' 
        ' Enunciado2
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(638, 441)
        Controls.Add(lblGenero)
        Controls.Add(Label13)
        Controls.Add(gpbTotales)
        Controls.Add(lblIndicador)
        Controls.Add(gpbResultados)
        Controls.Add(btnCalcular)
        Controls.Add(btnRegistrar)
        Controls.Add(txtEdad)
        Controls.Add(txtGenero)
        Controls.Add(Label6)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Margin = New Padding(3, 2, 3, 2)
        Name = "Enunciado2"
        Text = "Enunciado 2"
        gpbResultados.ResumeLayout(False)
        gpbResultados.PerformLayout()
        gpbTotales.ResumeLayout(False)
        gpbTotales.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtGenero As TextBox
    Friend WithEvents txtEdad As TextBox
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents btnCalcular As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblHombres As Label
    Friend WithEvents lblMujeres As Label
    Friend WithEvents gpbResultados As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblIndicador As Label
    Friend WithEvents gpbTotales As GroupBox
    Friend WithEvents txtListaMujeres As TextBox
    Friend WithEvents txtListaHombres As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblTotMujeres As Label
    Friend WithEvents lblTotHombres As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lblGenero As Label
End Class