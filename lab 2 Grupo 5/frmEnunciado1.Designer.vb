﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        lblTitulo = New Label()
        gpbTotales = New GroupBox()
        txtListaMujeres = New TextBox()
        txtListaHombres = New TextBox()
        Label12 = New Label()
        Label14 = New Label()
        Label16 = New Label()
        lblGenero = New Label()
        pnlTitulo = New Panel()
        pnlRegistros = New Panel()
        Label5 = New Label()
        txtContador = New TextBox()
        Label1 = New Label()
        btnRegister = New Button()
        Label3 = New Label()
        lblIndicador = New Label()
        txtTemp = New TextBox()
        lblIndicacion = New Label()
        pnlResultados = New Panel()
        btnVerResult = New Button()
        txtmen33 = New TextBox()
        Label4 = New Label()
        txtMay37 = New TextBox()
        dgvResultados = New DataGridView()
        colNumero = New DataGridViewTextBoxColumn()
        colTemperatura = New DataGridViewTextBoxColumn()
        Label2 = New Label()
        lblLista = New Label()
        gpbTotales.SuspendLayout()
        pnlTitulo.SuspendLayout()
        pnlRegistros.SuspendLayout()
        pnlResultados.SuspendLayout()
        CType(dgvResultados, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblTitulo
        ' 
        lblTitulo.AutoSize = True
        lblTitulo.FlatStyle = FlatStyle.System
        lblTitulo.Font = New Font("Myanmar Text", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblTitulo.Location = New Point(20, 17)
        lblTitulo.Margin = New Padding(4, 0, 4, 0)
        lblTitulo.Name = "lblTitulo"
        lblTitulo.Size = New Size(571, 51)
        lblTitulo.TabIndex = 0
        lblTitulo.Text = "Enunciado 2 - Control de Temperaturas "
        ' 
        ' gpbTotales
        ' 
        gpbTotales.Controls.Add(txtListaMujeres)
        gpbTotales.Controls.Add(txtListaHombres)
        gpbTotales.Controls.Add(Label12)
        gpbTotales.Controls.Add(Label14)
        gpbTotales.Controls.Add(Label16)
        gpbTotales.Location = New Point(34, 723)
        gpbTotales.Margin = New Padding(4, 3, 4, 3)
        gpbTotales.Name = "gpbTotales"
        gpbTotales.Padding = New Padding(4, 3, 4, 3)
        gpbTotales.Size = New Size(860, 125)
        gpbTotales.TabIndex = 19
        gpbTotales.TabStop = False
        gpbTotales.Text = "Total Accidentados"
        ' 
        ' txtListaMujeres
        ' 
        txtListaMujeres.Location = New Point(433, 73)
        txtListaMujeres.Margin = New Padding(4, 3, 4, 3)
        txtListaMujeres.Name = "txtListaMujeres"
        txtListaMujeres.ReadOnly = True
        txtListaMujeres.Size = New Size(417, 31)
        txtListaMujeres.TabIndex = 21
        ' 
        ' txtListaHombres
        ' 
        txtListaHombres.Location = New Point(431, 33)
        txtListaHombres.Margin = New Padding(4, 3, 4, 3)
        txtListaHombres.Name = "txtListaHombres"
        txtListaHombres.ReadOnly = True
        txtListaHombres.Size = New Size(418, 31)
        txtListaHombres.TabIndex = 20
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Myanmar Text", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label12.Location = New Point(323, 70)
        Label12.Margin = New Padding(4, 0, 4, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(105, 43)
        Label12.TabIndex = 14
        Label12.Text = "Mujeres"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Myanmar Text", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label14.Location = New Point(39, 57)
        Label14.Margin = New Padding(4, 0, 4, 0)
        Label14.Name = "Label14"
        Label14.Size = New Size(249, 43)
        Label14.TabIndex = 12
        Label14.Text = "Lista de Accidentados"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Myanmar Text", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label16.Location = New Point(311, 33)
        Label16.Margin = New Padding(4, 0, 4, 0)
        Label16.Name = "Label16"
        Label16.Size = New Size(116, 43)
        Label16.TabIndex = 13
        Label16.Text = "Hombres"
        ' 
        ' lblGenero
        ' 
        lblGenero.AutoSize = True
        lblGenero.FlatStyle = FlatStyle.System
        lblGenero.Font = New Font("Myanmar Text", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblGenero.Location = New Point(683, 118)
        lblGenero.Margin = New Padding(4, 0, 4, 0)
        lblGenero.Name = "lblGenero"
        lblGenero.Size = New Size(0, 43)
        lblGenero.TabIndex = 21
        ' 
        ' pnlTitulo
        ' 
        pnlTitulo.Controls.Add(lblTitulo)
        pnlTitulo.Dock = DockStyle.Top
        pnlTitulo.Location = New Point(29, 33)
        pnlTitulo.Margin = New Padding(4, 5, 4, 5)
        pnlTitulo.Name = "pnlTitulo"
        pnlTitulo.Size = New Size(860, 78)
        pnlTitulo.TabIndex = 22
        ' 
        ' pnlRegistros
        ' 
        pnlRegistros.Controls.Add(Label5)
        pnlRegistros.Controls.Add(txtContador)
        pnlRegistros.Controls.Add(Label1)
        pnlRegistros.Controls.Add(btnRegister)
        pnlRegistros.Controls.Add(Label3)
        pnlRegistros.Controls.Add(lblIndicador)
        pnlRegistros.Controls.Add(txtTemp)
        pnlRegistros.Controls.Add(lblIndicacion)
        pnlRegistros.Dock = DockStyle.Top
        pnlRegistros.Location = New Point(29, 111)
        pnlRegistros.Margin = New Padding(4, 5, 4, 5)
        pnlRegistros.Name = "pnlRegistros"
        pnlRegistros.Size = New Size(860, 340)
        pnlRegistros.TabIndex = 26
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.FlatStyle = FlatStyle.System
        Label5.Font = New Font("Myanmar Text", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(923, 22)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(43, 43)
        Label5.TabIndex = 34
        Label5.Text = "°C"
        ' 
        ' txtContador
        ' 
        txtContador.Location = New Point(428, 231)
        txtContador.Margin = New Padding(4, 5, 4, 5)
        txtContador.MaxLength = 1
        txtContador.Name = "txtContador"
        txtContador.ReadOnly = True
        txtContador.Size = New Size(283, 31)
        txtContador.TabIndex = 33
        txtContador.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.FlatStyle = FlatStyle.System
        Label1.Font = New Font("Myanmar Text", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(112, 228)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(325, 43)
        Label1.TabIndex = 32
        Label1.Text = "Personas que han entrado:"
        ' 
        ' btnRegister
        ' 
        btnRegister.BackColor = Color.Teal
        btnRegister.Enabled = False
        btnRegister.FlatAppearance.BorderSize = 0
        btnRegister.FlatStyle = FlatStyle.Flat
        btnRegister.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnRegister.ForeColor = Color.White
        btnRegister.Location = New Point(507, 81)
        btnRegister.Margin = New Padding(4, 5, 4, 5)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(144, 45)
        btnRegister.TabIndex = 30
        btnRegister.Text = "Registrar"
        btnRegister.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.FlatStyle = FlatStyle.System
        Label3.Font = New Font("Myanmar Text", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(127, 30)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(292, 43)
        Label3.TabIndex = 27
        Label3.Text = "Ingrese la Temperatura:"
        ' 
        ' lblIndicador
        ' 
        lblIndicador.AutoSize = True
        lblIndicador.BackColor = Color.Transparent
        lblIndicador.Font = New Font("Myanmar Text", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblIndicador.ForeColor = Color.Transparent
        lblIndicador.Location = New Point(269, 131)
        lblIndicador.Margin = New Padding(4, 0, 4, 0)
        lblIndicador.Name = "lblIndicador"
        lblIndicador.Padding = New Padding(4, 5, 4, 5)
        lblIndicador.Size = New Size(8, 53)
        lblIndicador.TabIndex = 29
        lblIndicador.TextAlign = ContentAlignment.MiddleCenter
        lblIndicador.Visible = False
        ' 
        ' txtTemp
        ' 
        txtTemp.Location = New Point(428, 33)
        txtTemp.Margin = New Padding(4, 5, 4, 5)
        txtTemp.MaxLength = 5
        txtTemp.Name = "txtTemp"
        txtTemp.Size = New Size(283, 31)
        txtTemp.TabIndex = 26
        txtTemp.TextAlign = HorizontalAlignment.Center
        ' 
        ' lblIndicacion
        ' 
        lblIndicacion.AutoSize = True
        lblIndicacion.FlatStyle = FlatStyle.System
        lblIndicacion.Font = New Font("Myanmar Text", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblIndicacion.Location = New Point(127, 76)
        lblIndicacion.Margin = New Padding(4, 0, 4, 0)
        lblIndicacion.Name = "lblIndicacion"
        lblIndicacion.Size = New Size(372, 43)
        lblIndicacion.TabIndex = 28
        lblIndicacion.Text = "(ingrese 0 para finalizar registros)"
        ' 
        ' pnlResultados
        ' 
        pnlResultados.Controls.Add(btnVerResult)
        pnlResultados.Controls.Add(txtmen33)
        pnlResultados.Controls.Add(Label4)
        pnlResultados.Controls.Add(txtMay37)
        pnlResultados.Controls.Add(dgvResultados)
        pnlResultados.Controls.Add(Label2)
        pnlResultados.Controls.Add(lblLista)
        pnlResultados.Dock = DockStyle.Top
        pnlResultados.Location = New Point(29, 451)
        pnlResultados.Margin = New Padding(4, 5, 4, 5)
        pnlResultados.Name = "pnlResultados"
        pnlResultados.Size = New Size(860, 582)
        pnlResultados.TabIndex = 27
        ' 
        ' btnVerResult
        ' 
        btnVerResult.BackColor = Color.Teal
        btnVerResult.Dock = DockStyle.Bottom
        btnVerResult.Enabled = False
        btnVerResult.FlatAppearance.BorderSize = 0
        btnVerResult.FlatStyle = FlatStyle.Flat
        btnVerResult.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnVerResult.ForeColor = Color.White
        btnVerResult.Location = New Point(0, 537)
        btnVerResult.Margin = New Padding(4, 5, 4, 5)
        btnVerResult.Name = "btnVerResult"
        btnVerResult.Size = New Size(860, 45)
        btnVerResult.TabIndex = 38
        btnVerResult.Text = "Ver Resultados"
        btnVerResult.UseVisualStyleBackColor = False
        ' 
        ' txtmen33
        ' 
        txtmen33.Location = New Point(750, 483)
        txtmen33.Margin = New Padding(4, 5, 4, 5)
        txtmen33.MaxLength = 1
        txtmen33.Name = "txtmen33"
        txtmen33.ReadOnly = True
        txtmen33.Size = New Size(163, 31)
        txtmen33.TabIndex = 37
        txtmen33.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.FlatStyle = FlatStyle.System
        Label4.Font = New Font("Myanmar Text", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(314, 480)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(473, 43)
        Label4.TabIndex = 36
        Label4.Text = "Personas con temperatura menor a 33°:"
        ' 
        ' txtMay37
        ' 
        txtMay37.Location = New Point(750, 405)
        txtMay37.Margin = New Padding(4, 5, 4, 5)
        txtMay37.MaxLength = 1
        txtMay37.Name = "txtMay37"
        txtMay37.ReadOnly = True
        txtMay37.Size = New Size(163, 31)
        txtMay37.TabIndex = 35
        txtMay37.TextAlign = HorizontalAlignment.Center
        ' 
        ' dgvResultados
        ' 
        dgvResultados.BackgroundColor = SystemColors.Control
        dgvResultados.CellBorderStyle = DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = Color.Teal
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvResultados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvResultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvResultados.Columns.AddRange(New DataGridViewColumn() {colNumero, colTemperatura})
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = Color.Black
        DataGridViewCellStyle2.SelectionBackColor = Color.Transparent
        DataGridViewCellStyle2.SelectionForeColor = Color.Black
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvResultados.DefaultCellStyle = DataGridViewCellStyle2
        dgvResultados.Dock = DockStyle.Top
        dgvResultados.GridColor = SystemColors.ActiveCaption
        dgvResultados.Location = New Point(0, 43)
        dgvResultados.Margin = New Padding(4, 5, 4, 5)
        dgvResultados.Name = "dgvResultados"
        dgvResultados.RowHeadersVisible = False
        dgvResultados.RowHeadersWidth = 62
        dgvResultados.RowTemplate.Height = 25
        dgvResultados.Size = New Size(860, 335)
        dgvResultados.TabIndex = 23
        ' 
        ' colNumero
        ' 
        colNumero.HeaderText = "Número de Ingreso"
        colNumero.MinimumWidth = 8
        colNumero.Name = "colNumero"
        colNumero.Width = 441
        ' 
        ' colTemperatura
        ' 
        colTemperatura.HeaderText = "Temperatura"
        colTemperatura.MinimumWidth = 8
        colTemperatura.Name = "colTemperatura"
        colTemperatura.Width = 440
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.FlatStyle = FlatStyle.System
        Label2.Font = New Font("Myanmar Text", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(314, 402)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(471, 43)
        Label2.TabIndex = 34
        Label2.Text = "Personas con temperatura mayor a 37°:"
        ' 
        ' lblLista
        ' 
        lblLista.AutoSize = True
        lblLista.Dock = DockStyle.Top
        lblLista.Font = New Font("Myanmar Text", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblLista.Location = New Point(0, 0)
        lblLista.Margin = New Padding(4, 0, 4, 0)
        lblLista.Name = "lblLista"
        lblLista.Size = New Size(505, 43)
        lblLista.TabIndex = 22
        lblLista.Text = "Lista de Personas y Temperaturas Medidas"
        ' 
        ' frmEnunciado1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(918, 614)
        Controls.Add(pnlResultados)
        Controls.Add(pnlRegistros)
        Controls.Add(pnlTitulo)
        Controls.Add(lblGenero)
        Controls.Add(gpbTotales)
        Margin = New Padding(4, 3, 4, 3)
        Name = "frmEnunciado1"
        Padding = New Padding(29, 33, 29, 33)
        Text = "Enunciado 1"
        gpbTotales.ResumeLayout(False)
        gpbTotales.PerformLayout()
        pnlTitulo.ResumeLayout(False)
        pnlTitulo.PerformLayout()
        pnlRegistros.ResumeLayout(False)
        pnlRegistros.PerformLayout()
        pnlResultados.ResumeLayout(False)
        pnlResultados.PerformLayout()
        CType(dgvResultados, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label3 As Label
    Friend WithEvents lblIndicador As Label
    Friend WithEvents txtTemp As TextBox
    Friend WithEvents lblIndicacion As Label
    Friend WithEvents pnlResultados As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtContador As TextBox
    Friend WithEvents lblLista As Label
    Friend WithEvents dgvResultados As DataGridView
    Friend WithEvents colNumero As DataGridViewTextBoxColumn
    Friend WithEvents colTemperatura As DataGridViewTextBoxColumn
    Friend WithEvents txtmen33 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtMay37 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnVerResult As Button
End Class