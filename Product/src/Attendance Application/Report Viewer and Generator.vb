Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms

Public Class Report_Viewer_and_Generator
    Dim MySqlConn As MySqlConnection

    Private Sub Report_Viewer_and_Generator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim adapter As New MySqlDataAdapter()
        Dim ds As New DataSet1

        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=127.0.0.1;userid=root;password=rp4hne1234;database=abisattendancesystem"
        adapter.SelectCommand = New MySqlCommand("select * from bluedolphinsdata", MySqlConn)

        adapter.Fill(ds.Tables(0))

        ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local

        ReportViewer1.LocalReport.ReportPath = System.Environment.CurrentDirectory & "\Report5.rdlc"

        ReportViewer1.LocalReport.DataSources.Clear()

        ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet3_DataTable1", ds.Tables(0)))

        ReportViewer1.DocumentMapCollapsed = True

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class