<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SampleAlgorithmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PositionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecapitulationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EntityToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VendorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelTitle = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelContent = New System.Windows.Forms.Panel()
        Me.lblQotd = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        Me.PanelTitle.SuspendLayout()
        Me.PanelContent.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ManageToolStripMenuItem, Me.EntityToolStripMenuItem, Me.ReportToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1201, 31)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SampleAlgorithmToolStripMenuItem})
        Me.FileToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(49, 27)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'SampleAlgorithmToolStripMenuItem
        '
        Me.SampleAlgorithmToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SampleAlgorithmToolStripMenuItem.Name = "SampleAlgorithmToolStripMenuItem"
        Me.SampleAlgorithmToolStripMenuItem.Size = New System.Drawing.Size(231, 28)
        Me.SampleAlgorithmToolStripMenuItem.Text = "Sample Algorithm"
        '
        'ManageToolStripMenuItem
        '
        Me.ManageToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ItemToolStripMenuItem, Me.PositionToolStripMenuItem, Me.RecapitulationToolStripMenuItem})
        Me.ManageToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ManageToolStripMenuItem.Name = "ManageToolStripMenuItem"
        Me.ManageToolStripMenuItem.Size = New System.Drawing.Size(86, 27)
        Me.ManageToolStripMenuItem.Text = "Manage"
        '
        'ItemToolStripMenuItem
        '
        Me.ItemToolStripMenuItem.Name = "ItemToolStripMenuItem"
        Me.ItemToolStripMenuItem.Size = New System.Drawing.Size(224, 28)
        Me.ItemToolStripMenuItem.Text = "Item"
        '
        'PositionToolStripMenuItem
        '
        Me.PositionToolStripMenuItem.Name = "PositionToolStripMenuItem"
        Me.PositionToolStripMenuItem.Size = New System.Drawing.Size(224, 28)
        Me.PositionToolStripMenuItem.Text = "Position"
        '
        'RecapitulationToolStripMenuItem
        '
        Me.RecapitulationToolStripMenuItem.Name = "RecapitulationToolStripMenuItem"
        Me.RecapitulationToolStripMenuItem.Size = New System.Drawing.Size(224, 28)
        Me.RecapitulationToolStripMenuItem.Text = "Recapitulation"
        '
        'EntityToolStripMenuItem
        '
        Me.EntityToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VendorToolStripMenuItem, Me.CustomerToolStripMenuItem})
        Me.EntityToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EntityToolStripMenuItem.Name = "EntityToolStripMenuItem"
        Me.EntityToolStripMenuItem.Size = New System.Drawing.Size(67, 27)
        Me.EntityToolStripMenuItem.Text = "Entity"
        '
        'VendorToolStripMenuItem
        '
        Me.VendorToolStripMenuItem.Name = "VendorToolStripMenuItem"
        Me.VendorToolStripMenuItem.Size = New System.Drawing.Size(168, 28)
        Me.VendorToolStripMenuItem.Text = "Vendor"
        '
        'CustomerToolStripMenuItem
        '
        Me.CustomerToolStripMenuItem.Name = "CustomerToolStripMenuItem"
        Me.CustomerToolStripMenuItem.Size = New System.Drawing.Size(168, 28)
        Me.CustomerToolStripMenuItem.Text = "Customer"
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(75, 27)
        Me.ReportToolStripMenuItem.Text = "Report"
        '
        'PanelTitle
        '
        Me.PanelTitle.Controls.Add(Me.Label1)
        Me.PanelTitle.Location = New System.Drawing.Point(12, 51)
        Me.PanelTitle.Name = "PanelTitle"
        Me.PanelTitle.Size = New System.Drawing.Size(1174, 67)
        Me.PanelTitle.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(276, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(218, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Item Management"
        '
        'PanelContent
        '
        Me.PanelContent.Controls.Add(Me.lblQotd)
        Me.PanelContent.Controls.Add(Me.PictureBox1)
        Me.PanelContent.Location = New System.Drawing.Point(12, 124)
        Me.PanelContent.Name = "PanelContent"
        Me.PanelContent.Size = New System.Drawing.Size(1174, 650)
        Me.PanelContent.TabIndex = 2
        '
        'lblQotd
        '
        Me.lblQotd.AutoSize = True
        Me.lblQotd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQotd.Location = New System.Drawing.Point(712, 16)
        Me.lblQotd.Name = "lblQotd"
        Me.lblQotd.Size = New System.Drawing.Size(71, 25)
        Me.lblQotd.TabIndex = 1
        Me.lblQotd.Text = "Label2"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(25, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(658, 366)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1201, 788)
        Me.Controls.Add(Me.PanelContent)
        Me.Controls.Add(Me.PanelTitle)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.Text = "VB 1124160034"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.PanelTitle.ResumeLayout(False)
        Me.PanelTitle.PerformLayout()
        Me.PanelContent.ResumeLayout(False)
        Me.PanelContent.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EntityToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SampleAlgorithmToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ItemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PositionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RecapitulationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VendorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PanelTitle As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PanelContent As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblQotd As Label
End Class
