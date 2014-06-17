﻿Public Class formRestoreTables
    Dim sql As New SQLControl

    Private Sub formRestoreTables_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtInstructions.Clear()
        txtInstructions.BorderStyle = BorderStyle.None
        txtInstructions.SelectionFont = New Font("Tahoma", 8.25)
        txtInstructions.SelectedText = "In order for the table restorer to work, the .CSV files used to restore must be placed in the following folder path..." + ControlChars.Cr + ControlChars.Cr
        txtInstructions.SelectionFont = New Font("Tahoma", 10)
        txtInstructions.SelectedText = ControlChars.Tab + "C:\XCELregister\restore\" + ControlChars.Cr + ControlChars.Cr
        txtInstructions.SelectionFont = New Font("Tahoma", 8.25)
        txtInstructions.SelectedText = "The file names set to..." + ControlChars.Cr + ControlChars.Cr
        txtInstructions.SelectionBullet = True
        txtInstructions.SelectionFont = New Font("Tahoma", 10)
        txtInstructions.SelectedText = "   AreaCalcChecklist_Restore.csv" + ControlChars.Cr
        txtInstructions.SelectionFont = New Font("Tahoma", 10)
        txtInstructions.SelectedText = "   FieldDataRegister_Restore.csv" + ControlChars.Cr
        txtInstructions.SelectionFont = New Font("Tahoma", 10)
        txtInstructions.SelectedText = "   SurveyReportRegister_Restore.csv" + ControlChars.Cr
        txtInstructions.SelectionFont = New Font("Tahoma", 10)
        txtInstructions.SelectedText = "   TQRFIRegister_Restore.csv" + ControlChars.Cr
        ' End the bulleted list.
        txtInstructions.SelectionBullet = False

    End Sub


    Private Sub cmdRestore_Click(sender As Object, e As EventArgs) Handles cmdRestore.Click
        Try
            Dim fileToRestore As String = ""
            Dim restoreFolder As String = ("C:\XCELregister\Restore\") 'Set restore directory
            Dim selectedTable As String = ""

            Select Case True
                Case rbAreaCalcChecklist.Checked
                    fileToRestore = "AreaCalcChecklist_Restore.csv"
                    selectedTable = "AreaCalcChecklist"
                Case rbFieldDataRegister.Checked
                    fileToRestore = "FieldDataRegister_Restore.csv"
                    selectedTable = "FieldDataRegister"
                Case rbSurveyReportRegister.Checked
                    fileToRestore = "SurveyReportRegister_Restore.csv"
                    selectedTable = "SurveyReportRegister"
                Case rbTQRFIRegister.Checked
                    fileToRestore = "TQRFIRegister_Restore.csv"
                    selectedTable = "TQRFIRegister"
            End Select

            sql.DataUpdate("DELETE FROM " & selectedTable & " WHERE 1=1" & vbCrLf & _
                            "USE register " & vbCrLf & _
                            "BULK" & vbCrLf & _
                            "INSERT " & selectedTable & vbCrLf & _
                            "FROM '" & restoreFolder & fileToRestore & "'" & vbCrLf & _
                            "WITH " & vbCrLf & _
                            "( FIELDTERMINATOR = ',', ROWTERMINATOR = '\n')")

            'Renames the backup file so that it cannot be accidentally used again for restore in the future.
            Dim myDateTime As DateTime = DateTime.Now    'Sets the date for the filename to now
            Dim myDateOnly As String = myDateTime.ToString("yyyyMMdd")
            Shell("cmd.exe /c REN " & restoreFolder & fileToRestore & " " & selectedTable & "_RestoreCompleted_" & myDateOnly & ".bak  ")
            'sets the new backup restore file to "table_RestoreCompleted_yyyyMMdd.bak"
            MessageBox.Show("Backup file Renamed to " & selectedTable & "_RestoreCompleted_" & myDateOnly & ".bak  ")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class