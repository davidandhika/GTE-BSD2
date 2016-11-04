Public Class FrmMenuAwal

    Private Sub BtnMaster_Click(sender As Object, e As EventArgs) Handles BtnMaster.Click
        FrmMenuAdministrator.Show()
        Me.Hide()
    End Sub

    Private Sub BtnReport_Click(sender As Object, e As EventArgs) Handles BtnReport.Click
        'FrmReport.Show()
        Me.Hide()
    End Sub

    Private Sub close_btn_Click(sender As Object, e As EventArgs) Handles close_btn.Click
        conn.Close()
        Me.Close()
        Login.Show()
    End Sub

    Private Sub opname_btn_Click(sender As Object, e As EventArgs)
        Opname.Show()
        Me.Hide()
    End Sub
End Class