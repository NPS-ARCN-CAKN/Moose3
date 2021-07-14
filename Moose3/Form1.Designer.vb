<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.MooseDataSet = New Moose3.MooseDataSet()
        Me.GSPE_SurveysBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GSPE_SurveysTableAdapter = New Moose3.MooseDataSetTableAdapters.GSPE_SurveysTableAdapter()
        Me.TableAdapterManager = New Moose3.MooseDataSetTableAdapters.TableAdapterManager()
        Me.GSPE_DensityEstimatesTableAdapter = New Moose3.MooseDataSetTableAdapters.GSPE_DensityEstimatesTableAdapter()
        Me.GSPE_PopulationEstimatesTableAdapter = New Moose3.MooseDataSetTableAdapters.GSPE_PopulationEstimatesTableAdapter()
        Me.GSPE_ResultsTableAdapter = New Moose3.MooseDataSetTableAdapters.GSPE_ResultsTableAdapter()
        Me.GSPETableAdapter = New Moose3.MooseDataSetTableAdapters.GSPETableAdapter()
        Me.GSPEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GSPE_DensityEstimatesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GSPE_PopulationEstimatesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GSPE_ResultsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.ListBoxControl1 = New DevExpress.XtraEditors.ListBoxControl()
        Me.SurveyVGridControl = New DevExpress.XtraVerticalGrid.VGridControl()
        Me.rowSurveyName = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowYear = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowNetwork = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowPark = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowSeason = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowStartDate = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowEndDate = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowAreaSurveyed_mi = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowAverageSearchEffort = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowMethodology = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowProtocolVersion = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowProtocolReferenceCode = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowPersonnel = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowReportReferenceCode = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowReportLink = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowDeliverablesDatasetReferenceCode = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowDataSource = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowDataResourcesDirectory = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowAbstract = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowSummary = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowDatasetProcessingSteps = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowComments = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowRecordInsertedDate = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowRecordInsertedBy = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowValidatedDate = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.rowValidatedBy = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
        Me.MainXtraTabControl = New DevExpress.XtraTab.XtraTabControl()
        Me.SurveyDetailsXtraTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.ResultsXtraTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.ResultsSplitContainer = New System.Windows.Forms.SplitContainer()
        Me.PopulationGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSurveyName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colParkSubArea = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAnalysis_Column = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStrata = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colConfidence = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPopulation_Estimate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStandard_Error = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLower_Limit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUpper_Limit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProportion_of_Mean = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStrata_Column = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAnalysis_Area = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCounted_Column = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnit_Area_Column = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSurveyArea = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSampledArea = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIntensity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRelativePrecision = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSightabilityCorrectionFactor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDensity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComments = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReportDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAnalysisPerformedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPopulationEstimateSource = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRecordInsertedDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRecordInsertedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colValidatedDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colValidatedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ResultsSplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.DensityGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSurveyName1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colParkSubArea1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStratum = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDensity_Estimate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDensity_AreaSurveyed_SqMi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDensity_AverageSearchEffort = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDensityEstimateMethodology = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDensityEstimateSource = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReportDate1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComments1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRecordInsertedDate1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRecordInsertedBy1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colValidatedDate1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colValidatedBy1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ResultsSplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.ResultsGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSurveyName2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colParkSubArea2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBullCowRatio = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCalfCowRatio = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCalfAdultRatio = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colADULT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBULL_30_40 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBULL_30_50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBULL_30_60 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBULL_41_50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBULL_ALL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBULL_GT_50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBULL_GT_60 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBULL_GTE_50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBULL_LT_30 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBULL_LT_50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCALF = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCOW = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCOW_W_0 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCOW_W_1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCOW_W_2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCOW_W_3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLG_BULL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMED_BULL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMED_L_BULL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSM_BULL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUNKNOWN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colYBULL_ALL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colYBULL_GTSF = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colYBULL_SF = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMOOSE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSubAreaSurveyed_SqMi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSubAreaAverageSearchEffort = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMethodologyUsed = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colResultsSource = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComments2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRecordInsertedDate2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRecordInsertedBy2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colValidatedDate2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colValidatedBy2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.AbstractRepositoryItemMemoEdit = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        CType(Me.MooseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GSPE_SurveysBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GSPEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GSPE_DensityEstimatesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GSPE_PopulationEstimatesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GSPE_ResultsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        CType(Me.ListBoxControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SurveyVGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MainXtraTabControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainXtraTabControl.SuspendLayout()
        Me.SurveyDetailsXtraTabPage.SuspendLayout()
        Me.ResultsXtraTabPage.SuspendLayout()
        CType(Me.ResultsSplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ResultsSplitContainer.Panel1.SuspendLayout()
        Me.ResultsSplitContainer.Panel2.SuspendLayout()
        Me.ResultsSplitContainer.SuspendLayout()
        CType(Me.PopulationGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ResultsSplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ResultsSplitContainer2.Panel1.SuspendLayout()
        Me.ResultsSplitContainer2.Panel2.SuspendLayout()
        Me.ResultsSplitContainer2.SuspendLayout()
        CType(Me.DensityGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ResultsSplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ResultsSplitContainer3.Panel1.SuspendLayout()
        Me.ResultsSplitContainer3.SuspendLayout()
        CType(Me.ResultsGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AbstractRepositoryItemMemoEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MooseDataSet
        '
        Me.MooseDataSet.DataSetName = "MooseDataSet"
        Me.MooseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GSPE_SurveysBindingSource
        '
        Me.GSPE_SurveysBindingSource.DataMember = "GSPE_Surveys"
        Me.GSPE_SurveysBindingSource.DataSource = Me.MooseDataSet
        '
        'GSPE_SurveysTableAdapter
        '
        Me.GSPE_SurveysTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.GSPE_DensityEstimatesTableAdapter = Me.GSPE_DensityEstimatesTableAdapter
        Me.TableAdapterManager.GSPE_PopulationEstimatesTableAdapter = Me.GSPE_PopulationEstimatesTableAdapter
        Me.TableAdapterManager.GSPE_ResultsTableAdapter = Me.GSPE_ResultsTableAdapter
        Me.TableAdapterManager.GSPE_SurveysTableAdapter = Me.GSPE_SurveysTableAdapter
        Me.TableAdapterManager.GSPETableAdapter = Me.GSPETableAdapter
        Me.TableAdapterManager.UpdateOrder = Moose3.MooseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'GSPE_DensityEstimatesTableAdapter
        '
        Me.GSPE_DensityEstimatesTableAdapter.ClearBeforeFill = True
        '
        'GSPE_PopulationEstimatesTableAdapter
        '
        Me.GSPE_PopulationEstimatesTableAdapter.ClearBeforeFill = True
        '
        'GSPE_ResultsTableAdapter
        '
        Me.GSPE_ResultsTableAdapter.ClearBeforeFill = True
        '
        'GSPETableAdapter
        '
        Me.GSPETableAdapter.ClearBeforeFill = True
        '
        'GSPEBindingSource
        '
        Me.GSPEBindingSource.DataMember = "FK_GSPE_GSPE_Surveys"
        Me.GSPEBindingSource.DataSource = Me.GSPE_SurveysBindingSource
        '
        'GSPE_DensityEstimatesBindingSource
        '
        Me.GSPE_DensityEstimatesBindingSource.DataMember = "FK_GSPE_DensityEstimates_GSPE_Surveys"
        Me.GSPE_DensityEstimatesBindingSource.DataSource = Me.GSPE_SurveysBindingSource
        '
        'GSPE_PopulationEstimatesBindingSource
        '
        Me.GSPE_PopulationEstimatesBindingSource.DataMember = "FK_GSPE_PopulationEstimates_GSPE_Surveys"
        Me.GSPE_PopulationEstimatesBindingSource.DataSource = Me.GSPE_SurveysBindingSource
        '
        'GSPE_ResultsBindingSource
        '
        Me.GSPE_ResultsBindingSource.DataMember = "FK_GSPE_Ratios_GSPE_Surveys"
        Me.GSPE_ResultsBindingSource.DataSource = Me.GSPE_SurveysBindingSource
        '
        'DockManager1
        '
        Me.DockManager1.Form = Me
        Me.DockManager1.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.DockPanel1})
        Me.DockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "System.Windows.Forms.StatusBar", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl", "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl", "DevExpress.XtraBars.ToolbarForm.ToolbarFormControl"})
        '
        'DockPanel1
        '
        Me.DockPanel1.Controls.Add(Me.DockPanel1_Container)
        Me.DockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left
        Me.DockPanel1.ID = New System.Guid("aba0a096-d031-43b4-aad9-b579af23cd0a")
        Me.DockPanel1.Location = New System.Drawing.Point(0, 0)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(372, 200)
        Me.DockPanel1.Size = New System.Drawing.Size(372, 786)
        Me.DockPanel1.Text = "Survey selector"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.ListBoxControl1)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(3, 26)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(365, 757)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'ListBoxControl1
        '
        Me.ListBoxControl1.DataSource = Me.GSPE_SurveysBindingSource
        Me.ListBoxControl1.DisplayMember = "SurveyName"
        Me.ListBoxControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBoxControl1.Location = New System.Drawing.Point(0, 0)
        Me.ListBoxControl1.Name = "ListBoxControl1"
        Me.ListBoxControl1.Size = New System.Drawing.Size(365, 757)
        Me.ListBoxControl1.SortOrder = System.Windows.Forms.SortOrder.Descending
        Me.ListBoxControl1.TabIndex = 0
        Me.ListBoxControl1.ValueMember = "SurveyName"
        '
        'SurveyVGridControl
        '
        Me.SurveyVGridControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.SurveyVGridControl.Cursor = System.Windows.Forms.Cursors.SizeNS
        Me.SurveyVGridControl.CustomizationFormBounds = New System.Drawing.Rectangle(457, 176, 214, 258)
        Me.SurveyVGridControl.DataSource = Me.GSPE_SurveysBindingSource
        Me.SurveyVGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SurveyVGridControl.LayoutStyle = DevExpress.XtraVerticalGrid.LayoutViewStyle.SingleRecordView
        Me.SurveyVGridControl.Location = New System.Drawing.Point(0, 0)
        Me.SurveyVGridControl.Name = "SurveyVGridControl"
        Me.SurveyVGridControl.RecordWidth = 148
        Me.SurveyVGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.AbstractRepositoryItemMemoEdit})
        Me.SurveyVGridControl.RowHeaderWidth = 52
        Me.SurveyVGridControl.Rows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() {Me.rowSurveyName, Me.rowYear, Me.rowNetwork, Me.rowPark, Me.rowSeason, Me.rowStartDate, Me.rowEndDate, Me.rowAreaSurveyed_mi, Me.rowAverageSearchEffort, Me.rowMethodology, Me.rowProtocolVersion, Me.rowProtocolReferenceCode, Me.rowPersonnel, Me.rowReportReferenceCode, Me.rowReportLink, Me.rowDeliverablesDatasetReferenceCode, Me.rowDataSource, Me.rowDataResourcesDirectory, Me.rowAbstract, Me.rowSummary, Me.rowDatasetProcessingSteps, Me.rowComments, Me.rowRecordInsertedDate, Me.rowRecordInsertedBy, Me.rowValidatedDate, Me.rowValidatedBy})
        Me.SurveyVGridControl.Size = New System.Drawing.Size(810, 761)
        Me.SurveyVGridControl.TabIndex = 1
        '
        'rowSurveyName
        '
        Me.rowSurveyName.Name = "rowSurveyName"
        Me.rowSurveyName.Properties.Caption = "Survey Name"
        Me.rowSurveyName.Properties.FieldName = "SurveyName"
        '
        'rowYear
        '
        Me.rowYear.Name = "rowYear"
        Me.rowYear.Properties.Caption = "Year"
        Me.rowYear.Properties.FieldName = "Year"
        '
        'rowNetwork
        '
        Me.rowNetwork.Name = "rowNetwork"
        Me.rowNetwork.Properties.Caption = "Network"
        Me.rowNetwork.Properties.FieldName = "Network"
        '
        'rowPark
        '
        Me.rowPark.Name = "rowPark"
        Me.rowPark.Properties.Caption = "Park"
        Me.rowPark.Properties.FieldName = "Park"
        '
        'rowSeason
        '
        Me.rowSeason.Name = "rowSeason"
        Me.rowSeason.Properties.Caption = "Season"
        Me.rowSeason.Properties.FieldName = "Season"
        '
        'rowStartDate
        '
        Me.rowStartDate.Name = "rowStartDate"
        Me.rowStartDate.Properties.Caption = "Start Date"
        Me.rowStartDate.Properties.FieldName = "StartDate"
        '
        'rowEndDate
        '
        Me.rowEndDate.Name = "rowEndDate"
        Me.rowEndDate.Properties.Caption = "End Date"
        Me.rowEndDate.Properties.FieldName = "EndDate"
        '
        'rowAreaSurveyed_mi
        '
        Me.rowAreaSurveyed_mi.Name = "rowAreaSurveyed_mi"
        Me.rowAreaSurveyed_mi.Properties.Caption = "Area Surveyed_mi"
        Me.rowAreaSurveyed_mi.Properties.FieldName = "AreaSurveyed_mi"
        '
        'rowAverageSearchEffort
        '
        Me.rowAverageSearchEffort.Name = "rowAverageSearchEffort"
        Me.rowAverageSearchEffort.Properties.Caption = "Average Search Effort"
        Me.rowAverageSearchEffort.Properties.FieldName = "AverageSearchEffort"
        '
        'rowMethodology
        '
        Me.rowMethodology.Name = "rowMethodology"
        Me.rowMethodology.Properties.Caption = "Methodology"
        Me.rowMethodology.Properties.FieldName = "Methodology"
        '
        'rowProtocolVersion
        '
        Me.rowProtocolVersion.Name = "rowProtocolVersion"
        Me.rowProtocolVersion.Properties.Caption = "Protocol Version"
        Me.rowProtocolVersion.Properties.FieldName = "ProtocolVersion"
        '
        'rowProtocolReferenceCode
        '
        Me.rowProtocolReferenceCode.Name = "rowProtocolReferenceCode"
        Me.rowProtocolReferenceCode.Properties.Caption = "Protocol Reference Code"
        Me.rowProtocolReferenceCode.Properties.FieldName = "ProtocolReferenceCode"
        '
        'rowPersonnel
        '
        Me.rowPersonnel.Name = "rowPersonnel"
        Me.rowPersonnel.Properties.Caption = "Personnel"
        Me.rowPersonnel.Properties.FieldName = "Personnel"
        '
        'rowReportReferenceCode
        '
        Me.rowReportReferenceCode.Name = "rowReportReferenceCode"
        Me.rowReportReferenceCode.Properties.Caption = "Report Reference Code"
        Me.rowReportReferenceCode.Properties.FieldName = "ReportReferenceCode"
        '
        'rowReportLink
        '
        Me.rowReportLink.Name = "rowReportLink"
        Me.rowReportLink.Properties.Caption = "Report Link"
        Me.rowReportLink.Properties.FieldName = "ReportLink"
        '
        'rowDeliverablesDatasetReferenceCode
        '
        Me.rowDeliverablesDatasetReferenceCode.Name = "rowDeliverablesDatasetReferenceCode"
        Me.rowDeliverablesDatasetReferenceCode.Properties.Caption = "Deliverables Dataset Reference Code"
        Me.rowDeliverablesDatasetReferenceCode.Properties.FieldName = "DeliverablesDatasetReferenceCode"
        '
        'rowDataSource
        '
        Me.rowDataSource.Name = "rowDataSource"
        Me.rowDataSource.Properties.Caption = "Data Source"
        Me.rowDataSource.Properties.FieldName = "DataSource"
        '
        'rowDataResourcesDirectory
        '
        Me.rowDataResourcesDirectory.Name = "rowDataResourcesDirectory"
        Me.rowDataResourcesDirectory.Properties.Caption = "Data Resources Directory"
        Me.rowDataResourcesDirectory.Properties.FieldName = "DataResourcesDirectory"
        '
        'rowAbstract
        '
        Me.rowAbstract.AllowCollapse = DevExpress.Utils.DefaultBoolean.[False]
        Me.rowAbstract.AppearanceCell.Options.UseTextOptions = True
        Me.rowAbstract.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.None
        Me.rowAbstract.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.rowAbstract.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.rowAbstract.Height = 258
        Me.rowAbstract.Name = "rowAbstract"
        Me.rowAbstract.Properties.Caption = "Abstract"
        Me.rowAbstract.Properties.FieldName = "Abstract"
        Me.rowAbstract.Properties.RowEdit = Me.AbstractRepositoryItemMemoEdit
        Me.rowAbstract.ShowCollapseButton = DevExpress.Utils.DefaultBoolean.[True]
        '
        'rowSummary
        '
        Me.rowSummary.AppearanceCell.Options.UseTextOptions = True
        Me.rowSummary.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.rowSummary.Height = 438
        Me.rowSummary.Name = "rowSummary"
        Me.rowSummary.Properties.Caption = "Summary"
        Me.rowSummary.Properties.FieldName = "Summary"
        '
        'rowDatasetProcessingSteps
        '
        Me.rowDatasetProcessingSteps.Height = 275
        Me.rowDatasetProcessingSteps.Name = "rowDatasetProcessingSteps"
        Me.rowDatasetProcessingSteps.Properties.Caption = "Dataset Processing Steps"
        Me.rowDatasetProcessingSteps.Properties.FieldName = "DatasetProcessingSteps"
        '
        'rowComments
        '
        Me.rowComments.Name = "rowComments"
        Me.rowComments.Properties.Caption = "Comments"
        Me.rowComments.Properties.FieldName = "Comments"
        '
        'rowRecordInsertedDate
        '
        Me.rowRecordInsertedDate.Name = "rowRecordInsertedDate"
        Me.rowRecordInsertedDate.Properties.Caption = "Record Inserted Date"
        Me.rowRecordInsertedDate.Properties.FieldName = "RecordInsertedDate"
        '
        'rowRecordInsertedBy
        '
        Me.rowRecordInsertedBy.Name = "rowRecordInsertedBy"
        Me.rowRecordInsertedBy.Properties.Caption = "Record Inserted By"
        Me.rowRecordInsertedBy.Properties.FieldName = "RecordInsertedBy"
        '
        'rowValidatedDate
        '
        Me.rowValidatedDate.Name = "rowValidatedDate"
        Me.rowValidatedDate.Properties.Caption = "Validated Date"
        Me.rowValidatedDate.Properties.FieldName = "ValidatedDate"
        '
        'rowValidatedBy
        '
        Me.rowValidatedBy.Name = "rowValidatedBy"
        Me.rowValidatedBy.Properties.Caption = "Validated By"
        Me.rowValidatedBy.Properties.FieldName = "ValidatedBy"
        '
        'MainXtraTabControl
        '
        Me.MainXtraTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainXtraTabControl.Location = New System.Drawing.Point(372, 0)
        Me.MainXtraTabControl.Name = "MainXtraTabControl"
        Me.MainXtraTabControl.SelectedTabPage = Me.SurveyDetailsXtraTabPage
        Me.MainXtraTabControl.Size = New System.Drawing.Size(812, 786)
        Me.MainXtraTabControl.TabIndex = 2
        Me.MainXtraTabControl.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.SurveyDetailsXtraTabPage, Me.ResultsXtraTabPage})
        '
        'SurveyDetailsXtraTabPage
        '
        Me.SurveyDetailsXtraTabPage.Controls.Add(Me.SurveyVGridControl)
        Me.SurveyDetailsXtraTabPage.Name = "SurveyDetailsXtraTabPage"
        Me.SurveyDetailsXtraTabPage.Size = New System.Drawing.Size(810, 761)
        Me.SurveyDetailsXtraTabPage.Text = "Survey details"
        '
        'ResultsXtraTabPage
        '
        Me.ResultsXtraTabPage.Controls.Add(Me.ResultsSplitContainer)
        Me.ResultsXtraTabPage.Controls.Add(Me.GridControl1)
        Me.ResultsXtraTabPage.Name = "ResultsXtraTabPage"
        Me.ResultsXtraTabPage.Size = New System.Drawing.Size(810, 761)
        Me.ResultsXtraTabPage.Text = "Results"
        '
        'ResultsSplitContainer
        '
        Me.ResultsSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ResultsSplitContainer.Location = New System.Drawing.Point(0, 0)
        Me.ResultsSplitContainer.Name = "ResultsSplitContainer"
        Me.ResultsSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'ResultsSplitContainer.Panel1
        '
        Me.ResultsSplitContainer.Panel1.Controls.Add(Me.PopulationGridControl)
        '
        'ResultsSplitContainer.Panel2
        '
        Me.ResultsSplitContainer.Panel2.Controls.Add(Me.ResultsSplitContainer2)
        Me.ResultsSplitContainer.Size = New System.Drawing.Size(810, 761)
        Me.ResultsSplitContainer.SplitterDistance = 124
        Me.ResultsSplitContainer.TabIndex = 1
        '
        'PopulationGridControl
        '
        Me.PopulationGridControl.DataSource = Me.GSPE_PopulationEstimatesBindingSource
        Me.PopulationGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PopulationGridControl.Location = New System.Drawing.Point(0, 0)
        Me.PopulationGridControl.MainView = Me.GridView2
        Me.PopulationGridControl.Name = "PopulationGridControl"
        Me.PopulationGridControl.Size = New System.Drawing.Size(810, 124)
        Me.PopulationGridControl.TabIndex = 0
        Me.PopulationGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSurveyName, Me.colParkSubArea, Me.colAnalysis_Column, Me.colStrata, Me.colConfidence, Me.colPopulation_Estimate, Me.colStandard_Error, Me.colLower_Limit, Me.colUpper_Limit, Me.colProportion_of_Mean, Me.colStrata_Column, Me.colAnalysis_Area, Me.colCounted_Column, Me.colUnit_Area_Column, Me.colSurveyArea, Me.colSampledArea, Me.colIntensity, Me.colRelativePrecision, Me.colSightabilityCorrectionFactor, Me.colDensity, Me.colComments, Me.colReportDate, Me.colAnalysisPerformedBy, Me.colPopulationEstimateSource, Me.colRecordInsertedDate, Me.colRecordInsertedBy, Me.colValidatedDate, Me.colValidatedBy})
        Me.GridView2.GridControl = Me.PopulationGridControl
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colSurveyName
        '
        Me.colSurveyName.FieldName = "SurveyName"
        Me.colSurveyName.Name = "colSurveyName"
        Me.colSurveyName.Visible = True
        Me.colSurveyName.VisibleIndex = 0
        '
        'colParkSubArea
        '
        Me.colParkSubArea.FieldName = "ParkSubArea"
        Me.colParkSubArea.Name = "colParkSubArea"
        Me.colParkSubArea.Visible = True
        Me.colParkSubArea.VisibleIndex = 1
        '
        'colAnalysis_Column
        '
        Me.colAnalysis_Column.FieldName = "Analysis_Column"
        Me.colAnalysis_Column.Name = "colAnalysis_Column"
        Me.colAnalysis_Column.Visible = True
        Me.colAnalysis_Column.VisibleIndex = 2
        '
        'colStrata
        '
        Me.colStrata.FieldName = "Strata"
        Me.colStrata.Name = "colStrata"
        Me.colStrata.Visible = True
        Me.colStrata.VisibleIndex = 3
        '
        'colConfidence
        '
        Me.colConfidence.FieldName = "Confidence"
        Me.colConfidence.Name = "colConfidence"
        Me.colConfidence.Visible = True
        Me.colConfidence.VisibleIndex = 4
        '
        'colPopulation_Estimate
        '
        Me.colPopulation_Estimate.FieldName = "Population_Estimate"
        Me.colPopulation_Estimate.Name = "colPopulation_Estimate"
        Me.colPopulation_Estimate.Visible = True
        Me.colPopulation_Estimate.VisibleIndex = 5
        '
        'colStandard_Error
        '
        Me.colStandard_Error.FieldName = "Standard_Error"
        Me.colStandard_Error.Name = "colStandard_Error"
        Me.colStandard_Error.Visible = True
        Me.colStandard_Error.VisibleIndex = 6
        '
        'colLower_Limit
        '
        Me.colLower_Limit.FieldName = "Lower_Limit"
        Me.colLower_Limit.Name = "colLower_Limit"
        Me.colLower_Limit.Visible = True
        Me.colLower_Limit.VisibleIndex = 7
        '
        'colUpper_Limit
        '
        Me.colUpper_Limit.FieldName = "Upper_Limit"
        Me.colUpper_Limit.Name = "colUpper_Limit"
        Me.colUpper_Limit.Visible = True
        Me.colUpper_Limit.VisibleIndex = 8
        '
        'colProportion_of_Mean
        '
        Me.colProportion_of_Mean.FieldName = "Proportion_of_Mean"
        Me.colProportion_of_Mean.Name = "colProportion_of_Mean"
        Me.colProportion_of_Mean.Visible = True
        Me.colProportion_of_Mean.VisibleIndex = 9
        '
        'colStrata_Column
        '
        Me.colStrata_Column.FieldName = "Strata_Column"
        Me.colStrata_Column.Name = "colStrata_Column"
        Me.colStrata_Column.Visible = True
        Me.colStrata_Column.VisibleIndex = 10
        '
        'colAnalysis_Area
        '
        Me.colAnalysis_Area.FieldName = "Analysis_Area"
        Me.colAnalysis_Area.Name = "colAnalysis_Area"
        Me.colAnalysis_Area.Visible = True
        Me.colAnalysis_Area.VisibleIndex = 11
        '
        'colCounted_Column
        '
        Me.colCounted_Column.FieldName = "Counted_Column"
        Me.colCounted_Column.Name = "colCounted_Column"
        Me.colCounted_Column.Visible = True
        Me.colCounted_Column.VisibleIndex = 12
        '
        'colUnit_Area_Column
        '
        Me.colUnit_Area_Column.FieldName = "Unit_Area_Column"
        Me.colUnit_Area_Column.Name = "colUnit_Area_Column"
        Me.colUnit_Area_Column.Visible = True
        Me.colUnit_Area_Column.VisibleIndex = 13
        '
        'colSurveyArea
        '
        Me.colSurveyArea.FieldName = "SurveyArea"
        Me.colSurveyArea.Name = "colSurveyArea"
        Me.colSurveyArea.Visible = True
        Me.colSurveyArea.VisibleIndex = 14
        '
        'colSampledArea
        '
        Me.colSampledArea.FieldName = "SampledArea"
        Me.colSampledArea.Name = "colSampledArea"
        Me.colSampledArea.Visible = True
        Me.colSampledArea.VisibleIndex = 15
        '
        'colIntensity
        '
        Me.colIntensity.FieldName = "Intensity"
        Me.colIntensity.Name = "colIntensity"
        Me.colIntensity.Visible = True
        Me.colIntensity.VisibleIndex = 16
        '
        'colRelativePrecision
        '
        Me.colRelativePrecision.FieldName = "RelativePrecision"
        Me.colRelativePrecision.Name = "colRelativePrecision"
        Me.colRelativePrecision.Visible = True
        Me.colRelativePrecision.VisibleIndex = 17
        '
        'colSightabilityCorrectionFactor
        '
        Me.colSightabilityCorrectionFactor.FieldName = "SightabilityCorrectionFactor"
        Me.colSightabilityCorrectionFactor.Name = "colSightabilityCorrectionFactor"
        Me.colSightabilityCorrectionFactor.Visible = True
        Me.colSightabilityCorrectionFactor.VisibleIndex = 18
        '
        'colDensity
        '
        Me.colDensity.FieldName = "Density"
        Me.colDensity.Name = "colDensity"
        Me.colDensity.Visible = True
        Me.colDensity.VisibleIndex = 19
        '
        'colComments
        '
        Me.colComments.FieldName = "Comments"
        Me.colComments.Name = "colComments"
        Me.colComments.Visible = True
        Me.colComments.VisibleIndex = 20
        '
        'colReportDate
        '
        Me.colReportDate.FieldName = "ReportDate"
        Me.colReportDate.Name = "colReportDate"
        Me.colReportDate.Visible = True
        Me.colReportDate.VisibleIndex = 21
        '
        'colAnalysisPerformedBy
        '
        Me.colAnalysisPerformedBy.FieldName = "AnalysisPerformedBy"
        Me.colAnalysisPerformedBy.Name = "colAnalysisPerformedBy"
        Me.colAnalysisPerformedBy.Visible = True
        Me.colAnalysisPerformedBy.VisibleIndex = 22
        '
        'colPopulationEstimateSource
        '
        Me.colPopulationEstimateSource.FieldName = "PopulationEstimateSource"
        Me.colPopulationEstimateSource.Name = "colPopulationEstimateSource"
        Me.colPopulationEstimateSource.Visible = True
        Me.colPopulationEstimateSource.VisibleIndex = 23
        '
        'colRecordInsertedDate
        '
        Me.colRecordInsertedDate.FieldName = "RecordInsertedDate"
        Me.colRecordInsertedDate.Name = "colRecordInsertedDate"
        Me.colRecordInsertedDate.Visible = True
        Me.colRecordInsertedDate.VisibleIndex = 24
        '
        'colRecordInsertedBy
        '
        Me.colRecordInsertedBy.FieldName = "RecordInsertedBy"
        Me.colRecordInsertedBy.Name = "colRecordInsertedBy"
        Me.colRecordInsertedBy.Visible = True
        Me.colRecordInsertedBy.VisibleIndex = 25
        '
        'colValidatedDate
        '
        Me.colValidatedDate.FieldName = "ValidatedDate"
        Me.colValidatedDate.Name = "colValidatedDate"
        Me.colValidatedDate.Visible = True
        Me.colValidatedDate.VisibleIndex = 26
        '
        'colValidatedBy
        '
        Me.colValidatedBy.FieldName = "ValidatedBy"
        Me.colValidatedBy.Name = "colValidatedBy"
        Me.colValidatedBy.Visible = True
        Me.colValidatedBy.VisibleIndex = 27
        '
        'ResultsSplitContainer2
        '
        Me.ResultsSplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ResultsSplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ResultsSplitContainer2.Name = "ResultsSplitContainer2"
        Me.ResultsSplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'ResultsSplitContainer2.Panel1
        '
        Me.ResultsSplitContainer2.Panel1.Controls.Add(Me.DensityGridControl)
        '
        'ResultsSplitContainer2.Panel2
        '
        Me.ResultsSplitContainer2.Panel2.Controls.Add(Me.ResultsSplitContainer3)
        Me.ResultsSplitContainer2.Size = New System.Drawing.Size(810, 633)
        Me.ResultsSplitContainer2.SplitterDistance = 124
        Me.ResultsSplitContainer2.TabIndex = 0
        '
        'DensityGridControl
        '
        Me.DensityGridControl.DataSource = Me.GSPE_DensityEstimatesBindingSource
        Me.DensityGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DensityGridControl.Location = New System.Drawing.Point(0, 0)
        Me.DensityGridControl.MainView = Me.GridView3
        Me.DensityGridControl.Name = "DensityGridControl"
        Me.DensityGridControl.Size = New System.Drawing.Size(810, 124)
        Me.DensityGridControl.TabIndex = 0
        Me.DensityGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSurveyName1, Me.colParkSubArea1, Me.colStratum, Me.colDensity_Estimate, Me.colDensity_AreaSurveyed_SqMi, Me.colDensity_AverageSearchEffort, Me.colDensityEstimateMethodology, Me.colDensityEstimateSource, Me.colReportDate1, Me.colComments1, Me.colRecordInsertedDate1, Me.colRecordInsertedBy1, Me.colValidatedDate1, Me.colValidatedBy1})
        Me.GridView3.GridControl = Me.DensityGridControl
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'colSurveyName1
        '
        Me.colSurveyName1.FieldName = "SurveyName"
        Me.colSurveyName1.Name = "colSurveyName1"
        Me.colSurveyName1.Visible = True
        Me.colSurveyName1.VisibleIndex = 0
        '
        'colParkSubArea1
        '
        Me.colParkSubArea1.FieldName = "ParkSubArea"
        Me.colParkSubArea1.Name = "colParkSubArea1"
        Me.colParkSubArea1.Visible = True
        Me.colParkSubArea1.VisibleIndex = 1
        '
        'colStratum
        '
        Me.colStratum.FieldName = "Stratum"
        Me.colStratum.Name = "colStratum"
        Me.colStratum.Visible = True
        Me.colStratum.VisibleIndex = 2
        '
        'colDensity_Estimate
        '
        Me.colDensity_Estimate.FieldName = "Density_Estimate"
        Me.colDensity_Estimate.Name = "colDensity_Estimate"
        Me.colDensity_Estimate.Visible = True
        Me.colDensity_Estimate.VisibleIndex = 3
        '
        'colDensity_AreaSurveyed_SqMi
        '
        Me.colDensity_AreaSurveyed_SqMi.FieldName = "Density_AreaSurveyed_SqMi"
        Me.colDensity_AreaSurveyed_SqMi.Name = "colDensity_AreaSurveyed_SqMi"
        Me.colDensity_AreaSurveyed_SqMi.Visible = True
        Me.colDensity_AreaSurveyed_SqMi.VisibleIndex = 4
        '
        'colDensity_AverageSearchEffort
        '
        Me.colDensity_AverageSearchEffort.FieldName = "Density_AverageSearchEffort"
        Me.colDensity_AverageSearchEffort.Name = "colDensity_AverageSearchEffort"
        Me.colDensity_AverageSearchEffort.Visible = True
        Me.colDensity_AverageSearchEffort.VisibleIndex = 5
        '
        'colDensityEstimateMethodology
        '
        Me.colDensityEstimateMethodology.FieldName = "DensityEstimateMethodology"
        Me.colDensityEstimateMethodology.Name = "colDensityEstimateMethodology"
        Me.colDensityEstimateMethodology.Visible = True
        Me.colDensityEstimateMethodology.VisibleIndex = 6
        '
        'colDensityEstimateSource
        '
        Me.colDensityEstimateSource.FieldName = "DensityEstimateSource"
        Me.colDensityEstimateSource.Name = "colDensityEstimateSource"
        Me.colDensityEstimateSource.Visible = True
        Me.colDensityEstimateSource.VisibleIndex = 7
        '
        'colReportDate1
        '
        Me.colReportDate1.FieldName = "ReportDate"
        Me.colReportDate1.Name = "colReportDate1"
        Me.colReportDate1.Visible = True
        Me.colReportDate1.VisibleIndex = 8
        '
        'colComments1
        '
        Me.colComments1.FieldName = "Comments"
        Me.colComments1.Name = "colComments1"
        Me.colComments1.Visible = True
        Me.colComments1.VisibleIndex = 9
        '
        'colRecordInsertedDate1
        '
        Me.colRecordInsertedDate1.FieldName = "RecordInsertedDate"
        Me.colRecordInsertedDate1.Name = "colRecordInsertedDate1"
        Me.colRecordInsertedDate1.Visible = True
        Me.colRecordInsertedDate1.VisibleIndex = 10
        '
        'colRecordInsertedBy1
        '
        Me.colRecordInsertedBy1.FieldName = "RecordInsertedBy"
        Me.colRecordInsertedBy1.Name = "colRecordInsertedBy1"
        Me.colRecordInsertedBy1.Visible = True
        Me.colRecordInsertedBy1.VisibleIndex = 11
        '
        'colValidatedDate1
        '
        Me.colValidatedDate1.FieldName = "ValidatedDate"
        Me.colValidatedDate1.Name = "colValidatedDate1"
        Me.colValidatedDate1.Visible = True
        Me.colValidatedDate1.VisibleIndex = 12
        '
        'colValidatedBy1
        '
        Me.colValidatedBy1.FieldName = "ValidatedBy"
        Me.colValidatedBy1.Name = "colValidatedBy1"
        Me.colValidatedBy1.Visible = True
        Me.colValidatedBy1.VisibleIndex = 13
        '
        'ResultsSplitContainer3
        '
        Me.ResultsSplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ResultsSplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.ResultsSplitContainer3.Name = "ResultsSplitContainer3"
        Me.ResultsSplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'ResultsSplitContainer3.Panel1
        '
        Me.ResultsSplitContainer3.Panel1.Controls.Add(Me.ResultsGridControl)
        Me.ResultsSplitContainer3.Size = New System.Drawing.Size(810, 505)
        Me.ResultsSplitContainer3.SplitterDistance = 270
        Me.ResultsSplitContainer3.TabIndex = 0
        '
        'ResultsGridControl
        '
        Me.ResultsGridControl.DataSource = Me.GSPE_ResultsBindingSource
        Me.ResultsGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ResultsGridControl.Location = New System.Drawing.Point(0, 0)
        Me.ResultsGridControl.MainView = Me.GridView4
        Me.ResultsGridControl.Name = "ResultsGridControl"
        Me.ResultsGridControl.Size = New System.Drawing.Size(810, 270)
        Me.ResultsGridControl.TabIndex = 0
        Me.ResultsGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView4})
        '
        'GridView4
        '
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSurveyName2, Me.colParkSubArea2, Me.colBullCowRatio, Me.colCalfCowRatio, Me.colCalfAdultRatio, Me.colADULT, Me.colBULL_30_40, Me.colBULL_30_50, Me.colBULL_30_60, Me.colBULL_41_50, Me.colBULL_ALL, Me.colBULL_GT_50, Me.colBULL_GT_60, Me.colBULL_GTE_50, Me.colBULL_LT_30, Me.colBULL_LT_50, Me.colCALF, Me.colCOW, Me.colCOW_W_0, Me.colCOW_W_1, Me.colCOW_W_2, Me.colCOW_W_3, Me.colLG_BULL, Me.colMED_BULL, Me.colMED_L_BULL, Me.colSM_BULL, Me.colUNKNOWN, Me.colYBULL_ALL, Me.colYBULL_GTSF, Me.colYBULL_SF, Me.colMOOSE, Me.colSubAreaSurveyed_SqMi, Me.colSubAreaAverageSearchEffort, Me.colMethodologyUsed, Me.colResultsSource, Me.colComments2, Me.colRecordInsertedDate2, Me.colRecordInsertedBy2, Me.colValidatedDate2, Me.colValidatedBy2})
        Me.GridView4.GridControl = Me.ResultsGridControl
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsView.ShowGroupPanel = False
        '
        'colSurveyName2
        '
        Me.colSurveyName2.FieldName = "SurveyName"
        Me.colSurveyName2.Name = "colSurveyName2"
        Me.colSurveyName2.Visible = True
        Me.colSurveyName2.VisibleIndex = 0
        '
        'colParkSubArea2
        '
        Me.colParkSubArea2.FieldName = "ParkSubArea"
        Me.colParkSubArea2.Name = "colParkSubArea2"
        Me.colParkSubArea2.Visible = True
        Me.colParkSubArea2.VisibleIndex = 1
        '
        'colBullCowRatio
        '
        Me.colBullCowRatio.FieldName = "BullCowRatio"
        Me.colBullCowRatio.Name = "colBullCowRatio"
        Me.colBullCowRatio.Visible = True
        Me.colBullCowRatio.VisibleIndex = 2
        '
        'colCalfCowRatio
        '
        Me.colCalfCowRatio.FieldName = "CalfCowRatio"
        Me.colCalfCowRatio.Name = "colCalfCowRatio"
        Me.colCalfCowRatio.Visible = True
        Me.colCalfCowRatio.VisibleIndex = 3
        '
        'colCalfAdultRatio
        '
        Me.colCalfAdultRatio.FieldName = "CalfAdultRatio"
        Me.colCalfAdultRatio.Name = "colCalfAdultRatio"
        Me.colCalfAdultRatio.Visible = True
        Me.colCalfAdultRatio.VisibleIndex = 4
        '
        'colADULT
        '
        Me.colADULT.FieldName = "ADULT"
        Me.colADULT.Name = "colADULT"
        Me.colADULT.Visible = True
        Me.colADULT.VisibleIndex = 5
        '
        'colBULL_30_40
        '
        Me.colBULL_30_40.FieldName = "BULL_30_40"
        Me.colBULL_30_40.Name = "colBULL_30_40"
        Me.colBULL_30_40.Visible = True
        Me.colBULL_30_40.VisibleIndex = 6
        '
        'colBULL_30_50
        '
        Me.colBULL_30_50.FieldName = "BULL_30_50"
        Me.colBULL_30_50.Name = "colBULL_30_50"
        Me.colBULL_30_50.Visible = True
        Me.colBULL_30_50.VisibleIndex = 7
        '
        'colBULL_30_60
        '
        Me.colBULL_30_60.FieldName = "BULL_30_60"
        Me.colBULL_30_60.Name = "colBULL_30_60"
        Me.colBULL_30_60.Visible = True
        Me.colBULL_30_60.VisibleIndex = 8
        '
        'colBULL_41_50
        '
        Me.colBULL_41_50.FieldName = "BULL_41_50"
        Me.colBULL_41_50.Name = "colBULL_41_50"
        Me.colBULL_41_50.Visible = True
        Me.colBULL_41_50.VisibleIndex = 9
        '
        'colBULL_ALL
        '
        Me.colBULL_ALL.FieldName = "BULL_ALL"
        Me.colBULL_ALL.Name = "colBULL_ALL"
        Me.colBULL_ALL.Visible = True
        Me.colBULL_ALL.VisibleIndex = 10
        '
        'colBULL_GT_50
        '
        Me.colBULL_GT_50.FieldName = "BULL_GT_50"
        Me.colBULL_GT_50.Name = "colBULL_GT_50"
        Me.colBULL_GT_50.Visible = True
        Me.colBULL_GT_50.VisibleIndex = 11
        '
        'colBULL_GT_60
        '
        Me.colBULL_GT_60.FieldName = "BULL_GT_60"
        Me.colBULL_GT_60.Name = "colBULL_GT_60"
        Me.colBULL_GT_60.Visible = True
        Me.colBULL_GT_60.VisibleIndex = 12
        '
        'colBULL_GTE_50
        '
        Me.colBULL_GTE_50.FieldName = "BULL_GTE_50"
        Me.colBULL_GTE_50.Name = "colBULL_GTE_50"
        Me.colBULL_GTE_50.Visible = True
        Me.colBULL_GTE_50.VisibleIndex = 13
        '
        'colBULL_LT_30
        '
        Me.colBULL_LT_30.FieldName = "BULL_LT_30"
        Me.colBULL_LT_30.Name = "colBULL_LT_30"
        Me.colBULL_LT_30.Visible = True
        Me.colBULL_LT_30.VisibleIndex = 14
        '
        'colBULL_LT_50
        '
        Me.colBULL_LT_50.FieldName = "BULL_LT_50"
        Me.colBULL_LT_50.Name = "colBULL_LT_50"
        Me.colBULL_LT_50.Visible = True
        Me.colBULL_LT_50.VisibleIndex = 15
        '
        'colCALF
        '
        Me.colCALF.FieldName = "CALF"
        Me.colCALF.Name = "colCALF"
        Me.colCALF.Visible = True
        Me.colCALF.VisibleIndex = 16
        '
        'colCOW
        '
        Me.colCOW.FieldName = "COW"
        Me.colCOW.Name = "colCOW"
        Me.colCOW.Visible = True
        Me.colCOW.VisibleIndex = 17
        '
        'colCOW_W_0
        '
        Me.colCOW_W_0.FieldName = "COW_W_0"
        Me.colCOW_W_0.Name = "colCOW_W_0"
        Me.colCOW_W_0.Visible = True
        Me.colCOW_W_0.VisibleIndex = 18
        '
        'colCOW_W_1
        '
        Me.colCOW_W_1.FieldName = "COW_W_1"
        Me.colCOW_W_1.Name = "colCOW_W_1"
        Me.colCOW_W_1.Visible = True
        Me.colCOW_W_1.VisibleIndex = 19
        '
        'colCOW_W_2
        '
        Me.colCOW_W_2.FieldName = "COW_W_2"
        Me.colCOW_W_2.Name = "colCOW_W_2"
        Me.colCOW_W_2.Visible = True
        Me.colCOW_W_2.VisibleIndex = 20
        '
        'colCOW_W_3
        '
        Me.colCOW_W_3.FieldName = "COW_W_3"
        Me.colCOW_W_3.Name = "colCOW_W_3"
        Me.colCOW_W_3.Visible = True
        Me.colCOW_W_3.VisibleIndex = 21
        '
        'colLG_BULL
        '
        Me.colLG_BULL.FieldName = "LG_BULL"
        Me.colLG_BULL.Name = "colLG_BULL"
        Me.colLG_BULL.Visible = True
        Me.colLG_BULL.VisibleIndex = 22
        '
        'colMED_BULL
        '
        Me.colMED_BULL.FieldName = "MED_BULL"
        Me.colMED_BULL.Name = "colMED_BULL"
        Me.colMED_BULL.Visible = True
        Me.colMED_BULL.VisibleIndex = 23
        '
        'colMED_L_BULL
        '
        Me.colMED_L_BULL.FieldName = "MED_L_BULL"
        Me.colMED_L_BULL.Name = "colMED_L_BULL"
        Me.colMED_L_BULL.Visible = True
        Me.colMED_L_BULL.VisibleIndex = 24
        '
        'colSM_BULL
        '
        Me.colSM_BULL.FieldName = "SM_BULL"
        Me.colSM_BULL.Name = "colSM_BULL"
        Me.colSM_BULL.Visible = True
        Me.colSM_BULL.VisibleIndex = 25
        '
        'colUNKNOWN
        '
        Me.colUNKNOWN.FieldName = "UNKNOWN"
        Me.colUNKNOWN.Name = "colUNKNOWN"
        Me.colUNKNOWN.Visible = True
        Me.colUNKNOWN.VisibleIndex = 26
        '
        'colYBULL_ALL
        '
        Me.colYBULL_ALL.FieldName = "YBULL_ALL"
        Me.colYBULL_ALL.Name = "colYBULL_ALL"
        Me.colYBULL_ALL.Visible = True
        Me.colYBULL_ALL.VisibleIndex = 27
        '
        'colYBULL_GTSF
        '
        Me.colYBULL_GTSF.FieldName = "YBULL_GTSF"
        Me.colYBULL_GTSF.Name = "colYBULL_GTSF"
        Me.colYBULL_GTSF.Visible = True
        Me.colYBULL_GTSF.VisibleIndex = 28
        '
        'colYBULL_SF
        '
        Me.colYBULL_SF.FieldName = "YBULL_SF"
        Me.colYBULL_SF.Name = "colYBULL_SF"
        Me.colYBULL_SF.Visible = True
        Me.colYBULL_SF.VisibleIndex = 29
        '
        'colMOOSE
        '
        Me.colMOOSE.FieldName = "MOOSE"
        Me.colMOOSE.Name = "colMOOSE"
        Me.colMOOSE.Visible = True
        Me.colMOOSE.VisibleIndex = 30
        '
        'colSubAreaSurveyed_SqMi
        '
        Me.colSubAreaSurveyed_SqMi.FieldName = "SubAreaSurveyed_SqMi"
        Me.colSubAreaSurveyed_SqMi.Name = "colSubAreaSurveyed_SqMi"
        Me.colSubAreaSurveyed_SqMi.Visible = True
        Me.colSubAreaSurveyed_SqMi.VisibleIndex = 31
        '
        'colSubAreaAverageSearchEffort
        '
        Me.colSubAreaAverageSearchEffort.FieldName = "SubAreaAverageSearchEffort"
        Me.colSubAreaAverageSearchEffort.Name = "colSubAreaAverageSearchEffort"
        Me.colSubAreaAverageSearchEffort.Visible = True
        Me.colSubAreaAverageSearchEffort.VisibleIndex = 32
        '
        'colMethodologyUsed
        '
        Me.colMethodologyUsed.FieldName = "MethodologyUsed"
        Me.colMethodologyUsed.Name = "colMethodologyUsed"
        Me.colMethodologyUsed.Visible = True
        Me.colMethodologyUsed.VisibleIndex = 33
        '
        'colResultsSource
        '
        Me.colResultsSource.FieldName = "ResultsSource"
        Me.colResultsSource.Name = "colResultsSource"
        Me.colResultsSource.Visible = True
        Me.colResultsSource.VisibleIndex = 34
        '
        'colComments2
        '
        Me.colComments2.FieldName = "Comments"
        Me.colComments2.Name = "colComments2"
        Me.colComments2.Visible = True
        Me.colComments2.VisibleIndex = 35
        '
        'colRecordInsertedDate2
        '
        Me.colRecordInsertedDate2.FieldName = "RecordInsertedDate"
        Me.colRecordInsertedDate2.Name = "colRecordInsertedDate2"
        Me.colRecordInsertedDate2.Visible = True
        Me.colRecordInsertedDate2.VisibleIndex = 36
        '
        'colRecordInsertedBy2
        '
        Me.colRecordInsertedBy2.FieldName = "RecordInsertedBy"
        Me.colRecordInsertedBy2.Name = "colRecordInsertedBy2"
        Me.colRecordInsertedBy2.Visible = True
        Me.colRecordInsertedBy2.VisibleIndex = 37
        '
        'colValidatedDate2
        '
        Me.colValidatedDate2.FieldName = "ValidatedDate"
        Me.colValidatedDate2.Name = "colValidatedDate2"
        Me.colValidatedDate2.Visible = True
        Me.colValidatedDate2.VisibleIndex = 38
        '
        'colValidatedBy2
        '
        Me.colValidatedBy2.FieldName = "ValidatedBy"
        Me.colValidatedBy2.Name = "colValidatedBy2"
        Me.colValidatedBy2.Visible = True
        Me.colValidatedBy2.VisibleIndex = 39
        '
        'GridControl1
        '
        Me.GridControl1.Location = New System.Drawing.Point(78, 34)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(400, 200)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'AbstractRepositoryItemMemoEdit
        '
        Me.AbstractRepositoryItemMemoEdit.Name = "AbstractRepositoryItemMemoEdit"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 786)
        Me.Controls.Add(Me.MainXtraTabControl)
        Me.Controls.Add(Me.DockPanel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.MooseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GSPE_SurveysBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GSPEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GSPE_DensityEstimatesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GSPE_PopulationEstimatesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GSPE_ResultsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        CType(Me.ListBoxControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SurveyVGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MainXtraTabControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainXtraTabControl.ResumeLayout(False)
        Me.SurveyDetailsXtraTabPage.ResumeLayout(False)
        Me.ResultsXtraTabPage.ResumeLayout(False)
        Me.ResultsSplitContainer.Panel1.ResumeLayout(False)
        Me.ResultsSplitContainer.Panel2.ResumeLayout(False)
        CType(Me.ResultsSplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResultsSplitContainer.ResumeLayout(False)
        CType(Me.PopulationGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResultsSplitContainer2.Panel1.ResumeLayout(False)
        Me.ResultsSplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.ResultsSplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResultsSplitContainer2.ResumeLayout(False)
        CType(Me.DensityGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResultsSplitContainer3.Panel1.ResumeLayout(False)
        CType(Me.ResultsSplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResultsSplitContainer3.ResumeLayout(False)
        CType(Me.ResultsGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AbstractRepositoryItemMemoEdit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MooseDataSet As MooseDataSet
    Friend WithEvents GSPE_SurveysBindingSource As BindingSource
    Friend WithEvents GSPE_SurveysTableAdapter As MooseDataSetTableAdapters.GSPE_SurveysTableAdapter
    Friend WithEvents TableAdapterManager As MooseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents GSPETableAdapter As MooseDataSetTableAdapters.GSPETableAdapter
    Friend WithEvents GSPEBindingSource As BindingSource
    Friend WithEvents GSPE_DensityEstimatesTableAdapter As MooseDataSetTableAdapters.GSPE_DensityEstimatesTableAdapter
    Friend WithEvents GSPE_DensityEstimatesBindingSource As BindingSource
    Friend WithEvents GSPE_PopulationEstimatesTableAdapter As MooseDataSetTableAdapters.GSPE_PopulationEstimatesTableAdapter
    Friend WithEvents GSPE_PopulationEstimatesBindingSource As BindingSource
    Friend WithEvents GSPE_ResultsTableAdapter As MooseDataSetTableAdapters.GSPE_ResultsTableAdapter
    Friend WithEvents GSPE_ResultsBindingSource As BindingSource
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents ListBoxControl1 As DevExpress.XtraEditors.ListBoxControl
    Friend WithEvents MainXtraTabControl As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents SurveyDetailsXtraTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents SurveyVGridControl As DevExpress.XtraVerticalGrid.VGridControl
    Friend WithEvents rowSurveyName As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowYear As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowNetwork As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowPark As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowSeason As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowStartDate As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowEndDate As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowAreaSurveyed_mi As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowAverageSearchEffort As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowMethodology As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowProtocolVersion As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowProtocolReferenceCode As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowPersonnel As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowReportReferenceCode As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowReportLink As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowDeliverablesDatasetReferenceCode As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowDataSource As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowDataResourcesDirectory As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowAbstract As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowSummary As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowDatasetProcessingSteps As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowComments As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowRecordInsertedDate As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowRecordInsertedBy As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowValidatedDate As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents rowValidatedBy As DevExpress.XtraVerticalGrid.Rows.EditorRow
    Friend WithEvents ResultsXtraTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents ResultsSplitContainer As SplitContainer
    Friend WithEvents PopulationGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSurveyName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colParkSubArea As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAnalysis_Column As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStrata As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colConfidence As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPopulation_Estimate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStandard_Error As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLower_Limit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUpper_Limit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProportion_of_Mean As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStrata_Column As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAnalysis_Area As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCounted_Column As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnit_Area_Column As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSurveyArea As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSampledArea As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIntensity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRelativePrecision As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSightabilityCorrectionFactor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDensity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComments As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReportDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAnalysisPerformedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPopulationEstimateSource As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRecordInsertedDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRecordInsertedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValidatedDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValidatedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ResultsSplitContainer2 As SplitContainer
    Friend WithEvents DensityGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSurveyName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colParkSubArea1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStratum As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDensity_Estimate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDensity_AreaSurveyed_SqMi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDensity_AverageSearchEffort As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDensityEstimateMethodology As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDensityEstimateSource As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReportDate1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComments1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRecordInsertedDate1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRecordInsertedBy1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValidatedDate1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValidatedBy1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ResultsSplitContainer3 As SplitContainer
    Friend WithEvents ResultsGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSurveyName2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colParkSubArea2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBullCowRatio As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCalfCowRatio As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCalfAdultRatio As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colADULT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBULL_30_40 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBULL_30_50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBULL_30_60 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBULL_41_50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBULL_ALL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBULL_GT_50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBULL_GT_60 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBULL_GTE_50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBULL_LT_30 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBULL_LT_50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCALF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCOW As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCOW_W_0 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCOW_W_1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCOW_W_2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCOW_W_3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLG_BULL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMED_BULL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMED_L_BULL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSM_BULL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUNKNOWN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colYBULL_ALL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colYBULL_GTSF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colYBULL_SF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMOOSE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSubAreaSurveyed_SqMi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSubAreaAverageSearchEffort As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMethodologyUsed As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colResultsSource As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComments2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRecordInsertedDate2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRecordInsertedBy2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValidatedDate2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colValidatedBy2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents AbstractRepositoryItemMemoEdit As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
End Class
