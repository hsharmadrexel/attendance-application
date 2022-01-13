<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_Students_Form
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
        Me.lblProvideDetailsPrompt = New System.Windows.Forms.Label()
        Me.lblStudentFirstName = New System.Windows.Forms.Label()
        Me.txtStudentFirstNameInput = New System.Windows.Forms.TextBox()
        Me.lblStudentLastName = New System.Windows.Forms.Label()
        Me.txtStudentLastNameInput = New System.Windows.Forms.TextBox()
        Me.lblGradeLevel = New System.Windows.Forms.Label()
        Me.txtGradeLevelInput = New System.Windows.Forms.TextBox()
        Me.lblTeamName = New System.Windows.Forms.Label()
        Me.cmbTeamNameInput = New System.Windows.Forms.ComboBox()
        Me.btnAddStudent = New System.Windows.Forms.Button()
        Me.lblStudentID = New System.Windows.Forms.Label()
        Me.txtStudentIDInput = New System.Windows.Forms.TextBox()
        Me.btnGoBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblProvideDetailsPrompt
        '
        Me.lblProvideDetailsPrompt.AutoSize = True
        Me.lblProvideDetailsPrompt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblProvideDetailsPrompt.Location = New System.Drawing.Point(12, 18)
        Me.lblProvideDetailsPrompt.Name = "lblProvideDetailsPrompt"
        Me.lblProvideDetailsPrompt.Size = New System.Drawing.Size(320, 25)
        Me.lblProvideDetailsPrompt.TabIndex = 0
        Me.lblProvideDetailsPrompt.Text = "Please provide the following details:"
        '
        'lblStudentFirstName
        '
        Me.lblStudentFirstName.AutoSize = True
        Me.lblStudentFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblStudentFirstName.Location = New System.Drawing.Point(12, 107)
        Me.lblStudentFirstName.Name = "lblStudentFirstName"
        Me.lblStudentFirstName.Size = New System.Drawing.Size(159, 20)
        Me.lblStudentFirstName.TabIndex = 1
        Me.lblStudentFirstName.Text = "Student First Name:"
        '
        'txtStudentFirstNameInput
        '
        Me.txtStudentFirstNameInput.Location = New System.Drawing.Point(183, 107)
        Me.txtStudentFirstNameInput.Name = "txtStudentFirstNameInput"
        Me.txtStudentFirstNameInput.Size = New System.Drawing.Size(178, 22)
        Me.txtStudentFirstNameInput.TabIndex = 2
        '
        'lblStudentLastName
        '
        Me.lblStudentLastName.AutoSize = True
        Me.lblStudentLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblStudentLastName.Location = New System.Drawing.Point(13, 159)
        Me.lblStudentLastName.Name = "lblStudentLastName"
        Me.lblStudentLastName.Size = New System.Drawing.Size(158, 20)
        Me.lblStudentLastName.TabIndex = 3
        Me.lblStudentLastName.Text = "Student Last Name:"
        '
        'txtStudentLastNameInput
        '
        Me.txtStudentLastNameInput.Location = New System.Drawing.Point(183, 157)
        Me.txtStudentLastNameInput.Name = "txtStudentLastNameInput"
        Me.txtStudentLastNameInput.Size = New System.Drawing.Size(178, 22)
        Me.txtStudentLastNameInput.TabIndex = 4
        '
        'lblGradeLevel
        '
        Me.lblGradeLevel.AutoSize = True
        Me.lblGradeLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblGradeLevel.Location = New System.Drawing.Point(12, 207)
        Me.lblGradeLevel.Name = "lblGradeLevel"
        Me.lblGradeLevel.Size = New System.Drawing.Size(105, 20)
        Me.lblGradeLevel.TabIndex = 5
        Me.lblGradeLevel.Text = "Grade Level:"
        '
        'txtGradeLevelInput
        '
        Me.txtGradeLevelInput.Location = New System.Drawing.Point(128, 207)
        Me.txtGradeLevelInput.Name = "txtGradeLevelInput"
        Me.txtGradeLevelInput.Size = New System.Drawing.Size(64, 22)
        Me.txtGradeLevelInput.TabIndex = 6
        '
        'lblTeamName
        '
        Me.lblTeamName.AutoSize = True
        Me.lblTeamName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblTeamName.Location = New System.Drawing.Point(12, 252)
        Me.lblTeamName.Name = "lblTeamName"
        Me.lblTeamName.Size = New System.Drawing.Size(105, 20)
        Me.lblTeamName.TabIndex = 7
        Me.lblTeamName.Text = "Team Name:"
        '
        'cmbTeamNameInput
        '
        Me.cmbTeamNameInput.FormattingEnabled = True
        Me.cmbTeamNameInput.Items.AddRange(New Object() {"Green Leopards ", "Blue Dolphins", "Red Falcons", "Yellow Foxes"})
        Me.cmbTeamNameInput.Location = New System.Drawing.Point(128, 248)
        Me.cmbTeamNameInput.Name = "cmbTeamNameInput"
        Me.cmbTeamNameInput.Size = New System.Drawing.Size(121, 24)
        Me.cmbTeamNameInput.TabIndex = 8
        '
        'btnAddStudent
        '
        Me.btnAddStudent.Location = New System.Drawing.Point(445, 261)
        Me.btnAddStudent.Name = "btnAddStudent"
        Me.btnAddStudent.Size = New System.Drawing.Size(142, 56)
        Me.btnAddStudent.TabIndex = 9
        Me.btnAddStudent.Text = "Add Student"
        Me.btnAddStudent.UseVisualStyleBackColor = True
        '
        'lblStudentID
        '
        Me.lblStudentID.AutoSize = True
        Me.lblStudentID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblStudentID.Location = New System.Drawing.Point(12, 62)
        Me.lblStudentID.Name = "lblStudentID"
        Me.lblStudentID.Size = New System.Drawing.Size(93, 20)
        Me.lblStudentID.TabIndex = 10
        Me.lblStudentID.Text = "Student ID:"
        '
        'txtStudentIDInput
        '
        Me.txtStudentIDInput.Location = New System.Drawing.Point(107, 60)
        Me.txtStudentIDInput.Name = "txtStudentIDInput"
        Me.txtStudentIDInput.Size = New System.Drawing.Size(64, 22)
        Me.txtStudentIDInput.TabIndex = 11
        '
        'btnGoBack
        '
        Me.btnGoBack.Location = New System.Drawing.Point(331, 261)
        Me.btnGoBack.Name = "btnGoBack"
        Me.btnGoBack.Size = New System.Drawing.Size(96, 56)
        Me.btnGoBack.TabIndex = 12
        Me.btnGoBack.Text = "Go Back"
        Me.btnGoBack.UseVisualStyleBackColor = True
        '
        'Add_Students_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(599, 329)
        Me.Controls.Add(Me.btnGoBack)
        Me.Controls.Add(Me.txtStudentIDInput)
        Me.Controls.Add(Me.lblStudentID)
        Me.Controls.Add(Me.btnAddStudent)
        Me.Controls.Add(Me.cmbTeamNameInput)
        Me.Controls.Add(Me.lblTeamName)
        Me.Controls.Add(Me.txtGradeLevelInput)
        Me.Controls.Add(Me.lblGradeLevel)
        Me.Controls.Add(Me.txtStudentLastNameInput)
        Me.Controls.Add(Me.lblStudentLastName)
        Me.Controls.Add(Me.txtStudentFirstNameInput)
        Me.Controls.Add(Me.lblStudentFirstName)
        Me.Controls.Add(Me.lblProvideDetailsPrompt)
        Me.Name = "Add_Students_Form"
        Me.Text = "Add_Students_Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblProvideDetailsPrompt As System.Windows.Forms.Label
    Friend WithEvents lblStudentFirstName As System.Windows.Forms.Label
    Friend WithEvents txtStudentFirstNameInput As System.Windows.Forms.TextBox
    Friend WithEvents lblStudentLastName As System.Windows.Forms.Label
    Friend WithEvents txtStudentLastNameInput As System.Windows.Forms.TextBox
    Friend WithEvents lblGradeLevel As System.Windows.Forms.Label
    Friend WithEvents txtGradeLevelInput As System.Windows.Forms.TextBox
    Friend WithEvents lblTeamName As System.Windows.Forms.Label
    Friend WithEvents cmbTeamNameInput As System.Windows.Forms.ComboBox
    Friend WithEvents btnAddStudent As System.Windows.Forms.Button
    Friend WithEvents lblStudentID As System.Windows.Forms.Label
    Friend WithEvents txtStudentIDInput As System.Windows.Forms.TextBox
    Friend WithEvents btnGoBack As System.Windows.Forms.Button
End Class
