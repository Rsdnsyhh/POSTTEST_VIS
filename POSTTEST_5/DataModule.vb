Imports MySqlConnector

Module DataModule
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
End Module