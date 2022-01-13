Imports MySql.Data.MySqlClient
Public Class View_Records
    Dim MySqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim dbDataSet As New DataTable
    Dim DV As New DataView(dbDataSet)

    Private Sub cmbTeamName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTeamName.SelectedIndexChanged
        Me.txtFirstName.Text = Nothing
        Me.txtLastName.Text = Nothing
        Me.cmbGradeLevel.SelectedItem = Nothing

        If Me.cmbTeamName.SelectedItem = "Green Leopards" Then
            dbDataSet.Rows.Clear()
            dbDataSet.Columns.Clear()
            loadtable("Green Leopards")
        ElseIf Me.cmbTeamName.SelectedItem = "Yellow Foxes" Then
            dbDataSet.Rows.Clear()
            dbDataSet.Columns.Clear()
            loadtable("Yellow Foxes")
        ElseIf Me.cmbTeamName.SelectedItem = "Red Falcons" Then
            dbDataSet.Rows.Clear()
            dbDataSet.Columns.Clear()
            loadtable("Red Falcons")
        Else
            dbDataSet.Rows.Clear()
            dbDataSet.Columns.Clear()
            loadtable("Blue Dolphins")
        End If

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        DataGridView1.Refresh()
    End Sub

    Private Sub loadtable(ByRef teamname As String)
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString =
        "server=127.0.0.1;userid=root;password=rp4hne1234;database=abisattendancesystem"
        Dim SDA As New MySqlDataAdapter
        Dim bSource As New BindingSource

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
    End Sub

    Private Sub txtFirstName_TextChanged(sender As Object, e As EventArgs) Handles txtFirstName.TextChanged
        DV.RowFilter = String.Format("StudentFirstName Like '%{0}%'", txtFirstName.Text)
        DataGridView1.DataSource = DV
    End Sub

    Private Sub txtLastName_TextChanged(sender As Object, e As EventArgs) Handles txtLastName.TextChanged
        DV.RowFilter = String.Format("StudentLastName Like '%{0}%'", txtLastName.Text)
        DataGridView1.DataSource = DV
    End Sub

    Private Sub cmbGradeLevel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbGradeLevel.SelectedIndexChanged
        Select Case cmbGradeLevel.SelectedItem
            Case Is = "7"
                DV.RowFilter = String.Format("GradeLevel = '{0}'", 7)
                DataGridView1.DataSource = DV
            Case Is = "8"
                DV.RowFilter = String.Format("GradeLevel = '{0}'", 8)
                DataGridView1.DataSource = DV
            Case Is = "9"
                DV.RowFilter = String.Format("GradeLevel = '{0}'", 9)
                DataGridView1.DataSource = DV
            Case Is = "10"
                DV.RowFilter = String.Format("GradeLevel = '{0}'", 10)
                DataGridView1.DataSource = DV
            Case Is = "11"
                DV.RowFilter = String.Format("GradeLevel = '{0}'", 11)
                DataGridView1.DataSource = DV
            Case Is = "12"
                DV.RowFilter = String.Format("GradeLevel = '{0}'", 12)
                DataGridView1.DataSource = DV
        End Select
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAttendanceCounts.Click
        Me.txtFirstName.Text = Nothing
        Me.txtLastName.Text = Nothing
        Me.cmbGradeLevel.SelectedItem = Nothing

        If Me.cmbTeamName.SelectedItem = "Green Leopards" Then
            dbDataSet.Rows.Clear()
            dbDataSet.Columns.Clear()
            attendanceloadtable("Green Leopards")
        ElseIf Me.cmbTeamName.SelectedItem = "Yellow Foxes" Then
            dbDataSet.Rows.Clear()
            dbDataSet.Columns.Clear()
            attendanceloadtable("Yellow Foxes")
        ElseIf Me.cmbTeamName.SelectedItem = "Red Falcons" Then
            dbDataSet.Rows.Clear()
            dbDataSet.Columns.Clear()
            attendanceloadtable("Red Falcons")
        Else
            dbDataSet.Rows.Clear()
            dbDataSet.Columns.Clear()
            attendanceloadtable("Blue Dolphins")
        End If
    End Sub

    Private Sub attendanceloadtable(ByRef teamname As String)
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString =
        "server=127.0.0.1;userid=root;password=rp4hne1234;database=abisattendancesystem"
        Dim SDA As New MySqlDataAdapter
        Dim bSource As New BindingSource

        Try
            MySqlConn.Open()
            Dim Query As String

            If teamname = "Green Leopards" Then
                Query = "select * from abisattendancesystem.greenleopardsdata"
                COMMAND = New MySqlCommand(Query, MySqlConn)
                SDA.SelectCommand = COMMAND
                SDA.Fill(dbDataSet)
                bSource.DataSource = dbDataSet
                DataGridView1.DataSource = bSource
                SDA.Update(dbDataSet)
            ElseIf teamname = "Yellow Foxes" Then
                Query = "select * from abisattendancesystem.yellowfoxesdata"
                COMMAND = New MySqlCommand(Query, MySqlConn)
                SDA.SelectCommand = COMMAND
                SDA.Fill(dbDataSet)
                bSource.DataSource = dbDataSet
                DataGridView1.DataSource = bSource
                SDA.Update(dbDataSet)
            ElseIf teamname = "Red Falcons" Then
                Query = "select * from abisattendancesystem.redfalconsdata"
                COMMAND = New MySqlCommand(Query, MySqlConn)
                SDA.SelectCommand = COMMAND
                SDA.Fill(dbDataSet)
                bSource.DataSource = dbDataSet
                DataGridView1.DataSource = bSource
                SDA.Update(dbDataSet)
            Else
                Query = "select * from abisattendancesystem.bluedolphinsdata"
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

        cmbGradeLevel.Enabled = False
    End Sub

    Private Sub btnGoBack_Click(sender As Object, e As EventArgs) Handles btnGoBack.Click
        Me.Hide()
    End Sub
End Class