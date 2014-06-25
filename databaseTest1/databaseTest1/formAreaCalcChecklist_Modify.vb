Public Class formAreaCalcChecklist_Modify
    Dim SQL As New SQLControl
    Dim EscapeChars As New EscapeChars
    Dim export As New exportTables

    'LOAD TEXTBOX'S WITH FIELDS FROM DATABASE
    Private Sub formAreaCalcChecklist_Modify_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

        Dim row As DataGridViewRow
        row = formMain.DGVData.Rows(formMain.DGVData.CurrentRow.Index) 'Returns integer value of the select row index from the datagrid

        txtModelLayer.Text = (row.Cells("Model/Layer").Value.ToString).Trim
        txtDrawingNumber.Text = (row.Cells("Drawing Number").Value.ToString).Trim
        txtTqRfi.Text = (row.Cells("TQ/RFI").Value.ToString).Trim
        cmboCalcdBy.Text = (row.Cells("Calc'd By").Value.ToString).Trim
        cmboCheckedBy.Text = (row.Cells("Checked By").Value.ToString).Trim
        txtComments.Text = (row.Cells("Comments").Value.ToString).Trim
        dtpCalcdDate.Value = (row.Cells("Calc'd Date").Value).Trim
        dtpCheckedDate.Value = (row.Cells("Checked Date").Value).Trim




    End Sub


    Private Sub formAreaCalcChecklist_Modify_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        formMain.Enabled = True 'Enables the main form when this form is closed
    End Sub


    Private Sub cmdModifySave_Click(sender As Object, e As EventArgs) Handles cmdModifySave.Click
        Dim row As DataGridViewRow
        row = formMain.DGVData.Rows(formMain.DGVData.CurrentRow.Index) 'Returns integer value of the select row index from the datagrid

        SQL.DataUpdate("SET DATEFORMAT dmy; UPDATE AreaCalcChecklist " & _
                       "SET " & _
                       "[Model/Layer]='" & txtModelLayer.Text & "', " & _
                       "[Drawing Number]='" & txtDrawingNumber.Text & "', " & _
                       "[TQ/RFI]='" & txtTqRfi.Text & "', " & _
                       "[Calc'd by]='" & cmboCalcdBy.Text & "', " & _
                       "[Checked by]='" & cmboCheckedBy.Text & "', " & _
                       "Comments='" & txtComments.Text & "', " & _
                       "[Calc'd date]='" & dtpCalcdDate.Value & "', " & _
                       "[Checked date]='" & dtpCheckedDate.Value & "', " & _
                       "Modified=GETDATE() " & _
                       "WHERE ID='" & row.Cells("ID").Value.ToString & "'") 'gets unique ID of the row selected


        'UPDATE THE BACKUP CSV FILE USING BCP UTILITY
        '(extension), (tablename), (destination)
        export.exportTable_Single("csv", "AreaCalcChecklist", export.backupFolder)

        Me.Close()

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