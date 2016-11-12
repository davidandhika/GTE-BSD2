Imports Oracle.DataAccess.Client
Public Class FormMasuk
    Dim ds As New Dslengkap
    Dim da As OracleDataAdapter
    Dim selectedindex As Integer
    Dim dr As OracleDataReader

    '-----
    'Sub autogenerate()
    '    Dim cmd As New OracleCommand("", conn)
    '    cmd.CommandText = "select s_generateDetailMasuk from dual "
    '    txtDetMasuk.Text = cmd.ExecuteScalar
    'End Sub

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
        satuan_cb.Text = "--pilih--"
        spek_txt.Text = ""
    End Sub

    Private Sub FormMasuk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' autogenerate()
        clearHeader()
        clearDetail()
        tgl_lbl.Text = String.Format("{0:dd/MM/yy}", DateTime.Now)
        Try
            'Dim cmd As New OracleCommand("select br.nmbarang, dm.jumlah, dm.satuan,dm.kondisi  from s_detail_masuk dm, s_barang br where dm.kdbarang=br.kdbarang and 1=2", conn)
            'da = New OracleDataAdapter(cmd)
            'da.Fill(ds, "detail_masuk")
            'DataGridView1.DataSource = ds.Tables.

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

        Dim dt As Dslengkap.detail_masukDataTable = ds1.detail_masuk
        Dim dr As Dslengkap.detail_masukRow = dt.NewRow
        dr.kdtransmasuk = noSuratJalan_txt.Text
        dr.kdbarang = kdbarang_txt.Text
        dr.kondisi = kondisi_cb.Text
        dr.jumlah = jumlah_txt.Value
        dr.satuan = satuan_cb.Text

        'dr(0) = nmBarang_txt.Text
        'dr(0) = nmBarang_txt.Text
        'dr(1) = jumlah_txt.Text
        'dr(2) = satuan_cb.Text
        'dr(3) = kondisi_cb.Text
        dt.Rows.Add(dr)
        DataGridView1.Rows(DataGridView1.RowCount - 1).Cells(2).Value = nmBarang_txt.Text
        clearDetail()
        ' clear()
    End Sub

    Private Sub close_btn_Click(sender As Object, e As EventArgs) Handles close_btn.Click
        Me.Close()
        MainMenu_client.Show()
    End Sub

    Private Sub delete_btn_Click(sender As Object, e As EventArgs) Handles delete_btn.Click
        Dim dt As Dslengkap.detail_masukDataTable = ds1.detail_masuk
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

    Private Sub search_btn_Click(sender As Object, e As EventArgs) Handles search_btn.Click
        Search_Masuk.Show()
    End Sub

    Private Sub save_btn_Click(sender As Object, e As EventArgs) Handles save_btn.Click
        Dim trans As OracleTransaction = conn.BeginTransaction
        Try

            'save detail
            'da.Update(ds.Tables("s_detail_masuk"))

            For i As Integer = 0 To ds1.detail_masuk.Rows.Count - 1
                Dim cmd2 As New OracleCommand("insert into s_detail_masuk(kdtransmasuk,kdbarang,kondisi,jumlah,satuan) values(:kdtransmasuk, :kdbarang, :kondisi,:jumlah,:satuan)")

                Dim dr As Dslengkap.detail_masukRow = ds1.detail_masuk.Rows(i)
                cmd2.Connection = conn
                cmd2.Parameters.Add(":kdtransmasuk", noSuratJalan_txt.Text)
                cmd2.Parameters.Add(":kdbarang", dr.kdbarang)
                cmd2.Parameters.Add(":kondisi", dr.kondisi)
                cmd2.Parameters.Add(":jumlah", dr.jumlah)
                cmd2.Parameters.Add(":satuan", dr.satuan)
                cmd2.ExecuteNonQuery()
            Next

            'save header
            Dim cmdheader As New OracleCommand("insert into s_trans_masuk(kdtransmasuk,kdgudang,kdrak,tgl_masuk) values(:kdtransmasuk,:kdgudang,:kdrak,current_date)")
            cmdheader.Connection = conn
            cmdheader.Parameters.Add(":kdtransmasuk", noSuratJalan_txt.Text)
            'cmdheader.Parameters.Add(":kddetmasuk", txtDetMasuk.Text)
            cmdheader.Parameters.Add(":kdgudang", txtKodeGudang.Text)
            cmdheader.Parameters.Add(":kdrak", rak_cb.Text)
            'cmdheader.Parameters.Add(":tgl", tgl_lbl.Text)
            cmdheader.ExecuteNonQuery()
            trans.Commit()
            ds.Clear()
            MsgBox("Simpan transaksi berhasil")
        Catch ex As Exception
            MsgBox(ex.Message)
            trans.Rollback()
        End Try
        clearHeader()
        clearDetail()
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

    'Private Sub rak_cb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles rak_cb.SelectedIndexChanged
    '    Dim comboRak As New OracleCommand("", conn)
    '    comboRak.CommandText = "select kdrak from s_rak where nmrak ='" & rak_cb.Text & "'"
    '    dr = comboRak.ExecuteReader
    '    While dr.Read
    '        txtKodeRak.Text = dr(0)
    '    End While
    '    dr.Close()
    'End Sub

End Class