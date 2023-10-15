<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Panel2 = New Panel()
        btnSalir = New Label()
        lblNombreForm = New Label()
        MenuStrip1 = New MenuStrip()
        smiEnun1 = New ToolStripMenuItem()
        smiEnun2 = New ToolStripMenuItem()
        smiEnun3 = New ToolStripMenuItem()
        smiEnun4 = New ToolStripMenuItem()
        smiEnun5 = New ToolStripMenuItem()
        smiEnun6 = New ToolStripMenuItem()
        Panel1 = New Panel()
        Panel3 = New Panel()
        Panel2.SuspendLayout()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.AccessibleRole = AccessibleRole.TitleBar
        Panel2.BackColor = Color.FromArgb(CByte(4), CByte(54), CByte(74))
        Panel2.BackgroundImageLayout = ImageLayout.None
        Panel2.Controls.Add(btnSalir)
        Panel2.Controls.Add(lblNombreForm)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1054, 77)
        Panel2.TabIndex = 2
        ' 
        ' btnSalir
        ' 
        btnSalir.AutoSize = True
        btnSalir.Cursor = Cursors.Hand
        btnSalir.Dock = DockStyle.Right
        btnSalir.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point)
        btnSalir.ForeColor = Color.White
        btnSalir.Location = New Point(1024, 0)
        btnSalir.Margin = New Padding(0)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(30, 29)
        btnSalir.TabIndex = 3
        btnSalir.Text = "X"
        btnSalir.TextAlign = ContentAlignment.TopCenter
        ' 
        ' lblNombreForm
        ' 
        lblNombreForm.Anchor = AnchorStyles.None
        lblNombreForm.AutoSize = True
        lblNombreForm.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        lblNombreForm.ForeColor = Color.White
        lblNombreForm.Location = New Point(74, 27)
        lblNombreForm.Name = "lblNombreForm"
        lblNombreForm.Size = New Size(230, 25)
        lblNombreForm.TabIndex = 0
        lblNombreForm.Text = "Inicio - Laboratorio 2"
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.FromArgb(CByte(23), CByte(107), CByte(135))
        MenuStrip1.BackgroundImageLayout = ImageLayout.None
        MenuStrip1.Dock = DockStyle.Left
        MenuStrip1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        MenuStrip1.GripMargin = New Padding(2)
        MenuStrip1.ImageScalingSize = New Size(24, 24)
        MenuStrip1.Items.AddRange(New ToolStripItem() {smiEnun1, smiEnun2, smiEnun3, smiEnun4, smiEnun5, smiEnun6})
        MenuStrip1.Location = New Point(0, 77)
        MenuStrip1.Margin = New Padding(0, 20, 0, 20)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(179, 523)
        MenuStrip1.TabIndex = 3
        MenuStrip1.Text = "Menu"
        ' 
        ' smiEnun1
        ' 
        smiEnun1.ForeColor = Color.White
        smiEnun1.Margin = New Padding(0, 75, 0, 5)
        smiEnun1.Name = "smiEnun1"
        smiEnun1.Padding = New Padding(4, 20, 0, 0)
        smiEnun1.Size = New Size(166, 44)
        smiEnun1.Text = "Enunciado 1"
        ' 
        ' smiEnun2
        ' 
        smiEnun2.ForeColor = Color.White
        smiEnun2.Margin = New Padding(0, 5, 0, 7)
        smiEnun2.Name = "smiEnun2"
        smiEnun2.Padding = New Padding(10, 20, 50, 0)
        smiEnun2.Size = New Size(166, 44)
        smiEnun2.Text = "Enunciado 2"
        ' 
        ' smiEnun3
        ' 
        smiEnun3.ForeColor = Color.White
        smiEnun3.Margin = New Padding(0, 5, 0, 7)
        smiEnun3.Name = "smiEnun3"
        smiEnun3.Padding = New Padding(10, 20, 50, 0)
        smiEnun3.Size = New Size(166, 44)
        smiEnun3.Text = "Enunciado 3"
        ' 
        ' smiEnun4
        ' 
        smiEnun4.ForeColor = Color.White
        smiEnun4.Margin = New Padding(0, 5, 0, 7)
        smiEnun4.Name = "smiEnun4"
        smiEnun4.Padding = New Padding(10, 20, 50, 0)
        smiEnun4.Size = New Size(166, 44)
        smiEnun4.Text = "Enunciado 4"
        ' 
        ' smiEnun5
        ' 
        smiEnun5.ForeColor = Color.White
        smiEnun5.Margin = New Padding(0, 5, 0, 7)
        smiEnun5.Name = "smiEnun5"
        smiEnun5.Padding = New Padding(10, 20, 50, 0)
        smiEnun5.Size = New Size(166, 44)
        smiEnun5.Text = "Enunciado 5"
        ' 
        ' smiEnun6
        ' 
        smiEnun6.ForeColor = Color.White
        smiEnun6.Margin = New Padding(0, 5, 0, 7)
        smiEnun6.Name = "smiEnun6"
        smiEnun6.Padding = New Padding(10, 20, 50, 0)
        smiEnun6.Size = New Size(166, 44)
        smiEnun6.Text = "Enunciado 6"
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Panel1.BackColor = Color.FromArgb(CByte(23), CByte(107), CByte(135))
        Panel1.Location = New Point(0, 542)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(155, 58)
        Panel1.TabIndex = 5
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(23), CByte(107), CByte(135))
        Panel3.Location = New Point(0, 77)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(155, 36)
        Panel3.TabIndex = 6
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(218), CByte(255), CByte(251))
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1054, 600)
        Controls.Add(Panel1)
        Controls.Add(Panel3)
        Controls.Add(MenuStrip1)
        Controls.Add(Panel2)
        MainMenuStrip = MenuStrip1
        MaximizeBox = False
        MdiChildrenMinimizedAnchorBottom = False
        MinimizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.Manual
        Text = "Laboratorio 2 - Arevalo, Muñoz, Vargas"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblNombreForm As Label
    Friend WithEvents btnSalir As Label
    Friend WithEvents smiEnun1 As ToolStripMenuItem
    Friend WithEvents smiEnun2 As ToolStripMenuItem
    Friend WithEvents smiEnun3 As ToolStripMenuItem
    Friend WithEvents smiEnun4 As ToolStripMenuItem
    Friend WithEvents smiEnun5 As ToolStripMenuItem
    Friend WithEvents smiEnun6 As ToolStripMenuItem
    Public WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
End Class
