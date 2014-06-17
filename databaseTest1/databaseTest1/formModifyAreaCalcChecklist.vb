Public Class formModifyAreaCalcChecklist
    Dim SQL As New SQLControl


    'LOAD TEXTBOX'S WITH FIELDS FROM DATABASE
    Private Sub formModifyAreaCalcChecklist_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim row As DataGridViewRow
        row = formMain.DGVData.Rows(formMain.DGVData.CurrentRow.Index) 'Returns integer value of the select row index from the datagrid

        txtModifyModelLayer.Text = (row.Cells("Model/Layer").Value.ToString).Trim
        txtModifyDrawingNumber.Text = (row.Cells("Drawing Number").Value.ToString).Trim
        txtModifyTqRfi.Text = (row.Cells("TQ/RFI").Value.ToString).Trim
        txtModifyCalcdBy.Text = (row.Cells("Calc'd By").Value.ToString).Trim
        txtModifyCheckedBy.Text = (row.Cells("Checked By").Value.ToString).Trim
        txtModifyComments.Text = (row.Cells("Comments").Value.ToString).Trim
        dtpModifyCalcdDate.Value = (row.Cells("Calc'd Date").Value).Trim
        dtpModifyCheckedDate.Value = (row.Cells("Checked Date").Value).Trim

        'MsgBox("cheked date: " & row.Cells("Calc'd Date").Value)
        'MsgBox("cheked date: " & row.Cells("Checked Date").Value)


    End Sub


    Private Sub formModifyAreaCalcChecklist_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        formMain.Enabled = True 'Enables the main form when this form is closed
    End Sub

    
    Private Sub cmdModifySave_Click(sender As Object, e As EventArgs) Handles cmdModifySave.Click
        Dim row As DataGridViewRow
        row = formMain.DGVData.Rows(formMain.DGVData.CurrentRow.Index) 'Returns integer value of the select row index from the datagrid

        SQL.DataUpdate("SET DATEFORMAT dmy; UPDATE AreaCalcChecklist " & _
                       "SET " & _
                       "[Model/Layer]='" & txtModifyModelLayer.Text & "', " & _
                       "[Drawing Number]='" & txtModifyDrawingNumber.Text & "', " & _
                       "[TQ/RFI]='" & txtModifyTqRfi.Text & "', " & _
                       "[Calc'd by]='" & txtModifyCalcdBy.Text & "', " & _
                       "[Checked by]='" & txtModifyCheckedBy.Text & "', " & _
                       "Comments='" & txtModifyComments.Text & "', " & _
                       "[Calc'd date]='" & dtpModifyCalcdDate.Value & "', " & _
                       "[Checked date]='" & dtpModifyCheckedDate.Value & "', " & _
                       "Modified=GETDATE() " & _
                       "WHERE ID='" & row.Cells("ID").Value.ToString & "'") 'gets unique ID of the row selected

        Me.Close()

    End Sub
End Class