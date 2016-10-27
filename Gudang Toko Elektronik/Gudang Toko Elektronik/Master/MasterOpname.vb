Imports Oracle.DataAccess.Client
Public Class Opname

    Private Sub close_btn_Click(sender As Object, e As EventArgs) Handles close_btn.Click
        Me.Close()
        FrmMenuAdministrator.Show()
    End Sub

    Private Sub search_btn_Click(sender As Object, e As EventArgs) Handles search_btn.Click
        Search.Show()
        Me.Hide()
        actual_txt.Focus()
    End Sub


    Private Sub Opname_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tgl_lbl.Text = String.Format("{0:dd/MM/yy}", DateTime.Now)
    End Sub
    Private Sub validity_btn_Click(sender As Object, e As EventArgs) Handles validity_btn.Click
        Try
            Dim cmd As New OracleCommand("UPDATE STOK_OPNAME SET STATUS = 'VALID' where kdbarang='" & kdbarang_txt.Text & "'", conn)
            Dim cmd2 As New OracleCommand("UPDATE BARANG SET STOK ='" & actual_txt.Text & "' where kdbarang='" & kdbarang_txt.Text & "'", conn)
            cmd.ExecuteNonQuery()
            cmd2.ExecuteNonQuery()
            MsgBox("Data Berhasil Divalidasi!")
            clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub clear()
        kdbarang_txt.Text = ""
        tanggal_txt.Text = ""
        actual_txt.Text = ""
        Selisih_txt.Text = ""
    End Sub
End Class