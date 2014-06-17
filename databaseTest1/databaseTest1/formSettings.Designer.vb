<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formSettings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdSRRRSurveyorsRemove = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmdSRRSurveyorsAdd = New System.Windows.Forms.Button()
        Me.lbSRRSurveyors = New System.Windows.Forms.ListBox()
        Me.cmdSRRDescriptionAdd = New System.Windows.Forms.Button()
        Me.cmdSRRDescriptionRemove = New System.Windows.Forms.Button()
        Me.cmdSRRAreaAdd = New System.Windows.Forms.Button()
        Me.cmdSRRAreaRemove = New System.Windows.Forms.Button()
        Me.lbSRRDescription = New System.Windows.Forms.ListBox()
        Me.lbSRRArea = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtProjectFolderPath = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmdBrowse = New System.Windows.Forms.Button()
        Me.projectFolderBrowser = New System.Windows.Forms.FolderBrowserDialog()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmdInstrumentAAdd = New System.Windows.Forms.Button()
        Me.cmdInstrumentARemove = New System.Windows.Forms.Button()
        Me.lbFDRInstrumentA = New System.Windows.Forms.ListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmdJobTypeAdd = New System.Windows.Forms.Button()
        Me.cmdJobTypeRemove = New System.Windows.Forms.Button()
        Me.lbFDRJobType = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmdFDRAreaAdd = New System.Windows.Forms.Button()
        Me.cmdFDRAreaRemove = New System.Windows.Forms.Button()
        Me.lbFDRArea = New System.Windows.Forms.ListBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdSRRDescriptionAdd)
        Me.GroupBox1.Controls.Add(Me.cmdSRRDescriptionRemove)
        Me.GroupBox1.Controls.Add(Me.cmdSRRAreaAdd)
        Me.GroupBox1.Controls.Add(Me.cmdSRRAreaRemove)
        Me.GroupBox1.Controls.Add(Me.lbSRRDescription)
        Me.GroupBox1.Controls.Add(Me.lbSRRArea)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 20)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(257, 444)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Survey Report Register"
        '
        'cmdSRRRSurveyorsRemove
        '
        Me.cmdSRRRSurveyorsRemove.Location = New System.Drawing.Point(615, 286)
        Me.cmdSRRRSurveyorsRemove.Name = "cmdSRRRSurveyorsRemove"
        Me.cmdSRRRSurveyorsRemove.Size = New System.Drawing.Size(60, 21)
        Me.cmdSRRRSurveyorsRemove.TabIndex = 11
        Me.cmdSRRRSurveyorsRemove.Text = "Remove"
        Me.cmdSRRRSurveyorsRemove.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(558, 195)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Surveyors"
        '
        'cmdSRRSurveyorsAdd
        '
        Me.cmdSRRSurveyorsAdd.Location = New System.Drawing.Point(681, 286)
        Me.cmdSRRSurveyorsAdd.Name = "cmdSRRSurveyorsAdd"
        Me.cmdSRRSurveyorsAdd.Size = New System.Drawing.Size(61, 21)
        Me.cmdSRRSurveyorsAdd.TabIndex = 10
        Me.cmdSRRSurveyorsAdd.Text = "Add"
        Me.cmdSRRSurveyorsAdd.UseVisualStyleBackColor = True
        '
        'lbSRRSurveyors
        '
        Me.lbSRRSurveyors.FormattingEnabled = True
        Me.lbSRRSurveyors.Location = New System.Drawing.Point(574, 211)
        Me.lbSRRSurveyors.Name = "lbSRRSurveyors"
        Me.lbSRRSurveyors.Size = New System.Drawing.Size(168, 69)
        Me.lbSRRSurveyors.TabIndex = 8
        '
        'cmdSRRDescriptionAdd
        '
        Me.cmdSRRDescriptionAdd.Location = New System.Drawing.Point(129, 266)
        Me.cmdSRRDescriptionAdd.Name = "cmdSRRDescriptionAdd"
        Me.cmdSRRDescriptionAdd.Size = New System.Drawing.Size(61, 21)
        Me.cmdSRRDescriptionAdd.TabIndex = 7
        Me.cmdSRRDescriptionAdd.Text = "Add"
        Me.cmdSRRDescriptionAdd.UseVisualStyleBackColor = True
        '
        'cmdSRRDescriptionRemove
        '
        Me.cmdSRRDescriptionRemove.Location = New System.Drawing.Point(63, 266)
        Me.cmdSRRDescriptionRemove.Name = "cmdSRRDescriptionRemove"
        Me.cmdSRRDescriptionRemove.Size = New System.Drawing.Size(60, 21)
        Me.cmdSRRDescriptionRemove.TabIndex = 6
        Me.cmdSRRDescriptionRemove.Text = "Remove"
        Me.cmdSRRDescriptionRemove.UseVisualStyleBackColor = True
        '
        'cmdSRRAreaAdd
        '
        Me.cmdSRRAreaAdd.Location = New System.Drawing.Point(129, 123)
        Me.cmdSRRAreaAdd.Name = "cmdSRRAreaAdd"
        Me.cmdSRRAreaAdd.Size = New System.Drawing.Size(61, 21)
        Me.cmdSRRAreaAdd.TabIndex = 5
        Me.cmdSRRAreaAdd.Text = "Add"
        Me.cmdSRRAreaAdd.UseVisualStyleBackColor = True
        '
        'cmdSRRAreaRemove
        '
        Me.cmdSRRAreaRemove.Location = New System.Drawing.Point(63, 123)
        Me.cmdSRRAreaRemove.Name = "cmdSRRAreaRemove"
        Me.cmdSRRAreaRemove.Size = New System.Drawing.Size(60, 21)
        Me.cmdSRRAreaRemove.TabIndex = 4
        Me.cmdSRRAreaRemove.Text = "Remove"
        Me.cmdSRRAreaRemove.UseVisualStyleBackColor = True
        '
        'lbSRRDescription
        '
        Me.lbSRRDescription.FormattingEnabled = True
        Me.lbSRRDescription.Location = New System.Drawing.Point(22, 191)
        Me.lbSRRDescription.Name = "lbSRRDescription"
        Me.lbSRRDescription.Size = New System.Drawing.Size(168, 69)
        Me.lbSRRDescription.TabIndex = 3
        '
        'lbSRRArea
        '
        Me.lbSRRArea.FormattingEnabled = True
        Me.lbSRRArea.Location = New System.Drawing.Point(22, 48)
        Me.lbSRRArea.Name = "lbSRRArea"
        Me.lbSRRArea.Size = New System.Drawing.Size(168, 69)
        Me.lbSRRArea.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 175)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Description"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Area"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(335, 481)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(179, 31)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtProjectFolderPath)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.cmdBrowse)
        Me.GroupBox2.Location = New System.Drawing.Point(552, 20)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(345, 133)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Location of the Project Folder"
        '
        'txtProjectFolderPath
        '
        Me.txtProjectFolderPath.BackColor = System.Drawing.SystemColors.Control
        Me.txtProjectFolderPath.Enabled = False
        Me.txtProjectFolderPath.Location = New System.Drawing.Point(90, 32)
        Me.txtProjectFolderPath.Multiline = True
        Me.txtProjectFolderPath.Name = "txtProjectFolderPath"
        Me.txtProjectFolderPath.Size = New System.Drawing.Size(238, 68)
        Me.txtProjectFolderPath.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Project Folder :"
        '
        'cmdBrowse
        '
        Me.cmdBrowse.Location = New System.Drawing.Point(267, 106)
        Me.cmdBrowse.Name = "cmdBrowse"
        Me.cmdBrowse.Size = New System.Drawing.Size(61, 21)
        Me.cmdBrowse.TabIndex = 0
        Me.cmdBrowse.Text = "Browse"
        Me.cmdBrowse.UseVisualStyleBackColor = True
        '
        'projectFolderBrowser
        '
        Me.projectFolderBrowser.RootFolder = System.Environment.SpecialFolder.MyComputer
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmdFDRAreaAdd)
        Me.GroupBox3.Controls.Add(Me.cmdFDRAreaRemove)
        Me.GroupBox3.Controls.Add(Me.lbFDRArea)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.cmdInstrumentAAdd)
        Me.GroupBox3.Controls.Add(Me.cmdInstrumentARemove)
        Me.GroupBox3.Controls.Add(Me.lbFDRInstrumentA)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.cmdJobTypeAdd)
        Me.GroupBox3.Controls.Add(Me.cmdJobTypeRemove)
        Me.GroupBox3.Controls.Add(Me.lbFDRJobType)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Location = New System.Drawing.Point(287, 20)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(259, 444)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Field Data Register"
        '
        'cmdInstrumentAAdd
        '
        Me.cmdInstrumentAAdd.Location = New System.Drawing.Point(129, 406)
        Me.cmdInstrumentAAdd.Name = "cmdInstrumentAAdd"
        Me.cmdInstrumentAAdd.Size = New System.Drawing.Size(61, 21)
        Me.cmdInstrumentAAdd.TabIndex = 15
        Me.cmdInstrumentAAdd.Text = "Add"
        Me.cmdInstrumentAAdd.UseVisualStyleBackColor = True
        '
        'cmdInstrumentARemove
        '
        Me.cmdInstrumentARemove.Location = New System.Drawing.Point(63, 406)
        Me.cmdInstrumentARemove.Name = "cmdInstrumentARemove"
        Me.cmdInstrumentARemove.Size = New System.Drawing.Size(60, 21)
        Me.cmdInstrumentARemove.TabIndex = 14
        Me.cmdInstrumentARemove.Text = "Remove"
        Me.cmdInstrumentARemove.UseVisualStyleBackColor = True
        '
        'lbFDRInstrumentA
        '
        Me.lbFDRInstrumentA.FormattingEnabled = True
        Me.lbFDRInstrumentA.Location = New System.Drawing.Point(22, 331)
        Me.lbFDRInstrumentA.Name = "lbFDRInstrumentA"
        Me.lbFDRInstrumentA.Size = New System.Drawing.Size(168, 69)
        Me.lbFDRInstrumentA.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 315)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Instrument A"
        '
        'cmdJobTypeAdd
        '
        Me.cmdJobTypeAdd.Location = New System.Drawing.Point(129, 266)
        Me.cmdJobTypeAdd.Name = "cmdJobTypeAdd"
        Me.cmdJobTypeAdd.Size = New System.Drawing.Size(61, 21)
        Me.cmdJobTypeAdd.TabIndex = 11
        Me.cmdJobTypeAdd.Text = "Add"
        Me.cmdJobTypeAdd.UseVisualStyleBackColor = True
        '
        'cmdJobTypeRemove
        '
        Me.cmdJobTypeRemove.Location = New System.Drawing.Point(63, 266)
        Me.cmdJobTypeRemove.Name = "cmdJobTypeRemove"
        Me.cmdJobTypeRemove.Size = New System.Drawing.Size(60, 21)
        Me.cmdJobTypeRemove.TabIndex = 10
        Me.cmdJobTypeRemove.Text = "Remove"
        Me.cmdJobTypeRemove.UseVisualStyleBackColor = True
        '
        'lbFDRJobType
        '
        Me.lbFDRJobType.FormattingEnabled = True
        Me.lbFDRJobType.Location = New System.Drawing.Point(22, 191)
        Me.lbFDRJobType.Name = "lbFDRJobType"
        Me.lbFDRJobType.Size = New System.Drawing.Size(168, 69)
        Me.lbFDRJobType.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 175)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Job Type"
        '
        'cmdFDRAreaAdd
        '
        Me.cmdFDRAreaAdd.Location = New System.Drawing.Point(129, 123)
        Me.cmdFDRAreaAdd.Name = "cmdFDRAreaAdd"
        Me.cmdFDRAreaAdd.Size = New System.Drawing.Size(61, 21)
        Me.cmdFDRAreaAdd.TabIndex = 19
        Me.cmdFDRAreaAdd.Text = "Add"
        Me.cmdFDRAreaAdd.UseVisualStyleBackColor = True
        '
        'cmdFDRAreaRemove
        '
        Me.cmdFDRAreaRemove.Location = New System.Drawing.Point(63, 123)
        Me.cmdFDRAreaRemove.Name = "cmdFDRAreaRemove"
        Me.cmdFDRAreaRemove.Size = New System.Drawing.Size(60, 21)
        Me.cmdFDRAreaRemove.TabIndex = 18
        Me.cmdFDRAreaRemove.Text = "Remove"
        Me.cmdFDRAreaRemove.UseVisualStyleBackColor = True
        '
        'lbFDRArea
        '
        Me.lbFDRArea.FormattingEnabled = True
        Me.lbFDRArea.Location = New System.Drawing.Point(22, 48)
        Me.lbFDRArea.Name = "lbFDRArea"
        Me.lbFDRArea.Size = New System.Drawing.Size(168, 69)
        Me.lbFDRArea.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Area"
        '
        'formSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1090, 524)
        Me.Controls.Add(Me.cmdSRRRSurveyorsRemove)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmdSRRSurveyorsAdd)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lbSRRSurveyors)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Name = "formSettings"
        Me.Text = "Settings"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbSRRDescription As System.Windows.Forms.ListBox
    Friend WithEvents lbSRRArea As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdSRRDescriptionAdd As System.Windows.Forms.Button
    Friend WithEvents cmdSRRDescriptionRemove As System.Windows.Forms.Button
    Friend WithEvents cmdSRRAreaAdd As System.Windows.Forms.Button
    Friend WithEvents cmdSRRAreaRemove As System.Windows.Forms.Button
    Friend WithEvents lbSRRSurveyors As System.Windows.Forms.ListBox
    Friend WithEvents cmdSRRRSurveyorsRemove As System.Windows.Forms.Button
    Friend WithEvents cmdSRRSurveyorsAdd As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtProjectFolderPath As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmdBrowse As System.Windows.Forms.Button
    Friend WithEvents projectFolderBrowser As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdInstrumentAAdd As System.Windows.Forms.Button
    Friend WithEvents cmdInstrumentARemove As System.Windows.Forms.Button
    Friend WithEvents lbFDRInstrumentA As System.Windows.Forms.ListBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmdJobTypeAdd As System.Windows.Forms.Button
    Friend WithEvents cmdJobTypeRemove As System.Windows.Forms.Button
    Friend WithEvents lbFDRJobType As System.Windows.Forms.ListBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmdFDRAreaAdd As System.Windows.Forms.Button
    Friend WithEvents cmdFDRAreaRemove As System.Windows.Forms.Button
    Friend WithEvents lbFDRArea As System.Windows.Forms.ListBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
