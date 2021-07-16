<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DataShaperForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.QuerySelectorToolStripComboBox = New System.Windows.Forms.ToolStripComboBox()
        Me.DataShaperPivotGridControl = New DevExpress.XtraPivotGrid.PivotGridControl()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.DatasetXtraTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.DataShaperGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.PivotXtraTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DataShaperPivotGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.DatasetXtraTabPage.SuspendLayout()
        CType(Me.DataShaperGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PivotXtraTabPage.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.QuerySelectorToolStripComboBox})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1184, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(152, 22)
        Me.ToolStripLabel1.Text = "Select a data table or query:"
        '
        'QuerySelectorToolStripComboBox
        '
        Me.QuerySelectorToolStripComboBox.Name = "QuerySelectorToolStripComboBox"
        Me.QuerySelectorToolStripComboBox.Size = New System.Drawing.Size(400, 25)
        '
        'DataShaperPivotGridControl
        '
        Me.DataShaperPivotGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataShaperPivotGridControl.Location = New System.Drawing.Point(0, 0)
        Me.DataShaperPivotGridControl.Name = "DataShaperPivotGridControl"
        Me.DataShaperPivotGridControl.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized
        Me.DataShaperPivotGridControl.Size = New System.Drawing.Size(1182, 711)
        Me.DataShaperPivotGridControl.TabIndex = 1
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 25)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.DatasetXtraTabPage
        Me.XtraTabControl1.Size = New System.Drawing.Size(1184, 736)
        Me.XtraTabControl1.TabIndex = 2
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.DatasetXtraTabPage, Me.PivotXtraTabPage})
        '
        'DatasetXtraTabPage
        '
        Me.DatasetXtraTabPage.Controls.Add(Me.DataShaperGridControl)
        Me.DatasetXtraTabPage.Name = "DatasetXtraTabPage"
        Me.DatasetXtraTabPage.Size = New System.Drawing.Size(1182, 711)
        Me.DatasetXtraTabPage.Text = "Dataset"
        '
        'DataShaperGridControl
        '
        Me.DataShaperGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataShaperGridControl.Location = New System.Drawing.Point(0, 0)
        Me.DataShaperGridControl.MainView = Me.GridView1
        Me.DataShaperGridControl.Name = "DataShaperGridControl"
        Me.DataShaperGridControl.Size = New System.Drawing.Size(1182, 711)
        Me.DataShaperGridControl.TabIndex = 0
        Me.DataShaperGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.DataShaperGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'PivotXtraTabPage
        '
        Me.PivotXtraTabPage.Controls.Add(Me.DataShaperPivotGridControl)
        Me.PivotXtraTabPage.Name = "PivotXtraTabPage"
        Me.PivotXtraTabPage.Size = New System.Drawing.Size(1182, 711)
        Me.PivotXtraTabPage.Text = "Pivot grid"
        '
        'DataShaperForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 761)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "DataShaperForm"
        Me.Text = "GSPE Data Shaper"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DataShaperPivotGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.DatasetXtraTabPage.ResumeLayout(False)
        CType(Me.DataShaperGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PivotXtraTabPage.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents QuerySelectorToolStripComboBox As ToolStripComboBox
    Friend WithEvents DataShaperPivotGridControl As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents DatasetXtraTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents PivotXtraTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents DataShaperGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
End Class
