<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEnunciado3

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
        lblGenero = New Label()
        lblTitulo = New Label()
        pnlTitulo = New Panel()
        txtNumero = New TextBox()
        lblIndicador = New Label()
        Label3 = New Label()
        Label1 = New Label()
        txtResultado = New TextBox()
        pnlRegistros = New Panel()
        lblPrueba = New Label()
        pnlTitulo.SuspendLayout()
        pnlRegistros.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblGenero
        ' 
        lblGenero.AutoSize = True
        lblGenero.FlatStyle = FlatStyle.System
        lblGenero.Font = New Font("Myanmar Text", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblGenero.Location = New Point(478, 71)
        lblGenero.Name = "lblGenero"
        lblGenero.Size = New Size(0, 29)
        lblGenero.TabIndex = 21
        ' 
        ' lblTitulo
        ' 
        lblTitulo.AutoSize = True
        lblTitulo.FlatStyle = FlatStyle.System
        lblTitulo.Font = New Font("Myanmar Text", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblTitulo.Location = New Point(14, 10)
        lblTitulo.Name = "lblTitulo"
        lblTitulo.Size = New Size(352, 34)
        lblTitulo.TabIndex = 0
        lblTitulo.Text = "Enunciado 3 - Invertir Número Entero"
        ' 
        ' pnlTitulo
        ' 
        pnlTitulo.Controls.Add(lblTitulo)
        pnlTitulo.Dock = DockStyle.Top
        pnlTitulo.Location = New Point(20, 20)
        pnlTitulo.Name = "pnlTitulo"
        pnlTitulo.Size = New Size(884, 47)
        pnlTitulo.TabIndex = 22
        ' 
        ' txtNumero
        ' 
        txtNumero.Location = New Point(284, 18)
        txtNumero.MaxLength = 1000
        txtNumero.Name = "txtNumero"
        txtNumero.Size = New Size(199, 23)
        txtNumero.TabIndex = 26
        txtNumero.TextAlign = HorizontalAlignment.Center
        ' 
        ' lblIndicador
        ' 
        lblIndicador.AutoSize = True
        lblIndicador.BackColor = Color.Transparent
        lblIndicador.Font = New Font("Myanmar Text", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblIndicador.ForeColor = Color.Transparent
        lblIndicador.Location = New Point(173, 77)
        lblIndicador.Name = "lblIndicador"
        lblIndicador.Padding = New Padding(3)
        lblIndicador.Size = New Size(6, 35)
        lblIndicador.TabIndex = 29
        lblIndicador.TextAlign = ContentAlignment.MiddleCenter
        lblIndicador.Visible = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.FlatStyle = FlatStyle.System
        Label3.Font = New Font("Myanmar Text", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(73, 16)
        Label3.Name = "Label3"
        Label3.Size = New Size(155, 29)
        Label3.TabIndex = 27
        Label3.Text = "Ingrese el número:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.FlatStyle = FlatStyle.System
        Label1.Font = New Font("Myanmar Text", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(63, 87)
        Label1.Name = "Label1"
        Label1.Size = New Size(169, 29)
        Label1.TabIndex = 32
        Label1.Text = "Número Convertido:"
        ' 
        ' txtResultado
        ' 
        txtResultado.Location = New Point(284, 89)
        txtResultado.MaxLength = 1
        txtResultado.Name = "txtResultado"
        txtResultado.ReadOnly = True
        txtResultado.Size = New Size(199, 23)
        txtResultado.TabIndex = 33
        txtResultado.TextAlign = HorizontalAlignment.Center
        ' 
        ' pnlRegistros
        ' 
        pnlRegistros.Controls.Add(txtResultado)
        pnlRegistros.Controls.Add(Label1)
        pnlRegistros.Controls.Add(Label3)
        pnlRegistros.Controls.Add(lblIndicador)
        pnlRegistros.Controls.Add(txtNumero)
        pnlRegistros.Controls.Add(lblPrueba)
        pnlRegistros.Dock = DockStyle.Top
        pnlRegistros.Location = New Point(20, 67)
        pnlRegistros.Name = "pnlRegistros"
        pnlRegistros.Size = New Size(884, 137)
        pnlRegistros.TabIndex = 26
        ' 
        ' lblPrueba
        ' 
        lblPrueba.AutoSize = True
        lblPrueba.FlatStyle = FlatStyle.System
        lblPrueba.Font = New Font("Myanmar Text", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblPrueba.Location = New Point(500, 16)
        lblPrueba.Name = "lblPrueba"
        lblPrueba.Size = New Size(0, 29)
        lblPrueba.TabIndex = 28
        ' 
        ' frmEnunciado3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(924, 631)
        Controls.Add(pnlRegistros)
        Controls.Add(pnlTitulo)
        Controls.Add(lblGenero)
        Margin = New Padding(3, 2, 3, 2)
        Name = "frmEnunciado3"
        Padding = New Padding(20)
        Text = "Enunciado 3"
        pnlTitulo.ResumeLayout(False)
        pnlTitulo.PerformLayout()
        pnlRegistros.ResumeLayout(False)
        pnlRegistros.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents gpbTotales As GroupBox
    Friend WithEvents txtListaMujeres As TextBox
    Friend WithEvents txtListaHombres As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents lblGenero As Label
    Friend WithEvents btnRegister As Button
    Friend WithEvents txtTemp As TextBox
    Friend WithEvents pnlResultados As Panel
    Friend WithEvents lblLista As Label
    Friend WithEvents dgvResultados As DataGridView
    Friend WithEvents colNumero As DataGridViewTextBoxColumn
    Friend WithEvents colTemperatura As DataGridViewTextBoxColumn
    Friend WithEvents txtmen33 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtMay37 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnVerResult As Button
    Friend WithEvents lblTitulo As Label
    Friend WithEvents pnlTitulo As Panel
    Private WithEvents txtNumero As TextBox
    Friend WithEvents lblIndicador As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtResultado As TextBox
    Friend WithEvents pnlRegistros As Panel
    Friend WithEvents lblPrueba As Label
End Class