Imports System.IO

Public Class Form1
    Dim grupHobi() As CheckBox
    Dim grupJK() As RadioButton

    Private Function CekData() As Boolean
        grupHobi = {CheckBox1, CheckBox2, CheckBox3, CheckBox4, CheckBox5,
                    CheckBox6, CheckBox7, CheckBox8, CheckBox9, CheckBox10}
        grupJK = {RadioButton1, RadioButton2}

        If Not ValidasiTextBox(TextBox1, "Inputan tidak boleh kosong") Then Return False ' Nama
        If Not ValidasiTextBox(TextBox2, "Inputan tidak boleh kosong") Then Return False ' Umur
        If Not ValidasiTextBox(TextBox3, "Inputan tidak boleh kosong") Then Return False ' Telpon
        If Not ValidasiTextBox(TextBox4, "Inputan tidak boleh kosong") Then Return False ' Alamat
        If Not ValidasiRadioButton(grupJK, "Inputan tidak boleh kosong") Then Return False
        If Not ValidasiCheckBox(grupHobi, "Inputan tidak boleh kosong") Then Return False
        If Not ValidasiPictureBox(PictureBox1, "Inputan tidak boleh kosong") Then Return False

        Return True
    End Function

    Private Sub btnPilihGambar_Click(sender As Object, e As EventArgs) Handles btnPilihGambar.Click
        If ValidasiTextBox(TextBox1, "Isi nama terlebih dahulu") Then
            Dim NamaFile As String = TextBox1.Text.Trim()
            Dim openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
            openFileDialog.Title = "Pilih Gambar"

            If openFileDialog.ShowDialog() = DialogResult.OK Then
                Dim folderPath As String = Path.Combine(Application.StartupPath, "Foto")
                Dim fileName As String = NamaFile & Path.GetExtension(openFileDialog.FileName)
                Dim destinationPath As String = Path.Combine(folderPath, fileName)

                If Not Directory.Exists(folderPath) Then
                    Directory.CreateDirectory(folderPath)
                End If

                File.Copy(openFileDialog.FileName, destinationPath, True)
                DataModule.Foto = destinationPath

                PictureBox1.Image = Image.FromFile(destinationPath)
                PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
                MessageBox.Show("Gambar berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub btnCetakKartu_Click(sender As Object, e As EventArgs) Handles btnCetakKartu.Click
        If CekData() Then
            grupHobi = {CheckBox1, CheckBox2, CheckBox3, CheckBox4, CheckBox5,
                        CheckBox6, CheckBox7, CheckBox8, CheckBox9, CheckBox10}
            grupJK = {RadioButton1, RadioButton2}

            DataModule.Nama = TextBox1.Text
            DataModule.Umur = TextBox2.Text
            DataModule.Telpon = TextBox3.Text
            DataModule.Alamat = TextBox4.Text
            DataModule.Tglahir = DateTimePicker1.Value.ToString("dd MMMM yyyy")
            DataModule.JK = GetSelectedRadioButton(grupJK)
            DataModule.Hobi = GetSelectedCheckBox(grupHobi)

            Form2.Show()
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        HanyaHuruf(sender, e)
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        HanyaAngka(sender, e)
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        HanyaAngka(sender, e)
    End Sub
End Class