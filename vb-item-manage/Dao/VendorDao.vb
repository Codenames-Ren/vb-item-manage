Imports Npgsql

Public Class VendorDao
    Dim npgsqlConn As NpgsqlConnection
    Dim cmd As NpgsqlCommand
    Dim rs As NpgsqlDataReader
    Dim adp As NpgsqlDataAdapter
    Dim query As String

    Public Function loadAllData() As DataTable
        query = "select * from vendor v where v.isDelete is null " 'query database'
        npgsqlConn = DbConnection.OpenConnection 'Membuka Koneksi ke Database'
        cmd = New NpgsqlCommand(query, npgsqlConn) 'Eksekusi Query berdasarkan koneksi'
        adp = New NpgsqlDataAdapter(cmd) 'Mengambil data hasil query'
        Dim table As New DataTable() 'definisi tabel penampungan'
        adp.Fill(table) 'data ditampung di tabel'

        Return table
    End Function

    Public Function insert(code As String, name As String, address As String,
                           phone As String, email As String, pic As String) As Integer 'Passing Value'
        npgsqlConn = DbConnection.OpenConnection()
        query = "INSERT INTO vendor (code, name, address, phone, email, pic_name) "
        query = query & " VALUES (@code, @name, @address, @phone, @email, @pic) " 'query untuk insert'
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

    Public Function update(code As String, name As String, address As String,
                           phone As String, email As String, pic As String, id As Integer) As Integer
        query = "UPDATE vendor SET code = @code, name = @name, address = @address, "
        query = query & "phone = @phone, email = @email, pic_name = @pic "
        query = query & "WHERE id = @id"

        npgsqlConn = DbConnection.OpenConnection()
        cmd = New NpgsqlCommand(query, npgsqlConn)
        cmd.Parameters.AddWithValue("@code", code)
        cmd.Parameters.AddWithValue("@name", name)
        cmd.Parameters.AddWithValue("@address", address)
        cmd.Parameters.AddWithValue("@phone", phone)
        cmd.Parameters.AddWithValue("@email", email)
        cmd.Parameters.AddWithValue("@pic", pic)
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
End Class
