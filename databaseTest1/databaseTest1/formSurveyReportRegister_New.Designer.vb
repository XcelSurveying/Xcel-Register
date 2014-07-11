<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formSurveyReportRegister_New
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formSurveyReportRegister_New))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblDestFolder = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblDestination = New System.Windows.Forms.Label()
        Me.cmdNewEntryBrowse = New System.Windows.Forms.Button()
        Me.linkSource = New System.Windows.Forms.LinkLabel()
        Me.lblDocumentNameWarning = New System.Windows.Forms.Label()
        Me.lblTitleWarning = New System.Windows.Forms.Label()
        Me.cmboSurveyor = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDocumentName = New System.Windows.Forms.TextBox()
        Me.cmboArea = New System.Windows.Forms.ComboBox()
        Me.cmboDescription = New System.Windows.Forms.ComboBox()
        Me.txtRev = New System.Windows.Forms.TextBox()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.txtComments = New System.Windows.Forms.TextBox()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.cmdNewEntrySave = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ofdBrowseDocumentName = New System.Windows.Forms.OpenFileDialog()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.timerDestFolder = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdCancel)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.lblDocumentNameWarning)
        Me.GroupBox1.Controls.Add(Me.lblTitleWarning)
        Me.GroupBox1.Controls.Add(Me.cmboSurveyor)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtDocumentName)
        Me.GroupBox1.Controls.Add(Me.cmboArea)
        Me.GroupBox1.Controls.Add(Me.cmboDescription)
        Me.GroupBox1.Controls.Add(Me.txtRev)
        Me.GroupBox1.Controls.Add(Me.txtTitle)
        Me.GroupBox1.Controls.Add(Me.txtComments)
        Me.GroupBox1.Controls.Add(Me.dtpDate)
        Me.GroupBox1.Controls.Add(Me.cmdNewEntrySave)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(602, 506)
        Me.GroupBox1.TabIndex = 38
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Survey Report Register"
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(536, 470)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(60, 30)
        Me.cmdCancel.TabIndex = 54
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblDestFolder)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.lblDestination)
        Me.GroupBox2.Controls.Add(Me.cmdNewEntryBrowse)
        Me.GroupBox2.Controls.Add(Me.linkSource)
        Me.GroupBox2.Location = New System.Drawing.Point(208, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(394, 216)
        Me.GroupBox2.TabIndex = 53
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Select PDF"
        '
        'lblDestFolder
        '
        Me.lblDestFolder.Location = New System.Drawing.Point(90, 166)
        Me.lblDestFolder.Name = "lblDestFolder"
        Me.lblDestFolder.Size = New System.Drawing.Size(298, 47)
        Me.lblDestFolder.TabIndex = 52
        Me.lblDestFolder.Text = "lblDestFolder"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(30, 166)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 13)
        Me.Label9.TabIndex = 51
        Me.Label9.Text = "Folder :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 117)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 13)
        Me.Label10.TabIndex = 50
        Me.Label10.Text = "Destination :"
        '
        'lblDestination
        '
        Me.lblDestination.Location = New System.Drawing.Point(90, 117)
        Me.lblDestination.Name = "lblDestination"
        Me.lblDestination.Size = New System.Drawing.Size(298, 45)
        Me.lblDestination.TabIndex = 49
        Me.lblDestination.Text = "lblDestination"
        Me.lblDestination.Visible = False
        '
        'cmdNewEntryBrowse
        '
        Me.cmdNewEntryBrowse.Location = New System.Drawing.Point(9, 41)
        Me.cmdNewEntryBrowse.Name = "cmdNewEntryBrowse"
        Me.cmdNewEntryBrowse.Size = New System.Drawing.Size(65, 20)
        Me.cmdNewEntryBrowse.TabIndex = 8
        Me.cmdNewEntryBrowse.Text = "Browse"
        Me.cmdNewEntryBrowse.UseVisualStyleBackColor = True
        '
        'linkSource
        '
        Me.linkSource.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkSource.LinkColor = System.Drawing.Color.Black
        Me.linkSource.Location = New System.Drawing.Point(90, 45)
        Me.linkSource.Name = "linkSource"
        Me.linkSource.Size = New System.Drawing.Size(298, 67)
        Me.linkSource.TabIndex = 42
        Me.linkSource.TabStop = True
        Me.linkSource.Text = "Browse to create link to PDF"
        '
        'lblDocumentNameWarning
        '
        Me.lblDocumentNameWarning.AutoSize = True
        Me.lblDocumentNameWarning.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDocumentNameWarning.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblDocumentNameWarning.Location = New System.Drawing.Point(9, 77)
        Me.lblDocumentNameWarning.Name = "lblDocumentNameWarning"
        Me.lblDocumentNameWarning.Size = New System.Drawing.Size(132, 13)
        Me.lblDocumentNameWarning.TabIndex = 48
        Me.lblDocumentNameWarning.Text = "lblDocumentNameWarning"
        Me.lblDocumentNameWarning.Visible = False
        '
        'lblTitleWarning
        '
        Me.lblTitleWarning.AutoSize = True
        Me.lblTitleWarning.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleWarning.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblTitleWarning.Location = New System.Drawing.Point(9, 276)
        Me.lblTitleWarning.Name = "lblTitleWarning"
        Me.lblTitleWarning.Size = New System.Drawing.Size(166, 13)
        Me.lblTitleWarning.TabIndex = 47
        Me.lblTitleWarning.Text = "Please enter a title for the report"
        Me.lblTitleWarning.Visible = False
        '
        'cmboSurveyor
        '
        Me.cmboSurveyor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmboSurveyor.FormattingEnabled = True
        Me.cmboSurveyor.Location = New System.Drawing.Point(9, 195)
        Me.cmboSurveyor.Name = "cmboSurveyor"
        Me.cmboSurveyor.Size = New System.Drawing.Size(193, 21)
        Me.cmboSurveyor.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label4.Location = New System.Drawing.Point(6, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 13)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "Document Name"
        '
        'txtDocumentName
        '
        Me.txtDocumentName.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold)
        Me.txtDocumentName.Location = New System.Drawing.Point(9, 41)
        Me.txtDocumentName.MaxLength = 10
        Me.txtDocumentName.Name = "txtDocumentName"
        Me.txtDocumentName.Size = New System.Drawing.Size(193, 33)
        Me.txtDocumentName.TabIndex = 0
        '
        'cmboArea
        '
        Me.cmboArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmboArea.FormattingEnabled = True
        Me.cmboArea.Location = New System.Drawing.Point(9, 324)
        Me.cmboArea.Name = "cmboArea"
        Me.cmboArea.Size = New System.Drawing.Size(176, 21)
        Me.cmboArea.TabIndex = 5
        '
        'cmboDescription
        '
        Me.cmboDescription.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmboDescription.FormattingEnabled = True
        Me.cmboDescription.Location = New System.Drawing.Point(217, 324)
        Me.cmboDescription.Name = "cmboDescription"
        Me.cmboDescription.Size = New System.Drawing.Size(379, 21)
        Me.cmboDescription.TabIndex = 6
        '
        'txtRev
        '
        Me.txtRev.Location = New System.Drawing.Point(156, 133)
        Me.txtRev.MaxLength = 2
        Me.txtRev.Name = "txtRev"
        Me.txtRev.Size = New System.Drawing.Size(46, 21)
        Me.txtRev.TabIndex = 2
        Me.txtRev.Text = "1"
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(9, 253)
        Me.txtTitle.MaxLength = 100
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(587, 21)
        Me.txtTitle.TabIndex = 4
        '
        'txtComments
        '
        Me.txtComments.Location = New System.Drawing.Point(9, 381)
        Me.txtComments.MaxLength = 255
        Me.txtComments.Multiline = True
        Me.txtComments.Name = "txtComments"
        Me.txtComments.Size = New System.Drawing.Size(587, 58)
        Me.txtComments.TabIndex = 7
        '
        'dtpDate
        '
        Me.dtpDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDate.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.dtpDate.Location = New System.Drawing.Point(9, 133)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(100, 21)
        Me.dtpDate.TabIndex = 1
        Me.dtpDate.Value = New Date(2014, 5, 15, 0, 0, 0, 0)
        '
        'cmdNewEntrySave
        '
        Me.cmdNewEntrySave.Image = CType(resources.GetObject("cmdNewEntrySave.Image"), System.Drawing.Image)
        Me.cmdNewEntrySave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdNewEntrySave.Location = New System.Drawing.Point(470, 470)
        Me.cmdNewEntrySave.Name = "cmdNewEntrySave"
        Me.cmdNewEntrySave.Size = New System.Drawing.Size(60, 30)
        Me.cmdNewEntrySave.TabIndex = 9
        Me.cmdNewEntrySave.Text = "Save"
        Me.cmdNewEntrySave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdNewEntrySave.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label8.Location = New System.Drawing.Point(6, 360)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 13)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Comments"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(214, 308)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 13)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Description"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(153, 117)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 13)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Rev"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label5.Location = New System.Drawing.Point(6, 308)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 13)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Area"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label3.Location = New System.Drawing.Point(6, 179)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Surveyor"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(6, 237)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Title"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Date"
        '
        'ofdBrowseDocumentName
        '
        Me.ofdBrowseDocumentName.FileName = "OpenFileDialog1"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'timerDestFolder
        '
        '
        'formSurveyReportRegister_New
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(626, 530)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formSurveyReportRegister_New"
        Me.Text = "New Entry to Survey Report Register"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdNewEntrySave As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTitle As System.Windows.Forms.TextBox
    Friend WithEvents txtComments As System.Windows.Forms.TextBox
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmboArea As System.Windows.Forms.ComboBox
    Friend WithEvents cmboDescription As System.Windows.Forms.ComboBox
    Friend WithEvents txtRev As System.Windows.Forms.TextBox
    Friend WithEvents ofdBrowseDocumentName As System.Windows.Forms.OpenFileDialog
    Friend WithEvents cmdNewEntryBrowse As System.Windows.Forms.Button
    Friend WithEvents linkSource As System.Windows.Forms.LinkLabel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDocumentName As System.Windows.Forms.TextBox
    Friend WithEvents cmboSurveyor As System.Windows.Forms.ComboBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents lblTitleWarning As System.Windows.Forms.Label
    Friend WithEvents lblDocumentNameWarning As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblDestination As System.Windows.Forms.Label
    Friend WithEvents lblDestFolder As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents timerDestFolder As System.Windows.Forms.Timer
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
End Class
