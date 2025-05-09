Imports Npgsql

Public Class DbConnection
    Private Shared host As String = "Host=localhost;Port=5432;"
    Private Shared credentials As String = "Username=postgres;Password=945313;"
    Private Shared dbDetail As String = "Database=vb_item_management"
    Private Shared endpoint As String = host & credentials & dbDetail
    Private Shared connectionDB As NpgsqlConnection

    'Fungsi untuk membuka koneksi

    Public Shared Function OpenConnection() As NpgsqlConnection
        Try
            connectionDB = New NpgsqlConnection(endpoint)
            connectionDB.Open()
            Return connectionDB
        Catch ex As Exception
            MessageBox.Show("Koneksi gagal: " & ex.Message)
            Return Nothing

        End Try
    End Function

    'Fungsi untuk menutup koneksi
    Public Shared Sub CloseConnection()
        If connectionDB IsNot Nothing AndAlso connectionDB.State = ConnectionState.Open Then
            connectionDB.Close()
        End If
    End Sub
End Class

