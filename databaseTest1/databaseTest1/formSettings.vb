Public Class formSettings
    Dim EscapeChars As New EscapeChars

    'AREA -- ADD
    Private Sub cmdSRRAreaAdd_Click(sender As Object, e As EventArgs) Handles cmdSRRAreaAdd.Click
        Dim add As String
        add = EscapeChars.cleanString(InputBox("Enter Area to Add", ""))
        If add <> "" Then
            lbSRRArea.Items.Add(add.ToUpper) 'Converts all to uppercase
        End If
    End Sub

    'AREA -- REMOVE 
    Private Sub cmdSRRAreaRemove_Click(sender As Object, e As EventArgs) Handles cmdSRRAreaRemove.Click
        lbSRRArea.Items.Remove(lbSRRArea.SelectedItem)
    End Sub

    'DESCRIPTION -- ADD 
    Private Sub cmdSRRDescriptionAdd_Click(sender As Object, e As EventArgs) Handles cmdSRRDescriptionAdd.Click
        Dim add As String
        add = EscapeChars.cleanString(InputBox("Enter Description to Add", ""))
        If add <> "" Then
            lbSRRDescription.Items.Add(add.ToUpper) 'Converts all to uppercase
        End If
    End Sub

    'DESCRIPTION -- REMOVE 
    Private Sub cmdSRRDescriptionRemove_Click(sender As Object, e As EventArgs) Handles cmdSRRDescriptionRemove.Click
        lbSRRDescription.Items.Remove(lbSRRDescription.SelectedItem)
    End Sub

    'SURVEYORS -- ADD
    Private Sub cmdSRRSurveyorsAdd_Click(sender As Object, e As EventArgs) Handles cmdSRRSurveyorsAdd.Click
        Dim addInitials As String
        Dim addFullName As String
        addInitials = EscapeChars.cleanString_NoHyphen_NoSpace(InputBox("Enter Surveyors Initials :", "")) 'Hyphens not allowed, as this is character is used for a split
        addFullName = EscapeChars.cleanString_NoHyphen(InputBox("Enter Surveyors Full Name :", "")) 'Hyphens not allowed, as this is character is used for a split
        If addInitials <> "" And addFullName <> "" Then
            If addInitials.Length <= 3 Then
                lbSRRSurveyors.Items.Add(addInitials.ToUpper & "  -  " & addFullName) 'Converts all to uppercase, adds Hyphen later used to separate Initials
            Else
                MessageBox.Show("Initials have a maximum of three characters")
            End If
        End If
    End Sub

    'SURVEYORS -- REMOVE 
    Private Sub cmdSRRRSurveyorsRemove_Click(sender As Object, e As EventArgs) Handles cmdSRRRSurveyorsRemove.Click
        lbSRRSurveyors.Items.Remove(lbSRRSurveyors.SelectedItem)
    End Sub

    ' FDR AREA -- ADD
    Private Sub cmdFDRAreaAdd_Click(sender As Object, e As EventArgs) Handles cmdFDRAreaAdd.Click
        Dim add As String
        add = EscapeChars.cleanString(InputBox("Enter Area to Add", ""))
        If add <> "" Then
            lbFDRArea.Items.Add(add.ToUpper) 'Converts all to uppercase
        End If
    End Sub
    ' FDR AREA -- REMOVE
    Private Sub cmdFDRAreaRemove_Click(sender As Object, e As EventArgs) Handles cmdFDRAreaRemove.Click
        lbFDRArea.Items.Remove(lbFDRArea.SelectedItem)
    End Sub

    ' JOB TYPE -- ADD
    Private Sub cmdJobTypeAdd_Click(sender As Object, e As EventArgs) Handles cmdJobTypeAdd.Click
        Dim add As String
        add = EscapeChars.cleanString(InputBox("Enter Job Type to Add", ""))
        If add <> "" Then
            lbFDRJobType.Items.Add(add.ToUpper) 'Converts all to uppercase
        End If
    End Sub

    ' JOB TYPE -- REMOVE
    Private Sub cmdJobTypeRemove_Click(sender As Object, e As EventArgs) Handles cmdJobTypeRemove.Click
        lbFDRJobType.Items.Remove(lbFDRJobType.SelectedItem)
    End Sub

    ' INSTRUMENT A ADD
    Private Sub cmdInstrumentAAdd_Click(sender As Object, e As EventArgs) Handles cmdInstrumentAAdd.Click
        Dim add As String
        add = EscapeChars.cleanString(InputBox("Enter Instrument to Add", ""))
        If add <> "" Then
            lbFDRInstrumentA.Items.Add(add.ToUpper) 'Converts all to uppercase
        End If
    End Sub

    ' INSTRUMENT A REMOVE
    Private Sub cmdInstrumentARemove_Click(sender As Object, e As EventArgs) Handles cmdInstrumentARemove.Click
        lbFDRInstrumentA.Items.Remove(lbFDRInstrumentA.SelectedItem)
    End Sub

    ' TQR Area - ADD
    Private Sub cmdTQRAreaAdd_Click(sender As Object, e As EventArgs) Handles cmdTQRAreaAdd.Click
        Dim add As String
        add = EscapeChars.cleanString(InputBox("Enter Area to Add", ""))
        If add <> "" Then
            lbTQRArea.Items.Add(add.ToUpper) 'Converts all to uppercase
        End If
    End Sub

    ' TQR Area - REMOVE
    Private Sub cmdTQRAreaRemove_Click(sender As Object, e As EventArgs) Handles cmdTQRAreaRemove.Click
        lbTQRArea.Items.Remove(lbTQRArea.SelectedItem)
    End Sub


    'SAVE SETTINGS
    Private Sub formSettings_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        ' Settings are set under project/properties/setings
        ' browse for data type system.collections.arraylist
        ' Save ListBox with the settings from "Area", "Description", "Surveyors"
        My.Settings.settingsSRRArea = New ArrayList(lbSRRArea.Items)
        My.Settings.settingsSRRDescription = New ArrayList(lbSRRDescription.Items)
        My.Settings.settingsSRRSurveyors = New ArrayList(lbSRRSurveyors.Items)
        My.Settings.settingsProjectFolderPath = txtProjectFolderPath.Text
        My.Settings.settingsFDRArea = New ArrayList(lbFDRArea.Items)
        My.Settings.settingsFDRInstrumentA = New ArrayList(lbFDRInstrumentA.Items)
        My.Settings.settingsFDRJobType = New ArrayList(lbFDRJobType.Items)
        My.Settings.settingsTQRArea = New ArrayList(lbTQRArea.Items)
        My.Settings.Save()
    End Sub

    'LOAD SETTINGS
    Private Sub formSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Form Settings
        Me.ShowIcon = False
        Me.MinimizeBox = False
        Me.MaximizeBox = False
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedToolWindow

        ' Load ListBox with the settings from "Area", "Description", "Surveyors"
        Me.lbSRRArea.Items.AddRange(My.Settings.settingsSRRArea.ToArray())
        Me.lbSRRDescription.Items.AddRange(My.Settings.settingsSRRDescription.ToArray())
        Me.lbSRRSurveyors.Items.AddRange(My.Settings.settingsSRRSurveyors.ToArray())
        Me.txtProjectFolderPath.Text = My.Settings.settingsProjectFolderPath
        Me.lbFDRArea.Items.AddRange(My.Settings.settingsFDRArea.ToArray())
        Me.lbFDRInstrumentA.Items.AddRange(My.Settings.settingsFDRInstrumentA.ToArray())
        Me.lbFDRJobType.Items.AddRange(My.Settings.settingsFDRJobType.ToArray())
        Me.lbTQRArea.Items.AddRange(My.Settings.settingsTQRArea.ToArray())
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub cmdBrowse_Click(sender As Object, e As EventArgs) Handles cmdBrowse.Click
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
        End If
    End Sub


End Class