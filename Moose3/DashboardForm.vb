Imports SkeeterUtilities.DataFileToDataTableConverters.DataFileToDataTableConverters
Public Class DashboardForm
    Private Sub DashboardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim Sql As String = "SELECT * FROM Dashboard"
            Dim DashboardDataTable As DataTable = GetDataTableFromSQLServerDatabase(My.Settings.MooseConnectionString, Sql)
            Me.GridControl1.DataSource = DashboardDataTable
        Catch ex As Exception
            MsgBox(ex.Message & " Failed to retrieve dashboard data: " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try
    End Sub
End Class