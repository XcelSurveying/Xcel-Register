Public Class formAreaCalcChecklist_New
    Dim SQL As New SQLControl
    Dim EscapeChars As New EscapeChars

    Private Sub formAreaCalcChecklist_Modify_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        formMain.Enabled = True 'Enables the main form when this form is closed
    End Sub

    Private Sub cmdNewEntrySave_Click(sender As Object, e As EventArgs) Handles cmdNewEntrySave.Click

        If txtDrawingNumber.Text = "" Then
            Exit Sub
        End If

        If txtModelLayer.Text = "" Then
            Exit Sub
        End If

        If txtTqRfi.Text = "" Then
            Exit Sub
        End If

        If cmboCalcdBy.Text = "Please select ..." OrElse cmboCalcdBy.Text = "" Then
            Exit Sub
        End If

        If cmboCheckedBy.Text = "Please select ..." OrElse cmboCheckedBy.Text = "" Then
            Exit Sub
        End If

        SQL.DataUpdate("SET DATEFORMAT dmy; INSERT INTO AreaCalcChecklist ([Model/Layer], [Drawing Number], [TQ/RFI], [Calc'd by], " & _
                                                      "[Calc'd date], [Checked by], [Checked date], Comments, " & _
                                                      "Created) " & _
                        "VALUES (" & _
                        "'" & txtModelLayer.Text & "', " & _
                        "'" & txtDrawingNumber.Text & "', " & _
                        "'" & txtTqRfi.Text & "', " & _
                        "'" & cmboCalcdBy.Text & "', " & _
                        "'" & dtpCalcdDate.Value & "', " & _
                        "'" & cmboCheckedBy.Text & "', " & _
                        "'" & dtpCheckedDate.Value & "', " & _
                        "'" & txtComments.Text & "', " & _
                        "GETDATE())")

        Me.Close()

    End Sub

    Private Sub formAreaCalcChecklist_New_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Form Settings
        Me.ShowIcon = False
        Me.MinimizeBox = False
        Me.MaximizeBox = False
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedToolWindow

        'POPULATE THE COMBOBOX'S WITH VALUES FROM LISTBOX IN SETTINGS
        'Uses saved listbox settings, converts them to an array then uses the data to fill the combobox
        cmboCalcdBy.Items.Clear()
        cmboCalcdBy.Items.AddRange(My.Settings.settingsSRRSurveyors.ToArray())
        cmboCheckedBy.Items.Clear()
        cmboCheckedBy.Items.AddRange(My.Settings.settingsSRRSurveyors.ToArray())


        'CREATE'S A PROMPT TO COMBOBOX TO SELECT VALUE
        Me.cmboCalcdBy.DropDownStyle = ComboBoxStyle.DropDownList
        Me.cmboCalcdBy.Items.Insert(0, "Please select ...")
        Me.cmboCalcdBy.SelectedItem = "Please select ..."
        Me.cmboCheckedBy.DropDownStyle = ComboBoxStyle.DropDownList
        Me.cmboCheckedBy.Items.Insert(0, "Please select ...")
        Me.cmboCheckedBy.SelectedItem = "Please select ..."


        '  'VALIDATING CONTROL FOR ALL TEXTBOX AND COMBOBOX IN FORM
        '  For Each c As Control In Me.Controls
        '      If TypeOf (c) Is TextBox Or TypeOf (c) Is ComboBox Then
        '          AddHandler c.Validating, AddressOf Me.TextBox_Validating
        '      End If
        '  Next

        'SET DATE TO TODAY
        dtpCalcdDate.Value = Today
        dtpCheckedDate.Value = Today

    End Sub

    'REMOVE PLEASE SELECT PROMPTS FROM COMBOBOX'S WHEN DROPDOWN IS SELECTED
    Private Sub cmboCalcdBy_DropDown(sender As Object, e As EventArgs) Handles cmboCalcdBy.DropDown
        Me.cmboCalcdBy.Items.Remove("Please select ...")
        If Me.cmboCalcdBy.SelectedItem = ("") Then Me.cmboCalcdBy.SelectedIndex = 0
    End Sub
    Private Sub cmboCheckedBy_DropDown(sender As Object, e As EventArgs) Handles cmboCheckedBy.DropDown
        Me.cmboCheckedBy.Items.Remove("Please select ...")
        If Me.cmboCheckedBy.SelectedItem = ("") Then Me.cmboCheckedBy.SelectedIndex = 0
    End Sub

    'ESCAPE CHARACTERS ENTERED IN TO THE TEXT BOXES
    Private Sub escapeCharacters_KeyPress(sender As Object, e As KeyPressEventArgs) _
        Handles txtModelLayer.KeyPress, txtComments.KeyPress, txtDrawingNumber.KeyPress, txtTqRfi.KeyPress
        'Escape Characters Class (e as keyPress, allow numbers, allow letters)
        EscapeChars.Include(e, True, True)
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub
End Class