Public Class Form2

    Private Sub KosongkanForm()
        txtKodeAlat.Clear()
        txtNamaAlat.Clear()
        txtKategori.Clear()
        txtHarga.Clear()
        txtStatus.Clear()
        txtSearch.Clear()
        txtKodeAlat.Enabled = True
        txtKodeAlat.Focus()
    End Sub

    Private Sub RefreshGrid()
        dgvAlat.DataSource = GetAllAlat()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshGrid()
        KosongkanForm()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtKodeAlat.Text = "" Or txtNamaAlat.Text = "" Then
            MessageBox.Show("Kode dan Nama Alat wajib diisi!", "Peringatan")
            Exit Sub
        End If

        If KodeSudahAda(txtKodeAlat.Text) Then
            MessageBox.Show("Kode Alat ini sudah ada!", "Peringatan")
            Exit Sub
        End If

        If SimpanAlat(txtKodeAlat.Text, txtNamaAlat.Text, txtKategori.Text, Val(txtHarga.Text), txtStatus.Text) Then
            MessageBox.Show("Data berhasil disimpan", "Sukses")
            RefreshGrid()
            KosongkanForm()
        End If
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If txtKodeAlat.Text = "" Then Exit Sub

        If UbahAlat(txtKodeAlat.Text, txtNamaAlat.Text, txtKategori.Text, Val(txtHarga.Text), txtStatus.Text) Then
            MessageBox.Show("Data berhasil diperbarui", "Sukses")
            RefreshGrid()
            KosongkanForm()
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If txtKodeAlat.Text = "" Then Exit Sub

        Dim tanya As DialogResult = MessageBox.Show("Hapus data alat ini?", "Konfirmasi", MessageBoxButtons.YesNo)
        If tanya = DialogResult.Yes Then
            If HapusAlat(txtKodeAlat.Text) Then
                MessageBox.Show("Data berhasil dihapus")
                RefreshGrid()
                KosongkanForm()
            End If
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        KosongkanForm()
        RefreshGrid()
    End Sub

    Private Sub dgvAlat_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAlat.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvAlat.Rows(e.RowIndex)
            txtKodeAlat.Text = row.Cells(0).Value.ToString()
            txtNamaAlat.Text = row.Cells(1).Value.ToString()
            txtKategori.Text = row.Cells(2).Value.ToString()
            txtHarga.Text = row.Cells(3).Value.ToString()
            txtStatus.Text = row.Cells(4).Value.ToString()

            txtKodeAlat.Enabled = False
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text = "" Then
            RefreshGrid()
        Else
            dgvAlat.DataSource = SearchAlat(txtSearch.Text)
        End If
    End Sub

    Private Sub txtHarga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHarga.KeyPress
        HanyaAngka(e) ' Mencegah input huruf pada harga
    End Sub
End Class