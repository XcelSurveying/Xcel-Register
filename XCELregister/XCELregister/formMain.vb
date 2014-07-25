Option Explicit On

Public Class formMain
    Dim SQL As New SQLControl
    Dim export As New exportTables
    Dim activation As New Activation
    Dim queryString As String = "0"
    'Dim sortColumns As sortColumnsDGVData

    Private Sub formMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Print command button
        cmdPrintDGVData.Visible = False

        'Open main window Maximised
        Me.WindowState = FormWindowState.Maximized




        'PERFORM KEY CHECK BEFORE ANY ANYTHING ELSE
        If activation.WaitForActivation() = True Then
            Me.Enabled = True
        Else
            MessageBox.Show("Activation failed")
            End
        End If


        If SQL.HasConnection = True Then 'has connected
            initilizeDataGridView() 'Set visual params for data grid view
            setSearchStringAreaCalcChecklist()
            rbAreaCalcChecklist.Checked = True
            '-- Updates/Refreshes the data grid --
            SQL.RunQuery("SELECT * FROM AreaCalcChecklist ORDER BY Created DESC")
            refreshDataGridView()
        End If
    End Sub

    Private Sub initilizeDataGridView()
        ' Set the background color for all rows and for alternating rows.  
        ' The value for alternating rows overrides the value for all rows. 
        DGVData.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
        If DGVData.Columns(2).HeaderText = "Document Name" Then
            DGVData.Columns(2).DefaultCellStyle.Font = New Font("Tahoma", 8.25, FontStyle.Bold)
        End If
        If DGVData.Columns(1).HeaderText = "Job Ref Number" Then
            DGVData.Columns(1).DefaultCellStyle.Font = New Font("Tahoma", 8.25, FontStyle.Bold)
        End If
        'DGVData.Columns("Comments").DefaultCellStyle.WrapMode = DataGridViewTriState.True

    End Sub

    'REFREASHES THE DATA GRIDVIEW
    Private Sub refreshDataGridView()
        Try
            Me.lblConnectionString.Text = SQL.connectionString
            If SQL.SQLDataset.Tables.Count > 0 Then
                DGVData.DataSource = SQL.SQLDataset.Tables(0)  ' Makes sure that there is data in the Table
            End If
        Catch ex As Exception
            Me.lblConnectionString.Text = SQL.connectionString
        End Try

    End Sub

    'NEW ENTRY 
    Private Sub cmdNewEntry_Click(sender As Object, e As EventArgs) Handles cmdNewEntry.Click
        Try
            'If DGVData.CurrentRow.Index >= 0 Then
            Select Case True
                Case rbAreaCalcChecklist.Checked
                    formAreaCalcChecklist_New.Show() 'Loads New Entry window
                Case rbSurveyReportRegister.Checked
                    formSurveyReportRegister_New.Show()
                Case rbFieldDataRegister.Checked
                    formFieldDataRegister_New.Show()
                Case rbTqRfiRegister.Checked
                    formTqRfiRegister_New.Show()
                Case Else
                    Exit Sub
            End Select
            Me.Enabled = False
            'End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "New Entry", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    'MODIFY ENTRY
    Private Sub cmdModifySelectedRow_Click(sender As Object, e As EventArgs) Handles cmdModifySelectedRow.Click
        Try
            Select Case True
                Case rbAreaCalcChecklist.Checked
                    formAreaCalcChecklist_Modify.Show() 'Loads Modify Entry window
                Case rbSurveyReportRegister.Checked
                    formSurveyReportRegister_Modify.Show()
                Case rbFieldDataRegister.Checked
                    formFieldDataRegister_Modify.Show()
                Case rbTqRfiRegister.Checked
                    formTqRfiRegister_Modify.Show()
                Case Else
                    Exit Sub
            End Select
            Me.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Modify Entry", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub


    Private Sub rbAreaCalcChecklist_CheckedChanged(sender As Object, e As EventArgs) Handles rbAreaCalcChecklist.CheckedChanged, rbSurveyReportRegister.CheckedChanged, rbFieldDataRegister.CheckedChanged, rbTqRfiRegister.CheckedChanged
        If SQL.HasConnection = True Then
            Select Case True
                Case rbAreaCalcChecklist.Checked
                    lblRegisterSelected.Text = "Area Calc Checklist"
                Case rbSurveyReportRegister.Checked
                    lblRegisterSelected.Text = "Survey Report Register"
                Case rbFieldDataRegister.Checked
                    lblRegisterSelected.Text = "Field Data Register"
                Case rbTqRfiRegister.Checked
                    lblRegisterSelected.Text = "TQ & RFI Register"
            End Select
            txtSearch_KeyUp(AcceptButton, AcceptButton) 'Queries the search box
            SQL.RunQuery(queryString)
            refreshDataGridView()
            txtSearch.Select() 'keeps the search box active after radio button is selected
        End If
    End Sub

    Public Sub txtSearch_KeyUp(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyUp
        If SQL.HasConnection = True Then
            Select Case True
                Case rbAreaCalcChecklist.Checked
                    setSearchStringAreaCalcChecklist()
                Case rbSurveyReportRegister.Checked
                    setSearchStringSurveyReportRegister()
                Case rbFieldDataRegister.Checked
                    setSearchStringFieldDataRegister()
                Case rbTqRfiRegister.Checked
                    setSearchStringTqRfiRegister()
                Case Else
                    Exit Sub
            End Select
            SQL.RunQuery(queryString)
            refreshDataGridView()
            'uses sortTable from exportTables.vb exportTables class 
            'customised data grid view for column display in exportTables.vb
            'sortColumns.sortTable("AreaCalcChecklist")

        End If
    End Sub

    Private Sub setSearchStringAreaCalcChecklist()
        queryString = ("SELECT * FROM AreaCalcChecklist WHERE " & vbCrLf & _
                            "ID LIKE '%" & txtSearch.Text & "%' OR " & vbCrLf & _
                            "[Model/Layer] LIKE '%" & txtSearch.Text & "%' OR " & vbCrLf & _
                            "[Drawing Number] LIKE '%" & txtSearch.Text & "%' OR " & vbCrLf & _
                            "[TQ/RFI] LIKE '%" & txtSearch.Text & "%' OR " & vbCrLf & _
                            "[Calc'd by] LIKE '%" & txtSearch.Text & "%' OR " & vbCrLf & _
                            "[Calc'd date] LIKE '%" & txtSearch.Text & "%' OR " & vbCrLf & _
                            "[Checked by] LIKE '%" & txtSearch.Text & "%' OR " & vbCrLf & _
                            "[Checked date] LIKE '%" & txtSearch.Text & "%' OR " & vbCrLf & _
                            "Comments LIKE '%" & txtSearch.Text & "%' OR " & vbCrLf & _
                            "Created LIKE '%" & txtSearch.Text & "%' OR " & vbCrLf & _
                            "Modified LIKE '%" & txtSearch.Text & "%' ORDER BY Created DESC")

        SQL.RunQuery(queryString)
        refreshDataGridView()
        'uses sortTable from exportTables.vb exportTables class 
        'customised data grid view for column display in exportTables.vb
        'sortColumns.sortTable("AreaCalcChecklist")
        For Each col As DataGridViewColumn In Me.DGVData.Columns
            Select Case col.Name
                Case "ID"
                    col.DisplayIndex = 0
                    'col.Visible = False
                Case "Model/Layer"
                    col.DisplayIndex = 1
                Case "Drawing Number"
                    col.DisplayIndex = 2
                Case "TQ/RFI"
                    col.DisplayIndex = 3
                Case "Calc'd by"
                    col.DisplayIndex = 4
                Case "Calc'd date"
                    col.DisplayIndex = 5
                Case "Checked by"
                    col.DisplayIndex = 6
                Case "Checked date"
                    col.DisplayIndex = 7
                Case "Comments"
                    col.DisplayIndex = 8
                Case "Created"
                    col.DisplayIndex = 9
                Case "Modified"
                    col.DisplayIndex = 10
                Case Else
                    col.Visible = False
            End Select
        Next

    End Sub

    Private Sub setSearchStringSurveyReportRegister()

        queryString = ("SELECT * FROM SurveyReportRegister WHERE " & vbCrLf & _
                            "ID LIKE '%" & txtSearch.Text & "%' OR " & vbCrLf & _
                            "Date LIKE '%" & txtSearch.Text & "%' OR " & vbCrLf & _
                            "[Document Name] LIKE '%" & txtSearch.Text & "%' OR " & vbCrLf & _
                            "Rev LIKE '%" & txtSearch.Text & "%' OR " & vbCrLf & _
                            "Title LIKE '%" & txtSearch.Text & "%' OR " & vbCrLf & _
                            "Area LIKE '%" & txtSearch.Text & "%' OR " & vbCrLf & _
                            "Description LIKE '%" & txtSearch.Text & "%' OR " & vbCrLf & _
                            "Surveyor LIKE '%" & txtSearch.Text & "%' OR " & vbCrLf & _
                            "Comments LIKE '%" & txtSearch.Text & "%' OR " & vbCrLf & _
                            "PDFLink LIKE '%" & txtSearch.Text & "%' OR " & vbCrLf & _
                            "Created LIKE '%" & txtSearch.Text & "%' OR " & vbCrLf & _
                            "Modified LIKE '%" & txtSearch.Text & "%' ORDER BY Created DESC")

        SQL.RunQuery(queryString)
        refreshDataGridView()
        For Each col As DataGridViewColumn In Me.DGVData.Columns

            Select Case col.Name

                Case "ID"
                    col.DisplayIndex = 0
                    'col.Visible = False
                Case "Date"
                    col.DisplayIndex = 1
                Case "Document Name"
                    col.DisplayIndex = 2
                Case "Rev"
                    col.DisplayIndex = 3
                Case "Title"
                    col.DisplayIndex = 4
                Case "Area"
                    col.DisplayIndex = 5
                Case "Description"
                    col.DisplayIndex = 6
                Case "Surveyor"
                    col.DisplayIndex = 7
                Case "Comments"
                    col.DisplayIndex = 8
                Case "PDFLink"
                    col.DisplayIndex = 9
                Case "Created"
                    col.DisplayIndex = 10
                Case "Modified"
                    col.DisplayIndex = 11
                Case Else
                    col.Visible = False
            End Select
        Next
        'Adds the bold to the hyperlinks
        initilizeDataGridView()
    End Sub

    Private Sub setSearchStringFieldDataRegister()
        queryString = ("SELECT * FROM FieldDataRegister WHERE " & vbCrLf & _
                            "ID LIKE '%" & txtSearch.Text & "%' OR " & vbCrLf & _
                            "[Job Ref Number] LIKE '%" & txtSearch.Text & "%' OR " & vbCrLf & _
                            "Date LIKE '%" & txtSearch.Text & "%' OR " & vbCrLf & _
                            "Surveyor LIKE '%" & txtSearch.Text & "%' OR " & vbCrLf & _
                            "Area LIKE '%" & txtSearch.Text & "%' OR " & vbCrLf & _
                            "[Job Type] LIKE '%" & txtSearch.Text & "%' OR " & vbCrLf & _
                            "[Job Description] LIKE '%" & txtSearch.Text & "%' OR " & vbCrLf & _
                            "[FLD-BK/PG] LIKE '%" & txtSearch.Text & "%' OR " & vbCrLf & _
                            "[Instrument A] LIKE '%" & txtSearch.Text & "%' OR " & vbCrLf & _
                            "Comments LIKE '%" & txtSearch.Text & "%' OR " & vbCrLf & _
                            "Created LIKE '%" & txtSearch.Text & "%' OR " & vbCrLf & _
                            "Modified LIKE '%" & txtSearch.Text & "%' ORDER BY Created DESC")

        SQL.RunQuery(queryString)
        refreshDataGridView()
        For Each col As DataGridViewColumn In Me.DGVData.Columns
            Select Case col.Name
                Case "ID"
                    col.DisplayIndex = 0
                    'col.Visible = False
                Case "Job Ref Number"
                    col.DisplayIndex = 1
                Case "Date"
                    col.DisplayIndex = 2
                Case "Surveyor"
                    col.DisplayIndex = 3
                Case "Area"
                    col.DisplayIndex = 4
                Case "Job Type"
                    col.DisplayIndex = 5
                Case "Job Description"
                    col.DisplayIndex = 6
                Case "FLD-BK/PG"
                    col.DisplayIndex = 7
                Case "Instrument A"
                    col.DisplayIndex = 8
                Case "Comments"
                    col.DisplayIndex = 9
                Case "Created"
                    col.DisplayIndex = 10
                Case "Modified"
                    col.DisplayIndex = 11
                Case Else
                    col.Visible = False
            End Select
        Next
        ' Adds bold text to the datagrid view to the hyperlink column
        initilizeDataGridView()
    End Sub

    Private Sub setSearchStringTqRfiRegister()
        queryString = ("SELECT * FROM TqRfiRegister WHERE " & vbCrLf & _
                            "ID LIKE '%" & txtSearch.Text & "%' OR " & vbCrLf & _
                            "[Drawing Number] LIKE '%" & txtSearch.Text & "%' OR " & vbCrLf & _
                            "[TQ / RFI] LIKE '%" & txtSearch.Text & "%' OR " & vbCrLf & _
                            "[Date Reieved] LIKE '%" & txtSearch.Text & "%' OR " & vbCrLf & _
                            "Surveyor LIKE '%" & txtSearch.Text & "%' OR " & vbCrLf & _
                            "Area LIKE '%" & txtSearch.Text & "%' OR " & vbCrLf & _
                            "Description LIKE '%" & txtSearch.Text & "%' OR " & vbCrLf & _
                            "Created LIKE '%" & txtSearch.Text & "%' OR " & vbCrLf & _
                            "Modified LIKE '%" & txtSearch.Text & "%' ORDER BY Created DESC")


        SQL.RunQuery(queryString)
        refreshDataGridView()
        For Each col As DataGridViewColumn In Me.DGVData.Columns
            Select Case col.Name
                Case "ID"
                    col.DisplayIndex = 0
                    'col.Visible = False
                Case "Drawing Number"
                    col.DisplayIndex = 1
                Case "TQ / RFI"
                    col.DisplayIndex = 2
                Case "Date Reieved"
                    col.DisplayIndex = 3
                Case "Surveyor"
                    col.DisplayIndex = 4
                Case "Area"
                    col.DisplayIndex = 5
                Case "Description"
                    col.DisplayIndex = 6
                Case "Created"
                    col.DisplayIndex = 7
                Case "Modified"
                    col.DisplayIndex = 8
                Case Else
                    col.Visible = False
            End Select
        Next
    End Sub

    Private Sub formMain_EnabledChanged(sender As Object, e As EventArgs) Handles MyBase.EnabledChanged
        SQL.RunQuery(queryString)
        refreshDataGridView()
    End Sub


    Private Sub ExportTablesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportTablesToolStripMenuItem.Click
        If SQL.HasConnection = True Then
            export.exportCSV_All() 'Calls the public sub from exportTables.vb
        End If
    End Sub

    Private Sub MoveDatabaseFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MoveDatabaseFileToolStripMenuItem.Click
        If SQL.HasConnection = True Then
            formRestoreTables.Show()
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutDialog.version()
    End Sub

    '--DELETE SELECTED ROW
    Private Sub cmdDeleteRow_Click(sender As Object, e As EventArgs) Handles cmdDeleteRow.Click
        Try
            Dim row As DataGridViewRow
            Dim selectedRegister As String = ""
            row = DGVData.Rows(DGVData.CurrentRow.Index) 'Returns integer value of the select row index from the datagrid
            Dim rowID As String = (row.Cells("ID").Value.ToString)
            Dim record As String = ""

            ' Stores to variable a comma delimited record of the record to be deleted
            For i As Integer = 0 To (DGVData.ColumnCount - 2)
                record = record & row.Cells(i).Value.ToString & ","
            Next
            record = record & row.Cells(DGVData.ColumnCount - 1).Value.ToString


            Select Case True
                Case rbAreaCalcChecklist.Checked
                    selectedRegister = "AreaCalcChecklist"
                Case rbSurveyReportRegister.Checked
                    selectedRegister = "SurveyReportRegister"
                Case rbFieldDataRegister.Checked
                    selectedRegister = "FieldDataRegister"
                Case rbTqRfiRegister.Checked
                    selectedRegister = "TqRfiRegister"
                Case Else
                    Exit Sub
            End Select

            If MessageBox.Show("Are you sure you want to delete the row?" & vbCrLf & vbCrLf & vbTab & "ID: " & rowID & vbCrLf & vbCrLf & _
                               "Once deleted this can't be undone", "Confirmation", MessageBoxButtons.YesNo, _
                               MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                export.recordDeletedEntry(record)


                ' Delete data from databse
                queryString = ("DELETE FROM " & selectedRegister & " WHERE " & _
                            "ID=" & rowID)

                SQL.RunQuery(queryString)
                txtSearch_KeyUp(AcceptButton, AcceptButton)

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Delete Entry", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'ADD HYPERLINKS TO THE DATA GRID VIEW
    Private Sub DGVData_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVData.CellContentClick
        Try
            'if the linkColumn is clicked
            If DGVData.Columns(e.ColumnIndex).HeaderText = "Document Name" And DGVData.Item(9, e.RowIndex).Value <> "" Then
                Process.Start("explorer", "/select," & DGVData.Item(9, e.RowIndex).Value)
            End If
            ' check to see if the area, job type and description fields aren't blank, then opens the folder location
            If DGVData.Columns(e.ColumnIndex).HeaderText = "Job Ref Number" And DGVData.Item(4, e.RowIndex).Value <> "" _
                And DGVData.Item(5, e.RowIndex).Value <> "" And DGVData.Item(4, e.RowIndex).Value <> "" Then
                Dim row As New DataGridViewRow
                row = Me.DGVData.Rows(Me.DGVData.CurrentRow.Index)

                Dim dataDir As String = ""
                Dim cmboArea As String = (row.Cells("Area").Value.ToString).Trim
                Dim cmboJobType As String = (row.Cells("Job Type").Value.ToString).Trim
                Dim txtJobRefNum As String = (row.Cells("Job Ref Number").Value.ToString).Trim
                Dim txtJobDescription As String = (row.Cells("Job Description").Value.ToString).Trim
                dataDir = formSettings.settingsProjectFolder & "\Area\" & cmboArea & "\Field Data\" & cmboJobType & "\" & txtJobRefNum & " - " & txtJobDescription & "\"
                Process.Start("explorer", "/select," & """" & dataDir & """")
            End If

        Catch ex As Exception
        End Try
    End Sub


    '--PRINT DataGridView 
    Private Sub cmdPrintDGVData_Click(sender As Object, e As EventArgs) Handles cmdPrintDGVData.Click
        printPreview.ShowDialog()
    End Sub


    '  Private Sub PrintDocument_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument.PrintPage
    '      Dim font As New Font("Arial", 16, FontStyle.Regular)
    '      e.Graphics.DrawString(DGVData.Rows, font, Brushes.Black, 100, 100)
    '  End Sub


    'EXPORT TO MS EXCEL
    Private Sub cmdExportXLXS_Click(sender As Object, e As EventArgs) Handles cmdExportXLXS.Click
        Try
            'Selects the Survey Report Register for Export
            rbSurveyReportRegister.Checked = True

            Dim xlApp As Microsoft.Office.Interop.Excel.Application
            Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
            Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
            Dim misValue As Object = System.Reflection.Missing.Value
            Dim i As Integer
            Dim j As Integer

            xlApp = New Microsoft.Office.Interop.Excel.Application
            xlWorkBook = xlApp.Workbooks.Add(misValue)
            xlWorkSheet = xlWorkBook.Sheets("sheet1")


            For i = 0 To DGVData.RowCount - 1
                For j = 0 To DGVData.ColumnCount - 1
                    For k As Integer = 1 To DGVData.Columns.Count
                        xlWorkSheet.Cells(1, k) = DGVData.Columns(k - 1).HeaderText
                        xlWorkSheet.Cells(i + 2, j + 1) = DGVData(j, i).Value
                    Next
                Next
            Next

            'Sets Date for export
            Dim myDateTime As DateTime = DateTime.Now    'Sets the date for the filename to now
            Dim myDateOnly As String = myDateTime.ToString("yyyyMMdd")

            Dim exportXLSXFile As New SaveFileDialog()
            exportXLSXFile.Filter = "Excel file|*.xlsx"
            exportXLSXFile.Title = "Export an Excel File"
            If formSettings.settingsProjectFolder <> "" Then exportXLSXFile.InitialDirectory = formSettings.settingsProjectFolder & "\Export To Client\"
            exportXLSXFile.FileName = myDateOnly & "_" & lblRegisterSelected.Text & "_XCELregister_export"
            exportXLSXFile.ShowDialog()

            If exportXLSXFile.FileName <> "" Then

                xlWorkSheet.SaveAs(exportXLSXFile.FileName)
                xlWorkBook.Close()
                xlApp.Quit()

                releaseObject(xlApp)
                releaseObject(xlWorkBook)
                releaseObject(xlWorkSheet)

                If MessageBox.Show("Export of the Excel file is complete, Would you like to open file?", "Export Complete", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    Process.Start(exportXLSXFile.FileName)
                End If

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub
    'Release the Excel application
    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub ConnectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConnectToolStripMenuItem.Click
        formNewDatabaseWizard.Show()
    End Sub

    Private Sub SettingsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem1.Click
        If SQL.HasConnection = True Then
            formSettings.Show()
        End If
    End Sub
End Class
