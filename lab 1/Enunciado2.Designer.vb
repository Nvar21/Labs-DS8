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
        bntRegistrar = New Button()
        btnCalcular = New Button()
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
        Label1.Text = "Enunciado 2 - Registro de accidentes automovilisticos por genero"
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
        ' bntRegistrar
        ' 
        bntRegistrar.Location = New Point(178, 189)
        bntRegistrar.Name = "bntRegistrar"
        bntRegistrar.Size = New Size(103, 23)
        bntRegistrar.TabIndex = 10
        bntRegistrar.Text = "Añadir Registro"
        bntRegistrar.UseVisualStyleBackColor = True
        ' 
        ' btnCalcular
        ' 
        btnCalcular.Enabled = False
        btnCalcular.Location = New Point(323, 189)
        btnCalcular.Name = "btnCalcular"
        btnCalcular.Size = New Size(122, 23)
        btnCalcular.TabIndex = 11
        btnCalcular.Text = "Obtener Estadísticas"
        btnCalcular.UseVisualStyleBackColor = True
        ' 
        ' Enunciado2
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(609, 293)
        Controls.Add(btnCalcular)
        Controls.Add(bntRegistrar)
        Controls.Add(txtEdad)
        Controls.Add(txtGenero)
        Controls.Add(Label6)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Margin = New Padding(3, 2, 3, 2)
        Name = "Enunciado2"
        Text = "Enunciado2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtGenero As TextBox
    Friend WithEvents txtEdad As TextBox
    Friend WithEvents bntRegistrar As Button
    Friend WithEvents btnCalcular As Button
End Class
