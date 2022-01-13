Imports MySql.Data.MySqlClient
Public Class Add_Students_Form
    Dim MySqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand

    Private Sub btnAddStudent_Click(sender As Object, e As EventArgs) Handles btnAddStudent.Click
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString =
        "server=127.0.0.1;userid=root;password=rp4hne1234;database=abisattendancesystem"
        Dim Reader As MySqlDataReader

        Try
            MySqlConn.Open()
            Dim Query As String

            If cmbTeamNameInput.SelectedItem = "Green Leopards" Then
                Query = "insert into abisattendancesystem.greenleopardsroster(idgreenleopardsroster,StudentFirstName,StudentLastName,GradeLevel) values ('" & txtStudentIDInput.Text & "','" & txtStudentFirstNameInput.Text & "','" & txtStudentLastNameInput.Text & "','" & txtGradeLevelInput.Text & "')"
            ElseIf cmbTeamNameInput.SelectedItem = "Yellow Foxes" Then
                Query = "insert into abisattendancesystem.yellowfoxesroster(idyellowfoxesroster,StudentFirstName,StudentLastName,GradeLevel) values ('" & txtStudentIDInput.Text & "','" & txtStudentFirstNameInput.Text & "','" & txtStudentLastNameInput.Text & "','" & txtGradeLevelInput.Text & "')"
            ElseIf cmbTeamNameInput.SelectedItem = "Red Falcons" Then
                Query = "insert into abisattendancesystem.redfalconsroster(idredfalconsroster,StudentFirstName,StudentLastName,GradeLevel) values ('" & txtStudentIDInput.Text & "','" & txtStudentFirstNameInput.Text & "','" & txtStudentLastNameInput.Text & "','" & txtGradeLevelInput.Text & "')"
            Else
                Query = "insert into abisattendancesystem.bluedolphinsroster(idbluedolphinsroster,StudentFirstName,StudentLastName,GradeLevel) values ('" & txtStudentIDInput.Text & "','" & txtStudentFirstNameInput.Text & "','" & txtStudentLastNameInput.Text & "','" & txtGradeLevelInput.Text & "')"
            End If

            If cmbTeamNameInput.SelectedItem = "" Then
                MessageBox.Show("Please select the team for the student")
            ElseIf txtGradeLevelInput.Text = Nothing Or txtStudentFirstNameInput.Text = Nothing Or txtStudentIDInput.Text = Nothing Or txtStudentLastNameInput.Text = Nothing Then
                MessageBox.Show("Please enter all of the required details")
            End If

            COMMAND = New MySqlCommand(Query, MySqlConn)
            Reader = COMMAND.ExecuteReader

            MessageBox.Show("New Student Added Successfully!")
            Call ClearEntries()

            MySqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MySqlConn.Dispose()
        End Try
    End Sub

    Private Sub ClearEntries()
        txtGradeLevelInput.Text = Nothing
        txtStudentIDInput.Text = Nothing
        txtStudentFirstNameInput.Text = Nothing
        txtStudentLastNameInput.Text = Nothing
        cmbTeamNameInput.SelectedItem = Nothing
    End Sub

    Private Sub btnGoBack_Click(sender As Object, e As EventArgs) Handles btnGoBack.Click
        Me.Close()
    End Sub
End Class