﻿Public Class Login

    Private Sub login_btn_Click(sender As Object, e As EventArgs) Handles login_btn.Click
        If username_txt.Text = "" Or pass_txt.Text = "" Then
            MsgBox("User atau Password Tidak boleh Kosong!")
        Else
            koneksi("orcl", username_txt.Text, pass_txt.Text)
            If conn.State = ConnectionState.Open Then
                MsgBox("Selamat Datang " & username_txt.Text & "!")
                If username_txt.Text = "david" Or username_txt.Text = "DAVID" Then
                    FrmMenuAdministrator1.Show()
                    '  FrmMenuAdministrator1.RibbonPage2.Visible = False
                    FrmMenuAdministrator1.CLIENT.Visible = False
                    Me.Hide()
                Else
                    '  MainMenu_client.Show()
                    FrmMenuAdministrator1.Show()
                    FrmMenuAdministrator1.RibbonPage2.Visible = False
                    FrmMenuAdministrator1.RibbonPage1.Visible = False
                    Me.Hide()
                End If
            Else
                MsgBox("Belum berhasil masuk")
            End If
        End If
    End Sub

    Private Sub close_btn_Click(sender As Object, e As EventArgs) Handles close_btn.Click
        ' Me.Close()
        Application.Exit()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
