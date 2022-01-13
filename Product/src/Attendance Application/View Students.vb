Imports MySql.Data.MySqlClient

Public Class View_Students
    Dim MySqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Private Sub btnViewRoster_Click(sender As Object, e As EventArgs) Handles btnViewRoster.Click
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString =
        "server=127.0.0.1;userid=root;password=rp4hne1234;database=abisattendancesystem"
        Dim Reader As MySqlDataReader

        Try
            MySqlConn.Open()
            Dim Query As String
            If cmbTeamGroup.SelectedItem = "Green Leopards" Then
                Query = "select * from abisattendancesystem.greenleopardsroster"
            ElseIf cmbTeamGroup.SelectedItem = "Blue Dolphins" Then
                Query = "select * from abisattendancesystem.bluedolphinsroster"
            ElseIf cmbTeamGroup.SelectedItem = "Red Falcons" Then
                Query = "select * from abisattendancesystem.redfalconsroster"
            ElseIf cmbTeamGroup.SelectedItem = Nothing Then
                MessageBox.Show("Please choose a team group. This is a required field")
            Else
                Query = "select * from abisattendancesystem.yellowfoxesroster"
            End If

            COMMAND = New MySqlCommand(Query, MySqlConn)
            Reader = COMMAND.ExecuteReader
            While Reader.Read
                Dim fName = Reader.GetString("StudentFirstName")
                Dim sName = Reader.GetString("StudentLastName")
                Dim gLevel = Reader.GetString("GradeLevel")
                lstStudentFirstName.Items.Add(fName)
                lstStudentLastName.Items.Add(sName)
                lstGradeLevel.Items.Add(gLevel)
            End While

            MySqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MySqlConn.Dispose()
        End Try

        btnViewRoster.Enabled = False
    End Sub

    Private Sub cmbTeamGroup_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTeamGroup.SelectedIndexChanged
        Me.lstGradeLevel.Items.Clear()
        Me.lstStudentFirstName.Items.Clear()
        Me.lstStudentLastName.Items.Clear()
        btnViewRoster.Enabled = True
    End Sub

    Private Sub btnGoBack_Click(sender As Object, e As EventArgs) Handles btnGoBack.Click
        Me.Hide()
    End Sub
End Class