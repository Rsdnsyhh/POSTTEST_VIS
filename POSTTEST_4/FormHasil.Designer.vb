<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormHasil
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        pbProfilHasil = New PictureBox()
        lblNamaHasil = New Label()
        panelHasil = New Panel()
        pbLogoHasil = New PictureBox()
        lblKomunitasHasil = New Label()
        lblKontakHasil = New Label()
        lblIdHasil = New Label()
        lblHobiAktivitasHasil = New Label()
        CType(pbProfilHasil, ComponentModel.ISupportInitialize).BeginInit()
        panelHasil.SuspendLayout()
        CType(pbLogoHasil, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pbProfilHasil
        ' 
        pbProfilHasil.BackColor = Color.Transparent
        pbProfilHasil.Location = New Point(116, 76)
        pbProfilHasil.Name = "pbProfilHasil"
        pbProfilHasil.Size = New Size(202, 205)
        pbProfilHasil.SizeMode = PictureBoxSizeMode.StretchImage
        pbProfilHasil.TabIndex = 0
        pbProfilHasil.TabStop = False
        ' 
        ' lblNamaHasil
        ' 
        lblNamaHasil.BackColor = Color.Transparent
        lblNamaHasil.Font = New Font("Comic Sans MS", 10.8F, FontStyle.Bold)
        lblNamaHasil.Location = New Point(515, 87)
        lblNamaHasil.Name = "lblNamaHasil"
        lblNamaHasil.Size = New Size(272, 30)
        lblNamaHasil.TabIndex = 2
        lblNamaHasil.Text = "-"
        ' 
        ' panelHasil
        ' 
        panelHasil.BackgroundImage = My.Resources.Resources.FIX_ID_CARD
        panelHasil.BackgroundImageLayout = ImageLayout.Stretch
        panelHasil.Controls.Add(pbLogoHasil)
        panelHasil.Controls.Add(lblKomunitasHasil)
        panelHasil.Controls.Add(pbProfilHasil)
        panelHasil.Controls.Add(lblKontakHasil)
        panelHasil.Controls.Add(lblNamaHasil)
        panelHasil.Controls.Add(lblIdHasil)
        panelHasil.Controls.Add(lblHobiAktivitasHasil)
        panelHasil.Location = New Point(0, 1)
        panelHasil.Name = "panelHasil"
        panelHasil.Size = New Size(831, 432)
        panelHasil.TabIndex = 6
        ' 
        ' pbLogoHasil
        ' 
        pbLogoHasil.BackColor = Color.Transparent
        pbLogoHasil.Image = My.Resources.Resources.logo
        pbLogoHasil.Location = New Point(0, 0)
        pbLogoHasil.Name = "pbLogoHasil"
        pbLogoHasil.Size = New Size(76, 68)
        pbLogoHasil.SizeMode = PictureBoxSizeMode.StretchImage
        pbLogoHasil.TabIndex = 6
        pbLogoHasil.TabStop = False
        ' 
        ' lblKomunitasHasil
        ' 
        lblKomunitasHasil.BackColor = Color.Transparent
        lblKomunitasHasil.Font = New Font("Comic Sans MS", 10.8F, FontStyle.Bold)
        lblKomunitasHasil.Location = New Point(515, 211)
        lblKomunitasHasil.Name = "lblKomunitasHasil"
        lblKomunitasHasil.Size = New Size(272, 29)
        lblKomunitasHasil.TabIndex = 4
        lblKomunitasHasil.Text = "-"
        ' 
        ' lblKontakHasil
        ' 
        lblKontakHasil.BackColor = Color.Transparent
        lblKontakHasil.Font = New Font("Comic Sans MS", 10.8F, FontStyle.Bold)
        lblKontakHasil.Location = New Point(515, 269)
        lblKontakHasil.Name = "lblKontakHasil"
        lblKontakHasil.Size = New Size(272, 27)
        lblKontakHasil.TabIndex = 1
        lblKontakHasil.Text = "-"
        ' 
        ' lblIdHasil
        ' 
        lblIdHasil.BackColor = Color.Transparent
        lblIdHasil.Font = New Font("Comic Sans MS", 10.8F, FontStyle.Bold)
        lblIdHasil.Location = New Point(515, 144)
        lblIdHasil.Name = "lblIdHasil"
        lblIdHasil.Size = New Size(272, 31)
        lblIdHasil.TabIndex = 3
        lblIdHasil.Text = "-"
        ' 
        ' lblHobiAktivitasHasil
        ' 
        lblHobiAktivitasHasil.BackColor = Color.Transparent
        lblHobiAktivitasHasil.Font = New Font("Comic Sans MS", 10.8F, FontStyle.Bold)
        lblHobiAktivitasHasil.Location = New Point(515, 331)
        lblHobiAktivitasHasil.Name = "lblHobiAktivitasHasil"
        lblHobiAktivitasHasil.Size = New Size(272, 30)
        lblHobiAktivitasHasil.TabIndex = 5
        lblHobiAktivitasHasil.Text = "-"
        ' 
        ' FormHasil
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(832, 435)
        Controls.Add(panelHasil)
        Name = "FormHasil"
        Text = "FormHasil"
        CType(pbProfilHasil, ComponentModel.ISupportInitialize).EndInit()
        panelHasil.ResumeLayout(False)
        CType(pbLogoHasil, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pbProfilHasil As PictureBox
    Friend WithEvents lblNamaHasil As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents panelHasil As Panel
    Friend WithEvents lblKomunitasHasil As Label
    Friend WithEvents lblKontakHasil As Label
    Friend WithEvents lblIdHasil As Label
    Friend WithEvents lblHobiAktivitasHasil As Label
    Friend WithEvents pbLogoHasil As PictureBox
End Class
