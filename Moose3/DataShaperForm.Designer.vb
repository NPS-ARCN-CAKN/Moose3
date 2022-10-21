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
        Me.RefreshDatasourceToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.DataShaperPivotGridControl = New DevExpress.XtraPivotGrid.PivotGridControl()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.DatasetXtraTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.DataShaperGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.DataShaperGridControlToolStrip = New System.Windows.Forms.ToolStrip()
        Me.ExportGridControlToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.PivotXtraTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ExportPivotGridButton = New System.Windows.Forms.ToolStripButton()
        Me.FooterToolStrip = New System.Windows.Forms.ToolStrip()
        Me.QueryToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.SqlToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.DatabaseToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.ConnectionStringToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.UsernameToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.ClientToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DataShaperPivotGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.DatasetXtraTabPage.SuspendLayout()
        CType(Me.DataShaperGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataShaperGridControlToolStrip.SuspendLayout()
        Me.PivotXtraTabPage.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.FooterToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.QuerySelectorToolStripComboBox, Me.RefreshToolStripButton, Me.ToolStripSeparator1, Me.RefreshDatasourceToolStripButton, Me.ToolStripSeparator2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1579, 31)
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
        Me.QuerySelectorToolStripComboBox.Name = "QuerySelectorToolStripComboBox"
        Me.QuerySelectorToolStripComboBox.Size = New System.Drawing.Size(532, 28)
        '
        'RefreshToolStripButton
        '
        Me.RefreshToolStripButton.Image = CType(resources.GetObject("RefreshToolStripButton.Image"), System.Drawing.Image)
        Me.RefreshToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.RefreshToolStripButton.Name = "RefreshToolStripButton"
        Me.RefreshToolStripButton.Size = New System.Drawing.Size(105, 28)
        Me.RefreshToolStripButton.Text = "Refresh list"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 28)
        '
        'RefreshDatasourceToolStripButton
        '
        Me.RefreshDatasourceToolStripButton.Image = CType(resources.GetObject("RefreshDatasourceToolStripButton.Image"), System.Drawing.Image)
        Me.RefreshDatasourceToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.RefreshDatasourceToolStripButton.Name = "RefreshDatasourceToolStripButton"
        Me.RefreshDatasourceToolStripButton.Size = New System.Drawing.Size(163, 25)
        Me.RefreshDatasourceToolStripButton.Text = "Refresh data source"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 28)
        '
        'DataShaperPivotGridControl
        '
        Me.DataShaperPivotGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataShaperPivotGridControl.Location = New System.Drawing.Point(0, 39)
        Me.DataShaperPivotGridControl.Margin = New System.Windows.Forms.Padding(4)
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
        Me.DataShaperPivotGridControl.Size = New System.Drawing.Size(1971, 1018)
        Me.DataShaperPivotGridControl.TabIndex = 1
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 31)
        Me.XtraTabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.DatasetXtraTabPage
        Me.XtraTabControl1.Size = New System.Drawing.Size(1579, 875)
        Me.XtraTabControl1.TabIndex = 2
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.DatasetXtraTabPage, Me.PivotXtraTabPage})
        '
        'DatasetXtraTabPage
        '
        Me.DatasetXtraTabPage.Controls.Add(Me.DataShaperGridControl)
        Me.DatasetXtraTabPage.Controls.Add(Me.DataShaperGridControlToolStrip)
        Me.DatasetXtraTabPage.Margin = New System.Windows.Forms.Padding(4)
        Me.DatasetXtraTabPage.Name = "DatasetXtraTabPage"
        Me.DatasetXtraTabPage.Size = New System.Drawing.Size(1577, 845)
        Me.DatasetXtraTabPage.Text = "Dataset"
        '
        'DataShaperGridControl
        '
        Me.DataShaperGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataShaperGridControl.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
        Me.DataShaperGridControl.Location = New System.Drawing.Point(0, 31)
        Me.DataShaperGridControl.MainView = Me.GridView1
        Me.DataShaperGridControl.Margin = New System.Windows.Forms.Padding(4)
        Me.DataShaperGridControl.Name = "DataShaperGridControl"
        Me.DataShaperGridControl.Size = New System.Drawing.Size(1577, 814)
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
        Me.PivotXtraTabPage.Controls.Add(Me.ToolStrip2)
        Me.PivotXtraTabPage.Margin = New System.Windows.Forms.Padding(4)
        Me.PivotXtraTabPage.Name = "PivotXtraTabPage"
        Me.PivotXtraTabPage.Size = New System.Drawing.Size(1577, 845)
        Me.PivotXtraTabPage.Text = "Pivot grid"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExportPivotGridButton})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(1577, 31)
        Me.ToolStrip2.TabIndex = 2
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ExportPivotGridButton
        '
        Me.ExportPivotGridButton.Image = CType(resources.GetObject("ExportPivotGridButton.Image"), System.Drawing.Image)
        Me.ExportPivotGridButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ExportPivotGridButton.Name = "ExportPivotGridButton"
        Me.ExportPivotGridButton.Size = New System.Drawing.Size(141, 28)
        Me.ExportPivotGridButton.Text = "Export to Excel..."
        '
        'FooterToolStrip
        '
        Me.FooterToolStrip.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FooterToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.FooterToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QueryToolStripLabel, Me.SqlToolStripLabel, Me.ToolStripSeparator3, Me.DatabaseToolStripLabel, Me.ConnectionStringToolStripLabel, Me.ToolStripSeparator4, Me.UsernameToolStripLabel, Me.ClientToolStripLabel})
        Me.FooterToolStrip.Location = New System.Drawing.Point(0, 906)
        Me.FooterToolStrip.Name = "FooterToolStrip"
        Me.FooterToolStrip.Size = New System.Drawing.Size(1579, 31)
        Me.FooterToolStrip.TabIndex = 2
        Me.FooterToolStrip.Text = "ToolStrip3"
        '
        'QueryToolStripLabel
        '
        Me.QueryToolStripLabel.Name = "QueryToolStripLabel"
        Me.QueryToolStripLabel.Size = New System.Drawing.Size(51, 22)
        Me.QueryToolStripLabel.Text = "Query:"
        '
        'SqlToolStripLabel
        '
        Me.SqlToolStripLabel.Name = "SqlToolStripLabel"
        Me.SqlToolStripLabel.Size = New System.Drawing.Size(35, 22)
        Me.SqlToolStripLabel.Text = "SQL"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'DatabaseToolStripLabel
        '
        Me.DatabaseToolStripLabel.Name = "DatabaseToolStripLabel"
        Me.DatabaseToolStripLabel.Size = New System.Drawing.Size(75, 22)
        Me.DatabaseToolStripLabel.Text = "Database:"
        '
        'ConnectionStringToolStripLabel
        '
        Me.ConnectionStringToolStripLabel.Name = "ConnectionStringToolStripLabel"
        Me.ConnectionStringToolStripLabel.Size = New System.Drawing.Size(99, 22)
        Me.ConnectionStringToolStripLabel.Text = "Disconnected"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'UsernameToolStripLabel
        '
        Me.UsernameToolStripLabel.Name = "UsernameToolStripLabel"
        Me.UsernameToolStripLabel.Size = New System.Drawing.Size(50, 22)
        Me.UsernameToolStripLabel.Text = "Client:"
        '
        'ClientToolStripLabel
        '
        Me.ClientToolStripLabel.Name = "ClientToolStripLabel"
        Me.ClientToolStripLabel.Size = New System.Drawing.Size(47, 22)
        Me.ClientToolStripLabel.Text = "Client"
        '
        'DataShaperForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1579, 937)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.FooterToolStrip)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Margin = New System.Windows.Forms.Padding(4)
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
        Me.PivotXtraTabPage.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.FooterToolStrip.ResumeLayout(False)
        Me.FooterToolStrip.PerformLayout()
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
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents ExportPivotGridButton As ToolStripButton
    Friend WithEvents RefreshDatasourceToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents FooterToolStrip As ToolStrip
    Friend WithEvents QueryToolStripLabel As ToolStripLabel
    Friend WithEvents SqlToolStripLabel As ToolStripLabel
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents DatabaseToolStripLabel As ToolStripLabel
    Friend WithEvents ConnectionStringToolStripLabel As ToolStripLabel
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents UsernameToolStripLabel As ToolStripLabel
    Friend WithEvents ClientToolStripLabel As ToolStripLabel
End Class
