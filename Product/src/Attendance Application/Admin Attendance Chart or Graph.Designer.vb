<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_Attendance_Chart_or_Graph
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
        Dim ChartArea5 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend5 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series5 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.lblPrompt = New System.Windows.Forms.Label()
        Me.cmbTeamName = New System.Windows.Forms.ComboBox()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.btnUpdate.Location = New System.Drawing.Point(471, 614)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(122, 53)
        Me.btnUpdate.TabIndex = 7
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.btnExit.Location = New System.Drawing.Point(954, 614)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(122, 53)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Button1.Location = New System.Drawing.Point(12, 614)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(122, 53)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Go Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Chart1
        '
        ChartArea5.AxisX.Interval = 1.0R
        ChartArea5.AxisX.IsLabelAutoFit = False
        ChartArea5.AxisX.LabelStyle.Angle = -90
        ChartArea5.AxisY.Interval = 1.0R
        ChartArea5.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea5)
        Legend5.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend5)
        Me.Chart1.Location = New System.Drawing.Point(12, 90)
        Me.Chart1.Name = "Chart1"
        Series5.ChartArea = "ChartArea1"
        Series5.Legend = "Legend1"
        Series5.Name = "Name_vs_DaysPresent"
        Me.Chart1.Series.Add(Series5)
        Me.Chart1.Size = New System.Drawing.Size(1064, 501)
        Me.Chart1.TabIndex = 4
        Me.Chart1.Text = "Chart1"
        '
        'lblPrompt
        '
        Me.lblPrompt.AutoSize = True
        Me.lblPrompt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lblPrompt.Location = New System.Drawing.Point(12, 41)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(294, 24)
        Me.lblPrompt.TabIndex = 8
        Me.lblPrompt.Text = "Choose a team to display records:"
        '
        'cmbTeamName
        '
        Me.cmbTeamName.FormattingEnabled = True
        Me.cmbTeamName.Items.AddRange(New Object() {"Green Leopards", "Yellow Foxes", "Red Falcons", "Blue Dolphins"})
        Me.cmbTeamName.Location = New System.Drawing.Point(312, 41)
        Me.cmbTeamName.Name = "cmbTeamName"
        Me.cmbTeamName.Size = New System.Drawing.Size(222, 24)
        Me.cmbTeamName.TabIndex = 9
        '
        'Admin_Attendance_Chart_or_Graph
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1088, 685)
        Me.Controls.Add(Me.cmbTeamName)
        Me.Controls.Add(Me.lblPrompt)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Chart1)
        Me.Name = "Admin_Attendance_Chart_or_Graph"
        Me.Text = "Admin_Attendance_Chart_or_Graph"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents lblPrompt As System.Windows.Forms.Label
    Friend WithEvents cmbTeamName As System.Windows.Forms.ComboBox
End Class
