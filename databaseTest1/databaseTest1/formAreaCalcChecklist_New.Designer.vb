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
        Me.cmboCalcdBy = New System.Windows.Forms.ComboBox()
        Me.cmboCheckedBy = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
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
        Me.GroupBox1.Size = New System.Drawing.Size(438, 272)
        Me.GroupBox1.TabIndex = 37
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add New Entry"
        '
        'txtNewEntryComments
        '
        Me.txtComments.Location = New System.Drawing.Point(32, 205)
        Me.txtComments.MaxLength = 255
        Me.txtComments.Multiline = True
        Me.txtComments.Name = "txtNewEntryComments"
        Me.txtComments.Size = New System.Drawing.Size(375, 52)
        Me.txtComments.TabIndex = 32
        '
        'dtpNewEntryCheckedDate
        '
        Me.dtpCheckedDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpCheckedDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpCheckedDate.Location = New System.Drawing.Point(152, 156)
        Me.dtpCheckedDate.Name = "dtpNewEntryCheckedDate"
        Me.dtpCheckedDate.Size = New System.Drawing.Size(132, 20)
        Me.dtpCheckedDate.TabIndex = 35
        Me.dtpCheckedDate.Value = New Date(2014, 5, 16, 0, 0, 0, 0)
        '
        'dtpNewEntryCalcdDate
        '
        Me.dtpCalcdDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpCalcdDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpCalcdDate.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.dtpCalcdDate.Location = New System.Drawing.Point(152, 99)
        Me.dtpCalcdDate.Name = "dtpNewEntryCalcdDate"
        Me.dtpCalcdDate.Size = New System.Drawing.Size(132, 20)
        Me.dtpCalcdDate.TabIndex = 34
        Me.dtpCalcdDate.Value = New Date(2014, 5, 15, 0, 0, 0, 0)
        '
        'cmdNewEntrySave
        '
        Me.cmdNewEntrySave.Image = CType(resources.GetObject("cmdNewEntrySave.Image"), System.Drawing.Image)
        Me.cmdNewEntrySave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdNewEntrySave.Location = New System.Drawing.Point(307, 140)
        Me.cmdNewEntrySave.Name = "cmdNewEntrySave"
        Me.cmdNewEntrySave.Size = New System.Drawing.Size(100, 36)
        Me.cmdNewEntrySave.TabIndex = 33
        Me.cmdNewEntrySave.Text = "Save "
        Me.cmdNewEntrySave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdNewEntrySave.UseVisualStyleBackColor = True
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
        Me.Label7.Location = New System.Drawing.Point(149, 140)
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
        Me.Label5.Location = New System.Drawing.Point(149, 83)
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
        'txtNewEntryTqRfi
        '
        Me.txtTqRfi.Location = New System.Drawing.Point(307, 43)
        Me.txtTqRfi.MaxLength = 10
        Me.txtTqRfi.Name = "txtNewEntryTqRfi"
        Me.txtTqRfi.Size = New System.Drawing.Size(100, 20)
        Me.txtTqRfi.TabIndex = 24
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
        'txtNewEntryDrawingNumber
        '
        Me.txtDrawingNumber.Location = New System.Drawing.Point(152, 43)
        Me.txtDrawingNumber.MaxLength = 30
        Me.txtDrawingNumber.Name = "txtNewEntryDrawingNumber"
        Me.txtDrawingNumber.Size = New System.Drawing.Size(132, 20)
        Me.txtDrawingNumber.TabIndex = 22
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
        'txtNewEntryModelLayer
        '
        Me.txtModelLayer.Location = New System.Drawing.Point(32, 43)
        Me.txtModelLayer.MaxLength = 30
        Me.txtModelLayer.Name = "txtNewEntryModelLayer"
        Me.txtModelLayer.Size = New System.Drawing.Size(100, 20)
        Me.txtModelLayer.TabIndex = 20
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
        'cmboCalcdBy
        '
        Me.cmboCalcdBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmboCalcdBy.FormattingEnabled = True
        Me.cmboCalcdBy.Location = New System.Drawing.Point(32, 98)
        Me.cmboCalcdBy.Name = "cmboCalcdBy"
        Me.cmboCalcdBy.Size = New System.Drawing.Size(100, 21)
        Me.cmboCalcdBy.TabIndex = 37
        '
        'cmboCheckedBy
        '
        Me.cmboCheckedBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmboCheckedBy.FormattingEnabled = True
        Me.cmboCheckedBy.Location = New System.Drawing.Point(32, 155)
        Me.cmboCheckedBy.Name = "cmboCheckedBy"
        Me.cmboCheckedBy.Size = New System.Drawing.Size(100, 21)
        Me.cmboCheckedBy.TabIndex = 38
        '
        'formNewEntryAreaCalcChecklist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(467, 296)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "formNewEntryAreaCalcChecklist"
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
End Class
