Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraVerticalGrid
Imports DevExpress.XtraVerticalGrid.Rows
Imports SkeeterUtilities.DataFileToDataTableConverters.DataFileToDataTableConverters

Public Class Form1

    ''' <summary>
    ''' Loads the data from the moose database into the local memory copy of it, MooseDataset
    ''' </summary>
    Private Sub LoadDataset()
        Try
            Me.HeaderLabel.Text = "Connecting: " & My.Settings.MooseConnectionString
            Me.GSPE_SurveysTableAdapter.Fill(Me.MooseDataSet.GSPE_Surveys)
            Me.GSPE_ResultsTableAdapter.Fill(Me.MooseDataSet.GSPE_Results)
            Me.GSPE_PopulationEstimatesTableAdapter.Fill(Me.MooseDataSet.GSPE_PopulationEstimates)
            Me.GSPE_DensityEstimatesTableAdapter.Fill(Me.MooseDataSet.GSPE_DensityEstimates)
            Me.GSPETableAdapter.Fill(Me.MooseDataSet.GSPE) 'GSPE data table

            Dim SurveyUnitSetsDataTable As DataTable = GetDataTableFromSQLServerDatabase(My.Settings.MooseConnectionString, "SELECT SurveyUnitSet FROM SurveyUnitSets ORDER BY SurveyUnitSet")
            For Each Row As DataRow In SurveyUnitSetsDataTable.Rows
                Me.SurveyUnitSetsRepositoryItemComboBox.Items.Add(Row.Item("SurveyUnitSet").trim)
            Next

        Catch ex As Exception
            MsgBox(ex.Message & "  " & System.Reflection.MethodBase.GetCurrentMethod.Name)
            Me.HeaderLabel.Text = "Database connection error: " & ex.Message
        End Try
    End Sub
    ''' <summary>
    ''' Saves all the changes from the local in memory dataset back to the database
    ''' </summary>
    Private Sub SaveDataset()
        Try
            Me.Validate()

            'End all pending edits
            EndEdits()

            'Send deletes, inserts and updates
            Me.TableAdapterManager.UpdateAll(Me.MooseDataSet)

        Catch ex As Exception
            MsgBox(ex.Message & "  " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try

    End Sub

    ''' <summary>
    ''' Ends all pending edits on the various binding sources
    ''' </summary>
    Private Sub EndEdits()
        'End all pending edits
        Me.GSPEBindingSource.EndEdit()
        Me.GSPE_PopulationEstimatesBindingSource.EndEdit()
        Me.GSPE_DensityEstimatesBindingSource.EndEdit()
        Me.GSPE_ResultsBindingSource.EndEdit()
        Me.GSPE_SurveysBindingSource.EndEdit()
    End Sub

    ''' <summary>
    ''' Determines if any GSPE data record related to SurveyName is certified, if so, returns True, otherwise False.
    ''' </summary>
    ''' <param name="SurveyName">Survey name. String.</param>
    ''' <returns></returns>
    Private Function GSPEDatasetIsCertified(SurveyName As String) As Boolean
        Dim IsCertified As Boolean = True
        Try
            'Get a DataView of certified GSPE records for the Survey
            Dim Filter As String = "SurveyName='" & SurveyName.Trim & "' And CertificationLevel='Certified'"
            Dim DV As New DataView(MooseDataSet.Tables("GSPE"), Filter, "", DataViewRowState.CurrentRows)
            If DV.Count > 0 Then
                IsCertified = True
            Else
                IsCertified = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message & "  " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try
        Return IsCertified
    End Function

    ''' <summary>
    ''' Queries the database for data table column descriptions and loads them into data grid view column toot tips
    ''' </summary>
    Private Sub LoadGridColumnDescriptions()
        Try
            'Get the columns descriptions from the database and load them into the tooltips of the matching column in the datagridview
            Dim TableName As String = "GSPE_PopulationEstimates"
            Dim DGV As DataGridView = Me.GSPE_PopulationEstimatesDataGridView
            Dim ColumnsDescriptionsSQL As String = "SELECT [Column],ColumnDescription FROM DatabaseColumnsDescriptions WHERE [Table] = '" & TableName & "' Order By [Column]"
            Dim ColumnsDescriptionsDataTable As DataTable = GetDataTableFromSQLServerDatabase(My.Settings.MooseConnectionString, ColumnsDescriptionsSQL)

            'Loop through the datagridview columns looking for matches to the columns in the columnsdescriptionsdatatable
            For Each DGVColumn As DataGridViewColumn In DGV.Columns
                'Loop through the columns definitions datatable and look for a match
                Dim ColumnName As String = DGVColumn.DataPropertyName.Trim
                For Each DR As DataRow In ColumnsDescriptionsDataTable.Rows
                    If DR.Item("Column").ToString.Trim.ToLower = ColumnName.Trim.ToLower Then
                        DGVColumn.ToolTipText = DR.Item("ColumnDescription")
                    End If
                Next
            Next
        Catch ex As Exception
            MsgBox(ex.Message & "  " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try
    End Sub

    ''' <summary>
    ''' Sets up the various long text editors in the vertical grid control. Basically, out of the box the vertical grid control does not size or wrap long text very
    ''' well, it just leaves the row height small and adds an ellipse so you have to click it to see it. This Sub builds memo editors and assigns them to the 
    ''' long text fields so that they are easier to see at a glance.
    ''' </summary>
    Private Sub SetUpSurveyVGridControlRowEditors()
        'Create a RepositoryItemMemoEdit editor to handle the Summary data field
        Dim AbstractMemoEdit As New RepositoryItemMemoEdit
        Dim DatasetProcessingStepsMemoEdit As New RepositoryItemMemoEdit
        Dim SummaryMemoEdit As New RepositoryItemMemoEdit
        Dim CommentsMemoEdit As New RepositoryItemMemoEdit
        AbstractMemoEdit.WordWrap = True
        DatasetProcessingStepsMemoEdit.WordWrap = True
        SummaryMemoEdit.WordWrap = True
        CommentsMemoEdit.WordWrap = True
        rowAbstract.Properties.RowEdit = AbstractMemoEdit
        rowDatasetProcessingSteps.Properties.RowEdit = DatasetProcessingStepsMemoEdit
        rowSummary.Properties.RowEdit = SummaryMemoEdit 'Set rowSummary's row editor to SummaryMemoEdit
        rowComments.Properties.RowEdit = CommentsMemoEdit
    End Sub


    ''' <summary>
    ''' Asks the user if they want to save pending edits back to the database.
    ''' </summary>
    Private Sub AskToSaveDataset()
        Try
            If Me.MooseDataSet.HasChanges = True Then
                If MsgBox("Save?", MsgBoxStyle.YesNo, "Save?") = MsgBoxResult.Yes Then
                    SaveDataset()
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Accesses the IRMA reference code in the SurveyVGridControl in ReferenceCodeColumnName and attempts to open the Data Store reference
    ''' </summary>
    ''' <param name="ReferenceCodeColumnName">Name of the column containing the Data Store reference code.</param>
    Private Sub OpenSurveyIRMAReference(ReferenceCodeColumnName As String)
        Try
            Dim RefCode As Integer = CInt(Me.SurveyVGridControl.GetCellValue(ReferenceCodeColumnName, Me.SurveyVGridControl.FocusedRecord))
            If RefCode > 0 Then
                Dim URL As String = My.Settings.IRMAReferenceURLPrefix & RefCode
                Process.Start(URL)
            End If
        Catch ex As Exception
            MsgBox(ex.Message & "  " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try
    End Sub


    Private Sub AddNewSurveyRecord()
        Try
            Dim NewSurveyName As String = InputBox("Enter a name for the new survey", "Add a new survey record")
            Dim SurveyYear As String = InputBox("What year did the survey take place?", "Year")
            If NewSurveyName.Trim.Length > 0 Then
                If SurveyYear.Trim.Length > 0 Then
                    If IsNumeric(SurveyYear) = True Then
                        Dim NewGSPE_SurveyDataRow As DataRow = MooseDataSet.Tables("GSPE_Surveys").NewRow
                        With NewGSPE_SurveyDataRow
                            .Item("SurveyName") = NewSurveyName.Trim
                            .Item("Year") = CInt(SurveyYear)
                            .Item("DatasetProcessingSteps") = Now & " " & My.User.Name & ": " & NewSurveyName & " survey record created."
                            .Item("RecordInsertedDate") = Now
                            .Item("RecordInsertedBy") = My.User.Name
                        End With
                        MooseDataSet.Tables("GSPE_Surveys").Rows.Add(NewGSPE_SurveyDataRow)
                        MsgBox("Your new survey record, " & NewSurveyName & " is now available in the surveys inventory selector.")

                    Else
                        MsgBox("Year must be numeric.")

                    End If
                Else
                    MsgBox("Survey year is required.")
                End If
            Else
                MsgBox("Survey name is required.")
            End If
        Catch ex As Exception
            MsgBox(ex.Message & "  " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try
    End Sub

    ''' <summary>
    ''' Appends a dated and signed comment prefix to the contents of TextBoxToEdit.
    ''' </summary>
    ''' <param name="TextboxToEdit">The TextBox to append the comment to. TextBox.</param>
    Private Sub AddSignedDatedCommentToTextBox(TextboxToEdit As TextBox)
        Dim Comment As String = TextboxToEdit.Text.Trim
        Comment = Comment & vbNewLine & Now & " " & My.User.Name & ":"
        TextboxToEdit.Text = Comment
    End Sub

    Private Sub UpdateHeaderLabel()
        'update the header label with the survey name
        Dim SurveyName As String = Me.SurveysListBoxControl.Text.Trim
        Me.HeaderLabel.Text = SurveyName

        'load some info about the survey into the header
        Try
            'Convey the number of GSPE records
            Me.SurveyDetailsLabel.Text = "Available GSPE records: " & GSPEBindingSource.Count

            'Convey the number of certified records
            Dim CertifiedRecordCount As Integer = 0
            Dim Filter As String = "SurveyName='" & SurveyName & "' And CertificationLevel='Certified'"
            Dim DV As New DataView(MooseDataSet.Tables("GSPE"), Filter, "", DataViewRowState.CurrentRows)
            CertifiedRecordCount = DV.Count
            Me.SurveyDetailsLabel.Text = Me.SurveyDetailsLabel.Text & " Certified records: " & CertifiedRecordCount

            'Number of polygons
            Dim Sql As String = "SELECT Count(ID) As n FROM GSPE where SurveyName='" & SurveyName & "' and SurveyUnitSet is not NULL and LTRIM(RTRIM(Surveyunitset))<> ''"
            Dim PolygonsDataTable As DataTable = GetDataTableFromSQLServerDatabase(My.Settings.MooseConnectionString, Sql)

            If PolygonsDataTable.Rows.Count = 1 Then
                Me.SurveyDetailsLabel.Text = Me.SurveyDetailsLabel.Text.Trim & " Units: " & PolygonsDataTable.Rows(0).Item("n")
            Else
                Me.SurveyDetailsLabel.Text = Me.SurveyDetailsLabel.Text.Trim & " Units: 0"
            End If

            'Append instructions for accessing the ContextMenu
            Me.SurveyDetailsLabel.Text = Me.SurveyDetailsLabel.Text.Trim & vbNewLine & "Right click grid for options."
        Catch ex As Exception
            Me.SurveyDetailsLabel.Text = "Could not retrieve survey details: " & ex.Message
        End Try

    End Sub


    'Private Sub LoadParkSubAreasIntoDataGridViews()
    '    Try
    '        'ParkSubAreaComboBox_PopEst
    '        'Dim ParkSubAreasDataTable As DataTable = GetDataTableFromSQLServerDatabase()
    '        Dim SubAreasDataTable As DataTable = MooseDataSet.Tables("GSPE_PopulationEstimates").DefaultView.ToTable(True, "ParkSubArea")
    '        For Each SubAreaDataRow As DataRow In SubAreasDataTable.Rows
    '            Dim ParkSubArea As String = SubAreaDataRow.Item("ParkSubArea").trim
    '            Debug.Print(ParkSubArea)
    '            'Me.ParkSubAreaComboBox_PopEst.Items.Add(ParkSubArea)
    '        Next
    '    Catch ex As Exception
    '        Debug.Print(ex.Message & "  " & System.Reflection.MethodBase.GetCurrentMethod.Name)
    '    End Try

    'End Sub







    ' -----------------------------------------------------------------------------------------------------------------------
    '=================================================================================================

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load the data into the form
        LoadDataset()

        'Set up the grid controls the way I like them
        SetUpGridControl(Me.GSPEGridControl, True, True, False)

        'Set up survey vertical grid control
        SetUpVGridControl(Me.SurveyVGridControl)

        'Set up the survey VGridControl's long field editors.
        SetUpSurveyVGridControlRowEditors()

        'Set up the pivot grid controls
        SetUpPivotGridControl(Me.GSPEPivotGridControl)

        'Autosize the datagridview columns
        With Me.GSPE_PopulationEstimatesDataGridView
            .Dock = DockStyle.Fill
            .AutoResizeColumns(DataGridViewAutoSizeColumnMode.DisplayedCells)
            .AutoResizeColumnHeadersHeight()
            .ScrollBars = ScrollBars.Both
        End With

        LoadGridColumnDescriptions()

        'Me.DensityEstimatesDataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnMode.AllCellsExceptHeader)
        'Me.ResultsDataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnMode.AllCellsExceptHeader)

    End Sub



    Private Sub OpenReportReferenceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenReportReferenceToolStripMenuItem.Click
        OpenSurveyIRMAReference("ReportReferenceCode")
    End Sub



    Private Sub OpenDeliverablesReferenceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenDeliverablesReferenceToolStripMenuItem.Click
        OpenSurveyIRMAReference("DeliverablesDatasetReferenceCode")
    End Sub

    Private Sub OpenProtocolReferenceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenProtocolReferenceToolStripMenuItem.Click
        OpenSurveyIRMAReference("ProtocolReferenceCode")
    End Sub

    Private Sub ListBoxControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SurveysListBoxControl.SelectedIndexChanged
        UpdateHeaderLabel
    End Sub
    Private Sub OpenReportLinkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenReportLinkToolStripMenuItem.Click
        Try
            Dim ReportLink As String = Me.SurveyVGridControl.GetCellValue("ReportLink", Me.SurveyVGridControl.FocusedRecord)
            Process.Start(ReportLink)
        Catch ex As Exception
            MsgBox(ex.Message & "  " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try
    End Sub

    Private Sub OpenDataDirectoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenDataDirectoryToolStripMenuItem.Click
        Try
            Dim DataDirectoryPath As String = Me.SurveyVGridControl.GetCellValue("DataResourcesDirectory", Me.SurveyVGridControl.FocusedRecord)
            Process.Start(DataDirectoryPath)
        Catch ex As Exception
            MsgBox(ex.Message & "  " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        AskToSaveDataset()
    End Sub

    Private Sub SaveToolStripButton_Click(sender As Object, e As EventArgs) Handles SaveToolStripButton.Click
        AskToSaveDataset()
    End Sub

    Private Sub LoadDatasetToolStripButton_Click(sender As Object, e As EventArgs) Handles LoadDatasetToolStripButton.Click
        AskToSaveDataset()
        LoadDataset()
    End Sub

    Private Sub DataShaperToolStripButton_Click(sender As Object, e As EventArgs) Handles DataShaperToolStripButton.Click
        Dim DataShaperForm As New DataShaperForm
        DataShaperForm.Show()

    End Sub

    Private Sub GSPE_SurveysBindingSource_PositionChanged(sender As Object, e As EventArgs) Handles GSPE_SurveysBindingSource.PositionChanged
        'End edits on binding sources
        EndEdits()

        'Lock the interface on detection of certified records
        Dim SurveyName As String = Me.SurveysListBoxControl.Text.Trim
        Dim SurveyDataIsCertified As Boolean = GSPEDatasetIsCertified(SurveyName)
        Dim GV As GridView = TryCast(Me.GSPEGridControl.MainView, GridView)
        GV.OptionsBehavior.ReadOnly = SurveyDataIsCertified

        'Put a message in the GSPE toolstriplabel telling user they may or may not edit certified data
        If SurveyDataIsCertified = True Then
            Me.GSPEDatasetCertificationToolStripLabel.Text = "The current GSPE dataset may not be edited because it contains certified records."
        Else
            Me.GSPEDatasetCertificationToolStripLabel.Text = ""
        End If

    End Sub

    Private Sub ExportPivotGridToolStripButton_Click(sender As Object, e As EventArgs) Handles ExportPivotGridToolStripButton.Click
        Try
            'Get the current survey name
            Dim SurveyName As String = Me.SurveysListBoxControl.Text.Trim

            'Get the requested export format and set up parameters for the savefiledialog
            Dim ExportFormat As String = Me.ExportPivotGridToolStripComboBox.Text.Trim
            Dim FileFilter As String = ""
            Dim FileExtension As String = ""

            'Determine which export format is needed
            If ExportFormat = "" Then
                MsgBox("Please select an export file format.")
                Me.ExportPivotGridToolStripComboBox.Focus()
            ElseIf ExportFormat = "Excel" Then
                FileFilter = "Excel files (*.xlsx)|(*.xlsx)"
                FileExtension = "xlsx"
            ElseIf ExportFormat = "CSV" Then
                FileFilter = "Comma delimited text files (*.csv)|(*.csv)"
                FileExtension = "csv"
            End If

            'Open a save file dialog to allow the user to save the file someplace
            Dim SFD As New SaveFileDialog
            With SFD
                .AddExtension = True
                .DefaultExt = FileExtension
                .FileName = SurveyName.Trim & "." & FileExtension
                .Filter = FileFilter
            End With

            'Show the dialog
            If SFD.ShowDialog = DialogResult.OK Then
                'Make a path to the export file
                Dim ExportPath As String = SFD.FileName

                'Now export the data in the requested format
                If ExportFormat = "Excel" Then
                    Me.GSPEPivotGridControl.ExportToXlsx(ExportPath)
                ElseIf ExportFormat = "CSV" Then
                    Me.GSPEPivotGridControl.ExportToCsv(ExportPath)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message & "  " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try
    End Sub

    Private Sub GSPEGridControlExportToolStripButton_Click(sender As Object, e As EventArgs) Handles GSPEGridControlExportToolStripButton.Click
        Try
            'Get the current survey name
            Dim SurveyName As String = Me.SurveysListBoxControl.Text.Trim

            'Get the requested export format and set up parameters for the savefiledialog
            Dim ExportFormat As String = GSPEGridControlExportFormatToolStripComboBox.Text.Trim
            Dim FileFilter As String = ""
            Dim FileExtension As String = ""

            'Determine which export format is needed
            If ExportFormat = "" Then
                MsgBox("Please select an export file format.")
                Me.GSPEGridControlExportFormatToolStripComboBox.Focus()
            ElseIf ExportFormat = "Excel" Then
                FileFilter = "Excel files (*.xlsx)|(*.xlsx)"
                FileExtension = "xlsx"
            ElseIf ExportFormat = "CSV" Then
                FileFilter = "Comma delimited text files (*.csv)|(*.csv)"
                FileExtension = "csv"
            End If

            'Open a save file dialog to allow the user to save the file someplace
            Dim SFD As New SaveFileDialog
            With SFD
                .AddExtension = True
                .DefaultExt = FileExtension
                .FileName = SurveyName.Trim & "." & FileExtension
                .Filter = FileFilter
            End With

            'Show the dialog
            If SFD.ShowDialog = DialogResult.OK Then
                'Make a path to the export file
                Dim ExportPath As String = SFD.FileName

                'Now export the data in the requested format
                If ExportFormat = "Excel" Then
                    Me.GSPEGridControl.ExportToXlsx(ExportPath)
                ElseIf ExportFormat = "CSV" Then
                    Me.GSPEGridControl.ExportToCsv(ExportPath)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message & "  " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try
    End Sub

    Private Sub OpenCAKNMooseMonitoringSharedDirectoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenCAKNMooseMonitoringSharedDirectoryToolStripMenuItem.Click
        Try
            StartProcess(My.Settings.CAKNSharedMooseDirectory)
        Catch ex As Exception
            MsgBox(ex.Message & "  " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try
    End Sub

    Private Sub OpenARCNMooseMonitoringSharedDirectoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenARCNMooseMonitoringSharedDirectoryToolStripMenuItem.Click
        Try
            StartProcess(My.Settings.ARCNSharedMooseDirectory)
        Catch ex As Exception
            MsgBox(ex.Message & "  " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try
    End Sub

    Private Sub ARCNMasterDataStoreReferenceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ARCNMasterDataStoreReferenceToolStripMenuItem.Click
        Try
            StartProcess(My.Settings.IRMAReferenceURLPrefix & My.Settings.ARCNProjectReferenceCode)
        Catch ex As Exception
            MsgBox(ex.Message & "  " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try
    End Sub

    Private Sub CAKNMasterDataStoreReferenceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CAKNMasterDataStoreReferenceToolStripMenuItem.Click
        Try
            StartProcess(My.Settings.IRMAReferenceURLPrefix & My.Settings.CAKNProjectReferenceCode)
        Catch ex As Exception
            MsgBox(ex.Message & "  " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try
    End Sub


    


    Private Sub GSPE_SurveysBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles GSPE_SurveysBindingSource.CurrentChanged
        EndEdits()

        'SetUpGridControl(Me.PopulationGridControl, False, True, False)
    End Sub

    Private Sub PopulationGridControl_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs)
        'Dim gridControl As GridControl = CType(sender, GridControl)
        'Dim currentView As GridView = CType(gridControl.FocusedView, GridView)
        'If e.KeyCode = Keys.Delete Then
        '    If MsgBox("Delete the current row?", MsgBoxStyle.YesNo, "Confirm delete.") = MsgBoxResult.Yes Then
        '        currentView.DeleteRow(currentView.FocusedRowHandle)
        '    End If
        'End If
    End Sub

    Private Sub PopEstGridView_InitNewRow(sender As Object, e As InitNewRowEventArgs)
        'Set up automatically the values for RecordInsertedDate and RecordInsertedBy.
        SetUpRecordInsertedByAndDateDefaultValues(sender, e)
    End Sub

    Private Sub DensityGridView_InitNewRow(sender As Object, e As InitNewRowEventArgs)
        'Set up automatically the values for RecordInsertedDate and RecordInsertedBy.
        SetUpRecordInsertedByAndDateDefaultValues(sender, e)
    End Sub

    Private Sub ResultsGridView_InitNewRow(sender As Object, e As InitNewRowEventArgs)
        'Set up automatically the values for RecordInsertedDate and RecordInsertedBy.
        SetUpRecordInsertedByAndDateDefaultValues(sender, e)
    End Sub

    Private Sub AddProcessingNoteToolStripButton_Click(sender As Object, e As EventArgs) Handles AddProcessingNoteToolStripButton.Click
        AddSignedDatedCommentToTextBox(Me.DatasetProcessingStepsTextBox)
    End Sub



    Private Sub NewSurveyRecordToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'allow user to add a new survey record
        AddNewSurveyRecord()
    End Sub

    Private Sub PopulationEstimatesDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles GSPE_PopulationEstimatesDataGridView.DataError
        Try
            MsgBox(e.Exception.Message)
        Catch ex As Exception
            MsgBox(ex.Message & "  " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try
    End Sub
    Private Sub PopulationEstimatesDataGridView_DefaultValuesNeeded(sender As Object, e As DataGridViewRowEventArgs) Handles GSPE_PopulationEstimatesDataGridView.DefaultValuesNeeded
        'Pre-enter metadata on new records
        e.Row.Cells("RecordInsertedDateDataGridViewTextBoxColumn").Value = Now
        e.Row.Cells("RecordInsertedByDataGridViewTextBoxColumn").Value = My.User.Name
        e.Row.Cells("PopulationEstimateSourceReferenceCodeDataGridViewTextBoxColumn").Value = -9999
        e.Row.Cells("PopulationEstimateSourceDataGridViewTextBoxColumn").Value = "REQUIRED: Enter a source for the estimate."
        e.Row.Cells("ParkSubAreaTextBox_PopEst").Value = "REQUIRED"
        e.Row.Cells("AnalysisColumnDataGridViewTextBoxColumn").Value = "REQUIRED: "
        e.Row.Cells("StrataDataGridViewTextBoxColumn").Value = "REQUIRED: "
        e.Row.Cells("ConfidenceDataGridViewTextBoxColumn").Value = "-9999"
    End Sub
    Private Sub DensityEstimatesDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles DensityEstimatesDataGridView.DataError
        Try
            MsgBox(e.Exception.Message)
        Catch ex As Exception
            MsgBox(ex.Message & "  " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try
    End Sub

    Private Sub ResultsDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles ResultsDataGridView.DataError
        Try
            MsgBox(e.Exception.Message)
        Catch ex As Exception
            MsgBox(ex.Message & "  " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try
    End Sub



    Private Sub DensityEstimatesDataGridView_DefaultValuesNeeded(sender As Object, e As DataGridViewRowEventArgs) Handles DensityEstimatesDataGridView.DefaultValuesNeeded
        'Pre-enter metadata on new records
        e.Row.Cells("RecordInsertedDateDataGridViewTextBoxColumn1").Value = Now
        e.Row.Cells("RecordInsertedByDataGridViewTextBoxColumn1").Value = My.User.Name
        e.Row.Cells("ParkSubAreaDataGridViewTextBoxColumn1").Value = "REQUIRED"
        e.Row.Cells("StratumDataGridViewTextBoxColumn").Value = "REQUIRED: "
        e.Row.Cells("AnalysisColumnDataGridViewTextBoxColumn1").Value = "REQUIRED: "
        e.Row.Cells("DensityEstimateSourceDataGridViewTextBoxColumn").Value = "REQUIRED: Enter a source for the estimate."
    End Sub

    Private Sub ResultsDataGridView_DefaultValuesNeeded(sender As Object, e As DataGridViewRowEventArgs) Handles ResultsDataGridView.DefaultValuesNeeded
        'Pre-enter metadata on new records
        e.Row.Cells("RecordInsertedDateDataGridViewTextBoxColumn2").Value = Now
        e.Row.Cells("RecordInsertedByDataGridViewTextBoxColumn2").Value = My.User.Name
        e.Row.Cells("ParkSubAreaDataGridViewTextBoxColumn2").Value = "REQUIRED"
        e.Row.Cells("ResultsSourceDataGridViewTextBoxColumn").Value = "REQUIRED: Enter a source for the estimate."
        e.Row.Cells("ResultID").Value = Guid.NewGuid.ToString
    End Sub

    Private Sub AddSurveyToolStripButton_Click(sender As Object, e As EventArgs) Handles AddSurveyToolStripButton.Click
        'Open a form to add a new survey to the inventory
        AddNewSurveyRecord()
    End Sub

    Private Sub AppendNewCommentToolStripButton_Click(sender As Object, e As EventArgs) Handles AppendNewCommentToolStripButton.Click
        'Append a signed, dated comment prefix to the comments box
        AddSignedDatedCommentToTextBox(Me.CommentsTextBox)
    End Sub






    'Private Sub PopulationEstimatesDataGridView_SelectionChanged(sender As Object, e As EventArgs) Handles PopulationEstimatesDataGridView.SelectionChanged
    '    Me.PopulationEstimatesDataGridView.EndEdit()
    '    Me.GSPE_PopulationEstimatesBindingSource.EndEdit()
    'End Sub

    'Private Sub DensityEstimatesDataGridView_SelectionChanged(sender As Object, e As EventArgs) Handles DensityEstimatesDataGridView.SelectionChanged
    '    Me.DensityEstimatesDataGridView.EndEdit()
    '    Me.GSPE_DensityEstimatesBindingSource.EndEdit()
    'End Sub

    'Private Sub ResultsDataGridView_SelectionChanged(sender As Object, e As EventArgs) Handles ResultsDataGridView.SelectionChanged
    '    Me.ResultsDataGridView.EndEdit()
    '    Me.GSPE_ResultsBindingSource.EndEdit()
    'End Sub

    'Private Sub SurveyVGridControl_SelectedChanged(sender As Object, e As DevExpress.XtraVerticalGrid.Events.SelectedChangedEventArgs) Handles SurveyVGridControl.SelectedChanged
    '    Me.GSPE_SurveysBindingSource.EndEdit()
    'End Sub



    'Private Sub PopulationEstimatesDataGridView_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles PopulationEstimatesDataGridView.CellValidating
    '    'Validate the entered data
    '    Dim DGV As DataGridView = sender
    '    Dim RequiredColumns As String = "SurveyName,ParkSubArea,Analysis_Column,Strata,Confidence,PopulationEstimateSource"
    '    Dim RequiredColumnNames As String() = RequiredColumns.Split(",")
    '    For Each ColumnName As String In RequiredColumnNames
    '        If DGV.Columns(e.ColumnIndex).HeaderText <> ColumnName Then
    '            Return
    '        Else
    '            If String.IsNullOrEmpty(e.FormattedValue) = True Then
    '                DGV.Rows(e.RowIndex).ErrorText = ColumnName & " is required."
    '                e.Cancel = True
    '            End If
    '        End If
    '    Next
    'End Sub

    'Private Sub PopulationEstimatesDataGridView_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles PopulationEstimatesDataGridView.CellEndEdit
    '    'Clear any row errors 
    '    Dim DGV As DataGridView = sender
    '    DGV.Rows(e.RowIndex).ErrorText = String.Empty
    'End Sub
End Class
