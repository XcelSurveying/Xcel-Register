<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formRestoreTables
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
        Me.rbAreaCalcChecklist = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtInstructions = New System.Windows.Forms.RichTextBox()
        Me.rbTQRFIRegister = New System.Windows.Forms.RadioButton()
        Me.rbSurveyReportRegister = New System.Windows.Forms.RadioButton()
        Me.rbFieldDataRegister = New System.Windows.Forms.RadioButton()
        Me.cmdRestore = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'rbAreaCalcChecklist
        '
        Me.rbAreaCalcChecklist.AutoSize = True
        Me.rbAreaCalcChecklist.Location = New System.Drawing.Point(26, 44)
        Me.rbAreaCalcChecklist.Name = "rbAreaCalcChecklist"
        Me.rbAreaCalcChecklist.Size = New System.Drawing.Size(116, 17)
        Me.rbAreaCalcChecklist.TabIndex = 0
        Me.rbAreaCalcChecklist.TabStop = True
        Me.rbAreaCalcChecklist.Text = "Area Calc Checklist"
        Me.rbAreaCalcChecklist.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.cmdRestore)
        Me.GroupBox1.Controls.Add(Me.txtInstructions)
        Me.GroupBox1.Controls.Add(Me.rbTQRFIRegister)
        Me.GroupBox1.Controls.Add(Me.rbSurveyReportRegister)
        Me.GroupBox1.Controls.Add(Me.rbFieldDataRegister)
        Me.GroupBox1.Controls.Add(Me.rbAreaCalcChecklist)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(645, 238)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select table to restore"
        '
        'txtInstructions
        '
        Me.txtInstructions.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtInstructions.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtInstructions.Location = New System.Drawing.Point(321, 19)
        Me.txtInstructions.Name = "txtInstructions"
        Me.txtInstructions.ReadOnly = True
        Me.txtInstructions.Size = New System.Drawing.Size(318, 176)
        Me.txtInstructions.TabIndex = 5
        Me.txtInstructions.Text = ""
        '
        'rbTQRFIRegister
        '
        Me.rbTQRFIRegister.AutoSize = True
        Me.rbTQRFIRegister.Location = New System.Drawing.Point(26, 164)
        Me.rbTQRFIRegister.Name = "rbTQRFIRegister"
        Me.rbTQRFIRegister.Size = New System.Drawing.Size(109, 17)
        Me.rbTQRFIRegister.TabIndex = 3
        Me.rbTQRFIRegister.TabStop = True
        Me.rbTQRFIRegister.Text = "TQ / RFI Register"
        Me.rbTQRFIRegister.UseVisualStyleBackColor = True
        '
        'rbSurveyReportRegister
        '
        Me.rbSurveyReportRegister.AutoSize = True
        Me.rbSurveyReportRegister.Location = New System.Drawing.Point(26, 124)
        Me.rbSurveyReportRegister.Name = "rbSurveyReportRegister"
        Me.rbSurveyReportRegister.Size = New System.Drawing.Size(138, 17)
        Me.rbSurveyReportRegister.TabIndex = 2
        Me.rbSurveyReportRegister.TabStop = True
        Me.rbSurveyReportRegister.Text = "Survey Report Register"
        Me.rbSurveyReportRegister.UseVisualStyleBackColor = True
        '
        'rbFieldDataRegister
        '
        Me.rbFieldDataRegister.AutoSize = True
        Me.rbFieldDataRegister.Location = New System.Drawing.Point(26, 84)
        Me.rbFieldDataRegister.Name = "rbFieldDataRegister"
        Me.rbFieldDataRegister.Size = New System.Drawing.Size(116, 17)
        Me.rbFieldDataRegister.TabIndex = 1
        Me.rbFieldDataRegister.TabStop = True
        Me.rbFieldDataRegister.Text = "Field Data Register"
        Me.rbFieldDataRegister.UseVisualStyleBackColor = True
        '
        'cmdRestore
        '
        Me.cmdRestore.Location = New System.Drawing.Point(26, 204)
        Me.cmdRestore.Name = "cmdRestore"
        Me.cmdRestore.Size = New System.Drawing.Size(138, 22)
        Me.cmdRestore.TabIndex = 6
        Me.cmdRestore.Text = "Restore"
        Me.cmdRestore.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(551, 204)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 22)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'formRestoreTables
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(669, 262)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Name = "formRestoreTables"
        Me.Text = "Restore From CSV (Comma Separated Values)"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rbAreaCalcChecklist As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbTQRFIRegister As System.Windows.Forms.RadioButton
    Friend WithEvents rbSurveyReportRegister As System.Windows.Forms.RadioButton
    Friend WithEvents rbFieldDataRegister As System.Windows.Forms.RadioButton
    Friend WithEvents txtInstructions As System.Windows.Forms.RichTextBox
    Friend WithEvents cmdRestore As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
