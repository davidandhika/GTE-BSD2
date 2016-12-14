Imports CrystalDecisions.CrystalReports.Engine
Public Class FrmRptTransKeluar

    Private Sub FrmRptTransKeluar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Me. = FormWindowState.Maximized
        Dim rpt As New rptTransKeluar
        'rpt.Load("E:\Semester Pendek 4-5\Client - Server\Proyek\Gudang Toko Elektronik\Gudang Toko Elektronik\Report\rptTransKeluar.rpt")
        CrystalReportViewer1.ReportSource = rpt
    End Sub
End Class