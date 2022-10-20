<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AboutForm
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
        Me.ApplicationPropertyGridControl = New DevExpress.XtraVerticalGrid.PropertyGridControl()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SettingsPropertyGridControl = New DevExpress.XtraVerticalGrid.PropertyGridControl()
        CType(Me.ApplicationPropertyGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SettingsPropertyGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ApplicationPropertyGridControl
        '
        Me.ApplicationPropertyGridControl.Cursor = System.Windows.Forms.Cursors.Default
        Me.ApplicationPropertyGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ApplicationPropertyGridControl.Location = New System.Drawing.Point(0, 0)
        Me.ApplicationPropertyGridControl.Name = "ApplicationPropertyGridControl"
        Me.ApplicationPropertyGridControl.OptionsView.AllowReadOnlyRowAppearance = DevExpress.Utils.DefaultBoolean.[True]
        Me.ApplicationPropertyGridControl.Size = New System.Drawing.Size(1044, 348)
        Me.ApplicationPropertyGridControl.TabIndex = 0
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.ApplicationPropertyGridControl)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SettingsPropertyGridControl)
        Me.SplitContainer1.Size = New System.Drawing.Size(835, 642)
        Me.SplitContainer1.SplitterDistance = 278
        Me.SplitContainer1.TabIndex = 1
        '
        'SettingsPropertyGridControl
        '
        Me.SettingsPropertyGridControl.Cursor = System.Windows.Forms.Cursors.Default
        Me.SettingsPropertyGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SettingsPropertyGridControl.Location = New System.Drawing.Point(0, 0)
        Me.SettingsPropertyGridControl.Name = "SettingsPropertyGridControl"
        Me.SettingsPropertyGridControl.OptionsView.AllowReadOnlyRowAppearance = DevExpress.Utils.DefaultBoolean.[True]
        Me.SettingsPropertyGridControl.Size = New System.Drawing.Size(1044, 450)
        Me.SettingsPropertyGridControl.TabIndex = 1
        '
        'AboutForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(835, 642)
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "AboutForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "About the Moose Monitoring Database Application"
        CType(Me.ApplicationPropertyGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.SettingsPropertyGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ApplicationPropertyGridControl As DevExpress.XtraVerticalGrid.PropertyGridControl
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents SettingsPropertyGridControl As DevExpress.XtraVerticalGrid.PropertyGridControl
End Class
