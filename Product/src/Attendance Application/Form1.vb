Imports MySql.Data.MySqlClient
Public Class frmLoginPage
    Dim MySqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString =
        "server=127.0.0.1;userid=root;password=rp4hne1234;database=abisattendancesystem"
        Dim Reader As MySqlDataReader

        Try
            MySqlConn.Open()
            Dim Query As String
            Query = "select * from abisattendancesystem.logininformation where Username ='" & txtUsername.Text & "' and password='" & txtPassword.Text & "'"
            COMMAND = New MySqlCommand(Query, MySqlConn)
            Reader = COMMAND.ExecuteReader
            Dim count As Integer

            While Reader.Read
                count = count + 1
            End While

            If count = 1 Then
                If txtUsername.Text = "lizjurkowski" Then
                    Teacher_Control_Panel.Show()
                    Me.Hide()
                ElseIf txtUsername.Text = "meghankenney" Then
                    Teacher_Control_Panel.Show()
                    Me.Hide()
                ElseIf txtUsername.Text = "todddavis" Then
                    Teacher_Control_Panel.Show()
                    Me.Hide()
                ElseIf txtUsername.Text = "kirilliwilliams" Then
                    Teacher_Control_Panel.Show()
                    Me.Hide()
                ElseIf txtUsername.Text = "atulalex" Then
                    Admin_Control.Show()
                    Me.Hide()
                End If
            ElseIf count > 1 Then
                MessageBox.Show("Duplicate login")
            Else
                MessageBox.Show("Incorrect username or password. Please try again")
            End If

            MySqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MySqlConn.Dispose()
        End Try

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub frmLoginPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnLogin.Enabled = False
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        If txtPassword.Text = Nothing Then
            btnLogin.Enabled = False
        ElseIf txtUsername.Text = Nothing Then
            btnLogin.Enabled = False
        Else
            btnLogin.Enabled = True
        End If
    End Sub
End Class
