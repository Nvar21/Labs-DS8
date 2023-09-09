<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Enunciado4
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
        txtNum = New TextBox()
        Button1 = New Button()
        txtResult = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Myanmar Text", 14F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(339, 43)
        Label1.Name = "Label1"
        Label1.Size = New Size(275, 50)
        Label1.TabIndex = 0
        Label1.Text = " Conjetura de Ulam"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Myanmar Text", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(363, 109)
        Label2.Name = "Label2"
        Label2.Size = New Size(238, 43)
        Label2.TabIndex = 1
        Label2.Text = "Ingrese un número"
        ' 
        ' txtNum
        ' 
        txtNum.Font = New Font("Myanmar Text", 10F, FontStyle.Bold, GraphicsUnit.Point)
        txtNum.Location = New Point(414, 155)
        txtNum.Name = "txtNum"
        txtNum.Size = New Size(150, 46)
        txtNum.TabIndex = 2
        txtNum.TextAlign = HorizontalAlignment.Center
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Myanmar Text", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(399, 234)
        Button1.Name = "Button1"
        Button1.Size = New Size(185, 50)
        Button1.TabIndex = 4
        Button1.Text = "Comprobar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' txtResult
        ' 
        txtResult.Font = New Font("Myanmar Text", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txtResult.Location = New Point(202, 290)
        txtResult.Multiline = True
        txtResult.Name = "txtResult"
        txtResult.ScrollBars = ScrollBars.Vertical
        txtResult.Size = New Size(585, 151)
        txtResult.TabIndex = 5
        ' 
        ' Enunciado4
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(922, 464)
        Controls.Add(txtResult)
        Controls.Add(Button1)
        Controls.Add(txtNum)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Enunciado4"
        Text = "Enunciado4"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNum As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents txtResult As TextBox
End Class
