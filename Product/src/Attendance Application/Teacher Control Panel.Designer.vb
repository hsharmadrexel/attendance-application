<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Teacher_Control_Panel
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
        Me.btnTakeAttendance = New System.Windows.Forms.Button()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.btnViewRoster = New System.Windows.Forms.Button()
        Me.btnViewAttendanceRecords = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnViewAttendanceChart = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblWelcomeMessage
        '
        Me.lblWelcomeMessage.AutoSize = True
        Me.lblWelcomeMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcomeMessage.Location = New System.Drawing.Point(12, 9)
        Me.lblWelcomeMessage.Name = "lblWelcomeMessage"
        Me.lblWelcomeMessage.Size = New System.Drawing.Size(0, 29)
        Me.lblWelcomeMessage.TabIndex = 0
        '
        'btnTakeAttendance
        '
        Me.btnTakeAttendance.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTakeAttendance.Location = New System.Drawing.Point(17, 147)
        Me.btnTakeAttendance.Name = "btnTakeAttendance"
        Me.btnTakeAttendance.Size = New System.Drawing.Size(177, 81)
        Me.btnTakeAttendance.TabIndex = 1
        Me.btnTakeAttendance.Text = "Take Attendance"
        Me.btnTakeAttendance.UseVisualStyleBackColor = True
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions.Location = New System.Drawing.Point(14, 103)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(391, 25)
        Me.lblInstructions.TabIndex = 2
        Me.lblInstructions.Text = "Please choose one of the following controls:"
        '
        'btnViewRoster
        '
        Me.btnViewRoster.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewRoster.Location = New System.Drawing.Point(228, 147)
        Me.btnViewRoster.Name = "btnViewRoster"
        Me.btnViewRoster.Size = New System.Drawing.Size(177, 81)
        Me.btnViewRoster.TabIndex = 3
        Me.btnViewRoster.Text = "View Roster"
        Me.btnViewRoster.UseVisualStyleBackColor = True
        '
        'btnViewAttendanceRecords
        '
        Me.btnViewAttendanceRecords.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewAttendanceRecords.Location = New System.Drawing.Point(442, 147)
        Me.btnViewAttendanceRecords.Name = "btnViewAttendanceRecords"
        Me.btnViewAttendanceRecords.Size = New System.Drawing.Size(177, 81)
        Me.btnViewAttendanceRecords.TabIndex = 4
        Me.btnViewAttendanceRecords.Text = "View Attendance Records"
        Me.btnViewAttendanceRecords.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(19, 260)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(103, 41)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnViewAttendanceChart
        '
        Me.btnViewAttendanceChart.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewAttendanceChart.Location = New System.Drawing.Point(663, 147)
        Me.btnViewAttendanceChart.Name = "btnViewAttendanceChart"
        Me.btnViewAttendanceChart.Size = New System.Drawing.Size(177, 81)
        Me.btnViewAttendanceChart.TabIndex = 7
        Me.btnViewAttendanceChart.Text = "View Attendance Chart"
        Me.btnViewAttendanceChart.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 26)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Dashboard"
        '
        'Teacher_Control_Panel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(869, 310)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnViewAttendanceChart)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnViewAttendanceRecords)
        Me.Controls.Add(Me.btnViewRoster)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.btnTakeAttendance)
        Me.Controls.Add(Me.lblWelcomeMessage)
        Me.Name = "Teacher_Control_Panel"
        Me.Text = "Teacher_Control_Panel"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblWelcomeMessage As System.Windows.Forms.Label
    Friend WithEvents btnTakeAttendance As System.Windows.Forms.Button
    Friend WithEvents lblInstructions As System.Windows.Forms.Label
    Friend WithEvents btnViewRoster As System.Windows.Forms.Button
    Friend WithEvents btnViewAttendanceRecords As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnViewAttendanceChart As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
