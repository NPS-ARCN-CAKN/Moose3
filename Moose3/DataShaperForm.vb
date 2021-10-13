Imports DevExpress.XtraGrid.Views.Grid
Imports SkeeterUtilities.DataFileToDataTableConverters.DataFileToDataTableConverters

Public Class DataShaperForm

    Dim CurrentDataTable As New DataTable 'This will be the DataTable that holds the main interface's query contents
    Dim CurrentQuery As String = "" 'This will hold the current query that fills CurrentDataTable

    ''' <summary>
    ''' Loads the query selector combo box with available tables and queries in the moose database
    ''' </summary>
    Private Sub LoadQuerySelector()
        'Clear the query selector
        Me.QuerySelectorToolStripComboBox.Items.Clear()

        Try
            Dim Sql As String = "SELECT TableName,Table_Type,TableDescription FROM [Moose].[dbo].[DatabaseTableDescriptions] order by [Table_Type] ASC,[TableName]"
            Dim TablesDataTable As DataTable = GetDataTableFromSQLServerDatabase(My.Settings.MooseConnectionString, Sql)

            'Load the table names into the query selector combo box
            Me.QuerySelectorToolStripComboBox.Items.Add("") 'Empty row 
            'Add the tables and queries
            For Each Row As DataRow In TablesDataTable.Rows
                Dim Type As String = Row.Item("Table_Type")
                Dim TableName As String = Row.Item("TableName")
                Me.QuerySelectorToolStripComboBox.Items.Add(TableName)
            Next
        Catch ex As Exception
            MsgBox("Failed to retrieve a list of tables and queries from the database: " & ex.Message & "  " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try
    End Sub

    ''' <summary>
    ''' Loads a dataset into the main interface for shaping
    ''' </summary>
    ''' <param name="Sql">Query to load</param>
    Private Sub LoadDataTableIntoInterface(Sql As String)
        Try
            'Get a list of tables and queries in the database
            CurrentDataTable = GetDataTableFromSQLServerDatabase(My.Settings.MooseConnectionString, Sql)

            'Load the datatable into the grid control
            'Me.DataShaperGridControl.DataSource = Nothing
            With Me.DataShaperGridControl
                .DataSource = CurrentDataTable
                '.RefreshDataSource()
            End With
            Dim GV As GridView = TryCast(Me.DataShaperGridControl.MainView, GridView)
            With GV
                .RefreshData()
                .PopulateColumns()
            End With

                SetUpGridControl(Me.DataShaperGridControl, True, True, True)

            'Load the datatable into the pivot grid control
            Me.DataShaperPivotGridControl.DataSource = CurrentDataTable
            Me.DataShaperPivotGridControl.RetrieveFields()
        Catch ex As Exception
            MsgBox("Failed to retrieve the dataset from the database: " & ex.Message & "  " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try
    End Sub







    '==========================================================================================================
    '----------------------------------------------------------------------------------------------------------

    Private Sub DataShaperForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load a list of tables and queries into the selector
        LoadQuerySelector()
    End Sub

    Private Sub QuerySelectorToolStripComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles QuerySelectorToolStripComboBox.SelectedIndexChanged
        If Me.QuerySelectorToolStripComboBox.Text.Trim.Length > 0 Then
            CurrentQuery = "SELECT * FROM " & Me.QuerySelectorToolStripComboBox.Text.Trim
            LoadDataTableIntoInterface(CurrentQuery)
        End If
    End Sub

    Private Sub QuerySelectorToolStripComboBox_DropDown(sender As Object, e As EventArgs) Handles QuerySelectorToolStripComboBox.DropDown
        LoadQuerySelector()
    End Sub



    Private Sub RefreshToolStripButton_Click(sender As Object, e As EventArgs) Handles RefreshToolStripButton.Click
        Try
            CurrentDataTable = GetDataTableFromSQLServerDatabase(My.Settings.MooseConnectionString, CurrentQuery)
            Me.DataShaperPivotGridControl.DataSource = CurrentDataTable
            Me.DataShaperGridControl.DataSource = CurrentDataTable
        Catch ex As Exception
            MsgBox("Failed to refresh the dataset from the database: " & ex.Message & "  " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try
    End Sub

    Private Sub ExportGridControlToolStripButton_Click(sender As Object, e As EventArgs) Handles ExportGridControlToolStripButton.Click
        ExportGridControl(Me.DataShaperGridControl, "Moose data summary", True)
    End Sub
End Class