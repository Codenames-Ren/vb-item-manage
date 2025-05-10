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

    'Load Vendor di item form'
    Public Sub LoadVendor()
        Dim vendorDao As New VendorDao()
        Dim rs As NpgsqlDataReader = vendorDao.getAllCode()
        While rs.Read()
            comboVendor.Items.Add(rs.GetString(0))
        End While
        vendorDao.clearConnection(rs)

        comboVendor.SelectedText = "Choose"
    End Sub

    Public Sub populateVendor()
        Dim VendorCode As String = comboVendor.SelectedItem.ToString
        Dim vendorDao As New VendorDao()
        Dim rs As NpgsqlDataReader = vendorDao.getObjectByCode(VendorCode)
        While rs.Read()
            TxtDetailVen.Text = "Name: " & rs.GetString(0) & Environment.NewLine
            TxtDetailVen.Text = TxtDetailVen.Text & "Address: " & rs.GetString(1) & Environment.NewLine
            TxtDetailVen.Text = TxtDetailVen.Text & "Phone: " & rs.GetString(2) & Environment.NewLine
            TxtDetailVen.Text = TxtDetailVen.Text & "Email: " & rs.GetString(3) & Environment.NewLine
            TxtDetailVen.Text = TxtDetailVen.Text & "PIC: " & rs.GetString(4)
            Exit While
        End While
        vendorDao.clearConnection(rs)
    End Sub
    Private Sub ItemForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPos()
        LoadVendor()
    End Sub

    Private Sub comboPos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboPos.SelectedIndexChanged
        populatePos()
    End Sub

    Private Sub comboVendor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboVendor.SelectedIndexChanged
        populateVendor()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        Dim code As String = txtCode.Text
        Dim measurement As String = comboMst.SelectedItem.ToString
        Dim posCode As String = comboPos.SelectedItem.ToString
        Dim vendorCode As String = comboVendor.SelectedItem.ToString
        Dim price As Integer = CInt(txtPrice.Text)
        Dim stock As Integer = CInt(txtStock.Text)

        If posCode = "Choose" Or vendorCode = "Choose" Then
            MessageBox.Show("Invalid Data!")
        Else
            Dim itemDao As New ItemDao()
            Dim posDao As New PosDao()
            Dim vendorDao As New VendorDao()
            Dim posId As Integer = posDao.getIdByCode(posCode)
            Dim vendorId As Integer = vendorDao.getIdByCode(vendorCode)

            If txtID.Text Is "" Then
                itemDao.insert(code, txtName.Text, measurement)
                Dim itemId As Integer = itemDao.getIdByCode(code)
                itemDao.insertDetail(itemId, posId, vendorId, price, stock)
            Else
                Dim id As Integer = CInt(txtID.Text)
                itemDao.update(code, txtName.Text, measurement, id)
                Dim detailId As Integer = itemDao.getIdDetailByCodes(code, vendorCode)
                itemDao.updateDetail(posId, vendorId, price, stock, id, detailId)
            End If
        End If
    End Sub
End Class