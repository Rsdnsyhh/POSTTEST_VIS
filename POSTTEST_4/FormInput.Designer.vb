<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInput
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
        TabControl1 = New TabControl()
        tpDataUtama = New TabPage()
        lblJenisKomunitas = New Label()
        lblJenisKelamin = New Label()
        lblTanggalLahir = New Label()
        lblId = New Label()
        lblNama = New Label()
        cbJenisKomunitas = New ComboBox()
        rbPerempuan = New RadioButton()
        rbLaki = New RadioButton()
        dtpTanggalLahir = New DateTimePicker()
        txtId = New TextBox()
        txtNama = New TextBox()
        tpKontakInfo = New TabPage()
        lblEmail = New Label()
        lblNoHp = New Label()
        lblAlamat = New Label()
        mtbNoHp = New MaskedTextBox()
        txtAlamat = New TextBox()
        txtEmail = New TextBox()
        tpProfilAktivitas = New TabPage()
        btnBrowse = New Button()
        cbProgramming = New CheckBox()
        cbTravelling = New CheckBox()
        cbDesain = New CheckBox()
        cbFotografi = New CheckBox()
        cbMembaca = New CheckBox()
        cbMusik = New CheckBox()
        cbGaming = New CheckBox()
        gbPeran = New GroupBox()
        rbAnggota = New RadioButton()
        rbAdmin = New RadioButton()
        rbKetua = New RadioButton()
        pbFotoProfil = New PictureBox()
        cbOlahraga = New CheckBox()
        btnSimpanCetak = New Button()
        OpenFileDialog1 = New OpenFileDialog()
        SaveFileDialog1 = New SaveFileDialog()
        TabControl1.SuspendLayout()
        tpDataUtama.SuspendLayout()
        tpKontakInfo.SuspendLayout()
        tpProfilAktivitas.SuspendLayout()
        gbPeran.SuspendLayout()
        CType(pbFotoProfil, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(tpDataUtama)
        TabControl1.Controls.Add(tpKontakInfo)
        TabControl1.Controls.Add(tpProfilAktivitas)
        TabControl1.Font = New Font("Times New Roman", 9F, FontStyle.Bold)
        TabControl1.Location = New Point(97, 32)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(571, 354)
        TabControl1.TabIndex = 4
        ' 
        ' tpDataUtama
        ' 
        tpDataUtama.BackgroundImage = My.Resources.Resources.Windows_XP
        tpDataUtama.Controls.Add(lblJenisKomunitas)
        tpDataUtama.Controls.Add(lblJenisKelamin)
        tpDataUtama.Controls.Add(lblTanggalLahir)
        tpDataUtama.Controls.Add(lblId)
        tpDataUtama.Controls.Add(lblNama)
        tpDataUtama.Controls.Add(cbJenisKomunitas)
        tpDataUtama.Controls.Add(rbPerempuan)
        tpDataUtama.Controls.Add(rbLaki)
        tpDataUtama.Controls.Add(dtpTanggalLahir)
        tpDataUtama.Controls.Add(txtId)
        tpDataUtama.Controls.Add(txtNama)
        tpDataUtama.Location = New Point(4, 26)
        tpDataUtama.Name = "tpDataUtama"
        tpDataUtama.Padding = New Padding(3)
        tpDataUtama.Size = New Size(563, 324)
        tpDataUtama.TabIndex = 0
        tpDataUtama.Text = "Data Utama"
        tpDataUtama.UseVisualStyleBackColor = True
        ' 
        ' lblJenisKomunitas
        ' 
        lblJenisKomunitas.AutoSize = True
        lblJenisKomunitas.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        lblJenisKomunitas.Font = New Font("Times New Roman", 9F, FontStyle.Bold)
        lblJenisKomunitas.ForeColor = Color.Black
        lblJenisKomunitas.Location = New Point(104, 251)
        lblJenisKomunitas.Name = "lblJenisKomunitas"
        lblJenisKomunitas.Size = New Size(118, 17)
        lblJenisKomunitas.TabIndex = 10
        lblJenisKomunitas.Text = "Jenis Komunitas"
        ' 
        ' lblJenisKelamin
        ' 
        lblJenisKelamin.AutoSize = True
        lblJenisKelamin.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        lblJenisKelamin.Font = New Font("Times New Roman", 9F, FontStyle.Bold)
        lblJenisKelamin.ForeColor = Color.Black
        lblJenisKelamin.Location = New Point(104, 201)
        lblJenisKelamin.Name = "lblJenisKelamin"
        lblJenisKelamin.Size = New Size(102, 17)
        lblJenisKelamin.TabIndex = 9
        lblJenisKelamin.Text = "Jenis Kelamin"
        ' 
        ' lblTanggalLahir
        ' 
        lblTanggalLahir.AutoSize = True
        lblTanggalLahir.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        lblTanggalLahir.Font = New Font("Times New Roman", 9F, FontStyle.Bold)
        lblTanggalLahir.ForeColor = Color.Black
        lblTanggalLahir.Location = New Point(104, 142)
        lblTanggalLahir.Name = "lblTanggalLahir"
        lblTanggalLahir.Size = New Size(98, 17)
        lblTanggalLahir.TabIndex = 8
        lblTanggalLahir.Text = "Tanggal Lahir"
        ' 
        ' lblId
        ' 
        lblId.AutoSize = True
        lblId.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        lblId.Font = New Font("Times New Roman", 9F, FontStyle.Bold)
        lblId.ForeColor = Color.Black
        lblId.Location = New Point(104, 89)
        lblId.Name = "lblId"
        lblId.Size = New Size(83, 17)
        lblId.TabIndex = 7
        lblId.Text = "ID Anggota"
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        lblNama.Font = New Font("Times New Roman", 9F, FontStyle.Bold)
        lblNama.ForeColor = Color.Black
        lblNama.Location = New Point(104, 36)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(45, 17)
        lblNama.TabIndex = 6
        lblNama.Text = "Nama"
        ' 
        ' cbJenisKomunitas
        ' 
        cbJenisKomunitas.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        cbJenisKomunitas.Font = New Font("Times New Roman", 10.2F, FontStyle.Bold)
        cbJenisKomunitas.FormattingEnabled = True
        cbJenisKomunitas.Items.AddRange(New Object() {"Klub Koding", "", "Pecinta Alam", "", "Tim Esports", "", "Klub Motor", "", "Fotografer", "", "Seni Musik", "", "Relawan Sosial"})
        cbJenisKomunitas.Location = New Point(239, 247)
        cbJenisKomunitas.Name = "cbJenisKomunitas"
        cbJenisKomunitas.Size = New Size(260, 27)
        cbJenisKomunitas.TabIndex = 5
        ' 
        ' rbPerempuan
        ' 
        rbPerempuan.AutoSize = True
        rbPerempuan.BackColor = Color.Transparent
        rbPerempuan.Font = New Font("Times New Roman", 10.2F, FontStyle.Bold)
        rbPerempuan.Location = New Point(363, 194)
        rbPerempuan.Name = "rbPerempuan"
        rbPerempuan.Size = New Size(114, 23)
        rbPerempuan.TabIndex = 4
        rbPerempuan.TabStop = True
        rbPerempuan.Text = "Perempuan"
        rbPerempuan.UseVisualStyleBackColor = False
        ' 
        ' rbLaki
        ' 
        rbLaki.AutoSize = True
        rbLaki.BackColor = Color.Transparent
        rbLaki.Font = New Font("Times New Roman", 10.2F, FontStyle.Bold)
        rbLaki.Location = New Point(239, 195)
        rbLaki.Name = "rbLaki"
        rbLaki.Size = New Size(104, 23)
        rbLaki.TabIndex = 3
        rbLaki.TabStop = True
        rbLaki.Text = "Laki-Laki"
        rbLaki.UseVisualStyleBackColor = False
        ' 
        ' dtpTanggalLahir
        ' 
        dtpTanggalLahir.CalendarMonthBackground = Color.White
        dtpTanggalLahir.Font = New Font("Times New Roman", 10.2F, FontStyle.Bold)
        dtpTanggalLahir.Location = New Point(239, 141)
        dtpTanggalLahir.Name = "dtpTanggalLahir"
        dtpTanggalLahir.Size = New Size(260, 27)
        dtpTanggalLahir.TabIndex = 2
        ' 
        ' txtId
        ' 
        txtId.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        txtId.Font = New Font("Times New Roman", 10.2F, FontStyle.Bold)
        txtId.Location = New Point(239, 87)
        txtId.Name = "txtId"
        txtId.PlaceholderText = "Masukkan ID"
        txtId.Size = New Size(260, 27)
        txtId.TabIndex = 1
        ' 
        ' txtNama
        ' 
        txtNama.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        txtNama.Font = New Font("Times New Roman", 10.2F, FontStyle.Bold)
        txtNama.Location = New Point(239, 32)
        txtNama.Name = "txtNama"
        txtNama.PlaceholderText = "Masukkan Nama"
        txtNama.Size = New Size(260, 27)
        txtNama.TabIndex = 0
        ' 
        ' tpKontakInfo
        ' 
        tpKontakInfo.BackgroundImage = My.Resources.Resources.Windows_XP
        tpKontakInfo.BackgroundImageLayout = ImageLayout.Stretch
        tpKontakInfo.Controls.Add(lblEmail)
        tpKontakInfo.Controls.Add(lblNoHp)
        tpKontakInfo.Controls.Add(lblAlamat)
        tpKontakInfo.Controls.Add(mtbNoHp)
        tpKontakInfo.Controls.Add(txtAlamat)
        tpKontakInfo.Controls.Add(txtEmail)
        tpKontakInfo.Location = New Point(4, 26)
        tpKontakInfo.Name = "tpKontakInfo"
        tpKontakInfo.Padding = New Padding(3)
        tpKontakInfo.Size = New Size(563, 324)
        tpKontakInfo.TabIndex = 1
        tpKontakInfo.Text = "Kontak & Info"
        tpKontakInfo.UseVisualStyleBackColor = True
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        lblEmail.ForeColor = Color.Black
        lblEmail.Location = New Point(103, 153)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(45, 17)
        lblEmail.TabIndex = 12
        lblEmail.Text = "Email"
        ' 
        ' lblNoHp
        ' 
        lblNoHp.AutoSize = True
        lblNoHp.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        lblNoHp.ForeColor = Color.Black
        lblNoHp.Location = New Point(103, 85)
        lblNoHp.Name = "lblNoHp"
        lblNoHp.Size = New Size(77, 17)
        lblNoHp.TabIndex = 11
        lblNoHp.Text = "Nomor Hp"
        ' 
        ' lblAlamat
        ' 
        lblAlamat.AutoSize = True
        lblAlamat.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        lblAlamat.ForeColor = Color.Black
        lblAlamat.Location = New Point(103, 221)
        lblAlamat.Name = "lblAlamat"
        lblAlamat.Size = New Size(54, 17)
        lblAlamat.TabIndex = 10
        lblAlamat.Text = "Alamat"
        ' 
        ' mtbNoHp
        ' 
        mtbNoHp.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        mtbNoHp.Font = New Font("Times New Roman", 9F, FontStyle.Bold)
        mtbNoHp.Location = New Point(205, 82)
        mtbNoHp.Mask = "0000-0000-0000"
        mtbNoHp.Name = "mtbNoHp"
        mtbNoHp.Size = New Size(255, 25)
        mtbNoHp.TabIndex = 9
        ' 
        ' txtAlamat
        ' 
        txtAlamat.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        txtAlamat.Font = New Font("Times New Roman", 9F, FontStyle.Bold)
        txtAlamat.Location = New Point(205, 218)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(255, 25)
        txtAlamat.TabIndex = 8
        ' 
        ' txtEmail
        ' 
        txtEmail.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        txtEmail.Font = New Font("Times New Roman", 9F, FontStyle.Bold)
        txtEmail.Location = New Point(205, 150)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(255, 25)
        txtEmail.TabIndex = 7
        ' 
        ' tpProfilAktivitas
        ' 
        tpProfilAktivitas.BackgroundImage = My.Resources.Resources.Windows_XP
        tpProfilAktivitas.BackgroundImageLayout = ImageLayout.Stretch
        tpProfilAktivitas.Controls.Add(btnBrowse)
        tpProfilAktivitas.Controls.Add(cbProgramming)
        tpProfilAktivitas.Controls.Add(cbTravelling)
        tpProfilAktivitas.Controls.Add(cbDesain)
        tpProfilAktivitas.Controls.Add(cbFotografi)
        tpProfilAktivitas.Controls.Add(cbMembaca)
        tpProfilAktivitas.Controls.Add(cbMusik)
        tpProfilAktivitas.Controls.Add(cbGaming)
        tpProfilAktivitas.Controls.Add(gbPeran)
        tpProfilAktivitas.Controls.Add(pbFotoProfil)
        tpProfilAktivitas.Controls.Add(cbOlahraga)
        tpProfilAktivitas.Location = New Point(4, 26)
        tpProfilAktivitas.Name = "tpProfilAktivitas"
        tpProfilAktivitas.Padding = New Padding(3)
        tpProfilAktivitas.Size = New Size(563, 324)
        tpProfilAktivitas.TabIndex = 2
        tpProfilAktivitas.Text = "Profil & Aktivitas"
        tpProfilAktivitas.UseVisualStyleBackColor = True
        ' 
        ' btnBrowse
        ' 
        btnBrowse.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        btnBrowse.Location = New Point(66, 161)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(94, 29)
        btnBrowse.TabIndex = 15
        btnBrowse.Text = "Browse"
        btnBrowse.UseVisualStyleBackColor = False
        ' 
        ' cbProgramming
        ' 
        cbProgramming.AutoSize = True
        cbProgramming.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        cbProgramming.Location = New Point(412, 267)
        cbProgramming.Name = "cbProgramming"
        cbProgramming.Size = New Size(118, 21)
        cbProgramming.TabIndex = 23
        cbProgramming.Text = "Programming"
        cbProgramming.UseVisualStyleBackColor = False
        ' 
        ' cbTravelling
        ' 
        cbTravelling.AutoSize = True
        cbTravelling.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        cbTravelling.Location = New Point(283, 267)
        cbTravelling.Name = "cbTravelling"
        cbTravelling.Size = New Size(96, 21)
        cbTravelling.TabIndex = 22
        cbTravelling.Text = "Travelling"
        cbTravelling.UseVisualStyleBackColor = False
        ' 
        ' cbDesain
        ' 
        cbDesain.AutoSize = True
        cbDesain.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        cbDesain.Location = New Point(173, 267)
        cbDesain.Name = "cbDesain"
        cbDesain.Size = New Size(75, 21)
        cbDesain.TabIndex = 21
        cbDesain.Text = "Desain"
        cbDesain.UseVisualStyleBackColor = False
        ' 
        ' cbFotografi
        ' 
        cbFotografi.AutoSize = True
        cbFotografi.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        cbFotografi.Location = New Point(57, 267)
        cbFotografi.Name = "cbFotografi"
        cbFotografi.Size = New Size(89, 21)
        cbFotografi.TabIndex = 20
        cbFotografi.Text = "Fotografi"
        cbFotografi.UseVisualStyleBackColor = False
        ' 
        ' cbMembaca
        ' 
        cbMembaca.AutoSize = True
        cbMembaca.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        cbMembaca.Location = New Point(412, 221)
        cbMembaca.Name = "cbMembaca"
        cbMembaca.Size = New Size(94, 21)
        cbMembaca.TabIndex = 19
        cbMembaca.Text = "Membaca"
        cbMembaca.UseVisualStyleBackColor = False
        ' 
        ' cbMusik
        ' 
        cbMusik.AutoSize = True
        cbMusik.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        cbMusik.Location = New Point(283, 221)
        cbMusik.Name = "cbMusik"
        cbMusik.Size = New Size(73, 21)
        cbMusik.TabIndex = 18
        cbMusik.Text = "Musik"
        cbMusik.UseVisualStyleBackColor = False
        ' 
        ' cbGaming
        ' 
        cbGaming.AutoSize = True
        cbGaming.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        cbGaming.Location = New Point(173, 221)
        cbGaming.Name = "cbGaming"
        cbGaming.Size = New Size(80, 21)
        cbGaming.TabIndex = 17
        cbGaming.Text = "Gaming"
        cbGaming.UseVisualStyleBackColor = False
        ' 
        ' gbPeran
        ' 
        gbPeran.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        gbPeran.Controls.Add(rbAnggota)
        gbPeran.Controls.Add(rbAdmin)
        gbPeran.Controls.Add(rbKetua)
        gbPeran.Location = New Point(191, 36)
        gbPeran.Name = "gbPeran"
        gbPeran.Size = New Size(351, 152)
        gbPeran.TabIndex = 14
        gbPeran.TabStop = False
        gbPeran.Text = "Peran"
        ' 
        ' rbAnggota
        ' 
        rbAnggota.AutoSize = True
        rbAnggota.Location = New Point(29, 95)
        rbAnggota.Name = "rbAnggota"
        rbAnggota.Size = New Size(84, 21)
        rbAnggota.TabIndex = 2
        rbAnggota.TabStop = True
        rbAnggota.Text = "Anggota"
        rbAnggota.UseVisualStyleBackColor = True
        ' 
        ' rbAdmin
        ' 
        rbAdmin.AutoSize = True
        rbAdmin.Location = New Point(29, 63)
        rbAdmin.Name = "rbAdmin"
        rbAdmin.Size = New Size(72, 21)
        rbAdmin.TabIndex = 1
        rbAdmin.TabStop = True
        rbAdmin.Text = "Admin"
        rbAdmin.UseVisualStyleBackColor = True
        ' 
        ' rbKetua
        ' 
        rbKetua.AutoSize = True
        rbKetua.Location = New Point(29, 33)
        rbKetua.Name = "rbKetua"
        rbKetua.Size = New Size(69, 21)
        rbKetua.TabIndex = 0
        rbKetua.TabStop = True
        rbKetua.Text = "Ketua"
        rbKetua.UseVisualStyleBackColor = True
        ' 
        ' pbFotoProfil
        ' 
        pbFotoProfil.BackgroundImage = My.Resources.Resources.Kosong
        pbFotoProfil.BackgroundImageLayout = ImageLayout.Stretch
        pbFotoProfil.Location = New Point(57, 36)
        pbFotoProfil.Name = "pbFotoProfil"
        pbFotoProfil.Size = New Size(113, 119)
        pbFotoProfil.SizeMode = PictureBoxSizeMode.StretchImage
        pbFotoProfil.TabIndex = 13
        pbFotoProfil.TabStop = False
        ' 
        ' cbOlahraga
        ' 
        cbOlahraga.AutoSize = True
        cbOlahraga.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        cbOlahraga.Location = New Point(57, 221)
        cbOlahraga.Name = "cbOlahraga"
        cbOlahraga.Size = New Size(89, 21)
        cbOlahraga.TabIndex = 16
        cbOlahraga.Text = "Olahraga"
        cbOlahraga.UseVisualStyleBackColor = False
        ' 
        ' btnSimpanCetak
        ' 
        btnSimpanCetak.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        btnSimpanCetak.Font = New Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSimpanCetak.Location = New Point(487, 405)
        btnSimpanCetak.Name = "btnSimpanCetak"
        btnSimpanCetak.Size = New Size(181, 34)
        btnSimpanCetak.TabIndex = 3
        btnSimpanCetak.Text = "Simpan dan Cetak Kartu"
        btnSimpanCetak.UseVisualStyleBackColor = False
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' FormInput
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 451)
        Controls.Add(btnSimpanCetak)
        Controls.Add(TabControl1)
        Name = "FormInput"
        Text = "FormInput"
        TabControl1.ResumeLayout(False)
        tpDataUtama.ResumeLayout(False)
        tpDataUtama.PerformLayout()
        tpKontakInfo.ResumeLayout(False)
        tpKontakInfo.PerformLayout()
        tpProfilAktivitas.ResumeLayout(False)
        tpProfilAktivitas.PerformLayout()
        gbPeran.ResumeLayout(False)
        gbPeran.PerformLayout()
        CType(pbFotoProfil, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tpDataUtama As TabPage
    Friend WithEvents lblJenisKomunitas As Label
    Friend WithEvents lblJenisKelamin As Label
    Friend WithEvents lblTanggalLahir As Label
    Friend WithEvents lblId As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents cbJenisKomunitas As ComboBox
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents rbLaki As RadioButton
    Friend WithEvents dtpTanggalLahir As DateTimePicker
    Friend WithEvents txtId As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents tpKontakInfo As TabPage
    Friend WithEvents tpProfilAktivitas As TabPage
    Friend WithEvents btnSimpanCetak As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblNoHp As Label
    Friend WithEvents lblAlamat As Label
    Friend WithEvents mtbNoHp As MaskedTextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents cbProgramming As CheckBox
    Friend WithEvents cbTravelling As CheckBox
    Friend WithEvents cbDesain As CheckBox
    Friend WithEvents cbFotografi As CheckBox
    Friend WithEvents cbMembaca As CheckBox
    Friend WithEvents cbMusik As CheckBox
    Friend WithEvents cbGaming As CheckBox
    Friend WithEvents gbPeran As GroupBox
    Friend WithEvents rbAnggota As RadioButton
    Friend WithEvents rbAdmin As RadioButton
    Friend WithEvents rbKetua As RadioButton
    Friend WithEvents pbFotoProfil As PictureBox
    Friend WithEvents cbOlahraga As CheckBox
End Class
