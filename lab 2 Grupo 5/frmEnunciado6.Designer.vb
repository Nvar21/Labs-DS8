<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEnunciado6
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
        pnlTitulo = New Panel()
        lblTitulo = New Label()
        pnlRegistros = New Panel()
        Label5 = New Label()
        lblNombreC4 = New Label()
        lblNombreC2 = New Label()
        txtVotosCand3 = New TextBox()
        txtVotosCand1 = New TextBox()
        lblNombreC3 = New Label()
        txtVotosCand2 = New TextBox()
        Label10 = New Label()
        lblNombreC1 = New Label()
        txtVotosCand0 = New TextBox()
        Label12 = New Label()
        lblAlerta = New Label()
        Label1 = New Label()
        Label4 = New Label()
        txtCand3 = New TextBox()
        txtCand1 = New TextBox()
        Label6 = New Label()
        txtCand2 = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        txtCand0 = New TextBox()
        btnObtener = New Button()
        lblIndicador = New Label()
        txtGanador = New TextBox()
        Label7 = New Label()
        Label8 = New Label()
        txtMenor = New TextBox()
        pnlTitulo.SuspendLayout()
        pnlRegistros.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlTitulo
        ' 
        pnlTitulo.Controls.Add(lblTitulo)
        pnlTitulo.Dock = DockStyle.Top
        pnlTitulo.Location = New Point(0, 0)
        pnlTitulo.Name = "pnlTitulo"
        pnlTitulo.Size = New Size(903, 47)
        pnlTitulo.TabIndex = 30
        ' 
        ' lblTitulo
        ' 
        lblTitulo.AutoSize = True
        lblTitulo.FlatStyle = FlatStyle.System
        lblTitulo.Font = New Font("Myanmar Text", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblTitulo.Location = New Point(14, 10)
        lblTitulo.Name = "lblTitulo"
        lblTitulo.Size = New Size(334, 34)
        lblTitulo.TabIndex = 0
        lblTitulo.Text = "Enunciado 6: Informe de votaciones"
        ' 
        ' pnlRegistros
        ' 
        pnlRegistros.Controls.Add(Label5)
        pnlRegistros.Controls.Add(lblNombreC4)
        pnlRegistros.Controls.Add(lblNombreC2)
        pnlRegistros.Controls.Add(txtVotosCand3)
        pnlRegistros.Controls.Add(txtVotosCand1)
        pnlRegistros.Controls.Add(lblNombreC3)
        pnlRegistros.Controls.Add(txtVotosCand2)
        pnlRegistros.Controls.Add(Label10)
        pnlRegistros.Controls.Add(lblNombreC1)
        pnlRegistros.Controls.Add(txtVotosCand0)
        pnlRegistros.Controls.Add(Label12)
        pnlRegistros.Controls.Add(lblAlerta)
        pnlRegistros.Controls.Add(Label1)
        pnlRegistros.Controls.Add(Label4)
        pnlRegistros.Controls.Add(txtCand3)
        pnlRegistros.Controls.Add(txtCand1)
        pnlRegistros.Controls.Add(Label6)
        pnlRegistros.Controls.Add(txtCand2)
        pnlRegistros.Controls.Add(Label2)
        pnlRegistros.Controls.Add(Label3)
        pnlRegistros.Controls.Add(txtCand0)
        pnlRegistros.Controls.Add(btnObtener)
        pnlRegistros.Controls.Add(lblIndicador)
        pnlRegistros.Dock = DockStyle.Top
        pnlRegistros.Location = New Point(0, 47)
        pnlRegistros.Name = "pnlRegistros"
        pnlRegistros.Size = New Size(903, 238)
        pnlRegistros.TabIndex = 31
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label5.AutoSize = True
        Label5.FlatStyle = FlatStyle.System
        Label5.Font = New Font("Myanmar Text", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(469, 196)
        Label5.Name = "Label5"
        Label5.Size = New Size(0, 29)
        Label5.TabIndex = 54
        ' 
        ' lblNombreC4
        ' 
        lblNombreC4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        lblNombreC4.AutoSize = True
        lblNombreC4.FlatStyle = FlatStyle.System
        lblNombreC4.Font = New Font("Myanmar Text", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblNombreC4.Location = New Point(451, 134)
        lblNombreC4.Name = "lblNombreC4"
        lblNombreC4.Size = New Size(105, 29)
        lblNombreC4.TabIndex = 53
        lblNombreC4.Text = "Candidato 4"
        ' 
        ' lblNombreC2
        ' 
        lblNombreC2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        lblNombreC2.AutoSize = True
        lblNombreC2.FlatStyle = FlatStyle.System
        lblNombreC2.Font = New Font("Myanmar Text", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblNombreC2.Location = New Point(451, 76)
        lblNombreC2.Name = "lblNombreC2"
        lblNombreC2.Size = New Size(105, 29)
        lblNombreC2.TabIndex = 49
        lblNombreC2.Text = "Candidato 2"
        ' 
        ' txtVotosCand3
        ' 
        txtVotosCand3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        txtVotosCand3.Location = New Point(577, 134)
        txtVotosCand3.MaxLength = 20
        txtVotosCand3.Name = "txtVotosCand3"
        txtVotosCand3.ReadOnly = True
        txtVotosCand3.Size = New Size(199, 23)
        txtVotosCand3.TabIndex = 52
        txtVotosCand3.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtVotosCand1
        ' 
        txtVotosCand1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        txtVotosCand1.Location = New Point(577, 76)
        txtVotosCand1.MaxLength = 20
        txtVotosCand1.Name = "txtVotosCand1"
        txtVotosCand1.ReadOnly = True
        txtVotosCand1.Size = New Size(199, 23)
        txtVotosCand1.TabIndex = 48
        txtVotosCand1.TextAlign = HorizontalAlignment.Center
        ' 
        ' lblNombreC3
        ' 
        lblNombreC3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        lblNombreC3.AutoSize = True
        lblNombreC3.FlatStyle = FlatStyle.System
        lblNombreC3.Font = New Font("Myanmar Text", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblNombreC3.Location = New Point(451, 105)
        lblNombreC3.Name = "lblNombreC3"
        lblNombreC3.Size = New Size(105, 29)
        lblNombreC3.TabIndex = 51
        lblNombreC3.Text = "Candidato 3"
        ' 
        ' txtVotosCand2
        ' 
        txtVotosCand2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        txtVotosCand2.Location = New Point(577, 105)
        txtVotosCand2.MaxLength = 20
        txtVotosCand2.Name = "txtVotosCand2"
        txtVotosCand2.ReadOnly = True
        txtVotosCand2.Size = New Size(199, 23)
        txtVotosCand2.TabIndex = 50
        txtVotosCand2.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.FlatStyle = FlatStyle.System
        Label10.Font = New Font("Myanmar Text", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.Location = New Point(557, 15)
        Label10.Name = "Label10"
        Label10.Size = New Size(236, 29)
        Label10.TabIndex = 47
        Label10.Text = "Total de Votos de Candidatos"
        ' 
        ' lblNombreC1
        ' 
        lblNombreC1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        lblNombreC1.AutoSize = True
        lblNombreC1.FlatStyle = FlatStyle.System
        lblNombreC1.Font = New Font("Myanmar Text", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblNombreC1.Location = New Point(451, 47)
        lblNombreC1.Name = "lblNombreC1"
        lblNombreC1.Size = New Size(105, 29)
        lblNombreC1.TabIndex = 46
        lblNombreC1.Text = "Candidato 1"
        ' 
        ' txtVotosCand0
        ' 
        txtVotosCand0.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        txtVotosCand0.Location = New Point(577, 47)
        txtVotosCand0.MaxLength = 20
        txtVotosCand0.Name = "txtVotosCand0"
        txtVotosCand0.ReadOnly = True
        txtVotosCand0.Size = New Size(199, 23)
        txtVotosCand0.TabIndex = 45
        txtVotosCand0.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label12
        ' 
        Label12.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label12.AutoSize = True
        Label12.BackColor = Color.Transparent
        Label12.Font = New Font("Myanmar Text", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label12.ForeColor = Color.Transparent
        Label12.Location = New Point(770, 47)
        Label12.Name = "Label12"
        Label12.Padding = New Padding(3)
        Label12.Size = New Size(6, 35)
        Label12.TabIndex = 43
        Label12.TextAlign = ContentAlignment.MiddleCenter
        Label12.Visible = False
        ' 
        ' lblAlerta
        ' 
        lblAlerta.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        lblAlerta.AutoSize = True
        lblAlerta.FlatStyle = FlatStyle.System
        lblAlerta.Font = New Font("Myanmar Text", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblAlerta.Location = New Point(78, 164)
        lblAlerta.Name = "lblAlerta"
        lblAlerta.Size = New Size(0, 29)
        lblAlerta.TabIndex = 42
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label1.AutoSize = True
        Label1.FlatStyle = FlatStyle.System
        Label1.Font = New Font("Myanmar Text", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(22, 135)
        Label1.Name = "Label1"
        Label1.Size = New Size(109, 29)
        Label1.TabIndex = 41
        Label1.Text = "Candidato 4:"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label4.AutoSize = True
        Label4.FlatStyle = FlatStyle.System
        Label4.Font = New Font("Myanmar Text", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(22, 77)
        Label4.Name = "Label4"
        Label4.Size = New Size(109, 29)
        Label4.TabIndex = 37
        Label4.Text = "Candidato 2:"
        ' 
        ' txtCand3
        ' 
        txtCand3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        txtCand3.Location = New Point(137, 135)
        txtCand3.MaxLength = 20
        txtCand3.Name = "txtCand3"
        txtCand3.Size = New Size(199, 23)
        txtCand3.TabIndex = 40
        txtCand3.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtCand1
        ' 
        txtCand1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        txtCand1.Location = New Point(137, 77)
        txtCand1.MaxLength = 20
        txtCand1.Name = "txtCand1"
        txtCand1.Size = New Size(199, 23)
        txtCand1.TabIndex = 36
        txtCand1.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label6.AutoSize = True
        Label6.FlatStyle = FlatStyle.System
        Label6.Font = New Font("Myanmar Text", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(22, 106)
        Label6.Name = "Label6"
        Label6.Size = New Size(109, 29)
        Label6.TabIndex = 39
        Label6.Text = "Candidato 3:"
        ' 
        ' txtCand2
        ' 
        txtCand2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        txtCand2.Location = New Point(137, 106)
        txtCand2.MaxLength = 20
        txtCand2.Name = "txtCand2"
        txtCand2.Size = New Size(199, 23)
        txtCand2.TabIndex = 38
        txtCand2.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.FlatStyle = FlatStyle.System
        Label2.Font = New Font("Myanmar Text", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(14, 15)
        Label2.Name = "Label2"
        Label2.Size = New Size(196, 29)
        Label2.TabIndex = 35
        Label2.Text = "Nombres de Candidatos"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label3.AutoSize = True
        Label3.FlatStyle = FlatStyle.System
        Label3.Font = New Font("Myanmar Text", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(22, 48)
        Label3.Name = "Label3"
        Label3.Size = New Size(109, 29)
        Label3.TabIndex = 33
        Label3.Text = "Candidato 1:"
        ' 
        ' txtCand0
        ' 
        txtCand0.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        txtCand0.Location = New Point(137, 48)
        txtCand0.MaxLength = 20
        txtCand0.Name = "txtCand0"
        txtCand0.Size = New Size(199, 23)
        txtCand0.TabIndex = 32
        txtCand0.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnObtener
        ' 
        btnObtener.BackColor = Color.Teal
        btnObtener.Dock = DockStyle.Bottom
        btnObtener.Enabled = False
        btnObtener.FlatAppearance.BorderSize = 0
        btnObtener.FlatStyle = FlatStyle.Flat
        btnObtener.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        btnObtener.ForeColor = Color.White
        btnObtener.Location = New Point(0, 208)
        btnObtener.Name = "btnObtener"
        btnObtener.Size = New Size(903, 30)
        btnObtener.TabIndex = 30
        btnObtener.Text = "Obtener Resultados"
        btnObtener.UseVisualStyleBackColor = False
        ' 
        ' lblIndicador
        ' 
        lblIndicador.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        lblIndicador.AutoSize = True
        lblIndicador.BackColor = Color.Transparent
        lblIndicador.Font = New Font("Myanmar Text", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblIndicador.ForeColor = Color.Transparent
        lblIndicador.Location = New Point(330, 48)
        lblIndicador.Name = "lblIndicador"
        lblIndicador.Padding = New Padding(3)
        lblIndicador.Size = New Size(6, 35)
        lblIndicador.TabIndex = 29
        lblIndicador.TextAlign = ContentAlignment.MiddleCenter
        lblIndicador.Visible = False
        ' 
        ' txtGanador
        ' 
        txtGanador.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        txtGanador.Location = New Point(347, 315)
        txtGanador.MaxLength = 20
        txtGanador.Name = "txtGanador"
        txtGanador.ReadOnly = True
        txtGanador.Size = New Size(409, 23)
        txtGanador.TabIndex = 55
        txtGanador.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.FlatStyle = FlatStyle.System
        Label7.Font = New Font("Myanmar Text", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(121, 311)
        Label7.Name = "Label7"
        Label7.Size = New Size(218, 29)
        Label7.TabIndex = 55
        Label7.Text = "Ganador de las elecciones: "
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.FlatStyle = FlatStyle.System
        Label8.Font = New Font("Myanmar Text", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(222, 377)
        Label8.Name = "Label8"
        Label8.Size = New Size(117, 29)
        Label8.TabIndex = 56
        Label8.Text = "Último Lugar:"
        ' 
        ' txtMenor
        ' 
        txtMenor.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        txtMenor.Location = New Point(347, 379)
        txtMenor.MaxLength = 20
        txtMenor.Name = "txtMenor"
        txtMenor.ReadOnly = True
        txtMenor.Size = New Size(409, 23)
        txtMenor.TabIndex = 57
        txtMenor.TextAlign = HorizontalAlignment.Center
        ' 
        ' frmEnunciado6
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(903, 456)
        Controls.Add(Label8)
        Controls.Add(txtMenor)
        Controls.Add(Label7)
        Controls.Add(txtGanador)
        Controls.Add(pnlRegistros)
        Controls.Add(pnlTitulo)
        Margin = New Padding(2)
        Name = "frmEnunciado6"
        Text = "frmEnunciado6"
        pnlTitulo.ResumeLayout(False)
        pnlTitulo.PerformLayout()
        pnlRegistros.ResumeLayout(False)
        pnlRegistros.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents pnlTitulo As Panel
    Friend WithEvents lblTitulo As Label
    Friend WithEvents pnlRegistros As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCand3 As TextBox
    Friend WithEvents txtCand1 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCand2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCand0 As TextBox
    Friend WithEvents btnObtener As Button
    Friend WithEvents lblIndicador As Label
    Friend WithEvents lblAlerta As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblNombreC4 As Label
    Friend WithEvents lblNombreC2 As Label
    Friend WithEvents txtVotosCand3 As TextBox
    Friend WithEvents txtVotosCand1 As TextBox
    Friend WithEvents lblNombreC3 As Label
    Friend WithEvents txtVotosCand2 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents lblNombreC1 As Label
    Friend WithEvents txtVotosCand0 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents lstVotos As TextBox
    Friend WithEvents txtGanador As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtMenor As TextBox
End Class
