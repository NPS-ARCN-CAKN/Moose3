Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraVerticalGrid
Imports DevExpress.XtraVerticalGrid.Rows

Module Utilities

    ''' <summary>
    ''' Saves the immediate contents of GridControl to the format specified by ExportFormat.
    ''' </summary>
    ''' <param name="GridControl">CridControl contents to export.</param>
    ''' <param name="ExportFormat">Export data format.</param>
    Public Sub SaveGridControlToExcel(GridControl As GridControl, ExportFormat As ExportFormat)
        Try
            'Build a save file dialog filter based on ExportFormat
            Dim Filter As String = ""
            If ExportFormat = ExportFormat.Csv Then
                Filter = "Comma Separated Values text files (*.csv)|*.csv"
            ElseIf ExportFormat = ExportFormat.Xlsx Then
                Filter = "Excel Files (*.xlsx)|*.xlsx"
            End If

            'Open a SaveFileDialog to allow the user to choose an export path.
            Dim SFD As New SaveFileDialog
            With SFD
                .Filter = Filter
                .AddExtension = True
                .DefaultExt = "." & ExportFormat.ToString
                .OverwritePrompt = True
                .Title = "Save results"
                .InitialDirectory = "C:\"
            End With

            'Show the save file dialog and if a path is chosen export the control's data to ExportFormat.
            If SFD.ShowDialog = vbOK Then
                Dim Path As String = SFD.FileName
                If ExportFormat = ExportFormat.Xlsx Then
                    GridControl.ExportToXlsx(Path)
                ElseIf ExportFormat = ExportFormat.Csv Then
                    GridControl.ExportToCsv(Path)
                End If

                'Ask if the user wants to open the exported file
                If MsgBox("Open the exported spreadsheet?", MsgBoxStyle.YesNo, "Open the exported spreadsheet?") = MsgBoxResult.Yes Then
                    Process.Start(Path)
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message & "  " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try
    End Sub

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

    ''' <summary>
    ''' Does the busy work of basically setting up a GridControl the way I like it. 
    ''' </summary>
    ''' <param name="GC"></param>
    ''' <param name="ShowFooter"></param>
    ''' <param name="ShowGroupPanel"></param>
    ''' <param name="SetReadOnly"></param>
    Public Sub SetUpGridControl(GC As GridControl, ShowFooter As Boolean, ShowGroupPanel As Boolean, SetReadOnly As Boolean)

        'You cannot delete a record in a GridControl without an embedded navigator. Weird but true, so I show it using this line.
        GC.UseEmbeddedNavigator = True

        'GridControls have a series of GridViews and they always have a MainView. This is where you set options.
        Dim GV As GridView = TryCast(GC.MainView, GridView)
        GV.BestFitColumns(False) 'I think this should be false to set the column widths to their contents automatically.(??????). Very strange
        GV.OptionsBehavior.AllowAddRows = True
        GV.OptionsBehavior.AllowDeleteRows = True
        GV.OptionsBehavior.ReadOnly = SetReadOnly
        GV.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom
        GV.OptionsView.BestFitMode = GridBestFitMode.Fast
        GV.OptionsView.ColumnAutoWidth = False
        GV.OptionsView.ShowFooter = ShowFooter
        GV.OptionsView.ShowGroupPanel = ShowGroupPanel
    End Sub

    ''' <summary>
    ''' Sets up a VGridControl the way I like it.
    ''' </summary>
    ''' <param name="VGC">VGridControl to set up.</param>
    Public Sub SetUpVGridControl(VGC As VGridControl)
        Try
            'Format each row of the control
            For Each VGridBaseRow As BaseRow In VGC.Rows
                With VGridBaseRow.AppearanceCell.TextOptions
                    .HAlignment = DevExpress.Utils.HorzAlignment.Near
                    .VAlignment = DevExpress.Utils.VertAlignment.Top
                    .WordWrap = True
                End With
            Next
        Catch ex As Exception
            MsgBox(ex.Message & "  " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try
    End Sub

    ''' <summary>
    ''' Sets up a PivotGridControl the way I like it
    ''' </summary>
    ''' <param name="PGC">PivotGridControl to set up.</param>
    Public Sub SetUpPivotGridControl(PGC As PivotGridControl)
        Try
            With PGC
                .BestFit()
                .BestFitColumnArea()
                .BestFitDataHeaders(True)
                .BestFitRowArea()
                .OptionsBehavior.BestFitMode = PivotGridBestFitMode.FieldValue
                .OptionsMenu.EnableFieldValueMenu = True
                .OptionsMenu.EnableFormatRulesMenu = True
                .OptionsMenu.EnableHeaderAreaMenu = True
                .Text = "Pivot grid text"

            End With

            For Each PGField As PivotGridField In PGC.Fields
                With PGField
                    .Options.AllowRunTimeSummaryChange = True
                    .BestFit()
                End With
            Next
        Catch ex As Exception
            MsgBox(ex.Message & "  " & System.Reflection.MethodBase.GetCurrentMethod.Name)
        End Try
    End Sub

    ''' <summary>
    ''' Returns the value of the specified column in a VGridControl
    ''' </summary>
    ''' <param name="VG">VGRidControl.</param>
    ''' <param name="ColumnName">Column name of the data to retrieve.</param>
    ''' <returns>String.</returns>
    Public Function GetVGridControlCellValue(VG As VGridControl, ColumnName As String) As String
        Dim ReturnValue As String = "" 'The value to be returned
        If ColumnName.Trim.Length > 0 Then 'Make sure we have a non-zero length ColumnName
            Try
                'See if the cell is DBNull
                If Not IsDBNull(VG.GetCellValue(ColumnName, VG.FocusedRecord)) Then
                    'Set the return value to the focused record's cell value
                    ReturnValue = VG.GetCellValue(ColumnName, VG.FocusedRecord)
                Else
                    ReturnValue = "The value of " & ColumnName & " is DBNULL."
                End If
            Catch ex As Exception
                MsgBox(ex.Message & "  " & System.Reflection.MethodBase.GetCurrentMethod.Name)
            End Try
        End If
        Return ReturnValue
    End Function

End Module
