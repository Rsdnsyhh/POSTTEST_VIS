Imports System.IO

Public Class FormUtama

    Private Sub InputDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InputDataToolStripMenuItem.Click
        FormInput.ShowDialog()
    End Sub

    Private Sub LihatKartuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LihatKartuToolStripMenuItem.Click
        If varNama = "" Then
            MessageBox.Show("Data masih kosong. Silakan input data terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            FormHasil.ShowDialog()
        End If
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Dim konfirmasi As DialogResult = MessageBox.Show("Apakah Anda yakin ingin keluar?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If konfirmasi = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub SimpanDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SimpanDataToolStripMenuItem.Click
        If varNama = "" Then
            MessageBox.Show("Tidak ada data untuk disimpan!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "Text Files (*.txt)|*.txt"
        saveFileDialog.Title = "Simpan Data Komunitas"

        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            Try
                Using writer As New StreamWriter(saveFileDialog.FileName)
                    writer.WriteLine(varNama)
                    writer.WriteLine(varID)
                    writer.WriteLine(varKelamin)
                    writer.WriteLine(varTglLahir)
                    writer.WriteLine(varKomunitas)
                    writer.WriteLine(varNoHp)
                    writer.WriteLine(varEmail)
                    writer.WriteLine(varAlamat)
                    writer.WriteLine(varPeran)
                    writer.WriteLine(varAktivitas)
                    writer.WriteLine(varFotoPath)
                End Using
                MessageBox.Show("Data berhasil disimpan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Terjadi kesalahan saat menyimpan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub BukaDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BukaDataToolStripMenuItem.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Text Files (*.txt)|*.txt"
        openFileDialog.Title = "Buka Data Komunitas"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Try
                Using reader As New StreamReader(openFileDialog.FileName)
                    varNama = reader.ReadLine()
                    varID = reader.ReadLine()
                    varKelamin = reader.ReadLine()
                    varTglLahir = reader.ReadLine()
                    varKomunitas = reader.ReadLine()
                    varNoHp = reader.ReadLine()
                    varEmail = reader.ReadLine()
                    varAlamat = reader.ReadLine()
                    varPeran = reader.ReadLine()
                    varAktivitas = reader.ReadLine()
                    varFotoPath = reader.ReadLine()
                End Using
                MessageBox.Show("Data berhasil dimuat! Silakan klik 'Lihat Kartu'.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Terjadi kesalahan saat membuka file: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

End Class