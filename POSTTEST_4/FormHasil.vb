Imports System.IO

Public Class FormHasil

    Private Sub FormHasil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Menampilkan data ke Label
        lblNamaHasil.Text = varNama
        lblIdHasil.Text = varID
        lblKomunitasHasil.Text = varPeran & " - " & varKomunitas

        ' Format kontak
        lblKontakHasil.Text = varNoHp & vbCrLf & varEmail

        ' Format Aktivitas
        lblHobiAktivitasHasil.Text = varAktivitas

        ' Memuat Foto Profil
        If varFotoPath <> "" AndAlso File.Exists(varFotoPath) Then
            pbProfilHasil.ImageLocation = varFotoPath
        Else
            ' Jika tidak ada foto, kosongkan atau gunakan gambar default (opsional)
            pbProfilHasil.Image = Nothing
        End If
    End Sub

    Private Sub panelHasil_Paint(sender As Object, e As PaintEventArgs) Handles panelHasil.Paint

    End Sub
End Class