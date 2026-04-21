Module ValidationModule

    Public Sub HanyaHuruf(e As KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) OrElse Char.IsWhiteSpace(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Sub HanyaAngka(e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Function ValidasiTextBox(ep As ErrorProvider, txt As TextBox, pesan As String) As Boolean
        If txt.Text.Trim() = "" Then
            ep.SetError(txt, pesan)
            Return False
        End If
        ep.SetError(txt, "")
        Return True
    End Function

    Public Function ValidasiComboBox(ep As ErrorProvider, cb As ComboBox, pesan As String) As Boolean
        If cb.SelectedIndex = -1 Then
            ep.SetError(cb, pesan)
            Return False
        End If
        ep.SetError(cb, "")
        Return True
    End Function

    Public Function ValidasiDataPeminjaman(ep As ErrorProvider, txtKode As TextBox,
                                           cbAlat As ComboBox, txtNama As TextBox,
                                           txtTglPinjam As TextBox,
                                           txtTglKembali As TextBox) As Boolean
        Dim kodeValid As Boolean = ValidasiTextBox(ep, txtKode, "Kode Peminjaman wajib diisi!")
        Dim alatValid As Boolean = ValidasiComboBox(ep, cbAlat, "Silakan pilih Alat!")
        Dim namaValid As Boolean = ValidasiTextBox(ep, txtNama, "Nama Peminjam wajib diisi!")
        Dim tglPinjamValid As Boolean = ValidasiTextBox(ep, txtTglPinjam, "Tanggal Pinjam wajib diisi!")
        Dim tglKembaliValid As Boolean = ValidasiTextBox(ep, txtTglKembali, "Tanggal Kembali wajib diisi!")
        Return kodeValid And alatValid And namaValid And tglPinjamValid And tglKembaliValid
    End Function

End Module