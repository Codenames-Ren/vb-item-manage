Imports System.Net

Public Class VendorForm
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Try
            Dim vendorDao As New VendorDao
            Dim code As String = txtCode.Text
            Dim name As String = txtName.Text
            Dim address As String = txtAddress.Text
            Dim phone As String = txtPhone.Text
            Dim email As String = txtEmail.Text
            Dim pic As String = txtPic.Text

            If String.IsNullOrEmpty(TxtId.Text) Then
                vendorDao.insert(code, name, address, phone, email, pic)
                MessageBox.Show("Data has been saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim id As String = TxtId.Text
                vendorDao.update(code, name, address, phone, email, pic, CInt(id))
                MessageBox.Show("Data has been updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If


            For Each ctrl As Control In Me.Controls
                If TypeOf ctrl Is TextBox Then
                    DirectCast(ctrl, TextBox).Clear()
                End If
            Next
            Me.Close()

        Catch x As Exception
            MessageBox.Show("Failed to Insert: " & x.Message)
        End Try

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim vendorDao As New VendorDao
        If String.IsNullOrEmpty(TxtId.Text) Then
            MessageBox.Show("Data is not exist!", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim id As String = TxtId.Text
            vendorDao.delete(CInt(id))
            MessageBox.Show("Data has been DELETE successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Hide()
        End If
    End Sub

    Private Sub VendorForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If String.IsNullOrEmpty(TxtId.Text) Then
            btnDelete.Hide()
        Else
            btnDelete.Show()
        End If
    End Sub
End Class