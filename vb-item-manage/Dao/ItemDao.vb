Imports Npgsql

Public Class ItemDao
    Dim connectionDb As NpgsqlConnection
    Dim query As String
    Dim cmd As NpgsqlCommand
    Dim adapter As NpgsqlDataAdapter
    Dim rs As NpgsqlDataReader
    Dim result As Integer

    Public Function loadAllData() As DataTable
        Dim table As New DataTable()
        Try
            connectionDb = DbConnection.OpenConnection()
            query = "select i.id, id.id as iddtl, i.code, i.name , id.price, (select p.code || ' | ' || p.name from positions p where p.id = id.id_position) as position, (select v.code || ' | ' || v.name from vendors v where v.id = id.id_vendor) as vendor, id.stock, i.measurement from items_detail id left join items i on i.id = id.id_item left join vendors v on id.id_position = v.id left join positions p on id.id_position = p.id "
            cmd = New NpgsqlCommand(query, connectionDb)
            adapter = New NpgsqlDataAdapter(cmd)
            adapter.Fill(table)
            Return table
        Catch ex As Exception
            MessageBox.Show("Gagal mengambil data: " & ex.Message)
            Return table
        End Try
    End Function

    Public Function getIdByCode(code As String) As Integer
        Dim idItem As Integer
        connectionDb = DbConnection.OpenConnection()
        query = "SELECT v.id from items v where v.code = @code"
        cmd = New NpgsqlCommand(query, connectionDb)
        cmd.Parameters.AddWithValue("@code", code)
        rs = cmd.ExecuteReader()
        While rs.Read()
            idItem = rs.GetInt32(0)
            Exit While
        End While
        clearConnection(rs)
        Return idItem
    End Function

    Public Function getAllCode() As NpgsqlDataReader
        connectionDb = DbConnection.OpenConnection()
        query = "select code from items"
        cmd = New NpgsqlCommand(query, connectionDb)
        rs = cmd.ExecuteReader()
        Return rs
    End Function

    Public Function insert(code As String, name As String, measurement As String) As Integer
        connectionDb = DbConnection.OpenConnection()
        query = "INSERT INTO items (code, name, measurement) VALUES (@code, @name, @measurement)"
        cmd = New NpgsqlCommand(query, connectionDb)
        cmd.Parameters.AddWithValue("@code", code)
        cmd.Parameters.AddWithValue("@name", name)
        cmd.Parameters.AddWithValue("@measurement", measurement)
        result = cmd.ExecuteNonQuery()
        DbConnection.CloseConnection()
        Return result
    End Function

    Public Function update(code As String, name As String, measurement As String, id As Integer) As Integer
        connectionDb = DbConnection.OpenConnection()
        query = "UPDATE items SET code = @code, name = @name, measurement = @measurement WHERE id = @id"
        cmd = New NpgsqlCommand(query, connectionDb)
        cmd.Parameters.AddWithValue("@code", code)
        cmd.Parameters.AddWithValue("@name", name)
        cmd.Parameters.AddWithValue("@measurement", measurement)
        cmd.Parameters.AddWithValue("@id", id)
        result = cmd.ExecuteNonQuery()
        DbConnection.CloseConnection()
        Return result
    End Function

    Public Function getMaxId() As NpgsqlDataReader
        connectionDb = DbConnection.OpenConnection()
        query = "SELECT COALESCE(max(id),0) from items"
        cmd = New NpgsqlCommand(query, connectionDb)
        rs = cmd.ExecuteReader()
        Return rs
    End Function

    Public Sub clearConnection(activeRs As NpgsqlDataReader)
        If activeRs.IsClosed = False Then
            activeRs.Close()
        End If
        DbConnection.CloseConnection()
    End Sub

    Friend Sub insertDetail(id_item As Integer, posId As Integer, vendorId As Integer, price As Double, stock As Double)
        connectionDb = DbConnection.OpenConnection()
        query = "INSERT INTO items_detail (id_item, id_position, id_vendor, price, stock, updated_on) values (@id_item, @id_position, @id_vendor, @price, @stock, @updated_on)"
        cmd = New NpgsqlCommand(query, connectionDb)
        cmd.Parameters.AddWithValue("@id_item", id_item)
        cmd.Parameters.AddWithValue("@id_position", posId)
        cmd.Parameters.AddWithValue("@id_vendor", vendorId)
        cmd.Parameters.AddWithValue("@price", price)
        cmd.Parameters.AddWithValue("@stock", stock)
        cmd.Parameters.AddWithValue("@updated_on", DateTime.Now)
        cmd.ExecuteNonQuery()
        DbConnection.CloseConnection()
    End Sub

    Friend Sub updateDetail(posId As Integer, vendorId As Integer, price As Double, stock As Double, id As Integer, idDtl As Integer)
        connectionDb = DbConnection.OpenConnection()
        query = "UPDATE items_detail SET id_position = @id_position, id_vendor = @id_vendor, price = @price, stock = @stock, updated_on = @updated_on, id_item = @id where id = @iddtl"
        cmd = New NpgsqlCommand(query, connectionDb)
        cmd.Parameters.AddWithValue("@id_position", posId)
        cmd.Parameters.AddWithValue("@id_vendor", vendorId)
        cmd.Parameters.AddWithValue("@price", price)
        cmd.Parameters.AddWithValue("@stock", stock)
        cmd.Parameters.AddWithValue("@updated_on", DateTime.Now)
        cmd.Parameters.AddWithValue("@id_item", id)
        cmd.Parameters.AddWithValue("@iddtl", idDtl)
        cmd.ExecuteNonQuery()
        DbConnection.CloseConnection()
    End Sub

    Friend Function getAllCodeDetail() As NpgsqlDataReader
        Try
            connectionDb = DbConnection.OpenConnection()
            query = "select i.code, id.id, v.code from items_detail id left join items i on i.id = id.id_item left join vendors v on id.id_vendor = v.id"
            cmd = New NpgsqlCommand(query, connectionDb)
            rs = cmd.ExecuteReader()
            Return rs
        Catch ex As Exception
            MessageBox.Show("Gagal mengambil data: " & ex.Message)
            Return rs
        End Try
    End Function

    Friend Function getDetailForRecap(codeItem As String, codeVendor As String) As NpgsqlDataReader
        Try
            connectionDb = DbConnection.OpenConnection()
            query = "select i.code, i.name, id.price, id.stock, v.code as vcode, v.name as vname, p.code as pcode, p.name as pname from items_detail id left join items i on i.id = id.id_item left join vendors v on id.id_vendor = v.id left join positions p on id.id_position = p.id where v.code = @codeVendor and i.code = @codeItem"
            cmd = New NpgsqlCommand(query, connectionDb)
            cmd.Parameters.AddWithValue("@codeVendor", codeVendor)
            cmd.Parameters.AddWithValue("@codeItem", codeItem)
            rs = cmd.ExecuteReader()
            Return rs
        Catch ex As Exception
            MessageBox.Show("Gagal mengambil data: " & ex.Message)
            Return rs
        End Try
    End Function

    Friend Sub updateStock(codeItem As String, codeVendor As String, updatedStock As Double)
        Dim idDtl As Integer = getIdDetailByCodes(codeItem, codeVendor)
        connectionDb = DbConnection.OpenConnection()
        query = "UPDATE items_detail SET stock = @stock, updated_on = @updated_on where id = @iddtl"
        cmd = New NpgsqlCommand(query, connectionDb)
        cmd.Parameters.AddWithValue("@stock", updatedStock)
        cmd.Parameters.AddWithValue("@updated_on", DateTime.Now)
        cmd.Parameters.AddWithValue("@iddtl", idDtl)
        cmd.ExecuteNonQuery()
        DbConnection.CloseConnection()
    End Sub

    Friend Function getIdDetailByCodes(codeItem As String, codeVendor As String) As Integer
        Dim idDtl As Integer
        connectionDb = DbConnection.OpenConnection()
        query = "select id.id from items_detail id left join items i on i.id = id.id_item left join vendors v on v.id = id.id_vendor where i.code = @codeItem and v.code = @codeVendor"
        cmd = New NpgsqlCommand(query, connectionDb)
        cmd.Parameters.AddWithValue("@codeItem", codeItem)
        cmd.Parameters.AddWithValue("@codeVendor", codeVendor)
        rs = cmd.ExecuteReader()
        While rs.Read()
            idDtl = rs.GetInt32(0)
            Exit While
        End While
        clearConnection(rs)
        Return idDtl
    End Function
End Class