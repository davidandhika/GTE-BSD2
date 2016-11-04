Imports Oracle.DataAccess.Client
Public Class Opname

    Private Sub close_btn_Click(sender As Object, e As EventArgs) Handles close_btn.Click
        Me.Close()
        MainMenu_client.Show()
    End Sub

    Private Sub search_btn_Click(sender As Object, e As EventArgs) Handles search2_btn.Click
        Search.Show()
        Me.Hide()
        actual_txt.Focus()
    End Sub


    Private Sub Opname_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tgl_lbl.Text = String.Format("{0:yyyyMMdd}", DateTime.Now)
    End Sub

    Private Sub actual_txt_TextChanged(sender As Object, e As EventArgs) Handles actual_txt.TextChanged
        Dim A As Integer = CInt(actual_txt.Text)
        Dim B As Integer = CInt(stokBarang_txt.Text)

        If A > B Then
            MsgBox("Mohon Periksa kembali Inputan Data Actual!")
            actual_txt.Focus()
            actual_txt.Text = ""
            'ElseIf actual_txt.Text < stokBarang_txt.Text Then
            '   Selisih_txt.Text = CInt(stokBarang_txt.Text) - CInt(actual_txt.Text)
        Else
            'Dim selisih = CInt(Selisih_txt.Text)
            Selisih_txt.Text = CInt(stokBarang_txt.Text) - CInt(actual_txt.Text)
        End If


    End Sub

    Private Sub reset_btn_Click(sender As Object, e As EventArgs)
        Dim trans As OracleTransaction = conn.BeginTransaction
        Try
            MsgBox("Silahkan Hubungi Administrator")
            Dim cmd As New OracleCommand("insert into s_stok_opname(kdbarang,current_date,actual,selisih,status) values(:kdbarang, :tgl_stok,:actual, :selisih,:status)")
            cmd.Connection = conn
            cmd.Parameters.Add(":kdbarang", kdbarang_txt.Text)
            'cmd.Parameters.Add(":tgl_stok", CDate(tgl_lbl.Text))
            cmd.Parameters.Add(":actual", CInt(actual_txt.Text))
            cmd.Parameters.Add(":selisih", CInt(Selisih_txt.Text))
            cmd.Parameters.Add(":status", "NOT VALID")
            cmd.Parameters.Add(":tampil", 1)
            cmd.ExecuteNonQuery()
            trans.Commit()
            clear()
        Catch ex As Exception
            MsgBox(ex.Message)
            trans.Rollback()
        End Try

    End Sub

    Private Sub validity_btn_Click(sender As Object, e As EventArgs) Handles validity_btn.Click

        If CInt(Selisih_txt.Text) > 0 Then
            MsgBox("Barang Selisih!")
        Else
            Dim trans As OracleTransaction = conn.BeginTransaction
            Try

                Dim cmd As New OracleCommand("insert into s_stok_opname(kdbarang,tgl_stok,actual,selisih,status) values(:kdbarang,current_date,:actual, :selisih,:status)")
                cmd.Connection = conn
                cmd.Parameters.Add(":kdbarang", kdbarang_txt.Text)
                ' cmd.Parameters.Add(":tgl_stok", tgl_lbl.Text)
                cmd.Parameters.Add(":actual", CInt(actual_txt.Text))
                cmd.Parameters.Add(":selisih", CInt(Selisih_txt.Text))
                cmd.Parameters.Add(":status", "VALID")
                cmd.ExecuteNonQuery()
                trans.Commit()
                MsgBox("Stok Berhasil Divalidasi!")
            Catch ex As Exception
                MsgBox(ex.Message)
                trans.Rollback()
            End Try
            clear()
        End If


    End Sub
    Sub clear()
        kdbarang_txt.Text = ""
        nmbarang_txt.Text = ""
        stokBarang_txt.Text = 0
        actual_txt.Text = 0
        Selisih_txt.Text = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Search.Show()
        Me.Hide()

    End Sub
End Class