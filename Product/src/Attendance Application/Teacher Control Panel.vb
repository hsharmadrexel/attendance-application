Public Class Teacher_Control_Panel

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub Teacher_Control_Panel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If frmLoginPage.txtUsername.Text = "meghankenney" Then
            Me.lblWelcomeMessage.Text = "Welcome Meghan Kenney!"
        ElseIf frmLoginPage.txtUsername.Text = "todddavis" Then
            Me.lblWelcomeMessage.Text = "Welcome Todd Davis!"
        ElseIf frmLoginPage.txtUsername.Text = "lizjurkowski" Then
            Me.lblWelcomeMessage.Text = "Welcome Liz Jurkowski!"
        Else
            Me.lblWelcomeMessage.Text = "Welcome Kirilli Williams!"
        End If
    End Sub

    Private Sub btnTakeAttendance_Click(sender As Object, e As EventArgs) Handles btnTakeAttendance.Click
        If frmLoginPage.txtUsername.Text = "meghankenney" Then
            greenteamlogin("Meghan Kenney")
        End If

        If frmLoginPage.txtUsername.Text = "todddavis" Then
            blueteamlogin("Todd Davis")
        End If

        If frmLoginPage.txtUsername.Text = "lizjurkowski" Then
            redteamlogin("Liz Jurkowski")
        End If

        If frmLoginPage.txtUsername.Text = "kirilliwilliams" Then
            yellowteamlogin("Kirilli Williams")
        End If
    End Sub

    Private Sub greenteamlogin(ByRef name As String)
        Green_Team_Attendance_Form.Text = "Main Form - Welcome " & name
        Green_Team_Attendance_Form.lblWelcomeMessage.Text = "Welcome " & name & "!"
        Green_Team_Attendance_Form.Show()
    End Sub

    Private Sub redteamlogin(ByRef name As String)
        Red_Team_Attendance_Form.Text = "Main Form - Welcome " & name
        Red_Team_Attendance_Form.lblWelcomeMessage.Text = "Welcome " & name & "!"
        Red_Team_Attendance_Form.Show()
    End Sub

    Private Sub blueteamlogin(ByRef name As String)
        Blue_Team_Attendance_Form.Text = "Main Form - Welcome " & name
        Blue_Team_Attendance_Form.lblWelcomeMessage.Text = "Welcome " & name & "!"
        Blue_Team_Attendance_Form.Show()
    End Sub

    Private Sub yellowteamlogin(ByRef name As String)
        Yellow_Team_Attendance_Form.Text = "Main Form - Welcome " & name
        Yellow_Team_Attendance_Form.lblWelcomeMessage.Text = "Welcome " & name & "!"
        Yellow_Team_Attendance_Form.Show()
    End Sub

    Private Sub btnViewRoster_Click(sender As Object, e As EventArgs) Handles btnViewRoster.Click
        Teacher_View_Roster_Form.Show()
    End Sub

    Private Sub btnViewAttendanceRecords_Click(sender As Object, e As EventArgs) Handles btnViewAttendanceRecords.Click
        Teacher_View_Records.Show()
    End Sub

    Private Sub btnViewAttendanceChart_Click(sender As Object, e As EventArgs) Handles btnViewAttendanceChart.Click
        Attendance_Chart_or_Graph.Show()
    End Sub
End Class