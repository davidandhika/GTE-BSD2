Imports Oracle.DataAccess.Client
Imports CrystalDecisions.CrystalReports.Engine

Public Class FrmRptSuratJalan

    Private Sub rptSuratJalan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim rpt As New ReportDocument
        'rpt.Load("C:\Users\Fransisca Maria\Documents\GitHub\GTE-BSD2\GTE-BSD2\Gudang Toko Elektronik\Gudang Toko Elektronik\Laporan\rptSuratJalan.rpt")
        'rpt.Refresh()
        'rpt.SetParameterValue("kdtranskeluar", FormCetakSuratJalan.noTransKeluar_txt.Text)
        'CrystalReportViewer1.ReportSource = rpt

        Dim rpt As New rptSuratJalan
        rpt.SetDataSource(FormCetakSuratJalan.DataSetSJ.Tables("dtSJ"))
        rpt.SetDatabaseLogon("david", "david")
        rpt.Refresh()
        CrystalReportViewer1.ReportSource = rpt
    End Sub
End Class