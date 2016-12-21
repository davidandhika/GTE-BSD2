Public Class Login

    Sub login()
        If username_txt.Text = "" Or pass_txt.Text = "" Then
            MsgBox("User atau Password Tidak boleh Kosong!")
        Else
            koneksi("orcl", username_txt.Text, pass_txt.Text)
            If conn.State = ConnectionState.Open Then
                splashscreen.Show()
                Me.Hide()
            Else
                MsgBox("Belum berhasil masuk")
                username_txt.Text = ""
                pass_txt.Text = ""
                username_txt.Focus()

            End If
        End If
    End Sub
    Private Sub login_btn_Click(sender As Object, e As EventArgs) Handles login_btn.Click
        login()
    End Sub

    Private Sub close_btn_Click(sender As Object, e As EventArgs) Handles close_btn.Click
        ' Me.Close()
        Application.Exit()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub pass_txt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles pass_txt.KeyPress
        If (e.KeyChar = Chr(13)) Then
            login()
        End If
    End Sub
End Class
