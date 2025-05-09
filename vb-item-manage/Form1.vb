Public Class MainForm
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblQotd.Text = "Jangan mudah menyerah hanya karena" & Environment.NewLine
        lblQotd.Text = lblQotd.Text & "1 kegagalan." & Environment.NewLine
        lblQotd.Text = lblQotd.Text & "Karena masih banyak kegagalan lain" & Environment.NewLine
        lblQotd.Text = lblQotd.Text & "yang belum kamu coba."
    End Sub

    Private Sub SampleAlgorithmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SampleAlgorithmToolStripMenuItem.Click
        LoadMenu(New AlgorithmControl)
    End Sub

    Private Sub LoadMenu(control As UserControl) 'Function baru'
        PanelContent.Controls.Clear() 'Membersihkan Panel Content'
        control.Dock = DockStyle.Fill 'Pengisian panel dengan model'
        PanelContent.Controls.Add(control) 'Menempel panel yang akan ditampilkan'
    End Sub

    Private Sub ItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ItemToolStripMenuItem.Click
        LoadMenu(New ItemControl)
    End Sub

    Private Sub VendorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VendorToolStripMenuItem.Click
        LoadMenu(New VendorControl)
    End Sub

    Private Sub PositionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PositionToolStripMenuItem.Click
        LoadMenu(New PosControl1)
    End Sub

    Private Sub ManageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageToolStripMenuItem.Click

    End Sub
End Class
