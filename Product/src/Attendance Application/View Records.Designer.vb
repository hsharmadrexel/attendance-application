<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class View_Records
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
        Me.lblChooseTeam = New System.Windows.Forms.Label()
        Me.cmbTeamName = New System.Windows.Forms.ComboBox()
        Me.lblSearchorFilterCriteria = New System.Windows.Forms.Label()
        Me.lblStudentFirstName = New System.Windows.Forms.Label()
        Me.lblStudentLastName = New System.Windows.Forms.Label()
        Me.lblGradeLevel = New System.Windows.Forms.Label()
        Me.lblAttendanceDate = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.cmbGradeLevel = New System.Windows.Forms.ComboBox()
        Me.btnAttendanceCounts = New System.Windows.Forms.Button()
        Me.btnGoBack = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblChooseTeam
        '
        Me.lblChooseTeam.AutoSize = True
        Me.lblChooseTeam.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblChooseTeam.Location = New System.Drawing.Point(12, 35)
        Me.lblChooseTeam.Name = "lblChooseTeam"
        Me.lblChooseTeam.Size = New System.Drawing.Size(499, 25)
        Me.lblChooseTeam.TabIndex = 0
        Me.lblChooseTeam.Text = "Choose the team for which you want to view the records:"
        '
        'cmbTeamName
        '
        Me.cmbTeamName.FormattingEnabled = True
        Me.cmbTeamName.Items.AddRange(New Object() {"Green Leopards", "Blue Dolphins", "Red Falcons", "Yellow Foxes"})
        Me.cmbTeamName.Location = New System.Drawing.Point(517, 36)
        Me.cmbTeamName.Name = "cmbTeamName"
        Me.cmbTeamName.Size = New System.Drawing.Size(176, 24)
        Me.cmbTeamName.TabIndex = 1
        '
        'lblSearchorFilterCriteria
        '
        Me.lblSearchorFilterCriteria.AutoSize = True
        Me.lblSearchorFilterCriteria.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lblSearchorFilterCriteria.Location = New System.Drawing.Point(14, 92)
        Me.lblSearchorFilterCriteria.Name = "lblSearchorFilterCriteria"
        Me.lblSearchorFilterCriteria.Size = New System.Drawing.Size(206, 24)
        Me.lblSearchorFilterCriteria.TabIndex = 2
        Me.lblSearchorFilterCriteria.Text = "Search or Filter Criteria:"
        '
        'lblStudentFirstName
        '
        Me.lblStudentFirstName.AutoSize = True
        Me.lblStudentFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblStudentFirstName.Location = New System.Drawing.Point(14, 137)
        Me.lblStudentFirstName.Name = "lblStudentFirstName"
        Me.lblStudentFirstName.Size = New System.Drawing.Size(164, 20)
        Me.lblStudentFirstName.TabIndex = 3
        Me.lblStudentFirstName.Text = "Student First Name: "
        '
        'lblStudentLastName
        '
        Me.lblStudentLastName.AutoSize = True
        Me.lblStudentLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblStudentLastName.Location = New System.Drawing.Point(14, 174)
        Me.lblStudentLastName.Name = "lblStudentLastName"
        Me.lblStudentLastName.Size = New System.Drawing.Size(163, 20)
        Me.lblStudentLastName.TabIndex = 4
        Me.lblStudentLastName.Text = "Student Last Name: "
        '
        'lblGradeLevel
        '
        Me.lblGradeLevel.AutoSize = True
        Me.lblGradeLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblGradeLevel.Location = New System.Drawing.Point(14, 212)
        Me.lblGradeLevel.Name = "lblGradeLevel"
        Me.lblGradeLevel.Size = New System.Drawing.Size(105, 20)
        Me.lblGradeLevel.TabIndex = 5
        Me.lblGradeLevel.Text = "Grade Level:"
        '
        'lblAttendanceDate
        '
        Me.lblAttendanceDate.AutoSize = True
        Me.lblAttendanceDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblAttendanceDate.Location = New System.Drawing.Point(14, 250)
        Me.lblAttendanceDate.Name = "lblAttendanceDate"
        Me.lblAttendanceDate.Size = New System.Drawing.Size(139, 20)
        Me.lblAttendanceDate.TabIndex = 6
        Me.lblAttendanceDate.Text = "Attendance Date:"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(393, 75)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(595, 273)
        Me.DataGridView1.TabIndex = 7
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(184, 135)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(174, 22)
        Me.txtFirstName.TabIndex = 8
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(184, 174)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(174, 22)
        Me.txtLastName.TabIndex = 9
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.btnUpdate.Location = New System.Drawing.Point(198, 296)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(160, 52)
        Me.btnUpdate.TabIndex = 12
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(169, 250)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePicker1.TabIndex = 13
        '
        'cmbGradeLevel
        '
        Me.cmbGradeLevel.FormattingEnabled = True
        Me.cmbGradeLevel.Items.AddRange(New Object() {"7", "8", "9", "10", "11", "12"})
        Me.cmbGradeLevel.Location = New System.Drawing.Point(184, 212)
        Me.cmbGradeLevel.Name = "cmbGradeLevel"
        Me.cmbGradeLevel.Size = New System.Drawing.Size(176, 24)
        Me.cmbGradeLevel.TabIndex = 14
        '
        'btnAttendanceCounts
        '
        Me.btnAttendanceCounts.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.btnAttendanceCounts.Location = New System.Drawing.Point(728, 12)
        Me.btnAttendanceCounts.Name = "btnAttendanceCounts"
        Me.btnAttendanceCounts.Size = New System.Drawing.Size(260, 52)
        Me.btnAttendanceCounts.TabIndex = 15
        Me.btnAttendanceCounts.Text = "View Attendance Counts"
        Me.btnAttendanceCounts.UseVisualStyleBackColor = True
        '
        'btnGoBack
        '
        Me.btnGoBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.btnGoBack.Location = New System.Drawing.Point(18, 296)
        Me.btnGoBack.Name = "btnGoBack"
        Me.btnGoBack.Size = New System.Drawing.Size(160, 52)
        Me.btnGoBack.TabIndex = 16
        Me.btnGoBack.Text = "Go Back"
        Me.btnGoBack.UseVisualStyleBackColor = True
        '
        'View_Records
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 360)
        Me.Controls.Add(Me.btnGoBack)
        Me.Controls.Add(Me.btnAttendanceCounts)
        Me.Controls.Add(Me.cmbGradeLevel)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.lblAttendanceDate)
        Me.Controls.Add(Me.lblGradeLevel)
        Me.Controls.Add(Me.lblStudentLastName)
        Me.Controls.Add(Me.lblStudentFirstName)
        Me.Controls.Add(Me.lblSearchorFilterCriteria)
        Me.Controls.Add(Me.cmbTeamName)
        Me.Controls.Add(Me.lblChooseTeam)
        Me.Name = "View_Records"
        Me.Text = "View_Records"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblChooseTeam As System.Windows.Forms.Label
    Friend WithEvents cmbTeamName As System.Windows.Forms.ComboBox
    Friend WithEvents lblSearchorFilterCriteria As System.Windows.Forms.Label
    Friend WithEvents lblStudentFirstName As System.Windows.Forms.Label
    Friend WithEvents lblStudentLastName As System.Windows.Forms.Label
    Friend WithEvents lblGradeLevel As System.Windows.Forms.Label
    Friend WithEvents lblAttendanceDate As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbGradeLevel As System.Windows.Forms.ComboBox
    Friend WithEvents btnAttendanceCounts As System.Windows.Forms.Button
    Friend WithEvents btnGoBack As System.Windows.Forms.Button
End Class
