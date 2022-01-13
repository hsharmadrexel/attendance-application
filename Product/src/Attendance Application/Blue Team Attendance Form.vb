Imports MySql.Data.MySqlClient

Public Class Blue_Team_Attendance_Form
    Dim blueteamstudents(14) As String
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
            Query = "select * from abisattendancesystem.bluedolphinsroster"

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
        blueteamstudents(0) = "Al Ghaithi, Hoor"
        blueteamstudents(1) = "Centino, Trisha"
        blueteamstudents(2) = "Gail Legaspi, Andrea"
        blueteamstudents(3) = "Gemarino, Jaira"
        blueteamstudents(4) = "Gemarino, Antonio-Alec"
        blueteamstudents(5) = "Gemarino, Jelani-Jed"
        blueteamstudents(6) = "Gomez, Caitlyn"
        blueteamstudents(7) = "Gonzalez, Julio"
        blueteamstudents(8) = "Healy, Courtney"
        blueteamstudents(9) = "Jacobs, Wi-aam"
        blueteamstudents(10) = "Jacobs, Ishtiaq"
        blueteamstudents(11) = "Jacobs, Aqeel"
        blueteamstudents(12) = "Marino, Zyrelle Queen"
        blueteamstudents(13) = "Marino, Klint John"
        blueteamstudents(14) = "Warrier, Abhishek"

        Me.cmbAddtoAll.Items.Add("Present")
        Me.cmbAddtoAll.Items.Add("Absent")
        Me.cmbAddtoAll.Items.Add("Late")
    End Sub

    Private Sub btnAssigntoAll_Click(sender As Object, e As EventArgs) Handles btnAssigntoAll.Click
        If Me.cmbAddtoAll.SelectedItem = "Present" Then
            Me.radPresentHoorAlGhaithi.Checked = True
            Me.radPresentTrishaCentino.Checked = True
            Me.radPresentAndreaGailLegaspi.Checked = True
            Me.radPresentJairaGemarino.Checked = True
            Me.radPresentAntonioAlecGemarino.Checked = True
            Me.radPresentJelaniJedGemarino.Checked = True
            Me.radPresentCaitlynGomez.Checked = True
            Me.radPresentJulioGonzalez.Checked = True
            Me.radPresentCourtneyHealy.Checked = True
            Me.radPresentWiaamJacobs.Checked = True
            Me.radPresentIshtiaqJacobs.Checked = True
            Me.radPresentAqeelJacobs.Checked = True
            Me.radPresentZyrelleQueenMarino.Checked = True
            Me.radPresentKlintJohnMarino.Checked = True
            Me.radPresentAbhishekWarrier.Checked = True
        ElseIf Me.cmbAddtoAll.SelectedItem = "Absent" Then
            Me.radAbsentHoorAlGhaithi.Checked = True
            Me.radAbsentTrishaCentino.Checked = True
            Me.radAbsentAndreaGailLegaspi.Checked = True
            Me.radAbsentJairaGemarino.Checked = True
            Me.radAbsentAntonioAlecGemarino.Checked = True
            Me.radAbsentJelaniJedGemarino.Checked = True
            Me.radAbsentCaitlynGomez.Checked = True
            Me.radAbsentJulioGonzalez.Checked = True
            Me.radAbsentCourtneyHealy.Checked = True
            Me.radAbsentWiaamJacobs.Checked = True
            Me.radAbsentIshtiaqJacobs.Checked = True
            Me.radAbsentAqeelJacobs.Checked = True
            Me.radAbsentZyrelleQueenMarino.Checked = True
            Me.radAbsentKlintJohnMarino.Checked = True
            Me.radAbsentAbhishekWarrier.Checked = True
        ElseIf Me.cmbAddtoAll.SelectedItem = "Late" Then
            Me.radLateHoorAlGhaithi.Checked = True
            Me.radLateTrishaCentino.Checked = True
            Me.radLateAndreaGailLegaspi.Checked = True
            Me.radLateJairaGemarino.Checked = True
            Me.radLateAntonioAlecGemarino.Checked = True
            Me.radLateJelaniJedGemarino.Checked = True
            Me.radLateCaitlynGomez.Checked = True
            Me.radLateJulioGonzalez.Checked = True
            Me.radLateCourtneyHealy.Checked = True
            Me.radLateWiaamJacobs.Checked = True
            Me.radLateIshtiaqJacobs.Checked = True
            Me.radLateAqeelJacobs.Checked = True
            Me.radLateZyrelleQueenMarino.Checked = True
            Me.radLateKlintJohnMarino.Checked = True
            Me.radLateAbhishekWarrier.Checked = True
        End If
    End Sub

    Private Sub lstStudents_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstStudents.SelectedIndexChanged

        If lstStudents.SelectedItem = blueteamstudents(0) Then
            picStudentPicture.SizeMode = PictureBoxSizeMode.Normal
            lblStudentName.Text = "Hoor Al Ghaithi"
            lblStudentGrade.Text = "12"
            Me.picStudentPicture.Image = My.Resources.Hoor_Al_Ghaithi
            picStudentPicture.SizeMode = PictureBoxSizeMode.StretchImage
        ElseIf lstStudents.SelectedItem = blueteamstudents(1) Then
            lblStudentName.Text = "Trisha Centino"
            Me.picStudentPicture.Image = My.Resources.Trisha_Centino
            lblStudentGrade.Text = "11"
        ElseIf lstStudents.SelectedItem = blueteamstudents(2) Then
            lblStudentName.Text = "Andrea Gail Legaspi"
            Me.picStudentPicture.Image = My.Resources.Andrea_Gail_Legaspi
            lblStudentGrade.Text = "8"
        ElseIf lstStudents.SelectedItem = blueteamstudents(3) Then
            lblStudentName.Text = "Jaira Gemarino"
            Me.picStudentPicture.Image = My.Resources.Jaira_Gemarino
            lblStudentGrade.Text = "7"
        ElseIf lstStudents.SelectedItem = blueteamstudents(4) Then
            Me.picStudentPicture.Image = My.Resources.Antonio_Alec_Gemarino
            lblStudentName.Text = "Antonio-Alec Gemarino"
            lblStudentGrade.Text = "11"
        ElseIf lstStudents.SelectedItem = blueteamstudents(5) Then
            Me.picStudentPicture.Image = My.Resources.Jelani_Jed_Gemarino
            lblStudentName.Text = "Jelani-Jed Gemarino"
            lblStudentGrade.Text = "12"
        ElseIf lstStudents.SelectedItem = blueteamstudents(6) Then
            Me.picStudentPicture.Image = My.Resources.Caitlyn_Gomez
            lblStudentName.Text = "Caitlyn Gomez"
            lblStudentGrade.Text = "9"
        ElseIf lstStudents.SelectedItem = blueteamstudents(7) Then
            Me.picStudentPicture.Image = My.Resources.Julio_Gonzalez
            lblStudentName.Text = "Julio Gomez"
            lblStudentGrade.Text = "8"
        ElseIf lstStudents.SelectedItem = blueteamstudents(8) Then
            Me.picStudentPicture.Image = My.Resources.Courtney_Healy
            lblStudentName.Text = "Courtney Healy"
            lblStudentGrade.Text = "8"
        ElseIf lstStudents.SelectedItem = blueteamstudents(11) Then
            Me.picStudentPicture.Image = My.Resources.Aqeel_Jacobs
            lblStudentName.Text = "Aqeel Jacobs"
            lblStudentGrade.Text = "12"
        ElseIf lstStudents.SelectedItem = blueteamstudents(12) Then
            Me.picStudentPicture.Image = My.Resources.Zyrelle_Queen_Marino
            lblStudentName.Text = "Zyrelle Queen Marino"
            lblStudentGrade.Text = "7"
        ElseIf lstStudents.SelectedItem = blueteamstudents(13) Then
            Me.picStudentPicture.Image = My.Resources.Klint_John_Marino
            lblStudentName.Text = "Klint John Marino"
            lblStudentGrade.Text = "10"
        ElseIf lstStudents.SelectedItem = blueteamstudents(14) Then
            Me.picStudentPicture.Image = My.Resources.Abhishek_Warrier
            lblStudentName.Text = "Abhishek Warrier"
            lblStudentGrade.Text = "8"
        ElseIf lstStudents.SelectedItem = "" Then
            Me.picStudentPicture.Image = Nothing
            lblStudentName.Text = Nothing
            lblStudentGrade.Text = Nothing
        Else
            Me.picStudentPicture.Image = My.Resources.Wi_aam_Jacobs
            lblStudentName.Text = "Wi-aam Jacobs"
            lblStudentGrade.Text = "7"
        End If
    End Sub

    Public Sub ClearorReset()
        Me.radPresentHoorAlGhaithi.Checked = False
        Me.radPresentTrishaCentino.Checked = False
        Me.radPresentAndreaGailLegaspi.Checked = False
        Me.radPresentJairaGemarino.Checked = False
        Me.radPresentAntonioAlecGemarino.Checked = False
        Me.radPresentJelaniJedGemarino.Checked = False
        Me.radPresentCaitlynGomez.Checked = False
        Me.radPresentJulioGonzalez.Checked = False
        Me.radPresentCourtneyHealy.Checked = False
        Me.radPresentWiaamJacobs.Checked = False
        Me.radPresentIshtiaqJacobs.Checked = False
        Me.radPresentAqeelJacobs.Checked = False
        Me.radPresentZyrelleQueenMarino.Checked = False
        Me.radPresentKlintJohnMarino.Checked = False
        Me.radPresentAbhishekWarrier.Checked = False

        Me.radAbsentHoorAlGhaithi.Checked = False
        Me.radAbsentTrishaCentino.Checked = False
        Me.radAbsentAndreaGailLegaspi.Checked = False
        Me.radAbsentJairaGemarino.Checked = False
        Me.radAbsentAntonioAlecGemarino.Checked = False
        Me.radAbsentJelaniJedGemarino.Checked = False
        Me.radAbsentCaitlynGomez.Checked = False
        Me.radAbsentJulioGonzalez.Checked = False
        Me.radAbsentCourtneyHealy.Checked = False
        Me.radAbsentWiaamJacobs.Checked = False
        Me.radAbsentIshtiaqJacobs.Checked = False
        Me.radAbsentAqeelJacobs.Checked = False
        Me.radAbsentZyrelleQueenMarino.Checked = False
        Me.radAbsentKlintJohnMarino.Checked = False
        Me.radAbsentAbhishekWarrier.Checked = False

        Me.radLateHoorAlGhaithi.Checked = False
        Me.radLateTrishaCentino.Checked = False
        Me.radLateAndreaGailLegaspi.Checked = False
        Me.radLateJairaGemarino.Checked = False
        Me.radLateAntonioAlecGemarino.Checked = False
        Me.radLateJelaniJedGemarino.Checked = False
        Me.radLateCaitlynGomez.Checked = False
        Me.radLateJulioGonzalez.Checked = False
        Me.radLateCourtneyHealy.Checked = False
        Me.radLateWiaamJacobs.Checked = False
        Me.radLateIshtiaqJacobs.Checked = False
        Me.radLateAqeelJacobs.Checked = False
        Me.radLateZyrelleQueenMarino.Checked = False
        Me.radLateKlintJohnMarino.Checked = False
        Me.radLateAbhishekWarrier.Checked = False

        Me.txtHoorAlGhaithiRemarks.Text = Nothing
        Me.txtTrishaCentinoRemarks.Text = Nothing
        Me.txtAndreaGailLegaspiRemarks.Text = Nothing
        Me.txtJairaGemarinoRemarks.Text = Nothing
        Me.txtAntonioAlecGemarinoRemarks.Text = Nothing
        Me.txtJelaniJedGemarinoRemarks.Text = Nothing
        Me.txtCaitlynGomezRemarks.Text = Nothing
        Me.txtJulioGonzalezRemarks.Text = Nothing
        Me.txtCourtneyHealyRemarks.Text = Nothing
        Me.txtWiaamJacobsRemarks.Text = Nothing
        Me.txtIshtiaqJacobsRemarks.Text = Nothing
        Me.txtAqeelJacobsRemarks.Text = Nothing
        Me.txtZyrelleQueenMarinoRemarks.Text = Nothing
        Me.txtKlintJohnMarinoRemarks.Text = Nothing
        Me.txtAbhishekWarrierRemarks.Text = Nothing

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
        Dim attendancerecorded(14) As String

        If Me.radPresentHoorAlGhaithi.Checked = True Then
            attendancerecorded(0) = "Present"
        ElseIf Me.radAbsentHoorAlGhaithi.Checked = True Then
            attendancerecorded(0) = "Absent"
        ElseIf Me.radLateHoorAlGhaithi.Checked = True Then
            attendancerecorded(0) = "Late"
        End If

        If Me.radPresentTrishaCentino.Checked = True Then
            attendancerecorded(1) = "Present"
        ElseIf Me.radAbsentTrishaCentino.Checked = True Then
            attendancerecorded(1) = "Absent"
        ElseIf Me.radLateTrishaCentino.Checked = True Then
            attendancerecorded(1) = "Late"
        End If

        If Me.radPresentAndreaGailLegaspi.Checked = True Then
            attendancerecorded(2) = "Present"
        ElseIf Me.radAbsentAndreaGailLegaspi.Checked = True Then
            attendancerecorded(2) = "Absent"
        ElseIf Me.radLateAndreaGailLegaspi.Checked = True Then
            attendancerecorded(2) = "Late"
        End If

        If Me.radPresentJairaGemarino.Checked = True Then
            attendancerecorded(3) = "Present"
        ElseIf Me.radAbsentJairaGemarino.Checked = True Then
            attendancerecorded(3) = "Absent"
        ElseIf Me.radLateJairaGemarino.Checked = True Then
            attendancerecorded(3) = "Late"
        End If

        If Me.radPresentAntonioAlecGemarino.Checked = True Then
            attendancerecorded(4) = "Present"
        ElseIf Me.radAbsentAntonioAlecGemarino.Checked = True Then
            attendancerecorded(4) = "Absent"
        ElseIf Me.radLateAntonioAlecGemarino.Checked = True Then
            attendancerecorded(4) = "Late"
        End If

        If Me.radPresentJelaniJedGemarino.Checked = True Then
            attendancerecorded(5) = "Present"
        ElseIf Me.radAbsentJelaniJedGemarino.Checked = True Then
            attendancerecorded(5) = "Absent"
        ElseIf Me.radLateJelaniJedGemarino.Checked = True Then
            attendancerecorded(5) = "Late"
        End If

        If Me.radPresentCaitlynGomez.Checked = True Then
            attendancerecorded(6) = "Present"
        ElseIf Me.radAbsentCaitlynGomez.Checked = True Then
            attendancerecorded(6) = "Absent"
        ElseIf Me.radLateCaitlynGomez.Checked = True Then
            attendancerecorded(6) = "Late"
        End If

        If Me.radPresentJulioGonzalez.Checked = True Then
            attendancerecorded(7) = "Present"
        ElseIf Me.radAbsentJulioGonzalez.Checked = True Then
            attendancerecorded(7) = "Absent"
        ElseIf Me.radLateJulioGonzalez.Checked = True Then
            attendancerecorded(7) = "Late"
        End If

        If Me.radPresentCourtneyHealy.Checked = True Then
            attendancerecorded(8) = "Present"
        ElseIf Me.radAbsentCourtneyHealy.Checked = True Then
            attendancerecorded(8) = "Absent"
        ElseIf Me.radLateCourtneyHealy.Checked = True Then
            attendancerecorded(8) = "Late"
        End If

        If Me.radPresentWiaamJacobs.Checked = True Then
            attendancerecorded(9) = "Present"
        ElseIf Me.radAbsentWiaamJacobs.Checked = True Then
            attendancerecorded(9) = "Absent"
        ElseIf Me.radLateWiaamJacobs.Checked = True Then
            attendancerecorded(9) = "Late"
        End If

        If Me.radPresentIshtiaqJacobs.Checked = True Then
            attendancerecorded(10) = "Present"
        ElseIf Me.radAbsentIshtiaqJacobs.Checked = True Then
            attendancerecorded(10) = "Absent"
        ElseIf Me.radLateIshtiaqJacobs.Checked = True Then
            attendancerecorded(10) = "Late"
        End If

        If Me.radPresentAqeelJacobs.Checked = True Then
            attendancerecorded(11) = "Present"
        ElseIf Me.radAbsentAqeelJacobs.Checked = True Then
            attendancerecorded(11) = "Absent"
        ElseIf Me.radLateAqeelJacobs.Checked = True Then
            attendancerecorded(11) = "Late"
        End If

        If Me.radPresentZyrelleQueenMarino.Checked = True Then
            attendancerecorded(12) = "Present"
        ElseIf Me.radAbsentZyrelleQueenMarino.Checked = True Then
            attendancerecorded(12) = "Absent"
        ElseIf Me.radLateZyrelleQueenMarino.Checked = True Then
            attendancerecorded(12) = "Late"
        End If

        If Me.radPresentKlintJohnMarino.Checked = True Then
            attendancerecorded(13) = "Present"
        ElseIf Me.radAbsentKlintJohnMarino.Checked = True Then
            attendancerecorded(13) = "Absent"
        ElseIf Me.radLateKlintJohnMarino.Checked = True Then
            attendancerecorded(13) = "Late"
        End If

        If Me.radPresentAbhishekWarrier.Checked = True Then
            attendancerecorded(14) = "Present"
        ElseIf Me.radAbsentAbhishekWarrier.Checked = True Then
            attendancerecorded(14) = "Absent"
        ElseIf Me.radLateAbhishekWarrier.Checked = True Then
            attendancerecorded(14) = "Late"
        End If

        Try
            MySqlConn.Open()
            Dim HoorAlGhaithiQuery As String
            HoorAlGhaithiQuery = "insert into abisattendancesystem.bluedolphinsrecords(idbluedolphinsrecords,Date,StudentFirstName,StudentLastName,GradeLevel,AttendanceRecorded,Comments) values (1, '" & DateTimePicker1.Text & "', 'Hoor', 'Al Ghaithi', 12 ,'" & attendancerecorded(0) & "', '" & txtHoorAlGhaithiRemarks.Text & "')"

            COMMAND = New MySqlCommand(HoorAlGhaithiQuery, MySqlConn)
            Reader = COMMAND.ExecuteReader
            MySqlConn.Close()

            MySqlConn.Open()
            Dim TrishaCentinoQuery As String
            TrishaCentinoQuery = "insert into abisattendancesystem.bluedolphinsrecords(idbluedolphinsrecords,Date,StudentFirstName,StudentLastName,GradeLevel,AttendanceRecorded,Comments) values (2, '" & DateTimePicker1.Text & "', 'Trisha', 'Centino', 11 ,'" & attendancerecorded(1) & "', '" & txtTrishaCentinoRemarks.Text & "')"

            COMMAND = New MySqlCommand(TrishaCentinoQuery, MySqlConn)
            Reader = COMMAND.ExecuteReader
            MySqlConn.Close()

            MySqlConn.Open()
            Dim AndreaGailLegaspiQuery As String
            AndreaGailLegaspiQuery = "insert into abisattendancesystem.bluedolphinsrecords(idbluedolphinsrecords,Date,StudentFirstName,StudentLastName,GradeLevel,AttendanceRecorded,Comments) values (3, '" & DateTimePicker1.Text & "', 'Andrea', 'Gail Legaspi', 8 ,'" & attendancerecorded(2) & "', '" & txtAndreaGailLegaspiRemarks.Text & "')"

            COMMAND = New MySqlCommand(AndreaGailLegaspiQuery, MySqlConn)
            Reader = COMMAND.ExecuteReader
            MySqlConn.Close()

            MySqlConn.Open()
            Dim JairaGemarinoQuery As String
            JairaGemarinoQuery = "insert into abisattendancesystem.bluedolphinsrecords(idbluedolphinsrecords,Date,StudentFirstName,StudentLastName,GradeLevel,AttendanceRecorded,Comments) values (4, '" & DateTimePicker1.Text & "', 'Jaira', 'Gemarino', 7 ,'" & attendancerecorded(3) & "', '" & txtJairaGemarinoRemarks.Text & "')"

            COMMAND = New MySqlCommand(JairaGemarinoQuery, MySqlConn)
            Reader = COMMAND.ExecuteReader
            MySqlConn.Close()

            MySqlConn.Open()
            Dim AntonioAlecGemarinoQuery As String
            AntonioAlecGemarinoQuery = "insert into abisattendancesystem.bluedolphinsrecords(idbluedolphinsrecords,Date,StudentFirstName,StudentLastName,GradeLevel,AttendanceRecorded,Comments) values (5, '" & DateTimePicker1.Text & "', 'Antonio-Alec', 'Gemarino', 11 ,'" & attendancerecorded(4) & "', '" & txtAntonioAlecGemarinoRemarks.Text & "')"

            COMMAND = New MySqlCommand(AntonioAlecGemarinoQuery, MySqlConn)
            Reader = COMMAND.ExecuteReader
            MySqlConn.Close()

            MySqlConn.Open()
            Dim JelaniJedGemarinoQuery As String
            JelaniJedGemarinoQuery = "insert into abisattendancesystem.bluedolphinsrecords(idbluedolphinsrecords,Date,StudentFirstName,StudentLastName,GradeLevel,AttendanceRecorded,Comments) values (6, '" & DateTimePicker1.Text & "', 'Jelani-Jed', 'Gemarino', 12 ,'" & attendancerecorded(5) & "', '" & txtJelaniJedGemarinoRemarks.Text & "')"

            COMMAND = New MySqlCommand(JelaniJedGemarinoQuery, MySqlConn)
            Reader = COMMAND.ExecuteReader
            MySqlConn.Close()

            MySqlConn.Open()
            Dim CaitlynGomezQuery As String
            CaitlynGomezQuery = "insert into abisattendancesystem.bluedolphinsrecords(idbluedolphinsrecords,Date,StudentFirstName,StudentLastName,GradeLevel,AttendanceRecorded,Comments) values (7, '" & DateTimePicker1.Text & "', 'Caitlyn', 'Gomez', 9 ,'" & attendancerecorded(6) & "', '" & txtCaitlynGomezRemarks.Text & "')"

            COMMAND = New MySqlCommand(CaitlynGomezQuery, MySqlConn)
            Reader = COMMAND.ExecuteReader
            MySqlConn.Close()

            MySqlConn.Open()
            Dim JulioGonzalezQuery As String
            JulioGonzalezQuery = "insert into abisattendancesystem.bluedolphinsrecords(idbluedolphinsrecords,Date,StudentFirstName,StudentLastName,GradeLevel,AttendanceRecorded,Comments) values (8, '" & DateTimePicker1.Text & "', 'Julio', 'Gonzalez', 8 ,'" & attendancerecorded(7) & "', '" & txtJulioGonzalezRemarks.Text & "')"

            COMMAND = New MySqlCommand(JulioGonzalezQuery, MySqlConn)
            Reader = COMMAND.ExecuteReader
            MySqlConn.Close()

            MySqlConn.Open()
            Dim CourtneyHealyQuery As String
            CourtneyHealyQuery = "insert into abisattendancesystem.bluedolphinsrecords(idbluedolphinsrecords,Date,StudentFirstName,StudentLastName,GradeLevel,AttendanceRecorded,Comments) values (9, '" & DateTimePicker1.Text & "', 'Courtney', 'Healy', 8 ,'" & attendancerecorded(8) & "', '" & txtCourtneyHealyRemarks.Text & "')"

            COMMAND = New MySqlCommand(CourtneyHealyQuery, MySqlConn)
            Reader = COMMAND.ExecuteReader
            MySqlConn.Close()

            MySqlConn.Open()
            Dim WiaamJacobsQuery As String
            WiaamJacobsQuery = "insert into abisattendancesystem.bluedolphinsrecords(idbluedolphinsrecords,Date,StudentFirstName,StudentLastName,GradeLevel,AttendanceRecorded,Comments) values (10, '" & DateTimePicker1.Text & "', 'Wi-aam', 'Jacobs', 7 ,'" & attendancerecorded(9) & "', '" & txtWiaamJacobsRemarks.Text & "')"

            COMMAND = New MySqlCommand(WiaamJacobsQuery, MySqlConn)
            Reader = COMMAND.ExecuteReader
            MySqlConn.Close()

            MySqlConn.Open()
            Dim IshtiaqJacobsQuery As String
            IshtiaqJacobsQuery = "insert into abisattendancesystem.bluedolphinsrecords(idbluedolphinsrecords,Date,StudentFirstName,StudentLastName,GradeLevel,AttendanceRecorded,Comments) values (11, '" & DateTimePicker1.Text & "', 'Ishtiaq', 'Jacobs', 8 ,'" & attendancerecorded(10) & "', '" & txtIshtiaqJacobsRemarks.Text & "')"

            COMMAND = New MySqlCommand(IshtiaqJacobsQuery, MySqlConn)
            Reader = COMMAND.ExecuteReader
            MySqlConn.Close()

            MySqlConn.Open()
            Dim ZyrelleQueenMarinoQuery As String
            ZyrelleQueenMarinoQuery = "insert into abisattendancesystem.bluedolphinsrecords(idbluedolphinsrecords,Date,StudentFirstName,StudentLastName,GradeLevel,AttendanceRecorded,Comments) values (12, '" & DateTimePicker1.Text & "', 'Zyrelle Queen', 'Marino', 7 ,'" & attendancerecorded(11) & "', '" & txtZyrelleQueenMarinoRemarks.Text & "')"

            COMMAND = New MySqlCommand(ZyrelleQueenMarinoQuery, MySqlConn)
            Reader = COMMAND.ExecuteReader
            MySqlConn.Close()

            MySqlConn.Open()
            Dim KlintJohnMarinoQuery As String
            KlintJohnMarinoQuery = "insert into abisattendancesystem.bluedolphinsrecords(idbluedolphinsrecords,Date,StudentFirstName,StudentLastName,GradeLevel,AttendanceRecorded,Comments) values (13, '" & DateTimePicker1.Text & "', 'Klint John', 'Marino', 10 ,'" & attendancerecorded(12) & "', '" & txtKlintJohnMarinoRemarks.Text & "')"

            COMMAND = New MySqlCommand(KlintJohnMarinoQuery, MySqlConn)
            Reader = COMMAND.ExecuteReader
            MySqlConn.Close()

            MySqlConn.Open()
            Dim AbhishekWarrierQuery As String
            AbhishekWarrierQuery = "insert into abisattendancesystem.bluedolphinsrecords(idbluedolphinsrecords,Date,StudentFirstName,StudentLastName,GradeLevel,AttendanceRecorded,Comments) values (14, '" & DateTimePicker1.Text & "', 'Abhishek', 'Warrier', 8 ,'" & attendancerecorded(13) & "', '" & txtAbhishekWarrierRemarks.Text & "')"

            COMMAND = New MySqlCommand(AbhishekWarrierQuery, MySqlConn)
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

            Dim StudentLastName(14) As String
            Dim StudentFirstName(14) As String
            Dim PresentAttendanceCount(14) As Integer
            Dim AbsentAttendanceCount(14) As Integer
            Dim LateAttendanceCount(14) As Integer

            StudentLastName(0) = "Al Ghaithi"
            StudentLastName(1) = "Centino"
            StudentLastName(2) = "Gail Legaspi"
            StudentLastName(3) = "Gemarino"
            StudentLastName(4) = "Gemarino"
            StudentLastName(5) = "Gemarino"
            StudentLastName(6) = "Gomez"
            StudentLastName(7) = "Gonzalez"
            StudentLastName(8) = "Healy"
            StudentLastName(9) = "Jacobs"
            StudentLastName(10) = "Jacobs"
            StudentLastName(11) = "Jacobs"
            StudentLastName(12) = "Marino"
            StudentLastName(13) = "Marino"
            StudentLastName(14) = "Warrier"

            StudentFirstName(0) = "Hoor"
            StudentFirstName(1) = "Trisha"
            StudentFirstName(2) = "Andrea"
            StudentFirstName(3) = "Jaira"
            StudentFirstName(4) = "Antonio-Alec"
            StudentFirstName(5) = "Jelani-Jed"
            StudentFirstName(6) = "Caitlyn"
            StudentFirstName(7) = "Julio"
            StudentFirstName(8) = "Courtney"
            StudentFirstName(9) = "Wi-aam"
            StudentFirstName(10) = "Ishtiaq"
            StudentFirstName(11) = "Aqeel"
            StudentFirstName(12) = "Zyrelle Queen"
            StudentFirstName(13) = "Klint John"
            StudentFirstName(14) = "Abhishek"

            If attendancerecorded(0) = "Present" Then
                Query1 = "select DaysPresent from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(0) & "' and StudentFirstName = '" & StudentFirstName(0) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(0) = Int(Reader.GetString("DaysPresent")) + 1
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(0) & "' and StudentFirstName = '" & StudentFirstName(0) & "'"
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
                    Query3 = "select DaysLate from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(0) & "' and StudentFirstName = '" & StudentFirstName(0) & "'"
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
                    Query4 = "update abisattendancesystem.bluedolphinsdata set idbluedolphinsdata=1,StudentFirstName='" & StudentFirstName(0) & "',StudentLastName='" & StudentLastName(0) & "',DaysPresent='" & PresentAttendanceCount(0) & "',DaysAbsent='" & AbsentAttendanceCount(0) & "',DaysLate='" & LateAttendanceCount(0) & "' where idbluedolphinsdata=1"
                    COMMAND4 = New MySqlCommand(Query4, MySqlConn)
                    Reader = COMMAND4.ExecuteReader
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try
            ElseIf attendancerecorded(0) = "Absent" Then
                Query1 = "select DaysPresent from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(0) & "' and StudentFirstName = '" & StudentFirstName(0) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(0) = Int(Reader.GetString("DaysPresent"))
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(0) & "' and StudentFirstName = '" & StudentFirstName(0) & "'"
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
                    Query3 = "select DaysLate from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(0) & "' and StudentFirstName = '" & StudentFirstName(0) & "'"
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
                    Query4 = "update abisattendancesystem.bluedolphinsdata set idbluedolphinsdata=1,StudentFirstName='" & StudentFirstName(0) & "',StudentLastName='" & StudentLastName(0) & "',DaysPresent='" & PresentAttendanceCount(0) & "',DaysAbsent='" & AbsentAttendanceCount(0) & "',DaysLate='" & LateAttendanceCount(0) & "' where idbluedolphinsdata=1"
                    COMMAND4 = New MySqlCommand(Query4, MySqlConn)
                    Reader = COMMAND4.ExecuteReader
                    MySqlConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    MySqlConn.Dispose()
                End Try
            Else
                Query1 = "select DaysPresent from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(0) & "' and StudentFirstName = '" & StudentFirstName(0) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(0) = Int(Reader.GetString("DaysPresent"))
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(0) & "' and StudentFirstName = '" & StudentFirstName(0) & "'"
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
                    Query3 = "select DaysLate from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(0) & "' and StudentFirstName = '" & StudentFirstName(0) & "'"
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
                    Query4 = "update abisattendancesystem.bluedolphinsdata set idbluedolphinsdata=1,StudentFirstName='" & StudentFirstName(0) & "',StudentLastName='" & StudentLastName(0) & "',DaysPresent='" & PresentAttendanceCount(0) & "',DaysAbsent='" & AbsentAttendanceCount(0) & "',DaysLate='" & LateAttendanceCount(0) & "' where idbluedolphinsdata=1"
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
                Query1 = "select DaysPresent from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(1) & "' and StudentFirstName = '" & StudentFirstName(1) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(1) = Int(Reader.GetString("DaysPresent")) + 1
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(1) & "' and StudentFirstName = '" & StudentFirstName(1) & "'"
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
                    Query3 = "select DaysLate from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(1) & "' and StudentFirstName = '" & StudentFirstName(1) & "'"
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
                    Query4 = "update abisattendancesystem.bluedolphinsdata set idbluedolphinsdata=2,StudentFirstName='" & StudentFirstName(1) & "',StudentLastName='" & StudentLastName(1) & "',DaysPresent='" & PresentAttendanceCount(1) & "',DaysAbsent='" & AbsentAttendanceCount(1) & "',DaysLate='" & LateAttendanceCount(1) & "' where idbluedolphinsdata=2"
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
                Query1 = "select DaysPresent from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(1) & "' and StudentFirstName = '" & StudentFirstName(1) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(1) = Int(Reader.GetString("DaysPresent"))
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(1) & "' and StudentFirstName = '" & StudentFirstName(1) & "'"
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
                    Query3 = "select DaysLate from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(1) & "' and StudentFirstName = '" & StudentFirstName(1) & "'"
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
                    Query4 = "update abisattendancesystem.bluedolphinsdata set idbluedolphinsdata=2,StudentFirstName='" & StudentFirstName(1) & "',StudentLastName='" & StudentLastName(1) & "',DaysPresent='" & PresentAttendanceCount(1) & "',DaysAbsent='" & AbsentAttendanceCount(1) & "',DaysLate='" & LateAttendanceCount(1) & "' where idbluedolphinsdata=2"
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
                Query1 = "select DaysPresent from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(1) & "' and StudentFirstName = '" & StudentFirstName(1) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(1) = Int(Reader.GetString("DaysPresent"))
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(1) & "' and StudentFirstName = '" & StudentFirstName(1) & "'"
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
                    Query3 = "select DaysLate from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(1) & "' and StudentFirstName = '" & StudentFirstName(1) & "'"
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
                    Query4 = "update abisattendancesystem.bluedolphinsdata set idbluedolphinsdata=2,StudentFirstName='" & StudentFirstName(1) & "',StudentLastName='" & StudentLastName(1) & "',DaysPresent='" & PresentAttendanceCount(1) & "',DaysAbsent='" & AbsentAttendanceCount(1) & "',DaysLate='" & LateAttendanceCount(1) & "' where idbluedolphinsdata=2"
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
                Query1 = "select DaysPresent from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(2) & "' and StudentFirstName = '" & StudentFirstName(2) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(2) = Int(Reader.GetString("DaysPresent")) + 1
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(2) & "' and StudentFirstName = '" & StudentFirstName(2) & "'"
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
                    Query3 = "select DaysLate from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(2) & "' and StudentFirstName = '" & StudentFirstName(2) & "'"
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
                    Query4 = "update abisattendancesystem.bluedolphinsdata set idbluedolphinsdata=3,StudentFirstName='" & StudentFirstName(2) & "',StudentLastName='" & StudentLastName(2) & "',DaysPresent='" & PresentAttendanceCount(2) & "',DaysAbsent='" & AbsentAttendanceCount(2) & "',DaysLate='" & LateAttendanceCount(2) & "' where idbluedolphinsdata=3"
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
                Query1 = "select DaysPresent from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(2) & "' and StudentFirstName = '" & StudentFirstName(2) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(2) = Int(Reader.GetString("DaysPresent"))
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(2) & "' and StudentFirstName = '" & StudentFirstName(2) & "'"
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
                    Query3 = "select DaysLate from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(2) & "' and StudentFirstName = '" & StudentFirstName(2) & "'"
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
                    Query4 = "update abisattendancesystem.bluedolphinsdata set idbluedolphinsdata=3,StudentFirstName='" & StudentFirstName(2) & "',StudentLastName='" & StudentLastName(2) & "',DaysPresent='" & PresentAttendanceCount(2) & "',DaysAbsent='" & AbsentAttendanceCount(2) & "',DaysLate='" & LateAttendanceCount(2) & "' where idbluedolphinsdata=3"
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
                Query1 = "select DaysPresent from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(2) & "' and StudentFirstName = '" & StudentFirstName(2) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(2) = Int(Reader.GetString("DaysPresent"))
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(2) & "' and StudentFirstName = '" & StudentFirstName(2) & "'"
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
                    Query3 = "select DaysLate from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(2) & "' and StudentFirstName = '" & StudentFirstName(2) & "'"
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
                    Query4 = "update abisattendancesystem.bluedolphinsdata set idbluedolphinsdata=3,StudentFirstName='" & StudentFirstName(2) & "',StudentLastName='" & StudentLastName(2) & "',DaysPresent='" & PresentAttendanceCount(2) & "',DaysAbsent='" & AbsentAttendanceCount(2) & "',DaysLate='" & LateAttendanceCount(2) & "' where idbluedolphinsdata=3"
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
                Query1 = "select DaysPresent from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(3) & "' and StudentFirstName = '" & StudentFirstName(3) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(3) = Int(Reader.GetString("DaysPresent")) + 1
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(3) & "' and StudentFirstName = '" & StudentFirstName(3) & "'"
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
                    Query3 = "select DaysLate from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(3) & "' and StudentFirstName = '" & StudentFirstName(3) & "'"
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
                    Query4 = "update abisattendancesystem.bluedolphinsdata set idbluedolphinsdata=4,StudentFirstName='" & StudentFirstName(3) & "',StudentLastName='" & StudentLastName(3) & "',DaysPresent='" & PresentAttendanceCount(3) & "',DaysAbsent='" & AbsentAttendanceCount(3) & "',DaysLate='" & LateAttendanceCount(3) & "' where idbluedolphinsdata=4"
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
                Query1 = "select DaysPresent from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(3) & "' and StudentFirstName = '" & StudentFirstName(3) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(3) = Int(Reader.GetString("DaysPresent"))
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(3) & "' and StudentFirstName = '" & StudentFirstName(3) & "'"
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
                    Query3 = "select DaysLate from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(3) & "' and StudentFirstName = '" & StudentFirstName(3) & "'"
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
                    Query4 = "update abisattendancesystem.bluedolphinsdata set idbluedolphinsdata=4,StudentFirstName='" & StudentFirstName(3) & "',StudentLastName='" & StudentLastName(3) & "',DaysPresent='" & PresentAttendanceCount(3) & "',DaysAbsent='" & AbsentAttendanceCount(3) & "',DaysLate='" & LateAttendanceCount(3) & "' where idbluedolphinsdata=4"
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
                Query1 = "select DaysPresent from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(3) & "' and StudentFirstName = '" & StudentFirstName(3) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(3) = Int(Reader.GetString("DaysPresent"))
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(3) & "' and StudentFirstName = '" & StudentFirstName(3) & "'"
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
                    Query3 = "select DaysLate from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(3) & "' and StudentFirstName = '" & StudentFirstName(3) & "'"
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
                    Query4 = "update abisattendancesystem.bluedolphinsdata set idbluedolphinsdata=4,StudentFirstName='" & StudentFirstName(3) & "',StudentLastName='" & StudentLastName(3) & "',DaysPresent='" & PresentAttendanceCount(3) & "',DaysAbsent='" & AbsentAttendanceCount(3) & "',DaysLate='" & LateAttendanceCount(3) & "' where idbluedolphinsdata=4"
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
                Query1 = "select DaysPresent from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(4) & "' and StudentFirstName = '" & StudentFirstName(4) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(4) = Int(Reader.GetString("DaysPresent")) + 1
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(4) & "' and StudentFirstName = '" & StudentFirstName(4) & "'"
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
                    Query3 = "select DaysLate from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(4) & "' and StudentFirstName = '" & StudentFirstName(4) & "'"
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
                    Query4 = "update abisattendancesystem.bluedolphinsdata set idbluedolphinsdata=5,StudentFirstName='" & StudentFirstName(4) & "',StudentLastName='" & StudentLastName(4) & "',DaysPresent='" & PresentAttendanceCount(4) & "',DaysAbsent='" & AbsentAttendanceCount(4) & "',DaysLate='" & LateAttendanceCount(4) & "' where idbluedolphinsdata=5"
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
                Query1 = "select DaysPresent from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(4) & "' and StudentFirstName = '" & StudentFirstName(4) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(4) = Int(Reader.GetString("DaysPresent"))
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(4) & "' and StudentFirstName = '" & StudentFirstName(4) & "'"
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
                    Query3 = "select DaysLate from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(4) & "' and StudentFirstName = '" & StudentFirstName(4) & "'"
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
                    Query4 = "update abisattendancesystem.bluedolphinsdata set idbluedolphinsdata=5,StudentFirstName='" & StudentFirstName(4) & "',StudentLastName='" & StudentLastName(4) & "',DaysPresent='" & PresentAttendanceCount(4) & "',DaysAbsent='" & AbsentAttendanceCount(4) & "',DaysLate='" & LateAttendanceCount(4) & "' where idbluedolphinsdata=5"
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
                Query1 = "select DaysPresent from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(4) & "' and StudentFirstName = '" & StudentFirstName(4) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(4) = Int(Reader.GetString("DaysPresent"))
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(4) & "' and StudentFirstName = '" & StudentFirstName(4) & "'"
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
                    Query3 = "select DaysLate from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(4) & "' and StudentFirstName = '" & StudentFirstName(4) & "'"
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
                    Query4 = "update abisattendancesystem.bluedolphinsdata set idbluedolphinsdata=5,StudentFirstName='" & StudentFirstName(4) & "',StudentLastName='" & StudentLastName(4) & "',DaysPresent='" & PresentAttendanceCount(4) & "',DaysAbsent='" & AbsentAttendanceCount(4) & "',DaysLate='" & LateAttendanceCount(4) & "' where idbluedolphinsdata=5"
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
                Query1 = "select DaysPresent from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(5) & "' and StudentFirstName = '" & StudentFirstName(5) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(5) = Int(Reader.GetString("DaysPresent")) + 1
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(5) & "' and StudentFirstName = '" & StudentFirstName(5) & "'"
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
                    Query3 = "select DaysLate from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(5) & "' and StudentFirstName = '" & StudentFirstName(5) & "'"
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
                    Query4 = "update abisattendancesystem.bluedolphinsdata set idbluedolphinsdata=6,StudentFirstName='" & StudentFirstName(5) & "',StudentLastName='" & StudentLastName(5) & "',DaysPresent='" & PresentAttendanceCount(5) & "',DaysAbsent='" & AbsentAttendanceCount(5) & "',DaysLate='" & LateAttendanceCount(5) & "' where idbluedolphinsdata=6"
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
                Query1 = "select DaysPresent from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(5) & "' and StudentFirstName = '" & StudentFirstName(5) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(5) = Int(Reader.GetString("DaysPresent"))
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(5) & "' and StudentFirstName = '" & StudentFirstName(5) & "'"
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
                    Query3 = "select DaysLate from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(5) & "' and StudentFirstName = '" & StudentFirstName(5) & "'"
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
                    Query4 = "update abisattendancesystem.bluedolphinsdata set idbluedolphinsdata=6,StudentFirstName='" & StudentFirstName(5) & "',StudentLastName='" & StudentLastName(5) & "',DaysPresent='" & PresentAttendanceCount(5) & "',DaysAbsent='" & AbsentAttendanceCount(5) & "',DaysLate='" & LateAttendanceCount(5) & "' where idbluedolphinsdata=6"
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
                Query1 = "select DaysPresent from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(5) & "' and StudentFirstName = '" & StudentFirstName(5) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(5) = Int(Reader.GetString("DaysPresent"))
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(5) & "' and StudentFirstName = '" & StudentFirstName(5) & "'"
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
                    Query3 = "select DaysLate from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(5) & "' and StudentFirstName = '" & StudentFirstName(5) & "'"
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
                    Query4 = "update abisattendancesystem.bluedolphinsdata set idbluedolphinsdata=6,StudentFirstName='" & StudentFirstName(5) & "',StudentLastName='" & StudentLastName(5) & "',DaysPresent='" & PresentAttendanceCount(5) & "',DaysAbsent='" & AbsentAttendanceCount(5) & "',DaysLate='" & LateAttendanceCount(5) & "' where idbluedolphinsdata=6"
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
                Query1 = "select DaysPresent from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(6) & "' and StudentFirstName = '" & StudentFirstName(6) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(6) = Int(Reader.GetString("DaysPresent")) + 1
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(6) & "' and StudentFirstName = '" & StudentFirstName(6) & "'"
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
                    Query3 = "select DaysLate from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(6) & "' and StudentFirstName = '" & StudentFirstName(6) & "'"
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
                    Query4 = "update abisattendancesystem.bluedolphinsdata set idbluedolphinsdata=7,StudentFirstName='" & StudentFirstName(6) & "',StudentLastName='" & StudentLastName(6) & "',DaysPresent='" & PresentAttendanceCount(6) & "',DaysAbsent='" & AbsentAttendanceCount(6) & "',DaysLate='" & LateAttendanceCount(6) & "' where idbluedolphinsdata=7"
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
                Query1 = "select DaysPresent from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(6) & "' and StudentFirstName = '" & StudentFirstName(6) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(6) = Int(Reader.GetString("DaysPresent"))
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(6) & "' and StudentFirstName = '" & StudentFirstName(6) & "'"
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
                    Query3 = "select DaysLate from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(6) & "' and StudentFirstName = '" & StudentFirstName(6) & "'"
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
                    Query4 = "update abisattendancesystem.bluedolphinsdata set idbluedolphinsdata=7,StudentFirstName='" & StudentFirstName(6) & "',StudentLastName='" & StudentLastName(6) & "',DaysPresent='" & PresentAttendanceCount(6) & "',DaysAbsent='" & AbsentAttendanceCount(6) & "',DaysLate='" & LateAttendanceCount(6) & "' where idbluedolphinsdata=7"
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
                Query1 = "select DaysPresent from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(6) & "' and StudentFirstName = '" & StudentFirstName(6) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(6) = Int(Reader.GetString("DaysPresent"))
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(6) & "' and StudentFirstName = '" & StudentFirstName(6) & "'"
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
                    Query3 = "select DaysLate from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(6) & "' and StudentFirstName = '" & StudentFirstName(6) & "'"
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
                    Query4 = "update abisattendancesystem.bluedolphinsdata set idbluedolphinsdata=7,StudentFirstName='" & StudentFirstName(6) & "',StudentLastName='" & StudentLastName(6) & "',DaysPresent='" & PresentAttendanceCount(6) & "',DaysAbsent='" & AbsentAttendanceCount(6) & "',DaysLate='" & LateAttendanceCount(6) & "' where idbluedolphinsdata=7"
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
                Query1 = "select DaysPresent from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(7) & "' and StudentFirstName = '" & StudentFirstName(7) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(7) = Int(Reader.GetString("DaysPresent")) + 1
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(7) & "' and StudentFirstName = '" & StudentFirstName(7) & "'"
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
                    Query3 = "select DaysLate from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(7) & "' and StudentFirstName = '" & StudentFirstName(7) & "'"
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
                    Query4 = "update abisattendancesystem.bluedolphinsdata set idbluedolphinsdata=8,StudentFirstName='" & StudentFirstName(7) & "',StudentLastName='" & StudentLastName(7) & "',DaysPresent='" & PresentAttendanceCount(7) & "',DaysAbsent='" & AbsentAttendanceCount(7) & "',DaysLate='" & LateAttendanceCount(7) & "' where idbluedolphinsdata=8"
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
                Query1 = "select DaysPresent from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(7) & "' and StudentFirstName = '" & StudentFirstName(7) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(7) = Int(Reader.GetString("DaysPresent"))
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(7) & "' and StudentFirstName = '" & StudentFirstName(7) & "'"
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
                    Query3 = "select DaysLate from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(7) & "' and StudentFirstName = '" & StudentFirstName(7) & "'"
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
                    Query4 = "update abisattendancesystem.bluedolphinsdata set idbluedolphinsdata=8,StudentFirstName='" & StudentFirstName(7) & "',StudentLastName='" & StudentLastName(7) & "',DaysPresent='" & PresentAttendanceCount(7) & "',DaysAbsent='" & AbsentAttendanceCount(7) & "',DaysLate='" & LateAttendanceCount(7) & "' where idbluedolphinsdata=8"
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
                Query1 = "select DaysPresent from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(7) & "' and StudentFirstName = '" & StudentFirstName(7) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(7) = Int(Reader.GetString("DaysPresent"))
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(7) & "' and StudentFirstName = '" & StudentFirstName(7) & "'"
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
                    Query3 = "select DaysLate from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(7) & "' and StudentFirstName = '" & StudentFirstName(7) & "'"
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
                    Query4 = "update abisattendancesystem.bluedolphinsdata set idbluedolphinsdata=8,StudentFirstName='" & StudentFirstName(7) & "',StudentLastName='" & StudentLastName(7) & "',DaysPresent='" & PresentAttendanceCount(7) & "',DaysAbsent='" & AbsentAttendanceCount(7) & "',DaysLate='" & LateAttendanceCount(7) & "' where idbluedolphinsdata=8"
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
                Query1 = "select DaysPresent from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(8) & "' and StudentFirstName = '" & StudentFirstName(8) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(8) = Int(Reader.GetString("DaysPresent")) + 1
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(8) & "' and StudentFirstName = '" & StudentFirstName(8) & "'"
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
                    Query3 = "select DaysLate from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(8) & "' and StudentFirstName = '" & StudentFirstName(8) & "'"
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
                    Query4 = "update abisattendancesystem.bluedolphinsdata set idbluedolphinsdata=9,StudentFirstName='" & StudentFirstName(8) & "',StudentLastName='" & StudentLastName(8) & "',DaysPresent='" & PresentAttendanceCount(8) & "',DaysAbsent='" & AbsentAttendanceCount(8) & "',DaysLate='" & LateAttendanceCount(8) & "' where idbluedolphinsdata=9"
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
                Query1 = "select DaysPresent from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(8) & "' and StudentFirstName = '" & StudentFirstName(8) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(8) = Int(Reader.GetString("DaysPresent"))
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(8) & "' and StudentFirstName = '" & StudentFirstName(8) & "'"
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
                    Query3 = "select DaysLate from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(8) & "' and StudentFirstName = '" & StudentFirstName(8) & "'"
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
                    Query4 = "update abisattendancesystem.bluedolphinsdata set idbluedolphinsdata=9,StudentFirstName='" & StudentFirstName(8) & "',StudentLastName='" & StudentLastName(8) & "',DaysPresent='" & PresentAttendanceCount(8) & "',DaysAbsent='" & AbsentAttendanceCount(8) & "',DaysLate='" & LateAttendanceCount(8) & "' where idbluedolphinsdata=9"
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
                Query1 = "select DaysPresent from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(8) & "' and StudentFirstName = '" & StudentFirstName(8) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(8) = Int(Reader.GetString("DaysPresent"))
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(8) & "' and StudentFirstName = '" & StudentFirstName(8) & "'"
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
                    Query3 = "select DaysLate from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(8) & "' and StudentFirstName = '" & StudentFirstName(8) & "'"
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
                    Query4 = "update abisattendancesystem.bluedolphinsdata set idbluedolphinsdata=9,StudentFirstName='" & StudentFirstName(8) & "',StudentLastName='" & StudentLastName(8) & "',DaysPresent='" & PresentAttendanceCount(8) & "',DaysAbsent='" & AbsentAttendanceCount(8) & "',DaysLate='" & LateAttendanceCount(8) & "' where idbluedolphinsdata=9"
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
                Query1 = "select DaysPresent from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(9) & "' and StudentFirstName = '" & StudentFirstName(9) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(9) = Int(Reader.GetString("DaysPresent")) + 1
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(9) & "' and StudentFirstName = '" & StudentFirstName(9) & "'"
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
                    Query3 = "select DaysLate from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(9) & "' and StudentFirstName = '" & StudentFirstName(9) & "'"
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
                    Query4 = "update abisattendancesystem.bluedolphinsdata set idbluedolphinsdata=10,StudentFirstName='" & StudentFirstName(9) & "',StudentLastName='" & StudentLastName(9) & "',DaysPresent='" & PresentAttendanceCount(9) & "',DaysAbsent='" & AbsentAttendanceCount(9) & "',DaysLate='" & LateAttendanceCount(9) & "' where idbluedolphinsdata=10"
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
                Query1 = "select DaysPresent from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(9) & "' and StudentFirstName = '" & StudentFirstName(9) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(9) = Int(Reader.GetString("DaysPresent"))
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(9) & "' and StudentFirstName = '" & StudentFirstName(9) & "'"
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
                    Query3 = "select DaysLate from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(9) & "' and StudentFirstName = '" & StudentFirstName(9) & "'"
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
                    Query4 = "update abisattendancesystem.bluedolphinsdata set idbluedolphinsdata=10,StudentFirstName='" & StudentFirstName(9) & "',StudentLastName='" & StudentLastName(9) & "',DaysPresent='" & PresentAttendanceCount(9) & "',DaysAbsent='" & AbsentAttendanceCount(9) & "',DaysLate='" & LateAttendanceCount(9) & "' where idbluedolphinsdata=10"
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
                Query1 = "select DaysPresent from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(9) & "' and StudentFirstName = '" & StudentFirstName(9) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(9) = Int(Reader.GetString("DaysPresent"))
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(9) & "' and StudentFirstName = '" & StudentFirstName(9) & "'"
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
                    Query3 = "select DaysLate from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(9) & "' and StudentFirstName = '" & StudentFirstName(9) & "'"
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
                    Query4 = "update abisattendancesystem.bluedolphinsdata set idbluedolphinsdata=10,StudentFirstName='" & StudentFirstName(9) & "',StudentLastName='" & StudentLastName(9) & "',DaysPresent='" & PresentAttendanceCount(9) & "',DaysAbsent='" & AbsentAttendanceCount(9) & "',DaysLate='" & LateAttendanceCount(9) & "' where idbluedolphinsdata=10"
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
                Query1 = "select DaysPresent from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(10) & "' and StudentFirstName = '" & StudentFirstName(10) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(10) = Int(Reader.GetString("DaysPresent")) + 1
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(10) & "' and StudentFirstName = '" & StudentFirstName(10) & "'"
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
                    Query3 = "select DaysLate from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(10) & "' and StudentFirstName = '" & StudentFirstName(10) & "'"
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
                    Query4 = "update abisattendancesystem.bluedolphinsdata set idbluedolphinsdata=11,StudentFirstName='" & StudentFirstName(10) & "',StudentLastName='" & StudentLastName(10) & "',DaysPresent='" & PresentAttendanceCount(10) & "',DaysAbsent='" & AbsentAttendanceCount(10) & "',DaysLate='" & LateAttendanceCount(10) & "' where idbluedolphinsdata=11"
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
                Query1 = "select DaysPresent from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(10) & "' and StudentFirstName = '" & StudentFirstName(10) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(10) = Int(Reader.GetString("DaysPresent"))
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(10) & "' and StudentFirstName = '" & StudentFirstName(10) & "'"
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
                    Query3 = "select DaysLate from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(10) & "' and StudentFirstName = '" & StudentFirstName(10) & "'"
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
                    Query4 = "update abisattendancesystem.bluedolphinsdata set idbluedolphinsdata=11,StudentFirstName='" & StudentFirstName(10) & "',StudentLastName='" & StudentLastName(10) & "',DaysPresent='" & PresentAttendanceCount(10) & "',DaysAbsent='" & AbsentAttendanceCount(10) & "',DaysLate='" & LateAttendanceCount(10) & "' where idbluedolphinsdata=11"
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
                Query1 = "select DaysPresent from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(10) & "' and StudentFirstName = '" & StudentFirstName(10) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(10) = Int(Reader.GetString("DaysPresent"))
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(10) & "' and StudentFirstName = '" & StudentFirstName(10) & "'"
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
                    Query3 = "select DaysLate from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(10) & "' and StudentFirstName = '" & StudentFirstName(10) & "'"
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
                    Query4 = "update abisattendancesystem.bluedolphinsdata set idbluedolphinsdata=11,StudentFirstName='" & StudentFirstName(10) & "',StudentLastName='" & StudentLastName(10) & "',DaysPresent='" & PresentAttendanceCount(10) & "',DaysAbsent='" & AbsentAttendanceCount(10) & "',DaysLate='" & LateAttendanceCount(10) & "' where idbluedolphinsdata=11"
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
                Query1 = "select DaysPresent from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(11) & "' and StudentFirstName = '" & StudentFirstName(11) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(11) = Int(Reader.GetString("DaysPresent")) + 1
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(11) & "' and StudentFirstName = '" & StudentFirstName(11) & "'"
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
                    Query3 = "select DaysLate from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(11) & "' and StudentFirstName = '" & StudentFirstName(11) & "'"
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
                    Query4 = "update abisattendancesystem.bluedolphinsdata set idbluedolphinsdata=12,StudentFirstName='" & StudentFirstName(11) & "',StudentLastName='" & StudentLastName(11) & "',DaysPresent='" & PresentAttendanceCount(11) & "',DaysAbsent='" & AbsentAttendanceCount(11) & "',DaysLate='" & LateAttendanceCount(11) & "' where idbluedolphinsdata=12"
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
                Query1 = "select DaysPresent from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(11) & "' and StudentFirstName = '" & StudentFirstName(11) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(11) = Int(Reader.GetString("DaysPresent"))
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(11) & "' and StudentFirstName = '" & StudentFirstName(11) & "'"
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
                    Query3 = "select DaysLate from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(11) & "' and StudentFirstName = '" & StudentFirstName(11) & "'"
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
                    Query4 = "update abisattendancesystem.bluedolphinsdata set idbluedolphinsdata=12,StudentFirstName='" & StudentFirstName(11) & "',StudentLastName='" & StudentLastName(11) & "',DaysPresent='" & PresentAttendanceCount(11) & "',DaysAbsent='" & AbsentAttendanceCount(11) & "',DaysLate='" & LateAttendanceCount(11) & "' where idbluedolphinsdata=12"
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
                Query1 = "select DaysPresent from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(11) & "' and StudentFirstName = '" & StudentFirstName(11) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(11) = Int(Reader.GetString("DaysPresent"))
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(11) & "' and StudentFirstName = '" & StudentFirstName(11) & "'"
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
                    Query3 = "select DaysLate from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(11) & "' and StudentFirstName = '" & StudentFirstName(11) & "'"
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
                    Query4 = "update abisattendancesystem.bluedolphinsdata set idbluedolphinsdata=12,StudentFirstName='" & StudentFirstName(11) & "',StudentLastName='" & StudentLastName(11) & "',DaysPresent='" & PresentAttendanceCount(11) & "',DaysAbsent='" & AbsentAttendanceCount(11) & "',DaysLate='" & LateAttendanceCount(11) & "' where idbluedolphinsdata=12"
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
                Query1 = "select DaysPresent from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(12) & "' and StudentFirstName = '" & StudentFirstName(12) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(12) = Int(Reader.GetString("DaysPresent")) + 1
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(12) & "' and StudentFirstName = '" & StudentFirstName(12) & "'"
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
                    Query3 = "select DaysLate from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(12) & "' and StudentFirstName = '" & StudentFirstName(12) & "'"
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
                    Query4 = "update abisattendancesystem.bluedolphinsdata set idbluedolphinsdata=13,StudentFirstName='" & StudentFirstName(12) & "',StudentLastName='" & StudentLastName(12) & "',DaysPresent='" & PresentAttendanceCount(12) & "',DaysAbsent='" & AbsentAttendanceCount(12) & "',DaysLate='" & LateAttendanceCount(12) & "' where idbluedolphinsdata=13"
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
                Query1 = "select DaysPresent from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(12) & "' and StudentFirstName = '" & StudentFirstName(12) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(12) = Int(Reader.GetString("DaysPresent"))
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(12) & "' and StudentFirstName = '" & StudentFirstName(12) & "'"
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
                    Query3 = "select DaysLate from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(12) & "' and StudentFirstName = '" & StudentFirstName(12) & "'"
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
                    Query4 = "update abisattendancesystem.bluedolphinsdata set idbluedolphinsdata=13,StudentFirstName='" & StudentFirstName(12) & "',StudentLastName='" & StudentLastName(12) & "',DaysPresent='" & PresentAttendanceCount(12) & "',DaysAbsent='" & AbsentAttendanceCount(12) & "',DaysLate='" & LateAttendanceCount(12) & "' where idbluedolphinsdata=13"
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
                Query1 = "select DaysPresent from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(12) & "' and StudentFirstName = '" & StudentFirstName(12) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(12) = Int(Reader.GetString("DaysPresent"))
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(12) & "' and StudentFirstName = '" & StudentFirstName(12) & "'"
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
                    Query3 = "select DaysLate from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(12) & "' and StudentFirstName = '" & StudentFirstName(12) & "'"
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
                    Query4 = "update abisattendancesystem.bluedolphinsdata set idbluedolphinsdata=13,StudentFirstName='" & StudentFirstName(12) & "',StudentLastName='" & StudentLastName(12) & "',DaysPresent='" & PresentAttendanceCount(12) & "',DaysAbsent='" & AbsentAttendanceCount(12) & "',DaysLate='" & LateAttendanceCount(12) & "' where idbluedolphinsdata=13"
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
                Query1 = "select DaysPresent from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(13) & "' and StudentFirstName = '" & StudentFirstName(13) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(13) = Int(Reader.GetString("DaysPresent")) + 1
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(13) & "' and StudentFirstName = '" & StudentFirstName(13) & "'"
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
                    Query3 = "select DaysLate from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(13) & "' and StudentFirstName = '" & StudentFirstName(13) & "'"
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
                    Query4 = "update abisattendancesystem.bluedolphinsdata set idbluedolphinsdata=14,StudentFirstName='" & StudentFirstName(13) & "',StudentLastName='" & StudentLastName(13) & "',DaysPresent='" & PresentAttendanceCount(13) & "',DaysAbsent='" & AbsentAttendanceCount(13) & "',DaysLate='" & LateAttendanceCount(13) & "' where idbluedolphinsdata=14"
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
                Query1 = "select DaysPresent from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(13) & "' and StudentFirstName = '" & StudentFirstName(13) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(13) = Int(Reader.GetString("DaysPresent"))
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(13) & "' and StudentFirstName = '" & StudentFirstName(13) & "'"
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
                    Query3 = "select DaysLate from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(13) & "' and StudentFirstName = '" & StudentFirstName(13) & "'"
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
                    Query4 = "update abisattendancesystem.bluedolphinsdata set idbluedolphinsdata=14,StudentFirstName='" & StudentFirstName(13) & "',StudentLastName='" & StudentLastName(13) & "',DaysPresent='" & PresentAttendanceCount(13) & "',DaysAbsent='" & AbsentAttendanceCount(13) & "',DaysLate='" & LateAttendanceCount(13) & "' where idbluedolphinsdata=14"
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
                Query1 = "select DaysPresent from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(13) & "' and StudentFirstName = '" & StudentFirstName(13) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(13) = Int(Reader.GetString("DaysPresent"))
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(13) & "' and StudentFirstName = '" & StudentFirstName(13) & "'"
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
                    Query3 = "select DaysLate from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(13) & "' and StudentFirstName = '" & StudentFirstName(13) & "'"
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
                    Query4 = "update abisattendancesystem.bluedolphinsdata set idbluedolphinsdata=14,StudentFirstName='" & StudentFirstName(13) & "',StudentLastName='" & StudentLastName(13) & "',DaysPresent='" & PresentAttendanceCount(13) & "',DaysAbsent='" & AbsentAttendanceCount(13) & "',DaysLate='" & LateAttendanceCount(13) & "' where idbluedolphinsdata=14"
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
                Query1 = "select DaysPresent from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(14) & "' and StudentFirstName = '" & StudentFirstName(14) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(14) = Int(Reader.GetString("DaysPresent")) + 1
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(14) & "' and StudentFirstName = '" & StudentFirstName(14) & "'"
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
                    Query3 = "select DaysLate from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(14) & "' and StudentFirstName = '" & StudentFirstName(14) & "'"
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
                    Query4 = "update abisattendancesystem.bluedolphinsdata set idbluedolphinsdata=15,StudentFirstName='" & StudentFirstName(14) & "',StudentLastName='" & StudentLastName(14) & "',DaysPresent='" & PresentAttendanceCount(14) & "',DaysAbsent='" & AbsentAttendanceCount(14) & "',DaysLate='" & LateAttendanceCount(14) & "' where idbluedolphinsdata=15"
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
                Query1 = "select DaysPresent from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(14) & "' and StudentFirstName = '" & StudentFirstName(14) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(14) = Int(Reader.GetString("DaysPresent"))
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(14) & "' and StudentFirstName = '" & StudentFirstName(14) & "'"
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
                    Query3 = "select DaysLate from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(14) & "' and StudentFirstName = '" & StudentFirstName(14) & "'"
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
                    Query4 = "update abisattendancesystem.bluedolphinsdata set idbluedolphinsdata=15,StudentFirstName='" & StudentFirstName(14) & "',StudentLastName='" & StudentLastName(14) & "',DaysPresent='" & PresentAttendanceCount(14) & "',DaysAbsent='" & AbsentAttendanceCount(14) & "',DaysLate='" & LateAttendanceCount(14) & "' where idbluedolphinsdata=15"
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
                Query1 = "select DaysPresent from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(14) & "' and StudentFirstName = '" & StudentFirstName(14) & "'"
                COMMAND1 = New MySqlCommand(Query1, MySqlConn)
                Reader = COMMAND1.ExecuteReader

                Reader.Read()
                PresentAttendanceCount(14) = Int(Reader.GetString("DaysPresent"))
                MySqlConn.Close()

                Try
                    MySqlConn.Open()
                    Query2 = "select DaysAbsent from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(14) & "' and StudentFirstName = '" & StudentFirstName(14) & "'"
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
                    Query3 = "select DaysLate from abisattendancesystem.bluedolphinsdata where StudentLastName = '" & StudentLastName(14) & "' and StudentFirstName = '" & StudentFirstName(14) & "'"
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
                    Query4 = "update abisattendancesystem.bluedolphinsdata set idbluedolphinsdata=15,StudentFirstName='" & StudentFirstName(14) & "',StudentLastName='" & StudentLastName(14) & "',DaysPresent='" & PresentAttendanceCount(14) & "',DaysAbsent='" & AbsentAttendanceCount(14) & "',DaysLate='" & LateAttendanceCount(14) & "' where idbluedolphinsdata=15"
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