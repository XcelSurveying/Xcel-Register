Public Class formMain
    Dim SQL As New SQLControl
    Dim export As New exportTables
    Dim queryString As String
    'Dim sortColumns As sortColumnsDGVData

    Private Sub formMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Hide Print command button, until get working code for this
        cmdPrintDGVData.Visible = False

        'Open main window Maximised
        Me.WindowState = FormWindowState.Maximized

        If SQL.HasConnection = True Then 'has connected
            initilizeDataGridView() 'Set visual params for data grid view
            setSearchStringAreaCalcChecklist()
            '-- Updates/Refreshes the data grid --
            SQL.RunQuery("SELECT * FROM AreaCalcChecklist ORDER BY Created DESC")
            refreshDataGridView()
        Else
            formNewDatabaseWizard.Show()
        End If
    End Sub

    Private Sub initilizeDataGridView()
        ' Set the background color for all rows and for alternating rows.  
        ' The value for alternating rows overrides the value for all rows. 
        DGVData.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray

    End Sub

    'REFREASHES THE DATA GRIDVIEW
    Private Sub refreshDataGridView()
        If SQL.SQLDataset.Tables.Count > 0 Then
            DGVData.DataSource = SQL.SQLDataset.Tables(0)  ' Makes sure that there is data in the Table
        End If
    End Sub

    'NEW ENTRY 
    Private Sub cmdNewEntry_Click(sender As Object, e As EventArgs) Handles cmdNewEntry.Click
        Try
            'If DGVData.CurrentRow.Index >= 0 Then
            Select Case True
                Case rbAreaCalcChecklist.Checked
                    formNewEntryAreaCalcChecklist.Show() 'Loads New Entry window
                Case rbSurveyReportRegister.Checked
                    formNewEntrySurveyReportRegister.Show()
                Case rbFieldDataRegister.Checked
                    formNewEntryFieldDataRegister.Show()
                Case rbTqRfiRegister.Checked
                    'formNewEntryTqRfiRegister.Show()
            End Select
            Me.Enabled = False
            'End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "New Entry", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmdModifySelectedRow_Click(sender As Object, e As EventArgs) Handles cmdModifySelectedRow.Click
        Try
            Select Case True
                Case rbAreaCalcChecklist.Checked
                    formModifyAreaCalcChecklist.Show() 'Loads Modify Entry window
                Case rbSurveyReportRegister.Checked
                    formModifySurveyReportRegister.Show()
                Case rbFieldDataRegister.Checked
                    formModifyFieldDataRegister.Show()
                Case rbTqRfiRegister.Checked

            End Select
            Me.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Modify Entry", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DatabaseSetupWizardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DatabaseSetupWizardToolStripMenuItem.Click
        formNewDatabaseWizard.Show()
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

    Private Sub txtSearch_KeyUp(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyUp
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
                            "ID LIKE '" & txtSearch.Text & "%' OR " & vbCrLf & _
                            "[Model/Layer] LIKE '" & txtSearch.Text & "%' OR " & vbCrLf & _
                            "[Drawing Number] LIKE '" & txtSearch.Text & "%' OR " & vbCrLf & _
                            "[TQ/RFI] LIKE '" & txtSearch.Text & "%' OR " & vbCrLf & _
                            "[Calc'd by] LIKE '" & txtSearch.Text & "%' OR " & vbCrLf & _
                            "[Calc'd date] LIKE '" & txtSearch.Text & "%' OR " & vbCrLf & _
                            "[Checked by] LIKE '" & txtSearch.Text & "%' OR " & vbCrLf & _
                            "[Checked date] LIKE '" & txtSearch.Text & "%' OR " & vbCrLf & _
                            "Comments LIKE '" & txtSearch.Text & "%' OR " & vbCrLf & _
                            "Created LIKE '" & txtSearch.Text & "%' OR " & vbCrLf & _
                            "Modified LIKE '" & txtSearch.Text & "%' ORDER BY Created DESC")

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
                            "ID LIKE '" & txtSearch.Text & "%' OR " & vbCrLf & _
                            "Date LIKE '" & txtSearch.Text & "%' OR " & vbCrLf & _
                            "[Document Name] LIKE '" & txtSearch.Text & "%' OR " & vbCrLf & _
                            "Rev LIKE '" & txtSearch.Text & "%' OR " & vbCrLf & _
                            "Title LIKE '" & txtSearch.Text & "%' OR " & vbCrLf & _
                            "Area LIKE '" & txtSearch.Text & "%' OR " & vbCrLf & _
                            "Description LIKE '" & txtSearch.Text & "%' OR " & vbCrLf & _
                            "Surveyor LIKE '" & txtSearch.Text & "%' OR " & vbCrLf & _
                            "Comments LIKE '" & txtSearch.Text & "%' OR " & vbCrLf & _
                            "PDFLink LIKE '" & txtSearch.Text & "%' OR " & vbCrLf & _
                            "Created LIKE '" & txtSearch.Text & "%' OR " & vbCrLf & _
                            "Modified LIKE '" & txtSearch.Text & "%' ORDER BY Created DESC")

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
    End Sub

    Private Sub setSearchStringFieldDataRegister()
        queryString = ("SELECT * FROM FieldDataRegister WHERE " & vbCrLf & _
                            "ID LIKE '" & txtSearch.Text & "%' OR " & vbCrLf & _
                            "[Job Ref Number] LIKE '" & txtSearch.Text & "%' OR " & vbCrLf & _
                            "Date LIKE '" & txtSearch.Text & "%' OR " & vbCrLf & _
                            "Surveyor LIKE '" & txtSearch.Text & "%' OR " & vbCrLf & _
                            "Area LIKE '" & txtSearch.Text & "%' OR " & vbCrLf & _
                            "[Job Type] LIKE '" & txtSearch.Text & "%' OR " & vbCrLf & _
                            "[Job Description] LIKE '" & txtSearch.Text & "%' OR " & vbCrLf & _
                            "[FLD-BK/PG] LIKE '" & txtSearch.Text & "%' OR " & vbCrLf & _
                            "[Instrument A] LIKE '" & txtSearch.Text & "%' OR " & vbCrLf & _
                            "Comments LIKE '" & txtSearch.Text & "%' OR " & vbCrLf & _
                            "Created LIKE '" & txtSearch.Text & "%' OR " & vbCrLf & _
                            "Modified LIKE '" & txtSearch.Text & "%' ORDER BY Created DESC")

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
    End Sub

    Private Sub setSearchStringTqRfiRegister()
        queryString = ("SELECT * FROM TqRfiRegister WHERE " & vbCrLf & _
                            "ID LIKE '" & txtSearch.Text & "%' OR " & vbCrLf & _
                            "[Drawing Number] LIKE '" & txtSearch.Text & "%' OR " & vbCrLf & _
                            "[TQ / RFI] LIKE '" & txtSearch.Text & "%' OR " & vbCrLf & _
                            "[Date Reieved] LIKE '" & txtSearch.Text & "%' OR " & vbCrLf & _
                            "Surveyor LIKE '" & txtSearch.Text & "%' OR " & vbCrLf & _
                            "Area LIKE '" & txtSearch.Text & "%' OR " & vbCrLf & _
                            "Description LIKE '" & txtSearch.Text & "%' OR " & vbCrLf & _
                            "Created LIKE '" & txtSearch.Text & "%' OR " & vbCrLf & _
                            "Modified LIKE '" & txtSearch.Text & "%' ORDER BY Created DESC")


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



    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        formSettings.Show()
    End Sub

    Private Sub formMain_EnabledChanged(sender As Object, e As EventArgs) Handles MyBase.EnabledChanged
        SQL.RunQuery(queryString)
        refreshDataGridView()
    End Sub


    Private Sub ExportTablesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportTablesToolStripMenuItem.Click
        export.exportCSV_All() 'Calls the public sub from exportTables.vb
    End Sub

    Private Sub MoveDatabaseFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MoveDatabaseFileToolStripMenuItem.Click
        formRestoreTables.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("Xcel Database Register: Version ##.##", "About", MessageBoxButtons.OK, MessageBoxIcon.None)
    End Sub

    '--PRINT DataGridView 
    Private Sub cmdPrintDGVData_Click(sender As Object, e As EventArgs) Handles cmdPrintDGVData.Click

    End Sub
End Class
