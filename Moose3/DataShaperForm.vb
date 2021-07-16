Imports SkeeterUtilities.DataFileToDataTableConverters.DataFileToDataTableConverters

Public Class DataShaperForm
    Private Sub DataShaperForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Get a list of tables and queries in the database
        Dim Sql As String = "SELECT *  FROM [Moose].[dbo].[DatabaseTableDescriptions] order by [Type], [TableName]"
        Dim TablesDataTable As DataTable = GetDataTableFromSQLServerDatabase(My.Settings.MooseConnectionString, Sql)
        Dim DT As DataTable = GetDataTableFromSQLServerDatabase(My.Settings.MooseConnectionString, Sql)
        Me.DataShaperPivotGridControl.DataSource = DT
        Me.DataShaperPivotGridControl.RetrieveFields()

        'Load the table names into the query selector combo box
        For Each Row As DataRow In DT.Rows
            Dim Type As String = Row.Item("Type")
            Dim TableName As String = Row.Item("TableName")
            Me.QuerySelectorToolStripComboBox.Items.Add(TableName & " (" & Type & ")")
        Next
    End Sub
End Class