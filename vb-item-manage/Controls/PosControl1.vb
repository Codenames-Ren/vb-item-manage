Imports System.ServiceModel

Public Class PosControl1

    Private Sub loadData()
        Try
            Dim posDao As New PosDao()
            Dim table As DataTable = posDao.loadData()
            DataGridPos.DataSource = table
            DataGridPos.Columns("id").Visible = False
        Catch ex As Exception
            MessageBox.Show("Gagal memuat data " & ex.Message)
        End Try
    End Sub

    Private Sub refreshForm()
        Dim posDao As New PosDao()
        Dim data As DataTable = posDao.loadData()

        If DataGridPos IsNot Nothing Then
            DataGridPos.DataSource = data
        End If

        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is TextBox Then
                DirectCast(ctrl, TextBox).Clear()
            End If
        Next
    End Sub
    Private Sub PosControl1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData()
    End Sub

    Private Sub btnAddPos_Click(sender As Object, e As EventArgs) Handles btnAddPos.Click
        PosForm.Show()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        refreshForm()
        MessageBox.Show("Form Refreshed!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub DataGridPos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridPos.CellClick
        If e.RowIndex >= 0 Then 'menampilkan baris index ketika di klik'
            Dim row As DataGridViewRow = DataGridPos.Rows(e.RowIndex) 'Ambil 1 baris utuh dari data grid'
            Dim posForm As New PosForm() 'Summon form yang akan di populate dan memasukannya 1 per 1 ke component'
            posForm.txtCode.Text = row.Cells("code").Value.ToString()
            posForm.txtName.Text = row.Cells("name").Value.ToString()
            posForm.txtDescription.Text = row.Cells("description").Value.ToString()
            posForm.txtMax.Text = row.Cells("max_capacity").Value.ToString()
            posForm.txtFilled.Text = row.Cells("filled").Value.ToString()
            posForm.txtId.Text = row.Cells("id").Value.ToString()
            posForm.Show() 'menampilkan form yang sudah terpopulate'
        End If
    End Sub
End Class
