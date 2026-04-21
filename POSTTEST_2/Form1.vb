Public Class Form1

    Private Function FormatBuku(ByVal judul As String, ByVal genre As String) As String

        Return judul & " (" & genre & ")"

    End Function

    'tambah buku
    Private Sub TambahBuku(ByVal judul As String, ByVal genre As String)

        If jumlahBuku < 100 Then

            daftarBuku(jumlahBuku, 0) = judul
            daftarBuku(jumlahBuku, 1) = genre

            jumlahBuku = jumlahBuku + 1

        End If

    End Sub


    'hapus buku berdasarkan judul
    Private Sub HapusBuku(ByVal judul As String)

        For i As Integer = 0 To jumlahBuku - 1

            If daftarBuku(i, 0) = judul Then

                For j As Integer = i To jumlahBuku - 2

                    daftarBuku(j, 0) = daftarBuku(j + 1, 0)
                    daftarBuku(j, 1) = daftarBuku(j + 1, 1)

                Next

                jumlahBuku = jumlahBuku - 1

                Exit For

            End If

        Next

    End Sub


    'tampilkan data buku ke datagridview
    Private Sub TampilBuku()

        dgvHasil.Rows.Clear()

        For i As Integer = 0 To jumlahBuku - 1

            dgvHasil.Rows.Add(daftarBuku(i, 0), daftarBuku(i, 1))

        Next

    End Sub

    'button tambah
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click

        If txtJudulBuku.Text = "" Or txtGenre.Text = "" Then

            MessageBox.Show("Data belum lengkap")

        Else

            TambahBuku(txtJudulBuku.Text, txtGenre.Text)

            TampilBuku()

            txtJudulBuku.Clear()
            txtGenre.Clear()

        End If

    End Sub

    'button hapus
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click

        If TextBox1.Text = "" Then

            MessageBox.Show("Masukkan judul buku")

        Else

            HapusBuku(TextBox1.Text)

            TampilBuku()

            TextBox1.Clear()

        End If

    End Sub

End Class