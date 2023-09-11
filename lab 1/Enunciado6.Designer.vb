<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Enunciado6
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        btnEjecutar = New Button()
        Label2 = New Label()
        txtResultado = New TextBox()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Myanmar Text", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(303, 29)
        Label1.Name = "Label1"
        Label1.Size = New Size(160, 43)
        Label1.TabIndex = 1
        Label1.Text = "Enunciado 6"
        ' 
        ' btnEjecutar
        ' 
        btnEjecutar.Font = New Font("Myanmar Text", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnEjecutar.Location = New Point(332, 160)
        btnEjecutar.Name = "btnEjecutar"
        btnEjecutar.Size = New Size(131, 39)
        btnEjecutar.TabIndex = 8
        btnEjecutar.Text = "Ejecutar"
        btnEjecutar.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Myanmar Text", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(207, 94)
        Label2.Name = "Label2"
        Label2.Size = New Size(368, 36)
        Label2.TabIndex = 9
        Label2.Text = "Aspirantes a la Alcaldía de Cartagena"
        ' 
        ' txtResultado
        ' 
        txtResultado.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtResultado.Font = New Font("Myanmar Text", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtResultado.Location = New Point(158, 316)
        txtResultado.Multiline = True
        txtResultado.Name = "txtResultado"
        txtResultado.ReadOnly = True
        txtResultado.Size = New Size(482, 136)
        txtResultado.TabIndex = 10
        txtResultado.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Myanmar Text", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(345, 272)
        Label3.Name = "Label3"
        Label3.Size = New Size(118, 36)
        Label3.TabIndex = 11
        Label3.Text = "Resultados"
        Label3.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Enunciado6
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 488)
        Controls.Add(Label3)
        Controls.Add(txtResultado)
        Controls.Add(Label2)
        Controls.Add(btnEjecutar)
        Controls.Add(Label1)
        Name = "Enunciado6"
        Text = "Enunciado6"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnEjecutar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtResultado As TextBox
    Friend WithEvents Label3 As Label
End Class
