<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmVerMovimientos
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.dgvMovimientos = New System.Windows.Forms.DataGridView()
        Me.id_cuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmbCliente = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.dgvMovimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(315, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 16)
        Me.Label1.TabIndex = 1
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Georgia", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(36, 31)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(203, 32)
        Me.lblTitulo.TabIndex = 2
        Me.lblTitulo.Text = "Movimientos"
        '
        'dgvMovimientos
        '
        Me.dgvMovimientos.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvMovimientos.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Georgia", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMovimientos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvMovimientos.ColumnHeadersHeight = 29
        Me.dgvMovimientos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_cuenta, Me.Column3, Me.Column1, Me.Column2, Me.Column4})
        Me.dgvMovimientos.Location = New System.Drawing.Point(42, 307)
        Me.dgvMovimientos.Name = "dgvMovimientos"
        Me.dgvMovimientos.ReadOnly = True
        Me.dgvMovimientos.RowHeadersVisible = False
        Me.dgvMovimientos.RowHeadersWidth = 51
        Me.dgvMovimientos.RowTemplate.Height = 24
        Me.dgvMovimientos.Size = New System.Drawing.Size(805, 278)
        Me.dgvMovimientos.TabIndex = 3
        '
        'id_cuenta
        '
        Me.id_cuenta.HeaderText = "id_cuenta"
        Me.id_cuenta.MinimumWidth = 6
        Me.id_cuenta.Name = "id_cuenta"
        Me.id_cuenta.ReadOnly = True
        Me.id_cuenta.Width = 125
        '
        'Column3
        '
        Me.Column3.HeaderText = "Fecha"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 125
        '
        'Column1
        '
        Me.Column1.HeaderText = "Deposito"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 125
        '
        'Column2
        '
        Me.Column2.HeaderText = "Retiro"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 125
        '
        'Column4
        '
        Me.Column4.HeaderText = "Saldo"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 125
        '
        'cmbCliente
        '
        Me.cmbCliente.Font = New System.Drawing.Font("Georgia", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCliente.FormattingEnabled = True
        Me.cmbCliente.Location = New System.Drawing.Point(158, 64)
        Me.cmbCliente.Name = "cmbCliente"
        Me.cmbCliente.Size = New System.Drawing.Size(224, 35)
        Me.cmbCliente.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(34, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 27)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Nombre:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmbCliente)
        Me.GroupBox1.Font = New System.Drawing.Font("Georgia", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(209, 103)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(418, 145)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar Cliente"
        '
        'FrmVerMovimientos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(882, 649)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvMovimientos)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "FrmVerMovimientos"
        Me.Text = "Visualizar Movimientos"
        CType(Me.dgvMovimientos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTitulo As Label
    Friend WithEvents dgvMovimientos As DataGridView
    Friend WithEvents id_cuenta As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents cmbCliente As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
End Class
