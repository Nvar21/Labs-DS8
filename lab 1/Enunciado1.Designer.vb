<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Enunciado1
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
        Label2 = New Label()
        txtCosto = New TextBox()
        Label3 = New Label()
        txtResult = New TextBox()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Myanmar Text", 14F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(302, 63)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(462, 50)
        Label1.TabIndex = 0
        Label1.Text = "Enunciado 1: Costo del automóvil"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(153, 194)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(312, 32)
        Label2.TabIndex = 1
        Label2.Text = "Costo inical del automóvil"
        ' 
        ' txtCosto
        ' 
        txtCosto.Font = New Font("Myanmar Text", 10F, FontStyle.Regular, GraphicsUnit.Point)
        txtCosto.Location = New Point(522, 194)
        txtCosto.Name = "txtCosto"
        txtCosto.Size = New Size(150, 45)
        txtCosto.TabIndex = 2
        txtCosto.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(325, 303)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(140, 32)
        Label3.TabIndex = 3
        Label3.Text = "Costo Final"
        ' 
        ' txtResult
        ' 
        txtResult.Font = New Font("Myanmar Text", 10F, FontStyle.Regular, GraphicsUnit.Point)
        txtResult.Location = New Point(522, 303)
        txtResult.Name = "txtResult"
        txtResult.ReadOnly = True
        txtResult.Size = New Size(150, 45)
        txtResult.TabIndex = 4
        txtResult.TextAlign = HorizontalAlignment.Center
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Myanmar Text", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(509, 412)
        Button1.Name = "Button1"
        Button1.Size = New Size(174, 44)
        Button1.TabIndex = 6
        Button1.Text = "Ejecutar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Enunciado1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1000, 562)
        Controls.Add(Button1)
        Controls.Add(txtResult)
        Controls.Add(Label3)
        Controls.Add(txtCosto)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Margin = New Padding(4)
        Name = "Enunciado1"
        Text = "Enunciado1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCosto As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtResult As TextBox
    Friend WithEvents Button1 As Button
End Class
