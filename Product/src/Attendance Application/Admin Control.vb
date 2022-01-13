Imports MySql.Data.MySqlClient

Public Class Admin_Control
    Dim MySqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand

    Private Sub btnAddStudents_Click(sender As Object, e As EventArgs) Handles btnAddStudents.Click
        Add_Students_Form.Show()
    End Sub

    Private Sub btnViewStudents_Click(sender As Object, e As EventArgs) Handles btnViewStudents.Click
        View_Students.Show()
    End Sub

    Private Sub btnViewAttendanceRecords_Click(sender As Object, e As EventArgs) Handles btnViewAttendanceRecords.Click
        View_Records.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnViewAttendanceChart_Click(sender As Object, e As EventArgs) Handles btnViewAttendanceChart.Click
        Admin_Attendance_Chart_or_Graph.Show()
    End Sub
End Class