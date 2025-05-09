<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VendorControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.DataGridVendor = New System.Windows.Forms.DataGridView()
        Me.btnAddVendor = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnRefresh = New System.Windows.Forms.Button()
        CType(Me.DataGridVendor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridVendor
        '
        Me.DataGridVendor.AllowUserToAddRows = False
        Me.DataGridVendor.AllowUserToDeleteRows = False
        Me.DataGridVendor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridVendor.Location = New System.Drawing.Point(49, 118)
        Me.DataGridVendor.Name = "DataGridVendor"
        Me.DataGridVendor.ReadOnly = True
        Me.DataGridVendor.RowHeadersWidth = 51
        Me.DataGridVendor.RowTemplate.Height = 24
        Me.DataGridVendor.Size = New System.Drawing.Size(936, 401)
        Me.DataGridVendor.TabIndex = 5
        '
        'btnAddVendor
        '
        Me.btnAddVendor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddVendor.Location = New System.Drawing.Point(583, 42)
        Me.btnAddVendor.Name = "btnAddVendor"
        Me.btnAddVendor.Size = New System.Drawing.Size(174, 56)
        Me.btnAddVendor.TabIndex = 4
        Me.btnAddVendor.Text = "Add New"
        Me.btnAddVendor.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(59, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(211, 36)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Master Vendor"
        '
        'btnRefresh
        '
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Location = New System.Drawing.Point(811, 42)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(174, 56)
        Me.btnRefresh.TabIndex = 7
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'VendorControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.DataGridVendor)
        Me.Controls.Add(Me.btnAddVendor)
        Me.Controls.Add(Me.Label1)
        Me.Name = "VendorControl"
        Me.Size = New System.Drawing.Size(1042, 564)
        CType(Me.DataGridVendor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridVendor As DataGridView
    Friend WithEvents btnAddVendor As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnRefresh As Button
End Class
