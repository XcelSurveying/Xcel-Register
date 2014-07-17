Public Class formSurveyReportRegister_New
    Dim sql As New SQLControl
    Dim export As New exportTables
    Dim EscapeChars As New EscapeChars

    Dim fullpath As String = String.Empty
    Dim filename As String = String.Empty

    Dim nonNumericOnlyString As String
    Dim matchString As String
    Dim matchStringDelimited() As String
    Dim NumericCharacters As New System.Text.RegularExpressions.Regex("\d")
    Dim foundMatch As Boolean = False

    Dim tickCount As Integer = 0
    Dim tickCountTitle As Integer = 0

    Dim DestinationDir As String

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


        'VALIDATING CONTROL FOR ALL TEXTBOX AND COMBOBOX IN FORM FOR EMPTY STRINGS, LINKS TO PRIVATE SUB
        For Each c As Control In Me.Controls
            If TypeOf (c) Is TextBox Or TypeOf (c) Is ComboBox Then
                AddHandler c.Validating, AddressOf Me.TextBox_Validating
            End If
        Next

        'STARTS DESTINATION FOLDER TIMER
        timerDestFolder_Tick()

        'SET DATE TO TODAY
        dtpDate.Value = Today

    End Sub

    Private Sub formNewEntrySurveyReportRegister_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        formMain.Enabled = True
    End Sub

    'HYPERLINK WHEN CLICKED
    Private Sub linkNewEntryDocumentName_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkSource.LinkClicked
        Try
            System.Diagnostics.Process.Start(fullpath)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Hyperlink", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        Dim fullpathNew As String
        Dim fullDirNew As String

        Try

            ' MessageBox.Show(settingsProjectFolderPath.ToString & DestinationDir.ToString & "\" & txtDocumentName.Text & ".pdf")

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
            ''''''''        nonNumericOnlyString = NumericCharacters.Replace(txtDocumentName.Text, String.Empty) 'removes all numeric values from document name string
            ''''''''        For Each Me.matchString In My.Settings.settingsSRRSurveyors.ToArray() 'Cycle through the surveyors list in settings
            ''''''''            matchStringDelimited = Split(matchString, " - ", , CompareMethod.Text)
            ''''''''            If String.Compare(nonNumericOnlyString.TrimEnd, matchStringDelimited(0).TrimEnd, True) = 0 Then
            ''''''''                foundMatch = True
            ''''''''            End If
            ''''''''        Next
            ''''''''        If foundMatch = False Then
            ''''''''            MessageBox.Show("Surveyor initials " & nonNumericOnlyString & " not found in settings list. Please make sure the surveyors details are added to the settings page in File/Settings", "Surveyors initials not found", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ''''''''            Exit Sub
            ''''''''        End If



            'QUERY FOR REV NUMBER DUPLICATE   (SEARCH FOR MAX REV NUMBER FOR DOCUMENT THAT IS BEING CREATED)
            sql.RunQuery("SELECT MAX(Rev) AS result From SurveyReportRegister WHERE [Document Name] = '" & txtDocumentName.Text & "'")
            If sql.SQLDataset.Tables(0).Rows(0).Item("result") IsNot DBNull.Value Then 'tests for NULL value
                'tests for equal or higher existing rev number
                If sql.SQLDataset.Tables(0).Rows(0).Item("result") >= txtRev.Text Then
                    MessageBox.Show("Rev " & txtRev.Text & " or higher already exists" & vbCrLf & _
                           "Rev " & sql.SQLDataset.Tables(0).Rows(0).Item("result") + 1 & " is the next available revision", "Change the Revision Number", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtRev.Focus()
                    txtRev.SelectAll() 'Highlights rev text box ready for input
                    Exit Sub
                End If
                'tests for equal or higher existing rev number
                If sql.SQLDataset.Tables(0).Rows(0).Item("result") + 1 < txtRev.Text Then 'tests for equal or higher existing rev number
                    MessageBox.Show("Looks like a revision has been skipped" & vbCrLf & _
                           "Rev " & sql.SQLDataset.Tables(0).Rows(0).Item("result") + 1 & " is the next available revision", "Change the Revision Number", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtRev.Focus()
                    txtRev.SelectAll() 'Highlights rev text box ready for input
                    Exit Sub
                End If
            Else
                'Finally test if query doesnt find an existing ducument name entry, it must start from revision 1
                If txtRev.Text <> 1 Then
                    MessageBox.Show("Revisions must start at 1", "Change the Revision Number", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
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

            'CAN ONLY BE CREATED WHEN DESTINATION DIR AND TXT DOCUMENT NAME ARE ENTERED, ESCAPE OTHERWISE
            fullpathNew = formSettings.settingsProjectFolder & DestinationDir.ToString & "\" & txtDocumentName.Text & " Rev" & txtRev.Text & ".pdf"
            fullDirNew = formSettings.settingsProjectFolder & DestinationDir.ToString & "\"

            'CREATE AND COPY THE PDF TO THE NEW DIRECTORY
            ' Copy the file to a new folder and rename it.
            If fullpath <> "" Then
                My.Computer.FileSystem.CopyFile(fullpath, fullpathNew,
                Microsoft.VisualBasic.FileIO.UIOption.AllDialogs,
                Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)
            Else
                MessageBox.Show("The report PDF file hasn't been selected, so no file has been copied. However the folder has been created at the location shown below: " & vbCrLf & fullDirNew)
                If Not System.IO.Directory.Exists(fullDirNew) Then
                    System.IO.Directory.CreateDirectory(fullDirNew)
                End If
                Process.Start("explorer.exe", fullDirNew)
                fullpathNew = fullDirNew
            End If
            


            '-- SQL INSERT QUERY IN TO THE DATABASE --
            sql.DataUpdate("SET DATEFORMAT dmy; INSERT INTO SurveyReportRegister (Date, [Document Name], Rev, Title, " & _
                                                          "Area, Description, Surveyor, Comments, PDFLink, " & _
                                                          "Created) " & _
                            "VALUES (" & _
                            "'" & dtpDate.Value & "', " & _
                            "'" & (txtDocumentName.Text).ToUpper & "', " & _
                            "'" & txtRev.Text & "', " & _
                            "'" & txtTitle.Text & "', " & _
                            "'" & cmboArea.Text & "', " & _
                            "'" & cmboDescription.Text & "', " & _
                            "'" & cmboSurveyor.Text & "', " & _
                            "'" & txtComments.Text & "', " & _
                            "'" & fullpathNew & "', " & _
                            "GETDATE())")

            'UPDATE THE BACKUP CSV FILE USING BCP UTILITY
            export.exportTable_Single("csv", "SurveyReportRegister", export.backupFolder)

            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "New Entry", MessageBoxButtons.OK, MessageBoxIcon.Error)

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

        Timer1.Stop()
        lblDocumentNameWarning.Visible = False

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

            'MAKES WARNING LABEL NOT VISIBLE
            lblDocumentNameWarning.Visible = False
            Timer1.Stop()

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

            'SETUP MATCH STRINGS FOR SURVEYORS NAME
            'removes all numeric values from document name string
            ''''''''         nonNumericOnlyString = NumericCharacters.Replace(txtDocumentName.Text, String.Empty)
            ''''''''         For Each Me.matchString In My.Settings.settingsSRRSurveyors.ToArray() 'Cycle through the surveyors list in settings
            ''''''''             matchStringDelimited = Split(matchString, " - ", , CompareMethod.Text)
            ''''''''             If String.Compare(nonNumericOnlyString.TrimEnd, matchStringDelimited(0).TrimEnd, True) = 0 Then
            ''''''''                 Me.cmboSurveyor.SelectedItem = (matchString)
            ''''''''             End If
            ''''''''         Next

            'QUERY FOR REV NUMBER DUPLICATE   (SEARCH FOR MAX REV NUMBER FOR DOCUMENT THAT IS BEING CREATED)
            sql.RunQuery("SELECT MAX(Rev) AS result From SurveyReportRegister WHERE [Document Name] = '" & txtDocumentName.Text & "'")
            If sql.SQLDataset.Tables(0).Rows(0).Item("result") IsNot DBNull.Value Then 'tests for NULL value
                If sql.SQLDataset.Tables(0).Rows(0).Item("result") >= txtRev.Text Then 'tests for equal or higher existing rev number
                    txtRev.Text = (sql.SQLDataset.Tables(0).Rows(0).Item("result") + 1)
                    Exit Sub

                End If
            Else
                txtRev.Text = ("1")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Document Name", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    'CLEAR WARNING LABEL ONCE TEXT IS TYPED IN TO TITLE TEXTBOX
    Private Sub txtTitle_TextChanged(sender As Object, e As EventArgs) Handles txtTitle.TextChanged
        lblTitleWarning.Visible = False
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
        Dim filenameOrig As String = filename
        Dim fullpathOrig As String = fullpath

        Dim ofdBrowseDocumentName As New OpenFileDialog()

        ofdBrowseDocumentName.Filter = "pdf files (*.pdf)|*.pdf"
        ofdBrowseDocumentName.FilterIndex = 1
        ofdBrowseDocumentName.RestoreDirectory = True
        ofdBrowseDocumentName.Title = "Select PDF File"
        ofdBrowseDocumentName.ShowDialog()

        'Set the filename and filepath of selected pdf
        fullpath = ofdBrowseDocumentName.FileName
        filename = System.IO.Path.GetFileName(fullpath) 'Reduces the full path to filename only
        linkSource.Text = filename 'Creates hyperlink name with full path name

        'Keep original values if the cancel button is pressed
        If linkSource.Text = "" Then
            linkSource.Text = filenameOrig
            fullpath = fullpathOrig
        End If

    End Sub

    Private Sub timerDestFolder_Tick() Handles timerDestFolder.Tick
        timerDestFolder.Interval = 100
        timerDestFolder.Enabled = True
        timerDestFolder.Start()
        'ADDS DESTINATION FOLDER TO FORM
        If txtRev.Text <> ("") And txtDocumentName.Text <> ("") And cmboDescription.Text <> ("Please select ...") And cmboArea.Text <> ("") Then
            DestinationDir = ("\Area\" & cmboArea.Text & "\Asbuilts\" & txtDocumentName.Text & "\Rev" & txtRev.Text)
            lblDestFolder.Text = DestinationDir
            lblDestFolder.Visible = True
        Else
            lblDestFolder.Visible = False
        End If

        'ADDS DESTINATION PDF NAME TO FORM
        If txtDocumentName.Text <> ("") And fullpath <> ("") Then
            lblDestination.Text = (txtDocumentName.Text & ".pdf")
            lblDestination.Visible = True
        Else
            lblDestination.Visible = False
        End If

    End Sub

    'ESCAPE CHARACTERS ENTERED IN TO THE TEXT BOXES
    Private Sub escapeCharacters_KeyPress(sender As Object, e As KeyPressEventArgs) _
        Handles txtComments.KeyPress, txtTitle.KeyPress, txtDocumentName.KeyPress
        'Escape Characters Class (e as keyPress, allow numbers, allow letters)
        EscapeChars.Include(e, True, True)
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub
End Class