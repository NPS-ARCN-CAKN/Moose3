<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImportGSPEForm
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
        Me.GSPEDataGridView = New System.Windows.Forms.DataGridView()
        CType(Me.GSPEDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GSPEDataGridView
        '
        Me.GSPEDataGridView.AllowUserToAddRows = False
        Me.GSPEDataGridView.AllowUserToDeleteRows = False
        Me.GSPEDataGridView.AllowUserToOrderColumns = True
        Me.GSPEDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GSPEDataGridView.Dock = System.Windows.Forms.DockStyle.Top
        Me.GSPEDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.GSPEDataGridView.Name = "GSPEDataGridView"
        Me.GSPEDataGridView.ReadOnly = True
        Me.GSPEDataGridView.Size = New System.Drawing.Size(800, 150)
        Me.GSPEDataGridView.TabIndex = 0
        '
        'ImportGSPEForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GSPEDataGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "ImportGSPEForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "ImportGSPEForm"
        CType(Me.GSPEDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GSPEDataGridView As DataGridView
End Class
