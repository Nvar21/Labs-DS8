<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEnunciado6
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
        btnRegistrar = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(139, 67)
        Label1.Name = "Label1"
        Label1.Size = New Size(487, 38)
        Label1.TabIndex = 0
        Label1.Text = "Enunciado 6: Informe de votaciones"
        ' 
        ' btnRegistrar
        ' 
        btnRegistrar.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnRegistrar.Location = New Point(245, 153)
        btnRegistrar.Name = "btnRegistrar"
        btnRegistrar.Size = New Size(279, 55)
        btnRegistrar.TabIndex = 1
        btnRegistrar.Text = "Registrar nombres"
        btnRegistrar.UseVisualStyleBackColor = True
        ' 
        ' frmEnunciado6
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnRegistrar)
        Controls.Add(Label1)
        Name = "frmEnunciado6"
        Text = "frmEnunciado6"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnRegistrar As Button
End Class
