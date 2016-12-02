Imports Oracle.DataAccess.Client
Public Class FrmBrowseRakbarang
    Dim rd As OracleDataReader

    Sub isiTable()
        Dim cmd As New OracleCommand("select* from rak_barang", conn)
        Dim oda As New OracleDataAdapter(cmd)
        Dim ds As New DataSet
        oda.Fill(ds)
        With DataGridView1
            .DataSource = ds.Tables(0)
            .Columns(0).HeaderCell.Value = "KODE RAK BARANG"
            .Columns(1).HeaderCell.Value = "KODE BARANG"
            .Columns(2).HeaderCell.Value = "NAMA RAK"
            .Columns(2).HeaderCell.Value = "NAMA LABEL"
        End With
    End Sub
    'Sub cari()
    '    'Dim cmd As New OracleCommand("SELECT rak.kdrak, rak.kdtype, tipe.nmtype FROM RAK, tipe where rak.kdtype = tipe.kdtype and tipe.nmtype LIKE'%" & UCase(TextBox1.Text) & "%'", conn)
    '    'Dim oda As New OracleDataAdapter(cmd)
    '    'Dim ds As New DataSet
    '    'oda.Fill(ds)
    '    'With DataGridView1
    '    '    .DataSource = ds.Tables(0)
    '    '    .Columns(0).HeaderCell.Value = "KODE RAK"
    '    '    .Columns(1).HeaderCell.Value = "KODE TYPE"
    '    '    .Columns(2).HeaderCell.Value = "NAMA TYPE"
    '    'End With
    'End Sub
    Private Sub FrmBrowseRak_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isiTable()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        'cari()
    End Sub

    Private Sub close_btn_Click(sender As Object, e As EventArgs) Handles close_btn.Click

        FrmPindahRak.Show()
        Me.Hide()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim barisdgv As Integer = e.RowIndex
        If barisdgv >= 0 Then
            FrmPindahRak.lblKodeRak.Text = DataGridView1.Item(0, barisdgv).Value
            FrmPindahRak.cmbKodeType.Text = DataGridView1.Item(1, barisdgv).Value
            FrmPindahRak.RAK_CB.Text = DataGridView1.Item(2, barisdgv).Value
            FrmPindahRak.TextBox1.Text = DataGridView1.Item(1, barisdgv).Value
        End If
        Me.Close()
        FrmPindahRak.Show()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class