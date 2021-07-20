Imports DevExpress.XtraGrid.Views.Grid
Imports SkeeterUtilities.DataFileToDataTableConverters.DataFileToDataTableConverters

Public Class DataShaperForm

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

            Dim DT As DataTable = GetDataTableFromSQLServerDatabase(My.Settings.MooseConnectionString, Sql)

            'Load the datatable into the grid control
            'Me.DataShaperGridControl.DataSource = Nothing
            With Me.DataShaperGridControl
                .DataSource = DT
                .RefreshDataSource()
            End With
            Dim GV As GridView = TryCast(Me.DataShaperGridControl.MainView, GridView)
            With GV
                .RefreshData()
                .PopulateColumns()
            End With

                SetUpGridControl(Me.DataShaperGridControl, True, True, True)

            'Load the datatable into the pivot grid control
            Me.DataShaperPivotGridControl.DataSource = DT
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
            Dim Query As String = "SELECT * FROM " & Me.QuerySelectorToolStripComboBox.Text.Trim
            LoadDataTableIntoInterface(Query)
        End If
    End Sub

    Private Sub QuerySelectorToolStripComboBox_DropDown(sender As Object, e As EventArgs) Handles QuerySelectorToolStripComboBox.DropDown
        LoadQuerySelector()
    End Sub

    Private Sub ExportPivotGridToolStripButton_Click(sender As Object, e As EventArgs) Handles ExportPivotGridToolStripButton.Click
        Me.DataShaperPivotGridControl.ExportToXlsx("C:\temp\zPivotGridExport.xlsx")
    End Sub
End Class