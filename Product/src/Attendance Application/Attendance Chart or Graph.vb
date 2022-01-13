Imports MySql.Data.MySqlClient
Public Class Attendance_Chart_or_Graph
    Dim MySqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim dbDataSet As New DataTable

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub

    Private Sub Attendance_Chart_or_Graph_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadChart()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
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

        If frmLoginPage.txtUsername.Text = "meghankenney" Then
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
        ElseIf frmLoginPage.txtUsername.Text = "lizjurkowski" Then
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
        ElseIf frmLoginPage.txtUsername.Text = "todddavis" Then
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
        ElseIf frmLoginPage.txtUsername.Text = "kirilliwilliams" Then
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

    Private Sub ExitApplicationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitApplicationToolStripMenuItem.Click
        Dim result = MessageBox.Show(" Are you sure you want to quit?", "Are you sure?", MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub AboutApplicationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutApplicationToolStripMenuItem.Click
        About_Application.Show()
    End Sub

    Private Sub PrintFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintFormToolStripMenuItem.Click
       
    End Sub
End Class