Public Class FrmMenuAdministrator1 
    Public childNumber As Integer
    Public frmMasuk As FormMasuk
    Public frmKeluar As FormKeluar
    Public frmGudang As FrmGudang
    Public frmBarang As FrmBarang
    Public frmBrand As FrmBrand
    Public frmRak As FrmRak
    Public frmType As FrmType
    Public frmPindahRak As FrmPindahRak
    Public frmMasterOpname As Opname
    Public frmCetakSuratJalan As FormCetakSuratJalan
    Public frmLaporanTransKeluar As FrmRptTransKeluar
    ' Public frmLaporanTransMasuk As 
    Public frmLaporanOpname As FrmRptOpname
    Public ds As DataSetSJ

    Public Function IsOpen(ByVal nameForm As String) As Boolean
        Dim frm As Form
        For Each frm In Me.MdiChildren
            If frm.Name = nameForm Then
                frm.Activate()
                frm.WindowState = FormWindowState.Normal
                Return True
                Exit Function
            End If
        Next
        Return False
    End Function

    Private Sub FrmMenuAdministrator1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        childNumber = 0
        BarButtonItem1.Enabled = True
        BarButtonItem2.Enabled = True
        BarButtonItem3.Enabled = True
        BarButtonItem4.Enabled = True
        BarButtonItem5.Enabled = True
        BarButtonItem6.Enabled = True
    End Sub


    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        If IsOpen("FrmGudang") = False Then
            frmGudang = New FrmGudang
            frmGudang.MdiParent = Me
            frmGudang.Show()
            childNumber += 1
        End If
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        If IsOpen("FrmRak") = False Then
            frmRak = New FrmRak
            frmRak.MdiParent = Me
            frmRak.Show()
            childNumber += 1
        End If


    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        If IsOpen("FrmBrand") = False Then
            frmBrand = New FrmBrand
            frmBrand.MdiParent = Me
            frmBrand.Show()
            childNumber += 1
        End If
    End Sub


    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        If IsOpen("FrmType") = False Then
            frmType = New FrmType
            frmType.MdiParent = Me
            frmType.Show()
            childNumber += 1
        End If
    End Sub

    Private Sub BarButtonItem5_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        If IsOpen("FrmBarang") = False Then
            frmBarang = New FrmBarang
            frmBarang.MdiParent = Me
            frmBarang.Show()
            childNumber += 1
        End If
    End Sub

    Private Sub BarButtonItem6_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        If IsOpen("FrmPindahRak") = False Then
            frmPindahRak = New FrmPindahRak
            frmPindahRak.MdiParent = Me
            frmPindahRak.Show()
            childNumber += 1
        End If
    End Sub

    Private Sub FrmMenuAdministrator1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Application.Exit()
        'Me.Close()
        Login.Show()
    End Sub

    Private Sub BarButtonItem10_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem10.ItemClick
        If IsOpen("FrmRptTransKeluar") = False Then
            frmLaporanTransKeluar = New FrmRptTransKeluar
            frmLaporanTransKeluar.MdiParent = Me
            frmLaporanTransKeluar.Show()
            childNumber += 1
        End If
    End Sub

    'Private Sub BarButtonItem11_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
    '    If IsOpen("FormCetakSuratJalan") = False Then
    '        frmCetakSuratJalan = New FrmRptSuratJalan
    '        frm.MdiParent = Me
    '        frm.Show()
    '        childNumber += 1
    '    End If
    'End Sub

    Private Sub BarButtonItem12_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem12.ItemClick
        If IsOpen("FrmRptOpname") = False Then
            frmLaporanOpname = New FrmRptOpname
            frmLaporanOpname.MdiParent = Me
            frmLaporanOpname.Show()
            childNumber += 1
        End If
    End Sub

    Private Sub BarButtonItem7_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick
        If IsOpen("FormMasuk") = False Then
            frmMasuk = New FormMasuk
            frmMasuk.MdiParent = Me
            frmMasuk.Show()
            childNumber += 1
        End If
    End Sub

    Private Sub BarButtonItem8_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem8.ItemClick
        If IsOpen("FormKeluar") = False Then
<<<<<<< HEAD
            frmKeluar = New FormKeluar
            frmKeluar.MdiParent = Me
            frmKeluar.Show()
=======
            Dim frm As New FormKeluar
            frm.MdiParent = Me
            'frm.Show()
            FormKeluar.Show()
>>>>>>> origin/master
            childNumber += 1
        End If
    End Sub

    Private Sub BarButtonItem9_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem9.ItemClick
        If IsOpen("Opname") = False Then
            frmMasterOpname = New Opname
            frmMasterOpname.MdiParent = Me
            frmMasterOpname.Show()
            childNumber += 1
        End If
    End Sub

    Private Sub BarButtonItem11_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem11.ItemClick
        'If IsOpen("FormCetakSuratJalan") = False Then
        '    frmCetakSuratJalan = New FormCetakSuratJalan
        '    frmCetakSuratJalan.MdiParent = Me
        '    frmCetakSuratJalan.Show()
        '    childNumber += 1
        'End If
        FormCetakSuratJalan.Show()
    End Sub
End Class