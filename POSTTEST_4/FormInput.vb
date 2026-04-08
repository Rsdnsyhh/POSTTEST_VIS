Public Class FormInput

    Private Sub FormInput_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Isi ComboBox Jenis Komunitas saat form dimuat
        cbJenisKomunitas.Items.Clear()
        cbJenisKomunitas.Items.Add("Pecinta Alam")
        cbJenisKomunitas.Items.Add("Teknologi & IT")
        cbJenisKomunitas.Items.Add("Seni & Budaya")
        cbJenisKomunitas.Items.Add("Otomotif")
        cbJenisKomunitas.Items.Add("Relawan Sosial")
        cbJenisKomunitas.SelectedIndex = 0
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        ' Membuka file gambar untuk foto profil
        OpenFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
        OpenFileDialog1.Title = "Pilih Foto Profil"

        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            pbFotoProfil.ImageLocation = OpenFileDialog1.FileName
            varFotoPath = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub btnSimpanCetak_Click(sender As Object, e As EventArgs) Handles btnSimpanCetak.Click
        ' Validasi input sederhana
        If txtNama.Text = "" Or txtId.Text = "" Then
            MessageBox.Show("Nama dan ID Anggota wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Simpan Data Utama
        varNama = txtNama.Text
        varID = txtId.Text
        varTglLahir = dtpTanggalLahir.Value.ToString("dd MMMM yyyy")
        varKomunitas = cbJenisKomunitas.Text

        If rbLaki.Checked Then
            varKelamin = "Laki-Laki"
        ElseIf rbPerempuan.Checked Then
            varKelamin = "Perempuan"
        Else
            varKelamin = "-"
        End If

        ' Simpan Kontak Info
        varNoHp = mtbNoHp.Text
        varEmail = txtEmail.Text
        varAlamat = txtAlamat.Text

        ' Simpan Peran
        If rbKetua.Checked Then
            varPeran = "Ketua"
        ElseIf rbAdmin.Checked Then
            varPeran = "Admin"
        ElseIf rbAnggota.Checked Then
            varPeran = "Anggota"
        Else
            varPeran = "Anggota" ' Default
        End If

        ' Simpan Hobi/Aktivitas (Menggabungkan text dari checkbox yang dicentang)
        Dim hobiList As New List(Of String)
        If cbOlahraga.Checked Then hobiList.Add("Olahraga")
        If cbGaming.Checked Then hobiList.Add("Gaming")
        If cbMusik.Checked Then hobiList.Add("Musik")
        If cbMembaca.Checked Then hobiList.Add("Membaca")
        If cbFotografi.Checked Then hobiList.Add("Fotografi")
        If cbDesain.Checked Then hobiList.Add("Desain")
        If cbTravelling.Checked Then hobiList.Add("Travelling")
        If cbProgramming.Checked Then hobiList.Add("Programming")

        If hobiList.Count > 0 Then
            varAktivitas = String.Join(", ", hobiList)
        Else
            varAktivitas = "-"
        End If

        ' Tutup form input dan buka form hasil
        MessageBox.Show("Data berhasil disimpan sementara!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
        FormHasil.ShowDialog()
    End Sub

    Private Sub RbLaki_CheckedChanged(sender As Object, e As EventArgs) Handles rbLaki.CheckedChanged

    End Sub
    Private Sub RbPerempuan_CheckedChanged(sender As Object, e As EventArgs) Handles rbPerempuan.CheckedChanged

    End Sub

    Private Sub tpDataUtama_Click(sender As Object, e As EventArgs) Handles tpDataUtama.Click

    End Sub

    Private Sub tpKontakInfo_Click(sender As Object, e As EventArgs) Handles tpKontakInfo.Click

    End Sub

    Private Sub tpProfilAktivitas_Click(sender As Object, e As EventArgs) Handles tpProfilAktivitas.Click

    End Sub
End Class