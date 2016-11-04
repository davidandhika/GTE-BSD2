Public Class MainMenu_client

    Private Sub opname_btn_Click(sender As Object, e As EventArgs) Handles opname_btn.Click
        Opname.Show()
        Me.Hide()
    End Sub

    Private Sub close_btn_Click(sender As Object, e As EventArgs) Handles close_btn.Click
        Me.Hide()
        conn.Close()
        Login.username_txt.Text = ""
        Login.pass_txt.Text = ""
        Login.Show()
    End Sub

    Private Sub out_btn_Click(sender As Object, e As EventArgs) Handles out_btn.Click
        FormKeluar.Show()
        Me.Hide()
    End Sub

    Private Sub in_btn_Click(sender As Object, e As EventArgs) Handles in_btn.Click
        ' FormMasuk.Show()
        Me.Hide()
    End Sub

    Private Sub report_btn_Click(sender As Object, e As EventArgs) Handles report_btn.Click

    End Sub

    Private Sub MainMenu_client_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class