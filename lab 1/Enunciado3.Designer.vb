<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Enunciado3
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
        txtNumLim = New TextBox()
        Label2 = New Label()
        txtResultado = New TextBox()
        btnEjecutar = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Myanmar Text", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(357, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(160, 43)
        Label1.TabIndex = 0
        Label1.Text = "Enunciado 3"
        ' 
        ' txtNumLim
        ' 
        txtNumLim.Font = New Font("Myanmar Text", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtNumLim.Location = New Point(467, 97)
        txtNumLim.Name = "txtNumLim"
        txtNumLim.Size = New Size(125, 45)
        txtNumLim.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Myanmar Text", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(284, 106)
        Label2.Name = "Label2"
        Label2.Size = New Size(153, 36)
        Label2.TabIndex = 3
        Label2.Text = "Número límite"
        ' 
        ' txtResultado
        ' 
        txtResultado.Font = New Font("Myanmar Text", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtResultado.Location = New Point(198, 253)
        txtResultado.Multiline = True
        txtResultado.Name = "txtResultado"
        txtResultado.ReadOnly = True
        txtResultado.ScrollBars = ScrollBars.Vertical
        txtResultado.Size = New Size(529, 252)
        txtResultado.TabIndex = 4
        ' 
        ' btnEjecutar
        ' 
        btnEjecutar.Font = New Font("Myanmar Text", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnEjecutar.Location = New Point(386, 175)
        btnEjecutar.Name = "btnEjecutar"
        btnEjecutar.Size = New Size(131, 39)
        btnEjecutar.TabIndex = 5
        btnEjecutar.Text = "Ejecutar"
        btnEjecutar.UseVisualStyleBackColor = True
        ' 
        ' Enunciado3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(912, 529)
        Controls.Add(btnEjecutar)
        Controls.Add(txtResultado)
        Controls.Add(Label2)
        Controls.Add(txtNumLim)
        Controls.Add(Label1)
        Name = "Enunciado3"
        Text = "Enunciado3"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtNumLim As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtResultado As TextBox
    Friend WithEvents btnEjecutar As Button
End Class
