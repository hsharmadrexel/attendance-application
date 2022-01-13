Imports MySql.Data.MySqlClient

Public Class Red_Team_Attendance_Form
    Dim redteamstudents(13) As String
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
            Query = "select * from abisattendancesystem.redfalconsroster"

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
        Call ClearorReset()
    End Sub

    Private Sub Red_Team_Attendance_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.Value = DateTime.Now
        redteamstudents(0) = "Al Mamari, Hadeel"
        redteamstudents(1) = "Al Maqbali, Israa"
        redteamstudents(2) = "Al Shirawi, Omar"
        redteamstudents(3) = "Alberts, Willem"
        redteamstudents(4) = "Aykour, Akram"
        redteamstudents(5) = "Benjamin, Kerry-Ann"
        redteamstudents(6) = "Govender, Prishanthi"
        redteamstudents(7) = "Hwang, Eunhye"
        redteamstudents(8) = "Jurkowski, Rhett"
        redteamstudents(9) = "Masoner, Taya"
        redteamstudents(10) = "Masoner, Kameron"
        redteamstudents(11) = "Mathews, Karen"
        redteamstudents(12) = "Persterer, Sanna"
        redteamstudents(13) = "Rival, Yann"

        Me.cmbAddtoAll.Items.Add("Present")
        Me.cmbAddtoAll.Items.Add("Absent")
        Me.cmbAddtoAll.Items.Add("Late")
    End Sub

    Private Sub btnAssigntoAll_Click(sender As Object, e As EventArgs) Handles btnAssigntoAll.Click
        If Me.cmbAddtoAll.SelectedItem = "Present" Then
            Me.radPresentHadeelAlMamari.Checked = True
            Me.radPresentIsraaAlMaqbali.Checked = True
            Me.radPresentOmarAlShirawi.Checked = True
            Me.radPresentWillemAlberts.Checked = True
            Me.radPresentAkramAykour.Checked = True
            Me.radPresentKerryAnnBenjamin.Checked = True
            Me.radPresentPrishanthiGovender.Checked = True
            Me.radPresentEunhyeHwang.Checked = True
            Me.radPresentRhettJurkowski.Checked = True
            Me.radPresentTayaMasoner.Checked = True
            Me.radPresentKameronMasoner.Checked = True
            Me.radPresentKarenMathews.Checked = True
            Me.radPresentSannaPersterer.Checked = True
            Me.radPresentYannRival.Checked = True
        ElseIf Me.cmbAddtoAll.SelectedItem = "Absent" Then
            Me.radAbsentHadeelAlMamari.Checked = True
            Me.radAbsentIsraaAlMaqbali.Checked = True
            Me.radAbsentOmarAlShirawi.Checked = True
            Me.radAbsentWillemAlberts.Checked = True
            Me.radAbsentAkramAykour.Checked = True
            Me.radAbsentKerryAnnBenjamin.Checked = True
            Me.radAbsentPrishanthiGovender.Checked = True
            Me.radAbsentEunhyeHwang.Checked = True
            Me.radAbsentRhettJurkowski.Checked = True
            Me.radAbsentTayaMasoner.Checked = True
            Me.radAbsentKameronMasoner.Checked = True
            Me.radAbsentKarenMathews.Checked = True
            Me.radAbsentSannaPersterer.Checked = True
            Me.radAbsentYannRival.Checked = True
        ElseIf Me.cmbAddtoAll.SelectedItem = "Late" Then
            Me.radLateHadeelAlMamari.Checked = True
            Me.radLateIsraaAlMaqbali.Checked = True
            Me.radLateOmarAlShirawi.Checked = True
            Me.radLateWillemAlberts.Checked = True
            Me.radLateAkramAykour.Checked = True
            Me.radLateKerryAnnBenjamin.Checked = True
            Me.radLatePrishanthiGovender.Checked = True
            Me.radLateEunhyeHwang.Checked = True
            Me.radLateRhettJurkowski.Checked = True
            Me.radLateTayaMasoner.Checked = True
            Me.radLateKameronMasoner.Checked = True
            Me.radLateKarenMathews.Checked = True
            Me.radLateSannaPersterer.Checked = True
            Me.radLateYannRival.Checked = True
        End If

    End Sub

    Private Sub lstStudents_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstStudents.SelectedIndexChanged
        picStudentPicture.Enabled = True

        If lstStudents.SelectedItem = redteamstudents(0) Then
            lblStudentName.Text = "Hadeel Al Mamari"
            lblStudentGrade.Text = "7"
            Me.picStudentPicture.Image = My.Resources.Hadeel_Al_Mamari
        ElseIf lstStudents.SelectedItem = redteamstudents(1) Then
            lblStudentName.Text = "Israa Al Maqbali"
            Me.picStudentPicture.Image = My.Resources.Israa_Al_Maqbali
            lblStudentGrade.Text = "7"
        ElseIf lstStudents.SelectedItem = redteamstudents(2) Then
            lblStudentName.Text = "Omar Al Shirawi"
            Me.picStudentPicture.Image = My.Resources.Omar_Al_Shirawi
            lblStudentGrade.Text = "8"
        ElseIf lstStudents.SelectedItem = redteamstudents(3) Then
            lblStudentName.Text = "Willem Alberts"
            Me.picStudentPicture.Image = My.Resources.Willem_Alberts
            lblStudentGrade.Text = "11"
        ElseIf lstStudents.SelectedItem = redteamstudents(4) Then
            Me.picStudentPicture.Image = My.Resources.Akram_Aykour
            lblStudentName.Text = "Akram Aykour"
            lblStudentGrade.Text = "9"
        ElseIf lstStudents.SelectedItem = redteamstudents(5) Then
            Me.picStudentPicture.Image = My.Resources.Kerry_Ann_Benjamin
            lblStudentName.Text = "Kerry-Ann Benjamin"
            lblStudentGrade.Text = "10"
        ElseIf lstStudents.SelectedItem = redteamstudents(6) Then
            Me.picStudentPicture.Image = My.Resources.Prishanthi_Govender
            lblStudentName.Text = "Prishanthi Govender"
            lblStudentGrade.Text = "8"
        ElseIf lstStudents.SelectedItem = redteamstudents(7) Then
            Me.picStudentPicture.Image = My.Resources.Eunhye_Hwang
            lblStudentName.Text = "Eunhye Hwang"
            lblStudentGrade.Text = "9"
        ElseIf lstStudents.SelectedItem = redteamstudents(8) Then
            Me.picStudentPicture.Image = Nothing
            lblStudentName.Text = "Rhett Jurkowski"
            lblStudentGrade.Text = "8"
        ElseIf lstStudents.SelectedItem = redteamstudents(9) Then
            Me.picStudentPicture.Image = My.Resources.Taya_Masoner
            lblStudentName.Text = "Taya Masoner"
            lblStudentGrade.Text = "7"
        ElseIf lstStudents.SelectedItem = redteamstudents(10) Then
            Me.picStudentPicture.Image = My.Resources.Kameron_Masoner
            lblStudentName.Text = "Kameron Masoner"
            lblStudentGrade.Text = "9"
        ElseIf lstStudents.SelectedItem = redteamstudents(11) Then
            Me.picStudentPicture.Image = My.Resources.Karen_Mathews
            lblStudentName.Text = "Karen Mathews"
            lblStudentGrade.Text = "9"
        ElseIf lstStudents.SelectedItem = redteamstudents(12) Then
            Me.picStudentPicture.Image = My.Resources.Sanna_Persterer
            lblStudentName.Text = "Sanna Persterer"
            lblStudentGrade.Text = "8"
        ElseIf lstStudents.SelectedItem = redteamstudents(13) Then
            Me.picStudentPicture.Image = My.Resources.Yann_Rival
            lblStudentName.Text = "Yann Rival"
            lblStudentGrade.Text = "8"
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Call ClearorReset()
    End Sub

    Public Sub ClearorReset()
        Me.radPresentHadeelAlMamari.Checked = False
        Me.radPresentIsraaAlMaqbali.Checked = False
        Me.radPresentOmarAlShirawi.Checked = False
        Me.radPresentWillemAlberts.Checked = False
        Me.radPresentAkramAykour.Checked = False
        Me.radPresentKerryAnnBenjamin.Checked = False
        Me.radPresentPrishanthiGovender.Checked = False
        Me.radPresentEunhyeHwang.Checked = False
        Me.radPresentRhettJurkowski.Checked = False
        Me.radPresentTayaMasoner.Checked = False
        Me.radPresentKameronMasoner.Checked = False
        Me.radPresentKarenMathews.Checked = False
        Me.radPresentSannaPersterer.Checked = False
        Me.radPresentYannRival.Checked = False

        Me.radAbsentHadeelAlMamari.Checked = False
        Me.radAbsentIsraaAlMaqbali.Checked = False
        Me.radAbsentOmarAlShirawi.Checked = False
        Me.radAbsentWillemAlberts.Checked = False
        Me.radAbsentAkramAykour.Checked = False
        Me.radAbsentKerryAnnBenjamin.Checked = False
        Me.radAbsentPrishanthiGovender.Checked = False
        Me.radAbsentEunhyeHwang.Checked = False
        Me.radAbsentRhettJurkowski.Checked = False
        Me.radAbsentTayaMasoner.Checked = False
        Me.radAbsentKameronMasoner.Checked = False
        Me.radAbsentKarenMathews.Checked = False
        Me.radAbsentSannaPersterer.Checked = False
        Me.radAbsentYannRival.Checked = False

        Me.radLateHadeelAlMamari.Checked = False
        Me.radLateIsraaAlMaqbali.Checked = False
        Me.radLateOmarAlShirawi.Checked = False
        Me.radLateWillemAlberts.Checked = False
        Me.radLateAkramAykour.Checked = False
        Me.radLateKerryAnnBenjamin.Checked = False
        Me.radLatePrishanthiGovender.Checked = False
        Me.radLateEunhyeHwang.Checked = False
        Me.radLateRhettJurkowski.Checked = False
        Me.radLateTayaMasoner.Checked = False
        Me.radLateKameronMasoner.Checked = False
        Me.radLateKarenMathews.Checked = False
        Me.radLateSannaPersterer.Checked = False
        Me.radLateYannRival.Checked = False

        Me.txtHadeelAlMamariRemarks.Text = Nothing
        Me.txtIsraaAlMaqbaliRemarks.Text = Nothing
        Me.txtOmarAlShirawiRemarks.Text = Nothing
        Me.txtWillemAlbertsRemarks.Text = Nothing
        Me.txtAkramAykourRemarks.Text = Nothing
        Me.txtKerryAnnBenjaminRemarks.Text = Nothing
        Me.txtPrishanthiGovenderRemarks.Text = Nothing
        Me.txtEunhyeHwangRemarks.Text = Nothing
        Me.txtRhettJurkowskiRemarks.Text = Nothing
        Me.txtTayaMasonerRemarks.Text = Nothing
        Me.txtKameronMasonerRemarks.Text = Nothing
        Me.txtKarenMathewsRemarks.Text = Nothing
        Me.txtSannaPerstererRemarks.Text = Nothing
        Me.txtYannRivalRemarks.Text = Nothing

        Me.picStudentPicture.Image = Nothing
        Me.lblStudentName.Text = Nothing
        Me.lblStudentGrade.Text = Nothing
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString =
        "server=127.0.0.1;userid=root;password=rp4hne1234;database=abisattendancesystem"
        Dim Reader As MySqlDataReader
        Dim attendancerecorded(13) As String

        If Me.radPresentHadeelAlMamari.Checked = True Then
            attendancerecorded(0) = "Present"
        ElseIf Me.radAbsentHadeelAlMamari.Checked = True Then
            attendancerecorded(0) = "Absent"
        ElseIf Me.radLateHadeelAlMamari.Checked = True Then
            attendancerecorded(0) = "Late"
        End If

        If Me.radPresentIsraaAlMaqbali.Checked = True Then
            attendancerecorded(1) = "Present"
        ElseIf Me.radAbsentIsraaAlMaqbali.Checked = True Then
            attendancerecorded(1) = "Absent"
        ElseIf Me.radLateIsraaAlMaqbali.Checked = True Then
            attendancerecorded(1) = "Late"
        End If

        If Me.radPresentOmarAlShirawi.Checked = True Then
            attendancerecorded(2) = "Present"
        ElseIf Me.radAbsentOmarAlShirawi.Checked = True Then
            attendancerecorded(2) = "Absent"
        ElseIf Me.radLateOmarAlShirawi.Checked = True Then
            attendancerecorded(2) = "Late"
        End If

        If Me.radPresentWillemAlberts.Checked = True Then
            attendancerecorded(3) = "Present"
        ElseIf Me.radAbsentWillemAlberts.Checked = True Then
            attendancerecorded(3) = "Absent"
        ElseIf Me.radLateWillemAlberts.Checked = True Then
            attendancerecorded(3) = "Late"
        End If

        If Me.radPresentAkramAykour.Checked = True Then
            attendancerecorded(4) = "Present"
        ElseIf Me.radAbsentAkramAykour.Checked = True Then
            attendancerecorded(4) = "Absent"
        ElseIf Me.radLateAkramAykour.Checked = True Then
            attendancerecorded(4) = "Late"
        End If

        If Me.radPresentKerryAnnBenjamin.Checked = True Then
            attendancerecorded(5) = "Present"
        ElseIf Me.radAbsentKerryAnnBenjamin.Checked = True Then
            attendancerecorded(5) = "Absent"
        ElseIf Me.radLateKerryAnnBenjamin.Checked = True Then
            attendancerecorded(5) = "Late"
        End If

        If Me.radPresentPrishanthiGovender.Checked = True Then
            attendancerecorded(6) = "Present"
        ElseIf Me.radAbsentPrishanthiGovender.Checked = True Then
            attendancerecorded(6) = "Absent"
        ElseIf Me.radLatePrishanthiGovender.Checked = True Then
            attendancerecorded(6) = "Late"
        End If

        If Me.radPresentEunhyeHwang.Checked = True Then
            attendancerecorded(7) = "Present"
        ElseIf Me.radAbsentEunhyeHwang.Checked = True Then
            attendancerecorded(7) = "Absent"
        ElseIf Me.radLateEunhyeHwang.Checked = True Then
            attendancerecorded(7) = "Late"
        End If

        If Me.radPresentRhettJurkowski.Checked = True Then
            attendancerecorded(8) = "Present"
        ElseIf Me.radAbsentRhettJurkowski.Checked = True Then
            attendancerecorded(8) = "Absent"
        ElseIf Me.radLateRhettJurkowski.Checked = True Then
            attendancerecorded(8) = "Late"
        End If

        If Me.radPresentTayaMasoner.Checked = True Then
            attendancerecorded(9) = "Present"
        ElseIf Me.radAbsentTayaMasoner.Checked = True Then
            attendancerecorded(9) = "Absent"
        ElseIf Me.radLateTayaMasoner.Checked = True Then
            attendancerecorded(9) = "Late"
        End If

        If Me.radPresentKameronMasoner.Checked = True Then
            attendancerecorded(10) = "Present"
        ElseIf Me.radAbsentKameronMasoner.Checked = True Then
            attendancerecorded(10) = "Absent"
        ElseIf Me.radLateKameronMasoner.Checked = True Then
            attendancerecorded(10) = "Late"
        End If

        If Me.radPresentKarenMathews.Checked = True Then
            attendancerecorded(11) = "Present"
        ElseIf Me.radAbsentKarenMathews.Checked = True Then
            attendancerecorded(11) = "Absent"
        ElseIf Me.radLateKarenMathews.Checked = True Then
            attendancerecorded(11) = "Late"
        End If

        If Me.radPresentSannaPersterer.Checked = True Then
            attendancerecorded(12) = "Present"
        ElseIf Me.radAbsentSannaPersterer.Checked = True Then
            attendancerecorded(12) = "Absent"
        ElseIf Me.radLateSannaPersterer.Checked = True Then
            attendancerecorded(12) = "Late"
        End If

        If Me.radPresentYannRival.Checked = True Then
            attendancerecorded(13) = "Present"
        ElseIf Me.radAbsentYannRival.Checked = True Then
            attendancerecorded(13) = "Absent"
        ElseIf Me.radLateYannRival.Checked = True Then
            attendancerecorded(13) = "Late"
        End If

        Try
            MySqlConn.Open()
            Dim HadeelAlMamariQuery As String
            HadeelAlMamariQuery = "insert into abisattendancesystem.redfalconsrecords(idredfalconsrecords,Date,StudentFirstName,StudentLastName,GradeLevel,AttendanceRecorded,Comments) values (1, '" & DateTimePicker1.Text & "', 'Hadeel', 'Al Mamari', 7 ,'" & attendancerecorded(0) & "', '" & txtHadeelAlMamariRemarks.Text & "')"

            COMMAND = New MySqlCommand(HadeelAlMamariQuery, MySqlConn)
            Reader = COMMAND.ExecuteReader
            MySqlConn.Close()

            MySqlConn.Open()
            Dim IsraaAlMaqbaliQuery As String
            IsraaAlMaqbaliQuery = "insert into abisattendancesystem.redfalconsrecords(idredfalconsrecords,Date,StudentFirstName,StudentLastName,GradeLevel,AttendanceRecorded,Comments) values (2, '" & DateTimePicker1.Text & "', 'Israa', 'Al Maqbali', 7 ,'" & attendancerecorded(1) & "', '" & txtIsraaAlMaqbaliRemarks.Text & "')"

            COMMAND = New MySqlCommand(IsraaAlMaqbaliQuery, MySqlConn)
            Reader = COMMAND.ExecuteReader
            MySqlConn.Close()

            MySqlConn.Open()
            Dim OmarAlShirawiQuery As String
            OmarAlShirawiQuery = "insert into abisattendancesystem.redfalconsrecords(idredfalconsrecords,Date,StudentFirstName,StudentLastName,GradeLevel,AttendanceRecorded,Comments) values (3, '" & DateTimePicker1.Text & "', 'Omar', 'Al Shirawi', 8 ,'" & attendancerecorded(2) & "', '" & txtOmarAlShirawiRemarks.Text & "')"

            COMMAND = New MySqlCommand(OmarAlShirawiQuery, MySqlConn)
            Reader = COMMAND.ExecuteReader
            MySqlConn.Close()

            MySqlConn.Open()
            Dim WillemAlbertsQuery As String
            WillemAlbertsQuery = "insert into abisattendancesystem.redfalconsrecords(idredfalconsrecords,Date,StudentFirstName,StudentLastName,GradeLevel,AttendanceRecorded,Comments) values (4, '" & DateTimePicker1.Text & "', 'Willem', 'Alberts', 11 ,'" & attendancerecorded(3) & "', '" & txtWillemAlbertsRemarks.Text & "')"

            COMMAND = New MySqlCommand(WillemAlbertsQuery, MySqlConn)
            Reader = COMMAND.ExecuteReader
            MySqlConn.Close()

            MySqlConn.Open()
            Dim AkramAykourQuery As String
            AkramAykourQuery = "insert into abisattendancesystem.redfalconsrecords(idredfalconsrecords,Date,StudentFirstName,StudentLastName,GradeLevel,AttendanceRecorded,Comments) values (5, '" & DateTimePicker1.Text & "', 'Akram', 'Aykour', 7 ,'" & attendancerecorded(4) & "', '" & txtAkramAykourRemarks.Text & "')"

            COMMAND = New MySqlCommand(AkramAykourQuery, MySqlConn)
            Reader = COMMAND.ExecuteReader
            MySqlConn.Close()

            MySqlConn.Open()
            Dim KerryAnnBenjaminQuery As String
            KerryAnnBenjaminQuery = "insert into abisattendancesystem.redfalconsrecords(idredfalconsrecords,Date,StudentFirstName,StudentLastName,GradeLevel,AttendanceRecorded,Comments) values (6, '" & DateTimePicker1.Text & "', 'Kerry-Ann', 'Benjamin', 10 ,'" & attendancerecorded(5) & "', '" & txtKerryAnnBenjaminRemarks.Text & "')"

            COMMAND = New MySqlCommand(KerryAnnBenjaminQuery, MySqlConn)
            Reader = COMMAND.ExecuteReader
            MySqlConn.Close()

            MySqlConn.Open()
            Dim PrishanthiGovenderQuery As String
            PrishanthiGovenderQuery = "insert into abisattendancesystem.redfalconsrecords(idredfalconsrecords,Date,StudentFirstName,StudentLastName,GradeLevel,AttendanceRecorded,Comments) values (7, '" & DateTimePicker1.Text & "', 'Prishanthi', 'Govender', 8 ,'" & attendancerecorded(6) & "', '" & txtPrishanthiGovenderRemarks.Text & "')"

            COMMAND = New MySqlCommand(PrishanthiGovenderQuery, MySqlConn)
            Reader = COMMAND.ExecuteReader
            MySqlConn.Close()

            MySqlConn.Open()
            Dim EunhyeHwangQuery As String
            EunhyeHwangQuery = "insert into abisattendancesystem.redfalconsrecords(idredfalconsrecords,Date,StudentFirstName,StudentLastName,GradeLevel,AttendanceRecorded,Comments) values (8, '" & DateTimePicker1.Text & "', 'Eunhye', 'Hwang', 9 ,'" & attendancerecorded(7) & "', '" & txtEunhyeHwangRemarks.Text & "')"

            COMMAND = New MySqlCommand(EunhyeHwangQuery, MySqlConn)
            Reader = COMMAND.ExecuteReader
            MySqlConn.Close()

            MySqlConn.Open()
            Dim RhettJurkowskiQuery As String
            RhettJurkowskiQuery = "insert into abisattendancesystem.redfalconsrecords(idredfalconsrecords,Date,StudentFirstName,StudentLastName,GradeLevel,AttendanceRecorded,Comments) values (9, '" & DateTimePicker1.Text & "', 'Rhett', 'Jurkowski', 7 ,'" & attendancerecorded(8) & "', '" & txtRhettJurkowskiRemarks.Text & "')"

            COMMAND = New MySqlCommand(RhettJurkowskiQuery, MySqlConn)
            Reader = COMMAND.ExecuteReader
            MySqlConn.Close()

            MySqlConn.Open()
            Dim TayaMasonerQuery As String
            TayaMasonerQuery = "insert into abisattendancesystem.redfalconsrecords(idredfalconsrecords,Date,StudentFirstName,StudentLastName,GradeLevel,AttendanceRecorded,Comments) values (10, '" & DateTimePicker1.Text & "', 'Taya', 'Masoner', 7 ,'" & attendancerecorded(9) & "', '" & txtTayaMasonerRemarks.Text & "')"

            COMMAND = New MySqlCommand(TayaMasonerQuery, MySqlConn)
            Reader = COMMAND.ExecuteReader
            MySqlConn.Close()

            MySqlConn.Open()
            Dim KameronMasonerQuery As String
            KameronMasonerQuery = "insert into abisattendancesystem.redfalconsrecords(idredfalconsrecords,Date,StudentFirstName,StudentLastName,GradeLevel,AttendanceRecorded,Comments) values (11, '" & DateTimePicker1.Text & "', 'Kameron', 'Masoner', 9 ,'" & attendancerecorded(10) & "', '" & txtKameronMasonerRemarks.Text & "')"

            COMMAND = New MySqlCommand(KameronMasonerQuery, MySqlConn)
            Reader = COMMAND.ExecuteReader
            MySqlConn.Close()

            MySqlConn.Open()
            Dim KarenMathewsQuery As String
            KarenMathewsQuery = "insert into abisattendancesystem.redfalconsrecords(idredfalconsrecords,Date,StudentFirstName,StudentLastName,GradeLevel,AttendanceRecorded,Comments) values (12, '" & DateTimePicker1.Text & "', 'Karen', 'Mathews', 9 ,'" & attendancerecorded(11) & "', '" & txtKarenMathewsRemarks.Text & "')"

            COMMAND = New MySqlCommand(KarenMathewsQuery, MySqlConn)
            Reader = COMMAND.ExecuteReader
            MySqlConn.Close()

            MySqlConn.Open()
            Dim SannaPerstererQuery As String
            SannaPerstererQuery = "insert into abisattendancesystem.redfalconsrecords(idredfalconsrecords,Date,StudentFirstName,StudentLastName,GradeLevel,AttendanceRecorded,Comments) values (13, '" & DateTimePicker1.Text & "', 'Sanna', 'Persterer', 8 ,'" & attendancerecorded(12) & "', '" & txtSannaPerstererRemarks.Text & "')"

            COMMAND = New MySqlCommand(SannaPerstererQuery, MySqlConn)
            Reader = COMMAND.ExecuteReader
            MySqlConn.Close()

            MySqlConn.Open()
            Dim YannRivalQuery As String
            YannRivalQuery = "insert into abisattendancesystem.redfalconsrecords(idredfalconsrecords,Date,StudentFirstName,StudentLastName,GradeLevel,AttendanceRecorded,Comments) values (14, '" & DateTimePicker1.Text & "', 'Yann', 'Rival', 8 ,'" & attendancerecorded(13) & "', '" & txtYannRivalRemarks.Text & "')"

            COMMAND = New MySqlCommand(YannRivalQuery, MySqlConn)
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

            Dim StudentLastName(13) As String
            Dim StudentFirstName(13) As String
            Dim PresentAttendanceCount(13) As Integer
            Dim AbsentAttendanceCount(13) As Integer
            Dim LateAttendanceCount(13) As Integer

            StudentLastName(0) = "Al Mamari"
            StudentLastName(1) = "Al Maqbali"
            StudentLastName(2) = "Al Shirawi"
            StudentLastName(3) = "Alberts"
            StudentLastName(4) = "Aykour"
            StudentLastName(5) = "Benjamin"
            StudentLastName(6) = "Govender"
            StudentLastName(7) = "Hwang"
            StudentLastName(8) = "Jurkowski"
            StudentLastName(9) = "Masoner"
            StudentLastName(10) = "Masoner"
            StudentLastName(11) = "Mathews"
            StudentLastName(12) = "Persterer"
            StudentLastName(13) = "Rival"

            StudentFirstName(0) = "Hadeel"
            StudentFirstName(1) = "Israa"
            StudentFirstName(2) = "Omar"
            StudentFirstName(3) = "Willem"
            StudentFirstName(4) = "Akram"
            StudentFirstName(5) = "Kerry-Ann"
            StudentFirstName(6) = "Prishanthi"
            StudentFirstName(7) = "Eunhye"
            StudentFirstName(8) = "Rhett"
            StudentFirstName(9) = "Taya"
            StudentFirstName(10) = "Kameron"
            StudentFirstName(11) = "Karen"
            StudentFirstName(12) = "Sanna"
            StudentFirstName(13) = "Yann"

            If attendancerecorded(0) = "Present" Then
                MySqlConn.Open()
                Query1 = "select DaysPresent from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(0) & "' and StudentFirstName = '" & StudentFirstName(0) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(0) = Int(Reader.GetString("DaysPresent")) + 1
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(0) & "' and StudentFirstName = '" & StudentFirstName(0) & "'"
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
                    Query3 = "select DaysLate from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(0) & "' and StudentFirstName = '" & StudentFirstName(0) & "'"
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
                    Query4 = "update abisattendancesystem.redfalconsdata set idredfalconsdata=1,StudentFirstName='" & StudentFirstName(0) & "',StudentLastName='" & StudentLastName(0) & "',DaysPresent='" & PresentAttendanceCount(0) & "',DaysAbsent='" & AbsentAttendanceCount(0) & "',DaysLate='" & LateAttendanceCount(0) & "' where idredfalconsdata=1"
                    COMMAND4 = New MySqlCommand(Query4, MySqlConn)
                    Reader = COMMAND4.ExecuteReader
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try
            ElseIf attendancerecorded(0) = "Absent" Then
                Query1 = "select DaysPresent from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(0) & "' and StudentFirstName = '" & StudentFirstName(0) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(0) = Int(Reader.GetString("DaysPresent"))
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(0) & "' and StudentFirstName = '" & StudentFirstName(0) & "'"
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
                    Query3 = "select DaysLate from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(0) & "' and StudentFirstName = '" & StudentFirstName(0) & "'"
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
                    Query4 = "update abisattendancesystem.redfalconsdata set idredfalconsdata=1,StudentFirstName='" & StudentFirstName(0) & "',StudentLastName='" & StudentLastName(0) & "',DaysPresent='" & PresentAttendanceCount(0) & "',DaysAbsent='" & AbsentAttendanceCount(0) & "',DaysLate='" & LateAttendanceCount(0) & "' where idredfalconsdata=1"
                    COMMAND4 = New MySqlCommand(Query4, MySqlConn)
                    Reader = COMMAND4.ExecuteReader
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try
            Else
                Query1 = "select DaysPresent from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(0) & "' and StudentFirstName = '" & StudentFirstName(0) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(0) = Int(Reader.GetString("DaysPresent"))
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(0) & "' and StudentFirstName = '" & StudentFirstName(0) & "'"
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
                    Query3 = "select DaysLate from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(0) & "' and StudentFirstName = '" & StudentFirstName(0) & "'"
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
                    Query4 = "update abisattendancesystem.redfalconsdata set idredfalconsdata=1,StudentFirstName='" & StudentFirstName(0) & "',StudentLastName='" & StudentLastName(0) & "',DaysPresent='" & PresentAttendanceCount(0) & "',DaysAbsent='" & AbsentAttendanceCount(0) & "',DaysLate='" & LateAttendanceCount(0) & "' where idredfalconsdata=1"
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
                Query1 = "select DaysPresent from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(1) & "' and StudentFirstName = '" & StudentFirstName(1) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(1) = Int(Reader.GetString("DaysPresent")) + 1
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(1) & "' and StudentFirstName = '" & StudentFirstName(1) & "'"
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
                    Query3 = "select DaysLate from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(1) & "' and StudentFirstName = '" & StudentFirstName(1) & "'"
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
                    Query4 = "update abisattendancesystem.redfalconsdata set idredfalconsdata=2,StudentFirstName='" & StudentFirstName(1) & "',StudentLastName='" & StudentLastName(1) & "',DaysPresent='" & PresentAttendanceCount(1) & "',DaysAbsent='" & AbsentAttendanceCount(1) & "',DaysLate='" & LateAttendanceCount(1) & "' where idredfalconsdata=2"
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
                Query1 = "select DaysPresent from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(1) & "' and StudentFirstName = '" & StudentFirstName(1) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(1) = Int(Reader.GetString("DaysPresent"))
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(1) & "' and StudentFirstName = '" & StudentFirstName(1) & "'"
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
                    Query3 = "select DaysLate from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(1) & "' and StudentFirstName = '" & StudentFirstName(1) & "'"
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
                    Query4 = "update abisattendancesystem.redfalconsdata set idredfalconsdata=2,StudentFirstName='" & StudentFirstName(1) & "',StudentLastName='" & StudentLastName(1) & "',DaysPresent='" & PresentAttendanceCount(1) & "',DaysAbsent='" & AbsentAttendanceCount(1) & "',DaysLate='" & LateAttendanceCount(1) & "' where idredfalconsdata=2"
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
                Query1 = "select DaysPresent from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(1) & "' and StudentFirstName = '" & StudentFirstName(1) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(1) = Int(Reader.GetString("DaysPresent"))
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(1) & "' and StudentFirstName = '" & StudentFirstName(1) & "'"
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
                    Query3 = "select DaysLate from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(1) & "' and StudentFirstName = '" & StudentFirstName(1) & "'"
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
                    Query4 = "update abisattendancesystem.redfalconsdata set idredfalconsdata=2,StudentFirstName='" & StudentFirstName(1) & "',StudentLastName='" & StudentLastName(1) & "',DaysPresent='" & PresentAttendanceCount(1) & "',DaysAbsent='" & AbsentAttendanceCount(1) & "',DaysLate='" & LateAttendanceCount(1) & "' where idredfalconsdata=2"
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
                Query1 = "select DaysPresent from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(2) & "' and StudentFirstName = '" & StudentFirstName(2) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(2) = Int(Reader.GetString("DaysPresent")) + 1
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(2) & "' and StudentFirstName = '" & StudentFirstName(2) & "'"
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
                    Query3 = "select DaysLate from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(2) & "' and StudentFirstName = '" & StudentFirstName(2) & "'"
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
                    Query4 = "update abisattendancesystem.redfalconsdata set idredfalconsdata=3,StudentFirstName='" & StudentFirstName(2) & "',StudentLastName='" & StudentLastName(2) & "',DaysPresent='" & PresentAttendanceCount(2) & "',DaysAbsent='" & AbsentAttendanceCount(2) & "',DaysLate='" & LateAttendanceCount(2) & "' where idredfalconsdata=3"
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
                Query1 = "select DaysPresent from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(2) & "' and StudentFirstName = '" & StudentFirstName(2) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(2) = Int(Reader.GetString("DaysPresent"))
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(2) & "' and StudentFirstName = '" & StudentFirstName(2) & "'"
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
                    Query3 = "select DaysLate from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(2) & "' and StudentFirstName = '" & StudentFirstName(2) & "'"
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
                    Query4 = "update abisattendancesystem.redfalconsdata set idredfalconsdata=3,StudentFirstName='" & StudentFirstName(2) & "',StudentLastName='" & StudentLastName(2) & "',DaysPresent='" & PresentAttendanceCount(2) & "',DaysAbsent='" & AbsentAttendanceCount(2) & "',DaysLate='" & LateAttendanceCount(2) & "' where idredfalconsdata=3"
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
                Query1 = "select DaysPresent from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(2) & "' and StudentFirstName = '" & StudentFirstName(2) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(2) = Int(Reader.GetString("DaysPresent"))
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(2) & "' and StudentFirstName = '" & StudentFirstName(2) & "'"
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
                    Query3 = "select DaysLate from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(2) & "' and StudentFirstName = '" & StudentFirstName(2) & "'"
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
                    Query4 = "update abisattendancesystem.redfalconsdata set idredfalconsdata=3,StudentFirstName='" & StudentFirstName(2) & "',StudentLastName='" & StudentLastName(2) & "',DaysPresent='" & PresentAttendanceCount(2) & "',DaysAbsent='" & AbsentAttendanceCount(2) & "',DaysLate='" & LateAttendanceCount(2) & "' where idredfalconsdata=3"
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
                Query1 = "select DaysPresent from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(3) & "' and StudentFirstName = '" & StudentFirstName(3) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(3) = Int(Reader.GetString("DaysPresent")) + 1
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(3) & "' and StudentFirstName = '" & StudentFirstName(3) & "'"
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
                    Query3 = "select DaysLate from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(3) & "' and StudentFirstName = '" & StudentFirstName(3) & "'"
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
                    Query4 = "update abisattendancesystem.redfalconsdata set idredfalconsdata=4,StudentFirstName='" & StudentFirstName(3) & "',StudentLastName='" & StudentLastName(3) & "',DaysPresent='" & PresentAttendanceCount(3) & "',DaysAbsent='" & AbsentAttendanceCount(3) & "',DaysLate='" & LateAttendanceCount(3) & "' where idredfalconsdata=4"
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
                Query1 = "select DaysPresent from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(3) & "' and StudentFirstName = '" & StudentFirstName(3) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(3) = Int(Reader.GetString("DaysPresent"))
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(3) & "' and StudentFirstName = '" & StudentFirstName(3) & "'"
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
                    Query3 = "select DaysLate from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(3) & "' and StudentFirstName = '" & StudentFirstName(3) & "'"
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
                    Query4 = "update abisattendancesystem.redfalconsdata set idredfalconsdata=4,StudentFirstName='" & StudentFirstName(3) & "',StudentLastName='" & StudentLastName(3) & "',DaysPresent='" & PresentAttendanceCount(3) & "',DaysAbsent='" & AbsentAttendanceCount(3) & "',DaysLate='" & LateAttendanceCount(3) & "' where idredfalconsdata=4"
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
                Query1 = "select DaysPresent from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(3) & "' and StudentFirstName = '" & StudentFirstName(3) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(3) = Int(Reader.GetString("DaysPresent"))
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(3) & "' and StudentFirstName = '" & StudentFirstName(3) & "'"
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
                    Query3 = "select DaysLate from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(3) & "' and StudentFirstName = '" & StudentFirstName(3) & "'"
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
                    Query4 = "update abisattendancesystem.redfalconsdata set idredfalconsdata=4,StudentFirstName='" & StudentFirstName(3) & "',StudentLastName='" & StudentLastName(3) & "',DaysPresent='" & PresentAttendanceCount(3) & "',DaysAbsent='" & AbsentAttendanceCount(3) & "',DaysLate='" & LateAttendanceCount(3) & "' where idredfalconsdata=4"
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
                Query1 = "select DaysPresent from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(4) & "' and StudentFirstName = '" & StudentFirstName(4) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(4) = Int(Reader.GetString("DaysPresent")) + 1
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(4) & "' and StudentFirstName = '" & StudentFirstName(4) & "'"
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
                    Query3 = "select DaysLate from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(4) & "' and StudentFirstName = '" & StudentFirstName(4) & "'"
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
                    Query4 = "update abisattendancesystem.redfalconsdata set idredfalconsdata=5,StudentFirstName='" & StudentFirstName(4) & "',StudentLastName='" & StudentLastName(4) & "',DaysPresent='" & PresentAttendanceCount(4) & "',DaysAbsent='" & AbsentAttendanceCount(4) & "',DaysLate='" & LateAttendanceCount(4) & "' where idredfalconsdata=5"
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
                Query1 = "select DaysPresent from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(4) & "' and StudentFirstName = '" & StudentFirstName(4) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(4) = Int(Reader.GetString("DaysPresent"))
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(4) & "' and StudentFirstName = '" & StudentFirstName(4) & "'"
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
                    Query3 = "select DaysLate from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(4) & "' and StudentFirstName = '" & StudentFirstName(4) & "'"
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
                    Query4 = "update abisattendancesystem.redfalconsdata set idredfalconsdata=5,StudentFirstName='" & StudentFirstName(4) & "',StudentLastName='" & StudentLastName(4) & "',DaysPresent='" & PresentAttendanceCount(4) & "',DaysAbsent='" & AbsentAttendanceCount(4) & "',DaysLate='" & LateAttendanceCount(4) & "' where idredfalconsdata=5"
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
                Query1 = "select DaysPresent from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(4) & "' and StudentFirstName = '" & StudentFirstName(4) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(4) = Int(Reader.GetString("DaysPresent"))
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(4) & "' and StudentFirstName = '" & StudentFirstName(4) & "'"
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
                    Query3 = "select DaysLate from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(4) & "' and StudentFirstName = '" & StudentFirstName(4) & "'"
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
                    Query4 = "update abisattendancesystem.redfalconsdata set idredfalconsdata=5,StudentFirstName='" & StudentFirstName(4) & "',StudentLastName='" & StudentLastName(4) & "',DaysPresent='" & PresentAttendanceCount(4) & "',DaysAbsent='" & AbsentAttendanceCount(4) & "',DaysLate='" & LateAttendanceCount(4) & "' where idredfalconsdata=5"
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
                Query1 = "select DaysPresent from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(5) & "' and StudentFirstName = '" & StudentFirstName(5) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(5) = Int(Reader.GetString("DaysPresent")) + 1
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(5) & "' and StudentFirstName = '" & StudentFirstName(5) & "'"
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
                    Query3 = "select DaysLate from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(5) & "' and StudentFirstName = '" & StudentFirstName(5) & "'"
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
                    Query4 = "update abisattendancesystem.redfalconsdata set idredfalconsdata=6,StudentFirstName='" & StudentFirstName(5) & "',StudentLastName='" & StudentLastName(5) & "',DaysPresent='" & PresentAttendanceCount(5) & "',DaysAbsent='" & AbsentAttendanceCount(5) & "',DaysLate='" & LateAttendanceCount(5) & "' where idredfalconsdata=6"
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
                Query1 = "select DaysPresent from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(5) & "' and StudentFirstName = '" & StudentFirstName(5) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(5) = Int(Reader.GetString("DaysPresent"))
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(5) & "' and StudentFirstName = '" & StudentFirstName(5) & "'"
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
                    Query3 = "select DaysLate from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(5) & "' and StudentFirstName = '" & StudentFirstName(5) & "'"
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
                    Query4 = "update abisattendancesystem.redfalconsdata set idredfalconsdata=6,StudentFirstName='" & StudentFirstName(5) & "',StudentLastName='" & StudentLastName(5) & "',DaysPresent='" & PresentAttendanceCount(5) & "',DaysAbsent='" & AbsentAttendanceCount(5) & "',DaysLate='" & LateAttendanceCount(5) & "' where idredfalconsdata=6"
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
                Query1 = "select DaysPresent from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(5) & "' and StudentFirstName = '" & StudentFirstName(5) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(5) = Int(Reader.GetString("DaysPresent"))
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(5) & "' and StudentFirstName = '" & StudentFirstName(5) & "'"
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
                    Query3 = "select DaysLate from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(5) & "' and StudentFirstName = '" & StudentFirstName(5) & "'"
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
                    Query4 = "update abisattendancesystem.redfalconsdata set idredfalconsdata=6,StudentFirstName='" & StudentFirstName(5) & "',StudentLastName='" & StudentLastName(5) & "',DaysPresent='" & PresentAttendanceCount(5) & "',DaysAbsent='" & AbsentAttendanceCount(5) & "',DaysLate='" & LateAttendanceCount(5) & "' where idredfalconsdata=6"
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
                Query1 = "select DaysPresent from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(6) & "' and StudentFirstName = '" & StudentFirstName(6) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(6) = Int(Reader.GetString("DaysPresent")) + 1
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(6) & "' and StudentFirstName = '" & StudentFirstName(6) & "'"
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
                    Query3 = "select DaysLate from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(6) & "' and StudentFirstName = '" & StudentFirstName(6) & "'"
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
                    Query4 = "update abisattendancesystem.redfalconsdata set idredfalconsdata=7,StudentFirstName='" & StudentFirstName(6) & "',StudentLastName='" & StudentLastName(6) & "',DaysPresent='" & PresentAttendanceCount(6) & "',DaysAbsent='" & AbsentAttendanceCount(6) & "',DaysLate='" & LateAttendanceCount(6) & "' where idredfalconsdata=7"
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
                Query1 = "select DaysPresent from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(6) & "' and StudentFirstName = '" & StudentFirstName(6) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(6) = Int(Reader.GetString("DaysPresent"))
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(6) & "' and StudentFirstName = '" & StudentFirstName(6) & "'"
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
                    Query3 = "select DaysLate from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(6) & "' and StudentFirstName = '" & StudentFirstName(6) & "'"
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
                    Query4 = "update abisattendancesystem.redfalconsdata set idredfalconsdata=7,StudentFirstName='" & StudentFirstName(6) & "',StudentLastName='" & StudentLastName(6) & "',DaysPresent='" & PresentAttendanceCount(6) & "',DaysAbsent='" & AbsentAttendanceCount(6) & "',DaysLate='" & LateAttendanceCount(6) & "' where idredfalconsdata=7"
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
                Query1 = "select DaysPresent from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(6) & "' and StudentFirstName = '" & StudentFirstName(6) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(6) = Int(Reader.GetString("DaysPresent"))
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(6) & "' and StudentFirstName = '" & StudentFirstName(6) & "'"
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
                    Query3 = "select DaysLate from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(6) & "' and StudentFirstName = '" & StudentFirstName(6) & "'"
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
                    Query4 = "update abisattendancesystem.redfalconsdata set idredfalconsdata=7,StudentFirstName='" & StudentFirstName(6) & "',StudentLastName='" & StudentLastName(6) & "',DaysPresent='" & PresentAttendanceCount(6) & "',DaysAbsent='" & AbsentAttendanceCount(6) & "',DaysLate='" & LateAttendanceCount(6) & "' where idredfalconsdata=7"
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
                Query1 = "select DaysPresent from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(7) & "' and StudentFirstName = '" & StudentFirstName(7) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(7) = Int(Reader.GetString("DaysPresent")) + 1
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(7) & "' and StudentFirstName = '" & StudentFirstName(7) & "'"
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
                    Query3 = "select DaysLate from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(7) & "' and StudentFirstName = '" & StudentFirstName(7) & "'"
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
                    Query4 = "update abisattendancesystem.redfalconsdata set idredfalconsdata=8,StudentFirstName='" & StudentFirstName(7) & "',StudentLastName='" & StudentLastName(7) & "',DaysPresent='" & PresentAttendanceCount(7) & "',DaysAbsent='" & AbsentAttendanceCount(7) & "',DaysLate='" & LateAttendanceCount(7) & "' where idredfalconsdata=8"
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
                Query1 = "select DaysPresent from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(7) & "' and StudentFirstName = '" & StudentFirstName(7) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(7) = Int(Reader.GetString("DaysPresent"))
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(7) & "' and StudentFirstName = '" & StudentFirstName(7) & "'"
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
                    Query3 = "select DaysLate from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(7) & "' and StudentFirstName = '" & StudentFirstName(7) & "'"
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
                    Query4 = "update abisattendancesystem.redfalconsdata set idredfalconsdata=8,StudentFirstName='" & StudentFirstName(7) & "',StudentLastName='" & StudentLastName(7) & "',DaysPresent='" & PresentAttendanceCount(7) & "',DaysAbsent='" & AbsentAttendanceCount(7) & "',DaysLate='" & LateAttendanceCount(7) & "' where idredfalconsdata=8"
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
                Query1 = "select DaysPresent from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(7) & "' and StudentFirstName = '" & StudentFirstName(7) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(7) = Int(Reader.GetString("DaysPresent"))
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(7) & "' and StudentFirstName = '" & StudentFirstName(7) & "'"
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
                    Query3 = "select DaysLate from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(7) & "' and StudentFirstName = '" & StudentFirstName(7) & "'"
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
                    Query4 = "update abisattendancesystem.redfalconsdata set idredfalconsdata=8,StudentFirstName='" & StudentFirstName(7) & "',StudentLastName='" & StudentLastName(7) & "',DaysPresent='" & PresentAttendanceCount(7) & "',DaysAbsent='" & AbsentAttendanceCount(7) & "',DaysLate='" & LateAttendanceCount(7) & "' where idredfalconsdata=8"
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
                Query1 = "select DaysPresent from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(8) & "' and StudentFirstName = '" & StudentFirstName(8) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(8) = Int(Reader.GetString("DaysPresent")) + 1
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(8) & "' and StudentFirstName = '" & StudentFirstName(8) & "'"
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
                    Query3 = "select DaysLate from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(8) & "' and StudentFirstName = '" & StudentFirstName(8) & "'"
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
                    Query4 = "update abisattendancesystem.redfalconsdata set idredfalconsdata=9,StudentFirstName='" & StudentFirstName(8) & "',StudentLastName='" & StudentLastName(8) & "',DaysPresent='" & PresentAttendanceCount(8) & "',DaysAbsent='" & AbsentAttendanceCount(8) & "',DaysLate='" & LateAttendanceCount(8) & "' where idredfalconsdata=9"
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
                Query1 = "select DaysPresent from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(8) & "' and StudentFirstName = '" & StudentFirstName(8) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(8) = Int(Reader.GetString("DaysPresent"))
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(8) & "' and StudentFirstName = '" & StudentFirstName(8) & "'"
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
                    Query3 = "select DaysLate from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(8) & "' and StudentFirstName = '" & StudentFirstName(8) & "'"
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
                    Query4 = "update abisattendancesystem.redfalconsdata set idredfalconsdata=9,StudentFirstName='" & StudentFirstName(8) & "',StudentLastName='" & StudentLastName(8) & "',DaysPresent='" & PresentAttendanceCount(8) & "',DaysAbsent='" & AbsentAttendanceCount(8) & "',DaysLate='" & LateAttendanceCount(8) & "' where idredfalconsdata=9"
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
                Query1 = "select DaysPresent from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(8) & "' and StudentFirstName = '" & StudentFirstName(8) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(8) = Int(Reader.GetString("DaysPresent"))
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(8) & "' and StudentFirstName = '" & StudentFirstName(8) & "'"
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
                    Query3 = "select DaysLate from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(8) & "' and StudentFirstName = '" & StudentFirstName(8) & "'"
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
                    Query4 = "update abisattendancesystem.redfalconsdata set idredfalconsdata=9,StudentFirstName='" & StudentFirstName(8) & "',StudentLastName='" & StudentLastName(8) & "',DaysPresent='" & PresentAttendanceCount(8) & "',DaysAbsent='" & AbsentAttendanceCount(8) & "',DaysLate='" & LateAttendanceCount(8) & "' where idredfalconsdata=9"
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
                Query1 = "select DaysPresent from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(9) & "' and StudentFirstName = '" & StudentFirstName(9) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(9) = Int(Reader.GetString("DaysPresent")) + 1
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(9) & "' and StudentFirstName = '" & StudentFirstName(9) & "'"
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
                    Query3 = "select DaysLate from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(9) & "' and StudentFirstName = '" & StudentFirstName(9) & "'"
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
                    Query4 = "update abisattendancesystem.redfalconsdata set idredfalconsdata=10,StudentFirstName='" & StudentFirstName(9) & "',StudentLastName='" & StudentLastName(9) & "',DaysPresent='" & PresentAttendanceCount(9) & "',DaysAbsent='" & AbsentAttendanceCount(9) & "',DaysLate='" & LateAttendanceCount(9) & "' where idredfalconsdata=10"
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
                Query1 = "select DaysPresent from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(9) & "' and StudentFirstName = '" & StudentFirstName(9) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(9) = Int(Reader.GetString("DaysPresent"))
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(9) & "' and StudentFirstName = '" & StudentFirstName(9) & "'"
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
                    Query3 = "select DaysLate from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(9) & "' and StudentFirstName = '" & StudentFirstName(9) & "'"
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
                    Query4 = "update abisattendancesystem.redfalconsdata set idredfalconsdata=10,StudentFirstName='" & StudentFirstName(9) & "',StudentLastName='" & StudentLastName(9) & "',DaysPresent='" & PresentAttendanceCount(9) & "',DaysAbsent='" & AbsentAttendanceCount(9) & "',DaysLate='" & LateAttendanceCount(9) & "' where idredfalconsdata=10"
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
                Query1 = "select DaysPresent from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(9) & "' and StudentFirstName = '" & StudentFirstName(9) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(9) = Int(Reader.GetString("DaysPresent"))
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(9) & "' and StudentFirstName = '" & StudentFirstName(9) & "'"
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
                    Query3 = "select DaysLate from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(9) & "' and StudentFirstName = '" & StudentFirstName(9) & "'"
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
                    Query4 = "update abisattendancesystem.redfalconsdata set idredfalconsdata=10,StudentFirstName='" & StudentFirstName(9) & "',StudentLastName='" & StudentLastName(9) & "',DaysPresent='" & PresentAttendanceCount(9) & "',DaysAbsent='" & AbsentAttendanceCount(9) & "',DaysLate='" & LateAttendanceCount(9) & "' where idredfalconsdata=10"
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
                Query1 = "select DaysPresent from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(10) & "' and StudentFirstName = '" & StudentFirstName(10) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(10) = Int(Reader.GetString("DaysPresent")) + 1
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(10) & "' and StudentFirstName = '" & StudentFirstName(10) & "'"
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
                    Query3 = "select DaysLate from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(10) & "' and StudentFirstName = '" & StudentFirstName(10) & "'"
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
                    Query4 = "update abisattendancesystem.redfalconsdata set idredfalconsdata=11,StudentFirstName='" & StudentFirstName(10) & "',StudentLastName='" & StudentLastName(10) & "',DaysPresent='" & PresentAttendanceCount(10) & "',DaysAbsent='" & AbsentAttendanceCount(10) & "',DaysLate='" & LateAttendanceCount(10) & "' where idredfalconsdata=11"
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
                Query1 = "select DaysPresent from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(10) & "' and StudentFirstName = '" & StudentFirstName(10) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(10) = Int(Reader.GetString("DaysPresent"))
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(10) & "' and StudentFirstName = '" & StudentFirstName(10) & "'"
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
                    Query3 = "select DaysLate from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(10) & "' and StudentFirstName = '" & StudentFirstName(10) & "'"
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
                    Query4 = "update abisattendancesystem.redfalconsdata set idredfalconsdata=11,StudentFirstName='" & StudentFirstName(10) & "',StudentLastName='" & StudentLastName(10) & "',DaysPresent='" & PresentAttendanceCount(10) & "',DaysAbsent='" & AbsentAttendanceCount(10) & "',DaysLate='" & LateAttendanceCount(10) & "' where idredfalconsdata=11"
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
                Query1 = "select DaysPresent from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(10) & "' and StudentFirstName = '" & StudentFirstName(10) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(10) = Int(Reader.GetString("DaysPresent"))
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(10) & "' and StudentFirstName = '" & StudentFirstName(10) & "'"
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
                    Query3 = "select DaysLate from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(10) & "' and StudentFirstName = '" & StudentFirstName(10) & "'"
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
                    Query4 = "update abisattendancesystem.redfalconsdata set idredfalconsdata=11,StudentFirstName='" & StudentFirstName(10) & "',StudentLastName='" & StudentLastName(10) & "',DaysPresent='" & PresentAttendanceCount(10) & "',DaysAbsent='" & AbsentAttendanceCount(10) & "',DaysLate='" & LateAttendanceCount(10) & "' where idredfalconsdata=11"
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
                Query1 = "select DaysPresent from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(11) & "' and StudentFirstName = '" & StudentFirstName(11) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(11) = Int(Reader.GetString("DaysPresent")) + 1
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(11) & "' and StudentFirstName = '" & StudentFirstName(11) & "'"
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
                    Query3 = "select DaysLate from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(11) & "' and StudentFirstName = '" & StudentFirstName(11) & "'"
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
                    Query4 = "update abisattendancesystem.redfalconsdata set idredfalconsdata=12,StudentFirstName='" & StudentFirstName(11) & "',StudentLastName='" & StudentLastName(11) & "',DaysPresent='" & PresentAttendanceCount(11) & "',DaysAbsent='" & AbsentAttendanceCount(11) & "',DaysLate='" & LateAttendanceCount(11) & "' where idredfalconsdata=12"
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
                Query1 = "select DaysPresent from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(11) & "' and StudentFirstName = '" & StudentFirstName(11) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(11) = Int(Reader.GetString("DaysPresent"))
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(11) & "' and StudentFirstName = '" & StudentFirstName(11) & "'"
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
                    Query3 = "select DaysLate from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(11) & "' and StudentFirstName = '" & StudentFirstName(11) & "'"
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
                    Query4 = "update abisattendancesystem.redfalconsdata set idredfalconsdata=12,StudentFirstName='" & StudentFirstName(11) & "',StudentLastName='" & StudentLastName(11) & "',DaysPresent='" & PresentAttendanceCount(11) & "',DaysAbsent='" & AbsentAttendanceCount(11) & "',DaysLate='" & LateAttendanceCount(11) & "' where idredfalconsdata=12"
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
                Query1 = "select DaysPresent from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(11) & "' and StudentFirstName = '" & StudentFirstName(11) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(11) = Int(Reader.GetString("DaysPresent"))
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(11) & "' and StudentFirstName = '" & StudentFirstName(11) & "'"
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
                    Query3 = "select DaysLate from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(11) & "' and StudentFirstName = '" & StudentFirstName(11) & "'"
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
                    Query4 = "update abisattendancesystem.redfalconsdata set idredfalconsdata=12,StudentFirstName='" & StudentFirstName(11) & "',StudentLastName='" & StudentLastName(11) & "',DaysPresent='" & PresentAttendanceCount(11) & "',DaysAbsent='" & AbsentAttendanceCount(11) & "',DaysLate='" & LateAttendanceCount(11) & "' where idredfalconsdata=12"
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
                Query1 = "select DaysPresent from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(12) & "' and StudentFirstName = '" & StudentFirstName(12) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(12) = Int(Reader.GetString("DaysPresent")) + 1
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(12) & "' and StudentFirstName = '" & StudentFirstName(12) & "'"
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
                    Query3 = "select DaysLate from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(12) & "' and StudentFirstName = '" & StudentFirstName(12) & "'"
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
                    Query4 = "update abisattendancesystem.redfalconsdata set idredfalconsdata=13,StudentFirstName='" & StudentFirstName(12) & "',StudentLastName='" & StudentLastName(12) & "',DaysPresent='" & PresentAttendanceCount(12) & "',DaysAbsent='" & AbsentAttendanceCount(12) & "',DaysLate='" & LateAttendanceCount(12) & "' where idredfalconsdata=13"
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
                Query1 = "select DaysPresent from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(12) & "' and StudentFirstName = '" & StudentFirstName(12) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(12) = Int(Reader.GetString("DaysPresent"))
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(12) & "' and StudentFirstName = '" & StudentFirstName(12) & "'"
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
                    Query3 = "select DaysLate from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(12) & "' and StudentFirstName = '" & StudentFirstName(12) & "'"
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
                    Query4 = "update abisattendancesystem.redfalconsdata set idredfalconsdata=13,StudentFirstName='" & StudentFirstName(12) & "',StudentLastName='" & StudentLastName(12) & "',DaysPresent='" & PresentAttendanceCount(12) & "',DaysAbsent='" & AbsentAttendanceCount(12) & "',DaysLate='" & LateAttendanceCount(12) & "' where idredfalconsdata=13"
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
                Query1 = "select DaysPresent from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(12) & "' and StudentFirstName = '" & StudentFirstName(12) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(12) = Int(Reader.GetString("DaysPresent"))
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(12) & "' and StudentFirstName = '" & StudentFirstName(12) & "'"
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
                    Query3 = "select DaysLate from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(12) & "' and StudentFirstName = '" & StudentFirstName(12) & "'"
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
                    Query4 = "update abisattendancesystem.redfalconsdata set idredfalconsdata=13,StudentFirstName='" & StudentFirstName(12) & "',StudentLastName='" & StudentLastName(12) & "',DaysPresent='" & PresentAttendanceCount(12) & "',DaysAbsent='" & AbsentAttendanceCount(12) & "',DaysLate='" & LateAttendanceCount(12) & "' where idredfalconsdata=13"
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
                Query1 = "select DaysPresent from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(13) & "' and StudentFirstName = '" & StudentFirstName(13) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(13) = Int(Reader.GetString("DaysPresent")) + 1
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(13) & "' and StudentFirstName = '" & StudentFirstName(13) & "'"
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
                    Query3 = "select DaysLate from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(13) & "' and StudentFirstName = '" & StudentFirstName(13) & "'"
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
                    Query4 = "update abisattendancesystem.redfalconsdata set idredfalconsdata=14,StudentFirstName='" & StudentFirstName(13) & "',StudentLastName='" & StudentLastName(13) & "',DaysPresent='" & PresentAttendanceCount(13) & "',DaysAbsent='" & AbsentAttendanceCount(13) & "',DaysLate='" & LateAttendanceCount(13) & "' where idredfalconsdata=14"
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
                Query1 = "select DaysPresent from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(13) & "' and StudentFirstName = '" & StudentFirstName(13) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(13) = Int(Reader.GetString("DaysPresent"))
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(13) & "' and StudentFirstName = '" & StudentFirstName(13) & "'"
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
                    Query3 = "select DaysLate from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(13) & "' and StudentFirstName = '" & StudentFirstName(13) & "'"
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
                    Query4 = "update abisattendancesystem.redfalconsdata set idredfalconsdata=14,StudentFirstName='" & StudentFirstName(13) & "',StudentLastName='" & StudentLastName(13) & "',DaysPresent='" & PresentAttendanceCount(13) & "',DaysAbsent='" & AbsentAttendanceCount(13) & "',DaysLate='" & LateAttendanceCount(13) & "' where idredfalconsdata=14"
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
                Query1 = "select DaysPresent from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(13) & "' and StudentFirstName = '" & StudentFirstName(13) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(13) = Int(Reader.GetString("DaysPresent"))
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(13) & "' and StudentFirstName = '" & StudentFirstName(13) & "'"
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
                    Query3 = "select DaysLate from abisattendancesystem.redfalconsdata where StudentLastName = '" & StudentLastName(13) & "' and StudentFirstName = '" & StudentFirstName(13) & "'"
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
                    Query4 = "update abisattendancesystem.redfalconsdata set idredfalconsdata=14,StudentFirstName='" & StudentFirstName(13) & "',StudentLastName='" & StudentLastName(13) & "',DaysPresent='" & PresentAttendanceCount(13) & "',DaysAbsent='" & AbsentAttendanceCount(13) & "',DaysLate='" & LateAttendanceCount(13) & "' where idredfalconsdata=14"
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