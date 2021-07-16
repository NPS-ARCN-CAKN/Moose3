﻿Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
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


    Public Sub SetUpGridControl(GC As GridControl, ShowFooter As Boolean, ShowGroupPanel As Boolean, SetReadOnly As Boolean)
        GC.UseEmbeddedNavigator = True
        Dim GV As GridView = TryCast(GC.MainView, GridView)
        GV.OptionsBehavior.AllowAddRows = True
        GV.OptionsBehavior.AllowDeleteRows = True
        GV.OptionsBehavior.ReadOnly = SetReadOnly
        GV.BestFitColumns(True)
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


End Module