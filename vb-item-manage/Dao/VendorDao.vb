Imports Npgsql

Public Class VendorDao
    Dim npgsqlConn As NpgsqlConnection
    Dim cmd As NpgsqlCommand
    Dim rs As NpgsqlDataReader
    Dim result As Integer
    Dim adp As NpgsqlDataAdapter
    Dim query As String

    Public Function loadAllData() As DataTable
        query = "select * from vendor v where v.isDelete is null " 'query database'
        npgsqlConn = DbConnection.OpenConnection 'pembukaan koneksi'
        cmd = New NpgsqlCommand(query, npgsqlConn) 'eksekusi query berdasarkan koneksi'
        adp = New NpgsqlDataAdapter(cmd) 'mengambil data hasil query'
        Dim table As New DataTable() 'definisi tabel penampungan'
        adp.Fill(table) 'data ditampung di tabel'

        Return table
    End Function

    Public Function getIdByCode(code As String) As Integer
        npgsqlConn = DbConnection.OpenConnection()
        query = "SELECT v.id from vendor v where v.code = @code"
        cmd = New NpgsqlCommand(query, npgsqlConn)
        cmd.Parameters.AddWithValue("@code", code)
        rs = cmd.ExecuteReader()
        While rs.Read()
            result = rs.GetInt32(0)
            Exit While
        End While

        Return result
    End Function

    Public Function getAllCode() As NpgsqlDataReader
        npgsqlConn = DbConnection.OpenConnection()
        query = "select code from vendor"
        cmd = New NpgsqlCommand(query, npgsqlConn)
        rs = cmd.ExecuteReader()
        Return rs
    End Function

    Public Function getObjectByCode(code As String) As NpgsqlDataReader
        npgsqlConn = DbConnection.OpenConnection()
        query = "SELECT v.name, v.address, v.phone, v.email, v.pic_name from vendor v where v.code = @code"
        cmd = New NpgsqlCommand(query, npgsqlConn)
        cmd.Parameters.AddWithValue("@code", code)
        rs = cmd.ExecuteReader()
        Return rs
    End Function

    Public Function insert(code As String, name As String, address As String,
                       phone As String, email As String, pic As String) As Integer
        'passing value'
        npgsqlConn = DbConnection.OpenConnection()
        query = "INSERT INTO vendor (code, name, address, phone, email, pic_name) "
        query = query & " VALUES (@code, @name, @address, @phone, @email, @pic)" 'query insert'
        cmd = New NpgsqlCommand(query, npgsqlConn)
        cmd.Parameters.AddWithValue("@code", code)
        cmd.Parameters.AddWithValue("@name", name)
        cmd.Parameters.AddWithValue("@address", address)
        cmd.Parameters.AddWithValue("@phone", phone)
        cmd.Parameters.AddWithValue("@email", email)
        cmd.Parameters.AddWithValue("@pic", pic)
        Dim result As Integer
        result = cmd.ExecuteNonQuery()
        DbConnection.CloseConnection()
        Return result
    End Function

    Public Function update(code As String, name As String, address As String, phone As String,
                       email As String, pic As String, id As Integer) As Integer
        query = "UPDATE vendor SET code = @code, name = @name, address = @address, "
        query = query & "phone = @phone, email = @email, pic_name = @pic " 'update on hapus'
        query = query & "WHERE id = @id"

        npgsqlConn = DbConnection.OpenConnection() 'tambah'
        cmd = New NpgsqlCommand(query, npgsqlConn)
        cmd.Parameters.AddWithValue("@code", code)
        cmd.Parameters.AddWithValue("@name", name)
        cmd.Parameters.AddWithValue("@address", address)
        cmd.Parameters.AddWithValue("@phone", phone)
        cmd.Parameters.AddWithValue("@email", email)
        cmd.Parameters.AddWithValue("@pic", pic)
        'update on di hapus'
        cmd.Parameters.AddWithValue("@id", id)
        Dim result As Integer
        result = cmd.ExecuteNonQuery()
        DbConnection.CloseConnection()
        Return result
    End Function

    Public Function delete(id As Integer) As Integer
        query = "UPDATE vendor SET isdelete = @flagYes "
        query = query & "WHERE id = @id"
        npgsqlConn = DbConnection.OpenConnection()
        cmd = New NpgsqlCommand(query, npgsqlConn)
        cmd.Parameters.AddWithValue("@flagYes", 1)
        cmd.Parameters.AddWithValue("@id", id)
        Dim result As Integer
        result = cmd.ExecuteNonQuery()
        DbConnection.CloseConnection()
        Return result
    End Function

    Public Sub clearConnection(activeRs As NpgsqlDataReader)
        If activeRs.IsClosed = False Then
            activeRs.Close()
        End If
        DbConnection.CloseConnection()
    End Sub
End Class
