Public Class splashscreen
    Private Sub splashscreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(25)
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()

            If Login.username_txt.Text = "david" Or Login.username_txt.Text = "DAVID" Then
                FrmMenuAdministrator1.Show()
                FrmMenuAdministrator1.CLIENT.Visible = False
                Me.Hide()
            Else
                FrmMenuAdministrator1.Show()
                FrmMenuAdministrator1.RibbonPage2.Visible = False
                FrmMenuAdministrator1.RibbonPage1.Visible = False
                Me.Hide()
            End If
        End If
    End Sub



End Class
