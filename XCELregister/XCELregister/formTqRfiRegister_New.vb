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

        'POPULATE THE COMBOBOX'S WITH VALUES FROM LISTBOX IN SETTINGS
        'Uses saved listbox settings, converts them to an array then uses the data to fill the combobox

        'Listbox 1 Area
        sql.PopulateListbox1("settingsTqrfiArea")
        cmboArea.DataSource = sql.dtData1
        cmboArea.DisplayMember = "data"
        cmboArea.ValueMember = "ID"
        cmboArea.SelectedIndex = 0

        'Listbox 2 InstrumentA
        sql.PopulateListbox2("settingsCommonSurveyors")
        cmboSurveyor.DataSource = sql.dtData2
        cmboSurveyor.DisplayMember = "data"
        cmboSurveyor.ValueMember = "ID"
        cmboSurveyor.SelectedIndex = 0

        'SET DATE TO TODAY
        dtpDate.Value = Today

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
        export.exportTable_Single("csv", "TqRfiRegister", export.backupFolder)

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