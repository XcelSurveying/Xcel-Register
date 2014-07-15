Public Class MainFormButtons

    Public Sub Enable()
        formMain.cmdDeleteRow.Enabled = True
        formMain.cmdModifySelectedRow.Enabled = True
        formMain.cmdNewEntry.Enabled = True
        formMain.rbAreaCalcChecklist.Enabled = True
        formMain.rbFieldDataRegister.Enabled = True
        formMain.rbSurveyReportRegister.Enabled = True
        formMain.rbTqRfiRegister.Enabled = True
        formMain.cmdExportXLXS.Enabled = True
    End Sub

    Public Sub Disable()
        formMain.cmdDeleteRow.Enabled = False
        formMain.cmdModifySelectedRow.Enabled = False
        formMain.cmdNewEntry.Enabled = False
        formMain.rbAreaCalcChecklist.Enabled = False
        formMain.rbFieldDataRegister.Enabled = False
        formMain.rbSurveyReportRegister.Enabled = False
        formMain.rbTqRfiRegister.Enabled = False
        formMain.cmdExportXLXS.Enabled = False
    End Sub

End Class
