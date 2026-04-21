Public Class Form3

    Private Sub Kosong()
        txtKodePinjam.Clear()
        cbAlat.SelectedIndex = -1
        cbAlat.Text = ""
        txtNamaPeminjam.Clear()
        txtTanggalPinjam.Clear()
        txtTanggalKembali.Clear()
        ErrorProvider1.Clear()
        txtKodePinjam.Focus()
    End Sub

    Private Sub TampilData()
        dgvPeminjaman.DataSource = DataModule.GetAllPeminjaman()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dtAlat As DataTable = DataModule.GetAllAlat()
        cbAlat.DataSource = dtAlat
        cbAlat.DisplayMember = "namaAlat"
        cbAlat.ValueMember = "kodeAlat"
        TampilData()
        Kosong()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        ErrorProvider1.Clear()
        If Not ValidationModule.ValidasiDataPeminjaman(ErrorProvider1, txtKodePinjam,
                cbAlat, txtNamaPeminjam, txtTanggalPinjam, txtTanggalKembali) Then Exit Sub

        Dim kode As String = txtKodePinjam.Text.Trim()

        If DataModule.KodePinjamanSudahAda(kode) Then
            MessageBox.Show("Kode Peminjaman sudah terdaftar!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtKodePinjam.Focus()
            Exit Sub
        End If

        Dim kodeAlat As String = cbAlat.SelectedValue.ToString()
        Dim nama As String = txtNamaPeminjam.Text.Trim()
        Dim tglPinjam As String = txtTanggalPinjam.Text.Trim()
        Dim tglKembali As String = txtTanggalKembali.Text.Trim()

        If DataModule.SimpanPeminjaman(kode, kodeAlat, nama, tglPinjam, tglKembali) Then
            MessageBox.Show("Data berhasil disimpan!", "Informasi",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData()
            Kosong()
        End If
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        ErrorProvider1.Clear()
        If Not ValidationModule.ValidasiDataPeminjaman(ErrorProvider1, txtKodePinjam,
                cbAlat, txtNamaPeminjam, txtTanggalPinjam, txtTanggalKembali) Then Exit Sub

        Dim kode As String = txtKodePinjam.Text.Trim()
        Dim kodeAlat As String = cbAlat.SelectedValue.ToString()
        Dim nama As String = txtNamaPeminjam.Text.Trim()
        Dim tglPinjam As String = txtTanggalPinjam.Text.Trim()
        Dim tglKembali As String = txtTanggalKembali.Text.Trim()

        If DataModule.UbahPeminjaman(kode, kodeAlat, nama, tglPinjam, tglKembali) Then
            MessageBox.Show("Data berhasil diubah!", "Informasi",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData()
            Kosong()
        Else
            MessageBox.Show("Data tidak ditemukan!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If txtKodePinjam.Text.Trim() = "" Then
            MessageBox.Show("Pilih data yang akan dihapus!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtKodePinjam.Focus()
            Exit Sub
        End If

        Dim hasil As DialogResult = MessageBox.Show("Apakah data ingin dihapus?", "Konfirmasi",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If hasil = DialogResult.Yes Then
            If DataModule.HapusPeminjaman(txtKodePinjam.Text.Trim()) Then
                MessageBox.Show("Data berhasil dihapus!", "Informasi",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
                TampilData()
                Kosong()
            End If
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Kosong()
        TampilData()
    End Sub

    Private Sub dgvPeminjaman_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPeminjaman.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvPeminjaman.Rows(e.RowIndex)
            txtKodePinjam.Text = row.Cells(0).Value.ToString()
            cbAlat.Text = row.Cells(1).Value.ToString()
            txtNamaPeminjam.Text = row.Cells(2).Value.ToString()
            txtTanggalPinjam.Text = row.Cells(3).Value.ToString()
            txtTanggalKembali.Text = row.Cells(4).Value.ToString()
        End If
    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        If txtCari.Text.Trim() = "" Then
            TampilData()
        Else
            dgvPeminjaman.DataSource = DataModule.SearchPeminjaman(txtCari.Text.Trim())
        End If
    End Sub

End Class