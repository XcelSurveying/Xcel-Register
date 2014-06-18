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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblWarning = New System.Windows.Forms.Label()
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
        Me.txtServer = New System.Windows.Forms.TextBox()
        Me.cmdSetupDatabase = New System.Windows.Forms.Button()
        Me.cmd_CreateTables = New System.Windows.Forms.Button()
        Me.cmboSQLServers = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmboSQLServers)
        Me.GroupBox1.Controls.Add(Me.lblWarning)
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
        Me.GroupBox1.Controls.Add(Me.txtServer)
        Me.GroupBox1.Controls.Add(Me.cmdSetupDatabase)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(347, 279)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Database connection"
        '
        'lblWarning
        '
        Me.lblWarning.AutoSize = True
        Me.lblWarning.ForeColor = System.Drawing.Color.Red
        Me.lblWarning.Location = New System.Drawing.Point(13, 218)
        Me.lblWarning.Name = "lblWarning"
        Me.lblWarning.Size = New System.Drawing.Size(57, 13)
        Me.lblWarning.TabIndex = 17
        Me.lblWarning.Text = "lblWarning"
        Me.lblWarning.Visible = False
        '
        'cmdModify
        '
        Me.cmdModify.Location = New System.Drawing.Point(109, 87)
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
        Me.lblMessage.Location = New System.Drawing.Point(215, 25)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(102, 19)
        Me.lblMessage.TabIndex = 15
        Me.lblMessage.Text = "SUCESSFUL"
        Me.lblMessage.Visible = False
        '
        'cmdTestConn
        '
        Me.cmdTestConn.Location = New System.Drawing.Point(139, 41)
        Me.cmdTestConn.Name = "cmdTestConn"
        Me.cmdTestConn.Size = New System.Drawing.Size(40, 22)
        Me.cmdTestConn.TabIndex = 14
        Me.cmdTestConn.Text = "Test"
        Me.cmdTestConn.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(202, 105)
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
        Me.Label7.Location = New System.Drawing.Point(84, 192)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "e.g. password"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label6.Location = New System.Drawing.Point(85, 142)
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
        Me.Label5.Size = New System.Drawing.Size(114, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "e.g. (localdb)\Projects"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Password :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 122)
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
        Me.Label1.Size = New System.Drawing.Size(120, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Database Server Path :"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(79, 168)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(100, 21)
        Me.txtPassword.TabIndex = 3
        '
        'txtUid
        '
        Me.txtUid.Location = New System.Drawing.Point(79, 118)
        Me.txtUid.Name = "txtUid"
        Me.txtUid.Size = New System.Drawing.Size(100, 21)
        Me.txtUid.TabIndex = 2
        '
        'txtServer
        '
        Me.txtServer.Location = New System.Drawing.Point(16, 41)
        Me.txtServer.Name = "txtServer"
        Me.txtServer.Size = New System.Drawing.Size(117, 21)
        Me.txtServer.TabIndex = 1
        '
        'cmdSetupDatabase
        '
        Me.cmdSetupDatabase.Enabled = False
        Me.cmdSetupDatabase.Location = New System.Drawing.Point(202, 58)
        Me.cmdSetupDatabase.Name = "cmdSetupDatabase"
        Me.cmdSetupDatabase.Size = New System.Drawing.Size(128, 35)
        Me.cmdSetupDatabase.TabIndex = 0
        Me.cmdSetupDatabase.Text = "Setup Database"
        Me.cmdSetupDatabase.UseVisualStyleBackColor = True
        '
        'cmd_CreateTables
        '
        Me.cmd_CreateTables.Location = New System.Drawing.Point(405, 28)
        Me.cmd_CreateTables.Name = "cmd_CreateTables"
        Me.cmd_CreateTables.Size = New System.Drawing.Size(126, 36)
        Me.cmd_CreateTables.TabIndex = 1
        Me.cmd_CreateTables.Text = "Create Tables"
        Me.cmd_CreateTables.UseVisualStyleBackColor = True
        '
        'cmboSQLServers
        '
        Me.cmboSQLServers.FormattingEnabled = True
        Me.cmboSQLServers.Location = New System.Drawing.Point(139, 242)
        Me.cmboSQLServers.Name = "cmboSQLServers"
        Me.cmboSQLServers.Size = New System.Drawing.Size(121, 21)
        Me.cmboSQLServers.TabIndex = 18
        '
        'formNewDatabaseWizard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(651, 348)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmd_CreateTables)
        Me.Name = "formNewDatabaseWizard"
        Me.Text = "formNewDatabaseWizard"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdSetupDatabase As System.Windows.Forms.Button
    Friend WithEvents cmd_CreateTables As System.Windows.Forms.Button
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtUid As System.Windows.Forms.TextBox
    Friend WithEvents txtServer As System.Windows.Forms.TextBox
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
    Friend WithEvents cmboSQLServers As System.Windows.Forms.ComboBox
End Class
