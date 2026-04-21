<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        txtKodeAlat = New TextBox()
        txtNamaAlat = New TextBox()
        txtKategori = New TextBox()
        txtHarga = New TextBox()
        txtStatus = New TextBox()
        btnSimpan = New Button()
        btnUbah = New Button()
        btnHapus = New Button()
        btnBatal = New Button()
        dgvAlat = New DataGridView()
        Label6 = New Label()
        txtSearch = New TextBox()
        CType(dgvAlat, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 9F, FontStyle.Bold)
        Label1.Location = New Point(30, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(74, 17)
        Label1.TabIndex = 16
        Label1.Text = "Kode Alat"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 9F, FontStyle.Bold)
        Label2.Location = New Point(30, 65)
        Label2.Name = "Label2"
        Label2.Size = New Size(75, 17)
        Label2.TabIndex = 15
        Label2.Text = "Nama Alat"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Times New Roman", 9F, FontStyle.Bold)
        Label3.Location = New Point(30, 100)
        Label3.Name = "Label3"
        Label3.Size = New Size(66, 17)
        Label3.TabIndex = 14
        Label3.Text = "Kategori"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Times New Roman", 9F, FontStyle.Bold)
        Label4.Location = New Point(30, 135)
        Label4.Name = "Label4"
        Label4.Size = New Size(48, 17)
        Label4.TabIndex = 13
        Label4.Text = "Harga"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Times New Roman", 9F, FontStyle.Bold)
        Label5.Location = New Point(30, 170)
        Label5.Name = "Label5"
        Label5.Size = New Size(48, 17)
        Label5.TabIndex = 12
        Label5.Text = "Status"
        ' 
        ' txtKodeAlat
        ' 
        txtKodeAlat.Font = New Font("Times New Roman", 9F, FontStyle.Bold)
        txtKodeAlat.Location = New Point(130, 27)
        txtKodeAlat.Name = "txtKodeAlat"
        txtKodeAlat.Size = New Size(150, 25)
        txtKodeAlat.TabIndex = 11
        ' 
        ' txtNamaAlat
        ' 
        txtNamaAlat.Font = New Font("Times New Roman", 9F, FontStyle.Bold)
        txtNamaAlat.Location = New Point(130, 62)
        txtNamaAlat.Name = "txtNamaAlat"
        txtNamaAlat.Size = New Size(300, 25)
        txtNamaAlat.TabIndex = 10
        ' 
        ' txtKategori
        ' 
        txtKategori.Font = New Font("Times New Roman", 9F, FontStyle.Bold)
        txtKategori.Location = New Point(130, 97)
        txtKategori.Name = "txtKategori"
        txtKategori.Size = New Size(200, 25)
        txtKategori.TabIndex = 9
        ' 
        ' txtHarga
        ' 
        txtHarga.Font = New Font("Times New Roman", 9F, FontStyle.Bold)
        txtHarga.Location = New Point(130, 132)
        txtHarga.Name = "txtHarga"
        txtHarga.Size = New Size(150, 25)
        txtHarga.TabIndex = 8
        ' 
        ' txtStatus
        ' 
        txtStatus.Font = New Font("Times New Roman", 9F, FontStyle.Bold)
        txtStatus.Location = New Point(130, 167)
        txtStatus.Name = "txtStatus"
        txtStatus.Size = New Size(150, 25)
        txtStatus.TabIndex = 7
        ' 
        ' btnSimpan
        ' 
        btnSimpan.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        btnSimpan.Font = New Font("Times New Roman", 9F, FontStyle.Bold)
        btnSimpan.ForeColor = Color.Black
        btnSimpan.Location = New Point(30, 215)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(90, 35)
        btnSimpan.TabIndex = 6
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = False
        ' 
        ' btnUbah
        ' 
        btnUbah.BackColor = Color.RoyalBlue
        btnUbah.Font = New Font("Times New Roman", 9F, FontStyle.Bold)
        btnUbah.ForeColor = Color.Black
        btnUbah.Location = New Point(130, 215)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(90, 35)
        btnUbah.TabIndex = 5
        btnUbah.Text = "Ubah"
        btnUbah.UseVisualStyleBackColor = False
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        btnHapus.Font = New Font("Times New Roman", 9F, FontStyle.Bold)
        btnHapus.ForeColor = Color.Black
        btnHapus.Location = New Point(230, 215)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(90, 35)
        btnHapus.TabIndex = 4
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' btnBatal
        ' 
        btnBatal.BackColor = Color.Yellow
        btnBatal.Font = New Font("Times New Roman", 9F, FontStyle.Bold)
        btnBatal.ForeColor = Color.Black
        btnBatal.Location = New Point(330, 215)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(90, 35)
        btnBatal.TabIndex = 3
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = False
        ' 
        ' dgvAlat
        ' 
        dgvAlat.AllowUserToAddRows = False
        dgvAlat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvAlat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvAlat.Location = New Point(30, 315)
        dgvAlat.Name = "dgvAlat"
        dgvAlat.ReadOnly = True
        dgvAlat.RowHeadersWidth = 51
        dgvAlat.Size = New Size(570, 220)
        dgvAlat.TabIndex = 0
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Times New Roman", 9F, FontStyle.Bold)
        Label6.Location = New Point(30, 275)
        Label6.Name = "Label6"
        Label6.Size = New Size(52, 17)
        Label6.TabIndex = 2
        Label6.Text = "Search"
        ' 
        ' txtSearch
        ' 
        txtSearch.Font = New Font("Times New Roman", 9F, FontStyle.Bold)
        txtSearch.Location = New Point(100, 272)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "Cari Data..."
        txtSearch.Size = New Size(500, 25)
        txtSearch.TabIndex = 1
        ' 
        ' Form2
        ' 
        BackgroundImage = My.Resources.Resources.Adventure_Time_4K_Wallpapers___Wallpaper_Cave
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(630, 560)
        Controls.Add(dgvAlat)
        Controls.Add(txtSearch)
        Controls.Add(Label6)
        Controls.Add(btnBatal)
        Controls.Add(btnHapus)
        Controls.Add(btnUbah)
        Controls.Add(btnSimpan)
        Controls.Add(txtStatus)
        Controls.Add(txtHarga)
        Controls.Add(txtKategori)
        Controls.Add(txtNamaAlat)
        Controls.Add(txtKodeAlat)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Pengelolaan Data Alat Camping"
        CType(dgvAlat, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtKodeAlat As TextBox
    Friend WithEvents txtNamaAlat As TextBox
    Friend WithEvents txtKategori As TextBox
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents txtStatus As TextBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents dgvAlat As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents txtSearch As TextBox
End Class