Imports Oracle.DataAccess.Client
Public Class FormCetakSuratJalan
    Dim ds As New DataSetSJ
    Dim da As OracleDataAdapter
    Dim selectedindex As Integer
    Dim dr As OracleDataReader

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim barisdgv As Integer = e.RowIndex
        If barisdgv >= 0 Then

            txtNamaBarang.Text = DataGridView1.Item(1, barisdgv).Value
            txtJumlah.Text = DataGridView1.Item(2, barisdgv).Value
        End If


        'Dim barisdgv As Integer = e.RowIndex
        'If barisdgv >= 0 Then
        '    Try
        '        DataGridView1.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.LightSteelBlue
        '        Dim kdtrans As String = DataGridView1.Item(1, barisdgv).Value
        '        Dim cmd As New OracleCommand("SELECT S_DETAIL_KELUAR.KDTRANSKELUAR,S_BARANG.NMBARANG,S_DETAIL_KELUAR.JUMLAH FROM S_DETAIL_KELUAR,S_BARANG WHERE S_DETAIL_KELUAR.KDBARANG=S_BARANG.KDBARANG AND KDTRANSKELUAR='" & kdtrans & "'", conn)
        '        dr = cmd.ExecuteReader
        '        While dr.Read
        '            txtNamaBarang.Text = dr.Item("NMBARANG")
        '            txtJumlah.Text = dr.Item("JUMLAH")
        '        End While
        '        dr.Close()
        '    Catch ex As Exception
        '        MsgBox(ex.Message)
        '    End Try
        'End If
    End Sub

    Private Sub close_btn_Click(sender As Object, e As EventArgs) Handles close_btn.Click
        Me.Close()
        MainMenu_client.Show()
    End Sub

    Private Sub refreshTabel()
        Try
            Dim cmd As New OracleCommand("SELECT S_DETAIL_KELUAR.KDTRANSKELUAR,S_BARANG.NMBARANG,S_DETAIL_KELUAR.JUMLAH FROM S_DETAIL_KELUAR,S_BARANG WHERE S_DETAIL_KELUAR.KDBARANG=S_BARANG.KDBARANG AND KDTRANSKELUAR='" & noTransKeluar_txt.Text & "'", conn)
            da = New OracleDataAdapter(cmd)
            da.Fill(ds)
            With DataGridView1
                .DataSource = ds.Tables(0)
                .Columns(0).HeaderText = "No. SK"
                .Columns(1).HeaderText = "Nama Barang"
                .Columns(2).HeaderText = "Jumlah"
                .Columns(0).Width = 100
                .Columns(1).Width = 350
                .Columns(2).Width = 100

            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Sub cari()
        Dim cmd As New OracleCommand("SELECT S_DETAIL_KELUAR.KDTRANSKELUAR,S_BARANG.NMBARANG,S_DETAIL_KELUAR.JUMLAH FROM S_DETAIL_KELUAR,S_BARANG WHERE S_DETAIL_KELUAR.KDBARANG=S_BARANG.KDBARANG AND KDTRANSKELUAR='" & noTransKeluar_txt.Text & "'", conn)
        Dim oda As New OracleDataAdapter(cmd)
        Dim ds As New DataSet
        oda.Fill(ds, "S_DETAIL_KELUAR")
        With DataGridView1
            .DataSource = ds.Tables(0)
            .Columns(0).HeaderText = "No. SK"
            .Columns(1).HeaderText = "Nama Barang"
            .Columns(2).HeaderText = "Jumlah"
            .Columns(0).Width = 100
            .Columns(1).Width = 350
            .Columns(2).Width = 100

        End With
    End Sub

    Private Sub noTransKeluar_txt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles noTransKeluar_txt.KeyPress
        If (e.KeyChar = Chr(13)) Then
            ' refreshTabel()
            cari()

            'Try
            '    Dim cmd As New OracleCommand("select KDTRANSKELUAR,KDBARANG,JUMLAH from S_DETAIL_KELUAR where KDTRANSKELUAR='" & noTransKeluar_txt.Text & "'", conn)
            '    da = New OracleDataAdapter(cmd)
            '    da.Fill(ds, "S_DETAIL_KELUAR")
            '    DataGridView1.DataSource = ds.Tables(0)
            'Catch ex As Exception
            '    MsgBox(ex.Message)
            'End Try

        End If

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        FrmRptSuratJalan.Show()
    End Sub

    Private Sub FormCetakSuratJalan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tgl_lbl.Text = String.Format("{0:dd/MM/yy}", DateTime.Now)


        'With DataGridView2
        '    .Columns.Add("kodesk", "No. SK")
        '    .Columns.Add("nama", "Nama Barang")
        '    .Columns.Add("jumlah", "Jumlah")
        '    .Columns(0).Width = 100
        '    .Columns(1).Width = 350
        '    .Columns(2).Width = 100
        'End With

        'Try
        '    Dim cmd As New OracleCommand("select * from S_DETAIL_KELUAR", conn)
        '    da = New OracleDataAdapter(cmd)
        '    da.Fill(ds, "S_DETAIL_KELUAR")
        '    DataGridView1.DataSource = ds.Tables(0)
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        FrmRptSuratJalan.Show()
        ' ds.Clear()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim dt As DataSetSJ.dtSJDataTable = DataSetSJ.dtSJ
        Dim dr As DataSetSJ.dtSJRow = dt.NewRow
        dr.kodesk = noTransKeluar_txt.Text
        dr.nama = txtNamaBarang.Text
        dr.jumlah = txtJumlah.Text
        dt.Rows.Add(dr)


        'Dim dt As Dslengkap.detail_keluarDataTable = Dslengkap.detail_keluar
        'Dim dr As Dslengkap.detail_keluarRow = dt.NewRow
        'dr.kdtranskeluar = noSuratJalan_txt.Text
        'dr.kdbarang = kdbarang_txt.Text
        'dr.kondisi = kondisi_cb.Text
        'dr.jumlah = jumlah_txt.Value

        'dt.Rows.Add(dr)

        'With DataGridView2
        '    .Columns.Add("kodesk", "No. SK")
        '    .Columns.Add("nama", "Nama Barang")
        '    .Columns.Add("jumlah", "Jumlah")

        'End With

        'DataGridView2.Rows.Add()
        'With DataGridView2.Rows(DataGridView2.RowCount - 1)
        '    .Cells("kodesk").Value = noTransKeluar_txt.Text
        '    .Cells("nama").Value = txtNamaBarang.Text
        '    .Cells("jumlah").Value = txtJumlah.Text
        'End With
        'DataGridView2.Rows(DataGridView2.RowCount - 1).Cells("kodesk").Value = noTransKeluar_txt.Text
        'DataGridView2.Rows(DataGridView2.RowCount - 1).Cells("nama").Value = txtNamaBarang.Text
        'DataGridView2.Rows(DataGridView2.RowCount - 1).Cells("jumlah").Value = txtJumlah.Text

        'DataGridView2.Rows(DataGridView2.RowCount - 1).Cells("kodesk").Value = noTransKeluar_txt.Text()
        'DataGridView2.Rows(DataGridView2.RowCount - 1).Cells("nama").Value = txtNamaBarang.Text()
        'DataGridView2.Rows(DataGridView2.RowCount - 1).Cells("jumlah").Value = txtJumlah.Text()
    End Sub



End Class