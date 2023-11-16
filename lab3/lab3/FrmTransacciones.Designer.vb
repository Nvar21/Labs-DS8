<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTransacciones
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbTipoCuenta = New System.Windows.Forms.ComboBox()
        Me.cmbCliente = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rdbRetiro = New System.Windows.Forms.RadioButton()
        Me.rdbDeposito = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSaldo = New System.Windows.Forms.TextBox()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.panelTransaccion = New System.Windows.Forms.Panel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.panelTransaccion.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbTipoCuenta)
        Me.GroupBox1.Controls.Add(Me.cmbCliente)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Georgia", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(23, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(752, 256)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Cliente"
        '
        'cmbTipoCuenta
        '
        Me.cmbTipoCuenta.Font = New System.Drawing.Font("Georgia", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoCuenta.FormattingEnabled = True
        Me.cmbTipoCuenta.Location = New System.Drawing.Point(328, 165)
        Me.cmbTipoCuenta.Name = "cmbTipoCuenta"
        Me.cmbTipoCuenta.Size = New System.Drawing.Size(270, 35)
        Me.cmbTipoCuenta.TabIndex = 5
        '
        'cmbCliente
        '
        Me.cmbCliente.Font = New System.Drawing.Font("Georgia", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCliente.FormattingEnabled = True
        Me.cmbCliente.Location = New System.Drawing.Point(328, 70)
        Me.cmbCliente.Name = "cmbCliente"
        Me.cmbCliente.Size = New System.Drawing.Size(270, 35)
        Me.cmbCliente.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(98, 168)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 27)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tipo de Cuenta:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(178, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cliente:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rdbRetiro)
        Me.GroupBox2.Controls.Add(Me.rdbDeposito)
        Me.GroupBox2.Font = New System.Drawing.Font("Georgia", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(23, 317)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(349, 215)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Transacciones"
        '
        'rdbRetiro
        '
        Me.rdbRetiro.AutoSize = True
        Me.rdbRetiro.Font = New System.Drawing.Font("Georgia", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbRetiro.Location = New System.Drawing.Point(128, 69)
        Me.rdbRetiro.Name = "rdbRetiro"
        Me.rdbRetiro.Size = New System.Drawing.Size(94, 31)
        Me.rdbRetiro.TabIndex = 1
        Me.rdbRetiro.TabStop = True
        Me.rdbRetiro.Text = "Retiro"
        Me.rdbRetiro.UseVisualStyleBackColor = True
        '
        'rdbDeposito
        '
        Me.rdbDeposito.AutoSize = True
        Me.rdbDeposito.Font = New System.Drawing.Font("Georgia", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbDeposito.Location = New System.Drawing.Point(118, 144)
        Me.rdbDeposito.Name = "rdbDeposito"
        Me.rdbDeposito.Size = New System.Drawing.Size(121, 31)
        Me.rdbDeposito.TabIndex = 0
        Me.rdbDeposito.TabStop = True
        Me.rdbDeposito.Text = "Depósito"
        Me.rdbDeposito.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.txtSaldo)
        Me.GroupBox3.Controls.Add(Me.btnRegistrar)
        Me.GroupBox3.Font = New System.Drawing.Font("Georgia", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(422, 320)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(353, 212)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Depósito/ Retiro"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Georgia", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(63, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 27)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Saldo"
        '
        'txtSaldo
        '
        Me.txtSaldo.Font = New System.Drawing.Font("Georgia", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldo.Location = New System.Drawing.Point(166, 69)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.Size = New System.Drawing.Size(114, 32)
        Me.txtSaldo.TabIndex = 1
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrar.Location = New System.Drawing.Point(102, 154)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(130, 41)
        Me.btnRegistrar.TabIndex = 0
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'panelTransaccion
        '
        Me.panelTransaccion.Controls.Add(Me.GroupBox1)
        Me.panelTransaccion.Controls.Add(Me.GroupBox3)
        Me.panelTransaccion.Controls.Add(Me.GroupBox2)
        Me.panelTransaccion.Location = New System.Drawing.Point(40, 120)
        Me.panelTransaccion.Name = "panelTransaccion"
        Me.panelTransaccion.Size = New System.Drawing.Size(801, 561)
        Me.panelTransaccion.TabIndex = 2
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Georgia", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(57, 39)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(321, 32)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Realizar Transacción"
        '
        'FrmTransacciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(882, 693)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.panelTransaccion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "FrmTransacciones"
        Me.Text = "Realizar Transacción"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.panelTransaccion.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbCliente As ComboBox
    Friend WithEvents cmbTipoCuenta As ComboBox
    Friend WithEvents rdbRetiro As RadioButton
    Friend WithEvents rdbDeposito As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSaldo As TextBox
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents panelTransaccion As Panel
    Friend WithEvents lblTitulo As Label
End Class
