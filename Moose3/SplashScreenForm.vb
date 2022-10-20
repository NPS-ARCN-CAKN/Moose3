Public Class SplashScreenForm
    Private Sub SplashScreenForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.VersionLabel.Text = "Version " & My.Application.Info.Version.ToString & vbNewLine &
        My.Application.Info.Copyright & " " & Year(Now)

        Me.DescriptionLabel.Text = "Loading data from " & vbNewLine &
            My.Settings.MooseConnectionString & vbNewLine &
            "Client: " & My.User.Name & ", " & Now
    End Sub
End Class