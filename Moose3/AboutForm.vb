Public Class AboutForm
    Private Sub AboutForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ApplicationPropertyGridControl.SelectedObject = My.Application.Info
        Me.SettingsPropertyGridControl.SelectedObject = My.Settings
    End Sub
End Class