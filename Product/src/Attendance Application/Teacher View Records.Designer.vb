<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Teacher_View_Records
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Teacher_View_Records))
        Me.btnAttendanceCounts = New System.Windows.Forms.Button()
        Me.cmbGradeLevel = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lblAttendanceDate = New System.Windows.Forms.Label()
        Me.lblGradeLevel = New System.Windows.Forms.Label()
        Me.lblStudentLastName = New System.Windows.Forms.Label()
        Me.lblStudentFirstName = New System.Windows.Forms.Label()
        Me.lblSearchorFilterCriteria = New System.Windows.Forms.Label()
        Me.btnViewRecords = New System.Windows.Forms.Button()
        Me.btnGoBack = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAttendanceCounts
        '
        Me.btnAttendanceCounts.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.btnAttendanceCounts.Location = New System.Drawing.Point(728, 12)
        Me.btnAttendanceCounts.Name = "btnAttendanceCounts"
        Me.btnAttendanceCounts.Size = New System.Drawing.Size(260, 52)
        Me.btnAttendanceCounts.TabIndex = 29
        Me.btnAttendanceCounts.Text = "View Attendance Counts"
        Me.btnAttendanceCounts.UseVisualStyleBackColor = True
        '
        'cmbGradeLevel
        '
        Me.cmbGradeLevel.FormattingEnabled = True
        Me.cmbGradeLevel.Items.AddRange(New Object() {"7", "8", "9", "10", "11", "12"})
        Me.cmbGradeLevel.Location = New System.Drawing.Point(184, 212)
        Me.cmbGradeLevel.Name = "cmbGradeLevel"
        Me.cmbGradeLevel.Size = New System.Drawing.Size(176, 24)
        Me.cmbGradeLevel.TabIndex = 28
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(169, 250)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePicker1.TabIndex = 27
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(184, 174)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(174, 22)
        Me.txtLastName.TabIndex = 25
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(184, 135)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(174, 22)
        Me.txtFirstName.TabIndex = 24
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(393, 75)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(595, 273)
        Me.DataGridView1.TabIndex = 23
        '
        'lblAttendanceDate
        '
        Me.lblAttendanceDate.AutoSize = True
        Me.lblAttendanceDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblAttendanceDate.Location = New System.Drawing.Point(14, 250)
        Me.lblAttendanceDate.Name = "lblAttendanceDate"
        Me.lblAttendanceDate.Size = New System.Drawing.Size(139, 20)
        Me.lblAttendanceDate.TabIndex = 22
        Me.lblAttendanceDate.Text = "Attendance Date:"
        '
        'lblGradeLevel
        '
        Me.lblGradeLevel.AutoSize = True
        Me.lblGradeLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblGradeLevel.Location = New System.Drawing.Point(14, 212)
        Me.lblGradeLevel.Name = "lblGradeLevel"
        Me.lblGradeLevel.Size = New System.Drawing.Size(105, 20)
        Me.lblGradeLevel.TabIndex = 21
        Me.lblGradeLevel.Text = "Grade Level:"
        '
        'lblStudentLastName
        '
        Me.lblStudentLastName.AutoSize = True
        Me.lblStudentLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblStudentLastName.Location = New System.Drawing.Point(14, 174)
        Me.lblStudentLastName.Name = "lblStudentLastName"
        Me.lblStudentLastName.Size = New System.Drawing.Size(163, 20)
        Me.lblStudentLastName.TabIndex = 20
        Me.lblStudentLastName.Text = "Student Last Name: "
        '
        'lblStudentFirstName
        '
        Me.lblStudentFirstName.AutoSize = True
        Me.lblStudentFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblStudentFirstName.Location = New System.Drawing.Point(14, 137)
        Me.lblStudentFirstName.Name = "lblStudentFirstName"
        Me.lblStudentFirstName.Size = New System.Drawing.Size(164, 20)
        Me.lblStudentFirstName.TabIndex = 19
        Me.lblStudentFirstName.Text = "Student First Name: "
        '
        'lblSearchorFilterCriteria
        '
        Me.lblSearchorFilterCriteria.AutoSize = True
        Me.lblSearchorFilterCriteria.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lblSearchorFilterCriteria.Location = New System.Drawing.Point(14, 92)
        Me.lblSearchorFilterCriteria.Name = "lblSearchorFilterCriteria"
        Me.lblSearchorFilterCriteria.Size = New System.Drawing.Size(206, 24)
        Me.lblSearchorFilterCriteria.TabIndex = 18
        Me.lblSearchorFilterCriteria.Text = "Search or Filter Criteria:"
        '
        'btnViewRecords
        '
        Me.btnViewRecords.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.btnViewRecords.Location = New System.Drawing.Point(18, 12)
        Me.btnViewRecords.Name = "btnViewRecords"
        Me.btnViewRecords.Size = New System.Drawing.Size(292, 52)
        Me.btnViewRecords.TabIndex = 30
        Me.btnViewRecords.Text = "Click to view records or Refresh"
        Me.btnViewRecords.UseVisualStyleBackColor = True
        '
        'btnGoBack
        '
        Me.btnGoBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.btnGoBack.Location = New System.Drawing.Point(17, 296)
        Me.btnGoBack.Name = "btnGoBack"
        Me.btnGoBack.Size = New System.Drawing.Size(160, 52)
        Me.btnGoBack.TabIndex = 31
        Me.btnGoBack.Text = "Go Back"
        Me.btnGoBack.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Button1.Location = New System.Drawing.Point(393, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(319, 52)
        Me.Button1.TabIndex = 32
        Me.Button1.Text = "Generate and Print Records Report"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Button3.Location = New System.Drawing.Point(207, 296)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(151, 52)
        Me.Button3.TabIndex = 34
        Me.Button3.Text = "Exit"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'Teacher_View_Records
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 360)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnGoBack)
        Me.Controls.Add(Me.btnViewRecords)
        Me.Controls.Add(Me.btnAttendanceCounts)
        Me.Controls.Add(Me.cmbGradeLevel)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.lblAttendanceDate)
        Me.Controls.Add(Me.lblGradeLevel)
        Me.Controls.Add(Me.lblStudentLastName)
        Me.Controls.Add(Me.lblStudentFirstName)
        Me.Controls.Add(Me.lblSearchorFilterCriteria)
        Me.Name = "Teacher_View_Records"
        Me.Text = "Teacher_View_Records"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAttendanceCounts As System.Windows.Forms.Button
    Friend WithEvents cmbGradeLevel As System.Windows.Forms.ComboBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents lblAttendanceDate As System.Windows.Forms.Label
    Friend WithEvents lblGradeLevel As System.Windows.Forms.Label
    Friend WithEvents lblStudentLastName As System.Windows.Forms.Label
    Friend WithEvents lblStudentFirstName As System.Windows.Forms.Label
    Friend WithEvents lblSearchorFilterCriteria As System.Windows.Forms.Label
    Friend WithEvents btnViewRecords As System.Windows.Forms.Button
    Friend WithEvents btnGoBack As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
End Class
