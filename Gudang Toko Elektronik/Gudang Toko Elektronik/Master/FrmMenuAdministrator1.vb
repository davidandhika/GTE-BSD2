﻿Public Class FrmMenuAdministrator1 
    Public childNumber As Integer

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
            Dim frm As New FrmGudang
            frm.MdiParent = Me
            frm.Show()
            childNumber += 1
        End If
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        If IsOpen("FrmRak") = False Then
            Dim frm As New FrmRak
            frm.MdiParent = Me
            frm.Show()
            childNumber += 1
        End If
    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        If IsOpen("FrmBrand") = False Then
            Dim frm As New FrmBrand
            frm.MdiParent = Me
            frm.Show()
            childNumber += 1
        End If
    End Sub

   
    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        If IsOpen("FrmTipe") = False Then
            Dim frm As New FrmType
            frm.MdiParent = Me
            frm.Show()
            childNumber += 1
        End If
    End Sub

    Private Sub BarButtonItem5_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        If IsOpen("FrmBarang") = False Then
            Dim frm As New FrmBarang
            frm.MdiParent = Me
            frm.Show()
            childNumber += 1
        End If
    End Sub

    Private Sub BarButtonItem6_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        If IsOpen("FrmPindahRak") = False Then
            Dim frm As New FrmPindahRak
            frm.MdiParent = Me
            frm.Show()
            childNumber += 1
        End If
    End Sub


    Private Sub FrmMenuAdministrator1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Close()

    End Sub
End Class