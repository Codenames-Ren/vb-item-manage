Imports Npgsql

Public Class PosDao
    Dim npgsqlConn As NpgsqlConnection
    Dim cmd As NpgsqlCommand
    Dim rs As NpgsqlDataReader
    Dim adp As NpgsqlDataAdapter
    Dim query As String
    Dim result As Integer

    Public Function loadData() As DataTable
        query = "select * from positions p where p.isDelete is null"
        npgsqlConn = DbConnection.OpenConnection
        cmd = New NpgsqlCommand(query, npgsqlConn)
        adp = New NpgsqlDataAdapter(cmd)
        Dim table As New DataTable()
        adp.Fill(table)

        Return table

    End Function

    Public Function getIdByCode(code As String) As Integer
        npgsqlConn = DbConnection.OpenConnection()
        query = "SELECT v.id from positions v where v.code = @code"
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
        query = "select code from positions where isdelete is null"
        cmd = New NpgsqlCommand(query, npgsqlConn)
        rs = cmd.ExecuteReader()
        Return rs
    End Function

    Public Function getObjectByCode(code As String) As NpgsqlDataReader
        npgsqlConn = DbConnection.OpenConnection()
        query = "SELECT x.name, x.description, x.max_capacity, x.filled " &
        "from positions x where x.code = @code and isdelete is null"
        cmd = New NpgsqlCommand(query, npgsqlConn)
        cmd.Parameters.AddWithValue("@code", code)
        rs = cmd.ExecuteReader()
        Return rs
    End Function

    Public Sub clearConnection(activeRs As NpgsqlDataReader)
        If activeRs.IsClosed = False Then
            activeRs.Close()
        End If
        DbConnection.CloseConnection()
    End Sub

    Public Function insert(code As String, name As String, description As String,
                           max_capacity As Double, filled As Double) As Integer
        npgsqlConn = DbConnection.OpenConnection()
        query = "INSERT INTO positions (code, name, description, max_capacity, filled, updated_on)"
        query = query & "VALUES (@code, @name, @description, @max_capacity, @filled, NOW())"
        cmd = New NpgsqlCommand(query, npgsqlConn)
        cmd.Parameters.AddWithValue("@code", code)
        cmd.Parameters.AddWithValue("@name", name)
        cmd.Parameters.AddWithValue("@description", description)
        cmd.Parameters.AddWithValue("@max_capacity", max_capacity)
        cmd.Parameters.AddWithValue("@filled", filled)
        result = cmd.ExecuteNonQuery()
        DbConnection.CloseConnection()

        Return result
    End Function

    Public Function update(code As String, name As String, description As String,
                           max_capacity As Double, filled As Double, id As Double) As Integer
        npgsqlConn = DbConnection.OpenConnection()
        query = "UPDATE positions SET code = @code, name = @name, description = @description, max_capacity = @max_capacity, filled = @filled,"
        query = query & "updated_on = @updated_on WHERE id = @id"
        cmd = New NpgsqlCommand(query, npgsqlConn)
        cmd.Parameters.AddWithValue("@code", code)
        cmd.Parameters.AddWithValue("@name", name)
        cmd.Parameters.AddWithValue("@description", description)
        cmd.Parameters.AddWithValue("@max_capacity", max_capacity)
        cmd.Parameters.AddWithValue("@filled", filled)
        cmd.Parameters.AddWithValue("@updated_on", DateTime.Now)
        cmd.Parameters.AddWithValue("@id", id)
        result = cmd.ExecuteNonQuery()
        DbConnection.CloseConnection()
        Return result
    End Function

    Public Function delete(id As Integer) As Integer
        npgsqlConn = DbConnection.OpenConnection()
        query = "UPDATE positions SET isDelete = @flagYes. updated_on = @updated_on WHERE id = @id"
        cmd = New NpgsqlCommand(query, npgsqlConn)
        cmd.Parameters.AddWithValue("@flagYes", 1)
        cmd.Parameters.AddWithValue("@updated_on", DateTime.Now)
        cmd.Parameters.AddWithValue("@id", id)
        result = cmd.ExecuteNonQuery()
        DbConnection.CloseConnection()
        Return result
    End Function
End Class
