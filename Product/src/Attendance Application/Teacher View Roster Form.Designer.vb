<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Teacher_View_Roster_Form
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
        Me.lblGradeLevel = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lstGradeLevel = New System.Windows.Forms.ListBox()
        Me.lstStudentLastName = New System.Windows.Forms.ListBox()
        Me.lstStudentFirstName = New System.Windows.Forms.ListBox()
        Me.btnGoBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblGradeLevel
        '
        Me.lblGradeLevel.AutoSize = True
        Me.lblGradeLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGradeLevel.Location = New System.Drawing.Point(471, 34)
        Me.lblGradeLevel.Name = "lblGradeLevel"
        Me.lblGradeLevel.Size = New System.Drawing.Size(97, 17)
        Me.lblGradeLevel.TabIndex = 14
        Me.lblGradeLevel.Text = "Grade Level"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastName.Location = New System.Drawing.Point(256, 34)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(85, 17)
        Me.lblLastName.TabIndex = 13
        Me.lblLastName.Text = "Last Name"
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstName.Location = New System.Drawing.Point(59, 34)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(86, 17)
        Me.lblFirstName.TabIndex = 12
        Me.lblFirstName.Text = "First Name"
        '
        'lstGradeLevel
        '
        Me.lstGradeLevel.FormattingEnabled = True
        Me.lstGradeLevel.ItemHeight = 16
        Me.lstGradeLevel.Location = New System.Drawing.Point(434, 54)
        Me.lstGradeLevel.Name = "lstGradeLevel"
        Me.lstGradeLevel.Size = New System.Drawing.Size(169, 324)
        Me.lstGradeLevel.TabIndex = 11
        '
        'lstStudentLastName
        '
        Me.lstStudentLastName.FormattingEnabled = True
        Me.lstStudentLastName.ItemHeight = 16
        Me.lstStudentLastName.Location = New System.Drawing.Point(217, 54)
        Me.lstStudentLastName.Name = "lstStudentLastName"
        Me.lstStudentLastName.Size = New System.Drawing.Size(169, 324)
        Me.lstStudentLastName.TabIndex = 10
        '
        'lstStudentFirstName
        '
        Me.lstStudentFirstName.FormattingEnabled = True
        Me.lstStudentFirstName.ItemHeight = 16
        Me.lstStudentFirstName.Location = New System.Drawing.Point(18, 54)
        Me.lstStudentFirstName.Name = "lstStudentFirstName"
        Me.lstStudentFirstName.Size = New System.Drawing.Size(169, 324)
        Me.lstStudentFirstName.TabIndex = 9
        '
        'btnGoBack
        '
        Me.btnGoBack.Location = New System.Drawing.Point(18, 389)
        Me.btnGoBack.Name = "btnGoBack"
        Me.btnGoBack.Size = New System.Drawing.Size(143, 40)
        Me.btnGoBack.TabIndex = 15
        Me.btnGoBack.Text = "Go Back"
        Me.btnGoBack.UseVisualStyleBackColor = True
        '
        'Teacher_View_Roster_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(625, 441)
        Me.Controls.Add(Me.btnGoBack)
        Me.Controls.Add(Me.lblGradeLevel)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.lstGradeLevel)
        Me.Controls.Add(Me.lstStudentLastName)
        Me.Controls.Add(Me.lstStudentFirstName)
        Me.Name = "Teacher_View_Roster_Form"
        Me.Text = "Teacher_View_Roster_Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblGradeLevel As System.Windows.Forms.Label
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents lstGradeLevel As System.Windows.Forms.ListBox
    Friend WithEvents lstStudentLastName As System.Windows.Forms.ListBox
    Friend WithEvents lstStudentFirstName As System.Windows.Forms.ListBox
    Friend WithEvents btnGoBack As System.Windows.Forms.Button
End Class
