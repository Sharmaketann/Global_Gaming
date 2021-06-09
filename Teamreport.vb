Imports CrystalDecisions.CrystalReports.Engine

Public Class Teamreport
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim crystal As New ReportDocument
        crystal.Load("C:\Users\admin\source\repos\Global_Gaming\CrystalReport2.rpt")
        CrystalReportViewer1.ReportSource = crystal
        CrystalReportViewer1.RefreshReport()
        crystal.Refresh()
    End Sub

    Private Sub Teamreport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
End Class