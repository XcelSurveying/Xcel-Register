Public Class formTqRfiRegister_New
    Dim sql As New SQLControl
    Dim export As New exportTables
    Dim EscapeChars As New EscapeChars


    Private Sub formNewEntryTqRfiRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Form Settings
        Me.ShowIcon = False
        Me.MinimizeBox = False
        Me.MaximizeBox = False
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedToolWindow

        'Load comboBox items from settings
        cmboSurveyor.Items.Clear()
        cmboSurveyor.Items.AddRange(My.Settings.settingsSRRSurveyors.ToArray())
        cmboArea.Items.Clear()
        cmboArea.Items.AddRange(My.Settings.settingsTQRArea.ToArray())

        'CREATE'S A PROMPT TO COMBOBOX TO SELECT VALUE
        Me.cmboSurveyor.DropDownStyle = ComboBoxStyle.DropDownList
        Me.cmboSurveyor.Items.Insert(0, "Please select ...")
        Me.cmboSurveyor.SelectedItem = "Please select ..."
        Me.cmboArea.DropDownStyle = ComboBoxStyle.DropDownList
        Me.cmboArea.Items.Insert(0, "Please select ...")
        Me.cmboArea.SelectedItem = "Please select ..."

        'SET DATE TO TODAY
        dtpDate.Value = Today

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

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click

        'CHECK TO SEE IF TITLE FIELD IS NOT BLANK
        If txtDescription.Text = ("") Then
            lblDNMessage.Text = ("Please enter a Drawing Number!")
            lblDNMessage.Visible = True
            'tickCount = 0
            'flashLabelTitle()
            Exit Sub
        End If

        'CHECK IF AREA AND DESCRIPTION FIELDS ARE SELECTED
        If cmboArea.Text = ("Please select ...") Then Exit Sub
        If cmboSurveyor.Text = ("Please select ...") Then Exit Sub

        '-- SQL INSERT QUERY IN TO THE DATABASE --
        sql.DataUpdate("SET DATEFORMAT dmy; INSERT INTO TQRFIRegister ([Drawing Number], [TQ / RFI], [Date Reieved], " & _
                                                      "Surveyor, Area, Description, Created) " & _
                        "VALUES (" & _
                        "'" & txtDrawingNumber.Text & "', " & _
                        "'" & txtTqRfi.Text & "', " & _
                        "'" & dtpDate.Text & "', " & _
                        "'" & cmboSurveyor.Text & "', " & _
                        "'" & cmboArea.Text & "', " & _
                        "'" & txtDescription.Text & "', " & _
                        "GETDATE())")

        'UPDATE THE BACKUP CSV FILE USING BCP UTILITY
        export.exportTable_Single("csv", "TqRfiRegister", "C:\XCELRegister")

        Me.Close()

    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub formNewEntryTqRfiRegister_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        formMain.Enabled = True
    End Sub

    'REMOVE MESSAGE FOR TEXTBOX WHEN TEXT CHANGED
    Private Sub txtDrawingNumber_TextChanged(sender As Object, e As EventArgs) Handles txtDrawingNumber.TextChanged
        lblDNMessage.Visible = False 'DRAWING NUMBER remove message
    End Sub
    Private Sub txtTqRfi_TextChanged(sender As Object, e As EventArgs) Handles txtTqRfi.TextChanged
        lblTQMessage.Visible = False 'TQ / RFI remove message
    End Sub

    'ESCAPE CHARACTERS ENTERED IN TO THE TEXT BOXES
    Private Sub escapeCharacters_KeyPress(sender As Object, e As KeyPressEventArgs) _
        Handles txtDrawingNumber.KeyPress, txtTqRfi.KeyPress, txtDescription.KeyPress
        Try
            'Escape Characters Class (e as keyPress, allow numbers, allow letters)
            EscapeChars.Include(e, True, True)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class