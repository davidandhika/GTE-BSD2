Imports Oracle.DataAccess.Client
Public Class FrmBrowseType
    Dim rd As OracleDataReader

    Sub isiTable()
        Dim cmd As New OracleCommand("SELECT * FROM TIPE", conn)
        Dim oda As New OracleDataAdapter(cmd)
        Dim ds As New DataSet
        oda.Fill(ds)
        With DataGridView1
            .DataSource = ds.Tables(0)
            .Columns(0).HeaderCell.Value = "KODE TYPE"
            .Columns(1).HeaderCell.Value = "NAMA TYPE"
            .Columns(1).Width = 200
        End With
    End Sub
    Sub cari()
        Dim cmd As New OracleCommand("SELECT * FROM TIPE WHERE NMTYPE LIKE'%" & UCase(TextBox1.Text) & "%'", conn)
        Dim oda As New OracleDataAdapter(cmd)
        Dim ds As New DataSet
        oda.Fill(ds)
        With DataGridView1
            .DataSource = ds.Tables(0)
            .Columns(0).HeaderCell.Value = "KODE TYPE"
            .Columns(1).HeaderCell.Value = "NAMA TYPE"
            .Columns(1).Width = 200
        End With
    End Sub
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        cari()
    End Sub

    Private Sub FrmBrowseType_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isiTable()
    End Sub

    Private Sub close_btn_Click(sender As Object, e As EventArgs) Handles close_btn.Click
        'FrmType.Show()
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Dim barisdgv As Integer = e.RowIndex
        If barisdgv >= 0 Then

            FrmMenuAdministrator1.frmType.lblKodeType.Text = DataGridView1.Item(0, barisdgv).Value
            FrmMenuAdministrator1.frmType.txtNamaType.Text = DataGridView1.Item(1, barisdgv).Value
        End If
        Me.Close()
    End Sub
End Class