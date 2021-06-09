Imports CrystalDecisions.CrystalReports.Engine

Public Class Scoreboardreport
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim crystal As New ReportDocument
        crystal.Load("C:\Users\admin\source\repos\Global_Gaming\CrystalReport3.rpt")
        CrystalReportViewer1.ReportSource = crystal
        CrystalReportViewer1.RefreshReport()
    End Sub
End Class