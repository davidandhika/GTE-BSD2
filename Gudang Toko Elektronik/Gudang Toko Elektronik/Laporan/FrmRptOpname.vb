Imports CrystalDecisions.CrystalReports.Engine
Public Class FrmRptOpname
    Private Sub FrmRptOpname_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rpt As New rptOpname
        'rpt.Load("path/FrmRptOpname.vb")
        rpt.Refresh()
        rpt.SetDatabaseLogon("DAVID", "DAVID")
        CrystalReportViewer1.ReportSource = rpt
    End Sub
End Class