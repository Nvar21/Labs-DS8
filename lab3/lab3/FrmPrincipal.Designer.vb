﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPrincipal
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.tlsInicio = New System.Windows.Forms.ToolStripLabel()
        Me.tslRegistrarCliente = New System.Windows.Forms.ToolStripLabel()
        Me.tslCrearCuenta = New System.Windows.Forms.ToolStripLabel()
        Me.tslTransacciones = New System.Windows.Forms.ToolStripLabel()
        Me.tslVerMovimientos = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.CadetBlue
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Left
        Me.ToolStrip1.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator4, Me.tlsInicio, Me.ToolStripSeparator6, Me.tslRegistrarCliente, Me.ToolStripSeparator1, Me.tslCrearCuenta, Me.ToolStripSeparator2, Me.tslTransacciones, Me.ToolStripSeparator3, Me.tslVerMovimientos, Me.ToolStripSeparator5})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(197, 556)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.AutoSize = False
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(195, 6)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.AutoSize = False
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(195, 6)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.AutoSize = False
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(195, 6)
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.AutoSize = False
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(194, 6)
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.AutoSize = False
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(195, 6)
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.AutoSize = False
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(195, 6)
        '
        'tlsInicio
        '
        Me.tlsInicio.Image = Global.lab3.My.Resources.Resources._0
        Me.tlsInicio.Name = "tlsInicio"
        Me.tlsInicio.Size = New System.Drawing.Size(195, 54)
        Me.tlsInicio.Text = "Inicio"
        Me.tlsInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tslRegistrarCliente
        '
        Me.tslRegistrarCliente.Image = Global.lab3.My.Resources.Resources._1
        Me.tslRegistrarCliente.Name = "tslRegistrarCliente"
        Me.tslRegistrarCliente.Size = New System.Drawing.Size(195, 54)
        Me.tslRegistrarCliente.Text = "Registrar Cliente"
        Me.tslRegistrarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tslCrearCuenta
        '
        Me.tslCrearCuenta.Image = Global.lab3.My.Resources.Resources._2
        Me.tslCrearCuenta.Name = "tslCrearCuenta"
        Me.tslCrearCuenta.Size = New System.Drawing.Size(195, 54)
        Me.tslCrearCuenta.Text = "Crear Cuenta"
        Me.tslCrearCuenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tslTransacciones
        '
        Me.tslTransacciones.Image = Global.lab3.My.Resources.Resources._3
        Me.tslTransacciones.Name = "tslTransacciones"
        Me.tslTransacciones.Size = New System.Drawing.Size(195, 54)
        Me.tslTransacciones.Text = "Realizar Transacción"
        Me.tslTransacciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tslVerMovimientos
        '
        Me.tslVerMovimientos.Image = Global.lab3.My.Resources.Resources._4
        Me.tslVerMovimientos.Name = "tslVerMovimientos"
        Me.tslVerMovimientos.Size = New System.Drawing.Size(195, 54)
        Me.tslVerMovimientos.Text = "Ver Movimientos"
        Me.tslVerMovimientos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(871, 556)
        Me.Controls.Add(Me.ToolStrip1)
        Me.IsMdiContainer = True
        Me.Name = "FrmPrincipal"
        Me.Text = "Inicio"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tslRegistrarCliente As ToolStripLabel
    Friend WithEvents tslCrearCuenta As ToolStripLabel
    Friend WithEvents tslTransacciones As ToolStripLabel
    Friend WithEvents tslVerMovimientos As ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents tlsInicio As ToolStripLabel
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
End Class
