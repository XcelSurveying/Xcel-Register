Public Class formModifyFieldDataRegister
    Dim sql As New SQLControl
    Dim export As New exportTables

    Dim nonNumericOnlyString As String
    Dim matchString As String
    Dim matchStringDelimited() As String
    Dim NumericCharacters As New System.Text.RegularExpressions.Regex("\d")
    Dim foundMatch As Boolean = False

    Dim ID As String = ""

    Dim tickCount As Integer = 0
    Dim tickCountTitle As Integer = 0


    'FORM LOAD
    Private Sub formModifyFieldDataRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Form Settings
        Me.ShowIcon = False
        Me.MinimizeBox = False
        Me.MaximizeBox = False
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedToolWindow

        'POPULATE THE COMBOBOX'S WITH VALUES FROM LISTBOX IN SETTINGS
        'Uses saved listbox settings, converts them to an array then uses the data to fill the combobox
        cmboArea.Items.Clear()
        cmboArea.Items.AddRange(My.Settings.settingsFDRArea.ToArray())
        cmboJobType.Items.Clear()
        cmboJobType.Items.AddRange(My.Settings.settingsFDRJobType.ToArray())
        cmboSurveyor.Items.Clear()
        cmboSurveyor.Items.AddRange(My.Settings.settingsSRRSurveyors.ToArray())
        cmboInstrumentA.Items.Clear()
        cmboInstrumentA.Items.AddRange(My.Settings.settingsFDRInstrumentA.ToArray())

        ' 'CREATE'S A PROMPT TO COMBOBOX TO SELECT VALUE
        ' Me.cmboSurveyor.DropDownStyle = ComboBoxStyle.DropDownList
        ' Me.cmboSurveyor.Items.Insert(0, "Please select ...")
        ' Me.cmboSurveyor.SelectedItem = "Please select ..."
        ' Me.cmboArea.DropDownStyle = ComboBoxStyle.DropDownList
        ' Me.cmboArea.Items.Insert(0, "Please select ...")
        ' Me.cmboArea.SelectedItem = "Please select ..."
        ' Me.cmboJobType.DropDownStyle = ComboBoxStyle.DropDownList
        ' Me.cmboJobType.Items.Insert(0, "Please select ...")
        ' Me.cmboJobType.SelectedItem = "Please select ..."
        ' Me.cmboInstrumentA.DropDownStyle = ComboBoxStyle.DropDownList
        ' Me.cmboInstrumentA.Items.Insert(0, "Please select ...")
        ' Me.cmboInstrumentA.SelectedItem = "Please select ..."


        'FILL ALL TEXT BOXES FROM LINE SELECTED IN DATAGRID VIE FROM DATABASE

        Dim row As New DataGridViewRow
        row = formMain.DGVData.Rows(formMain.DGVData.CurrentRow.Index)

        ID = (row.Cells("ID").Value.ToString).Trim
        txtJobRefNum.Text = (row.Cells("Job Ref Number").Value.ToString).Trim
        dtpDate.Text = (row.Cells("Date").Value.ToString).Trim
        cmboSurveyor.Text = (row.Cells("Surveyor").Value.ToString).Trim
        cmboArea.Text = (row.Cells("Area").Value.ToString).Trim
        cmboJobType.Text = (row.Cells("Job Type").Value.ToString).Trim
        txtJobDescription.Text = (row.Cells("Job description").Value.ToString).Trim
        txtFieldBook.Text = (row.Cells("FLD-BK/PG").Value.ToString).Trim
        txtFieldPage.Text = (row.Cells("FLD-BK/PG").Value.ToString).Trim
        cmboInstrumentA.Text = (row.Cells("Instrument A").Value.ToString).Trim
        txtComments.Text = (row.Cells("Comments").Value.ToString).Trim


        'VALIDATING CONTROL FOR ALL TEXTBOX AND COMBOBOX IN FORM
        For Each c As Control In Me.Controls
            If TypeOf (c) Is TextBox Or TypeOf (c) Is ComboBox Then
                AddHandler c.Validating, AddressOf Me.TextBox_Validating
            End If
        Next


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
        Me.cmboSurveyor.Items.Remove("Please select ...")
        If Me.cmboSurveyor.SelectedItem = ("") Then Me.cmboSurveyor.SelectedIndex = 0
    End Sub
    Private Sub cmboArea_DropDown(sender As Object, e As EventArgs) Handles cmboArea.DropDown
        Me.cmboArea.Items.Remove("Please select ...")
        If Me.cmboArea.SelectedItem = ("") Then Me.cmboArea.SelectedIndex = 0
    End Sub
    Private Sub cmboJobType_DropDown(sender As Object, e As EventArgs) Handles cmboJobType.DropDown
        Me.cmboJobType.Items.Remove("Please select ...")
        If Me.cmboJobType.SelectedItem = ("") Then Me.cmboJobType.SelectedIndex = 0
    End Sub
    Private Sub cmboInstrumentA_DropDown(sender As Object, e As EventArgs) Handles cmboInstrumentA.DropDown
        Me.cmboInstrumentA.Items.Remove("Please select ...")
        If Me.cmboInstrumentA.SelectedItem = ("") Then Me.cmboInstrumentA.SelectedIndex = 0
    End Sub

    'ONLY ALLOW NUMERIC VALUES TO BE ENTERED IN TO REV TEXTBOX
    Private Sub txtFieldBook_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFieldBook.KeyPress, txtFieldPage.KeyPress
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

    '--------====== SAVE ENTRY =======-------
    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
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
            nonNumericOnlyString = NumericCharacters.Replace(txtJobRefNum.Text, String.Empty) 'removes all numeric values from document name string
            For Each Me.matchString In My.Settings.settingsSRRSurveyors.ToArray() 'Cycle through the surveyors list in settings
                matchStringDelimited = Split(matchString, " - ", , CompareMethod.Text)
                If String.Compare(nonNumericOnlyString.TrimEnd, matchStringDelimited(0).TrimEnd, True) = 0 Then
                    foundMatch = True
                End If
            Next
            If foundMatch = False Then
                lblDocumentNameWarning.Text = ("Surveyor initials " & nonNumericOnlyString & " not found in settings list")
                tickCount = 0
                flashLabelDocumentName()
                Exit Sub
            End If


            'CHECK TO SEE IF JOB DECRIPTION FIELD IS NOT BLANK
            If txtJobDescription.Text = ("") Then
                lblDescriptionWarning.Text = ("Please enter a Job Description")
                tickCount = 0
                flashLabelDescription()
                Exit Sub
            End If

            'CHECK TO SEE IF FIELD BOOK FIELDS ARE NOT BLANK
            If txtJobDescription.Text = ("") Then
                lblDescriptionWarning.Text = ("Please enter a title for the report")
                tickCount = 0
                flashLabelDescription()
                Exit Sub
            End If


            'CHECK IF AREA AND DESCRIPTION FIELDS ARE SELECTED IF NOT THEN QUITS THE SAVE SUB
            If cmboArea.Text = ("Please select ...") Then Exit Sub
            If cmboSurveyor.Text = ("Please select ...") Then Exit Sub
            If cmboJobType.Text = ("Please select ...") Then Exit Sub
            If cmboInstrumentA.Text = ("Please select ...") Then Exit Sub

            '-- SQL UPDATE QUERY IN TO THE DATABASE -- 'variable ID Set on formLoad
            sql.DataUpdate("SET DATEFORMAT dmy; UPDATE FieldDataRegister " & _
                            "SET " & _
                            "[Job Ref Number]='" & (txtJobRefNum.Text).ToUpper & "', " & _
                            "Date='" & dtpDate.Value & "', " & _
                            "Surveyor='" & cmboSurveyor.Text & "', " & _
                            "Area='" & cmboArea.Text & "', " & _
                            "[Job Type]='" & cmboJobType.Text & "', " & _
                            "[Job Description]='" & txtJobDescription.Text & "', " & _
                            "[FLD-BK/PG]='" & txtFieldBook.Text & "/" & txtFieldPage.Text & "', " & _
                            "[Instrument A]='" & cmboInstrumentA.Text & "', " & _
                            "Comments='" & txtComments.Text & "', " & _
                            "Modified = GETDATE() " & _
                            "WHERE ID='" & ID & "'")


            'UPDATE THE BACKUP CSV FILE USING BCP UTILITY
            '(extension), (tablename), (destination)
            export.exportTable_Single("csv", "FieldDataRegister", "C:\XCELRegister")

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
        'removes all numeric values from document name string
        nonNumericOnlyString = NumericCharacters.Replace(txtJobRefNum.Text, String.Empty)
        For Each Me.matchString In My.Settings.settingsSRRSurveyors.ToArray() 'Cycle through the surveyors list in settings
            matchStringDelimited = Split(matchString, " - ", , CompareMethod.Text)
            If String.Compare(nonNumericOnlyString.TrimEnd, matchStringDelimited(0).TrimEnd, True) = 0 Then
                Me.cmboSurveyor.SelectedItem = (matchString)
            End If
        Next
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

    Private Sub formModifyFieldDataRegister_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        formMain.Enabled() = True
    End Sub

    'ESCAPE CHARACTERS ENTERED IN TO THE TEXT BOXES
    Private Sub escapeCharacters_KeyPress(sender As Object, e As KeyPressEventArgs) _
        Handles txtModifyModelLayer.KeyPress, txtModifyComments.KeyPress, txtModifyDrawingNumber.KeyPress, txtModifyTqRfi.KeyPress
        'Escape Characters Class (e as keyPress, allow numbers, allow letters)
        EscapeChars.Include(e, True, True)
    End Sub


End Class