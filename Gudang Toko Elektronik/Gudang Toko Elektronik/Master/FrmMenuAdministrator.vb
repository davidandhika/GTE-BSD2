Public Class FrmMenuAdministrator
    Private Sub BtnType_Click(sender As Object, e As EventArgs) Handles BtnType.Click
        FrmType.Show()
        Me.Hide()
    End Sub

    Private Sub BtnBarang_Click(sender As Object, e As EventArgs) Handles BtnBarang.Click
        FrmBarang.Show()
        Me.Hide()
    End Sub

    Private Sub BtnUser_Click(sender As Object, e As EventArgs)
        'FrmUser.Show()
        Me.Hide()
    End Sub

    Private Sub BtnGudang_Click_1(sender As Object, e As EventArgs) Handles BtnGudang.Click
        FrmGudang.Show()
        Me.Hide()
    End Sub

    Private Sub BtnRak_Click_1(sender As Object, e As EventArgs) Handles BtnRak.Click
        FrmRak.Show()
        Me.Hide()
    End Sub

    Private Sub BtnBrand_Click_1(sender As Object, e As EventArgs) Handles BtnBrand.Click
        FrmBrand.Show()
        Me.Hide()
    End Sub

    Private Sub close_btn_Click(sender As Object, e As EventArgs) Handles close_btn.Click
        Me.Close()
        FrmMenuAwal.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        'FrmPindahRak.Show()
    End Sub

End Class