<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formModifyTqRfiRegister
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
        Me.txtDrawingNumber = New System.Windows.Forms.TextBox()
        Me.txtTqRfi = New System.Windows.Forms.TextBox()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.cmboSurveyor = New System.Windows.Forms.ComboBox()
        Me.cmboArea = New System.Windows.Forms.ComboBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblDNMessage = New System.Windows.Forms.Label()
        Me.lblTQMessage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtDrawingNumber
        '
        Me.txtDrawingNumber.Location = New System.Drawing.Point(15, 35)
        Me.txtDrawingNumber.MaxLength = 30
        Me.txtDrawingNumber.Name = "txtDrawingNumber"
        Me.txtDrawingNumber.Size = New System.Drawing.Size(121, 20)
        Me.txtDrawingNumber.TabIndex = 0
        '
        'txtTqRfi
        '
        Me.txtTqRfi.Location = New System.Drawing.Point(172, 35)
        Me.txtTqRfi.MaxLength = 30
        Me.txtTqRfi.Name = "txtTqRfi"
        Me.txtTqRfi.Size = New System.Drawing.Size(141, 20)
        Me.txtTqRfi.TabIndex = 1
        '
        'dtpDate
        '
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDate.Location = New System.Drawing.Point(15, 110)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(121, 20)
        Me.dtpDate.TabIndex = 2
        '
        'cmboSurveyor
        '
        Me.cmboSurveyor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmboSurveyor.FormattingEnabled = True
        Me.cmboSurveyor.Location = New System.Drawing.Point(172, 110)
        Me.cmboSurveyor.Name = "cmboSurveyor"
        Me.cmboSurveyor.Size = New System.Drawing.Size(142, 21)
        Me.cmboSurveyor.TabIndex = 3
        '
        'cmboArea
        '
        Me.cmboArea.BackColor = System.Drawing.SystemColors.Window
        Me.cmboArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmboArea.FormattingEnabled = True
        Me.cmboArea.Location = New System.Drawing.Point(15, 170)
        Me.cmboArea.Name = "cmboArea"
        Me.cmboArea.Size = New System.Drawing.Size(298, 21)
        Me.cmboArea.TabIndex = 4
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(15, 230)
        Me.txtDescription.MaxLength = 255
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(298, 58)
        Me.txtDescription.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Drawing Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(169, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "TQ / RFI"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Date Recieved"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(169, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Surveyor"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 154)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Area"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 214)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Description"
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(241, 316)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 36)
        Me.cmdSave.TabIndex = 12
        Me.cmdSave.Text = "Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(183, 329)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(49, 23)
        Me.cmdCancel.TabIndex = 13
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Location = New System.Drawing.Point(-28, 305)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(377, 82)
        Me.Label7.TabIndex = 14
        '
        'lblDNMessage
        '
        Me.lblDNMessage.AutoSize = True
        Me.lblDNMessage.ForeColor = System.Drawing.Color.Red
        Me.lblDNMessage.Location = New System.Drawing.Point(17, 58)
        Me.lblDNMessage.Name = "lblDNMessage"
        Me.lblDNMessage.Size = New System.Drawing.Size(76, 13)
        Me.lblDNMessage.TabIndex = 15
        Me.lblDNMessage.Text = "lblDNMessage"
        Me.lblDNMessage.Visible = False
        '
        'lblTQMessage
        '
        Me.lblTQMessage.AutoSize = True
        Me.lblTQMessage.ForeColor = System.Drawing.Color.Red
        Me.lblTQMessage.Location = New System.Drawing.Point(173, 58)
        Me.lblTQMessage.Name = "lblTQMessage"
        Me.lblTQMessage.Size = New System.Drawing.Size(75, 13)
        Me.lblTQMessage.TabIndex = 16
        Me.lblTQMessage.Text = "lblTQMessage"
        Me.lblTQMessage.Visible = False
        '
        'formNewEntryTqRfiRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(328, 364)
        Me.Controls.Add(Me.lblTQMessage)
        Me.Controls.Add(Me.lblDNMessage)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmboSurveyor)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmboArea)
        Me.Controls.Add(Me.txtDrawingNumber)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtTqRfi)
        Me.Controls.Add(Me.Label7)
        Me.Name = "formNewEntryTqRfiRegister"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Enter New Entry to TQ / RFI Register"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtDrawingNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtTqRfi As System.Windows.Forms.TextBox
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmboSurveyor As System.Windows.Forms.ComboBox
    Friend WithEvents cmboArea As System.Windows.Forms.ComboBox
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblDNMessage As System.Windows.Forms.Label
    Friend WithEvents lblTQMessage As System.Windows.Forms.Label
End Class
