Imports MySql.Data.MySqlClient

Public Class Admin_Attendance_Chart_or_Graph
    Dim MySqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim dbDataSet As New DataTable

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Chart1.Series(0).Points.Clear()
        LoadChart()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub cmbTeamName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTeamName.SelectedIndexChanged
        Chart1.Series(0).Points.Clear()
        LoadChart()
    End Sub

    Private Sub LoadChart()
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString =
        "server=127.0.0.1;userid=root;password=rp4hne1234;database=abisattendancesystem"
        Dim SDA As New MySqlDataAdapter
        Dim bSource As New BindingSource
        Dim READER As MySqlDataReader

        If cmbTeamName.SelectedItem = "Green Leopards" Then
            Try
                MySqlConn.Open()
                Dim Query As String
                Query = "select * from abisattendancesystem.greenleopardsdata"
                COMMAND = New MySqlCommand(Query, MySqlConn)
                READER = COMMAND.ExecuteReader()

                While READER.Read
                    Chart1.Series("Name_vs_DaysPresent").Points.AddXY(READER.GetString("StudentFirstName"), READER.GetInt32("DaysPresent"))
                End While
                MySqlConn.Close()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                MySqlConn.Dispose()
            End Try
        ElseIf cmbTeamName.SelectedItem = "Red Falcons" Then
            Try
                MySqlConn.Open()
                Dim Query As String
                Query = "select * from abisattendancesystem.redfalconsdata"
                COMMAND = New MySqlCommand(Query, MySqlConn)
                READER = COMMAND.ExecuteReader()

                While READER.Read
                    Chart1.Series("Name_vs_DaysPresent").Points.AddXY(READER.GetString("StudentFirstName"), READER.GetInt32("DaysPresent"))
                End While
                MySqlConn.Close()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                MySqlConn.Dispose()
            End Try
        ElseIf cmbTeamName.SelectedItem = "Blue Dolphins" Then
            Try
                MySqlConn.Open()
                Dim Query As String
                Query = "select * from abisattendancesystem.bluedolphinsdata"
                COMMAND = New MySqlCommand(Query, MySqlConn)
                READER = COMMAND.ExecuteReader()

                While READER.Read
                    Chart1.Series("Name_vs_DaysPresent").Points.AddXY(READER.GetString("StudentFirstName"), READER.GetInt32("DaysPresent"))
                End While
                MySqlConn.Close()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                MySqlConn.Dispose()
            End Try
        ElseIf cmbTeamName.SelectedItem = "Yellow Foxes" Then
            Try
                MySqlConn.Open()
                Dim Query As String
                Query = "select * from abisattendancesystem.yellowfoxesdata"
                COMMAND = New MySqlCommand(Query, MySqlConn)
                READER = COMMAND.ExecuteReader()

                While READER.Read
                    Chart1.Series("Name_vs_DaysPresent").Points.AddXY(READER.GetString("StudentFirstName"), READER.GetInt32("DaysPresent"))
                End While
                MySqlConn.Close()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                MySqlConn.Dispose()
            End Try
        End If
    End Sub
End Class