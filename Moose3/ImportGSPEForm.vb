Public Class ImportGSPEForm

    Public Sub New(GSPEDataTable As DataTable)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.GSPEDataGridView.DataSource = GSPEDataTable
    End Sub

    Private Sub ImportGSPEForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class