<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEnunciado1

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
        lblTitulo = New Label()
        lblGenero = New Label()
        pnlTitulo = New Panel()
        pnlRegistros = New Panel()
        btnIniciar = New Button()
        Label3 = New Label()
        txtNumVentas = New TextBox()
        pnlResultados = New Panel()
        txtMontoTotal = New TextBox()
        txtCantidadTotal = New TextBox()
        Label2 = New Label()
        txtMonto3 = New TextBox()
        txtMonto2 = New TextBox()
        txtMonto1 = New TextBox()
        txtCantidad3 = New TextBox()
        txtCantidad2 = New TextBox()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label1 = New Label()
        Label4 = New Label()
        txtCantidad1 = New TextBox()
        lblLista = New Label()
        pnlTitulo.SuspendLayout()
        pnlRegistros.SuspendLayout()
        pnlResultados.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblTitulo
        ' 
        lblTitulo.AutoSize = True
        lblTitulo.FlatStyle = FlatStyle.System
        lblTitulo.Font = New Font("Myanmar Text", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblTitulo.Location = New Point(16, 13)
        lblTitulo.Name = "lblTitulo"
        lblTitulo.Size = New Size(338, 43)
        lblTitulo.TabIndex = 0
        lblTitulo.Text = "Enunciado 1 - Tienda EGPH "
        ' 
        ' lblGenero
        ' 
        lblGenero.AutoSize = True
        lblGenero.FlatStyle = FlatStyle.System
        lblGenero.Font = New Font("Myanmar Text", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblGenero.Location = New Point(546, 95)
        lblGenero.Name = "lblGenero"
        lblGenero.Size = New Size(0, 36)
        lblGenero.TabIndex = 21
        ' 
        ' pnlTitulo
        ' 
        pnlTitulo.Controls.Add(lblTitulo)
        pnlTitulo.Dock = DockStyle.Top
        pnlTitulo.Location = New Point(23, 27)
        pnlTitulo.Margin = New Padding(3, 4, 3, 4)
        pnlTitulo.Name = "pnlTitulo"
        pnlTitulo.Size = New Size(1010, 63)
        pnlTitulo.TabIndex = 22
        ' 
        ' pnlRegistros
        ' 
        pnlRegistros.Controls.Add(btnIniciar)
        pnlRegistros.Controls.Add(Label3)
        pnlRegistros.Controls.Add(txtNumVentas)
        pnlRegistros.Dock = DockStyle.Top
        pnlRegistros.Location = New Point(23, 90)
        pnlRegistros.Margin = New Padding(3, 4, 3, 4)
        pnlRegistros.Name = "pnlRegistros"
        pnlRegistros.Size = New Size(1010, 159)
        pnlRegistros.TabIndex = 26
        ' 
        ' btnIniciar
        ' 
        btnIniciar.BackColor = Color.Teal
        btnIniciar.FlatAppearance.BorderSize = 0
        btnIniciar.FlatStyle = FlatStyle.Flat
        btnIniciar.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        btnIniciar.ForeColor = Color.White
        btnIniciar.Location = New Point(449, 86)
        btnIniciar.Margin = New Padding(3, 4, 3, 4)
        btnIniciar.Name = "btnIniciar"
        btnIniciar.Size = New Size(115, 36)
        btnIniciar.TabIndex = 30
        btnIniciar.Text = "Iniciar"
        btnIniciar.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.FlatStyle = FlatStyle.System
        Label3.Font = New Font("Myanmar Text", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(258, 22)
        Label3.Name = "Label3"
        Label3.Size = New Size(259, 36)
        Label3.TabIndex = 27
        Label3.Text = "Ingrese las ventas del día:"
        ' 
        ' txtNumVentas
        ' 
        txtNumVentas.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        txtNumVentas.Location = New Point(523, 22)
        txtNumVentas.Margin = New Padding(3, 4, 3, 4)
        txtNumVentas.MaxLength = 5
        txtNumVentas.Name = "txtNumVentas"
        txtNumVentas.Size = New Size(102, 31)
        txtNumVentas.TabIndex = 26
        txtNumVentas.TextAlign = HorizontalAlignment.Center
        ' 
        ' pnlResultados
        ' 
        pnlResultados.Controls.Add(txtMontoTotal)
        pnlResultados.Controls.Add(txtCantidadTotal)
        pnlResultados.Controls.Add(Label2)
        pnlResultados.Controls.Add(txtMonto3)
        pnlResultados.Controls.Add(txtMonto2)
        pnlResultados.Controls.Add(txtMonto1)
        pnlResultados.Controls.Add(txtCantidad3)
        pnlResultados.Controls.Add(txtCantidad2)
        pnlResultados.Controls.Add(Label8)
        pnlResultados.Controls.Add(Label7)
        pnlResultados.Controls.Add(Label6)
        pnlResultados.Controls.Add(Label5)
        pnlResultados.Controls.Add(Label1)
        pnlResultados.Controls.Add(Label4)
        pnlResultados.Controls.Add(txtCantidad1)
        pnlResultados.Controls.Add(lblLista)
        pnlResultados.Dock = DockStyle.Top
        pnlResultados.Location = New Point(23, 249)
        pnlResultados.Margin = New Padding(3, 4, 3, 4)
        pnlResultados.Name = "pnlResultados"
        pnlResultados.Size = New Size(1010, 371)
        pnlResultados.TabIndex = 27
        ' 
        ' txtMontoTotal
        ' 
        txtMontoTotal.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        txtMontoTotal.Location = New Point(598, 299)
        txtMontoTotal.Margin = New Padding(3, 4, 3, 4)
        txtMontoTotal.MaxLength = 1
        txtMontoTotal.Name = "txtMontoTotal"
        txtMontoTotal.ReadOnly = True
        txtMontoTotal.Size = New Size(113, 31)
        txtMontoTotal.TabIndex = 51
        txtMontoTotal.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtCantidadTotal
        ' 
        txtCantidadTotal.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        txtCantidadTotal.Location = New Point(446, 299)
        txtCantidadTotal.Margin = New Padding(3, 4, 3, 4)
        txtCantidadTotal.MaxLength = 1
        txtCantidadTotal.Name = "txtCantidadTotal"
        txtCantidadTotal.ReadOnly = True
        txtCantidadTotal.Size = New Size(113, 31)
        txtCantidadTotal.TabIndex = 50
        txtCantidadTotal.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.FlatStyle = FlatStyle.System
        Label2.Font = New Font("Myanmar Text", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(365, 302)
        Label2.Name = "Label2"
        Label2.Size = New Size(64, 36)
        Label2.TabIndex = 49
        Label2.Text = "Total"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' txtMonto3
        ' 
        txtMonto3.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        txtMonto3.Location = New Point(598, 237)
        txtMonto3.Margin = New Padding(3, 4, 3, 4)
        txtMonto3.MaxLength = 1
        txtMonto3.Name = "txtMonto3"
        txtMonto3.ReadOnly = True
        txtMonto3.Size = New Size(113, 31)
        txtMonto3.TabIndex = 48
        txtMonto3.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtMonto2
        ' 
        txtMonto2.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        txtMonto2.Location = New Point(598, 180)
        txtMonto2.Margin = New Padding(3, 4, 3, 4)
        txtMonto2.MaxLength = 1
        txtMonto2.Name = "txtMonto2"
        txtMonto2.ReadOnly = True
        txtMonto2.Size = New Size(113, 31)
        txtMonto2.TabIndex = 47
        txtMonto2.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtMonto1
        ' 
        txtMonto1.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        txtMonto1.Location = New Point(598, 122)
        txtMonto1.Margin = New Padding(3, 4, 3, 4)
        txtMonto1.MaxLength = 1
        txtMonto1.Name = "txtMonto1"
        txtMonto1.ReadOnly = True
        txtMonto1.Size = New Size(113, 31)
        txtMonto1.TabIndex = 46
        txtMonto1.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtCantidad3
        ' 
        txtCantidad3.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        txtCantidad3.Location = New Point(446, 237)
        txtCantidad3.Margin = New Padding(3, 4, 3, 4)
        txtCantidad3.MaxLength = 1
        txtCantidad3.Name = "txtCantidad3"
        txtCantidad3.ReadOnly = True
        txtCantidad3.Size = New Size(113, 31)
        txtCantidad3.TabIndex = 45
        txtCantidad3.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtCantidad2
        ' 
        txtCantidad2.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        txtCantidad2.Location = New Point(446, 180)
        txtCantidad2.Margin = New Padding(3, 4, 3, 4)
        txtCantidad2.MaxLength = 1
        txtCantidad2.Name = "txtCantidad2"
        txtCantidad2.ReadOnly = True
        txtCantidad2.Size = New Size(113, 31)
        txtCantidad2.TabIndex = 44
        txtCantidad2.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.FlatStyle = FlatStyle.System
        Label8.Font = New Font("Myanmar Text", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(614, 82)
        Label8.Name = "Label8"
        Label8.Size = New Size(78, 36)
        Label8.TabIndex = 43
        Label8.Text = "Monto"
        Label8.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.FlatStyle = FlatStyle.System
        Label7.Font = New Font("Myanmar Text", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(455, 82)
        Label7.Name = "Label7"
        Label7.Size = New Size(99, 36)
        Label7.TabIndex = 42
        Label7.Text = "Cantidad"
        Label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.FlatStyle = FlatStyle.System
        Label6.Font = New Font("Myanmar Text", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(262, 242)
        Label6.Name = "Label6"
        Label6.Size = New Size(167, 36)
        Label6.TabIndex = 41
        Label6.Text = "menores a $500"
        Label6.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.FlatStyle = FlatStyle.System
        Label5.Font = New Font("Myanmar Text", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(227, 181)
        Label5.Name = "Label5"
        Label5.Size = New Size(202, 36)
        Label5.TabIndex = 40
        Label5.Text = "entre $500 y $1000"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.FlatStyle = FlatStyle.System
        Label1.Font = New Font("Myanmar Text", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(251, 122)
        Label1.Name = "Label1"
        Label1.Size = New Size(178, 36)
        Label1.TabIndex = 39
        Label1.Text = "mayores a $1000"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.FlatStyle = FlatStyle.System
        Label4.Font = New Font("Myanmar Text", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(251, 384)
        Label4.Name = "Label4"
        Label4.Size = New Size(0, 36)
        Label4.TabIndex = 36
        ' 
        ' txtCantidad1
        ' 
        txtCantidad1.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        txtCantidad1.Location = New Point(446, 122)
        txtCantidad1.Margin = New Padding(3, 4, 3, 4)
        txtCantidad1.MaxLength = 1
        txtCantidad1.Name = "txtCantidad1"
        txtCantidad1.ReadOnly = True
        txtCantidad1.Size = New Size(113, 31)
        txtCantidad1.TabIndex = 35
        txtCantidad1.TextAlign = HorizontalAlignment.Center
        ' 
        ' lblLista
        ' 
        lblLista.AutoSize = True
        lblLista.Font = New Font("Myanmar Text", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblLista.Location = New Point(449, 13)
        lblLista.Name = "lblLista"
        lblLista.Size = New Size(118, 36)
        lblLista.TabIndex = 22
        lblLista.Text = "Resultados"
        ' 
        ' frmEnunciado1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1056, 659)
        Controls.Add(pnlResultados)
        Controls.Add(pnlRegistros)
        Controls.Add(pnlTitulo)
        Controls.Add(lblGenero)
        Name = "frmEnunciado1"
        Padding = New Padding(23, 27, 23, 27)
        Text = "Enunciado 1"
        pnlTitulo.ResumeLayout(False)
        pnlTitulo.PerformLayout()
        pnlRegistros.ResumeLayout(False)
        pnlRegistros.PerformLayout()
        pnlResultados.ResumeLayout(False)
        pnlResultados.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents gpbTotales As GroupBox
    Friend WithEvents txtListaMujeres As TextBox
    Friend WithEvents txtListaHombres As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents lblGenero As Label
    Friend WithEvents pnlTitulo As Panel
    Friend WithEvents pnlRegistros As Panel
    Friend WithEvents btnRegister As Button
    Friend WithEvents btnIniciar As Button
    Friend WithEvents Label3 As Label
    Private txtNumVentas As TextBox
    Friend WithEvents txtTemp As TextBox
    Friend WithEvents pnlResultados As Panel
    Friend WithEvents lblLista As Label
    Friend WithEvents txtmen33 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCantidad1 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtMonto3 As TextBox
    Friend WithEvents txtMonto2 As TextBox
    Friend WithEvents txtMonto1 As TextBox
    Friend WithEvents txtCantidad3 As TextBox
    Friend WithEvents txtCantidad2 As TextBox
    Friend WithEvents txtMontoTotal As TextBox
    Friend WithEvents txtCantidadTotal As TextBox
    Friend WithEvents Label2 As Label
End Class