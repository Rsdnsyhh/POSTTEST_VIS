Public Class Form1

    Dim totalNilai As Double
    Dim jumlahSmt As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        totalNilai = 0
        jumlahSmt = 0
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim ipBaru As Double

        If Double.TryParse(txtIP.Text, ipBaru) Then

            totalNilai = totalNilai + ipBaru
            jumlahSmt = jumlahSmt + 1

            Dim ipk As Double
            ipk = totalNilai / jumlahSmt

            txtIPK.Text = ipk

            If ipk >= 3.01 Then
                lblPredikat.Text = "Sangat Memuaskan"
            ElseIf ipk >= 2.76 Then
                lblPredikat.Text = "Memuaskan"
            ElseIf ipk >= 2.0 Then
                lblPredikat.Text = "Cukup"
            Else
                lblPredikat.Text = "Kurang"
            End If

            txtIP.Text = ""
            txtIP.Focus()

        Else
            MessageBox.Show("IP harus berupa angka")
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        totalNilai = 0
        jumlahSmt = 0

        txtIP.Text = ""
        txtIPK.Text = ""
        lblPredikat.Text = "-"

        txtIP.Focus()
    End Sub

End Class