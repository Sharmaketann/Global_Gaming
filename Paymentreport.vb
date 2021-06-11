Imports CrystalDecisions.CrystalReports.Engine

Public Class Paymentreport
    Private Sub Paymentreport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim crystal As New ReportDocument
        crystal.Load("C:\Users\admin\source\repos\Global_Gaming\CrystalReport4.rpt")
        CrystalReportViewer1.ReportSource = crystal
        CrystalReportViewer1.RefreshReport()
        crystal.Refresh()
    End Sub
End Class