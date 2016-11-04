Imports Oracle.DataAccess.Client
Public Class Search
Dim ds As New DataSet
    Dim da As OracleDataAdapter
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' conn2.Open()
            Dim cmd As New OracleCommand("select * from s_barang", conn)
            da = New OracleDataAdapter(cmd)
            da.Fill(ds, "s_barang")
            DataGridView1.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub search_btn_Click(sender As Object, e As EventArgs) Handles search_btn.Click
        Try
            Dim cmd As New OracleCommand("select * from s_barang where kdbarang='" & TextBox1.Text & "'", conn)
            da = New OracleDataAdapter(cmd)
            da.Fill(ds, "s_barang")
            DataGridView1.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Dim barisdgv As Integer = e.RowIndex
        If barisdgv >= 0 Then
            Opname.kdbarang_txt.Text = DataGridView1.Item(0, barisdgv).Value
            Opname.nmbarang_txt.Text = DataGridView1.Item(1, barisdgv).Value
            Opname.stokBarang_txt.Text = DataGridView1.Item(5, barisdgv).Value
        End If
        Me.Close()
        Opname.Show()
    End Sub

    Private Sub close_btn_Click(sender As Object, e As EventArgs) Handles close_btn.Click
        Me.Close()
    End Sub

    Sub clear()

    End Sub
End Class