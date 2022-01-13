Imports MySql.Data.MySqlClient

Public Class Yellow_Team_Attendance_Form
    Dim yellowteamstudents(15) As String
    Dim MySqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim COMMAND1 As MySqlCommand
    Dim COMMAND2 As MySqlCommand
    Dim COMMAND3 As MySqlCommand
    Dim COMMAND4 As MySqlCommand

    Private Sub btnDisplayRoster_Click(sender As Object, e As EventArgs) Handles btnDisplayRoster.Click
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString =
        "server=127.0.0.1;userid=root;password=rp4hne1234;database=abisattendancesystem"
        Dim Reader As MySqlDataReader

        Try
            MySqlConn.Open()
            Dim Query As String
            Query = "select * from abisattendancesystem.yellowfoxesroster"

            COMMAND = New MySqlCommand(Query, MySqlConn)
            Reader = COMMAND.ExecuteReader
            While Reader.Read
                Dim fName = Reader.GetString("StudentFirstName")
                Dim sName = Reader.GetString("StudentLastName")
                lstStudents.Items.Add(sName & ", " & fName)
                lstStudents.Items.Add("")
            End While

            MySqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MySqlConn.Dispose()
        End Try

        btnDisplayRoster.Enabled = False
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Me.lstStudents.Items.Clear()
        btnDisplayRoster.Enabled = True
    End Sub

    Private Sub Blue_Team_Attendance_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.Value = DateTime.Now
        yellowteamstudents(0) = "Al Balushi, Noaf"
        yellowteamstudents(1) = "Al Balushi, Taif"
        yellowteamstudents(2) = "Al Zefeiti, Sultan"
        yellowteamstudents(3) = "Al-Maqbali, Aisha"
        yellowteamstudents(4) = "Al-Shibli, Shamma"
        yellowteamstudents(5) = "Al-Shibli, Saif"
        yellowteamstudents(6) = "Chetty, Tahlyn"
        yellowteamstudents(7) = "De Vera, Trina"
        yellowteamstudents(8) = "Govender, Shalin"
        yellowteamstudents(9) = "Nolido, Christine"
        yellowteamstudents(10) = "Panogalinog, Lexia"
        yellowteamstudents(11) = "Rahim, Hannah"
        yellowteamstudents(12) = "Tiriveedhi, Teja"
        yellowteamstudents(13) = "Tomalin, David"
        yellowteamstudents(14) = "Watts, Alex"
        yellowteamstudents(15) = "Willis, Hannah"

        Me.cmbAddtoAll.Items.Add("Present")
        Me.cmbAddtoAll.Items.Add("Absent")
        Me.cmbAddtoAll.Items.Add("Late")
    End Sub

    Private Sub btnAssigntoAll_Click(sender As Object, e As EventArgs) Handles btnAssigntoAll.Click
        If Me.cmbAddtoAll.SelectedItem = "Present" Then
            Me.radPresentNoafAlBalushi.Checked = True
            Me.radPresentTaifAlBalushi.Checked = True
            Me.radPresentSultanAlZefeiti.Checked = True
            Me.radPresentAishaAlMaqbali.Checked = True
            Me.radPresentShammaAlShibli.Checked = True
            Me.radPresentSaifAlShibli.Checked = True
            Me.radPresentTahlynChetty.Checked = True
            Me.radPresentTrinaDeVera.Checked = True
            Me.radPresentShalinGovender.Checked = True
            Me.radPresentChristineNolido.Checked = True
            Me.radPresentLexiaPanogalinog.Checked = True
            Me.radPresentHannahRahim.Checked = True
            Me.radPresentTejaTiriveedhi.Checked = True
            Me.radPresentDavidTomalin.Checked = True
            Me.radPresentAlexWatts.Checked = True
            Me.radPresentHannahWillis.Checked = True
        ElseIf Me.cmbAddtoAll.SelectedItem = "Absent" Then
            Me.radAbsentNoafAlBalushi.Checked = True
            Me.radAbsentTaifAlBalushi.Checked = True
            Me.radAbsentSultanAlZefeiti.Checked = True
            Me.radAbsentAishaAlMaqbali.Checked = True
            Me.radAbsentShammaAlShibli.Checked = True
            Me.radAbsentSaifAlShibli.Checked = True
            Me.radAbsentTahlynChetty.Checked = True
            Me.radAbsentTrinaDeVera.Checked = True
            Me.radAbsentShalinGovender.Checked = True
            Me.radAbsentChristineNolido.Checked = True
            Me.radAbsentLexiaPanogalinog.Checked = True
            Me.radAbsentHannahRahim.Checked = True
            Me.radAbsentTejaTiriveedhi.Checked = True
            Me.radAbsentDavidTomalin.Checked = True
            Me.radAbsentAlexWatts.Checked = True
            Me.radAbsentHannahWillis.Checked = True
        ElseIf Me.cmbAddtoAll.SelectedItem = "Late" Then
            Me.radLateNoafAlBalushi.Checked = True
            Me.radLateTaifAlBalushi.Checked = True
            Me.radLateSultanAlZefeiti.Checked = True
            Me.radLateAishaAlMaqbali.Checked = True
            Me.radLateShammaAlShibli.Checked = True
            Me.radLateSaifAlShibli.Checked = True
            Me.radLateTahlynChetty.Checked = True
            Me.radLateTrinaDeVera.Checked = True
            Me.radLateShalinGovender.Checked = True
            Me.radLateChristineNolido.Checked = True
            Me.radLateLexiaPanogalinog.Checked = True
            Me.radLateHannahRahim.Checked = True
            Me.radLateTejaTiriveedhi.Checked = True
            Me.radLateDavidTomalin.Checked = True
            Me.radLateAlexWatts.Checked = True
            Me.radLateHannahWillis.Checked = True
        End If
    End Sub

    Private Sub lstStudents_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstStudents.SelectedIndexChanged
        picStudentPicture.Enabled = True

        If lstStudents.SelectedItem = yellowteamstudents(0) Then
            lblStudentName.Text = "Noaf Al Balushi"
            lblStudentGrade.Text = "7"
            Me.picStudentPicture.Image = My.Resources.Noaf_Al_Balushi
        ElseIf lstStudents.SelectedItem = yellowteamstudents(1) Then
            lblStudentName.Text = "Taif Al Balushi"
            Me.picStudentPicture.Image = My.Resources.Taif_Al_Balushi
            lblStudentGrade.Text = "9"
        ElseIf lstStudents.SelectedItem = yellowteamstudents(2) Then
            lblStudentName.Text = "Sultan Al Zefeiti"
            Me.picStudentPicture.Image = My.Resources.Sultan_Al_Zefeiti
            lblStudentGrade.Text = "7"
        ElseIf lstStudents.SelectedItem = yellowteamstudents(3) Then
            lblStudentName.Text = "Aisha Al-Maqbali"
            Me.picStudentPicture.Image = My.Resources.Aisha_Al_Maqbali
            lblStudentGrade.Text = "12"
        ElseIf lstStudents.SelectedItem = yellowteamstudents(4) Then
            Me.picStudentPicture.Image = My.Resources.Shamma_Al_Shibli
            lblStudentName.Text = "Shamma Al-Shibli"
            lblStudentGrade.Text = "9"
        ElseIf lstStudents.SelectedItem = yellowteamstudents(5) Then
            Me.picStudentPicture.Image = My.Resources.Saif_Al_Shibli
            lblStudentName.Text = "Saif Al-Shibli"
            lblStudentGrade.Text = "10"
        ElseIf lstStudents.SelectedItem = yellowteamstudents(6) Then
            Me.picStudentPicture.Image = My.Resources.Tahlyn_Chetty
            lblStudentName.Text = "Tahlyn Chetty"
            lblStudentGrade.Text = "8"
        ElseIf lstStudents.SelectedItem = yellowteamstudents(7) Then
            Me.picStudentPicture.Image = My.Resources.Trina_De_Vera
            lblStudentName.Text = "Trina De Vera"
            lblStudentGrade.Text = "8"
        ElseIf lstStudents.SelectedItem = yellowteamstudents(8) Then
            Me.picStudentPicture.Image = My.Resources.Shalin_Govender
            lblStudentName.Text = "Shalin Govender"
            lblStudentGrade.Text = "10"
        ElseIf lstStudents.SelectedItem = yellowteamstudents(9) Then
            Me.picStudentPicture.Image = My.Resources.Christine_Nolido
            lblStudentName.Text = "Christine Nolido"
            lblStudentGrade.Text = "10"
        ElseIf lstStudents.SelectedItem = yellowteamstudents(10) Then
            Me.picStudentPicture.Image = Nothing
            lblStudentName.Text = "Lexia Panogalinog"
            lblStudentGrade.Text = "8"
        ElseIf lstStudents.SelectedItem = yellowteamstudents(11) Then
            Me.picStudentPicture.Image = Nothing
            lblStudentName.Text = "Hannah Rahim"
            lblStudentGrade.Text = "7"
        ElseIf lstStudents.SelectedItem = yellowteamstudents(12) Then
            Me.picStudentPicture.Image = My.Resources.Teja_Tiriveedhi
            lblStudentName.Text = "Teja Tiriveedhi"
            lblStudentGrade.Text = "12"
        ElseIf lstStudents.SelectedItem = yellowteamstudents(13) Then
            Me.picStudentPicture.Image = My.Resources.David_Tomalin
            lblStudentName.Text = "David Tomalin"
            lblStudentGrade.Text = "11"
        ElseIf lstStudents.SelectedItem = yellowteamstudents(14) Then
            Me.picStudentPicture.Image = My.Resources.Alex_Watts
            lblStudentName.Text = "Alex Watts"
            lblStudentGrade.Text = "12"
        ElseIf lstStudents.SelectedItem = yellowteamstudents(15) Then
            Me.picStudentPicture.Image = My.Resources.Hannah_Willis
            lblStudentName.Text = "Hannah Willis"
            lblStudentGrade.Text = "9"
        End If
    End Sub

    Public Sub ClearorReset()
        Me.radPresentNoafAlBalushi.Checked = False
        Me.radPresentTaifAlBalushi.Checked = False
        Me.radPresentSultanAlZefeiti.Checked = False
        Me.radPresentAishaAlMaqbali.Checked = False
        Me.radPresentShammaAlShibli.Checked = False
        Me.radPresentSaifAlShibli.Checked = False
        Me.radPresentTahlynChetty.Checked = False
        Me.radPresentTrinaDeVera.Checked = False
        Me.radPresentShalinGovender.Checked = False
        Me.radPresentChristineNolido.Checked = False
        Me.radPresentLexiaPanogalinog.Checked = False
        Me.radPresentHannahRahim.Checked = False
        Me.radPresentTejaTiriveedhi.Checked = False
        Me.radPresentDavidTomalin.Checked = False
        Me.radPresentAlexWatts.Checked = False
        Me.radPresentHannahWillis.Checked = False

        Me.radAbsentNoafAlBalushi.Checked = False
        Me.radAbsentTaifAlBalushi.Checked = False
        Me.radAbsentSultanAlZefeiti.Checked = False
        Me.radAbsentAishaAlMaqbali.Checked = False
        Me.radAbsentShammaAlShibli.Checked = False
        Me.radAbsentSaifAlShibli.Checked = False
        Me.radAbsentTahlynChetty.Checked = False
        Me.radAbsentTrinaDeVera.Checked = False
        Me.radAbsentShalinGovender.Checked = False
        Me.radAbsentChristineNolido.Checked = False
        Me.radAbsentLexiaPanogalinog.Checked = False
        Me.radAbsentHannahRahim.Checked = False
        Me.radAbsentTejaTiriveedhi.Checked = False
        Me.radAbsentDavidTomalin.Checked = False
        Me.radAbsentAlexWatts.Checked = False
        Me.radAbsentHannahWillis.Checked = False

        Me.radLateNoafAlBalushi.Checked = False
        Me.radLateTaifAlBalushi.Checked = False
        Me.radLateSultanAlZefeiti.Checked = False
        Me.radLateAishaAlMaqbali.Checked = False
        Me.radLateShammaAlShibli.Checked = False
        Me.radLateSaifAlShibli.Checked = False
        Me.radLateTahlynChetty.Checked = False
        Me.radLateTrinaDeVera.Checked = False
        Me.radLateShalinGovender.Checked = False
        Me.radLateChristineNolido.Checked = False
        Me.radLateLexiaPanogalinog.Checked = False
        Me.radLateHannahRahim.Checked = False
        Me.radLateTejaTiriveedhi.Checked = False
        Me.radLateDavidTomalin.Checked = False
        Me.radLateAlexWatts.Checked = False
        Me.radLateHannahWillis.Checked = False

        Me.txtNoafAlBalushiRemarks.Text = Nothing
        Me.txtTaifAlBalushiRemarks.Text = Nothing
        Me.txtSultanAlZefeitiRemarks.Text = Nothing
        Me.txtAishaAlMaqbaliRemarks.Text = Nothing
        Me.txtShammaAlShibliRemarks.Text = Nothing
        Me.txtSaifAlShibliRemarks.Text = Nothing
        Me.txtTahlynChettyRemarks.Text = Nothing
        Me.txtTrinaDeVeraRemarks.Text = Nothing
        Me.txtShalinGovenderRemarks.Text = Nothing
        Me.txtChristineNolidoRemarks.Text = Nothing
        Me.txtLexiaPanogalinogRemarks.Text = Nothing
        Me.txtHannahRahimRemarks.Text = Nothing
        Me.txtTejaTiriveedhiRemarks.Text = Nothing
        Me.txtDavidTomalinRemarks.Text = Nothing
        Me.txtAlexWattsRemarks.Text = Nothing
        Me.txtHannahWillisRemarks.Text = Nothing

        Me.picStudentPicture.Image = Nothing
        Me.lblStudentName.Text = Nothing
        Me.lblStudentGrade.Text = Nothing
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Call ClearorReset()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString =
        "server=127.0.0.1;userid=root;password=rp4hne1234;database=abisattendancesystem"
        Dim Reader As MySqlDataReader
        Dim attendancerecorded(15) As String

        If Me.radPresentNoafAlBalushi.Checked = True Then
            attendancerecorded(0) = "Present"
        ElseIf Me.radAbsentNoafAlBalushi.Checked = True Then
            attendancerecorded(0) = "Absent"
        ElseIf Me.radLateNoafAlBalushi.Checked = True Then
            attendancerecorded(0) = "Late"
        End If

        If Me.radPresentTaifAlBalushi.Checked = True Then
            attendancerecorded(1) = "Present"
        ElseIf Me.radAbsentTaifAlBalushi.Checked = True Then
            attendancerecorded(1) = "Absent"
        ElseIf Me.radLateTaifAlBalushi.Checked = True Then
            attendancerecorded(1) = "Late"
        End If

        If Me.radPresentSultanAlZefeiti.Checked = True Then
            attendancerecorded(2) = "Present"
        ElseIf Me.radAbsentSultanAlZefeiti.Checked = True Then
            attendancerecorded(2) = "Absent"
        ElseIf Me.radLateSultanAlZefeiti.Checked = True Then
            attendancerecorded(2) = "Late"
        End If

        If Me.radPresentAishaAlMaqbali.Checked = True Then
            attendancerecorded(3) = "Present"
        ElseIf Me.radAbsentAishaAlMaqbali.Checked = True Then
            attendancerecorded(3) = "Absent"
        ElseIf Me.radLateAishaAlMaqbali.Checked = True Then
            attendancerecorded(3) = "Late"
        End If

        If Me.radPresentShammaAlShibli.Checked = True Then
            attendancerecorded(4) = "Present"
        ElseIf Me.radAbsentShammaAlShibli.Checked = True Then
            attendancerecorded(4) = "Absent"
        ElseIf Me.radLateShammaAlShibli.Checked = True Then
            attendancerecorded(4) = "Late"
        End If

        If Me.radPresentSaifAlShibli.Checked = True Then
            attendancerecorded(5) = "Present"
        ElseIf Me.radAbsentSaifAlShibli.Checked = True Then
            attendancerecorded(5) = "Absent"
        ElseIf Me.radLateSaifAlShibli.Checked = True Then
            attendancerecorded(5) = "Late"
        End If

        If Me.radPresentTahlynChetty.Checked = True Then
            attendancerecorded(6) = "Present"
        ElseIf Me.radAbsentTahlynChetty.Checked = True Then
            attendancerecorded(6) = "Absent"
        ElseIf Me.radLateTahlynChetty.Checked = True Then
            attendancerecorded(6) = "Late"
        End If

        If Me.radPresentTrinaDeVera.Checked = True Then
            attendancerecorded(7) = "Present"
        ElseIf Me.radAbsentTrinaDeVera.Checked = True Then
            attendancerecorded(7) = "Absent"
        ElseIf Me.radLateTrinaDeVera.Checked = True Then
            attendancerecorded(7) = "Late"
        End If

        If Me.radPresentShalinGovender.Checked = True Then
            attendancerecorded(8) = "Present"
        ElseIf Me.radAbsentShalinGovender.Checked = True Then
            attendancerecorded(8) = "Absent"
        ElseIf Me.radLateShalinGovender.Checked = True Then
            attendancerecorded(8) = "Late"
        End If

        If Me.radPresentChristineNolido.Checked = True Then
            attendancerecorded(9) = "Present"
        ElseIf Me.radAbsentChristineNolido.Checked = True Then
            attendancerecorded(9) = "Absent"
        ElseIf Me.radLateChristineNolido.Checked = True Then
            attendancerecorded(9) = "Late"
        End If

        If Me.radPresentLexiaPanogalinog.Checked = True Then
            attendancerecorded(10) = "Present"
        ElseIf Me.radAbsentLexiaPanogalinog.Checked = True Then
            attendancerecorded(10) = "Absent"
        ElseIf Me.radLateLexiaPanogalinog.Checked = True Then
            attendancerecorded(10) = "Late"
        End If

        If Me.radPresentHannahRahim.Checked = True Then
            attendancerecorded(11) = "Present"
        ElseIf Me.radAbsentHannahRahim.Checked = True Then
            attendancerecorded(11) = "Absent"
        ElseIf Me.radLateHannahRahim.Checked = True Then
            attendancerecorded(11) = "Late"
        End If

        If Me.radPresentTejaTiriveedhi.Checked = True Then
            attendancerecorded(12) = "Present"
        ElseIf Me.radAbsentTejaTiriveedhi.Checked = True Then
            attendancerecorded(12) = "Absent"
        ElseIf Me.radLateTejaTiriveedhi.Checked = True Then
            attendancerecorded(12) = "Late"
        End If

        If Me.radPresentDavidTomalin.Checked = True Then
            attendancerecorded(13) = "Present"
        ElseIf Me.radAbsentDavidTomalin.Checked = True Then
            attendancerecorded(13) = "Absent"
        ElseIf Me.radLateDavidTomalin.Checked = True Then
            attendancerecorded(13) = "Late"
        End If

        If Me.radPresentAlexWatts.Checked = True Then
            attendancerecorded(14) = "Present"
        ElseIf Me.radAbsentAlexWatts.Checked = True Then
            attendancerecorded(14) = "Absent"
        ElseIf Me.radLateAlexWatts.Checked = True Then
            attendancerecorded(14) = "Late"
        End If

        If Me.radPresentHannahWillis.Checked = True Then
            attendancerecorded(15) = "Present"
        ElseIf Me.radAbsentHannahWillis.Checked = True Then
            attendancerecorded(15) = "Absent"
        ElseIf Me.radLateHannahWillis.Checked = True Then
            attendancerecorded(15) = "Late"
        End If

        Try
            MySqlConn.Open()
            Dim NoafAlBalushiQuery As String
            NoafAlBalushiQuery = "insert into abisattendancesystem.yellowfoxesrecords(idyellowfoxesrecords,Date,StudentFirstName,StudentLastName,GradeLevel,AttendanceRecorded,Comments) values (1, '" & DateTimePicker1.Text & "', 'Noaf', 'Al Balushi', 7 ,'" & attendancerecorded(0) & "', '" & txtNoafAlBalushiRemarks.Text & "')"

            COMMAND = New MySqlCommand(NoafAlBalushiQuery, MySqlConn)
            Reader = COMMAND.ExecuteReader
            MySqlConn.Close()

            MySqlConn.Open()
            Dim TaifAlBalushiQuery As String
            TaifAlBalushiQuery = "insert into abisattendancesystem.yellowfoxesrecords(idyellowfoxesrecords,Date,StudentFirstName,StudentLastName,GradeLevel,AttendanceRecorded,Comments) values (2, '" & DateTimePicker1.Text & "', 'Taif', 'Al Balushi', 9 ,'" & attendancerecorded(1) & "', '" & txtTaifAlBalushiRemarks.Text & "')"

            COMMAND = New MySqlCommand(TaifAlBalushiQuery, MySqlConn)
            Reader = COMMAND.ExecuteReader
            MySqlConn.Close()

            MySqlConn.Open()
            Dim SultanAlZefeitiQuery As String
            SultanAlZefeitiQuery = "insert into abisattendancesystem.yellowfoxesrecords(idyellowfoxesrecords,Date,StudentFirstName,StudentLastName,GradeLevel,AttendanceRecorded,Comments) values (3, '" & DateTimePicker1.Text & "', 'Sultan', 'Al Zefeiti', 7 ,'" & attendancerecorded(2) & "', '" & txtSultanAlZefeitiRemarks.Text & "')"

            COMMAND = New MySqlCommand(SultanAlZefeitiQuery, MySqlConn)
            Reader = COMMAND.ExecuteReader
            MySqlConn.Close()

            MySqlConn.Open()
            Dim AishaAlMaqbaliQuery As String
            AishaAlMaqbaliQuery = "insert into abisattendancesystem.yellowfoxesrecords(idyellowfoxesrecords,Date,StudentFirstName,StudentLastName,GradeLevel,AttendanceRecorded,Comments) values (4, '" & DateTimePicker1.Text & "', 'Aisha', 'Al-Maqbali', 12 ,'" & attendancerecorded(3) & "', '" & txtAishaAlMaqbaliRemarks.Text & "')"

            COMMAND = New MySqlCommand(AishaAlMaqbaliQuery, MySqlConn)
            Reader = COMMAND.ExecuteReader
            MySqlConn.Close()

            MySqlConn.Open()
            Dim ShammaAlShibliQuery As String
            ShammaAlShibliQuery = "insert into abisattendancesystem.yellowfoxesrecords(idyellowfoxesrecords,Date,StudentFirstName,StudentLastName,GradeLevel,AttendanceRecorded,Comments) values (5, '" & DateTimePicker1.Text & "', 'Shamma', 'Al-Shibli', 10 ,'" & attendancerecorded(4) & "', '" & txtShammaAlShibliRemarks.Text & "')"

            COMMAND = New MySqlCommand(ShammaAlShibliQuery, MySqlConn)
            Reader = COMMAND.ExecuteReader
            MySqlConn.Close()

            MySqlConn.Open()
            Dim SaifAlShibliQuery As String
            SaifAlShibliQuery = "insert into abisattendancesystem.yellowfoxesrecords(idyellowfoxesrecords,Date,StudentFirstName,StudentLastName,GradeLevel,AttendanceRecorded,Comments) values (6, '" & DateTimePicker1.Text & "', 'Saif', 'Al-Shibli', 10 ,'" & attendancerecorded(5) & "', '" & txtSaifAlShibliRemarks.Text & "')"

            COMMAND = New MySqlCommand(SaifAlShibliQuery, MySqlConn)
            Reader = COMMAND.ExecuteReader
            MySqlConn.Close()

            MySqlConn.Open()
            Dim TahlynChettyQuery As String
            TahlynChettyQuery = "insert into abisattendancesystem.yellowfoxesrecords(idyellowfoxesrecords,Date,StudentFirstName,StudentLastName,GradeLevel,AttendanceRecorded,Comments) values (7, '" & DateTimePicker1.Text & "', 'Tahlyn', 'Chetty', 8 ,'" & attendancerecorded(6) & "', '" & txtTahlynChettyRemarks.Text & "')"

            COMMAND = New MySqlCommand(TahlynChettyQuery, MySqlConn)
            Reader = COMMAND.ExecuteReader
            MySqlConn.Close()

            MySqlConn.Open()
            Dim TrinaDeVeraQuery As String
            TrinaDeVeraQuery = "insert into abisattendancesystem.yellowfoxesrecords(idyellowfoxesrecords,Date,StudentFirstName,StudentLastName,GradeLevel,AttendanceRecorded,Comments) values (8, '" & DateTimePicker1.Text & "', 'Trina', 'De Vera', 8 ,'" & attendancerecorded(7) & "', '" & txtTrinaDeVeraRemarks.Text & "')"

            COMMAND = New MySqlCommand(TrinaDeVeraQuery, MySqlConn)
            Reader = COMMAND.ExecuteReader
            MySqlConn.Close()

            MySqlConn.Open()
            Dim ShalinGovenderQuery As String
            ShalinGovenderQuery = "insert into abisattendancesystem.yellowfoxesrecords(idyellowfoxesrecords,Date,StudentFirstName,StudentLastName,GradeLevel,AttendanceRecorded,Comments) values (9, '" & DateTimePicker1.Text & "', 'Shalin', 'Govender', 10 ,'" & attendancerecorded(8) & "', '" & txtShalinGovenderRemarks.Text & "')"

            COMMAND = New MySqlCommand(ShalinGovenderQuery, MySqlConn)
            Reader = COMMAND.ExecuteReader
            MySqlConn.Close()

            MySqlConn.Open()
            Dim ChristineNolidoQuery As String
            ChristineNolidoQuery = "insert into abisattendancesystem.yellowfoxesrecords(idyellowfoxesrecords,Date,StudentFirstName,StudentLastName,GradeLevel,AttendanceRecorded,Comments) values (10, '" & DateTimePicker1.Text & "', 'Christine', 'Nolido', 10 ,'" & attendancerecorded(9) & "', '" & txtChristineNolidoRemarks.Text & "')"

            COMMAND = New MySqlCommand(ChristineNolidoQuery, MySqlConn)
            Reader = COMMAND.ExecuteReader
            MySqlConn.Close()

            MySqlConn.Open()
            Dim LexiaPanogalinogQuery As String
            LexiaPanogalinogQuery = "insert into abisattendancesystem.yellowfoxesrecords(idyellowfoxesrecords,Date,StudentFirstName,StudentLastName,GradeLevel,AttendanceRecorded,Comments) values (11, '" & DateTimePicker1.Text & "', 'Lexia', 'Panogalinog', 8 ,'" & attendancerecorded(10) & "', '" & txtLexiaPanogalinogRemarks.Text & "')"

            COMMAND = New MySqlCommand(LexiaPanogalinogQuery, MySqlConn)
            Reader = COMMAND.ExecuteReader
            MySqlConn.Close()

            MySqlConn.Open()
            Dim HannahRahimQuery As String
            HannahRahimQuery = "insert into abisattendancesystem.yellowfoxesrecords(idyellowfoxesrecords,Date,StudentFirstName,StudentLastName,GradeLevel,AttendanceRecorded,Comments) values (12, '" & DateTimePicker1.Text & "', 'Hannah', 'Rahim', 7 ,'" & attendancerecorded(11) & "', '" & txtHannahRahimRemarks.Text & "')"

            COMMAND = New MySqlCommand(HannahRahimQuery, MySqlConn)
            Reader = COMMAND.ExecuteReader
            MySqlConn.Close()

            MySqlConn.Open()
            Dim TejaTiriveedhiQuery As String
            TejaTiriveedhiQuery = "insert into abisattendancesystem.yellowfoxesrecords(idyellowfoxesrecords,Date,StudentFirstName,StudentLastName,GradeLevel,AttendanceRecorded,Comments) values (13, '" & DateTimePicker1.Text & "', 'Teja', 'Tiriveedhi', 12 ,'" & attendancerecorded(12) & "', '" & txtTejaTiriveedhiRemarks.Text & "')"

            COMMAND = New MySqlCommand(TejaTiriveedhiQuery, MySqlConn)
            Reader = COMMAND.ExecuteReader
            MySqlConn.Close()

            MySqlConn.Open()
            Dim DavidTomalinQuery As String
            DavidTomalinQuery = "insert into abisattendancesystem.yellowfoxesrecords(idyellowfoxesrecords,Date,StudentFirstName,StudentLastName,GradeLevel,AttendanceRecorded,Comments) values (14, '" & DateTimePicker1.Text & "', 'David', 'Tomalin', 11 ,'" & attendancerecorded(13) & "', '" & txtDavidTomalinRemarks.Text & "')"

            COMMAND = New MySqlCommand(DavidTomalinQuery, MySqlConn)
            Reader = COMMAND.ExecuteReader
            MySqlConn.Close()

            MySqlConn.Open()
            Dim AlexWattsQuery As String
            AlexWattsQuery = "insert into abisattendancesystem.yellowfoxesrecords(idyellowfoxesrecords,Date,StudentFirstName,StudentLastName,GradeLevel,AttendanceRecorded,Comments) values (15, '" & DateTimePicker1.Text & "', 'Alex', 'Watts', 12 ,'" & attendancerecorded(14) & "', '" & txtAlexWattsRemarks.Text & "')"

            COMMAND = New MySqlCommand(AlexWattsQuery, MySqlConn)
            Reader = COMMAND.ExecuteReader
            MySqlConn.Close()

            MySqlConn.Open()
            Dim HannahWillisQuery As String
            HannahWillisQuery = "insert into abisattendancesystem.yellowfoxesrecords(idyellowfoxesrecords,Date,StudentFirstName,StudentLastName,GradeLevel,AttendanceRecorded,Comments) values (16, '" & DateTimePicker1.Text & "', 'Hannah', 'Willis', 9 ,'" & attendancerecorded(15) & "', '" & txtHannahWillisRemarks.Text & "')"

            COMMAND = New MySqlCommand(HannahWillisQuery, MySqlConn)
            Reader = COMMAND.ExecuteReader
            MySqlConn.Close()

            MessageBox.Show("Attendance Submitted Successfully!")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MySqlConn.Dispose()
        End Try

        Try
            MySqlConn.Open()
            Dim Query1 As String
            Dim Query2 As String
            Dim Query3 As String
            Dim Query4 As String

            Dim StudentLastName(15) As String
            Dim StudentFirstName(15) As String
            Dim PresentAttendanceCount(15) As Integer
            Dim AbsentAttendanceCount(15) As Integer
            Dim LateAttendanceCount(15) As Integer

            StudentLastName(0) = "Al Balushi"
            StudentLastName(1) = "Al Balushi"
            StudentLastName(2) = "Al Zefeiti"
            StudentLastName(3) = "Al-Maqbali"
            StudentLastName(4) = "Al-Shibli"
            StudentLastName(5) = "Al-Shibli"
            StudentLastName(6) = "Chetty"
            StudentLastName(7) = "De Vera"
            StudentLastName(8) = "Govender"
            StudentLastName(9) = "Nolido"
            StudentLastName(10) = "Panogalinog"
            StudentLastName(11) = "Rahim"
            StudentLastName(12) = "Tiriveedhi"
            StudentLastName(13) = "Tomalin"
            StudentLastName(14) = "Watts"
            StudentLastName(15) = "Willis"

            StudentFirstName(0) = "Noaf"
            StudentFirstName(1) = "Taif"
            StudentFirstName(2) = "Sultan"
            StudentFirstName(3) = "Aisha"
            StudentFirstName(4) = "Shamma"
            StudentFirstName(5) = "Saif"
            StudentFirstName(6) = "Tahlyn"
            StudentFirstName(7) = "Trina"
            StudentFirstName(8) = "Shalin"
            StudentFirstName(9) = "Christine"
            StudentFirstName(10) = "Lexia"
            StudentFirstName(11) = "Hannah"
            StudentFirstName(12) = "Teja"
            StudentFirstName(13) = "David"
            StudentFirstName(14) = "Alex"
            StudentFirstName(15) = "Hannah"

            If attendancerecorded(0) = "Present" Then
                Query1 = "select DaysPresent from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(0) & "' and StudentFirstName = '" & StudentFirstName(0) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(0) = Int(Reader.GetString("DaysPresent")) + 1
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(0) & "' and StudentFirstName = '" & StudentFirstName(0) & "'"
                    COMMAND2 = New MySqlCommand(Query2, MySqlConn)
                    Reader = COMMAND2.ExecuteReader

                    Reader.Read()
                    AbsentAttendanceCount(0) = Int(Reader.GetString("DaysAbsent"))
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try

                Try
                    MySqlConn.Open()
                    Query3 = "select DaysLate from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(0) & "' and StudentFirstName = '" & StudentFirstName(0) & "'"
                    COMMAND3 = New MySqlCommand(Query3, MySqlConn)
                    Reader = COMMAND3.ExecuteReader

                    Reader.Read()
                    LateAttendanceCount(0) = Int(Reader.GetString("DaysLate"))
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try

                Try
                    MySqlConn.Open()
                    Query4 = "update abisattendancesystem.yellowfoxesdata set idyellowfoxesdata=1,StudentFirstName='" & StudentFirstName(0) & "',StudentLastName='" & StudentLastName(0) & "',DaysPresent='" & PresentAttendanceCount(0) & "',DaysAbsent='" & AbsentAttendanceCount(0) & "',DaysLate='" & LateAttendanceCount(0) & "' where idyellowfoxesdata=1"
                    COMMAND4 = New MySqlCommand(Query4, MySqlConn)
                    Reader = COMMAND4.ExecuteReader
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try
            ElseIf attendancerecorded(0) = "Absent" Then
                Query1 = "select DaysPresent from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(0) & "' and StudentFirstName = '" & StudentFirstName(0) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(0) = Int(Reader.GetString("DaysPresent"))
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(0) & "' and StudentFirstName = '" & StudentFirstName(0) & "'"
                    COMMAND2 = New MySqlCommand(Query2, MySqlConn)
                    Reader = COMMAND2.ExecuteReader

                    Reader.Read()
                    AbsentAttendanceCount(0) = Int(Reader.GetString("DaysAbsent")) + 1
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try

                Try
                    MySqlConn.Open()
                    Query3 = "select DaysLate from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(0) & "' and StudentFirstName = '" & StudentFirstName(0) & "'"
                    COMMAND3 = New MySqlCommand(Query3, MySqlConn)
                    Reader = COMMAND3.ExecuteReader

                    Reader.Read()
                    LateAttendanceCount(0) = Int(Reader.GetString("DaysLate"))
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try

                Try
                    MySqlConn.Open()
                    Query4 = "update abisattendancesystem.yellowfoxesdata set idyellowfoxesdata=1,StudentFirstName='" & StudentFirstName(0) & "',StudentLastName='" & StudentLastName(0) & "',DaysPresent='" & PresentAttendanceCount(0) & "',DaysAbsent='" & AbsentAttendanceCount(0) & "',DaysLate='" & LateAttendanceCount(0) & "' where idyellowfoxesdata=1"
                    COMMAND4 = New MySqlCommand(Query4, MySqlConn)
                    Reader = COMMAND4.ExecuteReader
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try
            Else
                Query1 = "select DaysPresent from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(0) & "' and StudentFirstName = '" & StudentFirstName(0) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(0) = Int(Reader.GetString("DaysPresent"))
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(0) & "' and StudentFirstName = '" & StudentFirstName(0) & "'"
                    COMMAND2 = New MySqlCommand(Query2, MySqlConn)
                    Reader = COMMAND2.ExecuteReader

                    Reader.Read()
                    AbsentAttendanceCount(0) = Int(Reader.GetString("DaysAbsent"))
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try

                Try
                    MySqlConn.Open()
                    Query3 = "select DaysLate from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(0) & "' and StudentFirstName = '" & StudentFirstName(0) & "'"
                    COMMAND3 = New MySqlCommand(Query3, MySqlConn)
                    Reader = COMMAND3.ExecuteReader

                    Reader.Read()
                    LateAttendanceCount(0) = Int(Reader.GetString("DaysLate")) + 1
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try

                Try
                    MySqlConn.Open()
                    Query4 = "update abisattendancesystem.yellowfoxesdata set idyellowfoxesdata=1,StudentFirstName='" & StudentFirstName(0) & "',StudentLastName='" & StudentLastName(0) & "',DaysPresent='" & PresentAttendanceCount(0) & "',DaysAbsent='" & AbsentAttendanceCount(0) & "',DaysLate='" & LateAttendanceCount(0) & "' where idyellowfoxesdata=1"
                    COMMAND4 = New MySqlCommand(Query4, MySqlConn)
                    Reader = COMMAND4.ExecuteReader
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try
            End If

            If attendancerecorded(1) = "Present" Then
                MySqlConn.Open()
                Query1 = "select DaysPresent from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(1) & "' and StudentFirstName = '" & StudentFirstName(1) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(1) = Int(Reader.GetString("DaysPresent")) + 1
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(1) & "' and StudentFirstName = '" & StudentFirstName(1) & "'"
                    COMMAND2 = New MySqlCommand(Query2, MySqlConn)
                    Reader = COMMAND2.ExecuteReader

                    Reader.Read()
                    AbsentAttendanceCount(1) = Int(Reader.GetString("DaysAbsent"))
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try

                Try
                    MySqlConn.Open()
                    Query3 = "select DaysLate from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(1) & "' and StudentFirstName = '" & StudentFirstName(1) & "'"
                    COMMAND3 = New MySqlCommand(Query3, MySqlConn)
                    Reader = COMMAND3.ExecuteReader

                    Reader.Read()
                    LateAttendanceCount(1) = Int(Reader.GetString("DaysLate"))
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try

                Try
                    MySqlConn.Open()
                    Query4 = "update abisattendancesystem.yellowfoxesdata set idyellowfoxesdata=2,StudentFirstName='" & StudentFirstName(1) & "',StudentLastName='" & StudentLastName(1) & "',DaysPresent='" & PresentAttendanceCount(1) & "',DaysAbsent='" & AbsentAttendanceCount(1) & "',DaysLate='" & LateAttendanceCount(1) & "' where idyellowfoxesdata=2"
                    COMMAND4 = New MySqlCommand(Query4, MySqlConn)
                    Reader = COMMAND4.ExecuteReader
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try
            ElseIf attendancerecorded(1) = "Absent" Then
                MySqlConn.Open()
                Query1 = "select DaysPresent from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(1) & "' and StudentFirstName = '" & StudentFirstName(1) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(1) = Int(Reader.GetString("DaysPresent"))
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(1) & "' and StudentFirstName = '" & StudentFirstName(1) & "'"
                    COMMAND2 = New MySqlCommand(Query2, MySqlConn)
                    Reader = COMMAND2.ExecuteReader

                    Reader.Read()
                    AbsentAttendanceCount(1) = Int(Reader.GetString("DaysAbsent")) + 1
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try

                Try
                    MySqlConn.Open()
                    Query3 = "select DaysLate from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(1) & "' and StudentFirstName = '" & StudentFirstName(1) & "'"
                    COMMAND3 = New MySqlCommand(Query3, MySqlConn)
                    Reader = COMMAND3.ExecuteReader

                    Reader.Read()
                    LateAttendanceCount(1) = Int(Reader.GetString("DaysLate"))
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try

                Try
                    MySqlConn.Open()
                    Query4 = "update abisattendancesystem.yellowfoxesdata set idyellowfoxesdata=2,StudentFirstName='" & StudentFirstName(1) & "',StudentLastName='" & StudentLastName(1) & "',DaysPresent='" & PresentAttendanceCount(1) & "',DaysAbsent='" & AbsentAttendanceCount(1) & "',DaysLate='" & LateAttendanceCount(1) & "' where idyellowfoxesdata=2"
                    COMMAND4 = New MySqlCommand(Query4, MySqlConn)
                    Reader = COMMAND4.ExecuteReader
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try
            Else
                MySqlConn.Open()
                Query1 = "select DaysPresent from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(1) & "' and StudentFirstName = '" & StudentFirstName(1) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(1) = Int(Reader.GetString("DaysPresent"))
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(1) & "' and StudentFirstName = '" & StudentFirstName(1) & "'"
                    COMMAND2 = New MySqlCommand(Query2, MySqlConn)
                    Reader = COMMAND2.ExecuteReader

                    Reader.Read()
                    AbsentAttendanceCount(1) = Int(Reader.GetString("DaysAbsent"))
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try

                Try
                    MySqlConn.Open()
                    Query3 = "select DaysLate from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(1) & "' and StudentFirstName = '" & StudentFirstName(1) & "'"
                    COMMAND3 = New MySqlCommand(Query3, MySqlConn)
                    Reader = COMMAND3.ExecuteReader

                    Reader.Read()
                    LateAttendanceCount(1) = Int(Reader.GetString("DaysLate")) + 1
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try

                Try
                    MySqlConn.Open()
                    Query4 = "update abisattendancesystem.yellowfoxesdata set idyellowfoxesdata=2,StudentFirstName='" & StudentFirstName(1) & "',StudentLastName='" & StudentLastName(1) & "',DaysPresent='" & PresentAttendanceCount(1) & "',DaysAbsent='" & AbsentAttendanceCount(1) & "',DaysLate='" & LateAttendanceCount(1) & "' where idyellowfoxesdata=2"
                    COMMAND4 = New MySqlCommand(Query4, MySqlConn)
                    Reader = COMMAND4.ExecuteReader
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try
            End If

            If attendancerecorded(2) = "Present" Then
                MySqlConn.Open()
                Query1 = "select DaysPresent from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(2) & "' and StudentFirstName = '" & StudentFirstName(2) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(2) = Int(Reader.GetString("DaysPresent")) + 1
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(2) & "' and StudentFirstName = '" & StudentFirstName(2) & "'"
                    COMMAND2 = New MySqlCommand(Query2, MySqlConn)
                    Reader = COMMAND2.ExecuteReader

                    Reader.Read()
                    AbsentAttendanceCount(2) = Int(Reader.GetString("DaysAbsent"))
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try

                Try
                    MySqlConn.Open()
                    Query3 = "select DaysLate from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(2) & "' and StudentFirstName = '" & StudentFirstName(2) & "'"
                    COMMAND3 = New MySqlCommand(Query3, MySqlConn)
                    Reader = COMMAND3.ExecuteReader

                    Reader.Read()
                    LateAttendanceCount(2) = Int(Reader.GetString("DaysLate"))
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try

                Try
                    MySqlConn.Open()
                    Query4 = "update abisattendancesystem.yellowfoxesdata set idyellowfoxesdata=3,StudentFirstName='" & StudentFirstName(2) & "',StudentLastName='" & StudentLastName(2) & "',DaysPresent='" & PresentAttendanceCount(2) & "',DaysAbsent='" & AbsentAttendanceCount(2) & "',DaysLate='" & LateAttendanceCount(2) & "' where idyellowfoxesdata=3"
                    COMMAND4 = New MySqlCommand(Query4, MySqlConn)
                    Reader = COMMAND4.ExecuteReader
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try
            ElseIf attendancerecorded(2) = "Absent" Then
                MySqlConn.Open()
                Query1 = "select DaysPresent from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(2) & "' and StudentFirstName = '" & StudentFirstName(2) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(2) = Int(Reader.GetString("DaysPresent"))
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(2) & "' and StudentFirstName = '" & StudentFirstName(2) & "'"
                    COMMAND2 = New MySqlCommand(Query2, MySqlConn)
                    Reader = COMMAND2.ExecuteReader

                    Reader.Read()
                    AbsentAttendanceCount(2) = Int(Reader.GetString("DaysAbsent")) + 1
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try

                Try
                    MySqlConn.Open()
                    Query3 = "select DaysLate from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(2) & "' and StudentFirstName = '" & StudentFirstName(2) & "'"
                    COMMAND3 = New MySqlCommand(Query3, MySqlConn)
                    Reader = COMMAND3.ExecuteReader

                    Reader.Read()
                    LateAttendanceCount(2) = Int(Reader.GetString("DaysLate"))
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try

                Try
                    MySqlConn.Open()
                    Query4 = "update abisattendancesystem.yellowfoxesdata set idyellowfoxesdata=3,StudentFirstName='" & StudentFirstName(2) & "',StudentLastName='" & StudentLastName(2) & "',DaysPresent='" & PresentAttendanceCount(2) & "',DaysAbsent='" & AbsentAttendanceCount(2) & "',DaysLate='" & LateAttendanceCount(2) & "' where idyellowfoxesdata=3"
                    COMMAND4 = New MySqlCommand(Query4, MySqlConn)
                    Reader = COMMAND4.ExecuteReader
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try
            Else
                MySqlConn.Open()
                Query1 = "select DaysPresent from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(2) & "' and StudentFirstName = '" & StudentFirstName(2) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(2) = Int(Reader.GetString("DaysPresent"))
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(2) & "' and StudentFirstName = '" & StudentFirstName(2) & "'"
                    COMMAND2 = New MySqlCommand(Query2, MySqlConn)
                    Reader = COMMAND2.ExecuteReader

                    Reader.Read()
                    AbsentAttendanceCount(2) = Int(Reader.GetString("DaysAbsent"))
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try

                Try
                    MySqlConn.Open()
                    Query3 = "select DaysLate from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(2) & "' and StudentFirstName = '" & StudentFirstName(2) & "'"
                    COMMAND3 = New MySqlCommand(Query3, MySqlConn)
                    Reader = COMMAND3.ExecuteReader

                    Reader.Read()
                    LateAttendanceCount(2) = Int(Reader.GetString("DaysLate")) + 1
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try

                Try
                    MySqlConn.Open()
                    Query4 = "update abisattendancesystem.yellowfoxesdata set idyellowfoxesdata=3,StudentFirstName='" & StudentFirstName(2) & "',StudentLastName='" & StudentLastName(2) & "',DaysPresent='" & PresentAttendanceCount(2) & "',DaysAbsent='" & AbsentAttendanceCount(2) & "',DaysLate='" & LateAttendanceCount(2) & "' where idyellowfoxesdata=3"
                    COMMAND4 = New MySqlCommand(Query4, MySqlConn)
                    Reader = COMMAND4.ExecuteReader
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try
            End If

            If attendancerecorded(3) = "Present" Then
                MySqlConn.Open()
                Query1 = "select DaysPresent from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(3) & "' and StudentFirstName = '" & StudentFirstName(3) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(3) = Int(Reader.GetString("DaysPresent")) + 1
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(3) & "' and StudentFirstName = '" & StudentFirstName(3) & "'"
                    COMMAND2 = New MySqlCommand(Query2, MySqlConn)
                    Reader = COMMAND2.ExecuteReader

                    Reader.Read()
                    AbsentAttendanceCount(3) = Int(Reader.GetString("DaysAbsent"))
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try

                Try
                    MySqlConn.Open()
                    Query3 = "select DaysLate from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(3) & "' and StudentFirstName = '" & StudentFirstName(3) & "'"
                    COMMAND3 = New MySqlCommand(Query3, MySqlConn)
                    Reader = COMMAND3.ExecuteReader

                    Reader.Read()
                    LateAttendanceCount(3) = Int(Reader.GetString("DaysLate"))
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try

                Try
                    MySqlConn.Open()
                    Query4 = "update abisattendancesystem.yellowfoxesdata set idyellowfoxesdata=4,StudentFirstName='" & StudentFirstName(3) & "',StudentLastName='" & StudentLastName(3) & "',DaysPresent='" & PresentAttendanceCount(3) & "',DaysAbsent='" & AbsentAttendanceCount(3) & "',DaysLate='" & LateAttendanceCount(3) & "' where idyellowfoxesdata=4"
                    COMMAND4 = New MySqlCommand(Query4, MySqlConn)
                    Reader = COMMAND4.ExecuteReader
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try
            ElseIf attendancerecorded(3) = "Absent" Then
                MySqlConn.Open()
                Query1 = "select DaysPresent from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(3) & "' and StudentFirstName = '" & StudentFirstName(3) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(3) = Int(Reader.GetString("DaysPresent"))
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(3) & "' and StudentFirstName = '" & StudentFirstName(3) & "'"
                    COMMAND2 = New MySqlCommand(Query2, MySqlConn)
                    Reader = COMMAND2.ExecuteReader

                    Reader.Read()
                    AbsentAttendanceCount(3) = Int(Reader.GetString("DaysAbsent")) + 1
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try

                Try
                    MySqlConn.Open()
                    Query3 = "select DaysLate from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(3) & "' and StudentFirstName = '" & StudentFirstName(3) & "'"
                    COMMAND3 = New MySqlCommand(Query3, MySqlConn)
                    Reader = COMMAND3.ExecuteReader

                    Reader.Read()
                    LateAttendanceCount(3) = Int(Reader.GetString("DaysLate"))
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try

                Try
                    MySqlConn.Open()
                    Query4 = "update abisattendancesystem.yellowfoxesdata set idyellowfoxesdata=4,StudentFirstName='" & StudentFirstName(3) & "',StudentLastName='" & StudentLastName(3) & "',DaysPresent='" & PresentAttendanceCount(3) & "',DaysAbsent='" & AbsentAttendanceCount(3) & "',DaysLate='" & LateAttendanceCount(3) & "' where idyellowfoxesdata=4"
                    COMMAND4 = New MySqlCommand(Query4, MySqlConn)
                    Reader = COMMAND4.ExecuteReader
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try
            Else
                MySqlConn.Open()
                Query1 = "select DaysPresent from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(3) & "' and StudentFirstName = '" & StudentFirstName(3) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(3) = Int(Reader.GetString("DaysPresent"))
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(3) & "' and StudentFirstName = '" & StudentFirstName(3) & "'"
                    COMMAND2 = New MySqlCommand(Query2, MySqlConn)
                    Reader = COMMAND2.ExecuteReader

                    Reader.Read()
                    AbsentAttendanceCount(3) = Int(Reader.GetString("DaysAbsent"))
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try

                Try
                    MySqlConn.Open()
                    Query3 = "select DaysLate from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(3) & "' and StudentFirstName = '" & StudentFirstName(3) & "'"
                    COMMAND3 = New MySqlCommand(Query3, MySqlConn)
                    Reader = COMMAND3.ExecuteReader

                    Reader.Read()
                    LateAttendanceCount(3) = Int(Reader.GetString("DaysLate")) + 1
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try

                Try
                    MySqlConn.Open()
                    Query4 = "update abisattendancesystem.yellowfoxesdata set idyellowfoxesdata=4,StudentFirstName='" & StudentFirstName(3) & "',StudentLastName='" & StudentLastName(3) & "',DaysPresent='" & PresentAttendanceCount(3) & "',DaysAbsent='" & AbsentAttendanceCount(3) & "',DaysLate='" & LateAttendanceCount(3) & "' where idyellowfoxesdata=4"
                    COMMAND4 = New MySqlCommand(Query4, MySqlConn)
                    Reader = COMMAND4.ExecuteReader
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try
            End If

            If attendancerecorded(4) = "Present" Then
                MySqlConn.Open()
                Query1 = "select DaysPresent from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(4) & "' and StudentFirstName = '" & StudentFirstName(4) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(4) = Int(Reader.GetString("DaysPresent")) + 1
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(4) & "' and StudentFirstName = '" & StudentFirstName(4) & "'"
                    COMMAND2 = New MySqlCommand(Query2, MySqlConn)
                    Reader = COMMAND2.ExecuteReader

                    Reader.Read()
                    AbsentAttendanceCount(4) = Int(Reader.GetString("DaysAbsent"))
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try

                Try
                    MySqlConn.Open()
                    Query3 = "select DaysLate from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(4) & "' and StudentFirstName = '" & StudentFirstName(4) & "'"
                    COMMAND3 = New MySqlCommand(Query3, MySqlConn)
                    Reader = COMMAND3.ExecuteReader

                    Reader.Read()
                    LateAttendanceCount(4) = Int(Reader.GetString("DaysLate"))
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try

                Try
                    MySqlConn.Open()
                    Query4 = "update abisattendancesystem.yellowfoxesdata set idyellowfoxesdata=5,StudentFirstName='" & StudentFirstName(4) & "',StudentLastName='" & StudentLastName(4) & "',DaysPresent='" & PresentAttendanceCount(4) & "',DaysAbsent='" & AbsentAttendanceCount(4) & "',DaysLate='" & LateAttendanceCount(4) & "' where idyellowfoxesdata=5"
                    COMMAND4 = New MySqlCommand(Query4, MySqlConn)
                    Reader = COMMAND4.ExecuteReader
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try
            ElseIf attendancerecorded(4) = "Absent" Then
                MySqlConn.Open()
                Query1 = "select DaysPresent from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(4) & "' and StudentFirstName = '" & StudentFirstName(4) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(4) = Int(Reader.GetString("DaysPresent"))
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(4) & "' and StudentFirstName = '" & StudentFirstName(4) & "'"
                    COMMAND2 = New MySqlCommand(Query2, MySqlConn)
                    Reader = COMMAND2.ExecuteReader

                    Reader.Read()
                    AbsentAttendanceCount(4) = Int(Reader.GetString("DaysAbsent")) + 1
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try

                Try
                    MySqlConn.Open()
                    Query3 = "select DaysLate from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(4) & "' and StudentFirstName = '" & StudentFirstName(4) & "'"
                    COMMAND3 = New MySqlCommand(Query3, MySqlConn)
                    Reader = COMMAND3.ExecuteReader

                    Reader.Read()
                    LateAttendanceCount(4) = Int(Reader.GetString("DaysLate"))
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try

                Try
                    MySqlConn.Open()
                    Query4 = "update abisattendancesystem.yellowfoxesdata set idyellowfoxesdata=5,StudentFirstName='" & StudentFirstName(4) & "',StudentLastName='" & StudentLastName(4) & "',DaysPresent='" & PresentAttendanceCount(4) & "',DaysAbsent='" & AbsentAttendanceCount(4) & "',DaysLate='" & LateAttendanceCount(4) & "' where idyellowfoxesdata=5"
                    COMMAND4 = New MySqlCommand(Query4, MySqlConn)
                    Reader = COMMAND4.ExecuteReader
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try
            Else
                MySqlConn.Open()
                Query1 = "select DaysPresent from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(4) & "' and StudentFirstName = '" & StudentFirstName(4) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(4) = Int(Reader.GetString("DaysPresent"))
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(4) & "' and StudentFirstName = '" & StudentFirstName(4) & "'"
                    COMMAND2 = New MySqlCommand(Query2, MySqlConn)
                    Reader = COMMAND2.ExecuteReader

                    Reader.Read()
                    AbsentAttendanceCount(4) = Int(Reader.GetString("DaysAbsent"))
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try

                Try
                    MySqlConn.Open()
                    Query3 = "select DaysLate from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(4) & "' and StudentFirstName = '" & StudentFirstName(4) & "'"
                    COMMAND3 = New MySqlCommand(Query3, MySqlConn)
                    Reader = COMMAND3.ExecuteReader

                    Reader.Read()
                    LateAttendanceCount(4) = Int(Reader.GetString("DaysLate")) + 1
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try

                Try
                    MySqlConn.Open()
                    Query4 = "update abisattendancesystem.yellowfoxesdata set idyellowfoxesdata=5,StudentFirstName='" & StudentFirstName(4) & "',StudentLastName='" & StudentLastName(4) & "',DaysPresent='" & PresentAttendanceCount(4) & "',DaysAbsent='" & AbsentAttendanceCount(4) & "',DaysLate='" & LateAttendanceCount(4) & "' where idyellowfoxesdata=5"
                    COMMAND4 = New MySqlCommand(Query4, MySqlConn)
                    Reader = COMMAND4.ExecuteReader
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try
            End If

            If attendancerecorded(5) = "Present" Then
                MySqlConn.Open()
                Query1 = "select DaysPresent from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(5) & "' and StudentFirstName = '" & StudentFirstName(5) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(5) = Int(Reader.GetString("DaysPresent")) + 1
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(5) & "' and StudentFirstName = '" & StudentFirstName(5) & "'"
                    COMMAND2 = New MySqlCommand(Query2, MySqlConn)
                    Reader = COMMAND2.ExecuteReader

                    Reader.Read()
                    AbsentAttendanceCount(5) = Int(Reader.GetString("DaysAbsent"))
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try

                Try
                    MySqlConn.Open()
                    Query3 = "select DaysLate from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(5) & "' and StudentFirstName = '" & StudentFirstName(5) & "'"
                    COMMAND3 = New MySqlCommand(Query3, MySqlConn)
                    Reader = COMMAND3.ExecuteReader

                    Reader.Read()
                    LateAttendanceCount(5) = Int(Reader.GetString("DaysLate"))
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try

                Try
                    MySqlConn.Open()
                    Query4 = "update abisattendancesystem.yellowfoxesdata set idyellowfoxesdata=6,StudentFirstName='" & StudentFirstName(5) & "',StudentLastName='" & StudentLastName(5) & "',DaysPresent='" & PresentAttendanceCount(5) & "',DaysAbsent='" & AbsentAttendanceCount(5) & "',DaysLate='" & LateAttendanceCount(5) & "' where idyellowfoxesdata=6"
                    COMMAND4 = New MySqlCommand(Query4, MySqlConn)
                    Reader = COMMAND4.ExecuteReader
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try
            ElseIf attendancerecorded(5) = "Absent" Then
                MySqlConn.Open()
                Query1 = "select DaysPresent from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(5) & "' and StudentFirstName = '" & StudentFirstName(5) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(5) = Int(Reader.GetString("DaysPresent"))
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(5) & "' and StudentFirstName = '" & StudentFirstName(5) & "'"
                    COMMAND2 = New MySqlCommand(Query2, MySqlConn)
                    Reader = COMMAND2.ExecuteReader

                    Reader.Read()
                    AbsentAttendanceCount(5) = Int(Reader.GetString("DaysAbsent")) + 1
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try

                Try
                    MySqlConn.Open()
                    Query3 = "select DaysLate from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(5) & "' and StudentFirstName = '" & StudentFirstName(5) & "'"
                    COMMAND3 = New MySqlCommand(Query3, MySqlConn)
                    Reader = COMMAND3.ExecuteReader

                    Reader.Read()
                    LateAttendanceCount(5) = Int(Reader.GetString("DaysLate"))
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try

                Try
                    MySqlConn.Open()
                    Query4 = "update abisattendancesystem.yellowfoxesdata set idyellowfoxesdata=6,StudentFirstName='" & StudentFirstName(5) & "',StudentLastName='" & StudentLastName(5) & "',DaysPresent='" & PresentAttendanceCount(5) & "',DaysAbsent='" & AbsentAttendanceCount(5) & "',DaysLate='" & LateAttendanceCount(5) & "' where idyellowfoxesdata=6"
                    COMMAND4 = New MySqlCommand(Query4, MySqlConn)
                    Reader = COMMAND4.ExecuteReader
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try
            Else
                MySqlConn.Open()
                Query1 = "select DaysPresent from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(5) & "' and StudentFirstName = '" & StudentFirstName(5) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(5) = Int(Reader.GetString("DaysPresent"))
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(5) & "' and StudentFirstName = '" & StudentFirstName(5) & "'"
                    COMMAND2 = New MySqlCommand(Query2, MySqlConn)
                    Reader = COMMAND2.ExecuteReader

                    Reader.Read()
                    AbsentAttendanceCount(5) = Int(Reader.GetString("DaysAbsent"))
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try

                Try
                    MySqlConn.Open()
                    Query3 = "select DaysLate from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(5) & "' and StudentFirstName = '" & StudentFirstName(5) & "'"
                    COMMAND3 = New MySqlCommand(Query3, MySqlConn)
                    Reader = COMMAND3.ExecuteReader

                    Reader.Read()
                    LateAttendanceCount(5) = Int(Reader.GetString("DaysLate")) + 1
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try

                Try
                    MySqlConn.Open()
                    Query4 = "update abisattendancesystem.yellowfoxesdata set idyellowfoxesdata=6,StudentFirstName='" & StudentFirstName(5) & "',StudentLastName='" & StudentLastName(5) & "',DaysPresent='" & PresentAttendanceCount(5) & "',DaysAbsent='" & AbsentAttendanceCount(5) & "',DaysLate='" & LateAttendanceCount(5) & "' where idyellowfoxesdata=6"
                    COMMAND4 = New MySqlCommand(Query4, MySqlConn)
                    Reader = COMMAND4.ExecuteReader
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try
            End If

            If attendancerecorded(6) = "Present" Then
                MySqlConn.Open()
                Query1 = "select DaysPresent from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(6) & "' and StudentFirstName = '" & StudentFirstName(6) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(6) = Int(Reader.GetString("DaysPresent")) + 1
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(6) & "' and StudentFirstName = '" & StudentFirstName(6) & "'"
                    COMMAND2 = New MySqlCommand(Query2, MySqlConn)
                    Reader = COMMAND2.ExecuteReader

                    Reader.Read()
                    AbsentAttendanceCount(6) = Int(Reader.GetString("DaysAbsent"))
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try

                Try
                    MySqlConn.Open()
                    Query3 = "select DaysLate from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(6) & "' and StudentFirstName = '" & StudentFirstName(6) & "'"
                    COMMAND3 = New MySqlCommand(Query3, MySqlConn)
                    Reader = COMMAND3.ExecuteReader

                    Reader.Read()
                    LateAttendanceCount(6) = Int(Reader.GetString("DaysLate"))
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try

                Try
                    MySqlConn.Open()
                    Query4 = "update abisattendancesystem.yellowfoxesdata set idyellowfoxesdata=7,StudentFirstName='" & StudentFirstName(6) & "',StudentLastName='" & StudentLastName(6) & "',DaysPresent='" & PresentAttendanceCount(6) & "',DaysAbsent='" & AbsentAttendanceCount(6) & "',DaysLate='" & LateAttendanceCount(6) & "' where idyellowfoxesdata=7"
                    COMMAND4 = New MySqlCommand(Query4, MySqlConn)
                    Reader = COMMAND4.ExecuteReader
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try
            ElseIf attendancerecorded(6) = "Absent" Then
                MySqlConn.Open()
                Query1 = "select DaysPresent from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(6) & "' and StudentFirstName = '" & StudentFirstName(6) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(6) = Int(Reader.GetString("DaysPresent"))
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(6) & "' and StudentFirstName = '" & StudentFirstName(6) & "'"
                    COMMAND2 = New MySqlCommand(Query2, MySqlConn)
                    Reader = COMMAND2.ExecuteReader

                    Reader.Read()
                    AbsentAttendanceCount(6) = Int(Reader.GetString("DaysAbsent")) + 1
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try

                Try
                    MySqlConn.Open()
                    Query3 = "select DaysLate from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(6) & "' and StudentFirstName = '" & StudentFirstName(6) & "'"
                    COMMAND3 = New MySqlCommand(Query3, MySqlConn)
                    Reader = COMMAND3.ExecuteReader

                    Reader.Read()
                    LateAttendanceCount(6) = Int(Reader.GetString("DaysLate"))
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try

                Try
                    MySqlConn.Open()
                    Query4 = "update abisattendancesystem.yellowfoxesdata set idyellowfoxesdata=7,StudentFirstName='" & StudentFirstName(6) & "',StudentLastName='" & StudentLastName(6) & "',DaysPresent='" & PresentAttendanceCount(6) & "',DaysAbsent='" & AbsentAttendanceCount(6) & "',DaysLate='" & LateAttendanceCount(6) & "' where idyellowfoxesdata=7"
                    COMMAND4 = New MySqlCommand(Query4, MySqlConn)
                    Reader = COMMAND4.ExecuteReader
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try
            Else
                MySqlConn.Open()
                Query1 = "select DaysPresent from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(6) & "' and StudentFirstName = '" & StudentFirstName(6) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(6) = Int(Reader.GetString("DaysPresent"))
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(6) & "' and StudentFirstName = '" & StudentFirstName(6) & "'"
                    COMMAND2 = New MySqlCommand(Query2, MySqlConn)
                    Reader = COMMAND2.ExecuteReader

                    Reader.Read()
                    AbsentAttendanceCount(6) = Int(Reader.GetString("DaysAbsent"))
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try

                Try
                    MySqlConn.Open()
                    Query3 = "select DaysLate from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(6) & "' and StudentFirstName = '" & StudentFirstName(6) & "'"
                    COMMAND3 = New MySqlCommand(Query3, MySqlConn)
                    Reader = COMMAND3.ExecuteReader

                    Reader.Read()
                    LateAttendanceCount(6) = Int(Reader.GetString("DaysLate")) + 1
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try

                Try
                    MySqlConn.Open()
                    Query4 = "update abisattendancesystem.yellowfoxesdata set idyellowfoxesdata=7,StudentFirstName='" & StudentFirstName(6) & "',StudentLastName='" & StudentLastName(6) & "',DaysPresent='" & PresentAttendanceCount(6) & "',DaysAbsent='" & AbsentAttendanceCount(6) & "',DaysLate='" & LateAttendanceCount(6) & "' where idyellowfoxesdata=7"
                    COMMAND4 = New MySqlCommand(Query4, MySqlConn)
                    Reader = COMMAND4.ExecuteReader
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try
            End If

            If attendancerecorded(7) = "Present" Then
                MySqlConn.Open()
                Query1 = "select DaysPresent from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(7) & "' and StudentFirstName = '" & StudentFirstName(7) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(7) = Int(Reader.GetString("DaysPresent")) + 1
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(7) & "' and StudentFirstName = '" & StudentFirstName(7) & "'"
                    COMMAND2 = New MySqlCommand(Query2, MySqlConn)
                    Reader = COMMAND2.ExecuteReader

                    Reader.Read()
                    AbsentAttendanceCount(7) = Int(Reader.GetString("DaysAbsent"))
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try

                Try
                    MySqlConn.Open()
                    Query3 = "select DaysLate from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(7) & "' and StudentFirstName = '" & StudentFirstName(7) & "'"
                    COMMAND3 = New MySqlCommand(Query3, MySqlConn)
                    Reader = COMMAND3.ExecuteReader

                    Reader.Read()
                    LateAttendanceCount(7) = Int(Reader.GetString("DaysLate"))
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try

                Try
                    MySqlConn.Open()
                    Query4 = "update abisattendancesystem.yellowfoxesdata set idyellowfoxesdata=8,StudentFirstName='" & StudentFirstName(7) & "',StudentLastName='" & StudentLastName(7) & "',DaysPresent='" & PresentAttendanceCount(7) & "',DaysAbsent='" & AbsentAttendanceCount(7) & "',DaysLate='" & LateAttendanceCount(7) & "' where idyellowfoxesdata=8"
                    COMMAND4 = New MySqlCommand(Query4, MySqlConn)
                    Reader = COMMAND4.ExecuteReader
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try
            ElseIf attendancerecorded(7) = "Absent" Then
                MySqlConn.Open()
                Query1 = "select DaysPresent from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(7) & "' and StudentFirstName = '" & StudentFirstName(7) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(7) = Int(Reader.GetString("DaysPresent"))
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(7) & "' and StudentFirstName = '" & StudentFirstName(7) & "'"
                    COMMAND2 = New MySqlCommand(Query2, MySqlConn)
                    Reader = COMMAND2.ExecuteReader

                    Reader.Read()
                    AbsentAttendanceCount(7) = Int(Reader.GetString("DaysAbsent")) + 1
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try

                Try
                    MySqlConn.Open()
                    Query3 = "select DaysLate from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(7) & "' and StudentFirstName = '" & StudentFirstName(7) & "'"
                    COMMAND3 = New MySqlCommand(Query3, MySqlConn)
                    Reader = COMMAND3.ExecuteReader

                    Reader.Read()
                    LateAttendanceCount(7) = Int(Reader.GetString("DaysLate"))
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try

                Try
                    MySqlConn.Open()
                    Query4 = "update abisattendancesystem.yellowfoxesdata set idyellowfoxesdata=8,StudentFirstName='" & StudentFirstName(7) & "',StudentLastName='" & StudentLastName(7) & "',DaysPresent='" & PresentAttendanceCount(7) & "',DaysAbsent='" & AbsentAttendanceCount(7) & "',DaysLate='" & LateAttendanceCount(7) & "' where idyellowfoxesdata=8"
                    COMMAND4 = New MySqlCommand(Query4, MySqlConn)
                    Reader = COMMAND4.ExecuteReader
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try
            Else
                MySqlConn.Open()
                Query1 = "select DaysPresent from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(7) & "' and StudentFirstName = '" & StudentFirstName(7) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(7) = Int(Reader.GetString("DaysPresent"))
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(7) & "' and StudentFirstName = '" & StudentFirstName(7) & "'"
                    COMMAND2 = New MySqlCommand(Query2, MySqlConn)
                    Reader = COMMAND2.ExecuteReader

                    Reader.Read()
                    AbsentAttendanceCount(7) = Int(Reader.GetString("DaysAbsent"))
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try

                Try
                    MySqlConn.Open()
                    Query3 = "select DaysLate from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(7) & "' and StudentFirstName = '" & StudentFirstName(7) & "'"
                    COMMAND3 = New MySqlCommand(Query3, MySqlConn)
                    Reader = COMMAND3.ExecuteReader

                    Reader.Read()
                    LateAttendanceCount(7) = Int(Reader.GetString("DaysLate")) + 1
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try

                Try
                    MySqlConn.Open()
                    Query4 = "update abisattendancesystem.yellowfoxesdata set idyellowfoxesdata=8,StudentFirstName='" & StudentFirstName(7) & "',StudentLastName='" & StudentLastName(7) & "',DaysPresent='" & PresentAttendanceCount(7) & "',DaysAbsent='" & AbsentAttendanceCount(7) & "',DaysLate='" & LateAttendanceCount(7) & "' where idyellowfoxesdata=8"
                    COMMAND4 = New MySqlCommand(Query4, MySqlConn)
                    Reader = COMMAND4.ExecuteReader
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try
            End If

            If attendancerecorded(8) = "Present" Then
                MySqlConn.Open()
                Query1 = "select DaysPresent from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(8) & "' and StudentFirstName = '" & StudentFirstName(8) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(8) = Int(Reader.GetString("DaysPresent")) + 1
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(8) & "' and StudentFirstName = '" & StudentFirstName(8) & "'"
                    COMMAND2 = New MySqlCommand(Query2, MySqlConn)
                    Reader = COMMAND2.ExecuteReader

                    Reader.Read()
                    AbsentAttendanceCount(8) = Int(Reader.GetString("DaysAbsent"))
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try

                Try
                    MySqlConn.Open()
                    Query3 = "select DaysLate from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(8) & "' and StudentFirstName = '" & StudentFirstName(8) & "'"
                    COMMAND3 = New MySqlCommand(Query3, MySqlConn)
                    Reader = COMMAND3.ExecuteReader

                    Reader.Read()
                    LateAttendanceCount(8) = Int(Reader.GetString("DaysLate"))
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try

                Try
                    MySqlConn.Open()
                    Query4 = "update abisattendancesystem.yellowfoxesdata set idyellowfoxesdata=9,StudentFirstName='" & StudentFirstName(8) & "',StudentLastName='" & StudentLastName(8) & "',DaysPresent='" & PresentAttendanceCount(8) & "',DaysAbsent='" & AbsentAttendanceCount(8) & "',DaysLate='" & LateAttendanceCount(8) & "' where idyellowfoxesdata=9"
                    COMMAND4 = New MySqlCommand(Query4, MySqlConn)
                    Reader = COMMAND4.ExecuteReader
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try
            ElseIf attendancerecorded(8) = "Absent" Then
                MySqlConn.Open()
                Query1 = "select DaysPresent from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(8) & "' and StudentFirstName = '" & StudentFirstName(8) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(8) = Int(Reader.GetString("DaysPresent"))
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(8) & "' and StudentFirstName = '" & StudentFirstName(8) & "'"
                    COMMAND2 = New MySqlCommand(Query2, MySqlConn)
                    Reader = COMMAND2.ExecuteReader

                    Reader.Read()
                    AbsentAttendanceCount(8) = Int(Reader.GetString("DaysAbsent")) + 1
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try

                Try
                    MySqlConn.Open()
                    Query3 = "select DaysLate from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(8) & "' and StudentFirstName = '" & StudentFirstName(8) & "'"
                    COMMAND3 = New MySqlCommand(Query3, MySqlConn)
                    Reader = COMMAND3.ExecuteReader

                    Reader.Read()
                    LateAttendanceCount(8) = Int(Reader.GetString("DaysLate"))
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try

                Try
                    MySqlConn.Open()
                    Query4 = "update abisattendancesystem.yellowfoxesdata set idyellowfoxesdata=9,StudentFirstName='" & StudentFirstName(8) & "',StudentLastName='" & StudentLastName(8) & "',DaysPresent='" & PresentAttendanceCount(8) & "',DaysAbsent='" & AbsentAttendanceCount(8) & "',DaysLate='" & LateAttendanceCount(8) & "' where idyellowfoxesdata=9"
                    COMMAND4 = New MySqlCommand(Query4, MySqlConn)
                    Reader = COMMAND4.ExecuteReader
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try
            Else
                MySqlConn.Open()
                Query1 = "select DaysPresent from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(8) & "' and StudentFirstName = '" & StudentFirstName(8) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(8) = Int(Reader.GetString("DaysPresent"))
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(8) & "' and StudentFirstName = '" & StudentFirstName(8) & "'"
                    COMMAND2 = New MySqlCommand(Query2, MySqlConn)
                    Reader = COMMAND2.ExecuteReader

                    Reader.Read()
                    AbsentAttendanceCount(8) = Int(Reader.GetString("DaysAbsent"))
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try

                Try
                    MySqlConn.Open()
                    Query3 = "select DaysLate from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(8) & "' and StudentFirstName = '" & StudentFirstName(8) & "'"
                    COMMAND3 = New MySqlCommand(Query3, MySqlConn)
                    Reader = COMMAND3.ExecuteReader

                    Reader.Read()
                    LateAttendanceCount(8) = Int(Reader.GetString("DaysLate")) + 1
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try

                Try
                    MySqlConn.Open()
                    Query4 = "update abisattendancesystem.yellowfoxesdata set idyellowfoxesdata=9,StudentFirstName='" & StudentFirstName(8) & "',StudentLastName='" & StudentLastName(8) & "',DaysPresent='" & PresentAttendanceCount(8) & "',DaysAbsent='" & AbsentAttendanceCount(8) & "',DaysLate='" & LateAttendanceCount(8) & "' where idyellowfoxesdata=9"
                    COMMAND4 = New MySqlCommand(Query4, MySqlConn)
                    Reader = COMMAND4.ExecuteReader
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try
            End If

            If attendancerecorded(9) = "Present" Then
                MySqlConn.Open()
                Query1 = "select DaysPresent from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(9) & "' and StudentFirstName = '" & StudentFirstName(9) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(9) = Int(Reader.GetString("DaysPresent")) + 1
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(9) & "' and StudentFirstName = '" & StudentFirstName(9) & "'"
                    COMMAND2 = New MySqlCommand(Query2, MySqlConn)
                    Reader = COMMAND2.ExecuteReader

                    Reader.Read()
                    AbsentAttendanceCount(9) = Int(Reader.GetString("DaysAbsent"))
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try

                Try
                    MySqlConn.Open()
                    Query3 = "select DaysLate from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(9) & "' and StudentFirstName = '" & StudentFirstName(9) & "'"
                    COMMAND3 = New MySqlCommand(Query3, MySqlConn)
                    Reader = COMMAND3.ExecuteReader

                    Reader.Read()
                    LateAttendanceCount(9) = Int(Reader.GetString("DaysLate"))
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try

                Try
                    MySqlConn.Open()
                    Query4 = "update abisattendancesystem.yellowfoxesdata set idyellowfoxesdata=10,StudentFirstName='" & StudentFirstName(9) & "',StudentLastName='" & StudentLastName(9) & "',DaysPresent='" & PresentAttendanceCount(9) & "',DaysAbsent='" & AbsentAttendanceCount(9) & "',DaysLate='" & LateAttendanceCount(9) & "' where idyellowfoxesdata=10"
                    COMMAND4 = New MySqlCommand(Query4, MySqlConn)
                    Reader = COMMAND4.ExecuteReader
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try
            ElseIf attendancerecorded(9) = "Absent" Then
                MySqlConn.Open()
                Query1 = "select DaysPresent from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(9) & "' and StudentFirstName = '" & StudentFirstName(9) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(9) = Int(Reader.GetString("DaysPresent"))
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(9) & "' and StudentFirstName = '" & StudentFirstName(9) & "'"
                    COMMAND2 = New MySqlCommand(Query2, MySqlConn)
                    Reader = COMMAND2.ExecuteReader

                    Reader.Read()
                    AbsentAttendanceCount(9) = Int(Reader.GetString("DaysAbsent")) + 1
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try

                Try
                    MySqlConn.Open()
                    Query3 = "select DaysLate from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(9) & "' and StudentFirstName = '" & StudentFirstName(9) & "'"
                    COMMAND3 = New MySqlCommand(Query3, MySqlConn)
                    Reader = COMMAND3.ExecuteReader

                    Reader.Read()
                    LateAttendanceCount(9) = Int(Reader.GetString("DaysLate"))
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try

                Try
                    MySqlConn.Open()
                    Query4 = "update abisattendancesystem.yellowfoxesdata set idyellowfoxesdata=10,StudentFirstName='" & StudentFirstName(9) & "',StudentLastName='" & StudentLastName(9) & "',DaysPresent='" & PresentAttendanceCount(9) & "',DaysAbsent='" & AbsentAttendanceCount(9) & "',DaysLate='" & LateAttendanceCount(9) & "' where idyellowfoxesdata=10"
                    COMMAND4 = New MySqlCommand(Query4, MySqlConn)
                    Reader = COMMAND4.ExecuteReader
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try
            Else
                MySqlConn.Open()
                Query1 = "select DaysPresent from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(9) & "' and StudentFirstName = '" & StudentFirstName(9) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(9) = Int(Reader.GetString("DaysPresent"))
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(9) & "' and StudentFirstName = '" & StudentFirstName(9) & "'"
                    COMMAND2 = New MySqlCommand(Query2, MySqlConn)
                    Reader = COMMAND2.ExecuteReader

                    Reader.Read()
                    AbsentAttendanceCount(9) = Int(Reader.GetString("DaysAbsent"))
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try

                Try
                    MySqlConn.Open()
                    Query3 = "select DaysLate from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(9) & "' and StudentFirstName = '" & StudentFirstName(9) & "'"
                    COMMAND3 = New MySqlCommand(Query3, MySqlConn)
                    Reader = COMMAND3.ExecuteReader

                    Reader.Read()
                    LateAttendanceCount(9) = Int(Reader.GetString("DaysLate")) + 1
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try

                Try
                    MySqlConn.Open()
                    Query4 = "update abisattendancesystem.yellowfoxesdata set idyellowfoxesdata=10,StudentFirstName='" & StudentFirstName(9) & "',StudentLastName='" & StudentLastName(9) & "',DaysPresent='" & PresentAttendanceCount(9) & "',DaysAbsent='" & AbsentAttendanceCount(9) & "',DaysLate='" & LateAttendanceCount(9) & "' where idyellowfoxesdata=10"
                    COMMAND4 = New MySqlCommand(Query4, MySqlConn)
                    Reader = COMMAND4.ExecuteReader
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try
            End If

            If attendancerecorded(10) = "Present" Then
                MySqlConn.Open()
                Query1 = "select DaysPresent from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(10) & "' and StudentFirstName = '" & StudentFirstName(10) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(10) = Int(Reader.GetString("DaysPresent")) + 1
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(10) & "' and StudentFirstName = '" & StudentFirstName(10) & "'"
                    COMMAND2 = New MySqlCommand(Query2, MySqlConn)
                    Reader = COMMAND2.ExecuteReader

                    Reader.Read()
                    AbsentAttendanceCount(10) = Int(Reader.GetString("DaysAbsent"))
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try

                Try
                    MySqlConn.Open()
                    Query3 = "select DaysLate from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(10) & "' and StudentFirstName = '" & StudentFirstName(10) & "'"
                    COMMAND3 = New MySqlCommand(Query3, MySqlConn)
                    Reader = COMMAND3.ExecuteReader

                    Reader.Read()
                    LateAttendanceCount(10) = Int(Reader.GetString("DaysLate"))
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try

                Try
                    MySqlConn.Open()
                    Query4 = "update abisattendancesystem.yellowfoxesdata set idyellowfoxesdata=11,StudentFirstName='" & StudentFirstName(10) & "',StudentLastName='" & StudentLastName(10) & "',DaysPresent='" & PresentAttendanceCount(10) & "',DaysAbsent='" & AbsentAttendanceCount(10) & "',DaysLate='" & LateAttendanceCount(10) & "' where idyellowfoxesdata=11"
                    COMMAND4 = New MySqlCommand(Query4, MySqlConn)
                    Reader = COMMAND4.ExecuteReader
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try
            ElseIf attendancerecorded(10) = "Absent" Then
                MySqlConn.Open()
                Query1 = "select DaysPresent from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(10) & "' and StudentFirstName = '" & StudentFirstName(10) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(10) = Int(Reader.GetString("DaysPresent"))
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(10) & "' and StudentFirstName = '" & StudentFirstName(10) & "'"
                    COMMAND2 = New MySqlCommand(Query2, MySqlConn)
                    Reader = COMMAND2.ExecuteReader

                    Reader.Read()
                    AbsentAttendanceCount(10) = Int(Reader.GetString("DaysAbsent")) + 1
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try

                Try
                    MySqlConn.Open()
                    Query3 = "select DaysLate from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(10) & "' and StudentFirstName = '" & StudentFirstName(10) & "'"
                    COMMAND3 = New MySqlCommand(Query3, MySqlConn)
                    Reader = COMMAND3.ExecuteReader

                    Reader.Read()
                    LateAttendanceCount(10) = Int(Reader.GetString("DaysLate"))
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try

                Try
                    MySqlConn.Open()
                    Query4 = "update abisattendancesystem.yellowfoxesdata set idyellowfoxesdata=11,StudentFirstName='" & StudentFirstName(10) & "',StudentLastName='" & StudentLastName(10) & "',DaysPresent='" & PresentAttendanceCount(10) & "',DaysAbsent='" & AbsentAttendanceCount(10) & "',DaysLate='" & LateAttendanceCount(10) & "' where idyellowfoxesdata=11"
                    COMMAND4 = New MySqlCommand(Query4, MySqlConn)
                    Reader = COMMAND4.ExecuteReader
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try
            Else
                MySqlConn.Open()
                Query1 = "select DaysPresent from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(10) & "' and StudentFirstName = '" & StudentFirstName(10) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(10) = Int(Reader.GetString("DaysPresent"))
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(10) & "' and StudentFirstName = '" & StudentFirstName(10) & "'"
                    COMMAND2 = New MySqlCommand(Query2, MySqlConn)
                    Reader = COMMAND2.ExecuteReader

                    Reader.Read()
                    AbsentAttendanceCount(10) = Int(Reader.GetString("DaysAbsent"))
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try

                Try
                    MySqlConn.Open()
                    Query3 = "select DaysLate from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(10) & "' and StudentFirstName = '" & StudentFirstName(10) & "'"
                    COMMAND3 = New MySqlCommand(Query3, MySqlConn)
                    Reader = COMMAND3.ExecuteReader

                    Reader.Read()
                    LateAttendanceCount(10) = Int(Reader.GetString("DaysLate")) + 1
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try

                Try
                    MySqlConn.Open()
                    Query4 = "update abisattendancesystem.yellowfoxesdata set idyellowfoxesdata=11,StudentFirstName='" & StudentFirstName(10) & "',StudentLastName='" & StudentLastName(10) & "',DaysPresent='" & PresentAttendanceCount(10) & "',DaysAbsent='" & AbsentAttendanceCount(10) & "',DaysLate='" & LateAttendanceCount(10) & "' where idyellowfoxesdata=11"
                    COMMAND4 = New MySqlCommand(Query4, MySqlConn)
                    Reader = COMMAND4.ExecuteReader
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try
            End If

            If attendancerecorded(11) = "Present" Then
                MySqlConn.Open()
                Query1 = "select DaysPresent from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(11) & "' and StudentFirstName = '" & StudentFirstName(11) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(11) = Int(Reader.GetString("DaysPresent")) + 1
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(11) & "' and StudentFirstName = '" & StudentFirstName(11) & "'"
                    COMMAND2 = New MySqlCommand(Query2, MySqlConn)
                    Reader = COMMAND2.ExecuteReader

                    Reader.Read()
                    AbsentAttendanceCount(11) = Int(Reader.GetString("DaysAbsent"))
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try

                Try
                    MySqlConn.Open()
                    Query3 = "select DaysLate from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(11) & "' and StudentFirstName = '" & StudentFirstName(11) & "'"
                    COMMAND3 = New MySqlCommand(Query3, MySqlConn)
                    Reader = COMMAND3.ExecuteReader

                    Reader.Read()
                    LateAttendanceCount(11) = Int(Reader.GetString("DaysLate"))
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try

                Try
                    MySqlConn.Open()
                    Query4 = "update abisattendancesystem.yellowfoxesdata set idyellowfoxesdata=12,StudentFirstName='" & StudentFirstName(11) & "',StudentLastName='" & StudentLastName(11) & "',DaysPresent='" & PresentAttendanceCount(11) & "',DaysAbsent='" & AbsentAttendanceCount(11) & "',DaysLate='" & LateAttendanceCount(11) & "' where idyellowfoxesdata=12"
                    COMMAND4 = New MySqlCommand(Query4, MySqlConn)
                    Reader = COMMAND4.ExecuteReader
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try
            ElseIf attendancerecorded(11) = "Absent" Then
                MySqlConn.Open()
                Query1 = "select DaysPresent from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(11) & "' and StudentFirstName = '" & StudentFirstName(11) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(11) = Int(Reader.GetString("DaysPresent"))
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(11) & "' and StudentFirstName = '" & StudentFirstName(11) & "'"
                    COMMAND2 = New MySqlCommand(Query2, MySqlConn)
                    Reader = COMMAND2.ExecuteReader

                    Reader.Read()
                    AbsentAttendanceCount(11) = Int(Reader.GetString("DaysAbsent")) + 1
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try

                Try
                    MySqlConn.Open()
                    Query3 = "select DaysLate from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(11) & "' and StudentFirstName = '" & StudentFirstName(11) & "'"
                    COMMAND3 = New MySqlCommand(Query3, MySqlConn)
                    Reader = COMMAND3.ExecuteReader

                    Reader.Read()
                    LateAttendanceCount(11) = Int(Reader.GetString("DaysLate"))
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try

                Try
                    MySqlConn.Open()
                    Query4 = "update abisattendancesystem.yellowfoxesdata set idyellowfoxesdata=12,StudentFirstName='" & StudentFirstName(11) & "',StudentLastName='" & StudentLastName(11) & "',DaysPresent='" & PresentAttendanceCount(11) & "',DaysAbsent='" & AbsentAttendanceCount(11) & "',DaysLate='" & LateAttendanceCount(11) & "' where idyellowfoxesdata=12"
                    COMMAND4 = New MySqlCommand(Query4, MySqlConn)
                    Reader = COMMAND4.ExecuteReader
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try
            Else
                MySqlConn.Open()
                Query1 = "select DaysPresent from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(11) & "' and StudentFirstName = '" & StudentFirstName(11) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(11) = Int(Reader.GetString("DaysPresent"))
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(11) & "' and StudentFirstName = '" & StudentFirstName(11) & "'"
                    COMMAND2 = New MySqlCommand(Query2, MySqlConn)
                    Reader = COMMAND2.ExecuteReader

                    Reader.Read()
                    AbsentAttendanceCount(11) = Int(Reader.GetString("DaysAbsent"))
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try

                Try
                    MySqlConn.Open()
                    Query3 = "select DaysLate from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(11) & "' and StudentFirstName = '" & StudentFirstName(11) & "'"
                    COMMAND3 = New MySqlCommand(Query3, MySqlConn)
                    Reader = COMMAND3.ExecuteReader

                    Reader.Read()
                    LateAttendanceCount(11) = Int(Reader.GetString("DaysLate")) + 1
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try

                Try
                    MySqlConn.Open()
                    Query4 = "update abisattendancesystem.yellowfoxesdata set idyellowfoxesdata=12,StudentFirstName='" & StudentFirstName(11) & "',StudentLastName='" & StudentLastName(11) & "',DaysPresent='" & PresentAttendanceCount(11) & "',DaysAbsent='" & AbsentAttendanceCount(11) & "',DaysLate='" & LateAttendanceCount(11) & "' where idyellowfoxesdata=12"
                    COMMAND4 = New MySqlCommand(Query4, MySqlConn)
                    Reader = COMMAND4.ExecuteReader
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try
            End If

            If attendancerecorded(12) = "Present" Then
                MySqlConn.Open()
                Query1 = "select DaysPresent from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(12) & "' and StudentFirstName = '" & StudentFirstName(12) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(12) = Int(Reader.GetString("DaysPresent")) + 1
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(12) & "' and StudentFirstName = '" & StudentFirstName(12) & "'"
                    COMMAND2 = New MySqlCommand(Query2, MySqlConn)
                    Reader = COMMAND2.ExecuteReader

                    Reader.Read()
                    AbsentAttendanceCount(12) = Int(Reader.GetString("DaysAbsent"))
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try

                Try
                    MySqlConn.Open()
                    Query3 = "select DaysLate from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(12) & "' and StudentFirstName = '" & StudentFirstName(12) & "'"
                    COMMAND3 = New MySqlCommand(Query3, MySqlConn)
                    Reader = COMMAND3.ExecuteReader

                    Reader.Read()
                    LateAttendanceCount(12) = Int(Reader.GetString("DaysLate"))
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try

                Try
                    MySqlConn.Open()
                    Query4 = "update abisattendancesystem.yellowfoxesdata set idyellowfoxesdata=13,StudentFirstName='" & StudentFirstName(12) & "',StudentLastName='" & StudentLastName(12) & "',DaysPresent='" & PresentAttendanceCount(12) & "',DaysAbsent='" & AbsentAttendanceCount(12) & "',DaysLate='" & LateAttendanceCount(12) & "' where idyellowfoxesdata=13"
                    COMMAND4 = New MySqlCommand(Query4, MySqlConn)
                    Reader = COMMAND4.ExecuteReader
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try
            ElseIf attendancerecorded(12) = "Absent" Then
                MySqlConn.Open()
                Query1 = "select DaysPresent from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(12) & "' and StudentFirstName = '" & StudentFirstName(12) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(12) = Int(Reader.GetString("DaysPresent"))
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(12) & "' and StudentFirstName = '" & StudentFirstName(12) & "'"
                    COMMAND2 = New MySqlCommand(Query2, MySqlConn)
                    Reader = COMMAND2.ExecuteReader

                    Reader.Read()
                    AbsentAttendanceCount(12) = Int(Reader.GetString("DaysAbsent")) + 1
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try

                Try
                    MySqlConn.Open()
                    Query3 = "select DaysLate from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(12) & "' and StudentFirstName = '" & StudentFirstName(12) & "'"
                    COMMAND3 = New MySqlCommand(Query3, MySqlConn)
                    Reader = COMMAND3.ExecuteReader

                    Reader.Read()
                    LateAttendanceCount(12) = Int(Reader.GetString("DaysLate"))
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try

                Try
                    MySqlConn.Open()
                    Query4 = "update abisattendancesystem.yellowfoxesdata set idyellowfoxesdata=13,StudentFirstName='" & StudentFirstName(12) & "',StudentLastName='" & StudentLastName(12) & "',DaysPresent='" & PresentAttendanceCount(12) & "',DaysAbsent='" & AbsentAttendanceCount(12) & "',DaysLate='" & LateAttendanceCount(12) & "' where idyellowfoxesdata=13"
                    COMMAND4 = New MySqlCommand(Query4, MySqlConn)
                    Reader = COMMAND4.ExecuteReader
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try
            Else
                MySqlConn.Open()
                Query1 = "select DaysPresent from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(12) & "' and StudentFirstName = '" & StudentFirstName(12) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(12) = Int(Reader.GetString("DaysPresent"))
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(12) & "' and StudentFirstName = '" & StudentFirstName(12) & "'"
                    COMMAND2 = New MySqlCommand(Query2, MySqlConn)
                    Reader = COMMAND2.ExecuteReader

                    Reader.Read()
                    AbsentAttendanceCount(12) = Int(Reader.GetString("DaysAbsent"))
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try

                Try
                    MySqlConn.Open()
                    Query3 = "select DaysLate from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(12) & "' and StudentFirstName = '" & StudentFirstName(12) & "'"
                    COMMAND3 = New MySqlCommand(Query3, MySqlConn)
                    Reader = COMMAND3.ExecuteReader

                    Reader.Read()
                    LateAttendanceCount(12) = Int(Reader.GetString("DaysLate")) + 1
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try

                Try
                    MySqlConn.Open()
                    Query4 = "update abisattendancesystem.yellowfoxesdata set idyellowfoxesdata=13,StudentFirstName='" & StudentFirstName(12) & "',StudentLastName='" & StudentLastName(12) & "',DaysPresent='" & PresentAttendanceCount(12) & "',DaysAbsent='" & AbsentAttendanceCount(12) & "',DaysLate='" & LateAttendanceCount(12) & "' where idyellowfoxesdata=13"
                    COMMAND4 = New MySqlCommand(Query4, MySqlConn)
                    Reader = COMMAND4.ExecuteReader
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try
            End If

            If attendancerecorded(13) = "Present" Then
                MySqlConn.Open()
                Query1 = "select DaysPresent from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(13) & "' and StudentFirstName = '" & StudentFirstName(13) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(13) = Int(Reader.GetString("DaysPresent")) + 1
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(13) & "' and StudentFirstName = '" & StudentFirstName(13) & "'"
                    COMMAND2 = New MySqlCommand(Query2, MySqlConn)
                    Reader = COMMAND2.ExecuteReader

                    Reader.Read()
                    AbsentAttendanceCount(13) = Int(Reader.GetString("DaysAbsent"))
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try

                Try
                    MySqlConn.Open()
                    Query3 = "select DaysLate from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(13) & "' and StudentFirstName = '" & StudentFirstName(13) & "'"
                    COMMAND3 = New MySqlCommand(Query3, MySqlConn)
                    Reader = COMMAND3.ExecuteReader

                    Reader.Read()
                    LateAttendanceCount(13) = Int(Reader.GetString("DaysLate"))
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try

                Try
                    MySqlConn.Open()
                    Query4 = "update abisattendancesystem.yellowfoxesdata set idyellowfoxesdata=14,StudentFirstName='" & StudentFirstName(13) & "',StudentLastName='" & StudentLastName(13) & "',DaysPresent='" & PresentAttendanceCount(13) & "',DaysAbsent='" & AbsentAttendanceCount(13) & "',DaysLate='" & LateAttendanceCount(13) & "' where idyellowfoxesdata=14"
                    COMMAND4 = New MySqlCommand(Query4, MySqlConn)
                    Reader = COMMAND4.ExecuteReader
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try
            ElseIf attendancerecorded(13) = "Absent" Then
                MySqlConn.Open()
                Query1 = "select DaysPresent from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(13) & "' and StudentFirstName = '" & StudentFirstName(13) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(13) = Int(Reader.GetString("DaysPresent"))
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(13) & "' and StudentFirstName = '" & StudentFirstName(13) & "'"
                    COMMAND2 = New MySqlCommand(Query2, MySqlConn)
                    Reader = COMMAND2.ExecuteReader

                    Reader.Read()
                    AbsentAttendanceCount(13) = Int(Reader.GetString("DaysAbsent")) + 1
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try

                Try
                    MySqlConn.Open()
                    Query3 = "select DaysLate from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(13) & "' and StudentFirstName = '" & StudentFirstName(13) & "'"
                    COMMAND3 = New MySqlCommand(Query3, MySqlConn)
                    Reader = COMMAND3.ExecuteReader

                    Reader.Read()
                    LateAttendanceCount(13) = Int(Reader.GetString("DaysLate"))
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try

                Try
                    MySqlConn.Open()
                    Query4 = "update abisattendancesystem.yellowfoxesdata set idyellowfoxesdata=14,StudentFirstName='" & StudentFirstName(13) & "',StudentLastName='" & StudentLastName(13) & "',DaysPresent='" & PresentAttendanceCount(13) & "',DaysAbsent='" & AbsentAttendanceCount(13) & "',DaysLate='" & LateAttendanceCount(13) & "' where idyellowfoxesdata=14"
                    COMMAND4 = New MySqlCommand(Query4, MySqlConn)
                    Reader = COMMAND4.ExecuteReader
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try
            Else
                MySqlConn.Open()
                Query1 = "select DaysPresent from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(13) & "' and StudentFirstName = '" & StudentFirstName(13) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(13) = Int(Reader.GetString("DaysPresent"))
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(13) & "' and StudentFirstName = '" & StudentFirstName(13) & "'"
                    COMMAND2 = New MySqlCommand(Query2, MySqlConn)
                    Reader = COMMAND2.ExecuteReader

                    Reader.Read()
                    AbsentAttendanceCount(13) = Int(Reader.GetString("DaysAbsent"))
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try

                Try
                    MySqlConn.Open()
                    Query3 = "select DaysLate from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(13) & "' and StudentFirstName = '" & StudentFirstName(13) & "'"
                    COMMAND3 = New MySqlCommand(Query3, MySqlConn)
                    Reader = COMMAND3.ExecuteReader

                    Reader.Read()
                    LateAttendanceCount(13) = Int(Reader.GetString("DaysLate")) + 1
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try

                Try
                    MySqlConn.Open()
                    Query4 = "update abisattendancesystem.yellowfoxesdata set idyellowfoxesdata=14,StudentFirstName='" & StudentFirstName(13) & "',StudentLastName='" & StudentLastName(13) & "',DaysPresent='" & PresentAttendanceCount(13) & "',DaysAbsent='" & AbsentAttendanceCount(13) & "',DaysLate='" & LateAttendanceCount(13) & "' where idyellowfoxesdata=14"
                    COMMAND4 = New MySqlCommand(Query4, MySqlConn)
                    Reader = COMMAND4.ExecuteReader
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try
            End If

            If attendancerecorded(14) = "Present" Then
                MySqlConn.Open()
                Query1 = "select DaysPresent from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(14) & "' and StudentFirstName = '" & StudentFirstName(14) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(14) = Int(Reader.GetString("DaysPresent")) + 1
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(14) & "' and StudentFirstName = '" & StudentFirstName(14) & "'"
                    COMMAND2 = New MySqlCommand(Query2, MySqlConn)
                    Reader = COMMAND2.ExecuteReader

                    Reader.Read()
                    AbsentAttendanceCount(14) = Int(Reader.GetString("DaysAbsent"))
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try

                Try
                    MySqlConn.Open()
                    Query3 = "select DaysLate from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(14) & "' and StudentFirstName = '" & StudentFirstName(14) & "'"
                    COMMAND3 = New MySqlCommand(Query3, MySqlConn)
                    Reader = COMMAND3.ExecuteReader

                    Reader.Read()
                    LateAttendanceCount(14) = Int(Reader.GetString("DaysLate"))
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try

                Try
                    MySqlConn.Open()
                    Query4 = "update abisattendancesystem.yellowfoxesdata set idyellowfoxesdata=15,StudentFirstName='" & StudentFirstName(14) & "',StudentLastName='" & StudentLastName(14) & "',DaysPresent='" & PresentAttendanceCount(14) & "',DaysAbsent='" & AbsentAttendanceCount(14) & "',DaysLate='" & LateAttendanceCount(14) & "' where idyellowfoxesdata=15"
                    COMMAND4 = New MySqlCommand(Query4, MySqlConn)
                    Reader = COMMAND4.ExecuteReader
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try
            ElseIf attendancerecorded(14) = "Absent" Then
                MySqlConn.Open()
                Query1 = "select DaysPresent from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(14) & "' and StudentFirstName = '" & StudentFirstName(14) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(14) = Int(Reader.GetString("DaysPresent"))
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(14) & "' and StudentFirstName = '" & StudentFirstName(14) & "'"
                    COMMAND2 = New MySqlCommand(Query2, MySqlConn)
                    Reader = COMMAND2.ExecuteReader

                    Reader.Read()
                    AbsentAttendanceCount(14) = Int(Reader.GetString("DaysAbsent")) + 1
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try

                Try
                    MySqlConn.Open()
                    Query3 = "select DaysLate from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(14) & "' and StudentFirstName = '" & StudentFirstName(14) & "'"
                    COMMAND3 = New MySqlCommand(Query3, MySqlConn)
                    Reader = COMMAND3.ExecuteReader

                    Reader.Read()
                    LateAttendanceCount(14) = Int(Reader.GetString("DaysLate"))
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try

                Try
                    MySqlConn.Open()
                    Query4 = "update abisattendancesystem.yellowfoxesdata set idyellowfoxesdata=15,StudentFirstName='" & StudentFirstName(14) & "',StudentLastName='" & StudentLastName(14) & "',DaysPresent='" & PresentAttendanceCount(14) & "',DaysAbsent='" & AbsentAttendanceCount(14) & "',DaysLate='" & LateAttendanceCount(14) & "' where idyellowfoxesdata=15"
                    COMMAND4 = New MySqlCommand(Query4, MySqlConn)
                    Reader = COMMAND4.ExecuteReader
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try
            Else
                MySqlConn.Open()
                Query1 = "select DaysPresent from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(14) & "' and StudentFirstName = '" & StudentFirstName(14) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(14) = Int(Reader.GetString("DaysPresent"))
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(14) & "' and StudentFirstName = '" & StudentFirstName(14) & "'"
                    COMMAND2 = New MySqlCommand(Query2, MySqlConn)
                    Reader = COMMAND2.ExecuteReader

                    Reader.Read()
                    AbsentAttendanceCount(14) = Int(Reader.GetString("DaysAbsent"))
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try

                Try
                    MySqlConn.Open()
                    Query3 = "select DaysLate from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(14) & "' and StudentFirstName = '" & StudentFirstName(14) & "'"
                    COMMAND3 = New MySqlCommand(Query3, MySqlConn)
                    Reader = COMMAND3.ExecuteReader

                    Reader.Read()
                    LateAttendanceCount(14) = Int(Reader.GetString("DaysLate")) + 1
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try

                Try
                    MySqlConn.Open()
                    Query4 = "update abisattendancesystem.yellowfoxesdata set idyellowfoxesdata=15,StudentFirstName='" & StudentFirstName(14) & "',StudentLastName='" & StudentLastName(14) & "',DaysPresent='" & PresentAttendanceCount(14) & "',DaysAbsent='" & AbsentAttendanceCount(14) & "',DaysLate='" & LateAttendanceCount(14) & "' where idyellowfoxesdata=15"
                    COMMAND4 = New MySqlCommand(Query4, MySqlConn)
                    Reader = COMMAND4.ExecuteReader
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try
            End If

            If attendancerecorded(15) = "Present" Then
                MySqlConn.Open()
                Query1 = "select DaysPresent from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(15) & "' and StudentFirstName = '" & StudentFirstName(15) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(15) = Int(Reader.GetString("DaysPresent")) + 1
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(15) & "' and StudentFirstName = '" & StudentFirstName(15) & "'"
                    COMMAND2 = New MySqlCommand(Query2, MySqlConn)
                    Reader = COMMAND2.ExecuteReader

                    Reader.Read()
                    AbsentAttendanceCount(15) = Int(Reader.GetString("DaysAbsent"))
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try

                Try
                    MySqlConn.Open()
                    Query3 = "select DaysLate from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(15) & "' and StudentFirstName = '" & StudentFirstName(15) & "'"
                    COMMAND3 = New MySqlCommand(Query3, MySqlConn)
                    Reader = COMMAND3.ExecuteReader

                    Reader.Read()
                    LateAttendanceCount(15) = Int(Reader.GetString("DaysLate"))
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try

                Try
                    MySqlConn.Open()
                    Query4 = "update abisattendancesystem.yellowfoxesdata set idyellowfoxesdata=16,StudentFirstName='" & StudentFirstName(15) & "',StudentLastName='" & StudentLastName(15) & "',DaysPresent='" & PresentAttendanceCount(15) & "',DaysAbsent='" & AbsentAttendanceCount(15) & "',DaysLate='" & LateAttendanceCount(15) & "' where idyellowfoxesdata=16"
                    COMMAND4 = New MySqlCommand(Query4, MySqlConn)
                    Reader = COMMAND4.ExecuteReader
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try
            ElseIf attendancerecorded(15) = "Absent" Then
                MySqlConn.Open()
                Query1 = "select DaysPresent from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(15) & "' and StudentFirstName = '" & StudentFirstName(15) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(15) = Int(Reader.GetString("DaysPresent"))
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(15) & "' and StudentFirstName = '" & StudentFirstName(15) & "'"
                    COMMAND2 = New MySqlCommand(Query2, MySqlConn)
                    Reader = COMMAND2.ExecuteReader

                    Reader.Read()
                    AbsentAttendanceCount(15) = Int(Reader.GetString("DaysAbsent")) + 1
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try

                Try
                    MySqlConn.Open()
                    Query3 = "select DaysLate from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(15) & "' and StudentFirstName = '" & StudentFirstName(15) & "'"
                    COMMAND3 = New MySqlCommand(Query3, MySqlConn)
                    Reader = COMMAND3.ExecuteReader

                    Reader.Read()
                    LateAttendanceCount(15) = Int(Reader.GetString("DaysLate"))
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try

                Try
                    MySqlConn.Open()
                    Query4 = "update abisattendancesystem.yellowfoxesdata set idyellowfoxesdata=16,StudentFirstName='" & StudentFirstName(15) & "',StudentLastName='" & StudentLastName(15) & "',DaysPresent='" & PresentAttendanceCount(15) & "',DaysAbsent='" & AbsentAttendanceCount(15) & "',DaysLate='" & LateAttendanceCount(15) & "' where idyellowfoxesdata=16"
                    COMMAND4 = New MySqlCommand(Query4, MySqlConn)
                    Reader = COMMAND4.ExecuteReader
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try
            Else
                MySqlConn.Open()
                Query1 = "select DaysPresent from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(15) & "' and StudentFirstName = '" & StudentFirstName(15) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(15) = Int(Reader.GetString("DaysPresent"))
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(15) & "' and StudentFirstName = '" & StudentFirstName(15) & "'"
                    COMMAND2 = New MySqlCommand(Query2, MySqlConn)
                    Reader = COMMAND2.ExecuteReader

                    Reader.Read()
                    AbsentAttendanceCount(15) = Int(Reader.GetString("DaysAbsent"))
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try

                Try
                    MySqlConn.Open()
                    Query3 = "select DaysLate from abisattendancesystem.yellowfoxesdata where StudentLastName = '" & StudentLastName(15) & "' and StudentFirstName = '" & StudentFirstName(15) & "'"
                    COMMAND3 = New MySqlCommand(Query3, MySqlConn)
                    Reader = COMMAND3.ExecuteReader

                    Reader.Read()
                    LateAttendanceCount(15) = Int(Reader.GetString("DaysLate")) + 1
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try

                Try
                    MySqlConn.Open()
                    Query4 = "update abisattendancesystem.yellowfoxesdata set idyellowfoxesdata=16,StudentFirstName='" & StudentFirstName(15) & "',StudentLastName='" & StudentLastName(15) & "',DaysPresent='" & PresentAttendanceCount(15) & "',DaysAbsent='" & AbsentAttendanceCount(15) & "',DaysLate='" & LateAttendanceCount(15) & "' where idyellowfoxesdata=16"
                    COMMAND4 = New MySqlCommand(Query4, MySqlConn)
                    Reader = COMMAND4.ExecuteReader
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try
            End If

            MySqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MySqlConn.Dispose()
        End Try
    End Sub

    Private Sub btnGoBack_Click(sender As Object, e As EventArgs) Handles btnGoBack.Click
        Me.Hide()
    End Sub
End Class