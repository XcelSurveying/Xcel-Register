<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formFieldDataRegister_Modify
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formFieldDataRegister_Modify))
        Me.txtJobRefNum = New System.Windows.Forms.TextBox()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.cmboSurveyor = New System.Windows.Forms.ComboBox()
        Me.cmboArea = New System.Windows.Forms.ComboBox()
        Me.cmboJobType = New System.Windows.Forms.ComboBox()
        Me.txtJobDescription = New System.Windows.Forms.TextBox()
        Me.txtFieldBook = New System.Windows.Forms.TextBox()
        Me.txtFieldPage = New System.Windows.Forms.TextBox()
        Me.cmboInstrumentA = New System.Windows.Forms.ComboBox()
        Me.txtComments = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblFieldBookWarning = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblDescriptionWarning = New System.Windows.Forms.Label()
        Me.lblDocumentNameWarning = New System.Windows.Forms.Label()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtJobRefNum
        '
        Me.txtJobRefNum.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold)
        Me.txtJobRefNum.Location = New System.Drawing.Point(19, 52)
        Me.txtJobRefNum.MaxLength = 10
        Me.txtJobRefNum.Name = "txtJobRefNum"
        Me.txtJobRefNum.Size = New System.Drawing.Size(212, 33)
        Me.txtJobRefNum.TabIndex = 1
        '
        'dtpDate
        '
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDate.Location = New System.Drawing.Point(286, 156)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(100, 21)
        Me.dtpDate.TabIndex = 5
        '
        'cmboSurveyor
        '
        Me.cmboSurveyor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmboSurveyor.FormattingEnabled = True
        Me.cmboSurveyor.Location = New System.Drawing.Point(17, 231)
        Me.cmboSurveyor.Name = "cmboSurveyor"
        Me.cmboSurveyor.Size = New System.Drawing.Size(212, 21)
        Me.cmboSurveyor.TabIndex = 6
        '
        'cmboArea
        '
        Me.cmboArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmboArea.FormattingEnabled = True
        Me.cmboArea.Location = New System.Drawing.Point(19, 297)
        Me.cmboArea.Name = "cmboArea"
        Me.cmboArea.Size = New System.Drawing.Size(210, 21)
        Me.cmboArea.TabIndex = 8
        '
        'cmboJobType
        '
        Me.cmboJobType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmboJobType.FormattingEnabled = True
        Me.cmboJobType.Location = New System.Drawing.Point(286, 297)
        Me.cmboJobType.Name = "cmboJobType"
        Me.cmboJobType.Size = New System.Drawing.Size(212, 21)
        Me.cmboJobType.TabIndex = 9
        '
        'txtJobDescription
        '
        Me.txtJobDescription.Location = New System.Drawing.Point(286, 52)
        Me.txtJobDescription.MaxLength = 150
        Me.txtJobDescription.Multiline = True
        Me.txtJobDescription.Name = "txtJobDescription"
        Me.txtJobDescription.Size = New System.Drawing.Size(212, 57)
        Me.txtJobDescription.TabIndex = 2
        '
        'txtFieldBook
        '
        Me.txtFieldBook.Location = New System.Drawing.Point(17, 156)
        Me.txtFieldBook.MaxLength = 2
        Me.txtFieldBook.Name = "txtFieldBook"
        Me.txtFieldBook.Size = New System.Drawing.Size(40, 21)
        Me.txtFieldBook.TabIndex = 3
        '
        'txtFieldPage
        '
        Me.txtFieldPage.Location = New System.Drawing.Point(80, 156)
        Me.txtFieldPage.MaxLength = 7
        Me.txtFieldPage.Name = "txtFieldPage"
        Me.txtFieldPage.Size = New System.Drawing.Size(48, 21)
        Me.txtFieldPage.TabIndex = 4
        '
        'cmboInstrumentA
        '
        Me.cmboInstrumentA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmboInstrumentA.FormattingEnabled = True
        Me.cmboInstrumentA.Location = New System.Drawing.Point(286, 231)
        Me.cmboInstrumentA.Name = "cmboInstrumentA"
        Me.cmboInstrumentA.Size = New System.Drawing.Size(212, 21)
        Me.cmboInstrumentA.TabIndex = 7
        '
        'txtComments
        '
        Me.txtComments.Location = New System.Drawing.Point(19, 367)
        Me.txtComments.MaxLength = 255
        Me.txtComments.Multiline = True
        Me.txtComments.Name = "txtComments"
        Me.txtComments.Size = New System.Drawing.Size(479, 52)
        Me.txtComments.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Job Ref Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(283, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Date of Survey"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 215)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Surveyor"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 281)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Area"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(283, 281)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Job Type"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(283, 36)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Job Description"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(22, 140)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Book"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(87, 140)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Page"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(283, 215)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Instrument A"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(16, 351)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Comments"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdCancel)
        Me.GroupBox1.Controls.Add(Me.lblFieldBookWarning)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.lblDescriptionWarning)
        Me.GroupBox1.Controls.Add(Me.lblDocumentNameWarning)
        Me.GroupBox1.Controls.Add(Me.cmdSave)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtJobDescription)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtFieldBook)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmboJobType)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.cmboArea)
        Me.GroupBox1.Controls.Add(Me.txtFieldPage)
        Me.GroupBox1.Controls.Add(Me.cmboSurveyor)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.dtpDate)
        Me.GroupBox1.Controls.Add(Me.cmboInstrumentA)
        Me.GroupBox1.Controls.Add(Me.txtJobRefNum)
        Me.GroupBox1.Controls.Add(Me.txtComments)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(520, 477)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Enter Details"
        '
        'lblFieldBookWarning
        '
        Me.lblFieldBookWarning.AutoSize = True
        Me.lblFieldBookWarning.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblFieldBookWarning.Location = New System.Drawing.Point(22, 180)
        Me.lblFieldBookWarning.Name = "lblFieldBookWarning"
        Me.lblFieldBookWarning.Size = New System.Drawing.Size(102, 13)
        Me.lblFieldBookWarning.TabIndex = 25
        Me.lblFieldBookWarning.Text = "lblFieldBookWarning"
        Me.lblFieldBookWarning.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(63, 159)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(11, 13)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "/"
        '
        'lblDescriptionWarning
        '
        Me.lblDescriptionWarning.AutoSize = True
        Me.lblDescriptionWarning.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblDescriptionWarning.Location = New System.Drawing.Point(283, 112)
        Me.lblDescriptionWarning.Name = "lblDescriptionWarning"
        Me.lblDescriptionWarning.Size = New System.Drawing.Size(110, 13)
        Me.lblDescriptionWarning.TabIndex = 23
        Me.lblDescriptionWarning.Text = "lblDescriptionWarning"
        Me.lblDescriptionWarning.Visible = False
        '
        'lblDocumentNameWarning
        '
        Me.lblDocumentNameWarning.AutoSize = True
        Me.lblDocumentNameWarning.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblDocumentNameWarning.Location = New System.Drawing.Point(23, 88)
        Me.lblDocumentNameWarning.Name = "lblDocumentNameWarning"
        Me.lblDocumentNameWarning.Size = New System.Drawing.Size(132, 13)
        Me.lblDocumentNameWarning.TabIndex = 22
        Me.lblDocumentNameWarning.Text = "lblDocumentNameWarning"
        Me.lblDocumentNameWarning.Visible = False
        '
        'cmdSave
        '
        Me.cmdSave.Image = CType(resources.GetObject("cmdSave.Image"), System.Drawing.Image)
        Me.cmdSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSave.Location = New System.Drawing.Point(372, 441)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(60, 30)
        Me.cmdSave.TabIndex = 11
        Me.cmdSave.Text = "Save"
        Me.cmdSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdSave.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(41, 124)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(55, 13)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Field Book"
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
        'Timer3
        '
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(438, 441)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(60, 30)
        Me.cmdCancel.TabIndex = 12
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'formFieldDataRegister_Modify
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(544, 502)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Name = "formFieldDataRegister_Modify"
        Me.Text = "Modify Entry to Field Data Register"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtJobRefNum As System.Windows.Forms.TextBox
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmboSurveyor As System.Windows.Forms.ComboBox
    Friend WithEvents cmboArea As System.Windows.Forms.ComboBox
    Friend WithEvents cmboJobType As System.Windows.Forms.ComboBox
    Friend WithEvents txtJobDescription As System.Windows.Forms.TextBox
    Friend WithEvents txtFieldBook As System.Windows.Forms.TextBox
    Friend WithEvents txtFieldPage As System.Windows.Forms.TextBox
    Friend WithEvents cmboInstrumentA As System.Windows.Forms.ComboBox
    Friend WithEvents txtComments As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblDocumentNameWarning As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents lblDescriptionWarning As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblFieldBookWarning As System.Windows.Forms.Label
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
End Class
