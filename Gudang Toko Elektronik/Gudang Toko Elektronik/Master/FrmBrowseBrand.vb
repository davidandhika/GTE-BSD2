Imports Oracle.DataAccess.Client
Public Class FrmBrowseBrand
    Dim rd As OracleDataReader
    Sub isiTable()
        Dim cmd As New OracleCommand("SELECT * FROM BRAND", conn)
        Dim oda As New OracleDataAdapter(cmd)
        Dim ds As New DataSet
        oda.Fill(ds)
        With DataGridView1
            .DataSource = ds.Tables(0)
            .Columns(0).HeaderCell.Value = "KODE BRAND"
            .Columns(1).HeaderCell.Value = "NAMA"
        End With
    End Sub
    Sub cari()
        Dim cmd As New OracleCommand("SELECT * FROM BRAND WHERE NMBRAND LIKE'%" & UCase(TextBox1.Text) & "%'", conn)
        Dim oda As New OracleDataAdapter(cmd)
        Dim ds As New DataSet
        oda.Fill(ds)
         With DataGridView1
            .DataSource = ds.Tables(0)
            .Columns(0).HeaderCell.Value = "KODE BRAND"
            .Columns(1).HeaderCell.Value = "NAMA"
        End With
    End Sub

    Private Sub FrmBrowseBrand_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isiTable()
    End Sub


    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        cari()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim barisdgv As Integer = e.RowIndex
        If barisdgv >= 0 Then
            FrmBrand.lblKodeBrand.Text = DataGridView1.Item(0, barisdgv).Value
            FrmBrand.txtNamaBrand.Text = DataGridView1.Item(1, barisdgv).Value
        End If
        Me.Close()
    End Sub
End Class