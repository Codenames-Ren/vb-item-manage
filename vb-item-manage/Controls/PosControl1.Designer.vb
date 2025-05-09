<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PosControl1
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
        Me.DataGridPos = New System.Windows.Forms.DataGridView()
        Me.btnAddPos = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnRefresh = New System.Windows.Forms.Button()
        CType(Me.DataGridPos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridPos
        '
        Me.DataGridPos.AllowUserToAddRows = False
        Me.DataGridPos.AllowUserToDeleteRows = False
        Me.DataGridPos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridPos.Location = New System.Drawing.Point(36, 115)
        Me.DataGridPos.Name = "DataGridPos"
        Me.DataGridPos.ReadOnly = True
        Me.DataGridPos.RowHeadersWidth = 51
        Me.DataGridPos.RowTemplate.Height = 24
        Me.DataGridPos.Size = New System.Drawing.Size(1074, 391)
        Me.DataGridPos.TabIndex = 5
        '
        'btnAddPos
        '
        Me.btnAddPos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddPos.Location = New System.Drawing.Point(717, 41)
        Me.btnAddPos.Name = "btnAddPos"
        Me.btnAddPos.Size = New System.Drawing.Size(174, 56)
        Me.btnAddPos.TabIndex = 4
        Me.btnAddPos.Text = "Add New"
        Me.btnAddPos.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(39, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(221, 36)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Master Position"
        '
        'btnRefresh
        '
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Location = New System.Drawing.Point(935, 41)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(174, 56)
        Me.btnRefresh.TabIndex = 6
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'PosControl1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.DataGridPos)
        Me.Controls.Add(Me.btnAddPos)
        Me.Controls.Add(Me.Label1)
        Me.Name = "PosControl1"
        Me.Size = New System.Drawing.Size(1168, 536)
        CType(Me.DataGridPos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridPos As DataGridView
    Friend WithEvents btnAddPos As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnRefresh As Button
End Class
