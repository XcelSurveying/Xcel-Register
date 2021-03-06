﻿Public Class formFieldDataRegister_New
    Dim SQL As New SQLControl
    Dim export As New exportTables
    Dim EscapeChars As New EscapeChars

    Dim nonNumericOnlyString As String
    Dim matchString As String
    Dim matchStringDelimited() As String
    Dim NumericCharacters As New System.Text.RegularExpressions.Regex("\d")
    Dim foundMatch As Boolean = False

    Dim tickCount As Integer = 0
    Dim tickCountTitle As Integer = 0


    'FORM LOAD
    Private Sub formNewEntryFieldDataRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Form Settings
        Me.ShowIcon = False
        Me.MinimizeBox = False
        Me.MaximizeBox = False
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedToolWindow

        'POPULATE THE COMBOBOX'S WITH VALUES FROM LISTBOX IN SETTINGS
        'Uses saved listbox settings, converts them to an array then uses the data to fill the combobox

        'Listbox 1 Area
        SQL.PopulateListbox1("settingsFieldDataArea")
        cmboArea.DataSource = SQL.dtData1
        cmboArea.DisplayMember = "data"
        cmboArea.ValueMember = "ID"
        cmboArea.SelectedIndex = 0

        'Listbox 2 InstrumentA
        SQL.PopulateListbox2("settingsFieldDataInstrumentA")
        cmboInstrumentA.DataSource = SQL.dtData2
        cmboInstrumentA.DisplayMember = "data"
        cmboInstrumentA.ValueMember = "ID"
        cmboInstrumentA.SelectedIndex = 0

        'Listbox 3 JobType
        SQL.PopulateListbox3("settingsFieldDataJobtype")
        cmboJobType.DataSource = SQL.dtData3
        cmboJobType.DisplayMember = "data"
        cmboJobType.ValueMember = "ID"
        cmboJobType.SelectedIndex = 0

        'Listbox 4 Surveyor
        SQL.PopulateListbox4("settingsCommonSurveyors")
        cmboSurveyor.DataSource = SQL.dtData4
        cmboSurveyor.DisplayMember = "data"
        cmboSurveyor.ValueMember = "ID"
        cmboSurveyor.SelectedIndex = 0

        'VALIDATING CONTROL FOR ALL TEXTBOX AND COMBOBOX IN FORM
        For Each c As Control In Me.Controls
            If TypeOf (c) Is TextBox Or TypeOf (c) Is ComboBox Then
                AddHandler c.Validating, AddressOf Me.TextBox_Validating
            End If
        Next

        'SET DATE TO TODAY
        dtpDate.Value = Today

    End Sub

    Private Sub TextBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) _
        Handles txtJobDescription.Validating, txtFieldBook.Validating, txtFieldPage.Validating,
                cmboSurveyor.Validating, cmboArea.Validating, cmboJobType.Validating, cmboInstrumentA.Validating
        Dim ctl As Control = CType(sender, Control)
        'Sets error provider when nothing is entered in the entryfields listed above
        If ctl.Text = "" Or ctl.Text = "Please select ..." Then
            e.Cancel = False
            ErrorProvider1.SetError(ctl, "Please enter a value")
        Else
            ErrorProvider1.Clear()
        End If
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
    Private Sub cmboJobType_DropDown(sender As Object, e As EventArgs) Handles cmboJobType.DropDown
        Try
            Me.cmboJobType.Items.Remove("Please select ...")
            If Me.cmboJobType.SelectedItem = ("") Then Me.cmboJobType.SelectedIndex = 0
        Catch ex As Exception
        End Try
    End Sub
    Private Sub cmboInstrumentA_DropDown(sender As Object, e As EventArgs) Handles cmboInstrumentA.DropDown
        Try
            Me.cmboInstrumentA.Items.Remove("Please select ...")
            If Me.cmboInstrumentA.SelectedItem = ("") Then Me.cmboInstrumentA.SelectedIndex = 0
        Catch ex As Exception
        End Try
    End Sub


    '--------====== SAVE ENTRY =======-------
    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Dim dataDir As String

        Try

            'CHECK MINIMUM LENGTH OF DOCUMENT NAME
            If txtJobRefNum.Text.Length < 9 Then
                lblDocumentNameWarning.Text = ("Document Name too short")
                tickCount = 0 ' counter for flash
                flashLabelDocumentName()
                Exit Sub
            End If

            'CHECK FORMAT OF DOCUMENT NAME FIRST 6 CHARS ARE INTEGER
            If txtJobRefNum.Text.Length >= 6 Then 'test string for at least 6 chars
                If IsNumeric(txtJobRefNum.Text.Substring(0, 6)) Then 'test if first 6 chars are numeric
                    If txtJobRefNum.Text.Substring(0, 2) > 20 _
                        Or txtJobRefNum.Text.Substring(2, 2) > 12 _
                        Or txtJobRefNum.Text.Substring(4, 2) > 31 Then 'test for mmdd date format
                        lblDocumentNameWarning.Text = ("Document Name date format must be" & vbCrLf & "(yymmdd)")
                        tickCount = 0
                        flashLabelDocumentName()
                        Exit Sub
                    End If
                Else
                    lblDocumentNameWarning.Text = ("Document Name date format must be" & vbCrLf & "(yymmdd)")
                    tickCount = 0
                    flashLabelDocumentName()
                    Exit Sub
                End If
            End If


            'CHECK IF DOCUMENT NAME CONTAINS SURVEYORS INITIALS FROM THE SETTINGS LIST
            '''''''       nonNumericOnlyString = NumericCharacters.Replace(txtJobRefNum.Text, String.Empty) 'removes all numeric values from document name string
            '''''''       For Each Me.matchString In My.Settings.settingsSRRSurveyors.ToArray() 'Cycle through the surveyors list in settings
            '''''''           matchStringDelimited = Split(matchString, " - ", , CompareMethod.Text)
            '''''''           If String.Compare(nonNumericOnlyString.TrimEnd, matchStringDelimited(0).TrimEnd, True) = 0 Then
            '''''''               foundMatch = True
            '''''''           End If
            '''''''       Next
            '''''''       If foundMatch = False Then
            '''''''           lblDocumentNameWarning.Text = ("Surveyor initials " & nonNumericOnlyString & " not found in settings list")
            '''''''           tickCount = 0
            '''''''           flashLabelDocumentName()
            '''''''           Exit Sub
            '''''''       End If


            'CHECK TO SEE IF JOB DECRIPTION FIELD IS NOT BLANK
            If txtJobDescription.Text = ("") Then
                lblDescriptionWarning.Text = ("Please enter a Job Description")
                tickCount = 0
                flashLabelDescription()
                Exit Sub
            End If

            'CHECK TO SEE IF FIELD BOOK FIELDS ARE NOT BLANK
            If txtFieldBook.Text = ("") Then
                lblDescriptionWarning.Text = ("Please enter fieldbook number")
                tickCount = 0
                flashLabelDescription()
                Exit Sub
            End If
            If txtFieldPage.Text = ("") Then
                lblDescriptionWarning.Text = ("Please enter fieldbook page numbers")
                tickCount = 0
                flashLabelDescription()
                Exit Sub
            End If


            'CHECK IF AREA AND DESCRIPTION FIELDS ARE SELECTED IF NOT THEN QUITS THE SAVE SUB
            If cmboArea.Text = ("Please select ...") Then Exit Sub
            If cmboSurveyor.Text = ("Please select ...") Then Exit Sub
            If cmboJobType.Text = ("Please select ...") Then Exit Sub
            If cmboInstrumentA.Text = ("Please select ...") Then Exit Sub

            'Create and open new folder for the data to reside
            dataDir = formSettings.settingsProjectFolder & "\Area\" & cmboArea.Text & "\Field Data\" & cmboJobType.Text & "\" & txtJobRefNum.Text & " - " & txtJobDescription.Text
            If Not System.IO.Directory.Exists(dataDir) Then
                System.IO.Directory.CreateDirectory(dataDir)
            End If
            Process.Start("explorer.exe", """" & dataDir & """")


            '-- SQL INSERT QUERY IN TO THE DATABASE --
            SQL.DataUpdate("SET DATEFORMAT dmy; INSERT INTO FieldDataRegister ([Job Ref Number], Date, Surveyor, Area, " & _
                                                          "[Job Type], [job Description], [FLD-BK/PG], [Instrument A], Comments, " & _
                                                          "Created) " & _
                            "VALUES (" & _
                            "'" & (txtJobRefNum.Text).ToUpper & "', " & _
                            "'" & dtpDate.Value & "', " & _
                            "'" & cmboSurveyor.Text & "', " & _
                            "'" & cmboArea.Text & "', " & _
                            "'" & cmboJobType.Text & "', " & _
                            "'" & txtJobDescription.Text & "', " & _
                            "'FB-" & txtFieldBook.Text & " / pg" & txtFieldPage.Text & "', " & _
                            "'" & cmboInstrumentA.Text & "', " & _
                            "'" & txtComments.Text & "', " & _
                            "GETDATE())")


            'UPDATE THE BACKUP CSV FILE USING BCP UTILITY
            '(extension), (tablename), (destination)
            export.exportTable_Single("csv", "FieldDataRegister", export.backupFolder)

            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Export CSV for backup", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' CONVERTS ALL ENTERED TEXT TO UPPER CASE
    Private Sub TextBoxToUpper_KeyPress(sender As Object, e As KeyPressEventArgs) _
        Handles txtJobRefNum.KeyPress
        Try
            'ONLY ALLOW CAPS TO BE ENTERED IN TO DOCUMENT NAME TEXTBOX
            If (Char.IsLower(e.KeyChar)) Then
                e.KeyChar = Char.ToUpper(e.KeyChar)
            End If

            'MAKES WARNING LABEL NOT VISIBLE
            lblDocumentNameWarning.Visible = False
            Timer1.Stop()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Convert text to UpperCase", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub


    'SETUP MATCH STRINGS FOR SURVEYORS NAME
    Private Sub txtJobRefNum_KeyUp(sender As Object, e As KeyEventArgs) Handles txtJobRefNum.KeyUp
        ''''''''        'removes all numeric values from document name string
        ''''''''        nonNumericOnlyString = NumericCharacters.Replace(txtJobRefNum.Text, String.Empty)
        ''''''''        For Each Me.matchString In My.Settings.settingsSRRSurveyors.ToArray() 'Cycle through the surveyors list in settings
        ''''''''            matchStringDelimited = Split(matchString, " - ", , CompareMethod.Text)
        ''''''''            If String.Compare(nonNumericOnlyString.TrimEnd, matchStringDelimited(0).TrimEnd, True) = 0 Then
        ''''''''                Me.cmboSurveyor.SelectedItem = (matchString)
        ''''''''            End If
        ''''''''        Next
    End Sub

    'CLEAR WARNING LABEL ONCE TEXT IS TYPED IN TO TITLE TEXTBOX
    Private Sub txtTitle_TextChanged(sender As Object, e As EventArgs) Handles txtJobDescription.TextChanged
        lblDescriptionWarning.Visible = False
    End Sub

    '----==== TIMERS ====---------------------------------------------------------
    Private Sub flashLabelDocumentName() Handles Timer1.Tick
        Timer1.Interval = 500
        Timer1.Enabled = True
        Timer1.Start()
        tickCount += 1
        If Not tickCount > 5 Then
            lblDocumentNameWarning.Visible = Not lblDocumentNameWarning.Visible
        Else
            lblDocumentNameWarning.Visible = True
            Timer1.Stop()
        End If
    End Sub
    Private Sub flashLabelDescription() Handles Timer2.Tick
        Timer2.Interval = 500
        Timer2.Enabled = True
        Timer2.Start()
        tickCountTitle += 1
        If Not tickCountTitle > 5 Then
            lblDescriptionWarning.Visible = Not lblDescriptionWarning.Visible
        Else
            lblDescriptionWarning.Visible = True
            Timer2.Stop()
        End If
    End Sub
    Private Sub flashLabelFieldBook() Handles Timer3.Tick
        Timer3.Interval = 500
        Timer3.Enabled = True
        Timer3.Start()
        tickCountTitle += 1
        If Not tickCountTitle > 5 Then
            lblFieldBookWarning.Visible = Not lblFieldBookWarning.Visible
        Else
            lblFieldBookWarning.Visible = True
            Timer3.Stop()
        End If
    End Sub

    Private Sub formNewEntryFieldDataRegister_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        formMain.Enabled() = True
    End Sub

    '----ESCAPE CHARACTERS ENTERED IN TO THE TEXT BOXES----
    ' ALLOW NUMBERS AND LETTERS
    Private Sub escapeCharacters_KeyPress(sender As Object, e As KeyPressEventArgs) _
        Handles txtComments.KeyPress, txtJobDescription.KeyPress, txtJobRefNum.KeyPress
        'Escape Characters Class (e as keyPress, allow numbers, allow letters)
        EscapeChars.Include(e, True, True)
    End Sub

    ' ALLOW NUMBERS ONLY, NO SPACES
    Private Sub txtFieldBook_KeyPress(sender As Object, e As KeyPressEventArgs) _
        Handles txtFieldBook.KeyPress
        'Escape Characters Class (e as keyPress, allow numbers, remove letters, remove spaces)
        EscapeChars.Include(e, True, False, True)
        'Stop flashing warning on keypress 
        Timer1.Stop()
        lblDocumentNameWarning.Visible = False
    End Sub

    ' ALLOW NUMBERS ONLY, NO SPACES, ADD HYPHENS
    Private Sub txtFieldPage_KeyPress(sender As Object, e As KeyPressEventArgs) _
        Handles txtFieldPage.KeyPress
        'Escape Characters Class (e as keyPress, allow numbers, remove letters, remove spaces, add hyphens)
        EscapeChars.Include(e, True, False, True, True)
        'Stop flashing warning on keypress 
        Timer1.Stop()
        lblDocumentNameWarning.Visible = False
    End Sub


    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    
End Class