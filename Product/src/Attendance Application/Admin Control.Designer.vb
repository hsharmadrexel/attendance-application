<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_Control
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
        Me.lblWelcomeMessage = New System.Windows.Forms.Label()
        Me.btnAddStudents = New System.Windows.Forms.Button()
        Me.btnViewStudents = New System.Windows.Forms.Button()
        Me.btnViewAttendanceRecords = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnViewAttendanceChart = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblWelcomeMessage
        '
        Me.lblWelcomeMessage.AutoSize = True
        Me.lblWelcomeMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.lblWelcomeMessage.Location = New System.Drawing.Point(12, 100)
        Me.lblWelcomeMessage.Name = "lblWelcomeMessage"
        Me.lblWelcomeMessage.Size = New System.Drawing.Size(596, 26)
        Me.lblWelcomeMessage.TabIndex = 0
        Me.lblWelcomeMessage.Text = "Welcome Atul Alex! Choose one of the control panels below."
        '
        'btnAddStudents
        '
        Me.btnAddStudents.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddStudents.Location = New System.Drawing.Point(17, 143)
        Me.btnAddStudents.Name = "btnAddStudents"
        Me.btnAddStudents.Size = New System.Drawing.Size(175, 93)
        Me.btnAddStudents.TabIndex = 1
        Me.btnAddStudents.Text = "Add Students"
        Me.btnAddStudents.UseVisualStyleBackColor = True
        '
        'btnViewStudents
        '
        Me.btnViewStudents.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewStudents.Location = New System.Drawing.Point(220, 143)
        Me.btnViewStudents.Name = "btnViewStudents"
        Me.btnViewStudents.Size = New System.Drawing.Size(175, 93)
        Me.btnViewStudents.TabIndex = 2
        Me.btnViewStudents.Text = "View Students"
        Me.btnViewStudents.UseVisualStyleBackColor = True
        '
        'btnViewAttendanceRecords
        '
        Me.btnViewAttendanceRecords.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewAttendanceRecords.Location = New System.Drawing.Point(433, 143)
        Me.btnViewAttendanceRecords.Name = "btnViewAttendanceRecords"
        Me.btnViewAttendanceRecords.Size = New System.Drawing.Size(175, 93)
        Me.btnViewAttendanceRecords.TabIndex = 3
        Me.btnViewAttendanceRecords.Text = "View Attendance Records"
        Me.btnViewAttendanceRecords.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(17, 273)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(148, 46)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit/Logout"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnViewAttendanceChart
        '
        Me.btnViewAttendanceChart.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewAttendanceChart.Location = New System.Drawing.Point(634, 143)
        Me.btnViewAttendanceChart.Name = "btnViewAttendanceChart"
        Me.btnViewAttendanceChart.Size = New System.Drawing.Size(201, 93)
        Me.btnViewAttendanceChart.TabIndex = 8
        Me.btnViewAttendanceChart.Text = "View Attendance Chart"
        Me.btnViewAttendanceChart.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 29)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Dashboard"
        '
        'Admin_Control
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(859, 338)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnViewAttendanceChart)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnViewAttendanceRecords)
        Me.Controls.Add(Me.btnViewStudents)
        Me.Controls.Add(Me.btnAddStudents)
        Me.Controls.Add(Me.lblWelcomeMessage)
        Me.Name = "Admin_Control"
        Me.Text = "Admin_Control"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblWelcomeMessage As System.Windows.Forms.Label
    Friend WithEvents btnAddStudents As System.Windows.Forms.Button
    Friend WithEvents btnViewStudents As System.Windows.Forms.Button
    Friend WithEvents btnViewAttendanceRecords As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnViewAttendanceChart As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
