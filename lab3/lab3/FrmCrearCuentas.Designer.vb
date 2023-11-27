<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCrearCuentas
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
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbCliente = New System.Windows.Forms.ComboBox()
        Me.rdbCuentCorriente = New System.Windows.Forms.RadioButton()
        Me.rdbCuentAhorro = New System.Windows.Forms.RadioButton()
        Me.btnCrear = New System.Windows.Forms.Button()
        Me.txtSaldo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Georgia", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(67, 48)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(0, 32)
        Me.lblTitulo.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbCliente)
        Me.GroupBox1.Controls.Add(Me.rdbCuentCorriente)
        Me.GroupBox1.Controls.Add(Me.rdbCuentAhorro)
        Me.GroupBox1.Controls.Add(Me.btnCrear)
        Me.GroupBox1.Controls.Add(Me.txtSaldo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Georgia", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(15, 118)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(917, 373)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de Cuenta"
        '
        'cmbCliente
        '
        Me.cmbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCliente.Font = New System.Drawing.Font("Georgia", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCliente.FormattingEnabled = True
        Me.cmbCliente.Location = New System.Drawing.Point(220, 57)
        Me.cmbCliente.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbCliente.Name = "cmbCliente"
        Me.cmbCliente.Size = New System.Drawing.Size(636, 35)
        Me.cmbCliente.TabIndex = 17
        '
        'rdbCuentCorriente
        '
        Me.rdbCuentCorriente.AutoSize = True
        Me.rdbCuentCorriente.Font = New System.Drawing.Font("Georgia", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbCuentCorriente.Location = New System.Drawing.Point(583, 135)
        Me.rdbCuentCorriente.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rdbCuentCorriente.Name = "rdbCuentCorriente"
        Me.rdbCuentCorriente.Size = New System.Drawing.Size(201, 31)
        Me.rdbCuentCorriente.TabIndex = 16
        Me.rdbCuentCorriente.TabStop = True
        Me.rdbCuentCorriente.Text = "Cuenta Corriente"
        Me.rdbCuentCorriente.UseVisualStyleBackColor = True
        '
        'rdbCuentAhorro
        '
        Me.rdbCuentAhorro.AutoSize = True
        Me.rdbCuentAhorro.Font = New System.Drawing.Font("Georgia", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbCuentAhorro.Location = New System.Drawing.Point(280, 135)
        Me.rdbCuentAhorro.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rdbCuentAhorro.Name = "rdbCuentAhorro"
        Me.rdbCuentAhorro.Size = New System.Drawing.Size(207, 31)
        Me.rdbCuentAhorro.TabIndex = 15
        Me.rdbCuentAhorro.TabStop = True
        Me.rdbCuentAhorro.Text = "Cuenta de Ahorro"
        Me.rdbCuentAhorro.UseVisualStyleBackColor = True
        '
        'btnCrear
        '
        Me.btnCrear.Enabled = False
        Me.btnCrear.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCrear.Location = New System.Drawing.Point(373, 298)
        Me.btnCrear.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCrear.Name = "btnCrear"
        Me.btnCrear.Size = New System.Drawing.Size(188, 38)
        Me.btnCrear.TabIndex = 14
        Me.btnCrear.Text = "Crear Cuenta"
        Me.btnCrear.UseVisualStyleBackColor = True
        '
        'txtSaldo
        '
        Me.txtSaldo.Enabled = False
        Me.txtSaldo.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldo.Location = New System.Drawing.Point(504, 212)
        Me.txtSaldo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSaldo.Multiline = True
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.Size = New System.Drawing.Size(243, 31)
        Me.txtSaldo.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 140)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 27)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Tipo de cuenta:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Georgia", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(51, 214)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(396, 27)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "¿Con cuánto saldo va a abrir su cuenta?"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Georgia", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(116, 298)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 27)
        Me.Label3.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(169, 27)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Nombre cliente:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Georgia", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(41, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(389, 32)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Crear Cuenta para Cliente"
        '
        'FrmCrearCuentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(947, 576)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblTitulo)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FrmCrearCuentas"
        Me.Text = "FrmCrearCuentas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitulo As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSaldo As TextBox
    Friend WithEvents btnCrear As Button
    Friend WithEvents rdbCuentCorriente As RadioButton
    Friend WithEvents rdbCuentAhorro As RadioButton
    Friend WithEvents cmbCliente As ComboBox
    Friend WithEvents Label5 As Label
End Class
