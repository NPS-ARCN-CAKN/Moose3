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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DataShaperForm))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.QuerySelectorToolStripComboBox = New System.Windows.Forms.ToolStripComboBox()
        Me.RefreshToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.DataShaperPivotGridControl = New DevExpress.XtraPivotGrid.PivotGridControl()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.DatasetXtraTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.DataShaperGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.DataShaperGridControlToolStrip = New System.Windows.Forms.ToolStrip()
        Me.ExportGridControlToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.PivotXtraTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DataShaperPivotGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.DatasetXtraTabPage.SuspendLayout()
        CType(Me.DataShaperGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataShaperGridControlToolStrip.SuspendLayout()
        Me.PivotXtraTabPage.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.QuerySelectorToolStripComboBox, Me.RefreshToolStripButton, Me.ToolStripSeparator1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1579, 28)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(195, 25)
        Me.ToolStripLabel1.Text = "Select a data table or query:"
        '
        'QuerySelectorToolStripComboBox
        '
        Me.QuerySelectorToolStripComboBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.QuerySelectorToolStripComboBox.Name = "QuerySelectorToolStripComboBox"
        Me.QuerySelectorToolStripComboBox.Size = New System.Drawing.Size(532, 28)
        '
        'RefreshToolStripButton
        '
        Me.RefreshToolStripButton.Image = CType(resources.GetObject("RefreshToolStripButton.Image"), System.Drawing.Image)
        Me.RefreshToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.RefreshToolStripButton.Name = "RefreshToolStripButton"
        Me.RefreshToolStripButton.Size = New System.Drawing.Size(105, 25)
        Me.RefreshToolStripButton.Text = "Refresh list"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 28)
        '
        'DataShaperPivotGridControl
        '
        Me.DataShaperPivotGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataShaperPivotGridControl.Location = New System.Drawing.Point(0, 0)
        Me.DataShaperPivotGridControl.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataShaperPivotGridControl.Name = "DataShaperPivotGridControl"
        Me.DataShaperPivotGridControl.OptionsChartDataSource.ProvideColumnCustomTotals = True
        Me.DataShaperPivotGridControl.OptionsChartDataSource.ProvideColumnGrandTotals = True
        Me.DataShaperPivotGridControl.OptionsChartDataSource.ProvideColumnTotals = True
        Me.DataShaperPivotGridControl.OptionsChartDataSource.ProvideRowCustomTotals = True
        Me.DataShaperPivotGridControl.OptionsChartDataSource.ProvideRowGrandTotals = True
        Me.DataShaperPivotGridControl.OptionsChartDataSource.ProvideRowTotals = True
        Me.DataShaperPivotGridControl.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized
        Me.DataShaperPivotGridControl.OptionsDataField.RowHeaderWidth = 133
        Me.DataShaperPivotGridControl.OptionsView.RowTreeOffset = 28
        Me.DataShaperPivotGridControl.OptionsView.RowTreeWidth = 133
        Me.DataShaperPivotGridControl.OptionsView.ShowCustomTotalsForSingleValues = True
        Me.DataShaperPivotGridControl.OptionsView.ShowGrandTotalsForSingleValues = True
        Me.DataShaperPivotGridControl.OptionsView.ShowTotalsForSingleValues = True
        Me.DataShaperPivotGridControl.Size = New System.Drawing.Size(1577, 879)
        Me.DataShaperPivotGridControl.TabIndex = 1
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 28)
        Me.XtraTabControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.DatasetXtraTabPage
        Me.XtraTabControl1.Size = New System.Drawing.Size(1579, 909)
        Me.XtraTabControl1.TabIndex = 2
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.DatasetXtraTabPage, Me.PivotXtraTabPage})
        '
        'DatasetXtraTabPage
        '
        Me.DatasetXtraTabPage.Controls.Add(Me.DataShaperGridControl)
        Me.DatasetXtraTabPage.Controls.Add(Me.DataShaperGridControlToolStrip)
        Me.DatasetXtraTabPage.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DatasetXtraTabPage.Name = "DatasetXtraTabPage"
        Me.DatasetXtraTabPage.Size = New System.Drawing.Size(1577, 879)
        Me.DatasetXtraTabPage.Text = "Dataset"
        '
        'DataShaperGridControl
        '
        Me.DataShaperGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataShaperGridControl.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataShaperGridControl.Location = New System.Drawing.Point(0, 39)
        Me.DataShaperGridControl.MainView = Me.GridView1
        Me.DataShaperGridControl.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataShaperGridControl.Name = "DataShaperGridControl"
        Me.DataShaperGridControl.Size = New System.Drawing.Size(1971, 1060)
        Me.DataShaperGridControl.TabIndex = 0
        Me.DataShaperGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.DetailHeight = 431
        Me.GridView1.GridControl = Me.DataShaperGridControl
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'DataShaperGridControlToolStrip
        '
        Me.DataShaperGridControlToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.DataShaperGridControlToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExportGridControlToolStripButton})
        Me.DataShaperGridControlToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.DataShaperGridControlToolStrip.Name = "DataShaperGridControlToolStrip"
        Me.DataShaperGridControlToolStrip.Size = New System.Drawing.Size(1577, 31)
        Me.DataShaperGridControlToolStrip.TabIndex = 1
        Me.DataShaperGridControlToolStrip.Text = "ToolStrip2"
        '
        'ExportGridControlToolStripButton
        '
        Me.ExportGridControlToolStripButton.Image = CType(resources.GetObject("ExportGridControlToolStripButton.Image"), System.Drawing.Image)
        Me.ExportGridControlToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ExportGridControlToolStripButton.Name = "ExportGridControlToolStripButton"
        Me.ExportGridControlToolStripButton.Size = New System.Drawing.Size(141, 28)
        Me.ExportGridControlToolStripButton.Text = "Export to Excel..."
        '
        'PivotXtraTabPage
        '
        Me.PivotXtraTabPage.Controls.Add(Me.DataShaperPivotGridControl)
        Me.PivotXtraTabPage.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PivotXtraTabPage.Name = "PivotXtraTabPage"
        Me.PivotXtraTabPage.Size = New System.Drawing.Size(1577, 879)
        Me.PivotXtraTabPage.Text = "Pivot grid"
        '
        'DataShaperForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1579, 937)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "DataShaperForm"
        Me.Text = "GSPE Data Shaper"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DataShaperPivotGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.DatasetXtraTabPage.ResumeLayout(False)
        Me.DatasetXtraTabPage.PerformLayout()
        CType(Me.DataShaperGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataShaperGridControlToolStrip.ResumeLayout(False)
        Me.DataShaperGridControlToolStrip.PerformLayout()
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
    Friend WithEvents RefreshToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents DataShaperGridControlToolStrip As ToolStrip
    Friend WithEvents ExportGridControlToolStripButton As ToolStripButton
End Class
