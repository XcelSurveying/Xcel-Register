<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formMain))
        Me.cmdModifySelectedRow = New System.Windows.Forms.Button()
        Me.DGVData = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.cmdNewEntry = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatabaseSetupWizardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportTablesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MoveDatabaseFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbTqRfiRegister = New System.Windows.Forms.RadioButton()
        Me.rbSurveyReportRegister = New System.Windows.Forms.RadioButton()
        Me.rbFieldDataRegister = New System.Windows.Forms.RadioButton()
        Me.rbAreaCalcChecklist = New System.Windows.Forms.RadioButton()
        Me.lblRegisterSelected = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DGVData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdModifySelectedRow
        '
        Me.cmdModifySelectedRow.Location = New System.Drawing.Point(341, 81)
        Me.cmdModifySelectedRow.Name = "cmdModifySelectedRow"
        Me.cmdModifySelectedRow.Size = New System.Drawing.Size(135, 30)
        Me.cmdModifySelectedRow.TabIndex = 11
        Me.cmdModifySelectedRow.Text = "Modify Selected Row"
        Me.cmdModifySelectedRow.UseVisualStyleBackColor = True
        '
        'DGVData
        '
        Me.DGVData.AllowUserToOrderColumns = True
        Me.DGVData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DGVData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2
        Me.DGVData.Location = New System.Drawing.Point(12, 186)
        Me.DGVData.Name = "DGVData"
        Me.DGVData.Size = New System.Drawing.Size(1276, 435)
        Me.DGVData.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtSearch)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 117)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(323, 57)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Search Box"
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(6, 20)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(311, 31)
        Me.txtSearch.TabIndex = 4
        '
        'cmdNewEntry
        '
        Me.cmdNewEntry.Image = CType(resources.GetObject("cmdNewEntry.Image"), System.Drawing.Image)
        Me.cmdNewEntry.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdNewEntry.Location = New System.Drawing.Point(341, 36)
        Me.cmdNewEntry.Name = "cmdNewEntry"
        Me.cmdNewEntry.Size = New System.Drawing.Size(93, 30)
        Me.cmdNewEntry.TabIndex = 12
        Me.cmdNewEntry.Text = "New Entry"
        Me.cmdNewEntry.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdNewEntry.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.DatabaseToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1300, 24)
        Me.MenuStrip1.TabIndex = 13
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingsToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.SettingsToolStripMenuItem.Text = "&Settings"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'DatabaseToolStripMenuItem
        '
        Me.DatabaseToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DatabaseSetupWizardToolStripMenuItem, Me.ExportTablesToolStripMenuItem, Me.MoveDatabaseFileToolStripMenuItem})
        Me.DatabaseToolStripMenuItem.Name = "DatabaseToolStripMenuItem"
        Me.DatabaseToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.DatabaseToolStripMenuItem.Text = "&Database"
        '
        'DatabaseSetupWizardToolStripMenuItem
        '
        Me.DatabaseSetupWizardToolStripMenuItem.Name = "DatabaseSetupWizardToolStripMenuItem"
        Me.DatabaseSetupWizardToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.DatabaseSetupWizardToolStripMenuItem.Text = "&Database Setup Wizard"
        '
        'ExportTablesToolStripMenuItem
        '
        Me.ExportTablesToolStripMenuItem.Name = "ExportTablesToolStripMenuItem"
        Me.ExportTablesToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.ExportTablesToolStripMenuItem.Text = "E&xport Tables to .CSV"
        '
        'MoveDatabaseFileToolStripMenuItem
        '
        Me.MoveDatabaseFileToolStripMenuItem.Name = "MoveDatabaseFileToolStripMenuItem"
        Me.MoveDatabaseFileToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.MoveDatabaseFileToolStripMenuItem.Text = "Restore Tables from .CSV"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbTqRfiRegister)
        Me.GroupBox1.Controls.Add(Me.rbSurveyReportRegister)
        Me.GroupBox1.Controls.Add(Me.rbFieldDataRegister)
        Me.GroupBox1.Controls.Add(Me.rbAreaCalcChecklist)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(323, 81)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Registers"
        '
        'rbTqRfiRegister
        '
        Me.rbTqRfiRegister.AutoSize = True
        Me.rbTqRfiRegister.Location = New System.Drawing.Point(170, 49)
        Me.rbTqRfiRegister.Name = "rbTqRfiRegister"
        Me.rbTqRfiRegister.Size = New System.Drawing.Size(111, 17)
        Me.rbTqRfiRegister.TabIndex = 3
        Me.rbTqRfiRegister.Text = "TQ && RFI Register"
        Me.rbTqRfiRegister.UseVisualStyleBackColor = True
        '
        'rbSurveyReportRegister
        '
        Me.rbSurveyReportRegister.AutoSize = True
        Me.rbSurveyReportRegister.Location = New System.Drawing.Point(170, 26)
        Me.rbSurveyReportRegister.Name = "rbSurveyReportRegister"
        Me.rbSurveyReportRegister.Size = New System.Drawing.Size(135, 17)
        Me.rbSurveyReportRegister.TabIndex = 2
        Me.rbSurveyReportRegister.Text = "Survey Report Register"
        Me.rbSurveyReportRegister.UseVisualStyleBackColor = True
        '
        'rbFieldDataRegister
        '
        Me.rbFieldDataRegister.AutoSize = True
        Me.rbFieldDataRegister.Location = New System.Drawing.Point(23, 49)
        Me.rbFieldDataRegister.Name = "rbFieldDataRegister"
        Me.rbFieldDataRegister.Size = New System.Drawing.Size(115, 17)
        Me.rbFieldDataRegister.TabIndex = 1
        Me.rbFieldDataRegister.Text = "Field Data Register"
        Me.rbFieldDataRegister.UseVisualStyleBackColor = True
        '
        'rbAreaCalcChecklist
        '
        Me.rbAreaCalcChecklist.AutoSize = True
        Me.rbAreaCalcChecklist.Checked = True
        Me.rbAreaCalcChecklist.Location = New System.Drawing.Point(23, 26)
        Me.rbAreaCalcChecklist.Name = "rbAreaCalcChecklist"
        Me.rbAreaCalcChecklist.Size = New System.Drawing.Size(117, 17)
        Me.rbAreaCalcChecklist.TabIndex = 0
        Me.rbAreaCalcChecklist.TabStop = True
        Me.rbAreaCalcChecklist.Text = "Area Calc Checklist"
        Me.rbAreaCalcChecklist.UseVisualStyleBackColor = True
        '
        'lblRegisterSelected
        '
        Me.lblRegisterSelected.AutoSize = True
        Me.lblRegisterSelected.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegisterSelected.Location = New System.Drawing.Point(577, 135)
        Me.lblRegisterSelected.Name = "lblRegisterSelected"
        Me.lblRegisterSelected.Size = New System.Drawing.Size(290, 33)
        Me.lblRegisterSelected.TabIndex = 15
        Me.lblRegisterSelected.Text = "Area Calc Checklist"
        Me.lblRegisterSelected.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = Global.databaseTest1.My.Resources.Resources.Xcel_Surveying_Cropped
        Me.PictureBox1.InitialImage = Global.databaseTest1.My.Resources.Resources.Xcel_Surveying_Cropped
        Me.PictureBox1.Location = New System.Drawing.Point(1109, 36)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(179, 98)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'formMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1300, 633)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblRegisterSelected)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdNewEntry)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.cmdModifySelectedRow)
        Me.Controls.Add(Me.DGVData)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "formMain"
        Me.Text = "Xcel Database Register"
        CType(Me.DGVData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGVData As System.Windows.Forms.DataGridView
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdModifySelectedRow As System.Windows.Forms.Button
    Friend WithEvents cmdNewEntry As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DatabaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DatabaseSetupWizardToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MoveDatabaseFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportTablesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbTqRfiRegister As System.Windows.Forms.RadioButton
    Friend WithEvents rbSurveyReportRegister As System.Windows.Forms.RadioButton
    Friend WithEvents rbFieldDataRegister As System.Windows.Forms.RadioButton
    Friend WithEvents rbAreaCalcChecklist As System.Windows.Forms.RadioButton
    Friend WithEvents lblRegisterSelected As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
