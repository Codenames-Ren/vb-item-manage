<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ItemControl
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAddItem = New System.Windows.Forms.Button()
        Me.DataGridItem = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Master Item"
        '
        'btnAddItem
        '
        Me.btnAddItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddItem.Location = New System.Drawing.Point(590, 27)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(174, 56)
        Me.btnAddItem.TabIndex = 1
        Me.btnAddItem.Text = "Add New"
        Me.btnAddItem.UseVisualStyleBackColor = True
        '
        'DataGridItem
        '
        Me.DataGridItem.AllowUserToAddRows = False
        Me.DataGridItem.AllowUserToDeleteRows = False
        Me.DataGridItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridItem.Location = New System.Drawing.Point(31, 112)
        Me.DataGridItem.Name = "DataGridItem"
        Me.DataGridItem.ReadOnly = True
        Me.DataGridItem.RowHeadersWidth = 51
        Me.DataGridItem.RowTemplate.Height = 24
        Me.DataGridItem.Size = New System.Drawing.Size(733, 354)
        Me.DataGridItem.TabIndex = 2
        '
        'ItemControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.DataGridItem)
        Me.Controls.Add(Me.btnAddItem)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ItemControl"
        Me.Size = New System.Drawing.Size(811, 542)
        CType(Me.DataGridItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnAddItem As Button
    Friend WithEvents DataGridItem As DataGridView
End Class
