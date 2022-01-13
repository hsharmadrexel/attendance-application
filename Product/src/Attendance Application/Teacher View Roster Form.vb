Imports MySql.Data.MySqlClient

Public Class Teacher_View_Roster_Form
    Dim MySqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnGoBack.Click
        Me.Hide()
    End Sub

    Private Sub Teacher_View_Roster_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.lstGradeLevel.Items.Clear()
        Me.lstStudentFirstName.Items.Clear()
        Me.lstStudentLastName.Items.Clear()
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString =
        "server=127.0.0.1;userid=root;password=rp4hne1234;database=abisattendancesystem"
        Dim Reader As MySqlDataReader

        Try
            MySqlConn.Open()
            Dim Query As String
            If frmLoginPage.txtUsername.Text = "meghankenney" Then
                Query = "select * from abisattendancesystem.greenleopardsroster"
            ElseIf frmLoginPage.txtUsername.Text = "todddavis" Then
                Query = "select * from abisattendancesystem.bluedolphinsroster"
            ElseIf frmLoginPage.txtUsername.Text = "lizjurkowski" Then
                Query = "select * from abisattendancesystem.redfalconsroster"
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
    End Sub
End Class