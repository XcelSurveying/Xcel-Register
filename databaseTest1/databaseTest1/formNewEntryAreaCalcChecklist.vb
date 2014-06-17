﻿Public Class formNewEntryAreaCalcChecklist
    Dim SQL As New SQLControl

    Private Sub formModifyAreaCalcChecklist_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        formMain.Enabled = True 'Enables the main form when this form is closed
    End Sub

    Private Sub cmdNewEntrySave_Click(sender As Object, e As EventArgs) Handles cmdNewEntrySave.Click
        Dim row As DataGridViewRow
        row = formMain.DGVData.Rows(formMain.DGVData.CurrentRow.Index) 'Returns integer value of the select row index from the datagrid

        SQL.DataUpdate("SET DATEFORMAT dmy; INSERT INTO AreaCalcChecklist ([Model/Layer], [Drawing Number], [TQ/RFI], [Calc'd by], " & _
                                                      "[Calc'd date], [Checked by], [Checked date], Comments, " & _
                                                      "Created) " & _
                        "VALUES (" & _
                        "'" & txtNewEntryModelLayer.Text & "', " & _
                        "'" & txtNewEntryDrawingNumber.Text & "', " & _
                        "'" & txtNewEntryTqRfi.Text & "', " & _
                        "'" & txtNewEntryCalcdBy.Text & "', " & _
                        "'" & dtpNewEntryCalcdDate.Value & "', " & _
                        "'" & txtNewEntryCheckedBy.Text & "', " & _
                        "'" & dtpNewEntryCheckedDate.Value & "', " & _
                        "'" & txtNewEntryComments.Text & "', " & _
                        "GETDATE())")

        Me.Close()

    End Sub
End Class