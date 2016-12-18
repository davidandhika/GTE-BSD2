Imports Oracle.DataAccess.Client

Public Class Search_Masuk
    Dim ds As New DataSet
    Dim da As OracleDataAdapter
    Sub cari()
        Dim cmd As New OracleCommand("select * from s_barang where kdbarang='" & TextBox1.Text & "'", conn)
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

    Private Sub search_btn_Click(sender As Object, e As EventArgs) Handles search_btn.Click
        
        cari()
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Try
            Dim barisdgv As Integer = e.RowIndex
            If barisdgv >= 0 Then
                FrmMenuAdministrator1.frmMasuk.kdbarang_txt.Text = DataGridView1.Item(0, barisdgv).Value
                FrmMenuAdministrator1.frmMasuk.nmBarang_txt.Text = DataGridView1.Item(1, barisdgv).Value
                FrmMenuAdministrator1.frmMasuk.spek_txt.Text = DataGridView1.Item(2, barisdgv).Value
            End If
         
        Catch ex As Exception

        End Try
        Me.Close()
        'FrmBarang.Show()
    End Sub

    Private Sub close_btn_Click(sender As Object, e As EventArgs) Handles close_btn.Click
        Me.Close()
    End Sub

    Private Sub Search_Masuk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim cmd As New OracleCommand("select * from s_barang", conn)
            da = New OracleDataAdapter(cmd)
            da.Fill(ds, "s_barang")
            DataGridView1.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Search_Masuk_TextChanged(sender As Object, e As EventArgs) Handles MyBase.TextChanged
        cari()
    End Sub
End Class