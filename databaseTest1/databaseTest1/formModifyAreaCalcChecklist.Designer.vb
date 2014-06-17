<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formModifyAreaCalcChecklist
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formModifyAreaCalcChecklist))
        Me.dtpModifyCheckedDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpModifyCalcdDate = New System.Windows.Forms.DateTimePicker()
        Me.cmdModifySave = New System.Windows.Forms.Button()
        Me.txtModifyComments = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtModifyCheckedBy = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtModifyCalcdBy = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtModifyTqRfi = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtModifyDrawingNumber = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtModifyModelLayer = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtpModifyCheckedDate
        '
        Me.dtpModifyCheckedDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpModifyCheckedDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpModifyCheckedDate.Location = New System.Drawing.Point(152, 156)
        Me.dtpModifyCheckedDate.Name = "dtpModifyCheckedDate"
        Me.dtpModifyCheckedDate.Size = New System.Drawing.Size(132, 20)
        Me.dtpModifyCheckedDate.TabIndex = 35
        Me.dtpModifyCheckedDate.Value = New Date(2014, 5, 16, 0, 0, 0, 0)
        '
        'dtpModifyCalcdDate
        '
        Me.dtpModifyCalcdDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpModifyCalcdDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpModifyCalcdDate.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.dtpModifyCalcdDate.Location = New System.Drawing.Point(152, 99)
        Me.dtpModifyCalcdDate.Name = "dtpModifyCalcdDate"
        Me.dtpModifyCalcdDate.Size = New System.Drawing.Size(132, 20)
        Me.dtpModifyCalcdDate.TabIndex = 34
        Me.dtpModifyCalcdDate.Value = New Date(2014, 5, 15, 0, 0, 0, 0)
        '
        'cmdModifySave
        '
        Me.cmdModifySave.Image = CType(resources.GetObject("cmdModifySave.Image"), System.Drawing.Image)
        Me.cmdModifySave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdModifySave.Location = New System.Drawing.Point(307, 140)
        Me.cmdModifySave.Name = "cmdModifySave"
        Me.cmdModifySave.Size = New System.Drawing.Size(100, 36)
        Me.cmdModifySave.TabIndex = 33
        Me.cmdModifySave.Text = "Save "
        Me.cmdModifySave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdModifySave.UseVisualStyleBackColor = True
        '
        'txtModifyComments
        '
        Me.txtModifyComments.Location = New System.Drawing.Point(32, 205)
        Me.txtModifyComments.MaxLength = 255
        Me.txtModifyComments.Multiline = True
        Me.txtModifyComments.Name = "txtModifyComments"
        Me.txtModifyComments.Size = New System.Drawing.Size(375, 52)
        Me.txtModifyComments.TabIndex = 32
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
        'txtModifyCheckedBy
        '
        Me.txtModifyCheckedBy.Location = New System.Drawing.Point(32, 156)
        Me.txtModifyCheckedBy.MaxLength = 5
        Me.txtModifyCheckedBy.Name = "txtModifyCheckedBy"
        Me.txtModifyCheckedBy.Size = New System.Drawing.Size(100, 20)
        Me.txtModifyCheckedBy.TabIndex = 29
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
        'txtModifyCalcdBy
        '
        Me.txtModifyCalcdBy.Location = New System.Drawing.Point(32, 99)
        Me.txtModifyCalcdBy.MaxLength = 5
        Me.txtModifyCalcdBy.Name = "txtModifyCalcdBy"
        Me.txtModifyCalcdBy.Size = New System.Drawing.Size(100, 20)
        Me.txtModifyCalcdBy.TabIndex = 26
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
        'txtModifyTqRfi
        '
        Me.txtModifyTqRfi.Location = New System.Drawing.Point(307, 43)
        Me.txtModifyTqRfi.MaxLength = 10
        Me.txtModifyTqRfi.Name = "txtModifyTqRfi"
        Me.txtModifyTqRfi.Size = New System.Drawing.Size(100, 20)
        Me.txtModifyTqRfi.TabIndex = 24
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
        'txtModifyDrawingNumber
        '
        Me.txtModifyDrawingNumber.Location = New System.Drawing.Point(152, 43)
        Me.txtModifyDrawingNumber.MaxLength = 30
        Me.txtModifyDrawingNumber.Name = "txtModifyDrawingNumber"
        Me.txtModifyDrawingNumber.Size = New System.Drawing.Size(132, 20)
        Me.txtModifyDrawingNumber.TabIndex = 22
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
        'txtModifyModelLayer
        '
        Me.txtModifyModelLayer.Location = New System.Drawing.Point(32, 43)
        Me.txtModifyModelLayer.MaxLength = 30
        Me.txtModifyModelLayer.Name = "txtModifyModelLayer"
        Me.txtModifyModelLayer.Size = New System.Drawing.Size(100, 20)
        Me.txtModifyModelLayer.TabIndex = 20
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtModifyComments)
        Me.GroupBox1.Controls.Add(Me.dtpModifyCheckedDate)
        Me.GroupBox1.Controls.Add(Me.dtpModifyCalcdDate)
        Me.GroupBox1.Controls.Add(Me.cmdModifySave)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtModifyCheckedBy)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtModifyCalcdBy)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtModifyTqRfi)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtModifyDrawingNumber)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtModifyModelLayer)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(438, 272)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Modify Entries"
        '
        'formModifyAreaCalcChecklist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(467, 296)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formModifyAreaCalcChecklist"
        Me.ShowIcon = False
        Me.Text = "Modify Entry for Area Calc Checklist"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dtpModifyCheckedDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpModifyCalcdDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmdModifySave As System.Windows.Forms.Button
    Friend WithEvents txtModifyComments As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtModifyCheckedBy As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtModifyCalcdBy As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtModifyTqRfi As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtModifyDrawingNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtModifyModelLayer As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
