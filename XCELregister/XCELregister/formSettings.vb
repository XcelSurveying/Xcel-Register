Public Class formSettings
    Dim SQL As New SQLControl
    Dim EscapeChars As New EscapeChars

    Public Function settingsProjectFolder() As String
        Dim projFolder As String = ""
        Try
            SQL.SettingsQuery("SELECT * FROM settingsProjectFolder ORDER BY data")
            If SQL.SQLDataset_lb.Tables.Count > 0 Then
                projFolder = SQL.SQLDataset_lb.Tables(0).Rows(0)("data").ToString  ' Makes sure that there is data in the Table
            End If
            Return projFolder
        Catch ex As Exception
            MessageBox.Show("Please go to settings and set the Project Folder", "Can't find Project Folder", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return projFolder
        End Try
    End Function


    '--------------------------------------------------------------------------------------------------------------------------
    '                                             R E F R E S H   L I S T B O X E S
    '--------------------------------------------------------------------------------------------------------------------------
    Private Sub RefreshListboxes()
        Try
            SQL.SettingsQuery("SELECT * FROM settingsSurveyReportArea ORDER BY data")
            If SQL.SQLDataset_lb.Tables.Count > 0 Then
                lbSRRArea.DataSource = SQL.SQLDataset_lb.Tables(0)  ' Makes sure that there is data in the Table
                lbSRRArea.DisplayMember = "data"
            End If
            SQL.SettingsQuery("SELECT * FROM settingsSurveyReportDescription ORDER BY data")
            If SQL.SQLDataset_lb.Tables.Count > 0 Then
                lbSRRDescription.DataSource = SQL.SQLDataset_lb.Tables(0)  ' Makes sure that there is data in the Table
                lbSRRDescription.DisplayMember = "data"
            End If
            SQL.SettingsQuery("SELECT * FROM settingsCommonSurveyors ORDER BY data")
            If SQL.SQLDataset_lb.Tables.Count > 0 Then
                lbSRRSurveyors.DataSource = SQL.SQLDataset_lb.Tables(0)  ' Makes sure that there is data in the Table
                lbSRRSurveyors.DisplayMember = "data"
            End If
            SQL.SettingsQuery("SELECT * FROM settingsFieldDataArea ORDER BY data")
            If SQL.SQLDataset_lb.Tables.Count > 0 Then
                lbFDRArea.DataSource = SQL.SQLDataset_lb.Tables(0)  ' Makes sure that there is data in the Table
                lbFDRArea.DisplayMember = "data"
            End If
            SQL.SettingsQuery("SELECT * FROM settingsFieldDataJobtype ORDER BY data")
            If SQL.SQLDataset_lb.Tables.Count > 0 Then
                lbFDRJobType.DataSource = SQL.SQLDataset_lb.Tables(0)  ' Makes sure that there is data in the Table
                lbFDRJobType.DisplayMember = "data"
            End If
            SQL.SettingsQuery("SELECT * FROM settingsFieldDataInstrumentA ORDER BY data")
            If SQL.SQLDataset_lb.Tables.Count > 0 Then
                lbFDRInstrumentA.DataSource = SQL.SQLDataset_lb.Tables(0)  ' Makes sure that there is data in the Table
                lbFDRInstrumentA.DisplayMember = "data"
            End If
            SQL.SettingsQuery("SELECT * FROM settingsTqrfiArea ORDER BY data")
            If SQL.SQLDataset_lb.Tables.Count > 0 Then
                lbTQRArea.DataSource = SQL.SQLDataset_lb.Tables(0)  ' Makes sure that there is data in the Table
                lbTQRArea.DisplayMember = "data"
            End If
            SQL.SettingsQuery("SELECT * FROM settingsProjectFolder ORDER BY data")
            If SQL.SQLDataset_lb.Tables.Count > 0 Then
                txtProjectFolderPath.Text = SQL.SQLDataset_lb.Tables(0).Rows(0)("data").ToString  ' Makes sure that there is data in the Table
            End If
        Catch ex As Exception
        End Try
    End Sub

    '--------------------------------------------------------------------------------------------------------------------------
    '                                                         A D D
    '--------------------------------------------------------------------------------------------------------------------------
    'AREA -- ADD
    Private Sub cmdSRRAreaAdd_Click(sender As Object, e As EventArgs) Handles cmdSRRAreaAdd.Click
        Try
            Dim add As String
            add = EscapeChars.cleanString(InputBox("Enter Area to Add", ""))
            If add <> "" Then
                SQL.DataUpdate("INSERT INTO settingsSurveyReportArea (data) VALUES ('" & add.ToUpper & "')")
                RefreshListboxes()
            End If
        Catch ex As Exception
        End Try
    End Sub
    'DESCRIPTION -- ADD 
    Private Sub cmdSRRDescriptionAdd_Click(sender As Object, e As EventArgs) Handles cmdSRRDescriptionAdd.Click
        Try
            Dim add As String
            add = EscapeChars.cleanString(InputBox("Enter Description to Add", ""))
            If add <> "" Then
                SQL.DataUpdate("INSERT INTO settingsSurveyReportDescription (data) VALUES ('" & add.ToUpper & "')")
                RefreshListboxes()
            End If
        Catch ex As Exception

        End Try
    End Sub
    'SURVEYORS -- ADD
    Private Sub cmdSRRSurveyorsAdd_Click(sender As Object, e As EventArgs) Handles cmdSRRSurveyorsAdd.Click
        Try
            Dim addInitials As String
            Dim addFullName As String
            addInitials = EscapeChars.cleanString_NoHyphen_NoSpace(InputBox("Enter Surveyors Initials :", "")) 'Hyphens not allowed, as this is character is used for a split
            addFullName = EscapeChars.cleanString_NoHyphen(InputBox("Enter Surveyors Full Name :", "")) 'Hyphens not allowed, as this is character is used for a split
            If addInitials <> "" And addFullName <> "" Then
                If addInitials.Length <= 3 Then
                    SQL.DataUpdate("INSERT INTO settingsCommonSurveyors (data) VALUES ('" & addInitials.ToUpper & "  -  " & addFullName & "')")
                    RefreshListboxes()
                Else
                    MessageBox.Show("Initials have a maximum of three characters")
                End If
            End If
        Catch ex As Exception
        End Try
        End Sub
    ' FDR AREA -- ADD
    Private Sub cmdFDRAreaAdd_Click(sender As Object, e As EventArgs) Handles cmdFDRAreaAdd.Click
        Try
            Dim add As String
            add = EscapeChars.cleanString(InputBox("Enter Area to Add", ""))
            If add <> "" Then
                SQL.DataUpdate("INSERT INTO settingsFieldDataArea (data) VALUES ('" & add.ToUpper & "')")
                RefreshListboxes()
            End If
        Catch ex As Exception
        End Try
    End Sub
    ' JOB TYPE -- ADD
    Private Sub cmdJobTypeAdd_Click(sender As Object, e As EventArgs) Handles cmdJobTypeAdd.Click
        Try
            Dim add As String
            add = EscapeChars.cleanString(InputBox("Enter Job Type to Add", ""))
            If add <> "" Then
                SQL.DataUpdate("INSERT INTO settingsFieldDataJobtype (data) VALUES ('" & add.ToUpper & "')")
                RefreshListboxes()
            End If
        Catch ex As Exception
        End Try
    End Sub
    ' INSTRUMENT A ADD
    Private Sub cmdInstrumentAAdd_Click(sender As Object, e As EventArgs) Handles cmdInstrumentAAdd.Click
        Try
            Dim add As String
            add = EscapeChars.cleanString(InputBox("Enter Instrument to Add", ""))
            If add <> "" Then
                SQL.DataUpdate("INSERT INTO settingsFieldDataInstrumentA (data) VALUES ('" & add.ToUpper & "')")
                RefreshListboxes()
            End If
        Catch ex As Exception
        End Try
    End Sub
    ' TQR Area - ADD
    Private Sub cmdTQRAreaAdd_Click(sender As Object, e As EventArgs) Handles cmdTQRAreaAdd.Click
        Try
            Dim add As String
            add = EscapeChars.cleanString(InputBox("Enter Area to Add", ""))
            If add <> "" Then
                SQL.DataUpdate("INSERT INTO settingsTqrfiArea (data) VALUES ('" & add.ToUpper & "')")
                RefreshListboxes()
            End If
        Catch ex As Exception
        End Try
    End Sub

    
    '--------------------------------------------------------------------------------------------------------------------------
    '                                                      R E M O V E
    '--------------------------------------------------------------------------------------------------------------------------
    'AREA -- REMOVE 
    Private Sub cmdSRRAreaRemove_Click(sender As Object, e As EventArgs) Handles cmdSRRAreaRemove.Click
        Try
            Dim selectedItem As String = lbSRRArea.Text
            SQL.DataUpdate("DELETE FROM settingsSurveyReportArea WHERE data=('" & selectedItem & "')")
            RefreshListboxes()
        Catch ex As Exception
        End Try
    End Sub
    'DESCRIPTION -- REMOVE 
    Private Sub cmdSRRDescriptionRemove_Click(sender As Object, e As EventArgs) Handles cmdSRRDescriptionRemove.Click
        Try
            Dim selectedItem As String = lbSRRDescription.Text
            SQL.DataUpdate("DELETE FROM settingsSurveyReportDescription WHERE data=('" & selectedItem & "')")
            RefreshListboxes()
        Catch ex As Exception
        End Try
    End Sub
    'SURVEYORS -- REMOVE 
    Private Sub cmdSRRRSurveyorsRemove_Click(sender As Object, e As EventArgs) Handles cmdSRRRSurveyorsRemove.Click
        Try
            Dim selectedItem As String = lbSRRSurveyors.Text
            SQL.DataUpdate("DELETE FROM settingsCommonSurveyors WHERE data=('" & selectedItem & "')")
            RefreshListboxes()
        Catch ex As Exception
        End Try
    End Sub
    ' FDR AREA -- REMOVE
    Private Sub cmdFDRAreaRemove_Click(sender As Object, e As EventArgs) Handles cmdFDRAreaRemove.Click
        Try
            Dim selectedItem As String = lbFDRArea.Text
            SQL.DataUpdate("DELETE FROM settingsFieldDataArea WHERE data=('" & selectedItem & "')")
            RefreshListboxes()
        Catch ex As Exception
        End Try
    End Sub
    ' JOB TYPE -- REMOVE
    Private Sub cmdJobTypeRemove_Click(sender As Object, e As EventArgs) Handles cmdJobTypeRemove.Click
        Try
            Dim selectedItem As String = lbFDRJobType.Text
            SQL.DataUpdate("DELETE FROM settingsFieldDataJobtype WHERE data=('" & selectedItem & "')")
            RefreshListboxes()
        Catch ex As Exception
        End Try
    End Sub
    ' INSTRUMENT A REMOVE
    Private Sub cmdInstrumentARemove_Click(sender As Object, e As EventArgs) Handles cmdInstrumentARemove.Click
        Try
            Dim selectedItem As String = lbFDRInstrumentA.Text
            SQL.DataUpdate("DELETE FROM settingsFieldDataInstrumentA WHERE data=('" & selectedItem & "')")
            RefreshListboxes()
        Catch ex As Exception
        End Try
    End Sub
    ' TQR Area - REMOVE
    Private Sub cmdTQRAreaRemove_Click(sender As Object, e As EventArgs) Handles cmdTQRAreaRemove.Click
        Try
            Dim selectedItem As String = lbTQRArea.Text
            SQL.DataUpdate("DELETE FROM settingsTqrfiArea WHERE data=('" & selectedItem & "')")
            RefreshListboxes()
        Catch ex As Exception
        End Try
    End Sub

    'LOAD SETTINGS
    Private Sub formSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Form Settings
        Me.ShowIcon = False
        Me.MinimizeBox = False
        Me.MaximizeBox = False
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedToolWindow
        ' Load ListBox with all the settings stored in SQL database
        RefreshListboxes()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub cmdBrowse_Click(sender As Object, e As EventArgs) Handles cmdBrowse.Click
        Try
            Dim folderPath As String = String.Empty
            Dim folderPathOrig As String = txtProjectFolderPath.Text
            Dim isCancel As Boolean = False
            Dim projectFolderBrowser As New FolderBrowserDialog

            'Shows Dialog box prompt
            projectFolderBrowser.ShowDialog()

            If DialogResult.OK Then
                folderPath = projectFolderBrowser.SelectedPath
                txtProjectFolderPath.Text = folderPath
            End If
            If folderPath = "" Then ' Replaces Original folder path when dialog is canceled
                txtProjectFolderPath.Text = folderPathOrig
            Else
                SQL.DataUpdate("DELETE FROM settingsProjectFolder WHERE 1=1; INSERT INTO settingsProjectFolder (data) VALUES ('" & folderPath & "')")
                RefreshListboxes()
            End If
        Catch ex As Exception
        End Try
    End Sub


    'Creates a description in the form describing what the listbox should contain
    Private Sub ListBox_MouseHover(sender As Object, e As EventArgs) _
        Handles lbSRRSurveyors.MouseHover, lbFDRArea.MouseHover, lbFDRInstrumentA.MouseHover, lbFDRJobType.MouseHover, _
        lbSRRArea.MouseHover, lbSRRDescription.MouseHover, lbTQRArea.MouseHover, MyBase.MouseHover
        Try
            Dim listbox As ListBox = CType(sender, ListBox)

            Select Case listbox.Name
                Case "lbSRRSurveyors" : lblSettingsDescription.Text = "COMMON :" & vbCrLf & vbCrLf & "The name of the surveyors on site, and those who will be completing works. " & vbCrLf & vbCrLf & "e.g JS - John Surveyor"
                Case "lbFDRArea" : lblSettingsDescription.Text = "FIELD DATA :" & vbCrLf & vbCrLf & "The name of the area that the work has been completed. " & vbCrLf & vbCrLf & "e.g 01 PLANT"
                Case "lbFDRInstrumentA" : lblSettingsDescription.Text = "FIELD DATA :" & vbCrLf & vbCrLf & "The type of intruments used on site. " & vbCrLf & vbCrLf & "e.g Total Station"
                Case "lbFDRJobType" : lblSettingsDescription.Text = "FIELD DATA :" & vbCrLf & vbCrLf & "The type of job. " & vbCrLf & vbCrLf & "e.g. ASCON"
                Case "lbSRRArea" : lblSettingsDescription.Text = "SURVEY REPORT :" & vbCrLf & vbCrLf & "The name of the area that the work has been completed. " & vbCrLf & vbCrLf & "e.g 01 PLANT"
                Case "lbSRRDescription" : lblSettingsDescription.Text = "SURVEY REPORT :" & vbCrLf & vbCrLf & "The type of job. " & vbCrLf & vbCrLf & "e.g. ASCON"
                Case "lbTQRArea" : lblSettingsDescription.Text = "TQ / RFI :" & vbCrLf & vbCrLf & "The name of the area that the work has been completed. " & vbCrLf & vbCrLf & "e.g 01 PLANT"
            End Select

        Catch ex As Exception

        End Try
    End Sub
    'Clears the label area once the mouse is taken off the listbox
    Private Sub ListBox_MouseLeave(sender As Object, e As EventArgs) _
        Handles lbSRRSurveyors.MouseLeave, lbFDRArea.MouseLeave, lbFDRInstrumentA.MouseLeave, lbFDRJobType.MouseLeave, _
        lbSRRArea.MouseLeave, lbSRRDescription.MouseLeave, lbTQRArea.MouseLeave
        Try

            lblSettingsDescription.Text = ""

        Catch ex As Exception

        End Try
    End Sub


    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
End Class