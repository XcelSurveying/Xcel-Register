Public Class formSurveyReportRegister_Modify
    Dim sql As New SQLControl
    Dim export As New exportTables
    Dim row As DataGridViewRow
    Dim EscapeChars As New EscapeChars

    Dim fullpath As String = "1"

    Dim nonNumericOnlyString As String
    Dim matchString As String
    Dim matchStringDelimited() As String
    Dim NumericCharacters As New System.Text.RegularExpressions.Regex("\d")
    Dim foundMatch As Boolean = False

    Dim tickCount As Integer = 0
    Dim tickCountTitle As Integer = 0

    Dim DestinationDir As String

    Dim DocumentName_orig As String = "blank"
    Dim Rev_orig As String = "blank"
    Dim ID_orig As String = "blank"
    Dim Area_orig As String = "blank"
    Dim Description_orig As String = "blank"
    Dim Linksource_orig As String = "blank"


    'FORM LOAD
    Private Sub formNewEntrySurveyReportRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Form Settings
        Me.ShowIcon = False
        Me.MinimizeBox = False
        Me.MaximizeBox = False
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedToolWindow

        'POPULATE THE COMBOBOX'S WITH VALUES FROM LISTBOX IN SETTINGS
        'Uses saved listbox settings, converts them to an array then uses the data to fill the combobox

        'Listbox 1 Area
        sql.PopulateListbox1("settingsSurveyReportArea")
        cmboArea.DataSource = sql.dtData1
        cmboArea.DisplayMember = "data"
        cmboArea.ValueMember = "ID"
        cmboArea.SelectedIndex = 0

        'Listbox 2 InstrumentA
        sql.PopulateListbox2("settingsSurveyReportDescription")
        cmboDescription.DataSource = sql.dtData2
        cmboDescription.DisplayMember = "data"
        cmboDescription.ValueMember = "ID"
        cmboDescription.SelectedIndex = 0

        'Listbox 3 JobType
        sql.PopulateListbox3("settingsCommonSurveyors")
        cmboSurveyor.DataSource = sql.dtData3
        cmboSurveyor.DisplayMember = "data"
        cmboSurveyor.ValueMember = "ID"
        cmboSurveyor.SelectedIndex = 0

        'LOAD TEXTBOX'S WITH FIELDS FROM DATABASE
        row = formMain.DGVData.Rows(formMain.DGVData.CurrentRow.Index) 'Returns integer value of the select row index from the datagrid

        'stores a copy of the Original Values so can be used to restore if the user cancels
        DocumentName_orig = (row.Cells("Document Name").Value.ToString).Trim
        Rev_orig = (row.Cells("Rev").Value.ToString).Trim
        ID_orig = (row.Cells("ID").Value.ToString)
        Area_orig = (row.Cells("Area").Value.ToString).Trim
        Description_orig = (row.Cells("Description").Value.ToString).Trim
        Linksource_orig = (row.Cells("PDFLink").Value).Trim
        fullpath = Linksource_orig

        txtDocumentName.Text = (row.Cells("Document Name").Value.ToString).Trim
        dtpDate.Value = (row.Cells("Date").Value.ToString).Trim
        txtRev.Text = Rev_orig
        txtTitle.Text = (row.Cells("Title").Value.ToString).Trim
        cmboArea.Text = Area_orig
        cmboDescription.Text = Description_orig
        cmboSurveyor.Text = (row.Cells("Surveyor").Value).Trim
        txtComments.Text = (row.Cells("Comments").Value).Trim
        linkSource.Text = Linksource_orig


        'VALIDATING CONTROL FOR ALL TEXTBOX AND COMBOBOX IN FORM
        For Each c As Control In Me.Controls
            If TypeOf (c) Is TextBox Or TypeOf (c) Is ComboBox Then
                AddHandler c.Validating, AddressOf Me.TextBox_Validating
            End If
        Next

    End Sub

    Private Sub formNewEntrySurveyReportRegister_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        formMain.Enabled = True
    End Sub

    'HYPERLINK WHEN CLICKED
    Private Sub linkNewEntryDocumentName_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkSource.LinkClicked
        Try
            System.Diagnostics.Process.Start(fullpath)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Hyperlink", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

    End Sub

    'TEXTBOX EMPTY STRING VALIDATOR
    Private Sub TextBox_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs) _
        Handles txtRev.Validating, cmboSurveyor.Validating, cmboArea.Validating, txtTitle.Validating, cmboDescription.Validating
        Dim ctl As Control = CType(sender, Control)
        If ctl.Text = "" Or ctl.Text = "Please select ..." Then
            e.Cancel = False
            ErrorProvider1.SetError(ctl, "Please enter a value")
        Else
            ErrorProvider1.Clear()
        End If
    End Sub

    '---------==========  SAVE BUTTON RECORD TO DATABASE =========--------------
    Private Sub cmdNewEntrySave_Click(sender As Object, e As EventArgs) Handles cmdNewEntrySave.Click
        Try

            'CHECK MINIMUM LENGTH OF DOCUMENT NAME
            If txtDocumentName.Text.Length < 9 Then
                MessageBox.Show("The document name appears to be too short, the format must contain date formated to yymmdd, surveyors initials up to 3 characters, and an occurance number starting from 1 to a maximum of 99.", "Document Name too short", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            'CHECK FORMAT OF DOCUMENT NAME FIRST 6 CHARS ARE INTEGER
            If txtDocumentName.Text.Length >= 6 Then 'test string for at least 6 chars
                If IsNumeric(txtDocumentName.Text.Substring(0, 6)) Then 'test if first 6 chars are numeric
                    If txtDocumentName.Text.Substring(0, 2) > 20 _
                        Or txtDocumentName.Text.Substring(2, 2) > 12 _
                        Or txtDocumentName.Text.Substring(4, 2) > 31 Then 'test for mmdd date format
                        MessageBox.Show("Document Name date format must be (yymmdd)", "Incorrect data format", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    End If
                Else
                    MessageBox.Show("Document Name date format must be" & vbCrLf & "(yymmdd)", "Incorrect date format", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
            End If


            'CHECK IF DOCUMENT NAME CONTAINS SURVEYORS INITIALS FROM THE SETTINGS LIST
            ''''''''         nonNumericOnlyString = NumericCharacters.Replace(txtDocumentName.Text, String.Empty) 'removes all numeric values from document name string
            ''''''''         For Each Me.matchString In My.Settings.settingsSRRSurveyors.ToArray() 'Cycle through the surveyors list in settings
            ''''''''             matchStringDelimited = Split(matchString, " - ", , CompareMethod.Text)
            ''''''''             If String.Compare(nonNumericOnlyString.TrimEnd, matchStringDelimited(0).TrimEnd, True) = 0 Then
            ''''''''                 foundMatch = True
            ''''''''             End If
            ''''''''         Next
            ''''''''         If foundMatch = False Then
            ''''''''             MessageBox.Show("Surveyor initials " & nonNumericOnlyString & " not found in settings list. Please make sure the surveyors details are added to the settings page in File/Settings", "Surveyors initials not found", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ''''''''             Exit Sub
            ''''''''         End If


            'QUERY FOR REV NUMBER DUPLICATE   (SEARCH FOR MAX REV NUMBER FOR DOCUMENT THAT IS BEING CREATED)
            'return number of entries in query result
            Dim numOfRows As Integer = 0
            sql.RunQuery("SELECT COUNT(Rev) AS count From SurveyReportRegister WHERE [Document Name] = '" & txtDocumentName.Text & "'")
            If sql.SQLDataset.Tables(0).Rows(0).Item("count") IsNot DBNull.Value Then
                numOfRows = sql.SQLDataset.Tables(0).Rows(0).Item("count") 'sets number of rows returned inthe search query for the loop to make the array
            End If

            'returns all rev values listed in database under the specific doument name

            'Only run if the Document Name or the Rev Number has changed
            If (txtDocumentName.Text <> DocumentName_orig Or txtRev.Text <> Rev_orig) And numOfRows <> 0 Then
                Dim i As Integer = 0
                Dim revArray(numOfRows - 1) As Integer
                sql.RunQuery("SELECT Rev AS result From SurveyReportRegister WHERE [Document Name] = '" & txtDocumentName.Text & "'")
                If sql.SQLDataset.Tables(0).Rows(0).Item("result") IsNot DBNull.Value Then 'tests for NULL value
                    ' Creates an array of revision numbers
                    For i = 0 To numOfRows - 1
                        revArray(i) = sql.SQLDataset.Tables(0).Rows(i).Item("result")
                    Next
                    'loops through each row or revision number results
                    For i = 0 To numOfRows - 1
                        If revArray(i) = txtRev.Text Then
                            MessageBox.Show("The revision number that you are trying to enter already existes in the database. Try a different number.", "Revision already exists", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            txtRev.Focus()
                            txtRev.SelectAll() 'Highlights rev text box ready for input
                            Exit Sub
                        End If
                    Next
                End If
            End If


            'CHECK TO SEE IF TITLE FIELD IS NOT BLANK
            If txtTitle.Text = ("") Then
                MessageBox.Show("It appears that the title field is blank. Please enter a title for the report", "Enter a title for the report", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            'CHECK IF AREA AND DESCRIPTION FIELDS ARE SELECTED
            If cmboArea.Text = ("Please select ...") Then Exit Sub
            If cmboDescription.Text = ("Please select ...") Then Exit Sub

            ' 'UPDATE THE PDF PATH LINK
            ' fullpathNew = My.Settings.settingsProjectFolderPath.ToString & DestinationDir.ToString & "\" & txtDocumentName.Text & ".pdf"

            '-- SQL INSERT QUERY IN TO THE DATABASE --
            sql.DataUpdate("SET DATEFORMAT dmy; UPDATE SurveyReportRegister " & _
                       "SET " & _
                       "Date='" & dtpDate.Value & "', " & _
                       "[Document Name]='" & txtDocumentName.Text.ToUpper & "', " & _
                       "Rev='" & txtRev.Text & "', " & _
                       "Title='" & txtTitle.Text & "', " & _
                       "Area='" & cmboArea.Text & "', " & _
                       "Description='" & cmboDescription.Text & "', " & _
                       "Surveyor='" & cmboSurveyor.Text & "', " & _
                       "Comments='" & txtComments.Text & "', " & _
                       "PDFLink='" & fullpath & "', " & _
                       "Modified=GETDATE() " & _
                       "WHERE ID='" & ID_orig & "'") 'gets unique ID of the row selected


            '     'CREATE AND COPY THE PDF TO THE NEW DIRECTORY
            '     ' Copy the file to a new folder and rename it.
            '     If fullpathNew <> Linksource_orig Then 'checks to see if file has changed
            '         My.Computer.FileSystem.CopyFile(
            '         fullpath, fullpathNew,
            '         Microsoft.VisualBasic.FileIO.UIOption.AllDialogs,
            '         Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)
            '         'MsgBox(fullpath)
            '         'MsgBox(My.Settings.settingsProjectFolderPath & DestinationDir & "\" & txtDocumentName.Text & ".pdf")
            '
            '         'REMOVE OLD PDF FROM ORIGINAL DIRECTORY
            '         'if folder hasnt changed dont delete file
            '         'My.Computer.FileSystem.DeleteFile(fullpathOrig)
            '     End If



            'UPDATE THE BACKUP CSV FILE USING BCP UTILITY
            export.exportTable_Single("csv", "SurveyReportRegister", export.backupFolder)

            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Save Record to SQL Database", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    '---===== EVENTS =====--------------------------------------------------------

    'ONLY ALLOW NUMERIC VALUES TO BE ENTERED IN TO REV TEXTBOX
    Private Sub txtRev_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRev.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
              Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            e.Handled = True
        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If

    End Sub

    'CHECK TO SEE IF REV FIELD IS GREATER THAN 0
    Private Sub txtRev_KeyUp(sender As Object, e As KeyEventArgs) Handles txtRev.KeyUp
        Try
            If txtRev.Text = ("") OrElse txtRev.Text < 1 Then
                txtRev.Text = (1)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Revision Number", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtDocumentName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDocumentName.KeyPress
        Try
            'ONLY ALLOW CAPS TO BE ENTERED IN TO DOCUMENT NAME TEXTBOX
            If (Char.IsLower(e.KeyChar)) Then
                e.KeyChar = Char.ToUpper(e.KeyChar)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Document Name", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub txtDocumentName_KeyUp(sender As Object, e As KeyEventArgs) Handles txtDocumentName.KeyUp
        Try

            '  'ADDS DESTINATION PDF NAME TO FORM
            '  If txtDocumentName.Text <> ("") And fullpath <> ("") Then
            '      lblDestination.Text = (txtDocumentName.Text & ".pdf")
            '      lblDestination.Visible = True
            '  Else
            '      lblDestination.Visible = False
            '  End If

            'SETUP MATCH STRINGS
            'removes all numeric values from document name string
            '''''''''           nonNumericOnlyString = NumericCharacters.Replace(txtDocumentName.Text, String.Empty)
            '''''''''           For Each Me.matchString In My.Settings.settingsSRRSurveyors.ToArray() 'Cycle through the surveyors list in settings
            '''''''''               matchStringDelimited = Split(matchString, " - ", , CompareMethod.Text)
            '''''''''               If String.Compare(nonNumericOnlyString.TrimEnd, matchStringDelimited(0).TrimEnd, True) = 0 Then
            '''''''''                   Me.cmboSurveyor.SelectedItem = (matchString)
            '''''''''               End If
            '''''''''           Next

            'QUERY FOR REV NUMBER DUPLICATE   (SEARCH FOR MAX REV NUMBER FOR DOCUMENT THAT IS BEING CREATED)
            sql.RunQuery("SELECT MAX(Rev) AS result From SurveyReportRegister WHERE [Document Name] = '" & txtDocumentName.Text & "'")
            If sql.SQLDataset.Tables(0).Rows(0).Item("result") IsNot DBNull.Value Then 'tests for NULL value
                'tests for equal or higher existing rev number
                ' If sql.SQLDataset.Tables(0).Rows(0).Item("result") >= txtRev.Text Then 
                '     txtRev.Text = (sql.SQLDataset.Tables(0).Rows(0).Item("result") + 1)
                '     Exit Sub
                '
                ' End If
            Else
                txtRev.Text = ("1")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Document Name", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    'REMOVE PLEASE SELECT PROMPTS FROM COMBOBOX'S WHEN DROPDOWN IS SELECTED
    Private Sub cmboSurveyor_DropDown(sender As Object, e As EventArgs) Handles cmboSurveyor.DropDown
        Try
            Me.cmboSurveyor.Items.Remove("Please select ...")
            If Me.cmboSurveyor.SelectedItem = ("") Then Me.cmboSurveyor.SelectedIndex = 0
        Catch ex As Exception
        End Try
    End Sub
    Private Sub cmboArea_DropDown(sender As Object, e As EventArgs) Handles cmboArea.DropDown
        Try
            Me.cmboArea.Items.Remove("Please select ...")
            If Me.cmboArea.SelectedItem = ("") Then Me.cmboArea.SelectedIndex = 0
        Catch ex As Exception
        End Try
    End Sub
    Private Sub cmboDescription_DropDown(sender As Object, e As EventArgs) Handles cmboDescription.DropDown
        Try
            Me.cmboDescription.Items.Remove("Please select ...")
            If Me.cmboDescription.SelectedItem = ("") Then Me.cmboDescription.SelectedIndex = 0
        Catch ex As Exception
        End Try
    End Sub


    '----==========BROWSE BUTTON ========------------------------------------------------
    Private Sub cmdNewEntryBrowse_Click(sender As Object, e As EventArgs) Handles cmdNewEntryBrowse.Click
        Try
            Dim filename As String
            filename = ""
            Dim ofdBrowseDocumentName As New OpenFileDialog()

            ofdBrowseDocumentName.Filter = "pdf files (*.pdf)|*.pdf"
            ofdBrowseDocumentName.FilterIndex = 1
            ofdBrowseDocumentName.RestoreDirectory = True
            ofdBrowseDocumentName.Title = "Select PDF File"
            ofdBrowseDocumentName.ShowDialog()
            fullpath = ofdBrowseDocumentName.FileName
            filename = System.IO.Path.GetFileName(fullpath) 'Reduces the full path to filename only
            linkSource.Text = fullpath 'Creates hyperlink name with full path name

        Catch ex As Exception

        End Try
        

    End Sub

    'ESCAPE CHARACTERS ENTERED IN TO THE TEXT BOXES
    Private Sub escapeCharacters_KeyPress(sender As Object, e As KeyPressEventArgs) _
        Handles txtTitle.KeyPress, txtComments.KeyPress, txtDocumentName.KeyPress
        'Escape Characters Class (e as keyPress, allow numbers, allow letters)
        EscapeChars.Include(e, True, True)
    End Sub


    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub
End Class