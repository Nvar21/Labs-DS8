﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEnunciado4
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
        txtYear = New TextBox()
        btnCalcular = New Button()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(145, 163)
        Label1.Name = "Label1"
        Label1.Size = New Size(487, 32)
        Label1.TabIndex = 0
        Label1.Text = "Enunciado 4 - Calcular la fecha de pascua"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(218, 253)
        Label2.Name = "Label2"
        Label2.Size = New Size(166, 32)
        Label2.TabIndex = 1
        Label2.Text = "Ingresar año:"
        ' 
        ' txtYear
        ' 
        txtYear.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        txtYear.Location = New Point(408, 245)
        txtYear.Name = "txtYear"
        txtYear.Size = New Size(150, 45)
        txtYear.TabIndex = 2
        ' 
        ' btnCalcular
        ' 
        btnCalcular.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnCalcular.Location = New Point(329, 325)
        btnCalcular.Name = "btnCalcular"
        btnCalcular.Size = New Size(140, 43)
        btnCalcular.TabIndex = 3
        btnCalcular.Text = "Calcular"
        btnCalcular.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(611, 375)
        Label3.Name = "Label3"
        Label3.Size = New Size(0, 25)
        Label3.TabIndex = 4
        ' 
        ' frmEnunciado4
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1320, 1050)
        Controls.Add(Label3)
        Controls.Add(btnCalcular)
        Controls.Add(txtYear)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "frmEnunciado4"
        Text = "frmEnunciado4"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtYear As TextBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents Label3 As Label
End Class
