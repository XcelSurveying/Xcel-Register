<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formNewEntryAreaCalcChecklist
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formNewEntryAreaCalcChecklist))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtNewEntryComments = New System.Windows.Forms.TextBox()
        Me.dtpNewEntryCheckedDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpNewEntryCalcdDate = New System.Windows.Forms.DateTimePicker()
        Me.cmdNewEntrySave = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNewEntryCheckedBy = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNewEntryCalcdBy = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNewEntryTqRfi = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNewEntryDrawingNumber = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNewEntryModelLayer = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtNewEntryComments)
        Me.GroupBox1.Controls.Add(Me.dtpNewEntryCheckedDate)
        Me.GroupBox1.Controls.Add(Me.dtpNewEntryCalcdDate)
        Me.GroupBox1.Controls.Add(Me.cmdNewEntrySave)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtNewEntryCheckedBy)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtNewEntryCalcdBy)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtNewEntryTqRfi)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtNewEntryDrawingNumber)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtNewEntryModelLayer)
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
        Me.txtNewEntryComments.Location = New System.Drawing.Point(32, 205)
        Me.txtNewEntryComments.MaxLength = 255
        Me.txtNewEntryComments.Multiline = True
        Me.txtNewEntryComments.Name = "txtNewEntryComments"
        Me.txtNewEntryComments.Size = New System.Drawing.Size(375, 52)
        Me.txtNewEntryComments.TabIndex = 32
        '
        'dtpNewEntryCheckedDate
        '
        Me.dtpNewEntryCheckedDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpNewEntryCheckedDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNewEntryCheckedDate.Location = New System.Drawing.Point(152, 156)
        Me.dtpNewEntryCheckedDate.Name = "dtpNewEntryCheckedDate"
        Me.dtpNewEntryCheckedDate.Size = New System.Drawing.Size(132, 20)
        Me.dtpNewEntryCheckedDate.TabIndex = 35
        Me.dtpNewEntryCheckedDate.Value = New Date(2014, 5, 16, 0, 0, 0, 0)
        '
        'dtpNewEntryCalcdDate
        '
        Me.dtpNewEntryCalcdDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpNewEntryCalcdDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNewEntryCalcdDate.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.dtpNewEntryCalcdDate.Location = New System.Drawing.Point(152, 99)
        Me.dtpNewEntryCalcdDate.Name = "dtpNewEntryCalcdDate"
        Me.dtpNewEntryCalcdDate.Size = New System.Drawing.Size(132, 20)
        Me.dtpNewEntryCalcdDate.TabIndex = 34
        Me.dtpNewEntryCalcdDate.Value = New Date(2014, 5, 15, 0, 0, 0, 0)
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
        'txtNewEntryCheckedBy
        '
        Me.txtNewEntryCheckedBy.Location = New System.Drawing.Point(32, 156)
        Me.txtNewEntryCheckedBy.MaxLength = 5
        Me.txtNewEntryCheckedBy.Name = "txtNewEntryCheckedBy"
        Me.txtNewEntryCheckedBy.Size = New System.Drawing.Size(100, 20)
        Me.txtNewEntryCheckedBy.TabIndex = 29
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
        'txtNewEntryCalcdBy
        '
        Me.txtNewEntryCalcdBy.Location = New System.Drawing.Point(32, 99)
        Me.txtNewEntryCalcdBy.MaxLength = 5
        Me.txtNewEntryCalcdBy.Name = "txtNewEntryCalcdBy"
        Me.txtNewEntryCalcdBy.Size = New System.Drawing.Size(100, 20)
        Me.txtNewEntryCalcdBy.TabIndex = 26
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
        Me.txtNewEntryTqRfi.Location = New System.Drawing.Point(307, 43)
        Me.txtNewEntryTqRfi.MaxLength = 10
        Me.txtNewEntryTqRfi.Name = "txtNewEntryTqRfi"
        Me.txtNewEntryTqRfi.Size = New System.Drawing.Size(100, 20)
        Me.txtNewEntryTqRfi.TabIndex = 24
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
        Me.txtNewEntryDrawingNumber.Location = New System.Drawing.Point(152, 43)
        Me.txtNewEntryDrawingNumber.MaxLength = 30
        Me.txtNewEntryDrawingNumber.Name = "txtNewEntryDrawingNumber"
        Me.txtNewEntryDrawingNumber.Size = New System.Drawing.Size(132, 20)
        Me.txtNewEntryDrawingNumber.TabIndex = 22
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
        Me.txtNewEntryModelLayer.Location = New System.Drawing.Point(32, 43)
        Me.txtNewEntryModelLayer.MaxLength = 30
        Me.txtNewEntryModelLayer.Name = "txtNewEntryModelLayer"
        Me.txtNewEntryModelLayer.Size = New System.Drawing.Size(100, 20)
        Me.txtNewEntryModelLayer.TabIndex = 20
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
    Friend WithEvents txtNewEntryComments As System.Windows.Forms.TextBox
    Friend WithEvents dtpNewEntryCheckedDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpNewEntryCalcdDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmdNewEntrySave As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtNewEntryCheckedBy As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtNewEntryCalcdBy As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNewEntryTqRfi As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNewEntryDrawingNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNewEntryModelLayer As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
