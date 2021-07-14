Module Utilities


    Public Sub OpenDataStoreReference(ReferenceCode As Integer)
        If IsNumeric(ReferenceCode) = True Then
            Dim URL As String = My.Settings.IRMADataStoreReferencePrefix & ReferenceCode.ToString
            Try
                Process.Start(URL)
            Catch ex As Exception
                MsgBox("Could not open report reference" & URL)
            End Try
        End If
    End Sub

End Module
