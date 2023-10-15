<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEnunciado5
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
        lblTitulo = New Label()
        pnlTitulo = New Panel()
        Panel1 = New Panel()
        Label1 = New Label()
        lstResultado = New ListBox()
        btnRotar = New Button()
        Label3 = New Label()
        txtCadena = New TextBox()
        pnlTitulo.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblTitulo
        ' 
        lblTitulo.AutoSize = True
        lblTitulo.FlatStyle = FlatStyle.System
        lblTitulo.Font = New Font("Myanmar Text", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblTitulo.Location = New Point(225, 11)
        lblTitulo.Name = "lblTitulo"
        lblTitulo.Size = New Size(387, 43)
        lblTitulo.TabIndex = 0
        lblTitulo.Text = "Enunciado 5 - Rotación de texto"
        lblTitulo.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' pnlTitulo
        ' 
        pnlTitulo.Controls.Add(lblTitulo)
        pnlTitulo.Location = New Point(12, 13)
        pnlTitulo.Margin = New Padding(3, 4, 3, 4)
        pnlTitulo.Name = "pnlTitulo"
        pnlTitulo.Size = New Size(848, 63)
        pnlTitulo.TabIndex = 23
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(lstResultado)
        Panel1.Controls.Add(btnRotar)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(txtCadena)
        Panel1.Location = New Point(12, 83)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(848, 545)
        Panel1.TabIndex = 24
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.FlatStyle = FlatStyle.System
        Label1.Font = New Font("Myanmar Text", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(586, 61)
        Label1.Name = "Label1"
        Label1.Size = New Size(109, 36)
        Label1.TabIndex = 35
        Label1.Text = "Resultado"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lstResultado
        ' 
        lstResultado.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lstResultado.FormattingEnabled = True
        lstResultado.HorizontalScrollbar = True
        lstResultado.ItemHeight = 28
        lstResultado.Location = New Point(453, 100)
        lstResultado.Name = "lstResultado"
        lstResultado.Size = New Size(366, 368)
        lstResultado.TabIndex = 34
        ' 
        ' btnRotar
        ' 
        btnRotar.BackColor = Color.Teal
        btnRotar.FlatAppearance.BorderSize = 0
        btnRotar.FlatStyle = FlatStyle.Flat
        btnRotar.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnRotar.ForeColor = Color.White
        btnRotar.Location = New Point(133, 314)
        btnRotar.Margin = New Padding(3, 4, 3, 4)
        btnRotar.Name = "btnRotar"
        btnRotar.Size = New Size(115, 36)
        btnRotar.TabIndex = 33
        btnRotar.Text = "Rotar"
        btnRotar.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.FlatStyle = FlatStyle.System
        Label3.Font = New Font("Myanmar Text", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(105, 126)
        Label3.Name = "Label3"
        Label3.Size = New Size(175, 36)
        Label3.TabIndex = 32
        Label3.Text = "Ingrese un texto:"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' txtCadena
        ' 
        txtCadena.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txtCadena.Location = New Point(43, 188)
        txtCadena.Margin = New Padding(3, 4, 3, 4)
        txtCadena.MaxLength = 0
        txtCadena.Multiline = True
        txtCadena.Name = "txtCadena"
        txtCadena.ScrollBars = ScrollBars.Vertical
        txtCadena.Size = New Size(303, 94)
        txtCadena.TabIndex = 31
        txtCadena.TextAlign = HorizontalAlignment.Center
        ' 
        ' frmEnunciado5
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(872, 640)
        Controls.Add(Panel1)
        Controls.Add(pnlTitulo)
        Name = "frmEnunciado5"
        Text = "frmEnunciado5"
        pnlTitulo.ResumeLayout(False)
        pnlTitulo.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents pnlTitulo As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnRotar As Button
    Friend WithEvents Label3 As Label
    Private WithEvents txtCadena As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lstResultado As ListBox
End Class
