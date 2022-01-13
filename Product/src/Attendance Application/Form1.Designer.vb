<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoginPage
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
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.lblUsernamePrompt = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblPasswordPrompt = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.picSchoolLogo = New System.Windows.Forms.PictureBox()
        CType(Me.picSchoolLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblWelcomeMessage
        '
        Me.lblWelcomeMessage.AutoSize = True
        Me.lblWelcomeMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.lblWelcomeMessage.Location = New System.Drawing.Point(46, 24)
        Me.lblWelcomeMessage.Name = "lblWelcomeMessage"
        Me.lblWelcomeMessage.Size = New System.Drawing.Size(611, 26)
        Me.lblWelcomeMessage.TabIndex = 0
        Me.lblWelcomeMessage.Text = "Welcome to Al Batinah International School Attendance Portal"
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lblInstructions.Location = New System.Drawing.Point(82, 283)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(466, 24)
        Me.lblInstructions.TabIndex = 2
        Me.lblInstructions.Text = "Please enter your username and password to proceed"
        '
        'lblUsernamePrompt
        '
        Me.lblUsernamePrompt.AutoSize = True
        Me.lblUsernamePrompt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblUsernamePrompt.Location = New System.Drawing.Point(129, 344)
        Me.lblUsernamePrompt.Name = "lblUsernamePrompt"
        Me.lblUsernamePrompt.Size = New System.Drawing.Size(91, 20)
        Me.lblUsernamePrompt.TabIndex = 3
        Me.lblUsernamePrompt.Text = "Username:"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(226, 344)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(187, 22)
        Me.txtUsername.TabIndex = 4
        '
        'lblPasswordPrompt
        '
        Me.lblPasswordPrompt.AutoSize = True
        Me.lblPasswordPrompt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblPasswordPrompt.Location = New System.Drawing.Point(129, 381)
        Me.lblPasswordPrompt.Name = "lblPasswordPrompt"
        Me.lblPasswordPrompt.Size = New System.Drawing.Size(88, 20)
        Me.lblPasswordPrompt.TabIndex = 5
        Me.lblPasswordPrompt.Text = "Password:"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(226, 381)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(187, 22)
        Me.txtPassword.TabIndex = 6
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(456, 333)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(134, 45)
        Me.btnLogin.TabIndex = 7
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(456, 384)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(134, 33)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'picSchoolLogo
        '
        Me.picSchoolLogo.Image = Global.ITGS_IA_Application.My.Resources.Resources.School_Logo
        Me.picSchoolLogo.Location = New System.Drawing.Point(245, 74)
        Me.picSchoolLogo.Name = "picSchoolLogo"
        Me.picSchoolLogo.Size = New System.Drawing.Size(184, 175)
        Me.picSchoolLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSchoolLogo.TabIndex = 1
        Me.picSchoolLogo.TabStop = False
        '
        'frmLoginPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(718, 432)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.lblPasswordPrompt)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.lblUsernamePrompt)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.picSchoolLogo)
        Me.Controls.Add(Me.lblWelcomeMessage)
        Me.Name = "frmLoginPage"
        Me.Text = "Al Batinah International School Attendance Portal"
        CType(Me.picSchoolLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblWelcomeMessage As System.Windows.Forms.Label
    Friend WithEvents picSchoolLogo As System.Windows.Forms.PictureBox
    Friend WithEvents lblInstructions As System.Windows.Forms.Label
    Friend WithEvents lblUsernamePrompt As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents lblPasswordPrompt As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
