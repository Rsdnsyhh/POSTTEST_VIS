<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
    Inherits System.Windows.Forms.Form

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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        lblKodePinjam = New Label()
        txtKodePinjam = New TextBox()
        lblAlat = New Label()
        cbAlat = New ComboBox()
        lblNamaPeminjam = New Label()
        txtNamaPeminjam = New TextBox()
        lblTanggalPinjam = New Label()
        txtTanggalPinjam = New TextBox()
        lblTanggalKembali = New Label()
        txtTanggalKembali = New TextBox()
        btnSimpan = New Button()
        btnUbah = New Button()
        btnHapus = New Button()
        btnBatal = New Button()
        txtCari = New TextBox()
        dgvPeminjaman = New DataGridView()
        ErrorProvider1 = New ErrorProvider(components)
        CType(dgvPeminjaman, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblKodePinjam
        ' 
        lblKodePinjam.AutoSize = True
        lblKodePinjam.Font = New Font("Times New Roman", 10F, FontStyle.Bold)
        lblKodePinjam.Location = New Point(20, 60)
        lblKodePinjam.Name = "lblKodePinjam"
        lblKodePinjam.Size = New Size(104, 19)
        lblKodePinjam.TabIndex = 0
        lblKodePinjam.Text = "Kode Pinjam"
        ' 
        ' txtKodePinjam
        ' 
        txtKodePinjam.Font = New Font("Times New Roman", 10F)
        txtKodePinjam.Location = New Point(160, 57)
        txtKodePinjam.Name = "txtKodePinjam"
        txtKodePinjam.Size = New Size(150, 27)
        txtKodePinjam.TabIndex = 0
        ' 
        ' lblAlat
        ' 
        lblAlat.AutoSize = True
        lblAlat.Font = New Font("Times New Roman", 10F, FontStyle.Bold)
        lblAlat.Location = New Point(20, 100)
        lblAlat.Name = "lblAlat"
        lblAlat.Size = New Size(111, 19)
        lblAlat.TabIndex = 1
        lblAlat.Text = "Alat Camping"
        ' 
        ' cbAlat
        ' 
        cbAlat.DropDownStyle = ComboBoxStyle.DropDownList
        cbAlat.Font = New Font("Times New Roman", 10F)
        cbAlat.Location = New Point(160, 97)
        cbAlat.Name = "cbAlat"
        cbAlat.Size = New Size(250, 27)
        cbAlat.TabIndex = 1
        ' 
        ' lblNamaPeminjam
        ' 
        lblNamaPeminjam.AutoSize = True
        lblNamaPeminjam.Font = New Font("Times New Roman", 10F, FontStyle.Bold)
        lblNamaPeminjam.Location = New Point(20, 140)
        lblNamaPeminjam.Name = "lblNamaPeminjam"
        lblNamaPeminjam.Size = New Size(130, 19)
        lblNamaPeminjam.TabIndex = 2
        lblNamaPeminjam.Text = "Nama Peminjam"
        ' 
        ' txtNamaPeminjam
        ' 
        txtNamaPeminjam.Font = New Font("Times New Roman", 10F)
        txtNamaPeminjam.Location = New Point(160, 137)
        txtNamaPeminjam.Name = "txtNamaPeminjam"
        txtNamaPeminjam.Size = New Size(250, 27)
        txtNamaPeminjam.TabIndex = 2
        ' 
        ' lblTanggalPinjam
        ' 
        lblTanggalPinjam.AutoSize = True
        lblTanggalPinjam.Font = New Font("Times New Roman", 10F, FontStyle.Bold)
        lblTanggalPinjam.Location = New Point(20, 180)
        lblTanggalPinjam.Name = "lblTanggalPinjam"
        lblTanggalPinjam.Size = New Size(123, 19)
        lblTanggalPinjam.TabIndex = 3
        lblTanggalPinjam.Text = "Tanggal Pinjam"
        ' 
        ' txtTanggalPinjam
        ' 
        txtTanggalPinjam.Font = New Font("Times New Roman", 10F)
        txtTanggalPinjam.Location = New Point(160, 177)
        txtTanggalPinjam.Name = "txtTanggalPinjam"
        txtTanggalPinjam.Size = New Size(150, 27)
        txtTanggalPinjam.TabIndex = 3
        ' 
        ' lblTanggalKembali
        ' 
        lblTanggalKembali.AutoSize = True
        lblTanggalKembali.Font = New Font("Times New Roman", 10F, FontStyle.Bold)
        lblTanggalKembali.Location = New Point(20, 220)
        lblTanggalKembali.Name = "lblTanggalKembali"
        lblTanggalKembali.Size = New Size(133, 19)
        lblTanggalKembali.TabIndex = 4
        lblTanggalKembali.Text = "Tanggal Kembali"
        ' 
        ' txtTanggalKembali
        ' 
        txtTanggalKembali.Font = New Font("Times New Roman", 10F)
        txtTanggalKembali.Location = New Point(160, 217)
        txtTanggalKembali.Name = "txtTanggalKembali"
        txtTanggalKembali.Size = New Size(150, 27)
        txtTanggalKembali.TabIndex = 4
        ' 
        ' btnSimpan
        ' 
        btnSimpan.BackColor = Color.Lime
        btnSimpan.Font = New Font("Times New Roman", 10F, FontStyle.Bold)
        btnSimpan.Location = New Point(20, 265)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(90, 30)
        btnSimpan.TabIndex = 5
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = False
        ' 
        ' btnUbah
        ' 
        btnUbah.BackColor = Color.DodgerBlue
        btnUbah.Font = New Font("Times New Roman", 10F, FontStyle.Bold)
        btnUbah.Location = New Point(125, 265)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(90, 30)
        btnUbah.TabIndex = 6
        btnUbah.Text = "Ubah"
        btnUbah.UseVisualStyleBackColor = False
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = Color.Red
        btnHapus.Font = New Font("Times New Roman", 10F, FontStyle.Bold)
        btnHapus.Location = New Point(230, 265)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(90, 30)
        btnHapus.TabIndex = 7
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' btnBatal
        ' 
        btnBatal.BackColor = Color.Yellow
        btnBatal.Font = New Font("Times New Roman", 10F, FontStyle.Bold)
        btnBatal.Location = New Point(335, 265)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(90, 30)
        btnBatal.TabIndex = 8
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = False
        ' 
        ' txtCari
        ' 
        txtCari.Font = New Font("Times New Roman", 10F)
        txtCari.Location = New Point(20, 315)
        txtCari.Name = "txtCari"
        txtCari.PlaceholderText = "Cari Data..."
        txtCari.Size = New Size(730, 27)
        txtCari.TabIndex = 9
        ' 
        ' dgvPeminjaman
        ' 
        dgvPeminjaman.AllowUserToAddRows = False
        dgvPeminjaman.AllowUserToDeleteRows = False
        dgvPeminjaman.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvPeminjaman.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvPeminjaman.Location = New Point(20, 355)
        dgvPeminjaman.Name = "dgvPeminjaman"
        dgvPeminjaman.ReadOnly = True
        dgvPeminjaman.RowHeadersWidth = 51
        dgvPeminjaman.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvPeminjaman.Size = New Size(730, 220)
        dgvPeminjaman.TabIndex = 10
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.adventure_time_scene___screencap1
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(780, 600)
        Controls.Add(lblKodePinjam)
        Controls.Add(txtKodePinjam)
        Controls.Add(lblAlat)
        Controls.Add(cbAlat)
        Controls.Add(lblNamaPeminjam)
        Controls.Add(txtNamaPeminjam)
        Controls.Add(lblTanggalPinjam)
        Controls.Add(txtTanggalPinjam)
        Controls.Add(lblTanggalKembali)
        Controls.Add(txtTanggalKembali)
        Controls.Add(btnSimpan)
        Controls.Add(btnUbah)
        Controls.Add(btnHapus)
        Controls.Add(btnBatal)
        Controls.Add(txtCari)
        Controls.Add(dgvPeminjaman)
        Name = "Form3"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Data Peminjaman Alat Camping"
        CType(dgvPeminjaman, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblKodePinjam As Label
    Friend WithEvents txtKodePinjam As TextBox
    Friend WithEvents lblAlat As Label
    Friend WithEvents cbAlat As ComboBox
    Friend WithEvents lblNamaPeminjam As Label
    Friend WithEvents txtNamaPeminjam As TextBox
    Friend WithEvents lblTanggalPinjam As Label
    Friend WithEvents txtTanggalPinjam As TextBox
    Friend WithEvents lblTanggalKembali As Label
    Friend WithEvents txtTanggalKembali As TextBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents txtCari As TextBox
    Friend WithEvents dgvPeminjaman As DataGridView
    Friend WithEvents ErrorProvider1 As ErrorProvider

End Class