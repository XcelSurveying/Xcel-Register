Public Class formModifyTqRfiRegister
    Dim sql As New SQLControl
    Dim export As New exportTables


    Private Sub formModifyTqRfiRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
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

            'FILL ALL TEXT BOXES FROM LINE SELECTED IN DATAGRID VIE FROM DATABASE
            Dim row As New DataGridViewRow
            row = formMain.DGVData.Rows(formMain.DGVData.CurrentRow.Index)

            txtDrawingNumber.Text = (row.Cells("Drawing Number").Value.ToString).Trim
            txtTqRfi.Text = (row.Cells("TQ / RFI").Value.ToString).Trim
            dtpDate.Text = (row.Cells("Date Reieved").Value.ToString).Trim
            cmboSurveyor.Text = (row.Cells("Surveyor").Value.ToString).Trim
            cmboArea.Text = (row.Cells("Area").Value.ToString).Trim
            txtDescription.Text = (row.Cells("Description").Value.ToString).Trim
        Catch ex As Exception

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
        sql.DataUpdate("SET DATEFORMAT dmy; UPDATE TQRFIRegister " & _
                        "SET " & _
                       "[Drawing Number]='" & txtDrawingNumber.Text & "', " & _
                       "[TQ / RFI]='" & txtTqRfi.Text & "', " & _
                       "[Date Reieved]='" & dtpDate.Text & "', " & _
                       "Surveyor='" & cmboSurveyor.Text & "', " & _
                       "Area='" & cmboArea.Text & "', " & _
                       "Description='" & txtDescription.Text & "', " & _
                       "Modified=GETDATE()")

        'UPDATE THE BACKUP CSV FILE USING BCP UTILITY
        export.exportTable_Single("csv", "TqRfiRegister", "C:\XCELRegister")

        Me.Close()

    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub formModifyTqRfiRegister_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
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
        Handles txtModifyModelLayer.KeyPress, txtModifyComments.KeyPress, txtModifyDrawingNumber.KeyPress, txtModifyTqRfi.KeyPress
        'Escape Characters Class (e as keyPress, allow numbers, allow letters)
        EscapeChars.Include(e, True, True)
    End Sub

End Class