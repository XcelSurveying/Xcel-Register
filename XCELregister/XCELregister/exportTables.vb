Public Class exportTables

    Public backupFolder As String = "C:\XCELRegister"

    Public Sub exportCSV_All()
        Try
            If (MessageBox.Show("Are you sure you want to export ALL tables?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No) Then
                Exit Sub
            End If

            Shell("cmd.exe /c if not exist C:\XCELregister mkdir C:\XCELregister")
            Shell("cmd.exe /c bcp register.dbo.AreaCalcChecklist out C:\XCELregister\AreaCalcChecklist_Backup.csv -c -t, -T -S" & My.Settings.settingsDbServerName)
            Shell("cmd.exe /c bcp register.dbo.SurveyReportRegister out C:\XCELregister\SurveyReportRegister_Backup.csv -c -t, -T -S" & My.Settings.settingsDbServerName)
            Shell("cmd.exe /c bcp register.dbo.FieldDataRegister out C:\XCELregister\FieldDataRegister_Backup.csv -c -t, -T -S" & My.Settings.settingsDbServerName)
            Shell("cmd.exe /c bcp register.dbo.TQRFIRegister out C:\XCELregister\TQRFIRegister_Backup.csv -c -t, -T -S" & My.Settings.settingsDbServerName)

            MessageBox.Show("Table CSV files copied successfully to C:\XCELregister", _
                        "Export Tables as Comma Separated Values", MessageBoxButtons.OK, _
                         MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Export all CSV files for backup", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub exportTable_Single(extension As String, table As String, destinationDir As String)
        Shell("cmd.exe /c if not exist " & destinationDir & " mkdir " & destinationDir)
        Shell("cmd.exe /c bcp register.dbo." & table & " out " & destinationDir & "\" & table & "_Backup." & extension & " -c -t, -T -S" & My.Settings.settingsDbServerName)

    End Sub

End Class