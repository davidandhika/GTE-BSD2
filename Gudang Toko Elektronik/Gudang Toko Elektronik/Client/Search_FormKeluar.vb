Imports Oracle.DataAccess.Client
Public Class Search_FormKeluar
    Dim ds As New DataSet
    Dim da As OracleDataAdapter
    Public isi_kdbrg = "", isi_nmbrg As String = ""
    Private Sub search_btn_Click(sender As Object, e As EventArgs) Handles search_btn.Click
        Try
            Dim cmd As New OracleCommand("select * from s_barang where kdbarang='" & TextBox2.Text & "'", conn)
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
            isi_kdbrg = DataGridView1.Item(0, barisdgv).Value.ToString()
            isi_nmbrg = DataGridView1.Item(1, barisdgv).Value.ToString()
            FormKeluar.kdbarang_txt.Text = DataGridView1.Item(0, barisdgv).Value.ToString()
            FormKeluar.nmBarang_txt.Text = DataGridView1.Item(1, barisdgv).Value.ToString()
        End If
        Me.Close()
    End Sub

    Private Sub close_btn_Click(sender As Object, e As EventArgs) Handles close_btn.Click
        Me.Close()
    End Sub

    Private Sub Search_FormKeluar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim cmd As New OracleCommand("select * from s_barang", conn)
            da = New OracleDataAdapter(cmd)
            da.Fill(ds, "s_barang")
            DataGridView1.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class