<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Enunciado5
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
        gpbMetodos = New GroupBox()
        rdbClave = New RadioButton()
        rdbTarjeta = New RadioButton()
        rdbCheque = New RadioButton()
        rdbEfectivo = New RadioButton()
        txtPrecio = New TextBox()
        Label3 = New Label()
        txtUnidades = New TextBox()
        Label2 = New Label()
        GroupBox1 = New GroupBox()
        txtTotalPagar = New TextBox()
        txtDescuento = New TextBox()
        txtPrecioOG = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        btnCalcular = New Button()
        gpbMetodos.SuspendLayout()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.FlatStyle = FlatStyle.System
        Label1.Font = New Font("Myanmar Text", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(430, 34)
        Label1.TabIndex = 1
        Label1.Text = "Enunciado 5 - Manejo de precios de productos"
        ' 
        ' gpbMetodos
        ' 
        gpbMetodos.Controls.Add(rdbClave)
        gpbMetodos.Controls.Add(rdbTarjeta)
        gpbMetodos.Controls.Add(rdbCheque)
        gpbMetodos.Controls.Add(rdbEfectivo)
        gpbMetodos.Location = New Point(232, 62)
        gpbMetodos.Name = "gpbMetodos"
        gpbMetodos.Size = New Size(179, 146)
        gpbMetodos.TabIndex = 2
        gpbMetodos.TabStop = False
        gpbMetodos.Text = "Métodos de Pago"
        ' 
        ' rdbClave
        ' 
        rdbClave.AutoSize = True
        rdbClave.Font = New Font("Myanmar Text", 12F, FontStyle.Bold, GraphicsUnit.Point)
        rdbClave.Location = New Point(6, 94)
        rdbClave.Name = "rdbClave"
        rdbClave.Size = New Size(130, 33)
        rdbClave.TabIndex = 4
        rdbClave.TabStop = True
        rdbClave.Text = "Tarjeta Clave"
        rdbClave.UseVisualStyleBackColor = True
        ' 
        ' rdbTarjeta
        ' 
        rdbTarjeta.AutoSize = True
        rdbTarjeta.Font = New Font("Myanmar Text", 12F, FontStyle.Bold, GraphicsUnit.Point)
        rdbTarjeta.Location = New Point(6, 68)
        rdbTarjeta.Name = "rdbTarjeta"
        rdbTarjeta.Size = New Size(167, 33)
        rdbTarjeta.TabIndex = 2
        rdbTarjeta.TabStop = True
        rdbTarjeta.Text = "Tarjeta de Crédito"
        rdbTarjeta.UseVisualStyleBackColor = True
        ' 
        ' rdbCheque
        ' 
        rdbCheque.AutoSize = True
        rdbCheque.Font = New Font("Myanmar Text", 12F, FontStyle.Bold, GraphicsUnit.Point)
        rdbCheque.Location = New Point(6, 45)
        rdbCheque.Name = "rdbCheque"
        rdbCheque.Size = New Size(89, 33)
        rdbCheque.TabIndex = 1
        rdbCheque.TabStop = True
        rdbCheque.Text = "Cheque"
        rdbCheque.UseVisualStyleBackColor = True
        ' 
        ' rdbEfectivo
        ' 
        rdbEfectivo.AutoSize = True
        rdbEfectivo.Font = New Font("Myanmar Text", 12F, FontStyle.Bold, GraphicsUnit.Point)
        rdbEfectivo.Location = New Point(7, 22)
        rdbEfectivo.Name = "rdbEfectivo"
        rdbEfectivo.Size = New Size(93, 33)
        rdbEfectivo.TabIndex = 0
        rdbEfectivo.TabStop = True
        rdbEfectivo.Text = "Efectivo"
        rdbEfectivo.UseVisualStyleBackColor = True
        ' 
        ' txtPrecio
        ' 
        txtPrecio.Location = New Point(55, 94)
        txtPrecio.MaxLength = 32000
        txtPrecio.Name = "txtPrecio"
        txtPrecio.PlaceholderText = "$"
        txtPrecio.Size = New Size(100, 23)
        txtPrecio.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.FlatStyle = FlatStyle.System
        Label3.Font = New Font("Myanmar Text", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(43, 62)
        Label3.Name = "Label3"
        Label3.Size = New Size(143, 29)
        Label3.TabIndex = 5
        Label3.Text = "Precio Individual"
        ' 
        ' txtUnidades
        ' 
        txtUnidades.Location = New Point(55, 185)
        txtUnidades.MaxLength = 32000
        txtUnidades.Name = "txtUnidades"
        txtUnidades.PlaceholderText = "$"
        txtUnidades.Size = New Size(100, 23)
        txtUnidades.TabIndex = 6
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.FlatStyle = FlatStyle.System
        Label2.Font = New Font("Myanmar Text", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(50, 153)
        Label2.Name = "Label2"
        Label2.Size = New Size(122, 29)
        Label2.TabIndex = 7
        Label2.Text = "Total a vender"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(txtTotalPagar)
        GroupBox1.Controls.Add(txtDescuento)
        GroupBox1.Controls.Add(txtPrecioOG)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Location = New Point(26, 260)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(385, 167)
        GroupBox1.TabIndex = 8
        GroupBox1.TabStop = False
        GroupBox1.Text = "Resultados"
        ' 
        ' txtTotalPagar
        ' 
        txtTotalPagar.Location = New Point(279, 88)
        txtTotalPagar.MaxLength = 32000
        txtTotalPagar.Name = "txtTotalPagar"
        txtTotalPagar.Size = New Size(100, 23)
        txtTotalPagar.TabIndex = 14
        txtTotalPagar.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtDescuento
        ' 
        txtDescuento.Location = New Point(279, 59)
        txtDescuento.MaxLength = 32000
        txtDescuento.Name = "txtDescuento"
        txtDescuento.Size = New Size(100, 23)
        txtDescuento.TabIndex = 13
        txtDescuento.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtPrecioOG
        ' 
        txtPrecioOG.Location = New Point(279, 30)
        txtPrecioOG.MaxLength = 32000
        txtPrecioOG.Name = "txtPrecioOG"
        txtPrecioOG.Size = New Size(100, 23)
        txtPrecioOG.TabIndex = 12
        txtPrecioOG.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.FlatStyle = FlatStyle.System
        Label6.Font = New Font("Myanmar Text", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(152, 86)
        Label6.Name = "Label6"
        Label6.Size = New Size(121, 29)
        Label6.TabIndex = 11
        Label6.Text = "Total, a pagar:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.FlatStyle = FlatStyle.System
        Label5.Font = New Font("Myanmar Text", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(103, 57)
        Label5.Name = "Label5"
        Label5.Size = New Size(170, 29)
        Label5.TabIndex = 10
        Label5.Text = "Descuento Aplicado:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.FlatStyle = FlatStyle.System
        Label4.Font = New Font("Myanmar Text", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(6, 28)
        Label4.Name = "Label4"
        Label4.Size = New Size(271, 29)
        Label4.TabIndex = 9
        Label4.Text = "Precio de producto sin descuento:"
        ' 
        ' btnCalcular
        ' 
        btnCalcular.Location = New Point(178, 232)
        btnCalcular.Margin = New Padding(3, 2, 3, 2)
        btnCalcular.Name = "btnCalcular"
        btnCalcular.Size = New Size(90, 23)
        btnCalcular.TabIndex = 11
        btnCalcular.Text = "Calcular"
        btnCalcular.UseVisualStyleBackColor = True
        ' 
        ' Enunciado5
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(449, 450)
        Controls.Add(btnCalcular)
        Controls.Add(GroupBox1)
        Controls.Add(txtUnidades)
        Controls.Add(Label2)
        Controls.Add(txtPrecio)
        Controls.Add(Label3)
        Controls.Add(gpbMetodos)
        Controls.Add(Label1)
        Name = "Enunciado5"
        Text = "z"
        gpbMetodos.ResumeLayout(False)
        gpbMetodos.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents gpbMetodos As GroupBox
    Friend WithEvents rdbTarjeta As RadioButton
    Friend WithEvents rdbCheque As RadioButton
    Friend WithEvents rdbEfectivo As RadioButton
    Friend WithEvents rdbClave As RadioButton
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtUnidades As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtTotalPagar As TextBox
    Friend WithEvents txtDescuento As TextBox
    Friend WithEvents txtPrecioOG As TextBox
    Friend WithEvents btnCalcular As Button
End Class
