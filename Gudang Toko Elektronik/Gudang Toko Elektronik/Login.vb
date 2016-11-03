Public Class Login

    Private Sub login_btn_Click(sender As Object, e As EventArgs) Handles login_btn.Click
        koneksi("xe", username_txt.Text, pass_txt.Text)
        If conn.State = ConnectionState.Open Then
            MsgBox("Selamat Datang " & username_txt.Text & "!")
            If username_txt.Text = "david" Then
                FrmMenuAwal.Show()
                'MainMenu_client.Show()
                Me.Hide()
            Else
                'MainMenu_client.Show()
                Me.Hide()
            End If
        Else
            MsgBox("Belum berhasil masuk")
        End If
    End Sub

    Private Sub close_btn_Click(sender As Object, e As EventArgs) Handles close_btn.Click
        Me.Close()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
