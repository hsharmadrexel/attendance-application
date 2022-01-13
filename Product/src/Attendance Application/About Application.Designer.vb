<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class About_Application
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
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.lblDateCreated = New System.Windows.Forms.Label()
        Me.lblDeveloperName = New System.Windows.Forms.Label()
        Me.lblContactEmail = New System.Windows.Forms.Label()
        Me.picboxLogo = New System.Windows.Forms.PictureBox()
        CType(Me.picboxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(12, 127)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(318, 17)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name: ABIS Attendance Management Application"
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Location = New System.Drawing.Point(12, 166)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(96, 17)
        Me.lblVersion.TabIndex = 2
        Me.lblVersion.Text = "Version: 1.0.1"
        '
        'lblDateCreated
        '
        Me.lblDateCreated.AutoSize = True
        Me.lblDateCreated.Location = New System.Drawing.Point(12, 208)
        Me.lblDateCreated.Name = "lblDateCreated"
        Me.lblDateCreated.Size = New System.Drawing.Size(225, 17)
        Me.lblDateCreated.TabIndex = 3
        Me.lblDateCreated.Text = "Date Created: 11th February 2017"
        '
        'lblDeveloperName
        '
        Me.lblDeveloperName.AutoSize = True
        Me.lblDeveloperName.Location = New System.Drawing.Point(12, 251)
        Me.lblDeveloperName.Name = "lblDeveloperName"
        Me.lblDeveloperName.Size = New System.Drawing.Size(213, 17)
        Me.lblDeveloperName.TabIndex = 4
        Me.lblDeveloperName.Text = "Developer Name: Harsh Sharma"
        '
        'lblContactEmail
        '
        Me.lblContactEmail.AutoSize = True
        Me.lblContactEmail.Location = New System.Drawing.Point(12, 287)
        Me.lblContactEmail.Name = "lblContactEmail"
        Me.lblContactEmail.Size = New System.Drawing.Size(266, 17)
        Me.lblContactEmail.TabIndex = 5
        Me.lblContactEmail.Text = "Contact Email: h.sharma@abisoman.com"
        '
        'picboxLogo
        '
        Me.picboxLogo.Image = Global.ITGS_IA_Application.My.Resources.Resources.School_Logo
        Me.picboxLogo.Location = New System.Drawing.Point(106, 12)
        Me.picboxLogo.Name = "picboxLogo"
        Me.picboxLogo.Size = New System.Drawing.Size(119, 98)
        Me.picboxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picboxLogo.TabIndex = 6
        Me.picboxLogo.TabStop = False
        '
        'About_Application
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(348, 332)
        Me.Controls.Add(Me.picboxLogo)
        Me.Controls.Add(Me.lblContactEmail)
        Me.Controls.Add(Me.lblDeveloperName)
        Me.Controls.Add(Me.lblDateCreated)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.lblName)
        Me.Name = "About_Application"
        Me.Text = "About_Application"
        CType(Me.picboxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblVersion As System.Windows.Forms.Label
    Friend WithEvents lblDateCreated As System.Windows.Forms.Label
    Friend WithEvents lblDeveloperName As System.Windows.Forms.Label
    Friend WithEvents lblContactEmail As System.Windows.Forms.Label
    Friend WithEvents picboxLogo As System.Windows.Forms.PictureBox
End Class
