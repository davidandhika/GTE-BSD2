Imports CrystalDecisions.CrystalReports.Engine
Public Class FrmRptOpname
    Private Sub FrmRptOpname_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rpt As New ReportDocument
        rpt.Load("C:\Users\lol\Documents\GitHub\GTE-BSD2\Gudang Toko Elektronik\Gudang Toko Elektronik\Laporan\rptOpname.rpt")
        CrystalReportViewer1.ReportSource = rpt
    End Sub
End Class