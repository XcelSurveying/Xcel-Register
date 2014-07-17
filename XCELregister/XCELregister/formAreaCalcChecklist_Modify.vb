Public Class formAreaCalcChecklist_Modify
    Dim SQL As New SQLControl
    Dim EscapeChars As New EscapeChars
    Dim export As New exportTables

    Dim ID As String = ""

    'LOAD TEXTBOX'S WITH FIELDS FROM DATABASE
    Private Sub formAreaCalcChecklist_Modify_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim checkedBy As String = ""


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

        Dim row As DataGridViewRow
        row = formMain.DGVData.Rows(formMain.DGVData.CurrentRow.Index) 'Returns integer value of the select row index from the datagrid

        checkedBy = (row.Cells("Checked By").Value.ToString).Trim
        ID = (row.Cells("ID").Value.ToString).Trim
        txtModelLayer.Text = (row.Cells("Model/Layer").Value.ToString).Trim
        txtDrawingNumber.Text = (row.Cells("Drawing Number").Value.ToString).Trim
        txtTqRfi.Text = (row.Cells("TQ/RFI").Value.ToString).Trim
        cmboCalcdBy.Text = (row.Cells("Calc'd By").Value.ToString).Trim
        cmboCheckedBy.Text = checkedBy
        txtComments.Text = (row.Cells("Comments").Value.ToString).Trim
        dtpCalcdDate.Value = (row.Cells("Calc'd Date").Value)
        dtpCheckedDate.Value = (row.Cells("Checked Date").Value)

        'SET UP CHECKED BY AS OFF BY DEFAULT WHEN MODIFYING AN EXISTING ENTRY
        If checkedBy = "... not checked ..." Then
            chkChecked.Checked = False
            cmboCheckedBy.Enabled = False
            dtpCheckedDate.Enabled = False
            Label6.Enabled = False
            Label7.Enabled = False
        Else
            chkChecked.Checked = True
            cmboCheckedBy.Enabled = True
            dtpCheckedDate.Enabled = True
            Label6.Enabled = True
            Label7.Enabled = True
        End If

    End Sub


    Private Sub formAreaCalcChecklist_Modify_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        formMain.Enabled = True 'Enables the main form when this form is closed
    End Sub


    Private Sub cmdModifySave_Click(sender As Object, e As EventArgs) Handles cmdModifySave.Click
        Dim row As DataGridViewRow
        row = formMain.DGVData.Rows(formMain.DGVData.CurrentRow.Index) 'Returns integer value of the select row index from the datagrid

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
        'Only test if the checkbox has been ticked
        If chkChecked.Checked = True Then
            If cmboCheckedBy.Text = "Please select ..." OrElse cmboCheckedBy.Text = "" Then
                Exit Sub
            End If
        End If

        'Check that different surveyor checks the calcs
        If cmboCalcdBy.Text = cmboCheckedBy.Text And chkChecked.Checked = True Then
            MessageBox.Show("You must get another Surveyor to check your calcs", "Check Calcs")
            Exit Sub
        End If

        If chkChecked.Checked = True Then

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
                           "WHERE ID='" & ID & "'") 'gets unique ID of the row selected

        Else
            SQL.DataUpdate("SET DATEFORMAT dmy; UPDATE AreaCalcChecklist " & _
                          "SET " & _
                          "[Model/Layer]='" & txtModelLayer.Text & "', " & _
                          "[Drawing Number]='" & txtDrawingNumber.Text & "', " & _
                          "[TQ/RFI]='" & txtTqRfi.Text & "', " & _
                          "[Calc'd by]='" & cmboCalcdBy.Text & "', " & _
                          "[Checked by]='... not checked ...', " & _
                          "Comments='" & txtComments.Text & "', " & _
                          "[Calc'd date]='" & dtpCalcdDate.Value & "', " & _
                          "Modified=GETDATE() " & _
                          "WHERE ID='" & ID & "'") 'gets unique ID of the row selected

        End If
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

    ' CHECKBOX TO DISABLE OR ENABLE CHECKED BY FIELDS
    Private Sub chkChecked_CheckedChanged(sender As Object, e As EventArgs) Handles chkChecked.CheckedChanged
        If chkChecked.Checked = True Then
            cmboCheckedBy.Enabled = True
            dtpCheckedDate.Enabled = True
            Label6.Enabled = True
            Label7.Enabled = True
        Else
            cmboCheckedBy.Enabled = False
            dtpCheckedDate.Enabled = False
            Label6.Enabled = False
            Label7.Enabled = False
        End If
    End Sub
End Class