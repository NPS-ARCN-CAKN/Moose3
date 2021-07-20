Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraVerticalGrid
Imports DevExpress.XtraVerticalGrid.Rows

Public Class Form1

    ''' <summary>
    ''' Loads the data from the moose database into the local memory copy of it, MooseDataset
    ''' </summary>
    Private Sub LoadDataset()
        Try
            Me.GSPE_SurveysTableAdapter.Fill(Me.MooseDataSet.GSPE_Surveys)
            Me.GSPE_ResultsTableAdapter.Fill(Me.MooseDataSet.GSPE_Results)
            Me.GSPE_PopulationEstimatesTableAdapter.Fill(Me.MooseDataSet.GSPE_PopulationEstimates)
            Me.GSPE_DensityEstimatesTableAdapter.Fill(Me.MooseDataSet.GSPE_DensityEstimates)
            Me.GSPETableAdapter.Fill(Me.MooseDataSet.GSPE) 'GSPE data table
            Me.GSPETableAdapter.Fill(Me.MooseDataSet.GSPE)
        Catch ex As Exception
            MsgBox(ex.Message & "  " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try


    End Sub
    ''' <summary>
    ''' Saves all the changes from the local in memory dataset back to the database
    ''' </summary>
    Private Sub SaveDataset()
        Try
            Me.Validate()

            'End all pending edits
            Me.GSPEBindingSource.EndEdit()
            Me.GSPE_PopulationEstimatesBindingSource.EndEdit()
            Me.GSPE_DensityEstimatesBindingSource.EndEdit()
            Me.GSPE_ResultsBindingSource.EndEdit()
            Me.GSPE_SurveysBindingSource.EndEdit()

            'Send deletes, inserts and updates
            Me.TableAdapterManager.UpdateAll(Me.MooseDataSet)

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
        AbstractMemoEdit.WordWrap = True
        DatasetProcessingStepsMemoEdit.WordWrap = True
        SummaryMemoEdit.WordWrap = True
        rowAbstract.Properties.RowEdit = AbstractMemoEdit
        rowDatasetProcessingSteps.Properties.RowEdit = DatasetProcessingStepsMemoEdit
        rowSummary.Properties.RowEdit = SummaryMemoEdit 'Set rowSummary's row editor to SummaryMemoEdit
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
                Dim URL As String = My.Settings.IRMADataStoreReferencePrefix & RefCode
                Process.Start(URL)
            End If
        Catch ex As Exception
            MsgBox(ex.Message & "  " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try
    End Sub















    ' -----------------------------------------------------------------------------------------------------------------------
    '=================================================================================================

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load the data into the form
        LoadDataset()

        'Set up the grid controls the way I like them
        SetUpGridControl(Me.PopulationGridControl, False, False, False)
        SetUpGridControl(Me.DensityGridControl, False, False, False)
        SetUpGridControl(Me.ResultsGridControl, False, False, False)
        SetUpGridControl(Me.GSPEGridControl, True, True, False)

        'Set up survey vertical grid control
        SetUpVGridControl(Me.SurveyVGridControl)

        'Set up the survey VGridControl's long field editors.
        SetUpSurveyVGridControlRowEditors()

        'Set up the pivot grid controls
        SetUpPivotGridControl(Me.GSPEPivotGridControl)

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
        Me.HeaderLabel.Text = Me.SurveysListBoxControl.Text
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
End Class
