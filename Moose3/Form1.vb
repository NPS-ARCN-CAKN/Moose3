Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid

Public Class Form1

    Private Sub LoadDataset()
        Try
            Me.GSPE_ResultsTableAdapter.Fill(Me.MooseDataSet.GSPE_Results)
            Me.GSPE_PopulationEstimatesTableAdapter.Fill(Me.MooseDataSet.GSPE_PopulationEstimates)
            Me.GSPE_DensityEstimatesTableAdapter.Fill(Me.MooseDataSet.GSPE_DensityEstimates)
            ' Me.GSPETableAdapter.Fill(Me.MooseDataSet.GSPE)
            Me.GSPE_SurveysTableAdapter.Fill(Me.MooseDataSet.GSPE_Surveys)
        Catch ex As Exception
            MsgBox(ex.Message & "  " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try


    End Sub

    Private Sub SaveDataset()
        Try
            Me.Validate()
            Me.GSPE_SurveysBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.MooseDataSet)
        Catch ex As Exception
            MsgBox(ex.Message & "  " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try

    End Sub

    Private Sub SetUpGridControl(GC As GridControl)
        GC.UseEmbeddedNavigator = True
        Dim GV As GridView = TryCast(GC.MainView, GridView)
        GV.OptionsBehavior.AllowAddRows = True
        GV.OptionsBehavior.AllowDeleteRows = True
        GV.BestFitColumns(True)
        GV.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom
        GV.OptionsView.BestFitMode = GridBestFitMode.Fast
        GV.OptionsView.ColumnAutoWidth = False
        GV.OptionsView.ShowFooter = True
    End Sub







    ' -----------------------------------------------------------------------------------------------------------------------
    '=================================================================================================

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataset()
        SetUpGridControl(Me.PopulationGridControl)
        SetUpGridControl(Me.DensityGridControl)
        SetUpGridControl(Me.ResultsGridControl)


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
End Class
