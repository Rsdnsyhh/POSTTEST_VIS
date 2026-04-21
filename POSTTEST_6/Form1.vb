Public Class Form1

    Private Sub DataAlatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataAlatToolStripMenuItem.Click
        Form2.ShowDialog()
    End Sub

    Private Sub DataPeminjamanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataPeminjamanToolStripMenuItem.Click
        Form3.ShowDialog()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Dim konfirmasi As DialogResult = MessageBox.Show("Apakah Anda yakin ingin keluar?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If konfirmasi = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

End Class