<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnEnun1 = New Button()
        btnEnun2 = New Button()
        GroupBox1 = New GroupBox()
        btnEnun6 = New Button()
        btnEnun4 = New Button()
        btnEnun5 = New Button()
        btnEnun3 = New Button()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnEnun1
        ' 
        btnEnun1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnEnun1.Location = New Point(52, 53)
        btnEnun1.Name = "btnEnun1"
        btnEnun1.Size = New Size(120, 31)
        btnEnun1.TabIndex = 0
        btnEnun1.Text = "Enunciado 1"
        btnEnun1.UseVisualStyleBackColor = True
        ' 
        ' btnEnun2
        ' 
        btnEnun2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnEnun2.Location = New Point(234, 53)
        btnEnun2.Name = "btnEnun2"
        btnEnun2.Size = New Size(120, 31)
        btnEnun2.TabIndex = 1
        btnEnun2.Text = "Enunciado 2"
        btnEnun2.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btnEnun6)
        GroupBox1.Controls.Add(btnEnun4)
        GroupBox1.Controls.Add(btnEnun5)
        GroupBox1.Controls.Add(btnEnun3)
        GroupBox1.Controls.Add(btnEnun1)
        GroupBox1.Controls.Add(btnEnun2)
        GroupBox1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        GroupBox1.Location = New Point(156, 76)
        GroupBox1.Margin = New Padding(3, 2, 3, 2)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 2, 3, 2)
        GroupBox1.Size = New Size(407, 267)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        GroupBox1.Text = "Laboratorio 1"
        ' 
        ' btnEnun6
        ' 
        btnEnun6.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnEnun6.Location = New Point(234, 204)
        btnEnun6.Name = "btnEnun6"
        btnEnun6.Size = New Size(120, 31)
        btnEnun6.TabIndex = 5
        btnEnun6.Text = "Enunciado 6"
        btnEnun6.UseVisualStyleBackColor = True
        ' 
        ' btnEnun4
        ' 
        btnEnun4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnEnun4.Location = New Point(234, 128)
        btnEnun4.Name = "btnEnun4"
        btnEnun4.Size = New Size(120, 31)
        btnEnun4.TabIndex = 3
        btnEnun4.Text = "Enunciado 4"
        btnEnun4.UseVisualStyleBackColor = True
        ' 
        ' btnEnun5
        ' 
        btnEnun5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnEnun5.Location = New Point(52, 204)
        btnEnun5.Name = "btnEnun5"
        btnEnun5.Size = New Size(120, 31)
        btnEnun5.TabIndex = 4
        btnEnun5.Text = "Enunciado 5"
        btnEnun5.UseVisualStyleBackColor = True
        ' 
        ' btnEnun3
        ' 
        btnEnun3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnEnun3.Location = New Point(52, 128)
        btnEnun3.Name = "btnEnun3"
        btnEnun3.Size = New Size(120, 31)
        btnEnun3.TabIndex = 2
        btnEnun3.Text = "Enunciado 3"
        btnEnun3.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(GroupBox1)
        Name = "Form1"
        Text = "Menú Laboratorio 1"
        GroupBox1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnEnun1 As Button
    Friend WithEvents btnEnun2 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnEnun4 As Button
    Friend WithEvents btnEnun5 As Button
    Friend WithEvents btnEnun3 As Button
    Friend WithEvents btnEnun6 As Button
End Class
