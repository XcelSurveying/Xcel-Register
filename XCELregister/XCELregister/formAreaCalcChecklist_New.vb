Public Class formAreaCalcChecklist_New
    Dim SQL As New SQLControl
    Dim EscapeChars As New EscapeChars
    Dim export As New exportTables

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

        'UPDATE THE BACKUP CSV FILE USING BCP UTILITY
        '(extension), (tablename), (destination)
        export.exportTable_Single("csv", "AreaCalcChecklist", export.backupFolder)

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

        'Listbox 1
        SQL.PopulateListbox1("settingsCommonSurveyors")
        cmboCalcdBy.DataSource = SQL.dtData1
        cmboCalcdBy.DisplayMember = "data"
        cmboCalcdBy.ValueMember = "ID"
        cmboCalcdBy.SelectedIndex = 0

        'Listbox 2
        SQL.PopulateListbox2("settingsCommonSurveyors")
        cmboCheckedBy.DataSource = SQL.dtData2
        cmboCheckedBy.DisplayMember = "data"
        cmboCheckedBy.ValueMember = "ID"
        cmboCheckedBy.SelectedIndex = 0

        'SET DATE TO TODAY
        dtpCalcdDate.Value = Today
        dtpCheckedDate.Value = Today

    End Sub

    'REMOVE PLEASE SELECT PROMPTS FROM COMBOBOX'S WHEN DROPDOWN IS SELECTED
    Private Sub cmboCalcdBy_DropDown(sender As Object, e As EventArgs) Handles cmboCalcdBy.DropDown
        Try
            Me.cmboCalcdBy.Items.Remove("Please select ...")
            If Me.cmboCalcdBy.SelectedItem = ("") Then Me.cmboCalcdBy.SelectedIndex = 0
        Catch ex As Exception
        End Try
    End Sub
    Private Sub cmboCheckedBy_DropDown(sender As Object, e As EventArgs) Handles cmboCheckedBy.DropDown
        Try
            Me.cmboCheckedBy.Items.Remove("Please select ...")
            If Me.cmboCheckedBy.SelectedItem = ("") Then Me.cmboCheckedBy.SelectedIndex = 0
        Catch ex As Exception
        End Try
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