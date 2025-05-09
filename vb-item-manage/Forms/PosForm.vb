Public Class PosForm
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Try
            Dim posDao As New PosDao
            Dim code As String = txtCode.Text
            Dim name As String = txtName.Text
            Dim description As String = txtDescription.Text
            Dim max_capacity As Double = CDbl(txtMax.Text)
            Dim filled As Double = CDbl(txtFilled.Text)
            posDao.insert(code, name, description, max_capacity, filled)

            MessageBox.Show("Data has been saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            For Each ctrl As Control In Me.Controls
                If TypeOf ctrl Is TextBox Then
                    DirectCast(ctrl, TextBox).Clear()
                End If
            Next
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Failed to insert! " & ex.Message)
        End Try
    End Sub

    Private Sub txtMax_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMax.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar = "." AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("Please input numeric!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub txtFilled_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFilled.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar = "." AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("Please input numeric!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub PosForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If String.IsNullOrEmpty(txtId.Text) Then
            btnDelete.Hide()
        Else
            btnDelete.Show()
        End If
    End Sub

    Private Sub txtId_TextChanged(sender As Object, e As EventArgs) Handles txtId.TextChanged

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            Dim posDao As New PosDao()
            If txtId.Text IsNot "" Then
                posDao.delete(CInt(txtId.Text))
                MessageBox.Show("Data berhasil dihapus!")
            Else
                MessageBox.Show("Pilih data dahulu!")
            End If

        Catch ex As Exception

        End Try
    End Sub
End Class