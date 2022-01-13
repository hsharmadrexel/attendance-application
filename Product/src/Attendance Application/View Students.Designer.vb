<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class View_Students
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
        Me.lblChooseTeamPrompt = New System.Windows.Forms.Label()
        Me.cmbTeamGroup = New System.Windows.Forms.ComboBox()
        Me.lstStudentFirstName = New System.Windows.Forms.ListBox()
        Me.lstStudentLastName = New System.Windows.Forms.ListBox()
        Me.lstGradeLevel = New System.Windows.Forms.ListBox()
        Me.btnViewRoster = New System.Windows.Forms.Button()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblGradeLevel = New System.Windows.Forms.Label()
        Me.btnGoBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblChooseTeamPrompt
        '
        Me.lblChooseTeamPrompt.AutoSize = True
        Me.lblChooseTeamPrompt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblChooseTeamPrompt.Location = New System.Drawing.Point(12, 25)
        Me.lblChooseTeamPrompt.Name = "lblChooseTeamPrompt"
        Me.lblChooseTeamPrompt.Size = New System.Drawing.Size(372, 20)
        Me.lblChooseTeamPrompt.TabIndex = 0
        Me.lblChooseTeamPrompt.Text = "Please choose the team group to view students: "
        '
        'cmbTeamGroup
        '
        Me.cmbTeamGroup.FormattingEnabled = True
        Me.cmbTeamGroup.Items.AddRange(New Object() {"Green Leopards", "Blue Dolphins", "Red Falcons", "Yellow Foxes"})
        Me.cmbTeamGroup.Location = New System.Drawing.Point(390, 25)
        Me.cmbTeamGroup.Name = "cmbTeamGroup"
        Me.cmbTeamGroup.Size = New System.Drawing.Size(158, 24)
        Me.cmbTeamGroup.TabIndex = 1
        '
        'lstStudentFirstName
        '
        Me.lstStudentFirstName.FormattingEnabled = True
        Me.lstStudentFirstName.ItemHeight = 16
        Me.lstStudentFirstName.Location = New System.Drawing.Point(16, 105)
        Me.lstStudentFirstName.Name = "lstStudentFirstName"
        Me.lstStudentFirstName.Size = New System.Drawing.Size(169, 324)
        Me.lstStudentFirstName.TabIndex = 2
        '
        'lstStudentLastName
        '
        Me.lstStudentLastName.FormattingEnabled = True
        Me.lstStudentLastName.ItemHeight = 16
        Me.lstStudentLastName.Location = New System.Drawing.Point(215, 105)
        Me.lstStudentLastName.Name = "lstStudentLastName"
        Me.lstStudentLastName.Size = New System.Drawing.Size(169, 324)
        Me.lstStudentLastName.TabIndex = 3
        '
        'lstGradeLevel
        '
        Me.lstGradeLevel.FormattingEnabled = True
        Me.lstGradeLevel.ItemHeight = 16
        Me.lstGradeLevel.Location = New System.Drawing.Point(432, 105)
        Me.lstGradeLevel.Name = "lstGradeLevel"
        Me.lstGradeLevel.Size = New System.Drawing.Size(169, 324)
        Me.lstGradeLevel.TabIndex = 4
        '
        'btnViewRoster
        '
        Me.btnViewRoster.Location = New System.Drawing.Point(630, 20)
        Me.btnViewRoster.Name = "btnViewRoster"
        Me.btnViewRoster.Size = New System.Drawing.Size(119, 33)
        Me.btnViewRoster.TabIndex = 5
        Me.btnViewRoster.Text = "View Roster"
        Me.btnViewRoster.UseVisualStyleBackColor = True
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstName.Location = New System.Drawing.Point(57, 85)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(86, 17)
        Me.lblFirstName.TabIndex = 6
        Me.lblFirstName.Text = "First Name"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastName.Location = New System.Drawing.Point(254, 85)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(85, 17)
        Me.lblLastName.TabIndex = 7
        Me.lblLastName.Text = "Last Name"
        '
        'lblGradeLevel
        '
        Me.lblGradeLevel.AutoSize = True
        Me.lblGradeLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGradeLevel.Location = New System.Drawing.Point(469, 85)
        Me.lblGradeLevel.Name = "lblGradeLevel"
        Me.lblGradeLevel.Size = New System.Drawing.Size(97, 17)
        Me.lblGradeLevel.TabIndex = 8
        Me.lblGradeLevel.Text = "Grade Level"
        '
        'btnGoBack
        '
        Me.btnGoBack.Location = New System.Drawing.Point(630, 69)
        Me.btnGoBack.Name = "btnGoBack"
        Me.btnGoBack.Size = New System.Drawing.Size(119, 33)
        Me.btnGoBack.TabIndex = 9
        Me.btnGoBack.Text = "Go Back"
        Me.btnGoBack.UseVisualStyleBackColor = True
        '
        'View_Students
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(761, 441)
        Me.Controls.Add(Me.btnGoBack)
        Me.Controls.Add(Me.lblGradeLevel)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.btnViewRoster)
        Me.Controls.Add(Me.lstGradeLevel)
        Me.Controls.Add(Me.lstStudentLastName)
        Me.Controls.Add(Me.lstStudentFirstName)
        Me.Controls.Add(Me.cmbTeamGroup)
        Me.Controls.Add(Me.lblChooseTeamPrompt)
        Me.Name = "View_Students"
        Me.Text = "View Students"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblChooseTeamPrompt As System.Windows.Forms.Label
    Friend WithEvents cmbTeamGroup As System.Windows.Forms.ComboBox
    Friend WithEvents lstStudentFirstName As System.Windows.Forms.ListBox
    Friend WithEvents lstStudentLastName As System.Windows.Forms.ListBox
    Friend WithEvents lstGradeLevel As System.Windows.Forms.ListBox
    Friend WithEvents btnViewRoster As System.Windows.Forms.Button
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents lblGradeLevel As System.Windows.Forms.Label
    Friend WithEvents btnGoBack As System.Windows.Forms.Button
End Class
