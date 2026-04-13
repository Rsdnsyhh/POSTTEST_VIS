Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.ReadOnly = True
        TextBox2.ReadOnly = True
        TextBox3.ReadOnly = True
        TextBox4.ReadOnly = True
        TextBox5.ReadOnly = True
        TextBox6.ReadOnly = True
        TextBox7.ReadOnly = True

        TextBox1.Text = DataModule.Nama
        TextBox2.Text = DataModule.Umur & " Tahun"
        TextBox3.Text = DataModule.Tglahir
        TextBox4.Text = DataModule.JK
        TextBox5.Text = DataModule.Telpon
        TextBox6.Text = DataModule.Hobi
        TextBox7.Text = DataModule.Alamat

        If Not String.IsNullOrEmpty(DataModule.Foto) Then
            PictureBox1.Image = Image.FromFile(DataModule.Foto)
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub
End Class