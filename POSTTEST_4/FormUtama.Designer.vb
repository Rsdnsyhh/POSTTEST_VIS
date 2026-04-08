<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormUtama
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        MenuStrip1 = New MenuStrip()
        InputDataToolStripMenuItem = New ToolStripMenuItem()
        LihatKartuToolStripMenuItem = New ToolStripMenuItem()
        SimpanDataToolStripMenuItem = New ToolStripMenuItem()
        BukaDataToolStripMenuItem = New ToolStripMenuItem()
        KeluarToolStripMenuItem = New ToolStripMenuItem()
        lblAplikasiKartu = New Label()
        pbWelcomeBG = New PictureBox()
        OpenFileDialog1 = New OpenFileDialog()
        pbLogoWS = New PictureBox()
        MenuStrip1.SuspendLayout()
        CType(pbWelcomeBG, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbLogoWS, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Dock = DockStyle.Left
        MenuStrip1.Font = New Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {InputDataToolStripMenuItem, LihatKartuToolStripMenuItem, SimpanDataToolStripMenuItem, BukaDataToolStripMenuItem, KeluarToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.RenderMode = ToolStripRenderMode.Professional
        MenuStrip1.Size = New Size(114, 394)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' InputDataToolStripMenuItem
        ' 
        InputDataToolStripMenuItem.Name = "InputDataToolStripMenuItem"
        InputDataToolStripMenuItem.Size = New Size(101, 23)
        InputDataToolStripMenuItem.Text = "Input Data"
        ' 
        ' LihatKartuToolStripMenuItem
        ' 
        LihatKartuToolStripMenuItem.Name = "LihatKartuToolStripMenuItem"
        LihatKartuToolStripMenuItem.Size = New Size(101, 23)
        LihatKartuToolStripMenuItem.Text = "Lihat  Kartu"
        ' 
        ' SimpanDataToolStripMenuItem
        ' 
        SimpanDataToolStripMenuItem.Name = "SimpanDataToolStripMenuItem"
        SimpanDataToolStripMenuItem.Size = New Size(101, 23)
        SimpanDataToolStripMenuItem.Text = "Simpan Data"
        ' 
        ' BukaDataToolStripMenuItem
        ' 
        BukaDataToolStripMenuItem.Name = "BukaDataToolStripMenuItem"
        BukaDataToolStripMenuItem.Size = New Size(101, 23)
        BukaDataToolStripMenuItem.Text = "Buka Data"
        ' 
        ' KeluarToolStripMenuItem
        ' 
        KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        KeluarToolStripMenuItem.Size = New Size(101, 23)
        KeluarToolStripMenuItem.Text = "Keluar"
        ' 
        ' lblAplikasiKartu
        ' 
        lblAplikasiKartu.AutoSize = True
        lblAplikasiKartu.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        lblAplikasiKartu.Font = New Font("Times New Roman", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblAplikasiKartu.ForeColor = Color.White
        lblAplikasiKartu.Location = New Point(281, 19)
        lblAplikasiKartu.Name = "lblAplikasiKartu"
        lblAplikasiKartu.Size = New Size(340, 34)
        lblAplikasiKartu.TabIndex = 1
        lblAplikasiKartu.Text = "Aplikasi Kartu Komunitas"
        ' 
        ' pbWelcomeBG
        ' 
        pbWelcomeBG.Image = My.Resources.Resources.bomb_cat_bg
        pbWelcomeBG.Location = New Point(117, 0)
        pbWelcomeBG.Name = "pbWelcomeBG"
        pbWelcomeBG.Size = New Size(650, 394)
        pbWelcomeBG.SizeMode = PictureBoxSizeMode.StretchImage
        pbWelcomeBG.TabIndex = 2
        pbWelcomeBG.TabStop = False
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' pbLogoWS
        ' 
        pbLogoWS.BackColor = Color.Transparent
        pbLogoWS.BackgroundImageLayout = ImageLayout.Stretch
        pbLogoWS.Image = My.Resources.Resources.logo
        pbLogoWS.Location = New Point(117, 0)
        pbLogoWS.Name = "pbLogoWS"
        pbLogoWS.Size = New Size(89, 84)
        pbLogoWS.SizeMode = PictureBoxSizeMode.StretchImage
        pbLogoWS.TabIndex = 3
        pbLogoWS.TabStop = False
        ' 
        ' FormUtama
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(766, 394)
        Controls.Add(pbLogoWS)
        Controls.Add(lblAplikasiKartu)
        Controls.Add(MenuStrip1)
        Controls.Add(pbWelcomeBG)
        MainMenuStrip = MenuStrip1
        Name = "FormUtama"
        Text = "FormUtama"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(pbWelcomeBG, ComponentModel.ISupportInitialize).EndInit()
        CType(pbLogoWS, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InputDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LihatKartuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SimpanDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BukaDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblAplikasiKartu As Label
    Friend WithEvents pbWelcomeBG As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents pbLogoWS As PictureBox

End Class
