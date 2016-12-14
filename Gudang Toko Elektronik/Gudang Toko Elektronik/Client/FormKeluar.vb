Imports Oracle.DataAccess.Client
Public Class FormKeluar
    Dim ds As New Dslengkap
    Dim da As OracleDataAdapter
    Dim selectedindex As Integer
    Dim dr As OracleDataReader
    Sub clearHeader()
        noSuratJalan_txt.Text = ""
        gudang_cb.Text = "--pilih--"
        rak_cb.Text = "--pilih--"
    End Sub
    Sub clearDetail()
        kdbarang_txt.Text = ""
        nmBarang_txt.Text = ""
        jumlah_txt.Value = 0
        kondisi_cb.Text = "--pilih--"
    End Sub

    Private Sub FormKeluar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clearHeader()
        clearDetail()
        tgl_lbl.Text = String.Format("{0:dd/MM/yy}", DateTime.Now)
        Try
            Dim cmd2 As New OracleCommand("select nmgudang from s_gudang", conn)
            dr = cmd2.ExecuteReader
            While dr.Read
                gudang_cb.Items.Add(dr(0))
            End While
            dr.Close()

            Dim cmd3 As New OracleCommand("select kdrak from s_rak", conn)
            dr = cmd3.ExecuteReader
            While dr.Read
                rak_cb.Items.Add(dr(0))
            End While
            dr.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub insert_btn_Click(sender As Object, e As EventArgs) Handles insert_btn.Click
        Dim dt As Dslengkap.detail_keluarDataTable = Dslengkap.detail_keluar
        Dim dr As Dslengkap.detail_keluarRow = dt.NewRow
        dr.kdtranskeluar = noSuratJalan_txt.Text
        dr.kdbarang = kdbarang_txt.Text
        dr.kondisi = kondisi_cb.Text
        dr.jumlah = jumlah_txt.Value

        dt.Rows.Add(dr)
        DataGridView1.Rows(DataGridView1.RowCount - 1).Cells(2).Value = nmBarang_txt.Text

        clearDetail()
    End Sub

    Private Sub save_btn_Click(sender As Object, e As EventArgs) Handles save_btn.Click
        Dim trans As OracleTransaction = conn.BeginTransaction
        Try

            For i As Integer = 0 To Dslengkap.detail_keluar.Rows.Count - 1
                Dim cmd2 As New OracleCommand("insert into s_detail_keluar(kdtranskeluar,kdbarang,jumlah,kondisi) values(:kdtranskeluar, :kdbarang, :jumlah,:kondisi)")

                Dim dr As Dslengkap.detail_keluarRow = Dslengkap.detail_keluar.Rows(i)
                cmd2.Connection = conn
                cmd2.Parameters.Add(":kdtranskeluar", noSuratJalan_txt.Text)
                cmd2.Parameters.Add(":kdbarang", dr.kdbarang)
                cmd2.Parameters.Add(":jumlah", dr.jumlah)
                cmd2.Parameters.Add(":kondisi", dr.kondisi)
                cmd2.ExecuteNonQuery()
            Next

            'save header
            Dim cmdheader As New OracleCommand("insert into s_trans_keluar(kdtranskeluar,kdgudang,kdrak,tgl_keluar) values(:kdtranskeluar,:kdgudang,:kdrak,current_date)")
            cmdheader.Connection = conn
            cmdheader.Parameters.Add(":kdtranskeluar", noSuratJalan_txt.Text)
            cmdheader.Parameters.Add(":kdgudang", txtKodeGudang.Text)
            cmdheader.Parameters.Add(":kdrak", rak_cb.Text)
            'cmdheader.Parameters.Add(":tgl_keluar", tgl_lbl.Text)
            cmdheader.ExecuteNonQuery()
            trans.Commit()
            ds.Clear()
            MsgBox("Simpan transaksi berhasil")
        Catch ex As Exception
            MsgBox(ex.Message)
            trans.Rollback()
        End Try
        clearDetail()
        clearHeader()
    End Sub

    Private Sub delete_btn_Click(sender As Object, e As EventArgs) Handles delete_btn.Click
        Dim dt As Dslengkap.detail_keluarDataTable = Dslengkap.detail_keluar
        dt.Rows.RemoveAt(selectedindex)
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim idx As Integer = e.RowIndex
        If DataGridView1.CurrentRow.IsNewRow Then
            MsgBox("tidak ada data terpilih")
        Else
            selectedindex = idx
        End If
    End Sub

    Private Sub close_btn_Click(sender As Object, e As EventArgs) Handles close_btn.Click
        Me.Close()
        MainMenu_client.Show()
    End Sub

    Private Sub search_btn_Click(sender As Object, e As EventArgs) Handles search_btn.Click
        Search_FormKeluar.Show()
    End Sub

    Private Sub gudang_cb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gudang_cb.SelectedIndexChanged
        Dim comboGudang As New OracleCommand("", conn)
        comboGudang.CommandText = "select kdgudang from s_gudang where nmgudang ='" & gudang_cb.Text & "'"
        dr = comboGudang.ExecuteReader
        While dr.Read
            txtKodeGudang.Text = dr(0)
        End While
        dr.Close()
    End Sub
End Class