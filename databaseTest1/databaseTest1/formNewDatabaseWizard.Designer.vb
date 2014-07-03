<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formNewDatabaseWizard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formNewDatabaseWizard))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblWarning = New System.Windows.Forms.Label()
        Me.cmd_CreateTables = New System.Windows.Forms.Button()
        Me.cmdModify = New System.Windows.Forms.Button()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.cmdTestConn = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUid = New System.Windows.Forms.TextBox()
        Me.txtServerIP = New System.Windows.Forms.TextBox()
        Me.cmdSetupDatabase = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.dgvSQLServers = New System.Windows.Forms.DataGridView()
        Me.cmdSearch = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtServerPort = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvSQLServers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtServerPort)
        Me.GroupBox1.Controls.Add(Me.lblWarning)
        Me.GroupBox1.Controls.Add(Me.cmd_CreateTables)
        Me.GroupBox1.Controls.Add(Me.cmdModify)
        Me.GroupBox1.Controls.Add(Me.lblMessage)
        Me.GroupBox1.Controls.Add(Me.cmdTestConn)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtPassword)
        Me.GroupBox1.Controls.Add(Me.txtUid)
        Me.GroupBox1.Controls.Add(Me.txtServerIP)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(347, 276)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Database connection"
        '
        'lblWarning
        '
        Me.lblWarning.ForeColor = System.Drawing.Color.Red
        Me.lblWarning.Location = New System.Drawing.Point(13, 220)
        Me.lblWarning.Name = "lblWarning"
        Me.lblWarning.Size = New System.Drawing.Size(166, 35)
        Me.lblWarning.TabIndex = 17
        Me.lblWarning.Text = "lblWarning"
        Me.lblWarning.Visible = False
        '
        'cmd_CreateTables
        '
        Me.cmd_CreateTables.Image = CType(resources.GetObject("cmd_CreateTables.Image"), System.Drawing.Image)
        Me.cmd_CreateTables.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_CreateTables.Location = New System.Drawing.Point(230, 220)
        Me.cmd_CreateTables.Name = "cmd_CreateTables"
        Me.cmd_CreateTables.Size = New System.Drawing.Size(101, 35)
        Me.cmd_CreateTables.TabIndex = 1
        Me.cmd_CreateTables.Text = "Create Tables"
        Me.cmd_CreateTables.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_CreateTables.UseVisualStyleBackColor = True
        '
        'cmdModify
        '
        Me.cmdModify.Location = New System.Drawing.Point(16, 89)
        Me.cmdModify.Name = "cmdModify"
        Me.cmdModify.Size = New System.Drawing.Size(69, 22)
        Me.cmdModify.TabIndex = 16
        Me.cmdModify.Text = "Modify"
        Me.cmdModify.UseVisualStyleBackColor = True
        Me.cmdModify.Visible = False
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblMessage.Location = New System.Drawing.Point(212, 43)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(110, 19)
        Me.lblMessage.TabIndex = 15
        Me.lblMessage.Text = "CONNECTED"
        Me.lblMessage.Visible = False
        '
        'cmdTestConn
        '
        Me.cmdTestConn.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTestConn.Location = New System.Drawing.Point(110, 89)
        Me.cmdTestConn.Name = "cmdTestConn"
        Me.cmdTestConn.Size = New System.Drawing.Size(69, 22)
        Me.cmdTestConn.TabIndex = 14
        Me.cmdTestConn.Text = "Connect"
        Me.cmdTestConn.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(203, 89)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox1.Size = New System.Drawing.Size(128, 107)
        Me.TextBox1.TabIndex = 13
        Me.TextBox1.Text = "The database server path, user ID and the Password fields are crutial for the dat" & _
    "abase connection to work. If these are incorrect the database connection will fa" & _
    "il."
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label7.Location = New System.Drawing.Point(84, 203)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "e.g. password"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label6.Location = New System.Drawing.Point(85, 153)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "e.g. sa"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(20, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "e.g. 10.1.1.5"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 182)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Password :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "User ID :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Server IP :"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(79, 179)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(100, 21)
        Me.txtPassword.TabIndex = 3
        '
        'txtUid
        '
        Me.txtUid.Location = New System.Drawing.Point(79, 129)
        Me.txtUid.Name = "txtUid"
        Me.txtUid.Size = New System.Drawing.Size(100, 21)
        Me.txtUid.TabIndex = 2
        '
        'txtServer
        '
        Me.txtServerIP.Location = New System.Drawing.Point(16, 41)
        Me.txtServerIP.Name = "txtServer"
        Me.txtServerIP.Size = New System.Drawing.Size(76, 21)
        Me.txtServerIP.TabIndex = 1
        '
        'cmdSetupDatabase
        '
        Me.cmdSetupDatabase.Enabled = False
        Me.cmdSetupDatabase.Image = CType(resources.GetObject("cmdSetupDatabase.Image"), System.Drawing.Image)
        Me.cmdSetupDatabase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSetupDatabase.Location = New System.Drawing.Point(228, 294)
        Me.cmdSetupDatabase.Name = "cmdSetupDatabase"
        Me.cmdSetupDatabase.Size = New System.Drawing.Size(115, 35)
        Me.cmdSetupDatabase.TabIndex = 0
        Me.cmdSetupDatabase.Text = "Setup Database"
        Me.cmdSetupDatabase.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdSetupDatabase.UseVisualStyleBackColor = True
        Me.cmdSetupDatabase.Visible = False
        '
        'cmdClose
        '
        Me.cmdClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdClose.Location = New System.Drawing.Point(297, 433)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(60, 30)
        Me.cmdClose.TabIndex = 17
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'dgvSQLServers
        '
        Me.dgvSQLServers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSQLServers.Location = New System.Drawing.Point(28, 335)
        Me.dgvSQLServers.Name = "dgvSQLServers"
        Me.dgvSQLServers.Size = New System.Drawing.Size(315, 92)
        Me.dgvSQLServers.TabIndex = 18
        '
        'cmdSearch
        '
        Me.cmdSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSearch.Location = New System.Drawing.Point(26, 299)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(112, 30)
        Me.cmdSearch.TabIndex = 19
        Me.cmdSearch.Text = "Search for Servers"
        Me.cmdSearch.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(127, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "e.g. 1433"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(117, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Port :"
        '
        'txtServerPort
        '
        Me.txtServerPort.Location = New System.Drawing.Point(120, 41)
        Me.txtServerPort.Name = "txtServerPort"
        Me.txtServerPort.Size = New System.Drawing.Size(59, 21)
        Me.txtServerPort.TabIndex = 18
        '
        'formNewDatabaseWizard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(369, 475)
        Me.Controls.Add(Me.cmdSearch)
        Me.Controls.Add(Me.dgvSQLServers)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdSetupDatabase)
        Me.Name = "formNewDatabaseWizard"
        Me.Text = "Setup Database"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvSQLServers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdSetupDatabase As System.Windows.Forms.Button
    Friend WithEvents cmd_CreateTables As System.Windows.Forms.Button
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtUid As System.Windows.Forms.TextBox
    Friend WithEvents txtServerIP As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents cmdTestConn As System.Windows.Forms.Button
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents cmdModify As System.Windows.Forms.Button
    Friend WithEvents lblWarning As System.Windows.Forms.Label
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents dgvSQLServers As System.Windows.Forms.DataGridView
    Friend WithEvents cmdSearch As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtServerPort As System.Windows.Forms.TextBox
End Class
