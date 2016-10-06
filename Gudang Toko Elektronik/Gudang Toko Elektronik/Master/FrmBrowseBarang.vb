Imports Oracle.DataAccess.Client
Public Class FrmBrowseBarang
    Dim rd As OracleDataReader
    Sub isiTable()
        Dim cmd As New OracleCommand("SELECT BARANG.KDBARANG,BARANG.NMBARANG,TIPE.NMTYPE,BRAND.NMBRAND,BARANG.SPESIFIKASI,BARANG.STOK FROM BARANG,TIPE,BRAND WHERE BARANG.KDTYPE=TIPE.KDTYPE AND BARANG.KDBRAND=BRAND.KDBRAND", conn)
        Dim oda As New OracleDataAdapter(cmd)
        Dim ds As New DataSet
        oda.Fill(ds, "BARANG")
        With DataGridView1
            .DataSource = ds.Tables(0)
            .Columns(0).HeaderCell.Value = "KODE BARANG"
            .Columns(1).HeaderCell.Value = "NAMA"
            .Columns(2).HeaderCell.Value = "TYPE"
            .Columns(3).HeaderCell.Value = "BRAND"
            .Columns(4).HeaderCell.Value = "SPESIFIKASI"
            .Columns(5).HeaderCell.Value = "STOK"
        End With
    End Sub
    Sub cari()
        Dim cmd As New OracleCommand("SELECT * FROM BARANG WHERE NMBARANG LIKE'%" & UCase(TextBox1.Text) & "%'", conn)
        Dim oda As New OracleDataAdapter(cmd)
        Dim ds As New DataSet
        oda.Fill(ds, "BARANG")
        With DataGridView1
            .DataSource = ds.Tables(0)
            .Columns(0).HeaderCell.Value = "KODE BARANG"
            .Columns(1).HeaderCell.Value = "NAMA"
            .Columns(2).HeaderCell.Value = "TYPE"
            .Columns(3).HeaderCell.Value = "BRAND"
            .Columns(4).HeaderCell.Value = "SPESIFIKASI"
            .Columns(5).HeaderCell.Value = "STOK"
        End With
    End Sub
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        cari()
    End Sub


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim barisdgv As Integer = e.RowIndex
        If barisdgv >= 0 Then

            FrmBarang.lblKodeBarang.Text = DataGridView1.Item(0, barisdgv).Value
            FrmBarang.txtNamaBarang.Text = DataGridView1.Item(1, barisdgv).Value
            FrmBarang.cmbNamaType.Text = DataGridView1.Item(2, barisdgv).Value
            FrmBarang.cmbNamaBrand.Text = DataGridView1.Item(3, barisdgv).Value
            FrmBarang.txtSpesifikasi.Text = DataGridView1.Item(4, barisdgv).Value
            FrmBarang.txtStok.Text = DataGridView1.Item(5, barisdgv).Value
        End If
        Me.Close()
    End Sub

    Private Sub FrmBrowseBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isiTable()

    End Sub
End Class