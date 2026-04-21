Imports MySqlConnector

Module DataModule

    ' tabel alat
    Public Function GetAllAlat() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT kodeAlat, namaAlat, kategori, harga, status FROM tbalat ORDER BY kodeAlat ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan data: " & ex.Message)
        End Try
        Return dt
    End Function

    Public Function SearchAlat(keyword As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT * FROM tbalat WHERE kodeAlat LIKE @keyword OR namaAlat LIKE @keyword OR status LIKE @keyword ORDER BY kodeAlat ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@keyword", "%" & keyword & "%")
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mencari data: " & ex.Message)
        End Try
        Return dt
    End Function

    Public Function KodeSudahAda(kode As String) As Boolean
        Try
            Dim query As String = "SELECT COUNT(*) FROM tbalat WHERE kodeAlat = @kodeAlat"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kodeAlat", kode)
                    Return Convert.ToInt32(cmd.ExecuteScalar()) > 0
                End Using
            End Using
        Catch ex As Exception
            Return True
        End Try
    End Function

    Public Function SimpanAlat(kode As String, nama As String, kategori As String, harga As Integer, status As String) As Boolean
        Try
            Dim query As String = "INSERT INTO tbalat (kodeAlat, namaAlat, kategori, harga, status) VALUES (@kode, @nama, @kat, @harga, @status)"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@kat", kategori)
                    cmd.Parameters.AddWithValue("@harga", harga)
                    cmd.Parameters.AddWithValue("@status", status)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function UbahAlat(kode As String, nama As String, kategori As String, harga As Integer, status As String) As Boolean
        Try
            Dim query As String = "UPDATE tbalat SET namaAlat=@nama, kategori=@kat, harga=@harga, status=@status WHERE kodeAlat=@kode"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@kat", kategori)
                    cmd.Parameters.AddWithValue("@harga", harga)
                    cmd.Parameters.AddWithValue("@status", status)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengubah: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function HapusAlat(kode As String) As Boolean
        Try
            Dim query As String = "DELETE FROM tbalat WHERE kodeAlat = @kodeAlat"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kodeAlat", kode)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            Return False
        End Try
    End Function

    ' tabel peminjaman
    Public Function GetAllPeminjaman() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String =
                "SELECT p.kodePinjam, a.namaAlat AS 'Nama Alat', p.namaPeminjam, " &
                "p.tanggalPinjam, p.tanggalKembali " &
                "FROM tbpeminjaman p " &
                "INNER JOIN tbalat a ON p.kodeAlat = a.kodeAlat " &
                "ORDER BY p.kodePinjam ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan data peminjaman: " & ex.Message)
        End Try
        Return dt
    End Function

    Public Function SearchPeminjaman(keyword As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String =
                "SELECT p.kodePinjam, a.namaAlat AS 'Nama Alat', p.namaPeminjam, " &
                "p.tanggalPinjam, p.tanggalKembali " &
                "FROM tbpeminjaman p " &
                "INNER JOIN tbalat a ON p.kodeAlat = a.kodeAlat " &
                "WHERE p.kodePinjam LIKE @kw OR p.namaPeminjam LIKE @kw OR a.namaAlat LIKE @kw " &
                "ORDER BY p.kodePinjam ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@kw", "%" & keyword & "%")
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mencari data peminjaman: " & ex.Message)
        End Try
        Return dt
    End Function

    Public Function KodePinjamanSudahAda(kode As String) As Boolean
        Try
            Dim query As String = "SELECT COUNT(*) FROM tbpeminjaman WHERE kodePinjam = @kode"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    Return Convert.ToInt32(cmd.ExecuteScalar()) > 0
                End Using
            End Using
        Catch ex As Exception
            Return True
        End Try
    End Function

    Public Function SimpanPeminjaman(kodePinjam As String, kodeAlat As String,
                                     namaPeminjam As String, tanggalPinjam As String,
                                     tanggalKembali As String) As Boolean
        Try
            Dim query As String =
                "INSERT INTO tbpeminjaman (kodePinjam, kodeAlat, namaPeminjam, tanggalPinjam, tanggalKembali) " &
                "VALUES (@kp, @ka, @np, @tp, @tk)"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kp", kodePinjam)
                    cmd.Parameters.AddWithValue("@ka", kodeAlat)
                    cmd.Parameters.AddWithValue("@np", namaPeminjam)
                    cmd.Parameters.AddWithValue("@tp", tanggalPinjam)
                    cmd.Parameters.AddWithValue("@tk", tanggalKembali)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan peminjaman: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function UbahPeminjaman(kodePinjam As String, kodeAlat As String,
                                   namaPeminjam As String, tanggalPinjam As String,
                                   tanggalKembali As String) As Boolean
        Try
            Dim query As String =
                "UPDATE tbpeminjaman SET kodeAlat=@ka, namaPeminjam=@np, " &
                "tanggalPinjam=@tp, tanggalKembali=@tk WHERE kodePinjam=@kp"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kp", kodePinjam)
                    cmd.Parameters.AddWithValue("@ka", kodeAlat)
                    cmd.Parameters.AddWithValue("@np", namaPeminjam)
                    cmd.Parameters.AddWithValue("@tp", tanggalPinjam)
                    cmd.Parameters.AddWithValue("@tk", tanggalKembali)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengubah peminjaman: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function HapusPeminjaman(kodePinjam As String) As Boolean
        Try
            Dim query As String = "DELETE FROM tbpeminjaman WHERE kodePinjam = @kp"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kp", kodePinjam)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menghapus peminjaman: " & ex.Message)
            Return False
        End Try
    End Function

End Module