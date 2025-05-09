Public Class VendorControl
    Private Sub loadData()
        Try
            Dim vendorDao As New VendorDao() 'Memanggil Database'
            Dim table As DataTable = vendorDao.loadAllData() 'Memuat semua data'
            DataGridVendor.DataSource = table 'Tempel ke Desain'
            DataGridVendor.Columns("id").Visible = False 'Menyembunyikan id'
            DataGridVendor.Columns("isdelete").Visible = False
        Catch ex As Exception
            MessageBox.Show("Gagal Mengambil Data: " & ex.Message)
        End Try
    End Sub

    Private Sub refreshForm()
        Dim vendorDao As New VendorDao()
        Dim data As DataTable = vendorDao.loadAllData()

        If DataGridVendor IsNot Nothing Then
            DataGridVendor.DataSource = data
        End If

        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is TextBox Then
                DirectCast(ctrl, TextBox).Clear()
            End If
        Next
    End Sub
    Private Sub VendorControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData()
    End Sub

    Private Sub btnAddVendor_Click(sender As Object, e As EventArgs) Handles btnAddVendor.Click
        VendorForm.Show()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        refreshForm()
        MessageBox.Show("Form Refreshed!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub DataGridVendor_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridVendor.CellClick
        If e.RowIndex >= 0 Then 'menampilkan baris index ketika di klik'
            Dim row As DataGridViewRow = DataGridVendor.Rows(e.RowIndex) 'Ambil 1 baris utuh dari data grid'
            Dim vendorForm As New VendorForm() 'Summon form yang akan di populate dan memasukannya 1 per 1 ke component'
            vendorForm.txtAddress.Text = row.Cells("address").Value.ToString()
            vendorForm.txtCode.Text = row.Cells("code").Value.ToString()
            vendorForm.txtEmail.Text = row.Cells("email").Value.ToString()
            vendorForm.TxtId.Text = row.Cells("id").Value.ToString()
            vendorForm.txtName.Text = row.Cells("name").Value.ToString()
            vendorForm.txtPhone.Text = row.Cells("phone").Value.ToString()
            vendorForm.txtPic.Text = row.Cells("pic_name").Value.ToString()
            vendorForm.Show() 'menampilkan form yang sudah terpopulate'

        End If
    End Sub
End Class
