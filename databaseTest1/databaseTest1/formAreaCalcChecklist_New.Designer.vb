<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formAreaCalcChecklist_New
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formAreaCalcChecklist_New))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmboCheckedBy = New System.Windows.Forms.ComboBox()
        Me.cmboCalcdBy = New System.Windows.Forms.ComboBox()
        Me.txtComments = New System.Windows.Forms.TextBox()
        Me.dtpCheckedDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpCalcdDate = New System.Windows.Forms.DateTimePicker()
        Me.cmdNewEntrySave = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTqRfi = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDrawingNumber = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtModelLayer = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdCancel)
        Me.GroupBox1.Controls.Add(Me.cmboCheckedBy)
        Me.GroupBox1.Controls.Add(Me.cmboCalcdBy)
        Me.GroupBox1.Controls.Add(Me.txtComments)
        Me.GroupBox1.Controls.Add(Me.dtpCheckedDate)
        Me.GroupBox1.Controls.Add(Me.dtpCalcdDate)
        Me.GroupBox1.Controls.Add(Me.cmdNewEntrySave)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtTqRfi)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtDrawingNumber)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtModelLayer)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(436, 319)
        Me.GroupBox1.TabIndex = 37
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add New Entry"
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(347, 283)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(60, 30)
        Me.cmdCancel.TabIndex = 10
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'cmboCheckedBy
        '
        Me.cmboCheckedBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmboCheckedBy.FormattingEnabled = True
        Me.cmboCheckedBy.Location = New System.Drawing.Point(32, 155)
        Me.cmboCheckedBy.Name = "cmboCheckedBy"
        Me.cmboCheckedBy.Size = New System.Drawing.Size(252, 21)
        Me.cmboCheckedBy.TabIndex = 6
        '
        'cmboCalcdBy
        '
        Me.cmboCalcdBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmboCalcdBy.FormattingEnabled = True
        Me.cmboCalcdBy.Location = New System.Drawing.Point(32, 98)
        Me.cmboCalcdBy.Name = "cmboCalcdBy"
        Me.cmboCalcdBy.Size = New System.Drawing.Size(252, 21)
        Me.cmboCalcdBy.TabIndex = 4
        '
        'txtComments
        '
        Me.txtComments.Location = New System.Drawing.Point(32, 205)
        Me.txtComments.MaxLength = 255
        Me.txtComments.Multiline = True
        Me.txtComments.Name = "txtComments"
        Me.txtComments.Size = New System.Drawing.Size(375, 52)
        Me.txtComments.TabIndex = 8
        '
        'dtpCheckedDate
        '
        Me.dtpCheckedDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpCheckedDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpCheckedDate.Location = New System.Drawing.Point(307, 156)
        Me.dtpCheckedDate.Name = "dtpCheckedDate"
        Me.dtpCheckedDate.Size = New System.Drawing.Size(100, 20)
        Me.dtpCheckedDate.TabIndex = 7
        Me.dtpCheckedDate.Value = New Date(2014, 5, 16, 0, 0, 0, 0)
        '
        'dtpCalcdDate
        '
        Me.dtpCalcdDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpCalcdDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpCalcdDate.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.dtpCalcdDate.Location = New System.Drawing.Point(307, 99)
        Me.dtpCalcdDate.Name = "dtpCalcdDate"
        Me.dtpCalcdDate.Size = New System.Drawing.Size(100, 20)
        Me.dtpCalcdDate.TabIndex = 5
        Me.dtpCalcdDate.Value = New Date(2014, 5, 15, 0, 0, 0, 0)
        '
        'cmdNewEntrySave
        '
        Me.cmdNewEntrySave.Image = CType(resources.GetObject("cmdNewEntrySave.Image"), System.Drawing.Image)
        Me.cmdNewEntrySave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdNewEntrySave.Location = New System.Drawing.Point(281, 283)
        Me.cmdNewEntrySave.Name = "cmdNewEntrySave"
        Me.cmdNewEntrySave.Size = New System.Drawing.Size(60, 30)
        Me.cmdNewEntrySave.TabIndex = 9
        Me.cmdNewEntrySave.Text = "Save "
        Me.cmdNewEntrySave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdNewEntrySave.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(29, 189)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 13)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Comments"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(304, 140)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 13)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Checked date"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(29, 140)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Checked by"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(304, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Calc'd date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 83)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Calc'd by"
        '
        'txtTqRfi
        '
        Me.txtTqRfi.Location = New System.Drawing.Point(307, 43)
        Me.txtTqRfi.MaxLength = 10
        Me.txtTqRfi.Name = "txtTqRfi"
        Me.txtTqRfi.Size = New System.Drawing.Size(100, 20)
        Me.txtTqRfi.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(304, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "TQ / RFI"
        '
        'txtDrawingNumber
        '
        Me.txtDrawingNumber.Location = New System.Drawing.Point(152, 43)
        Me.txtDrawingNumber.MaxLength = 30
        Me.txtDrawingNumber.Name = "txtDrawingNumber"
        Me.txtDrawingNumber.Size = New System.Drawing.Size(132, 20)
        Me.txtDrawingNumber.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(149, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Drawing Number"
        '
        'txtModelLayer
        '
        Me.txtModelLayer.Location = New System.Drawing.Point(32, 43)
        Me.txtModelLayer.MaxLength = 30
        Me.txtModelLayer.Name = "txtModelLayer"
        Me.txtModelLayer.Size = New System.Drawing.Size(100, 20)
        Me.txtModelLayer.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Model / Layer"
        '
        'formAreaCalcChecklist_New
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(460, 340)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "formAreaCalcChecklist_New"
        Me.Text = "New Entry to Area Calc Checlist"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtComments As System.Windows.Forms.TextBox
    Friend WithEvents dtpCheckedDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpCalcdDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmdNewEntrySave As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTqRfi As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDrawingNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtModelLayer As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmboCheckedBy As System.Windows.Forms.ComboBox
    Friend WithEvents cmboCalcdBy As System.Windows.Forms.ComboBox
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
End Class
