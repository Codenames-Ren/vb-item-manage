Imports Npgsql

Public Class ItemForm

    Public Sub LoadPos()
        Dim posDao As New PosDao()
        Dim rs As NpgsqlDataReader = posDao.getAllCode()
        While rs.Read()
            comboPos.Items.Add(rs.GetString(0))
        End While
        posDao.clearConnection(rs)

        comboPos.SelectedText = "Choose"
    End Sub

    Public Sub populatePos()
        Dim PosCode As String = comboPos.SelectedItem.ToString
        Dim posDao As New PosDao()
        Dim rs As NpgsqlDataReader = posDao.getObjectByCode(PosCode)
        While rs.Read()
            txtDetailPos.Text = rs.GetString(0) & Environment.NewLine & rs.GetString(1) & Environment.NewLine
            txtDetailPos.Text = txtDetailPos.Text & "Max: " & rs.GetDouble(2) & Environment.NewLine
            txtDetailPos.Text = txtDetailPos.Text & "Filled: " & rs.GetDouble(3)
            Exit While
        End While
        posDao.clearConnection(rs)
    End Sub

    Private Sub ItemForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPos()

    End Sub

    Private Sub comboPos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboPos.SelectedIndexChanged
        populatePos()
    End Sub
End Class