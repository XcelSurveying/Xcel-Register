Public Class sortColumnsDGVData
    Public Sub sortTable(table As String)
        Dim SQL As New SQLControl
        Try
            If SQL.HasConnection = True Then
                Select Case table
                    Case "AreaCalcChecklist"
                        For Each col As DataGridViewColumn In formMain.DGVData.Columns

                            Select Case col.Name

                                Case "ID"
                                    col.DisplayIndex = 0
                                    'col.FillWeight = 100
                                    col.Visible = False

                                Case "Model/Layer"
                                    col.DisplayIndex = 1
                                    'col.FillWeight = 100
                                    'col.Visible = True

                                Case "Drawing Number"
                                    col.DisplayIndex = 2
                                    'col.HeaderText = "Created On"
                                    'col.DefaultCellStyle.Format = "d"
                                    'col.FillWeight = 75
                                    'col.Visible = True

                                Case "TQ/RFI"
                                    col.DisplayIndex = 3
                                    'col.HeaderText = "Created By"
                                    'col.FillWeight = 75
                                    'col.Visible = True

                                Case "Calc'd by"
                                    col.DisplayIndex = 4
                                    'col.HeaderText = ""
                                    'col.FillWeight = 30
                                    'col.Visible = True

                                Case Else
                                    'col.Visible = False

                            End Select

                        Next

                    Case "SurveyReportRegister"
                        For Each col As DataGridViewColumn In formMain.DGVData.Columns

                            Select Case col.Name

                                Case "ID"
                                    col.DisplayIndex = 0
                                    'col.FillWeight = 100
                                    col.Visible = False

                                Case "Date"
                                    col.DisplayIndex = 1
                                    'col.FillWeight = 100
                                    'col.Visible = True

                                Case "Document Name"
                                    col.DisplayIndex = 2
                                    'col.HeaderText = "Created On"
                                    'col.DefaultCellStyle.Format = "d"
                                    'col.FillWeight = 75
                                    'col.Visible = True

                                Case "Rev"
                                    col.DisplayIndex = 3
                                    'col.HeaderText = "Created By"
                                    'col.FillWeight = 75
                                    'col.Visible = True

                                Case "Title"
                                    col.DisplayIndex = 4
                                    'col.HeaderText = ""
                                    'col.FillWeight = 30
                                    'col.Visible = True

                                Case "Area"
                                    col.DisplayIndex = 5
                                    'col.HeaderText = ""
                                    'col.FillWeight = 30
                                    'col.Visible = True

                                Case "Description"
                                    col.DisplayIndex = 6
                                    'col.HeaderText = ""
                                    'col.FillWeight = 30
                                    'col.Visible = True

                                Case "Title"
                                    col.DisplayIndex = 7
                                    'col.HeaderText = ""
                                    'col.FillWeight = 30
                                    'col.Visible = True

                                Case "Surveyor"
                                    col.DisplayIndex = 8
                                    'col.HeaderText = ""
                                    'col.FillWeight = 30
                                    'col.Visible = True

                                Case "Comments"
                                    col.DisplayIndex = 9
                                    'col.HeaderText = ""
                                    'col.FillWeight = 30
                                    'col.Visible = True

                                Case "Created"
                                    col.DisplayIndex = 10
                                    'col.HeaderText = ""
                                    'col.FillWeight = 30
                                    'col.Visible = True

                                Case "Modified"
                                    col.DisplayIndex = 10
                                    'col.HeaderText = ""
                                    'col.FillWeight = 30
                                    'col.Visible = True

                                Case Else
                                    'col.Visible = False

                            End Select

                        Next

                    Case "FieldDataRegister"

                    Case "TqRfiRegister"

                End Select
            End If

        Catch ex As Exception

        End Try

    End Sub
End Class