Imports MySql.Data.MySqlClient

Public Class Teacher_View_Records
    Dim connection As New MySqlConnection("server=127.0.0.1;userid=root;password=rp4hne1234;database=abisattendancesystem")
    Dim MySqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim dbDataSet As New DataTable
    Dim DV As New DataView(dbDataSet)
    Dim SDA As New MySqlDataAdapter
    Dim bSource As New BindingSource
    Dim dbDataSet2 As New DataTable
    Dim count As Integer

    Private Sub btnViewRecords_Click(sender As Object, e As EventArgs) Handles btnViewRecords.Click
        If frmLoginPage.txtUsername.Text = "meghankenney" Then
            dbDataSet.Rows.Clear()
            dbDataSet.Columns.Clear()
            loadtable("Green Leopards")
        ElseIf frmLoginPage.txtUsername.Text = "kirilliwilliams" Then
            dbDataSet.Rows.Clear()
            dbDataSet.Columns.Clear()
            loadtable("Yellow Foxes")
        ElseIf frmLoginPage.txtUsername.Text = "lizjurkowski" Then
            dbDataSet.Rows.Clear()
            dbDataSet.Columns.Clear()
            loadtable("Red Falcons")
        Else
            dbDataSet.Rows.Clear()
            dbDataSet.Columns.Clear()
            loadtable("Blue Dolphins")
        End If
    End Sub

    Private Sub loadtable(ByRef teamname As String)
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString =
        "server=127.0.0.1;userid=root;password=rp4hne1234;database=abisattendancesystem"

        Try
            MySqlConn.Open()
            Dim Query As String

            If teamname = "Green Leopards" Then
                Query = "select * from abisattendancesystem.greenleopardsrecords"
                COMMAND = New MySqlCommand(Query, MySqlConn)
                SDA.SelectCommand = COMMAND
                SDA.Fill(dbDataSet)
                bSource.DataSource = dbDataSet
                DataGridView1.DataSource = bSource
                SDA.Update(dbDataSet)
            ElseIf teamname = "Yellow Foxes" Then
                Query = "select * from abisattendancesystem.yellowfoxesrecords"
                COMMAND = New MySqlCommand(Query, MySqlConn)
                SDA.SelectCommand = COMMAND
                SDA.Fill(dbDataSet)
                bSource.DataSource = dbDataSet
                DataGridView1.DataSource = bSource
                SDA.Update(dbDataSet)
            ElseIf teamname = "Red Falcons" Then
                Query = "select * from abisattendancesystem.redfalconsrecords"
                COMMAND = New MySqlCommand(Query, MySqlConn)
                SDA.SelectCommand = COMMAND
                SDA.Fill(dbDataSet)
                bSource.DataSource = dbDataSet
                DataGridView1.DataSource = bSource
                SDA.Update(dbDataSet)
            Else
                Query = "select * from abisattendancesystem.bluedolphinsrecords"
                COMMAND = New MySqlCommand(Query, MySqlConn)
                SDA.SelectCommand = COMMAND
                SDA.Fill(dbDataSet)
                bSource.DataSource = dbDataSet
                DataGridView1.DataSource = bSource
                SDA.Update(dbDataSet)
            End If

            MySqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MySqlConn.Dispose()
        End Try

        count = 1
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs)
        DataGridView1.Refresh()
    End Sub

    Private Sub btnGoBack_Click(sender As Object, e As EventArgs) Handles btnGoBack.Click
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAttendanceCounts.Click

        If frmLoginPage.txtUsername.Text = "meghankenney" Then
            dbDataSet.Rows.Clear()
            dbDataSet.Columns.Clear()
            loadattendancecount("Green Leopards")
        ElseIf frmLoginPage.txtUsername.Text = "kirilliwilliams" Then
            dbDataSet.Rows.Clear()
            dbDataSet.Columns.Clear()
            loadattendancecount("Yellow Foxes")
        ElseIf frmLoginPage.txtUsername.Text = "lizjurkowski" Then
            dbDataSet.Rows.Clear()
            dbDataSet.Columns.Clear()
            loadattendancecount("Red Falcons")
        Else
            dbDataSet.Rows.Clear()
            dbDataSet.Columns.Clear()
            loadattendancecount("Blue Dolphins")
        End If
    End Sub

    Private Sub loadattendancecount(ByRef teamname As String)

        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString =
        "server=127.0.0.1;userid=root;password=rp4hne1234;database=abisattendancesystem"
        Dim SDA As New MySqlDataAdapter

        Try
            MySqlConn.Open()
            Dim Query As String

            If teamname = "Green Leopards" Then
                Query = "select * from abisattendancesystem.greenleopardsdata"
                COMMAND = New MySqlCommand(Query, MySqlConn)
                SDA.SelectCommand = COMMAND
                SDA.Fill(dbDataSet2)
                bSource.DataSource = dbDataSet2
                DataGridView1.DataSource = bSource
                SDA.Update(dbDataSet2)
            ElseIf teamname = "Yellow Foxes" Then
                Query = "select * from abisattendancesystem.yellowfoxesdata"
                COMMAND = New MySqlCommand(Query, MySqlConn)
                SDA.SelectCommand = COMMAND
                SDA.Fill(dbDataSet2)
                bSource.DataSource = dbDataSet2
                DataGridView1.DataSource = bSource
                SDA.Update(dbDataSet2)
            ElseIf teamname = "Red Falcons" Then
                Query = "select * from abisattendancesystem.redfalconsdata"
                COMMAND = New MySqlCommand(Query, MySqlConn)
                SDA.SelectCommand = COMMAND
                SDA.Fill(dbDataSet2)
                bSource.DataSource = dbDataSet2
                DataGridView1.DataSource = bSource
                SDA.Update(dbDataSet2)
            Else
                Query = "select * from abisattendancesystem.bluedolphinsdata"
                COMMAND = New MySqlCommand(Query, MySqlConn)
                SDA.SelectCommand = COMMAND
                SDA.Fill(dbDataSet2)
                bSource.DataSource = dbDataSet2
                DataGridView1.DataSource = bSource
                SDA.Update(dbDataSet2)
            End If

            MySqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MySqlConn.Dispose()
        End Try

        cmbGradeLevel.Enabled = False

        count = 2
    End Sub

    Private Sub txtFirstName_TextChanged(sender As Object, e As EventArgs) Handles txtFirstName.TextChanged
        If count = 1 Then
            FilterData(txtFirstName.Text)
        ElseIf count = 2 Then
            FilterData2(txtFirstName.Text)
        End If
    End Sub

    Public Sub FilterData(valueToSearch As String)
        Dim searchQuery As String
        If frmLoginPage.txtUsername.Text = "todddavis" Then
            searchQuery = "SELECT * From bluedolphinsrecords WHERE CONCAT(idbluedolphinsrecords, Date, StudentFirstName, StudentLastName, GradeLevel, AttendanceRecorded, Comments) like '%" & valueToSearch & "%'"
        ElseIf frmLoginPage.txtUsername.Text = "meghankenney" Then
            searchQuery = "SELECT * From greenleopardsrecords WHERE CONCAT(idgreenleopardsrecords, Date, StudentFirstName, StudentLastName, GradeLevel, AttendanceRecorded, Comments) like '%" & valueToSearch & "%'"
        ElseIf frmLoginPage.txtUsername.Text = "lizjurkowski" Then
            searchQuery = "SELECT * From redfalconsrecords WHERE CONCAT(idredfalconsrecords, Date, StudentFirstName, StudentLastName, GradeLevel, AttendanceRecorded, Comments) like '%" & valueToSearch & "%'"
        ElseIf frmLoginPage.txtUsername.Text = "kirilliwilliams" Then
            searchQuery = "SELECT * From yellowfoxesrecords WHERE CONCAT(idyellowfoxesrecords, Date, StudentFirstName, StudentLastName, GradeLevel, AttendanceRecorded, Comments) like '%" & valueToSearch & "%'"
        End If

        Dim command As New MySqlCommand(searchQuery, connection)
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        DataGridView1.DataSource = table
    End Sub

    Public Sub FilterData2(valueToSearch As String)
        Dim searchQuery As String

        If frmLoginPage.txtUsername.Text = "todddavis" Then
            searchQuery = "SELECT * From bluedolphinsdata WHERE CONCAT(idbluedolphinsdata, StudentFirstName, StudentLastName, DaysPresent, DaysAbsent, DaysLate) like '%" & valueToSearch & "%'"
        ElseIf frmLoginPage.txtUsername.Text = "meghankenney" Then
            searchQuery = "SELECT * From greenleopardsdata WHERE CONCAT(idgreenleopardsdata, StudentFirstName, StudentLastName, DaysPresent, DaysAbsent, DaysLate) like '%" & valueToSearch & "%'"
        ElseIf frmLoginPage.txtUsername.Text = "lizjurkowski" Then
            searchQuery = "SELECT * From redfalconsdata WHERE CONCAT(idredfalconsdata, StudentFirstName, StudentLastName, DaysPresent, DaysAbsent, DaysLate) like '%" & valueToSearch & "%'"
        ElseIf frmLoginPage.txtUsername.Text = "kirilliwilliams" Then
            searchQuery = "SELECT * From yellowfoxesdata WHERE CONCAT(idyellowfoxesdata, StudentFirstName, StudentLastName, DaysPresent, DaysAbsent, DaysLate) like '%" & valueToSearch & "%'"
        End If

        Dim command As New MySqlCommand(searchQuery, connection)
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        DataGridView1.DataSource = table
    End Sub

    Private Sub Teacher_View_Records_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FilterData("")
        Button1.Enabled = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Report_Viewer_and_Generator.Show()
    End Sub
End Class